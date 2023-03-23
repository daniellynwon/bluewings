using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1C02_PROD_RESULT_SUB : Form
    {
        public P1C02_PROD_RESULT parentWin;

        // 검색조건 거래처/영업담당/프로젝트명/현장
        public P1C02_PROD_RESULT_SUB()
        {
            InitializeComponent();
        }
        private void P1C02_PROD_RESULT_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            ListSearch();
        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));
                string sSearch = "%";

                sP_ProdOrder_QueryTableAdapter.Fill(dataSetP1C.SP_ProdOrder_Query,dtFromDate, dtToDate, sSearch);

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
            }
            catch (NullReferenceException)
            {
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #region 엔터키로 포커스 이동
        public bool NextFocus(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                return true;
            }
            return false;
        }
        private void nextFocus_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = NextFocus(sender, e);
        }
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpToDate.Value >= dtpFromDate.Value)
                ListSearch();
        }
        #endregion

        #region grid View Event
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
        private void Save()
        {
            lblMsg.Text = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];

                if (Convert.ToBoolean(chk.Value) == true)
                {
                    parentWin.dtpDate.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());
                    parentWin.tbJobNo.Text = row.Cells[2].Value.ToString();

                    parentWin.tbMachine.Text = row.Cells[4].Value.ToString();
                    parentWin.tbProd.Tag = row.Cells[7].Value.ToString();
                    parentWin.tbMachine.Tag = row.Cells[3].Value.ToString();
                    parentWin.tbProd.Text = row.Cells[8].Value.ToString();
                }
            }
            this.Dispose();

        }
        #endregion

    }
}
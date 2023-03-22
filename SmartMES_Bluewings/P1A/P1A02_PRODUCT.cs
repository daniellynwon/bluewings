using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1A02_PRODUCT : SmartMES_Bluewings.FormBasic
    {
        public P1A02_PRODUCT()
        {
            InitializeComponent();
        }
        private void P1A02_PRODUCT_Load(object sender, EventArgs e)
        {
            ListSearch();
            this.ActiveControl = tbSearch;
        }

        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sGubun = "A";
                if (rbB.Checked) sGubun = "B";
                else if (rbC.Checked) sGubun = "C";
                else if (rbD.Checked) sGubun = "D";
                else if (rbZ.Checked) sGubun = "Z";

                string sSearch = tbSearch.Text.Trim();

                sP_Product_QueryTableAdapter.Fill(dataSetP1A.SP_Product_Query, sGubun, sSearch);
                var data = dataSetP1A.SP_Product_Query;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

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

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            string sGubun = "A";
            if (rbB.Checked) sGubun = "B";
            else if (rbC.Checked) sGubun = "C";
            else if (rbD.Checked) sGubun = "D";
            else if (rbZ.Checked) sGubun = "Z";

            P1A02_PRODUCT_SUB sub = new P1A02_PRODUCT_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            if(sGubun != "A")
                sub.Size = new Size(570, 622);
            sub.gubun = sGubun;
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            //
        }
        #endregion

        #region Condition Bar Events
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 1) return;

            string sGubun = "A";
            if (rbB.Checked) sGubun = "B";
            else if (rbC.Checked) sGubun = "C";
            else if (rbD.Checked) sGubun = "D";
            else if (rbZ.Checked) sGubun = "Z";

            P1A02_PRODUCT_SUB sub = new P1A02_PRODUCT_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
            if (sGubun != "A")
                sub.Size = new Size(570, 622);
            sub.gubun = sGubun;
            sub.parentWin = this;
            sub.ShowDialog();
        }
        #endregion
    }
}

using System;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1ED03_QC_AS_DELI : Form
    {
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;

        public P1ED03_QC_AS_DELI()
        {
            InitializeComponent();
        }
        private void P1ED03_QC_AS_DELI_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Today.AddDays(-30);
            this.ActiveControl = tbSearch;
        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                if (dtFromDate > dtToDate)
                    MessageBox.Show("기간 설정이 정확하지 않습니다.\r\r다시 확인해 주세요.");

                string sSearch = tbSearch.Text.Trim();

                sP_QcAs_DeliTableAdapter.Fill(dataSetP1E.SP_QcAs_Deli, dtFromDate, dtToDate, sSearch);

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

        #region Condition Bar Events
        private void dtpDate_ValueChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 0) return;

            this.FormSendEvent(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
            this.Dispose();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}

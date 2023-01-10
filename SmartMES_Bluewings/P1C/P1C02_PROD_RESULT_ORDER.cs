using System;
using System.Linq;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1C02_PROD_RESULT_ORDER : Form
    {
        public P1C02_PROD_RESULT parentWin;
        public DateTime dtDate;
        public string sPart;
        public string sGroup;

        public P1C02_PROD_RESULT_ORDER()
        {
            InitializeComponent();
        }
        private void P1C02_PROD_RESULT_ORDER_Load(object sender, EventArgs e)
        {
            ListSearch();
            this.ActiveControl = dataGridView1;
        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                sP_ProdResult_OrderTableAdapter.Fill(dataSetP1C.SP_ProdResult_Order, dtDate);

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 0) return;

            //parentWin.tbJobNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            parentWin.dtpDate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            parentWin.tbContents.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            parentWin.tbProdCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            parentWin.timer1.Stop();
            parentWin.timer2.Stop();
            parentWin.btnStart.Tag = null;
            parentWin.btnFinish.Tag = null;
            parentWin.tbJobTime.Text = "00 : 00 : 00";
            parentWin.tbIdleTime.Text = "00 : 00 : 00";
            parentWin.tbRealDriveTime.Text = "00 : 00 : 00";

            parentWin.sP_ProdResult_IdleTableAdapter.Fill(parentWin.dataSetP1C.SP_ProdResult_Idle, DateTime.Parse("1900-01-01"));

            parentWin.dataGridView1.CurrentCell = null;
            parentWin.dataGridView1.ClearSelection();
            parentWin.lblMsg.Text = "작업시작 할 수 있습니다.";

            // 전력사용량
            parentWin.energyUseToday(DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).ToString("yyyy-MM-dd"));
            parentWin.energyUseYesterday(DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).AddDays(-1).ToString("yyyy-MM-dd"));
           
            this.Dispose();
        }
    }
}

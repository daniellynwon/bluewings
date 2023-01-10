using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1B13_STOCK_TABLE_SUB : Form
    {
        public P1B13_STOCK_TABLE parentWin;

        public P1B13_STOCK_TABLE_SUB()
        {
            InitializeComponent();
        }
        private void P1B13_STOCK_TABLE_SUB_Load(object sender, EventArgs e)
        {
            ListSearch();
            this.ActiveControl = dataGridView1;
        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DateTime dtFromDate = DateTime.Parse(parentWin.dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(parentWin.dtpToDate.Value.ToString("yyyy-MM-dd"));
                string sCode = tbProd.Tag.ToString();
                string sDepot = parentWin.cbDepot.SelectedValue.ToString();

                sP_StockTable_DayTableAdapter.Fill(dataSetP1B.SP_StockTable_Day, dtFromDate, dtToDate, sCode, sDepot);

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

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int rowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
            if (rowIndex <= 0) return;

            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

            dataGridView1[0, rowIndex].Value = rowIndex.ToString() + "일";

            //

            long iSum1 = 0, iSum2 = 0, iSum3 = 0, iSum4 = 0, iSum5 = 0;

            for (int i = 0; i < rowIndex; i++)
            {
                iSum1 += long.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                iSum2 += long.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                iSum3 += long.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                iSum4 += long.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                iSum5 += long.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());

                //

                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "0")
                    dataGridView1.Rows[i].Cells[1].Style.ForeColor = Color.Transparent;
                else
                    dataGridView1.Rows[i].Cells[1].Style.ForeColor = Color.Black;

                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "0")
                    dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Transparent;
                else
                    dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Black;

                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "0")
                    dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Transparent;
                else
                    dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Black;

                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "0")
                    dataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.Transparent;
                else
                    dataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.Black;

                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "0")
                    dataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Transparent;
                else
                    dataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Black;
            }

            dataGridView1[1, rowIndex].Value = iSum1;
            dataGridView1[2, rowIndex].Value = iSum2;
            dataGridView1[3, rowIndex].Value = iSum3;
            dataGridView1[4, rowIndex].Value = iSum4;
            dataGridView1[5, rowIndex].Value = iSum5;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}

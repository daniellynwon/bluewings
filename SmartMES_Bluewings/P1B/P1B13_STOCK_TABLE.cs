using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1B13_STOCK_TABLE : SmartMES_Bluewings.FormBasic
    {
        public P1B13_STOCK_TABLE()
        {
            InitializeComponent();
        }
        private void P1B13_STOCK_TABLE_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));

            string sql = @"select t.co_code, t.co_item
                            from(
                            select '%' as co_code, '<전체>' as co_item
                            union 
                            select co_code, co_item from tb_gi_common where co_kind = 'C') as t
                            order by t.co_code";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbKind.DataSource = table;
                cbKind.ValueMember = "co_code";
                cbKind.DisplayMember = "co_item";
            }

            sql = @"select t.co_code, t.co_item
                            from(
                            select '%' as co_code, '<전체>' as co_item
                            union 
                            select co_code, co_item from tb_gi_common where co_kind = 'B') as t
                            order by t.co_code";
            table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbDepot.DataSource = table;
                cbDepot.ValueMember = "co_code";
                cbDepot.DisplayMember = "co_item";
            }
        }
        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));
                string sSearch = tbSearch.Text.Trim();

                if (dtFromDate > dtToDate)
                    MessageBox.Show("기간 설정이 정확하지 않습니다.\r\r다시 확인해 주세요.");

                string sKind = cbKind.SelectedValue.ToString();
                string sDepot = cbDepot.SelectedValue.ToString();

                sP_StockTable_QueryTableAdapter.Fill(dataSetP1B.SP_StockTable_Query, dtFromDate, dtToDate, sKind, sDepot, sSearch);
                var data = dataSetP1B.SP_StockTable_Query;
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

        #region Condition Bar Events
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void cbKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void cbDepot_SelectedIndexChanged(object sender, EventArgs e)
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
            int rowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
            if (rowIndex <= 0) return;

            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

            dataGridView1[1, rowIndex].Value = rowIndex.ToString() + "건";

            //

            long iSum1 = 0, iSum2 = 0, iSum3 = 0, iSum4 = 0, iSum5 = 0, iSum6 = 0, iSum7 = 0, iSum8 = 0;

            for (int i = 0; i < rowIndex; i++)
            {
                iSum1 += long.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                iSum2 += long.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                iSum3 += long.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                iSum4 += long.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                iSum5 += long.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                iSum6 += long.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                iSum7 += long.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString());
                iSum8 += long.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString());

                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "0")
                    dataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.Transparent;
                else
                    dataGridView1.Rows[i].Cells[4].Style.ForeColor = Color.Gray;

                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "0")
                    dataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Transparent;
                else
                    dataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Black;

                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "0")
                    dataGridView1.Rows[i].Cells[6].Style.ForeColor = Color.Transparent;
                else
                    dataGridView1.Rows[i].Cells[6].Style.ForeColor = Color.Black;

                if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "0")
                    dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Transparent;
                else
                    dataGridView1.Rows[i].Cells[7].Style.ForeColor = Color.Black;

                if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "0")
                    dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Transparent;
                else
                    dataGridView1.Rows[i].Cells[8].Style.ForeColor = Color.Black;
            }

            dataGridView1[4, rowIndex].Value = iSum1;
            dataGridView1[5, rowIndex].Value = iSum2;
            dataGridView1[6, rowIndex].Value = iSum3;
            dataGridView1[7, rowIndex].Value = iSum4;
            dataGridView1[8, rowIndex].Value = iSum5;
            dataGridView1[9, rowIndex].Value = iSum6;
            dataGridView1[10, rowIndex].Value = iSum7;
            dataGridView1[12, rowIndex].Value = iSum8;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.RowCount - 1) return;

            if (e.ColumnIndex == 3) //품목명
            {
                P1B13_STOCK_TABLE_SUB sub = new P1B13_STOCK_TABLE_SUB();
                sub.parentWin = this;
                sub.tbProd.Tag = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                sub.tbProd.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                sub.ShowDialog();
            }
            else if (e.ColumnIndex == 9) //조정량
            {
                P1B13_STOCK_TABLE_MOVE sub = new P1B13_STOCK_TABLE_MOVE();
                sub.parentWin = this;
                sub.ShowDialog();
            }
            else if (e.ColumnIndex == 11) //단가
            {
                P1B13_STOCK_TABLE_DANGA sub = new P1B13_STOCK_TABLE_DANGA();
                sub.parentWin = this;
                sub.ShowDialog();
            }
        }
        // 자식 폼 중복 여부
        private bool formIsExist(Type tp)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == tp)
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            //
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
            if (dataGridView1.RowCount <= 1) return;

            string reportFileName = "SmartMES_Bluewings.Reports.P1B13_STOCK_TABLE.rdlc";

            string reportParm1 = "기 간 : ";
            //string reportParm2 = "분 류 : ";
            string reportParm2 = "품목명 : ";
            string reportParm3 = "재고창고 : ";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");
            //reportParm2 = reportParm2 + cbKind.Text;
            reportParm2 = reportParm2 + tbSearch.Text.Trim();
            reportParm3 = reportParm3 + cbDepot.Text;

            ViewReport_H viewReport = new ViewReport_H();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPStockTableQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex != dataGridView1.RowCount - 1)
                dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void P1B13_STOCK_TABLE_Activated(object sender, EventArgs e)
        {
            ListSearch();
        }
    }
}

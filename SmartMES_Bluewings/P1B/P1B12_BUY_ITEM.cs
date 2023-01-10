using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1B12_BUY_ITEM : SmartMES_Bluewings.FormBasic
    {
        public P1B12_BUY_ITEM()
        {
            InitializeComponent();
        }
        private void P1B12_BUY_ITEM_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
            //ListSearch();
            this.ActiveControl = tbSearch;
        }
        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sCust = "%";
                if (!string.IsNullOrEmpty(tbCust.Text)) sCust = tbCust.Tag.ToString();
                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                if (dtFromDate > dtToDate)
                    MessageBox.Show("기간 설정이 정확하지 않습니다.\r\r다시 확인해 주세요.");

                string sSearch = tbSearch.Text.Trim();

                sP_BuyItem_QueryTableAdapter.Fill(dataSetP1B.SP_BuyItem_Query, sCust, dtFromDate, dtToDate, sSearch);
                var data = dataSetP1B.SP_BuyItem_Query;
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
        private void lblCust_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            CustFinder sub = new CustFinder();
            sub.FormSendEvent += new CustFinder.FormSendDataHandler(CustEventMethod);
            sub._gubun = "023";
            sub.ShowDialog();
        }
        private void CustEventMethod(object sender)
        {
            string sCust = sender.ToString();

            if (string.IsNullOrEmpty(sCust)) return;

            tbCust.Tag = sCust.Substring(0, 7);
            tbCust.Text = sCust.Substring(8, sCust.Length - 8);

            ListSearch();
        }
        private void ubDel_Click(object sender, EventArgs e)
        {
            tbCust.Tag = null;
            tbCust.Text = string.Empty;

            ListSearch();
        }
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

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int rowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
            if (rowIndex <= 0) return;

            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

            dataGridView1[4, rowIndex].Value = rowIndex.ToString() + "건";

            //

            long iSum1 = 0, iSum2 = 0, iSum3 = 0, iSum4 = 0;

            for (int i = 0; i < rowIndex; i++)
            {
                iSum1 += long.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                iSum2 += long.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                iSum3 += long.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString());
                iSum4 += long.Parse(dataGridView1.Rows[i].Cells[11].Value.ToString());
            }

            dataGridView1[7, rowIndex].Value = iSum1;
            dataGridView1[9, rowIndex].Value = iSum2;
            dataGridView1[10, rowIndex].Value = iSum3;
            dataGridView1[11, rowIndex].Value = iSum4;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
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

            string reportFileName = "SmartMES_Bluewings.Reports.P1B12_BUY_ITEM.rdlc";

            string reportParm1 = "매입기간 : ";
            string reportParm2 = "품목명/규격 : ";
            string reportParm3 = "매입처 : ";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(tbSearch.Text.Trim())) reportParm2 = reportParm2 + "전체";
            else reportParm2 = reportParm2 + tbSearch.Text.Trim();

            if (string.IsNullOrEmpty(tbCust.Text)) reportParm2 = reportParm2 + "전체";
            else reportParm3 = reportParm3 + tbSearch.Text;

            ViewReport_V viewReport = new ViewReport_V();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPBuyItemQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

        private void P1B12_BUY_ITEM_Activated(object sender, EventArgs e)
        {
            ListSearch();
        }
    }
}

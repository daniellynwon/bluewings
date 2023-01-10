using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1A01_CUSTOMER : SmartMES_Bluewings.FormBasic
    {
        public P1A01_CUSTOMER()
        {
            InitializeComponent();
        }
        private void P1A01_CUSTOMER_Load(object sender, EventArgs e)
        {
            cbFlag.SelectedIndex = 0;
            ListSearch();

            this.ActiveControl = tbSearch;
        }

        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();
                string sFlag = "123";
                if (cbFlag.Text == "1.매출처") sFlag = "103";
                else if (cbFlag.Text == "2.매입처") sFlag = "023";

                sP_Customer_QueryTableAdapter.Fill(dataSetP1A.SP_Customer_Query, sSearch, sFlag);
                var data = dataSetP1A.SP_Customer_Query;
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
            P1A01_CUSTOMER_SUB sub = new P1A01_CUSTOMER_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
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
            string reportFileName = "SmartMES_Bluewings.Reports.P1A01_CUSTOMER.rdlc";

            string reportParm1 = "매입/매출 구분 : ";
            string reportParm2 = "거래처명/대표자/주소 : ";
            string reportParm3 = "";

            reportParm1 = reportParm1 + cbFlag.Text;
            reportParm2 = reportParm2 + tbSearch.Text.Trim();
            reportParm3 = reportParm3 + "";

            ViewReport_V viewReport = new ViewReport_V();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPCustomerQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

        #region Condition Bar Events
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        private void cbFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSearch();
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
            if (e.ColumnIndex != 3) return;

            P1A01_CUSTOMER_SUB sub = new P1A01_CUSTOMER_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        #endregion
    }
}

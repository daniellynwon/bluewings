using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1B14_UNIT_COST : SmartMES_Bluewings.FormBasic
    {
        public P1B14_UNIT_COST()
        {
            InitializeComponent();
        }
        private void P1B14_UNIT_COST_Load(object sender, EventArgs e)
        {
            ListSearch();
            this.ActiveControl = tbSearch;
        }
        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();

                sP_UnitCost_QueryTableAdapter.Fill(dataSetP1B.SP_UnitCost_Query, "0", sSearch);
                var data = dataSetP1B.SP_UnitCost_Query;
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
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (dataGridView1.RowCount < 2) return;

            //try
            //{                
            //    string sGubun = "-";
            //    string sProd = "-";
                
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        if (sGubun == row.Cells[0].Value.ToString() && sProd == row.Cells[1].Value.ToString())
            //        {
            //            sGubun = row.Cells[0].Value.ToString();
            //            sProd = row.Cells[1].Value.ToString();

            //            row.Cells[0].Value = null;
            //            row.Cells[2].Value = null;
            //            row.Cells[3].Value = null;
            //            row.Cells[4].Value = null;
            //        }
            //        else
            //        {
            //            sGubun = row.Cells[0].Value.ToString();
            //            sProd = row.Cells[1].Value.ToString();
            //        }
            //    }                
            //}
            //catch (NullReferenceException)
            //{
            //    return;
            //}
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

            string reportFileName = "SmartMES_Bluewings.Reports.P1B14_UNIT_COST.rdlc";

            string reportParm1 = "자재";
            string reportParm2 = "품목명/규격/입고처 : ";
            string reportParm3 = "";

            if (string.IsNullOrEmpty(tbSearch.Text.Trim())) reportParm2 = reportParm2 + "전체";
            else reportParm2 = reportParm2 + tbSearch.Text.Trim();

            reportParm3 = reportParm3 + "";

            ViewReport_V viewReport = new ViewReport_V();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPUnitCostQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }

        #endregion

        private void P1B14_UNIT_COST_Activated(object sender, EventArgs e)
        {
            ListSearch();
        }
    }
}

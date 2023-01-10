using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1D02_MACHINE_LIST : SmartMES_Bluewings.FormBasic
    {
        public P1D02_MACHINE_LIST()
        {
            InitializeComponent();
        }
        private void P1D02_MACHINE_LIST_Load(object sender, EventArgs e)
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

                sP_MachineCard_QueryTableAdapter.Fill(dataSetP1D.SP_MachineCard_Query, G.Pos, sSearch);
                var data = dataSetP1D.SP_MachineCard_Query;
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
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int rowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
            if (rowIndex <= 0) return;

            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

            long iSum = 0;
            string sMoney;

            for (int i = 0; i < rowIndex; i++)
            {
                sMoney = dataGridView1.Rows[i].Cells[8].Value.ToString();
                if (string.IsNullOrEmpty(sMoney)) sMoney = "0";
                iSum += long.Parse(sMoney);
            }

            dataGridView1[3, rowIndex].Value = rowIndex.ToString() + "기";
            dataGridView1[8, rowIndex].Value = iSum;
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
            string reportFileName = "SmartMES_Bluewings.Reports.P1D02_MACHINE_LIST.rdlc";

            string reportParm1 = "호기/설비명/설비그룹 : ";
            string reportParm2 = "";
            string reportParm3 = "";

            if (string.IsNullOrEmpty(tbSearch.Text.Trim())) reportParm1 = reportParm1 + "전체";
            else reportParm1 = reportParm1 + tbSearch.Text.Trim();

            reportParm2 = reportParm2 + "";
            reportParm3 = reportParm3 + "";

            ViewReport_H viewReport = new ViewReport_H();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPMachineCardQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

        private void P1D02_MACHINE_LIST_Activated(object sender, EventArgs e)
        {
            ListSearch();
        }
    }
}

using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1ED03_QC_DOC : FormBasic
    {
        public P1ED03_QC_DOC()
        {
            InitializeComponent();
        }
        private void P1ED03_QC_DOC_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
            this.ActiveControl = tbSearch;
        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                string sSearch = tbSearch.Text.Trim();
                string sClass = string.Empty;;

                if (dtFromDate > dtToDate)
                    MessageBox.Show("기간 설정이 정확하지 않습니다.\r\r다시 확인해 주세요.");

                sP_QualityDoc_ListTableAdapter.Fill(dataSetP1E.SP_QualityDoc_List, sSearch, dtFromDate, dtToDate);

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
        private void cbA_CheckedChanged(object sender, EventArgs e)
        {
            ListSearch();
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

            dataGridView1[0, rowIndex].Value = rowIndex.ToString() + "건";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (dataGridView1.RowCount <= 0) return;

            if (e.ColumnIndex == 5) // 파일1
            {
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;

                P1ED03_QC_DOC_DOC sub = new P1ED03_QC_DOC_DOC();
                sub.parentWin = this;
                sub.sNo = "1";
                sub.sParentCode = tbNo.Text;    // 문서번호
                if (doc1.Tag == null) sub.sFileName = "";
                else
                    sub.sFileName = doc1.Tag.ToString();
                sub.ShowDialog();
            }

            if (e.ColumnIndex == 6) // 파일2
            {
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;

                P1ED03_QC_DOC_DOC sub = new P1ED03_QC_DOC_DOC();
                sub.parentWin = this;
                sub.sNo = "2";
                sub.sParentCode = tbNo.Text;    // 문서번호
                if (doc2.Tag == null) sub.sFileName = "";
                else
                    sub.sFileName = doc2.Tag.ToString();
                sub.ShowDialog();
            }
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            //P1ED03_QC_DOC_SUB sub = new P1ED03_QC_DOC_SUB();
            //sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            //sub.parentWin = this;
            //sub.ShowDialog();
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

            string reportFileName = "SmartMES_Bluewings.Reports.P1ED03_QC_DOC.rdlc";

            string reportParm1 = "검사기간 : ";
            string reportParm2 = " ";
            string reportParm3 = " ";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");

            ViewReport_H viewReport = new ViewReport_H();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds1 = new ReportDataSource("DataSet1", sPQcClassQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds1);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

    }
}

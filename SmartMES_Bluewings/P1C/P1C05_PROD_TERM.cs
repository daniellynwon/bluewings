using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1C05_PROD_TERM : SmartMES_Bluewings.FormBasic
    {
        public P1C05_PROD_TERM()
        {
            InitializeComponent();
        }
        private void P1C05_PROD_TERM_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
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

                sP_ProdTerm_QueryTableAdapter.Fill(dataSetP1C.SP_ProdTerm_Query, dtFromDate, dtToDate, sSearch);

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
                var data = dataSetP1C.SP_ProdTerm_Query;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가
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

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int rowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
            if (rowIndex <= 0) return;

            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

            dataGridView1[2, rowIndex].Value = rowIndex.ToString() + "건";

            long iSum1 = 0; long iSum2 = 0; long iSum3 = 0;

            for (int i = 0; i < rowIndex; i++)
            {
                iSum1 += long.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString());
                iSum2 += long.Parse(dataGridView1.Rows[i].Cells[13].Value.ToString());
                iSum3 += long.Parse(dataGridView1.Rows[i].Cells[14].Value.ToString());
            }

            dataGridView1[12, rowIndex].Value = iSum1;
            dataGridView1[13, rowIndex].Value = iSum2;
            dataGridView1[14, rowIndex].Value = iSum3;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible) == e.RowIndex) return;
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 0) return;

            string sNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            P1C02_PROD_RESULT form = new P1C02_PROD_RESULT();

            if (formIsExist(form.GetType()))
            {
                form.Dispose();
            }
            else
            {
                MDIForm parent = (MDIForm)this.MdiParent;
                form.MdiParent = parent;
                form.Dock = DockStyle.Fill;
                form.Show();
                form.ListSearch1();

                for (int i = 0; i < form.dataGridViewList.Rows.Count; i++)
                {
                    if (form.dataGridViewList.Rows[i].Cells[0].Value.ToString() == sNo)
                    {
                        form.dataGridViewList.CurrentCell = form.dataGridViewList[0, i];
                        form.dataGridViewList.CurrentCell.Selected = true;

                        form.ListSearch2(i);
                        break;
                    }
                }
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

            string reportFileName = "SmartMES_Bluewings.Reports.P1C05_PROD_TERM.rdlc";

            string reportParm1 = "생산기간 : ";
            string reportParm2 = "품목명 : ";
            string reportParm3 = "";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");
            reportParm2 = reportParm2 + tbSearch.Text.Trim();

            ViewReport_V viewReport = new ViewReport_V();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds1 = new ReportDataSource("DataSet1", sPProdTermQueryBindingSource);
            ReportDataSource rds2 = new ReportDataSource("DataSet2", sPProdTermMaterialBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds1);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds2);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

        #region other functions
        private void P1C05_PROD_TERM_Activated(object sender, EventArgs e)
        {
            ListSearch();
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
    }
}

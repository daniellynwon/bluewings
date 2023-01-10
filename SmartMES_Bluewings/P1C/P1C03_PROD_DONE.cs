using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1C03_PROD_DONE : SmartMES_Bluewings.FormBasic
    {
        public P1C03_PROD_DONE()
        {
            InitializeComponent();
        }
        private void P1C03_PROD_DONE_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
        }
        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sFrom = dtpFromDate.Value.ToString("yyyy-MM-dd");
                string sTo = dtpToDate.Value.ToString("yyyy-MM-dd");

                sP_ProdDone_QueryTableAdapter.Fill(dataSetP1C.SP_ProdDone_Query, DateTime.Parse(sFrom), DateTime.Parse(sTo));

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
                var data = dataSetP1C.SP_ProdDone_Query;
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
        #endregion        

        #region GridView Events
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (dataGridView1.RowCount <= 1) return;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible) == e.RowIndex) return;
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 0) return;

            string sDate = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).ToString("yyyy-MM-dd");
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
                    if (DateTime.Parse(form.dataGridViewList.Rows[i].Cells[0].Value.ToString()).ToString("yyyy-MM-dd") == sDate)
                    {
                        form.dataGridViewList.CurrentCell = form.dataGridViewList[0, i];
                        form.dataGridViewList.CurrentCell.Selected = true;

                        form.ListSearch2(i);
                        break;
                    }
                }
            }
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int rowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
            if (rowIndex <= 0) return;

            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

            //dataGridView1[0, rowIndex].Value = rowIndex.ToString() + "건";

            float fSum1 = 0, fSum2 = 0, fSum3 = 0;

            for (int i = 0; i < rowIndex; i++)
            {
                fSum1 += float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                fSum2 += float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                fSum3 += float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }

            dataGridView1[1, rowIndex].Value = fSum1;
            dataGridView1[2, rowIndex].Value = fSum2;
            dataGridView1[4, rowIndex].Value = fSum3;
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

            string reportFileName = "SmartMES_Bluewings.Reports.P1C03_PROD_DONE.rdlc";

            string reportParm1 = "생산기간 : ";
            string reportParm2 = "";
            string reportParm3 = "";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");
            //reportParm2 = reportParm2 + cbPart.Text;

            ViewReport_H viewReport = new ViewReport_H();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPProdDoneQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }

        #endregion

        private void P1C03_PROD_DONE_Activated(object sender, EventArgs e)
        {
            ListSearch();
        }
    }
}

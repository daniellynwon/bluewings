using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using SmartFactory;
using System.Drawing;

namespace SmartMES_Bluewings
{
    public partial class P1ED03_DEFECT_LIST : SmartMES_Bluewings.FormBasic
    {
        public P1ED03_DEFECT_LIST()
        {
            InitializeComponent();
        }
        private void P1ED03_DEFECT_LIST_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
            this.ActiveControl = tbSearch;
        }
        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                if (dtFromDate > dtToDate)
                    MessageBox.Show("기간 설정이 정확하지 않습니다.\r\r다시 확인해 주세요.");

                string sSearch = tbSearch.Text.Trim();

                sP_Qc_QueryTableAdapter.Fill(dataSetP1E.SP_Qc_Query, sSearch, dtFromDate, dtToDate);
                var data = dataSetP1E.SP_Qc_Query;
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
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        #endregion

        #region GridView Events
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 2) return;

            //string sNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //P1ED01_QC_FINAL form = new P1ED01_QC_FINAL();

            //if (formIsExist(form.GetType()))
            //{
            //    form.Dispose();
            //}
            //else
            //{
            //    MDIForm parent = (MDIForm)this.MdiParent;
            //    form.MdiParent = parent;
            //    form.Dock = DockStyle.Fill;
            //    form.Show();

            //    form.dtpJobDate.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            //    form.dtpToDate.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            //    form.tbCust.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    form.tbProd.Text = "";   // 두 건 이상일 때, 다 나오게 하려고 빈칸.
            //    form.ListSearch1();

            //    for (int i = 0; i < form.dataGridViewList.Rows.Count; i++)
            //    {
            //        if (form.dataGridViewList.Rows[i].Cells[0].Value.ToString() == sNo)
            //        {
            //            form.dataGridViewList.CurrentCell = form.dataGridViewList[1, i];
            //            form.dataGridViewList.CurrentCell.Selected = true;

            //            //form.ListSearch2(sNo);
            //            break;
            //        }
            //    }
            //}
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
            if (dataGridView1.RowCount <= 0) return;

            string reportFileName = "SmartMES_Bluewings.Reports.P1ED03_DEFECT_LIST.rdlc";

            string reportParm1 = "검사기간 : ";
            string reportParm2 = "거래처명/현장정보 : ";
            string reportParm3 = "";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(tbSearch.Text.Trim())) reportParm2 = reportParm2 + "전체";
            else reportParm2 = reportParm2 + tbSearch.Text.Trim();

            ViewReport_H viewReport = new ViewReport_H();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPQcQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

        #region Cell Paint
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;
            string[] strHeaders = { "관벽두께(mm)", "최소내벽두께(mm)", "평균안지름(mm)", "제품길이(mm)" };
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // Category Painting 헤더 그리는 부분
            {
                //--------------------------------- 범위 지정
                Rectangle r1 = gv.GetCellDisplayRectangle(7, -1, false);  //범위 시작
                int width1 = gv.GetCellDisplayRectangle(8, -1, false).Width;
                int width2 = gv.GetCellDisplayRectangle(9, -1, false).Width;

                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + width1 + width2 - 2; // + width1 + width2 + width3 + width4 + width5 + width6
                r1.Height = (r1.Height / 2) - 2;

                //--------------------------------- 범위 지정 END

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r1);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r1);   // 셀 병합

                e.Graphics.DrawString(strHeaders[0],
                    gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor),
                    r1,
                    format);
            }
            {
                Rectangle r2 = gv.GetCellDisplayRectangle(10, -1, false);
                int width1 = gv.GetCellDisplayRectangle(11, -1, false).Width;
                int width2 = gv.GetCellDisplayRectangle(12, -1, false).Width;

                r2.X += 1; r2.Y += 1;
                r2.Width = r2.Width + width1 + width2 - 2;
                r2.Height = (r2.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r2);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r2);
                e.Graphics.DrawString(strHeaders[1], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r2, format);
            }
            {
                Rectangle r3 = gv.GetCellDisplayRectangle(13, -1, false);
                int width1 = gv.GetCellDisplayRectangle(14, -1, false).Width;
                int width2 = gv.GetCellDisplayRectangle(15, -1, false).Width;

                r3.X += 1; r3.Y += 1;
                r3.Width = r3.Width + width1 + width2 - 2;
                r3.Height = (r3.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r3);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r3);
                e.Graphics.DrawString(strHeaders[2], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r3, format);
            }
            {
                Rectangle r4 = gv.GetCellDisplayRectangle(16, -1, false);
                int width2 = gv.GetCellDisplayRectangle(17, -1, false).Width;
                int width1 = gv.GetCellDisplayRectangle(18, -1, false).Width;

                r4.X += 1; r4.Y += 1;
                r4.Width = r4.Width + width1 + width2 - 2;
                r4.Height = (r4.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r4);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r4);
                e.Graphics.DrawString(strHeaders[2], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r4, format);
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r = e.CellBounds;
                r.Y += e.CellBounds.Height / 2;
                r.Height = e.CellBounds.Height / 2;
                e.PaintBackground(r, true);
                e.PaintContent(r);
                e.Handled = true;
            }
        }
        #endregion
    }
}

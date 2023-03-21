using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using SmartFactory;
using System.Drawing;

namespace SmartMES_Bluewings
{
    public partial class P1C01_PROD_ORDER : SmartMES_Bluewings.FormBasic
    {
        public P1C01_PROD_ORDER()
        {
            InitializeComponent();
        }
        private void P1C01_PROD_ORDER_Load(object sender, EventArgs e)
        {
            dtpDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd"));
            this.ActiveControl = tbSearch;
        }
        public async void ListSearch()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
                string sSearch = tbSearch.Text.Trim();

                sP_ProdOrder_QueryTableAdapter.Fill(dataSetP1C.SP_ProdOrder_Query, DateTime.Parse(sDate), sSearch);
                var data = dataSetP1C.SP_ProdOrder_Query;
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMsg.Text = "";
            if (e.RowIndex < 0) return;

            int index = dataGridView1.CurrentRow.Index;
            string lotno = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if(e.ColumnIndex == 0)
            {
                ///////////// Job No 클릭했을 때, Sub창 Job No 라벨에 Job No 가져가기.
                ///
                P1C01_PROD_ORDER_SUB2 sub = new P1C01_PROD_ORDER_SUB2();
                sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
                sub.lblJob.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();     // LotNo
                sub.parentWin = this;
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
            lblMsg.Text = "";

            P1C01_PROD_ORDER_SUB2 sub = new P1C01_PROD_ORDER_SUB2();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (G.Authority == "D") return;
            if (dataGridView1.RowCount == 0) return;

            int index = 0;
            string sLotNo = string.Empty;

            try
            {
                index = dataGridView1.CurrentRow.Index;
                sLotNo = dataGridView1.Rows[index].Cells[1].Value.ToString();

                if (dataGridView1.Rows[index].Selected != true)
                {
                    MessageBox.Show("삭제 정보가 선택되지 않았습니다.", this.lblTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("삭제 정보가 선택되지 않았습니다.", this.lblTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("LotNo. : " + sLotNo + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            string sql = @"select count(job_no) from tb_prod_order where job_no = '" + sLotNo + "'";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            string com = m.dbRonlyOne(sql, ref msg).ToString();

            if (msg == "OK" && Int32.Parse(com) > 0)
            {
                MessageBox.Show("실적처리된 Lot번호는 삭제할 수 없습니다.");
                return;
            }

            sql = "delete from tb_prod_order where job_no = '" + sLotNo + "'";
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.삭제, data);//삭제로그추가

            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sLotNo);

            ListSearch();
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            try
            {
                if (dataGridView1.RowCount < 1)
                {
                    lblMsg.Text = "출력정보가 존재하지 않습니다.";
                    return;
                }
                string reportFileName = "SmartMES_Bluewings.Reports.P1C01_PROD_ORDER.rdlc";

                string reportParm1 = "Lot생성일자 : ";
                string reportParm2 = "품목명/LotNo : ";
                string reportParm3 = "";

                reportParm1 = reportParm1 + dtpDate.Value.ToString("yyyy-MM-dd");

                if (string.IsNullOrEmpty(tbSearch.Text.Trim()))
                    reportParm2 = reportParm2 + "<전체>";
                else
                    reportParm2 = reportParm2 + tbSearch.Text.Trim();

                ViewReport_V viewReport = new ViewReport_V();
                viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
                viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

                ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
                ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
                ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
                viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

                ReportDataSource rds = new ReportDataSource("DataSet1", sPProdOrderQueryBindingSource);
                viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
                viewReport.reportViewer1.LocalReport.Refresh();

                viewReport.ShowDialog();
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        #endregion

        #region Cell Paint
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;
            string[] strHeaders = { "폴리에틸렌수지(A)", "폴리에틸렌수지(B)", "폴리에틸렌수지(M/B)" };
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // Category Painting 헤더 그리는 부분
            {
                //--------------------------------- 범위 지정
                Rectangle r1 = gv.GetCellDisplayRectangle(9, -1, false);  //범위 시작
                int width1 = gv.GetCellDisplayRectangle(9, -1, false).Width;

                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width - 2; // + width1 + width2 + width3 + width4 + width5 + width6
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
                int width = gv.GetCellDisplayRectangle(10, -1, false).Width;

                r2.X += 1; r2.Y += 1;
                r2.Width = r2.Width - 2;
                r2.Height = (r2.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r2);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r2);
                e.Graphics.DrawString(strHeaders[1], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r2, format);
            }
            {
                Rectangle r3 = gv.GetCellDisplayRectangle(11, -1, false);
                int width = gv.GetCellDisplayRectangle(11, -1, false).Width;

                r3.X += 1; r3.Y += 1;
                r3.Width = r3.Width  - 2;
                r3.Height = (r3.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r3);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r3);
                e.Graphics.DrawString(strHeaders[2], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r3, format);
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


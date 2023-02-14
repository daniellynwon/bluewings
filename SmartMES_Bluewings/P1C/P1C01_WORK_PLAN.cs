using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1C01_WORK_PLAN : SmartMES_Bluewings.FormBasic
    {
        public P1C01_WORK_PLAN()
        {
            InitializeComponent();
        }
        private void P1C01_WORK_PLAN_Load(object sender, EventArgs e)
        {
            // 현재일자
            DateTime dateToday = DateTime.Today; 
            // 현재일자 기준 다음주 월요일 구하기 -> 2/9 현재일자 기준 이번 주 월요일 구해짐.
            DateTime mondayDate = dateToday.AddDays(Convert.ToInt32(DayOfWeek.Monday) - Convert.ToInt32(dateToday.DayOfWeek));
            DateTime TodayMondey = mondayDate.AddDays(-7); // 현재일자 기준 해당주 월요일 구하기 -> 2/9일 현재 일자 기준 지난 주 월요일 구해짐. 이번주 월요일 아니고..
            //2/9일 현재일자 기준 이번 주 일요일 구해야함.  현재일자 기준 해당주 일요일 구하기 -> 현재일자 기준 지난 주 일요일 나옴.
            DateTime TodaySunday = mondayDate.AddDays(6); // DateTime TodaySunday = TodayMondey.AddDays(6);

            dtpFromDate.Value = Convert.ToDateTime(mondayDate);
            dtpToDate.Value = Convert.ToDateTime(TodaySunday);

            ListSearch(mondayDate);
        }

        public void ListSearch(DateTime _day)
        {
            lblMsg.Text = "";
            try
            {  
                Cursor.Current = Cursors.WaitCursor;
                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                if (dtFromDate.DayOfWeek != DayOfWeek.Monday)
                {
                    MessageBox.Show("시작일은 반드시 월요일을 선택해야 합니다.");
                };

                sP_ProdPlan_QueryTableAdapter.Fill(dataSetP1C.SP_ProdPlan_Query, dtFromDate, dtToDate);
                var data = dataSetP1C.SP_ProdPlan_Query;
                Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();

                if(dataGridView1.Rows.Count > 0)
                {
                    //DateTime d1 = _day;
                    //DateTime d2 = _day.AddDays(1);
                    //DateTime d3 = _day.AddDays(2);
                    //DateTime d4 = _day.AddDays(3);
                    //DateTime d5 = _day.AddDays(4);
                    //DateTime d6 = _day.AddDays(5);
                    //DateTime d7 = _day.AddDays(6);

                    //dataGridView1.Columns[4].HeaderText = d1.ToString("yyyy-MM-dd") + "(월)";
                    //dataGridView1.Columns[6].HeaderText = d2.ToString("yyyy-MM-dd") + "(화)";
                    //dataGridView1.Columns[8].HeaderText = d3.ToString("yyyy-MM-dd") + "(수)";
                    //dataGridView1.Columns[10].HeaderText = d4.ToString("yyyy-MM-dd") + "(목)";
                    //dataGridView1.Columns[12].HeaderText = d5.ToString("yyyy-MM-dd") + "(금)";
                    //dataGridView1.Columns[14].HeaderText = d6.ToString("yyyy-MM-dd") + "(토)";
                    //dataGridView1.Columns[16].HeaderText = d7.ToString("yyyy-MM-dd") + "(일)";
                    dataGridView1.Columns[4].HeaderText = "품목"; dataGridView1.Columns[5].HeaderText = "중량";
                    dataGridView1.Columns[6].HeaderText = "품목"; dataGridView1.Columns[7].HeaderText = "중량";
                    dataGridView1.Columns[8].HeaderText = "품목"; dataGridView1.Columns[9].HeaderText = "중량";
                    dataGridView1.Columns[10].HeaderText = "품목"; dataGridView1.Columns[11].HeaderText = "중량";
                    dataGridView1.Columns[12].HeaderText = "품목"; dataGridView1.Columns[13].HeaderText = "중량";
                    dataGridView1.Columns[14].HeaderText = "품목"; dataGridView1.Columns[15].HeaderText = "중량";
                    dataGridView1.Columns[16].HeaderText = "품목"; dataGridView1.Columns[17].HeaderText = "중량";
                }
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
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime nowDt = dtpFromDate.Value;
            ListSearch(nowDt);
        }
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ////////int rowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
            ////////if (rowIndex <= 0) return;

            ////////dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(93, 123, 157);
            ////////dataGridView1.Rows[rowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 123, 157);
            ////////dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

            ////////dataGridView1[3, rowIndex].Value = string.Format("{0:#,###,###}", rowIndex) + "건";

            ////////long iSum1 = 0, iSum2 = 0, iSum3 = 0, iSum4 = 0; //, iSum5 = 0;

            ////////for (int i = 0; i < rowIndex; i++)
            ////////{
            ////////    iSum1 += long.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            ////////    iSum2 += long.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            ////////    iSum3 += long.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
            ////////    iSum4 += long.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
            ////////    //iSum5 += long.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString());
            ////////}

            ////////dataGridView1[5, rowIndex].Value = iSum1;
            ////////dataGridView1[6, rowIndex].Value = iSum2;
            ////////dataGridView1[7, rowIndex].Value = iSum3;
            ////////dataGridView1[8, rowIndex].Value = iSum4;
            //////////dataGridView1[12, rowIndex].Value = iSum5; 
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = -1;

            lblRow.Text = "-";
            lblCol.Text = "-";

            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;

            // ***** 2월 9일 변경(note확인)
            irow = e.RowIndex + 1; int icol = e.ColumnIndex;

            if (!(e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3))   // (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 10) //업체, 수주명 선택
            {
                if(icol % 2 == 0 && icol != 0)
                {
                    dataGridView1.Columns[icol].ReadOnly = true;
                    lblRow.Text = e.RowIndex.ToString();
                    lblCol.Text = e.ColumnIndex.ToString();

                    ProdFinder sub = new ProdFinder();
                    sub.FormSendEvent += new ProdFinder.FormSendDataHandler(PostEventMethod);
                    sub.cbGubun.SelectedIndex = 1;
                    sub._kind = "%";
                    sub._stockFlag = "1";
                    sub.ShowDialog();
                }
            }
        }
        private void PostEventMethod(object sender)
        {
            string sProd = sender.ToString();
            if (string.IsNullOrEmpty(sProd)) return;

            string sRow = lblRow.Text.ToString().Trim();
            string sCol = lblCol.Text.ToString().Trim();

            if (string.IsNullOrEmpty(sRow)) return;
            if (string.IsNullOrEmpty(sCol)) return;
            if (sRow.Trim() == "-") return;
            if (sCol.Trim() == "-") return;

            int irow = Convert.ToInt32(sRow);
            int icol = Convert.ToInt32(sCol);

            dataGridView1.Rows[irow].Cells[icol].Value = sProd.Substring(0, sProd.IndexOf("#1/")) + "/" + sProd.Substring(sProd.IndexOf("#1/") + 3, sProd.IndexOf("#2/") - (sProd.IndexOf("#1/") + 3));
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
            DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
            ListSearch(dtFromDate);
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
            lblMsg.Text = "";
            DialogResult dr = MessageBox.Show("해당 생산계획을 저장하시겠습니까?", "생산계획등록", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = string.Empty;
            string msg = string.Empty;

            string sDate = string.Empty; string sWeight = string.Empty; int d = 4;

            for (int i = 4; i < dataGridView1.ColumnCount - 1; i += 2)    // column 먼저
            {
                if (i == 4) sDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
                else sDate = dtpFromDate.Value.AddDays(i - d).ToString("yyyy-MM-dd");
                d++;
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    string sMachine = dataGridView1.Rows[j].Cells[1].Value.ToString().Trim(); // 설비코드
                    string sProd = dataGridView1.Rows[j].Cells[i].Value.ToString().Split('/')[0];
                    if (string.IsNullOrEmpty(sProd)) return;
                    sWeight = dataGridView1.Rows[j].Cells[i + 1].Value.ToString().Trim();   // if (!(string.IsNullOrEmpty(sProd) && string.IsNullOrEmpty(sWeight))) return;
                    if (string.IsNullOrEmpty(sWeight)) sWeight = "0";

                    sql = "insert into tb_prod_plan (plan_date, machine_id, prod_id, plan_weight, enter_man)" +
                        " values('" + sDate + "','" + sMachine + "','" + sProd + "'," + sWeight + ",'" + G.UserID + "')" +
                        " on duplicate key update" +
                        " prod_id = '" + sProd + "', plan_weight = " + sWeight;
                    m.dbCUD(sql, ref msg);
                }
            }
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 1) return;

            string reportFileName = "SmartMES_DongLimConrod.Reports.P1B06_STOCK_INVEL_DT.rdlc";

            //string reportParm1 = " [ 전체 소재/제품 ] ";
            //reportParm1 = reportParm1 + " "; 

            ViewReport_H viewReport = new ViewReport_H();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            //ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1); 
            //viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1 });

            //////////////////ReportDataSource rds = new ReportDataSource("DataSet1", sP0CProductInOuthisBindingSource);
            //////////////////viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            //////////////////viewReport.reportViewer1.LocalReport.Refresh();

            //////////////////viewReport.ShowDialog();
        }
        #endregion

        #region Cell Paint
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            DateTime d1 = dtpFromDate.Value;
            DateTime d2 = dtpFromDate.Value.AddDays(1);
            DateTime d3 = dtpFromDate.Value.AddDays(2);
            DateTime d4 = dtpFromDate.Value.AddDays(3);
            DateTime d5 = dtpFromDate.Value.AddDays(4);
            DateTime d6 = dtpFromDate.Value.AddDays(5);
            DateTime d7 = dtpFromDate.Value.AddDays(6);

            DataGridView gv = (DataGridView)sender;
            string[] strHeaders = { "생산계획", d1.ToString("yyyy-MM-dd") + "(월)", d2.ToString("yyyy-MM-dd") + "(화)", d3.ToString("yyyy-MM-dd") + "(수)", d4.ToString("yyyy-MM-dd") + "(목)",
                            d5.ToString("yyyy-MM-dd") + "(금)", d6.ToString("yyyy-MM-dd") + "(토)", d7.ToString("yyyy-MM-dd") + "(일)"};
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // Category Painting 헤더 그리는 부분
            {
                //--------------------------------- 범위 지정
                Rectangle r1 = gv.GetCellDisplayRectangle(2, -1, false);  //범위 시작
                int width1 = gv.GetCellDisplayRectangle(3, -1, false).Width;

                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + width1 - 2; // + width1 + width2 + width3 + width4 + width5 + width6
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
                Rectangle r2 = gv.GetCellDisplayRectangle(4, -1, false);
                int width = gv.GetCellDisplayRectangle(5, -1, false).Width;

                r2.X += 1; r2.Y += 1;
                r2.Width = r2.Width + width - 2;
                r2.Height = (r2.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r2);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r2);
                e.Graphics.DrawString(strHeaders[1], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r2, format);
            }
            {
                Rectangle r3 = gv.GetCellDisplayRectangle(6, -1, false);
                int width = gv.GetCellDisplayRectangle(7, -1, false).Width;

                r3.X += 1; r3.Y += 1;
                r3.Width = r3.Width + width - 2;
                r3.Height = (r3.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r3);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r3);
                e.Graphics.DrawString(strHeaders[2], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r3, format);
            }
            {
                Rectangle r4 = gv.GetCellDisplayRectangle(8, -1, false);
                int width = gv.GetCellDisplayRectangle(9, -1, false).Width;

                r4.X += 1; r4.Y += 1;
                r4.Width = r4.Width + width - 2;
                r4.Height = (r4.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r4);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r4);
                e.Graphics.DrawString(strHeaders[3], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r4, format);
            }
            {
                Rectangle r5 = gv.GetCellDisplayRectangle(10, -1, false);
                int width = gv.GetCellDisplayRectangle(11, -1, false).Width;

                r5.X += 1; r5.Y += 1;
                r5.Width = r5.Width + width - 2;
                r5.Height = (r5.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r5);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r5);
                e.Graphics.DrawString(strHeaders[4], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r5, format);
            }
            {
                Rectangle r6 = gv.GetCellDisplayRectangle(12, -1, false);
                int width = gv.GetCellDisplayRectangle(13, -1, false).Width;

                r6.X += 1; r6.Y += 1;
                r6.Width = r6.Width + width - 2;
                r6.Height = (r6.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r6);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r6);
                e.Graphics.DrawString(strHeaders[5], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r6, format);
            }
            {
                Rectangle r7 = gv.GetCellDisplayRectangle(14, -1, false);
                int width = gv.GetCellDisplayRectangle(15, -1, false).Width;

                r7.X += 1; r7.Y += 1;
                r7.Width = r7.Width + width - 2;
                r7.Height = (r7.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r7);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r7);
                e.Graphics.DrawString(strHeaders[6], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r7, format);
            }
            {
                Rectangle r8 = gv.GetCellDisplayRectangle(16, -1, false);
                int width = gv.GetCellDisplayRectangle(17, -1, false).Width;

                r8.X += 1; r8.Y += 1;
                r8.Width = r8.Width + width - 2;
                r8.Height = (r8.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r8);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r8);
                e.Graphics.DrawString(strHeaders[7], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r8, format);
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
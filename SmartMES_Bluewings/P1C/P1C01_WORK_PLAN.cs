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
            // 현재일자 기준 다음주 월요일 구하기
            DateTime mondayDate = dateToday.AddDays(Convert.ToInt32(DayOfWeek.Monday) - Convert.ToInt32(dateToday.DayOfWeek));
            // 현재일자 기준 해당주 월요일 구하기
            DateTime TodayMondey = mondayDate.AddDays(-7);
            // 현재일자 기준 해당주 일요일 구하기
            DateTime TodaySunday = TodayMondey.AddDays(6);

            dtpFromDate.Value = Convert.ToDateTime(TodayMondey);
            dtpToDate.Value = Convert.ToDateTime(TodaySunday);

            ListSearch(mondayDate);
        }

        public void ListSearch(DateTime _day)
        {
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
                    DateTime d1 = _day;
                    DateTime d2 = _day.AddDays(1);
                    DateTime d3 = _day.AddDays(2);
                    DateTime d4 = _day.AddDays(3);
                    DateTime d5 = _day.AddDays(4);
                    DateTime d6 = _day.AddDays(5);
                    DateTime d7 = _day.AddDays(6);

                    dataGridView1.Columns[4].HeaderText = d1.ToString("yyyy-MM-dd") + "(월)";
                    dataGridView1.Columns[5].HeaderText = d2.ToString("yyyy-MM-dd") + "(화)";
                    dataGridView1.Columns[6].HeaderText = d3.ToString("yyyy-MM-dd") + "(수)";
                    dataGridView1.Columns[7].HeaderText = d4.ToString("yyyy-MM-dd") + "(목)";
                    dataGridView1.Columns[8].HeaderText = d5.ToString("yyyy-MM-dd") + "(금)";
                    dataGridView1.Columns[9].HeaderText = d6.ToString("yyyy-MM-dd") + "(토)";
                    dataGridView1.Columns[10].HeaderText = d7.ToString("yyyy-MM-dd") + "(일)"; 
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
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
             
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

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //
        }  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = -1;

            lblRow.Text = "-";
            lblCol.Text = "-";

            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;

            irow = e.RowIndex + 1;

            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 10) //업체, 수주명 선택
            {
                if (irow % 2 == 0 && irow != 0) //짝수 임
                {
                    lblRow.Text = e.RowIndex.ToString();
                    lblCol.Text = e.ColumnIndex.ToString();

                    ProdFinder sub = new ProdFinder();
                    sub.FormSendEvent += new ProdFinder.FormSendDataHandler(PostEventMethod);
                    sub.cbGubun.SelectedIndex = 1;
                    sub._kind = "%";
                    sub._stockFlag = "1";
                    sub.ShowDialog();
                }
                else if (irow % 2 == 1) // 홀수임
                {
                    lblRow.Text = e.RowIndex.ToString();
                    lblCol.Text = e.ColumnIndex.ToString();

                    ProdFinder sub = new ProdFinder();
                    sub.FormSendEvent += new ProdFinder.FormSendDataHandler(PostEventMethod);
                    sub.cbGubun.SelectedIndex = 1;
                    sub._kind = "%";
                    sub._stockFlag = "1";
                    sub.ShowDialog();
                }
                else // 0 입니다.
                {
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
            //
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

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;
            string[] strHeaders = { "생산계획"};
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // Category Painting 
            {
                //--------------------------------- 범위 지정
                Rectangle r1 = gv.GetCellDisplayRectangle(4, -1, false);  //범위 시작
                int width1 = gv.GetCellDisplayRectangle(5, -1, false).Width;
                int width2 = gv.GetCellDisplayRectangle(6, -1, false).Width;  // 범위 종료 
                int width3 = gv.GetCellDisplayRectangle(7, -1, false).Width;  // 범위 종료 
                int width4 = gv.GetCellDisplayRectangle(8, -1, false).Width;  // 범위 종료 
                int width5 = gv.GetCellDisplayRectangle(9, -1, false).Width;  // 범위 종료 
                int width6 = gv.GetCellDisplayRectangle(10, -1, false).Width;  // 범위 종료  

                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + width1 + width2 + width3 + width4 + width5 + width6 - 2;
                r1.Height = (r1.Height / 2) - 2; 
             
                //--------------------------------- 범위 지정 END

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r1);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r1); 

                e.Graphics.DrawString(strHeaders[0],
                    gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor),
                    r1,
                    format); 
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

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime nowDt = dtpFromDate.Value; 

            ListSearch(nowDt);

            ////if (nowDt.DayOfWeek == DayOfWeek.Monday)
            ////    Console.WriteLine("월");
            ////else if (nowDt.DayOfWeek == DayOfWeek.Tuesday)
            ////    Console.WriteLine("화");
            ////else if (nowDt.DayOfWeek == DayOfWeek.Wednesday)
            ////    Console.WriteLine("수");
            ////else if (nowDt.DayOfWeek == DayOfWeek.Thursday)
            ////    Console.WriteLine("목");
            ////else if (nowDt.DayOfWeek == DayOfWeek.Friday)
            ////    Console.WriteLine("금");
            ////else if (nowDt.DayOfWeek == DayOfWeek.Saturday)
            ////    Console.WriteLine("토");
            ////else if (nowDt.DayOfWeek == DayOfWeek.Sunday)
            ////    Console.WriteLine("일");
        }
    }
}
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartMES_Bluewings
{
    public partial class P1ED01_QC_FINAL : SmartMES_Bluewings.FormBasic
    {
        int columnIndex = 0;
        int rowIndex = 0;
        bool endEdit = false;

        public P1ED01_QC_FINAL()
        {
            InitializeComponent();
        }
        private void P1ED01_QC_FINAL_Load(object sender, EventArgs e)
        {
            string sql = @"select t.user_id, t.user_name
                            from(
                            select '-' as user_id, '-' as user_name
                            union 
                            select user_id, user_name from tb_sys_user where authority in ('B','C') and user_flag = 1) as t
                            order by t.user_name";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbQcMan.DataSource = table;
                cbQcMan.ValueMember = "user_id";
                cbQcMan.DisplayMember = "user_name";
            }
            ListSearch1();
        }
        public async void ListSearch1()
        {
            lblMsg.Text = "";
            try
            {
                //Cursor.Current = Cursors.WaitCursor;

                sP_QcFinal_ROderTableAdapter.Fill(dataSetP1E.SP_QcFinal_ROder);
                var data = dataSetP1E.SP_QcFinal_ROder;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

                dataGridViewList.CurrentCell = null;
                dataGridViewList.ClearSelection();
            }
            catch (NullReferenceException)
            {
                return;
            }
            finally
            {
                //Cursor.Current = Cursors.Default;
            }
        }
        public void ListSearch2(int rowIndex)
        {
            lblMsg.Text = "";
            try
            {
                //Cursor.Current = Cursors.WaitCursor;
                int idx = dataGridViewList.CurrentRow.Index;
                string sProd = dataGridViewList[5, idx].Value.ToString();

                string sql = "select tube_skin_thickness, min_in_thickness, avg_inner_diameter, product_length from tb_gi_product_spec where prod_id = '" + sProd + "'";
                MariaCRUD m = new MariaCRUD();
                string msg = string.Empty;
                DataTable table = m.dbDataTable(sql, ref msg);

                lblStd1.Text = Convert.ToString(table.Rows[0][0]); lblStd2.Text = Convert.ToString(table.Rows[0][1]);
                lblStd3.Text = Convert.ToString(table.Rows[0][2]); lblStd4.Text = Convert.ToString(table.Rows[0][3]);

                if (dataGridViewList[7, idx].Value.ToString() == "F") cbResult.Checked = false;
                else cbResult.Checked = true;
                tbVal1.Text = dataGridViewList[8, idx].Value.ToString();
                tbVal2.Text = dataGridViewList[9, idx].Value.ToString();
                tbVal3.Text = dataGridViewList[10, idx].Value.ToString();
                tbVal4.Text = dataGridViewList[11, idx].Value.ToString();
                tbVal5.Text = dataGridViewList[12, idx].Value.ToString();
                tbVal6.Text = dataGridViewList[13, idx].Value.ToString();
                tbVal7.Text = dataGridViewList[14, idx].Value.ToString();
                tbVal8.Text = dataGridViewList[15, idx].Value.ToString();
                tbVal9.Text = dataGridViewList[16, idx].Value.ToString();
                tbVal10.Text = dataGridViewList[17, idx].Value.ToString();
                tbVal11.Text = dataGridViewList[18, idx].Value.ToString();
                tbVal12.Text = dataGridViewList[19, idx].Value.ToString();
                if (dataGridViewList[20, idx].Value.ToString() == "F") lblResult.Text = "불합";
                else lblResult.Text = "합격";
                dtpDate.Value = DateTime.Parse(dataGridViewList[21, idx].Value.ToString());
            }
            catch (NullReferenceException)
            {
                return;
            }
            finally
            {
                //Cursor.Current = Cursors.Default;
            }
        }
        public void ListInit()
        {
            lblMsg.Text = "";
            dtpDate.Value = DateTime.Today;
            cbQcMan.SelectedValue = "-";
            tbContents.Text = string.Empty;
            tbVal1.Text = ""; tbVal2.Text = ""; tbVal3.Text = ""; tbVal4.Text = "";
            tbVal5.Text = ""; tbVal6.Text = ""; tbVal7.Text = ""; tbVal8.Text = "";
            tbVal9.Text = ""; tbVal10.Text = ""; tbVal11.Text = ""; tbVal12.Text = "";
        }

        #region Controls Event
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListSearch1();
        }
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch1();
            }
        }
        #endregion

        #region 엔터키로 포커스 이동
        public bool NextFocus(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                return true;
            }
            return false;
        }
        private void nextFocus_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = NextFocus(sender, e);
        }
        #endregion

        #region GridView Events
        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int index = dataGridViewList.CurrentRow.Index;

            ListSearch2(index);
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;

                    if (columnIndex == 17)
                        dataGridView1.CurrentCell = dataGridView1[5, rowIndex + 1];
                    else
                        dataGridView1.CurrentCell = dataGridView1[columnIndex + 1, rowIndex];
                }
                if (e.KeyCode == Keys.Tab)
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                rowIndex = dataGridView1.CurrentCell.RowIndex;
                endEdit = true;

                float value1 = 0; float value2 = 0; float value3 = 0;
                string minStd = string.Empty; string maxStd = string.Empty;
                //long moneyA = 0;
                //long moneyB = 0;
                //float discount = 100;

                if (columnIndex == 6 || columnIndex == 7 || columnIndex == 8)
                {
                    minStd = lblStd1.Text.Substring(0, lblStd1.Text.IndexOf("±"));
                    maxStd = lblStd1.Text.Substring(lblStd1.Text.IndexOf("±") + 1, lblStd1.Text.Length - (lblStd1.Text.IndexOf("±") + 1));

                    if (dataGridView1.Rows[rowIndex].Cells[6].Value != null && dataGridView1.Rows[rowIndex].Cells[6].Value.ToString().Length != 0)
                        value1 = float.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());   // 수량

                    if (dataGridView1.Rows[rowIndex].Cells[7].Value != null && dataGridView1.Rows[rowIndex].Cells[7].Value.ToString().Length != 0)
                        value2 = float.Parse(dataGridView1.Rows[rowIndex].Cells[7].Value.ToString());   // 단가

                    if (dataGridView1.Rows[rowIndex].Cells[8].Value != null && dataGridView1.Rows[rowIndex].Cells[8].Value.ToString().Length != 0)
                        value3 = float.Parse(dataGridView1.Rows[rowIndex].Cells[8].Value.ToString());

                    if (value1 >= float.Parse(minStd) && float.Parse(maxStd) >= value1)
                        dataGridView1.Rows[rowIndex].Cells[18].Value = "합격";

                    if (value2 >= float.Parse(minStd) && float.Parse(maxStd) >= value2)
                        dataGridView1.Rows[rowIndex].Cells[18].Value = "합격";
                    else
                        dataGridView1.Rows[rowIndex].Cells[18].Value = "불합";
                }
                else if (columnIndex == 9 || columnIndex == 10 || columnIndex == 11)
                {
                    //
                }
                else if (columnIndex == 12 || columnIndex == 12 || columnIndex == 13)
                {
                    //
                }
                else if (columnIndex == 14 || columnIndex == 15 || columnIndex == 16)
                {
                    //
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                //rowIndex = dataGridView1.CurrentCell.RowIndex;

                if (dataGridView1.CurrentCell != null && endEdit)
                {
                    //if (columnIndex == dataGridView1.Columns.Count - 1)
                    if (columnIndex == 17)
                        dataGridView1.CurrentCell = dataGridView1[5, rowIndex + 1];
                    else
                        dataGridView1.CurrentCell = dataGridView1[columnIndex + 1, rowIndex];

                    endEdit = false;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMsg.Text = "";
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            float fVal = 0;
            
            if(e.ColumnIndex == 5 || e.ColumnIndex == 18)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "")
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = "적합";
                else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "적합")
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = "불합";
                else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "불합")
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = "";
            }
            //else if (e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8)
            //{
            //    string minStd = lblStd1.Text.Substring(0, lblStd1.Text.IndexOf("±"));
            //    string maxStd = lblStd1.Text.Substring(lblStd1.Text.IndexOf("±") + 1, lblStd1.Text.Length - (lblStd1.Text.IndexOf("±") + 1));
            //    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "") return;
            //    string sVal = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //    getResult(e.RowIndex, e.ColumnIndex, minStd, maxStd, float.Parse(sVal));
            //}
            //else if (e.ColumnIndex == 9 || e.ColumnIndex == 10 || e.ColumnIndex == 11)
            //{
            //    string minStd = lblStd2.Text.Substring(0, lblStd1.Text.IndexOf("±"));
            //    string maxStd = lblStd2.Text.Substring(lblStd1.Text.IndexOf("±") + 1, lblStd1.Text.Length - (lblStd1.Text.IndexOf("±") + 1));
            //    string sVal = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //    getResult(e.RowIndex, e.ColumnIndex, minStd, maxStd, float.Parse(sVal));
            //}
            //else if (e.ColumnIndex == 12 || e.ColumnIndex == 13 || e.ColumnIndex == 14)
            //{
            //    string minStd = lblStd3.Text.Substring(0, lblStd1.Text.IndexOf("±"));
            //    string maxStd = lblStd3.Text.Substring(lblStd1.Text.IndexOf("±") + 1, lblStd1.Text.Length - (lblStd1.Text.IndexOf("±") + 1));
            //    string sVal = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //    getResult(e.RowIndex, e.ColumnIndex, minStd, maxStd, float.Parse(sVal));
            //}
            //else if (e.ColumnIndex == 15 || e.ColumnIndex == 16 || e.ColumnIndex == 17)
            //{
            //    string minStd = lblStd4.Text.Substring(0, lblStd1.Text.IndexOf("±"));
            //    string maxStd = lblStd4.Text.Substring(lblStd1.Text.IndexOf("±") + 1, lblStd1.Text.Length - (lblStd1.Text.IndexOf("±") + 1));
            //    string sVal = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //    getResult(e.RowIndex, e.ColumnIndex, minStd, maxStd, float.Parse(sVal));
            //}
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.RowCount < 2) return;
        }
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                if (!(columnIndex == 5 || columnIndex == 18))
                {
                    if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.'))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //
            }
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }
        void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch1();
            ListInit();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;
            ListInit();
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (dataGridView1.RowCount <= 0)
            {
                lblMsg.Text = "삭제할 검사 건이 선택되지 않았습니다.";
                return;
            }

            if (dataGridView1[9, 0].Value == null || string.IsNullOrEmpty(dataGridView1[9, 0].Value.ToString()))
            {
                lblMsg.Text = "저장되지 않은 검사 건입니다.";
                return;
            }

            string sJobNo = dataGridView1[9, 0].Value.ToString();

            DialogResult dr = MessageBox.Show("포대번호 : " + sJobNo + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_qc_inspection where job_no = '" + sJobNo + "'";
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }
            sql = "update tb_prod_done_sub set qc_flag = 0 where prod_no = '" + sJobNo + "'";
            m.dbCUD(sql, ref msg);

            dataGridViewList[7, dataGridViewList.CurrentRow.Index].Value = 0;
            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sJobNo + " " + "");
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

            ListInit();
            lblMsg.Text = "삭제되었습니다.";
        }
        private async void pbSave_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (dataGridViewList.RowCount <= 0 || dataGridViewList.CurrentRow == null)
            {
                lblMsg.Text = "저장할 검사건이 선택되지 않았습니다.";
                return;
            }
            getResult();

            string sNo= dataGridViewList.Rows[dataGridViewList.CurrentRow.Index].Cells[0].Value.ToString(); // JobNo
            string sMach = dataGridViewList.Rows[dataGridViewList.CurrentRow.Index].Cells[2].Value.ToString(); // 설비코드
            string sProd = dataGridViewList.Rows[dataGridViewList.CurrentRow.Index].Cells[5].Value.ToString(); // 설비코드
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sVal1 = tbVal1.Text; string sVal2 = tbVal2.Text; string sVal3 = tbVal3.Text; string sVal4 = tbVal4.Text;
            string sVal5 = tbVal5.Text; string sVal6 = tbVal6.Text; string sVal7 = tbVal7.Text; string sVal8 = tbVal8.Text;
            string sVal9 = tbVal9.Text; string sVal10 = tbVal10.Text; string sVal11 = tbVal11.Text; string sVal12 = tbVal12.Text;
            string sResult1 = "F"; string sResult2 = "P";

            if (cbResult.Checked) sResult1 = "P";
            if (lblResult.Text == "불합") sResult2 = "F";

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            sql = "INSERT INTO tb_qc_inspection(job_no, machine_id, qc_date, prod_id, result1, tube1, tube2, tube3, in1, in2, in3, diameter1, diameter2, diameter3, length1, length2, length3, result2, enter_man) " +
                    "VALUES('" + sNo + "'," + sMach + ",'" + sDate + ",'" + sProd + "','" + sResult1 + "','" + sVal1 + "','" + sVal2 + "','" + sVal3 + "','" + sVal4 + "','" + sVal5 + "','" + sVal6 + "','" +
                    sVal7 + "','" + sVal8 + "','" + sVal9 + "','" + sVal10 + "','" + sVal11 + "','" + sVal12 + "','" + sResult2 + "','" + G.UserID + "') " +
                    "ON DUPLICATE KEY UPDATE qc_date = '" + sDate + "', result1 = '" + sResult1 + "', tube1 = '" + sVal1 + "', tube2 = '" + sVal2 + "', tube3 = '" + sVal3 + 
                    "', in1 = '" + sVal4 + "', in2 = '" + sVal5 + "', in3 = '" + sVal6 + "', diameter1 = '" + sVal7 + "', diameter2 = '" + sVal8 + "', diameter3 = '" + sVal9 + 
                    "', length1 = '" + sVal10 + "', length2 = '" + sVal11 + "', length3 = '" + sVal12 + "', result2 = '" + sResult2 + "', enter_man = '" + G.UserID + "'";

            m.dbCUD(sql, ref msg);

            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가
            lblMsg.Text = "저장되었습니다.";
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            //if (dataGridView1.RowCount <= 0)
            //{
            //    lblMsg.Text = "성적서 발행건이 선택되지 않았습니다.";
            //    return;
            //}

            //if (dataGridView1[6, 0].Value == null || string.IsNullOrEmpty(dataGridView1[6, 0].Value.ToString()))
            //{
            //    lblMsg.Text = "저장된 검사건만 성적서 출력이 가능합니다.";
            //    return;
            //}

            //string sJobNo = dataGridViewList.Rows[dataGridViewList.CurrentRow.Index].Cells[0].Value.ToString();
            //sP_QcFinal_PrintTableAdapter.Fill(dataSetP1E.SP_QcFinal_Print, sJobNo);

            //string reportFileName = "SmartMES_Bluewings.Reports.P1ED01_QC_FINAL.rdlc";

            //ViewReport_V viewReport = new ViewReport_V();
            //viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            //viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            //ReportDataSource rds = new ReportDataSource("DataSet1", sPQcFinalPrintBindingSource);
            //viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            //viewReport.reportViewer1.LocalReport.Refresh();

            //viewReport.ShowDialog();
        }
        #endregion

        #region 텍스트 박스 숫자 처리
        private void tb_KeyPressComa(object sender, KeyPressEventArgs e)
        {
            // TODO : (221101) 소숫점 입력 기능 
            if (e.KeyChar == Convert.ToChar("."))   //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = false;  // fasle : 인정 true : 미인정 - 소숫점이 들어오면 인정 다른 값이면 아래 판단
            }
            else
            {
                // TODO : (221101) 소숫점 입력 기능 
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))  //숫자와 백스페이스를 제외한 나머지를 바로 처리
                {
                    e.Handled = true;
                }
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
                Rectangle r1 = gv.GetCellDisplayRectangle(6, -1, false);  //범위 시작
                int width1 = gv.GetCellDisplayRectangle(7, -1, false).Width;
                int width2 = gv.GetCellDisplayRectangle(8, -1, false).Width;

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
                Rectangle r2 = gv.GetCellDisplayRectangle(9, -1, false);
                int width1 = gv.GetCellDisplayRectangle(10, -1, false).Width;
                int width2 = gv.GetCellDisplayRectangle(11, -1, false).Width;

                r2.X += 1; r2.Y += 1;
                r2.Width = r2.Width + width1 + width2 - 2;
                r2.Height = (r2.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r2);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r2);
                e.Graphics.DrawString(strHeaders[1], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r2, format);
            }
            {
                Rectangle r3 = gv.GetCellDisplayRectangle(12, -1, false);
                int width1 = gv.GetCellDisplayRectangle(13, -1, false).Width;
                int width2 = gv.GetCellDisplayRectangle(14, -1, false).Width;

                r3.X += 1; r3.Y += 1;
                r3.Width = r3.Width + width1 + width2 - 2;
                r3.Height = (r3.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r3);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r3);
                e.Graphics.DrawString(strHeaders[2], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r3, format);
            }
            {
                Rectangle r4 = gv.GetCellDisplayRectangle(15, -1, false);
                int width2 = gv.GetCellDisplayRectangle(16, -1, false).Width;
                int width1 = gv.GetCellDisplayRectangle(17, -1, false).Width;

                r4.X += 1; r4.Y += 1;
                r4.Width = r4.Width + width1+ width2 - 2;
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

        #region Functions
        private void getResult()
        {
            int iCnt = 0; string sValue = string.Empty;
            string minStd1 = lblStd1.Text.Substring(0, lblStd1.Text.IndexOf("±")); string maxStd1 = lblStd1.Text.Substring(lblStd1.Text.IndexOf("±") + 1, lblStd1.Text.Length - (lblStd1.Text.IndexOf("±") + 1));
            string minStd2 = lblStd2.Text.Substring(0, lblStd2.Text.IndexOf("±")); string maxStd2 = lblStd2.Text.Substring(lblStd2.Text.IndexOf("±") + 1, lblStd2.Text.Length - (lblStd2.Text.IndexOf("±") + 1));
            string minStd3 = lblStd3.Text.Substring(0, lblStd3.Text.IndexOf("±")); string maxStd3 = lblStd3.Text.Substring(lblStd3.Text.IndexOf("±") + 1, lblStd3.Text.Length - (lblStd3.Text.IndexOf("±") + 1));
            string minStd4 = lblStd4.Text.Substring(0, lblStd4.Text.IndexOf("±")); string maxStd4 = lblStd4.Text.Substring(lblStd4.Text.IndexOf("±") + 1, lblStd4.Text.Length - (lblStd4.Text.IndexOf("±") + 1));
            
            for (int i = 0; i < 3; i++)
            {
                if (i == 0) sValue = tbVal1.Text;
                else if (i == 1) sValue = tbVal2.Text;
                else if (i == 2) sValue = tbVal3.Text;

                if (!(float.Parse(sValue) >= float.Parse(minStd1) && float.Parse(maxStd1) >= float.Parse(sValue)))
                    iCnt = 1;
                else iCnt = 0; break;
            }

            for (int i = 0; i < 3; i++)
            {
                if (i == 0) sValue = tbVal4.Text;
                else if (i == 1) sValue = tbVal5.Text;
                else if (i == 2) sValue = tbVal6.Text;

                if (!(float.Parse(sValue) >= float.Parse(minStd2) && float.Parse(maxStd2) >= float.Parse(sValue)))
                    iCnt = 1;
                else iCnt = 0; break;
            }

            for (int i = 0; i < 3; i++)
            {
                if (i == 0) sValue = tbVal7.Text;
                else if (i == 1) sValue = tbVal8.Text;
                else if (i == 2) sValue = tbVal9.Text;

                if (!(float.Parse(sValue) >= float.Parse(minStd3) && float.Parse(maxStd3) >= float.Parse(sValue)))
                    iCnt = 1;
                else iCnt = 0; break;
            }

            for (int i = 0; i < 3; i++)
            {
                if (i == 0) sValue = tbVal10.Text;
                else if (i == 1) sValue = tbVal11.Text;
                else if (i == 2) sValue = tbVal12.Text;

                if (!(float.Parse(sValue) >= float.Parse(minStd4) && float.Parse(maxStd4) >= float.Parse(sValue)))
                    iCnt = 1;
                else iCnt = 0; break;
            }
            
            if (iCnt == 1) lblResult.Text = "불합";
        }
        #endregion
    }
}
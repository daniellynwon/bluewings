﻿using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;
using System.Drawing;

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
                Cursor.Current = Cursors.WaitCursor;

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
                Cursor.Current = Cursors.Default;
            }
        }
        public async void ListSearch2(string jobNo, string mach)
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                sP_Qc_QueryTableAdapter.Fill(dataSetP1E.SP_Qc_Query, jobNo, int.Parse(mach));
                var data = dataSetP1E.SP_Qc_Query;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가
                int idx = dataGridViewList.CurrentRow.Index;

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();

                string sProd = dataGridViewList[5, idx].Value.ToString();
                string sql = "select tube_skin_thickness, min_in_thickness, avg_inner_diameter, product_length from tb_gi_product_spec where prod_id = '" + sProd + "'";
                MariaCRUD m = new MariaCRUD();
                string msg = string.Empty;
                DataTable table = m.dbDataTable(sql, ref msg);

                lblStd1.Text = Convert.ToString(table.Rows[0][0]);
                lblStd2.Text = Convert.ToString(table.Rows[0][1]);
                lblStd3.Text = Convert.ToString(table.Rows[0][2]);
                lblStd4.Text = Convert.ToString(table.Rows[0][3]);
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
        public void ListInit()
        {
            lblMsg.Text = "";
            try
            {
                sP_QcFinal_QueryTableAdapter.Fill(dataSetP1E.SP_QcFinal_Query, "-", "-");

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();

                dtpDate.Value = DateTime.Today;
                cbQcMan.SelectedValue = "-";
                tbContents.Text = string.Empty;
            }
            catch (NullReferenceException)
            {
                return;
            }
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
            string sJobNo = dataGridViewList[0, index].Value.ToString();
            string sMach = dataGridViewList[2, index].Value.ToString();

            ListSearch2(sJobNo, sMach);
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

            if (dataGridViewList.RowCount <= 0 || dataGridViewList.CurrentRow == null)
            {
                lblMsg.Text = "추가할 검사건이 선택되지 않았습니다.";
                return;
            }
            if (dataGridView1.RowCount > 0)
            {
                lblMsg.Text = "이미 검사 데이터가 존재합니다.";
                return;
            }
            try
            {
                sP_QcFinal_QueryTableAdapter.Fill(dataSetP1E.SP_QcFinal_Query, "", "%");

                dataGridView1.CurrentCell = dataGridView1[3, 0];

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[4].Value = "1.합 격";
                }

                cbQcMan.SelectedValue = "-";
                tbContents.Text = string.Empty;
            }
            catch (NullReferenceException)
            {
                return;
            }
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
            if (dataGridView1.RowCount <= 0)
            {
                lblMsg.Text = "저장 검사 건이 추가되지 않았습니다.";
                return;
            }
            if (string.IsNullOrEmpty(cbQcMan.SelectedValue.ToString()) || cbQcMan.SelectedValue.ToString() == "-")
            {
                lblMsg.Text = "검사원이 선택되지 않았습니다.";
                return;
            }
            dataGridView1.CurrentCell = dataGridView1[1, 0];

            string sQcMan = cbQcMan.SelectedValue.ToString();
            string sNo= dataGridViewList.Rows[dataGridViewList.CurrentRow.Index].Cells[0].Value.ToString();
            string sItem = string.Empty;
            string sResult = string.Empty;
            string sDecison = string.Empty;
            string sContents = tbContents.Text.Trim();
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            //sql = "INSERT INTO tb_qc_inspection(job_no, machine_id, prod_id, result1, tube1, tube2, tube3, in1, in2, in3, diameter1, diameter2, diameter3, length1, length2, length3, result2) " +
            //            "VALUES('" + sItem + "','" + sProdNo + "','" + sResult + "'," + sDecison + ",'" + sContents + "','" + sDate + "','" + sQcMan + "','" + G.UserID + "') " +
            //            "ON DUPLICATE KEY UPDATE " +
            //            "qc_result = '" + sResult + "', qc_decision = " + sDecison + ", contents = '" + sContents + "', qc_date = '" + sDate + "', qc_man = '" + sQcMan + "'";

            //m.dbCUD(sql, ref msg);

            //sql = "update tb_prod_done_sub set qc_flag = 1 where prod_no = '" + sProdNo + "'";
            m.dbCUD(sql, ref msg);
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

            //dataGridViewList[6, dataGridViewList.CurrentRow.Index].Value = q;   // 검사건수
            lblMsg.Text = "저장되었습니다.";
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (dataGridView1.RowCount <= 0)
            {
                lblMsg.Text = "성적서 발행건이 선택되지 않았습니다.";
                return;
            }

            if (dataGridView1[6, 0].Value == null || string.IsNullOrEmpty(dataGridView1[6, 0].Value.ToString()))
            {
                lblMsg.Text = "저장된 검사건만 성적서 출력이 가능합니다.";
                return;
            }

            string sJobNo = dataGridViewList.Rows[dataGridViewList.CurrentRow.Index].Cells[0].Value.ToString();
            sP_QcFinal_PrintTableAdapter.Fill(dataSetP1E.SP_QcFinal_Print, sJobNo);

            string reportFileName = "SmartMES_Bluewings.Reports.P1ED01_QC_FINAL.rdlc";

            ViewReport_V viewReport = new ViewReport_V();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportDataSource rds = new ReportDataSource("DataSet1", sPQcFinalPrintBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

        #region 텍스트 박스 숫자 처리
        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText1, lgsText2, lgsText3, lgsText4, lgsText5, lgsText6, lgsText7, lgsText8, lgsText9, lgsText10,
                    lgsText11, lgsText12;

                lgsText1 = tbVal1.Text.Replace(",", ""); lgsText2 = tbVal2.Text.Replace(",", ""); lgsText3 = tbVal3.Text.Replace(",", ""); lgsText4 = tbVal4.Text.Replace(",", "");
                lgsText5 = tbVal5.Text.Replace(",", ""); lgsText6 = tbVal6.Text.Replace(",", ""); lgsText7 = tbVal7.Text.Replace(",", ""); lgsText8 = tbVal8.Text.Replace(",", "");
                lgsText9 = tbVal9.Text.Replace(",", ""); lgsText10 = tbVal10.Text.Replace(",", ""); lgsText11 = tbVal11.Text.Replace(",", ""); lgsText12 = tbVal12.Text.Replace(",", "");
                tbVal1.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText1)); tbVal2.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText2));
                tbVal3.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText3)); tbVal4.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText4));
                tbVal5.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText5)); tbVal6.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText6));
                tbVal7.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText7)); tbVal8.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText8));
                tbVal9.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText9)); tbVal10.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText10));
                tbVal11.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText11)); tbVal12.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText12));

                tbVal1.SelectionStart = tbVal1.TextLength; tbVal2.SelectionStart = tbVal2.TextLength; tbVal3.SelectionStart = tbVal3.TextLength; tbVal4.SelectionStart = tbVal4.TextLength;
                tbVal5.SelectionStart = tbVal5.TextLength; tbVal6.SelectionStart = tbVal6.TextLength; tbVal7.SelectionStart = tbVal7.TextLength; tbVal8.SelectionStart = tbVal8.TextLength;
                tbVal9.SelectionStart = tbVal9.TextLength; tbVal10.SelectionStart = tbVal10.TextLength; tbVal11.SelectionStart = tbVal11.TextLength; tbVal12.SelectionStart = tbVal12.TextLength;
                tbVal1.SelectionLength = 0; tbVal2.SelectionLength = 0; tbVal3.SelectionLength = 0; tbVal4.SelectionLength = 0;
                tbVal5.SelectionLength = 0; tbVal6.SelectionLength = 0; tbVal7.SelectionLength = 0; tbVal8.SelectionLength = 0;
                tbVal9.SelectionLength = 0; tbVal10.SelectionLength = 0; tbVal11.SelectionLength = 0; tbVal12.SelectionLength = 0;
            }
            catch (FormatException)
            {
                return;
            }
        }
        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-'))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
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
        private void getResult(int idx, int col, string min, string max, float fVal)
        {
            int iCnt = 0;
            //string sValue = dataGridView1.Rows[idx].Cells[col].Value.ToString(); string sVal = string.Empty;
            //if (!(dataGridView1.Rows[idx].Cells[col].Value == "" || string.IsNullOrEmpty(dataGridView1.Rows[idx].Cells[col].Value.ToString())))
            //    fVal = float.Parse(dataGridView1.Rows[idx].Cells[col].Value.ToString());
            
            if(col == 6 || col == 7 || col == 8)
            {
                if (fVal >= float.Parse(min) && float.Parse(max) >= fVal)
                {
                    dataGridView1.Rows[idx].Cells[18].Value = "합격";
                }
                else
                    dataGridView1.Rows[idx].Cells[18].Value = "불합";
            }

            //for(int i=0; i < 3; i++)
            //{
            //    if (dataGridView1.Rows[idx].Cells[col+i].Value == "" || string.IsNullOrEmpty(dataGridView1.Rows[idx].Cells[col+i].Value.ToString()))
            //        fVal = 0;
            //    else
            //        fVal = float.Parse(dataGridView1.Rows[idx].Cells[col+i].Value.ToString());

            //    if (float.Parse(min) < fVal && float.Parse(max) > fVal)
            //        dataGridView1.Rows[idx].Cells[18].Value = "합격";
            //    else
            //    {
            //        dataGridView1.Rows[idx].Cells[18].Value = "불합";
            //        iCnt = 1;
            //    }
            //}
        }
        #endregion
    }
}
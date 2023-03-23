using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{ // P1C02_PROD_RESULT_A_A
    public partial class P1C02_PROD_RESULT_A : SmartMES_Bluewings.FormBasic
    {
        int columnIndex = 0;
        int rowIndex = 0;
        bool endEdit = false;

        public P1C02_PROD_RESULT_A()
        {
            InitializeComponent();
        }
        private void P1C02_PROD_RESULT_A_Load(object sender, EventArgs e)
        {
            this.sP_Z_Common_IDTableAdapter.Fill(this.dataSetP1C.SP_Z_Common_ID, "B");
            ListSearch1();
        }
        public void ListSearch1()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                sP_ProdResult_ListTableAdapter.Fill(dataSetP1C.SP_ProdResult_List);

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
        public void ListSearch2(int rowIndex)
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DateTime checkDate = DateTime.Parse(dataGridViewList[0, rowIndex].Value.ToString());
                dataGridView1.DataSource = dataSetP1C.SP_ProdResult_Query;  // 생산실적 갱신 후 Sub 그리드뷰 update안되는 에러 수정.
                //sP_ProdResult_QueryTableAdapter.Fill(dataSetP1C.SP_ProdResult_Query, checkDate);

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();

                dtpDate.Value = checkDate;
                dtpDate.Enabled = false;
                cbDate.Checked = false;
                if (dataGridViewList.Rows[rowIndex].Cells[2].Value == null || string.IsNullOrEmpty(dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString()))
                    dtpStartTime.Text = string.Empty;
                else
                    dtpStartTime.Text = DateTime.Parse(dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");

                if (dataGridViewList.Rows[rowIndex].Cells[3].Value == null || string.IsNullOrEmpty(dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString()))
                    dtpDoneTime.Text = string.Empty;
                else
                    dtpDoneTime.Text = DateTime.Parse(dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");

                tbWorkCnt.Text = dataGridViewList.Rows[rowIndex].Cells[4].Value.ToString();
                tbWorkers.Text = dataGridViewList.Rows[rowIndex].Cells[5].Value.ToString();
                tbEnergy1.Text = dataGridViewList.Rows[rowIndex].Cells[6].Value.ToString();
                tbEnergy2.Text = dataGridViewList.Rows[rowIndex].Cells[7].Value.ToString();
                tbContents.Text = dataGridViewList.Rows[rowIndex].Cells[8].Value.ToString();
                tbCheckMan.Text = dataGridViewList.Rows[rowIndex].Cells[9].Value.ToString();

                btnStart.Tag = dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString();

                if (string.IsNullOrEmpty(dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString()))
                    btnFinish.Tag = null;
                else
                    btnFinish.Tag = dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString();

                sP_ProdResult_IdleTableAdapter.Fill(dataSetP1C.SP_ProdResult_Idle, checkDate);

                timer1.Start();
                timer2.Start();
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
                Cursor.Current = Cursors.WaitCursor;

                //sP_ProdResult_QueryTableAdapter.Fill(dataSetP1C.SP_ProdResult_Query, DateTime.Parse("1900-01-01"));

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();

                dtpDate.Enabled = true;
                dtpDate.Value = DateTime.Today;
                dtpStartTime.Text = string.Empty;
                dtpDoneTime.Text = string.Empty;
                cbDate.Checked = false;

                timer1.Stop();
                timer2.Stop();

                tbCheckMan.Text = "";
                tbWorkCnt.Text = "";
                tbWorkers.Text = "";
                tbContents.Text = "";
                tbEnergy1.Text = "";
                tbEnergy2.Text = "";

                tbJobTime.Text = "00 : 00 : 00";
                tbIdleTime.Text = "00 : 00 : 00";
                tbRealDriveTime.Text = "00 : 00 : 00";
                btnStart.Tag = null;
                btnFinish.Tag = null;
                sP_ProdResult_IdleTableAdapter.Fill(dataSetP1C.SP_ProdResult_Idle, DateTime.Parse("1900-01-01"));
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

        #region 엔터키로 포커스 이동 / 텍스트 박스 숫자 처리
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
        private void tbQty1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText1 = tbEnergy1.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                string lgsText2 = tbEnergy2.Text.Replace(",", "");

                tbEnergy1.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText1));
                tbEnergy2.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText2));;

                tbEnergy1.SelectionStart = tbEnergy1.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbEnergy1.SelectionLength = 0;
                tbEnergy2.SelectionStart = tbEnergy2.TextLength;
                tbEnergy2.SelectionLength = 0;

                long lQty1 = long.Parse(tbEnergy1.Text.Replace(",", "").Trim());
                long lQty2 = long.Parse(tbEnergy2.Text.Replace(",", "").Trim());
                //tbMoney.Text = (lQty).ToString("#,##0");
            }
            catch (FormatException)
            {
                return;
            }
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

                    //if (columnIndex == dataGridView1.Columns.Count - 1)
                    if (columnIndex == 10)
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

                long qtyA = 0;
                long qtyB = 0;

                if (columnIndex == 9 || columnIndex == 10)
                {
                    if (dataGridView1.Rows[rowIndex].Cells[9].Value != null && dataGridView1.Rows[rowIndex].Cells[9].Value.ToString().Length != 0)
                        qtyA = long.Parse(dataGridView1.Rows[rowIndex].Cells[9].Value.ToString());

                    if (dataGridView1.Rows[rowIndex].Cells[10].Value != null && dataGridView1.Rows[rowIndex].Cells[10].Value.ToString().Length != 0)
                        qtyB = long.Parse(dataGridView1.Rows[rowIndex].Cells[10].Value.ToString());

                    dataGridView1.Rows[rowIndex].Cells[11].Value = (qtyA + qtyB);
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
                if (dataGridView1.CurrentCell != null && endEdit)
                {
                    //if (columnIndex == dataGridView1.Columns.Count - 1)
                    if (columnIndex == 11)
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

            if (e.ColumnIndex == 4) //"품목"
            {
                ProdFinder pop = new ProdFinder();
                pop.cbGubun.SelectedIndex = 1;
                pop._kind = "%";
                pop._stockFlag = "%";
                pop.FormSendEvent += new ProdFinder.FormSendDataHandler(ProdEventMethod);
                pop.ShowDialog();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 14) return;    // 라벨
            if (dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible) == e.RowIndex) return;
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                lblMsg.Text = "생산실적등록 후 라벨 출력이 가능합니다.";
                return;
            }

            dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            dataGridView1.CurrentCell.Selected = true;

            //P1C03_PROD_DONE_SUB1 sub = new P1C03_PROD_DONE_SUB1();
            //sub.parentWin = this;
            //sub.rowIndex = dataGridView1.CurrentCell.RowIndex;
            //sub.ShowDialog();
        }
        private void ProdEventMethod(object sender)
        {
            try
            {
                string sProd = sender.ToString();
                if (string.IsNullOrEmpty(sProd)) return;

                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex < 0) return;

                dataGridView1.Rows[rowIndex].Cells[3].Value = sProd.Substring(0, sProd.IndexOf("#1/"));
                dataGridView1.Rows[rowIndex].Cells[6].Value = sProd.Substring(sProd.IndexOf("#1/") + 3, sProd.IndexOf("#2/") - (sProd.IndexOf("#1/") + 3));
                dataGridView1.Rows[rowIndex].Cells[8].Value = sProd.Substring(sProd.IndexOf("#2/") + 3, sProd.Length - (sProd.IndexOf("#2/") + 3));
                dataGridView1.Rows[rowIndex].Cells[12].Value = "0001";  // 창고 default값
                dataGridView1.CurrentCell = dataGridView1[9, rowIndex];
            }
            catch (Exception)
            {
                return;
            }
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
                if (columnIndex == 9 || columnIndex == 10 || columnIndex == 11)
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
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch1();

            string sDate = dtpDate.Value.ToString();
            if (string.IsNullOrEmpty(sDate))
            {
                ListInit();
            }
            else
            {
                for (int i = 0; i < dataGridViewList.Rows.Count; i++)
                {
                    if (dataGridViewList.Rows[i].Cells[0].Value.ToString() == sDate)
                    {
                        dataGridViewList.CurrentCell = dataGridViewList[0, i];
                        dataGridViewList.CurrentCell.Selected = true;

                        ListSearch2(i);
                        break;
                    }
                }
            }
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;     // 09/07 수정

            ListSearch1();
            ListInit();
            // 전력사용량
            energyUseToday(dtpDate.Value.ToString("yyyy-MM-dd"));
            energyUseYesterday(dtpDate.Value.AddDays(-1).ToString("yyyy-MM-dd"));
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (!cbDate.Checked)
            {
                lblMsg.Text = "삭제할 생산실적을 체크해 주세요.";
                return;
            }            

            if (dtpDate.Enabled)
            {
                lblMsg.Text = "저장된 생산실적만 삭제할 수 있습니다.";
                return;
            }
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");

            DialogResult dr = MessageBox.Show("생산일자 : " + sDate + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_prod_done_main where job_date = '" + sDate + "'";
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.삭제, data);//삭제로그추가

            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sDate);

            ListSearch1();
            ListInit();
            set_production_result("1900-01-01");            // Clear table
            lblMsg.Text = "삭제되었습니다.";
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            dataGridView1.CurrentCell = dataGridView1[4, 0];
            lblMsg.Text = "";

            int iCnt = 0;

            if (dtpDate.Enabled)
            {
                for(int i=0; i<dataGridViewList.RowCount; i++)
                {
                    if(DateTime.Parse(dataGridViewList.Rows[i].Cells[0].Value.ToString()).ToString("yyyy-MM-dd") == dtpDate.Value.ToString("yyyy-MM-dd"))
                    {
                        lblMsg.Text = "해당일자 생산실적은 이미 처리되어 있습니다.";
                        return;
                    }
                }
            }
            energyUseToday(dtpDate.Value.ToString("yyyy-MM-dd"));
            energyUseYesterday(dtpDate.Value.AddDays(-1).ToString("yyyy-MM-dd"));
            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    if (!(dataGridView1.Rows[i].Cells[4].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[4].Value.ToString()))) iCnt++;
            //}

            //if (iCnt == 0)
            //{
            //    lblMsg.Text = "품목정보를 확인해 주세요.";
            //    dataGridView1.Focus();
            //    return;
            //}

            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sJobTimeA = "";
            string sJobTimeB = "";

            if (dtpStartTime.Text.Length == 19) sJobTimeA = dtpStartTime.Text;
            else sJobTimeA = "";

            if (dtpDoneTime.Text.Length == 19) sJobTimeB = dtpDoneTime.Text;
            else sJobTimeB = "";

            string sJobManCnt = tbWorkCnt.Text;
            if (string.IsNullOrEmpty(sJobManCnt)) sJobManCnt = "0";
            string sJonManList = tbWorkers.Text.Trim();
            string sContents = tbContents.Text.Trim();
            string sUserID = G.UserID;
            string sEnergy1 = tbEnergy1.Text.Replace(",", "").Trim();
            string sEnergy2 = tbEnergy2.Text.Replace(",", "").Trim();
            //if (string.IsNullOrEmpty(sEnergy1) || string.IsNullOrEmpty(sEnergy2))
            //{
            //    lblMsg.Text = "전력사용량을 확인하세요";
            //    return;
            //}
            if (string.IsNullOrEmpty(sEnergy1) || string.IsNullOrEmpty(sEnergy2))
            {
                lblMsg.Text = "전력량이 입력되지 않았습니다. 그대로 작업실적을 저장합니다.";
                sEnergy1 = "0";
                sEnergy2 = "0";
            }

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sSeq = string.Empty;
            string sSeq1 = string.Empty;
            string sProdID = string.Empty;
            string sAddSize = string.Empty;
            string sGdQty = string.Empty;
            string sNgQty = string.Empty;
            string sDepot = string.Empty;
            string sTime = string.Empty;

            if (dtpDate.Enabled) //추가 (Enabled가 true)
            {
                sql = "insert into tb_prod_done_main (job_date, job_part, jobtime_a, jobtime_b, jobman_cnt, jobman_list, energy1_a, energy1_b, ment, enter_man) " +
                    "values('" + sDate + "', 'A', if('" + sJobTimeA + "' = '',NOW(),'" + sJobTimeA + "'),if('" + sJobTimeB + "' = '',null,'" + sJobTimeB + "')," + sJobManCnt + ",'" + sJonManList + "'," + sEnergy1 + "," + sEnergy2 + ",'" + sContents + "','" + sUserID + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }

                int seq = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString())) continue;

                    if (i == 0) seq = seq + 10;
                    else seq = seq + 1;

                    sSeq = getProdNoSeq();
                    sSeq1 = seq.ToString();
                    sProdID = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
                    sTime = DateTime.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                    sAddSize = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
                    sGdQty = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();
                    sNgQty = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();
                    sDepot = dataGridView1.Rows[i].Cells[12].Value.ToString().Trim();

                    if (string.IsNullOrEmpty(sGdQty)) sGdQty = "0";
                    if (string.IsNullOrEmpty(sNgQty)) sNgQty = "0";

                    sql = "insert into tb_prod_done_sub (job_date, job_part, job_seq, prod_no, prod_id, add_size, done_qty, ng_qty, depot, enter_dt) " +
                          "values('" + sDate + "', 'A'," + sSeq1 + ",'" + sSeq + "','" + sProdID + "','" + sAddSize + "'," + sGdQty + "," + sNgQty + ",'" + sDepot + "','" + sTime + "')";

                    m.dbCUD(sql, ref msg);
                }
            }
            else //수정
            {
                sql = "update tb_prod_done_main " +
                    "set jobtime_a = if('" + sJobTimeA + "' = '',now(),'" + sJobTimeA + "'), jobtime_b = if('" + sJobTimeB + "' = '',null,'" + sJobTimeB + "'), jobman_cnt = " + sJobManCnt + ", jobman_list = '" + sJonManList + "', energy1_a = " + sEnergy1 + ", energy1_b = " + sEnergy2 + ", ment = '" + sContents + "'" +
                     " where job_date = '" + sDate + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }

                // 일단 삭제
                sql = "DELETE FROM tb_prod_done_sub WHERE job_date = '" + sDate + "'";
                m.dbCUD(sql, ref msg);

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString())) continue;        // 품목코드

                    sProdID = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
                    sTime = DateTime.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                    sAddSize = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
                    sGdQty = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();
                    sNgQty = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();
                    sDepot = dataGridView1.Rows[i].Cells[12].Value.ToString().Trim();

                    if (dataGridView1.Rows[i].Cells[1].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                        sSeq1 = getProdDoneSeq(sDate);
                    //else if(dataGridView1.Rows[i].Cells[16].Value.ToString() == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[16].Value.ToString()))
                    //{
                    //    sSeq1 = getProdDoneSeq(sDate);
                    //}
                    else
                        sSeq1 = dataGridView1.Rows[i].Cells[15].Value.ToString();

                    if (dataGridView1.Rows[i].Cells[2].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                        sSeq = getProdNoSeq();
                    else
                        sSeq = dataGridView1.Rows[i].Cells[2].Value.ToString();
                     
                    if (string.IsNullOrEmpty(sGdQty)) sGdQty = "0";
                    if (string.IsNullOrEmpty(sNgQty)) sNgQty = "0";

                    sql = "insert into tb_prod_done_sub (job_date, job_part, job_seq, prod_no, prod_id, add_size, done_qty, ng_qty, depot, enter_dt) " +
                         "values('" + sDate + "', 'A'," + sSeq1 + ",'" + sSeq + "','" + sProdID + "','" + sAddSize + "'," + sGdQty + "," + sNgQty + ",'" + sDepot + "','" + sTime + "')" +
                    " on duplicate key update" +
                        " prod_id = '" + sProdID + "', add_size = '" + sAddSize + "', done_qty = " + sGdQty + ", ng_qty = " + sNgQty + ", depot = '" + sDepot + "', enter_dt = '" + sTime + "'";

                    m.dbCUD(sql, ref msg);
                }
            }
            ListSearch1();

            for (int i = 0; i < dataGridViewList.Rows.Count; i++)
            {
                if (DateTime.Parse(dataGridViewList.Rows[i].Cells[0].Value.ToString()).ToString("yyyy-MM-dd") == sDate)
                {
                    dataGridViewList.CurrentCell = dataGridViewList[0, i];
                    dataGridViewList.CurrentCell.Selected = true;

                    ListSearch2(i);
                    break;
                }
            }
            m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sDate);
            lblMsg.Text = "저장되었습니다.";
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            //
        }
        #endregion

        #region 포대번호/ 순번 생성
        private string getProdNoSeq()
        {
            string sql = @"select UF_ProdNoGenerator()";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        private string getProdDoneSeq(string sDate)
        {
            string sql = @"select UF_ProdDoneSeqGenerator('" + sDate + "')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        #endregion

        #region other function
        private void P1C02_PROD_RESULT_A_Shown(object sender, EventArgs e)
        {
            dataGridViewList.CurrentCell = null;
            dataGridViewList.ClearSelection();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            set_production_result(dtpDate.Value.ToString("yyyy-MM-dd"));
        }
        #endregion

        #region Condition Bar Events2
        private async void btnStart_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            //if (dtpDate.Enabled)
            //{
            //    lblMsg.Text = "생산일자를 선택하거나 저장해 주세요.";
            //    return;
            //}
            if (btnStart.Tag != null)
            {
                lblMsg.Text = "이미 작업시작된 생산일자입니다.";
                return;
            }

            DialogResult dr = MessageBox.Show("생산일자 : " + dtpDate.Value.ToString("yyyy-MM-dd") + "\r\r해당 정보로 작업시작 하시겠습니까?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.No) return;

            string sJobDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sJobTimeA = "";
            string sJobTimeB = "";

            if (dtpStartTime.Text.Length == 19) sJobTimeA = dtpStartTime.Text;
            else sJobTimeA = "";

            if (dtpDoneTime.Text.Length == 19) sJobTimeB = dtpDoneTime.Text;
            else sJobTimeB = "";

            string sJobManCnt = tbWorkCnt.Text;
            if (string.IsNullOrEmpty(sJobManCnt)) sJobManCnt = "0";
            string sJonManList = tbWorkers.Text.Trim();
            string sContents = tbContents.Text.Trim();
            string sUserID = G.UserID;
            string sEnergy1 = tbEnergy1.Text.Replace(",", "").Trim();
            string sEnergy2 = tbEnergy2.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(sEnergy1) || string.IsNullOrEmpty(sEnergy2))
            {
                lblMsg.Text = "전력사용량을 확인하세요";
                return;
            }

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sSeq = string.Empty;
            string sSeq1 = string.Empty;
            string sProdID = string.Empty;
            string sAddSize = string.Empty;
            string sGdQty = string.Empty;
            string sNgQty = string.Empty;
            string sDepot = string.Empty;
            string sTime = string.Empty;

            if (dtpDate.Enabled) //추가 (Enabled가 true)
            {
                sql = "insert into tb_prod_done_main (job_date, job_part, jobtime_a, jobtime_b, jobman_cnt, jobman_list, energy1_a, energy1_b, ment, enter_man) " +
                    "values('" + sJobDate + "', 'A', if('" + sJobTimeA + "' = '',NOW(),'" + sJobTimeA + "'),if('" + sJobTimeB + "' = '',null,'" + sJobTimeB + "')," + sJobManCnt + ",'" + sJonManList + "'," + sEnergy1 + "," + sEnergy2 + ",'" + sContents + "','" + sUserID + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

                int seq = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString())) continue;

                    if (i == 0) seq = seq + 10;
                    else seq = seq + 1;

                    sSeq = getProdNoSeq();
                    sSeq1 = seq.ToString();
                    sProdID = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
                    sTime = DateTime.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                    sAddSize = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
                    sGdQty = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();
                    sNgQty = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();
                    sDepot = dataGridView1.Rows[i].Cells[12].Value.ToString().Trim();

                    if (string.IsNullOrEmpty(sGdQty)) sGdQty = "0";
                    if (string.IsNullOrEmpty(sNgQty)) sNgQty = "0";

                    sql = "insert into tb_prod_done_sub (job_date, job_part, job_seq, prod_no, prod_id, add_size, done_qty, ng_qty, depot, enter_dt) " +
                          "values('" + sJobDate + "', 'A'," + sSeq1 + ",'" + sSeq + "','" + sProdID + "','" + sAddSize + "'," + sGdQty + "," + sNgQty + ",'" + sDepot + "','" + sTime + "')";

                    m.dbCUD(sql, ref msg);
                }
            }
            else //수정
            {
                sql = "update tb_prod_done_main " +
                    "set jobtime_a = if('" + sJobTimeA + "' = '',now(),'" + sJobTimeA + "'), jobtime_b = if('" + sJobTimeB + "' = '',null,'" + sJobTimeB + "'), jobman_cnt = " + sJobManCnt + ", jobman_list = '" + sJonManList + "', energy1_a = " + sEnergy1 + ", energy1_b = " + sEnergy1 + ", ment = '" + sContents + "'" +
                    " where job_date = '" + sJobDate + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString())) continue;        // 품목코드

                    sProdID = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
                    sTime = DateTime.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                    sAddSize = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
                    sGdQty = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();
                    sNgQty = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();
                    sDepot = dataGridView1.Rows[i].Cells[12].Value.ToString().Trim();

                    if (dataGridView1.Rows[i].Cells[1].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                        sSeq1 = getProdDoneSeq(sJobDate);
                    else
                        sSeq1 = dataGridView1.Rows[i].Cells[15].Value.ToString();

                    if (dataGridView1.Rows[i].Cells[2].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString()))
                        sSeq = getProdNoSeq();
                    else
                        sSeq = dataGridView1.Rows[i].Cells[2].Value.ToString();

                    if (string.IsNullOrEmpty(sGdQty)) sGdQty = "0";
                    if (string.IsNullOrEmpty(sNgQty)) sNgQty = "0";

                    sql = "insert into tb_prod_done_sub (job_date, job_part, job_seq, prod_no, prod_id, add_size, done_qty, ng_qty, depot, enter_dt) " +
                         "values('" + sJobDate + "', 'A'," + sSeq1 + ",'" + sSeq + "','" + sProdID + "','" + sAddSize + "'," + sGdQty + "," + sNgQty + ",'" + sDepot + "','" + sTime + "')" +
                        " on duplicate key update" +
                        " prod_id = '" + sProdID + "', add_size = '" + sAddSize + "', done_qty = " + sGdQty + ", ng_qty = " + sNgQty + ", depot = '" + sDepot + "', enter_dt = '" + sTime + "'";

                    m.dbCUD(sql, ref msg);
                }
            }

            if (msg != "OK")
            {
                lblMsg.Text = "저장에 문제가 있습니다. 확인해 주세요.";
                return;
            }

            int rowIndex = 0;
            ListSearch1();
            dataGridViewList.CurrentCell = dataGridViewList[0, rowIndex];
            dataGridViewList.CurrentCell.Selected = true;

            ListSearch2(rowIndex);

            lblMsg.Text = "작업시작되었습니다.";
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {            
            lblMsg.Text = "";

            if (dtpDate.Enabled)
            {
                lblMsg.Text = "생산일자를 선택하거나 저장해 주세요.";
                return;
            }
            if (btnStart.Tag == null)
            {
                lblMsg.Text = "작업시작되지 않은 생산일자입니다.";
                return;
            }
            if (btnFinish.Tag != null)
            {
                lblMsg.Text = "이미 작업종료된 생산일자입니다.";
                return;
            }

            DialogResult dr = MessageBox.Show("생산일자 : " + dtpDate.Value.ToString("yyyy-MM-dd") + "\r\r해당 정보로 작업종료 하시겠습니까?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.No) return;

            string sJobDate = dtpDate.Value.ToString("yyyy-MM-dd");

            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sql = @"update tb_prod_done_main set jobtime_b = now() where job_date = '" + sJobDate + "'";

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            //sql = "update tb_prod_order set prod_flag = 1 where job_date = '" + sJobDate + "'";
            //m.dbCUD(sql, ref msg);

            //if (msg != "OK")
            //{
            //    lblMsg.Text = msg;
            //    return;
            //}
            
            int rowIndex = dataGridViewList.CurrentRow.Index;
            ListSearch1();
            dataGridViewList.CurrentCell = dataGridViewList[0, rowIndex];
            dataGridViewList.CurrentCell.Selected = true;

            ListSearch2(rowIndex);

            lblMsg.Text = "작업종료되었습니다.";
        }
        private void btnIdle_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (dtpDate.Enabled)
            {
                lblMsg.Text = "생산일자가 선택되지 않았습니다.";
                return;
            }
            if (btnStart.Tag == null)
            {
                lblMsg.Text = "작업시작되지 않은 생산일자입니다.";
                return;
            }
            if (btnFinish.Tag != null)
            {
                lblMsg.Text = "이미 작업종료된 생산일자입니다.";
                return;
            }

            //P1C02_PROD_RESULT_A_IDLE sub = new P1C02_PROD_RESULT_A_IDLE();
            //sub.parentWin = this;
            //sub.jobDate = dtpDate.Value.ToString("yyyy-MM-dd");
            //sub.ShowDialog();
        }
        #endregion

        #region gridIdle
        private void gridIdle_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            dataGridView.ClearSelection();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string sStart = btnStart.Tag.ToString();
                string sFinish = DateTime.Now.ToString();
                if (btnFinish.Tag != null && !string.IsNullOrEmpty(btnFinish.Tag.ToString()))
                    sFinish = btnFinish.Tag.ToString();

                TimeSpan result = DateTime.Parse(sFinish) - DateTime.Parse(sStart);

                tbJobTime.Text = result.TotalHours.ToString("00") + " : " + result.Minutes.ToString("00") + " : " + result.Seconds.ToString("00");

                string sIdel = tbIdleTime.Text;
                if (sIdel == "00 : 00 : 00")
                    tbRealDriveTime.Text = tbJobTime.Text;
                else
                {
                    TimeSpan ts = new TimeSpan(Int32.Parse(sIdel.Substring(0, 2)), Int32.Parse(sIdel.Substring(5, 2)), Int32.Parse(sIdel.Substring(10, 2)));
                    result = result - ts;

                    tbRealDriveTime.Text = result.TotalHours.ToString("00") + " : " + result.Minutes.ToString("00") + " : " + result.Seconds.ToString("00");
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {                
                DateTime dt1, dt2;
                TimeSpan ts = new TimeSpan(00, 00, 00);

                for (int i = 0; i < gridIdle.RowCount; i++)
                {
                    dt1 = DateTime.Parse(gridIdle.Rows[i].Cells[2].Value.ToString());
                    if (string.IsNullOrEmpty(gridIdle.Rows[i].Cells[3].Value.ToString())) dt2 = DateTime.Now;
                    else dt2 = DateTime.Parse(gridIdle.Rows[i].Cells[3].Value.ToString());
                    ts = ts + (dt2 - dt1);
                }

                tbIdleTime.Text = ts.TotalHours.ToString("00") + " : " + ts.Minutes.ToString("00") + " : " + ts.Seconds.ToString("00");
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        #endregion

        #region 생산실적/전력사용량 불러오기
        private void set_production_result(string today)
        {
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            //ProResult[] proResult = new ProResult[10];
            int seq = 10;
            int i = 0;

            using (MySqlConnection conn = new MySqlConnection(G.conStr))
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;

                    cmd.CommandText = "SP_ProductionResult_Query";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new MySqlParameter("workday", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("eqid", MySqlDbType.VarChar));
                    cmd.Parameters["workday"].Value = today;
                    //cmd.Parameters["eqid"].Value = "P006";

                    cmd.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);

                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = dtpDate.Value.ToString("yyyy-MM-dd");    // 생산일자
                        dataGridView1.Rows[i].Cells[1].Value = r["작업조"].ToString();                 // 작업조
                        //dataGridView1.Rows[i].Cells[3].Value = getProdNoSeq();
                        //dataGridView1.Rows[i].Cells[3].Value = dtpDate.Value.ToString("yy") + dtpDate.Value.ToString("MM") + dtpDate.Value.ToString("dd") + (i + 1).ToString("D3");  // prod_no
                        //dataGridView1.Rows[i].Cells[3].Value = "P" + dtpDate.Value.ToString("yy") + dtpDate.Value.ToString("MM") + dtpDate.Value.ToString("dd") + (i + 1).ToString("D3");  // prod_no
                        dataGridView1.Rows[i].Cells[3].Value = r["제품코드"].ToString();
                        dataGridView1.Rows[i].Cells[5].Value = r["생산시간"];
                        dataGridView1.Rows[i].Cells[6].Value = r["품목명"].ToString();
                        dataGridView1.Rows[i].Cells[7].Value = r["규격"].ToString();
                        dataGridView1.Rows[i].Cells[8].Value = "Kg";
                        dataGridView1.Rows[i].Cells[9].Value = r["양품량"].ToString();
                        dataGridView1.Rows[i].Cells[10].Value = r["불량량"].ToString();
                        dataGridView1.Rows[i].Cells[11].Value = r["생산량"].ToString();
                        dataGridView1.Rows[i].Cells[12].Value = r["출하창고"].ToString();
                        dataGridView1.Rows[i].Cells[15].Value = seq.ToString();
                        seq += 1;
                        i += 1;
                    }
                    //lblMsg.Text = "생산실적이 반영되었습니다.";   주석처리 -> 삭제할때도 뜸.
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conn.Close();
                conn.Dispose();
            }
        }
        public void energyUseToday(string today)
        {
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            //ProResult[] proResult = new ProResult[10];
            int i = 0;

            using (MySqlConnection conn = new MySqlConnection(G.conStr))
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;

                    cmd.CommandText = "SP_ProductionEnergy_Query";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new MySqlParameter("eqid", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("workday", MySqlDbType.Date));
                    cmd.Parameters["workday"].Value = today;
                    cmd.Parameters["eqid"].Value = "EM01";

                    cmd.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);

                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        tbEnergy2.Text = r["전력량"].ToString();
                        i += 1;
                    }
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conn.Close();
                conn.Dispose();
            }
        }
        public void energyUseYesterday(string today)
        {
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            //ProResult[] proResult = new ProResult[10];
            int i = 0;

            using (MySqlConnection conn = new MySqlConnection(G.conStr))
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;

                    cmd.CommandText = "SP_ProductionEnergy_Query";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new MySqlParameter("eqid", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("workday", MySqlDbType.Date));
                    cmd.Parameters["workday"].Value = today;
                    cmd.Parameters["eqid"].Value = "EM01";

                    cmd.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    // Fill the DataSet using default values for DataTable names, etc
                    da.Fill(ds);

                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        tbEnergy1.Text = r["전력량"].ToString();
                        i += 1;
                    }
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conn.Close();
                conn.Dispose();
            }
        }
        #endregion

    }
}
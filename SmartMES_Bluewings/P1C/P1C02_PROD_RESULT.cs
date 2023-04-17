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
{
    public partial class P1C02_PROD_RESULT : SmartMES_Bluewings.FormBasic
    {
        int columnIndex = 0;
        int rowIndex = 0;
        bool endEdit = false;

        public P1C02_PROD_RESULT()
        {
            InitializeComponent();
        }
        private void P1C02_PROD_RESULT_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSetP1C.SP_ProdResult_List' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.sP_ProdResult_ListTableAdapter.Fill(this.dataSetP1C.SP_ProdResult_List);
            // TODO: 이 코드는 데이터를 'dataSetP1C.SP_ProdResult_List' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.sP_ProdResult_ListTableAdapter.Fill(this.dataSetP1C.SP_ProdResult_List);
            // TODO: 이 코드는 데이터를 'dataSetP1C.SP_ProdResult_List1' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.sP_ProdResult_List1TableAdapter.Fill(this.dataSetP1C.SP_ProdResult_List1);
            //this.sP_Z_Common_IDTableAdapter.Fill(this.dataSetP1C.SP_Z_Common_ID, "B");
            ListSearch1();
        }
        public void ListSearch1()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

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

                DateTime checkDate = DateTime.Parse(dataGridViewList[1, rowIndex].Value.ToString());        // 생산일자
                dtpDate.Value = checkDate;

                tbJobNo.Text = dataGridViewList.Rows[rowIndex].Cells[0].Value.ToString();
                tbMachine.Tag = dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString();      // 설비코드
                tbMachine.Text = dataGridViewList.Rows[rowIndex].Cells[4].Value.ToString();     // 설비명
                tbProd.Tag = dataGridViewList.Rows[rowIndex].Cells[7].Value.ToString();         // 품목코드
                tbProd.Text = dataGridViewList.Rows[rowIndex].Cells[8].Value.ToString();        // 품목명

                DisplayStdData();

                if (!string.IsNullOrEmpty(tbJobNo.Text))
                    DisplayProductionMachineData(tbJobNo.Text);

                if (dataGridViewList.Rows[rowIndex].Cells[15].Value == null || string.IsNullOrEmpty(dataGridViewList.Rows[rowIndex].Cells[15].Value.ToString()))
                    dtpStartTime.Text = string.Empty;
                else
                    dtpStartTime.Text = DateTime.Parse(dataGridViewList.Rows[rowIndex].Cells[15].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");

                if (dataGridViewList.Rows[rowIndex].Cells[16].Value == null || string.IsNullOrEmpty(dataGridViewList.Rows[rowIndex].Cells[16].Value.ToString()))
                    dtpDoneTime.Text = string.Empty;
                else
                    dtpDoneTime.Text = DateTime.Parse(dataGridViewList.Rows[rowIndex].Cells[16].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");

                if (dataGridViewList.Rows[rowIndex].Cells[17].Value == null || string.IsNullOrEmpty(dataGridViewList.Rows[rowIndex].Cells[17].Value.ToString()))
                    dtpTotalTime.Text = string.Empty;
                else
                    dtpTotalTime.Text = dataGridViewList.Rows[rowIndex].Cells[17].Value.ToString();

                btnStart.Tag = dataGridViewList.Rows[rowIndex].Cells[15].Value.ToString();       // 작업시작

                if (string.IsNullOrEmpty(dataGridViewList.Rows[rowIndex].Cells[16].Value.ToString()))
                    btnFinish.Tag = null;
                else
                    btnFinish.Tag = dataGridViewList.Rows[rowIndex].Cells[16].Value.ToString();

                sP_ProdResult_IdleTableAdapter.Fill(dataSetP1C.SP_ProdResult_Idle, checkDate);

                //timer1.Start();
                //timer2.Start();
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

        public void ListSearch3(int rowIndex)
        {
            lblMsg.Text = "";
            try
            {
                //Cursor.Current = Cursors.WaitCursor;

                //sP_ProdResult_Query1TableAdapter.Fill(dataSetP1C.SP_ProdResult_Query1, tbJobNo.Text, tbMachine.Tag.ToString());

                // 주, 보조 압출기
                {
                    //tbMat1.Text = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
                    //tbMat2.Text = dataGridView2.Rows[rowIndex].Cells[1].Value.ToString();
                    //tbMat3.Text = dataGridView2.Rows[rowIndex].Cells[2].Value.ToString();
                    //tbMat4.Text = dataGridView2.Rows[rowIndex].Cells[3].Value.ToString();
                    //tbMat5.Text = dataGridView2.Rows[rowIndex].Cells[4].Value.ToString();
                    //tbMat6.Text = dataGridView2.Rows[rowIndex].Cells[5].Value.ToString();
                    //tbMat7.Text = dataGridView2.Rows[rowIndex].Cells[6].Value.ToString();
                    //tbMat8.Text = dataGridView2.Rows[rowIndex].Cells[7].Value.ToString();
                    //tbMat9.Text = dataGridView2.Rows[rowIndex].Cells[8].Value.ToString();
                    //tbMat10.Text = dataGridView2.Rows[rowIndex].Cells[9].Value.ToString();
                    //tbMat11.Text = dataGridView2.Rows[rowIndex].Cells[10].Value.ToString();
                    //tbMat12.Text = dataGridView2.Rows[rowIndex].Cells[11].Value.ToString();
                }
                // 주, 보조 속도(압출, 모터) + 인취 / 냉각수
                {
                    //tbSpeed11.Text = dataGridView2.Rows[rowIndex].Cells[12].Value.ToString();
                    //tbSpeed12.Text = dataGridView2.Rows[rowIndex].Cells[13].Value.ToString();
                    //tbSpeed13.Text = dataGridView2.Rows[rowIndex].Cells[17].Value.ToString();     // 인취
                    ////tbSpeed4.Text = dataGridView2.Rows[rowIndex].Cells[14].Value.ToString();
                    ////tbSpeed5.Text = dataGridView2.Rows[rowIndex].Cells[15].Value.ToString();
                    //tbTemp.Text = dataGridView2.Rows[rowIndex].Cells[16].Value.ToString();
                }

                //sP_ProdResult_IdleTableAdapter.Fill(dataSetP1C.SP_ProdResult_Idle, checkDate);

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
                dtpDate.Enabled = true;
                dtpDate.Value = DateTime.Today;
                dtpStartTime.Text = string.Empty;
                dtpTotalTime.Text = string.Empty;
                dtpDoneTime.Text = string.Empty;
                cbDate.Checked = false;
                tbMat11.Text = string.Empty; tbMat12.Text = string.Empty; tbMat13.Text = string.Empty; tbMat14.Text = string.Empty; tbMat15.Text = string.Empty; tbMat16.Text = string.Empty;
                //tbMat7.Text = string.Empty; tbMat8.Text = string.Empty; tbMat9.Text = string.Empty; tbMat10.Text = string.Empty; tbMat11.Text = string.Empty; tbMat12.Text = string.Empty;
                //tbSpeed11.Text = string.Empty; tbSpeed12.Text = string.Empty; tbSpeed13.Text = string.Empty; tbSpeed4.Text = string.Empty; tbSpeed5.Text = string.Empty; tbTemp.Text = string.Empty;

                timer1.Stop();
                timer2.Stop();

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
                //string lgsText1 = tbEnergy1.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...

                //tbEnergy1.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText1));

                //tbEnergy1.SelectionStart = tbEnergy1.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                //tbEnergy1.SelectionLength = 0;

                //long lQty1 = long.Parse(tbEnergy1.Text.Replace(",", "").Trim());
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

            int index = e.RowIndex; // dataGridViewList.CurrentRow.Index;

            ListSearch2(index);
            //ListSearch3(index);
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

            tbProd.Text = "";

            P1C02_PROD_RESULT_SUB sub = new P1C02_PROD_RESULT_SUB();
            sub.parentWin = this;
            sub.Show();
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
            //set_production_result("1900-01-01");            // Clear table
            lblMsg.Text = "삭제되었습니다.";
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;
            lblMsg.Text = "";

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sJobNo = tbJobNo.Text;
            string sMachine = tbMachine.Tag.ToString();
            string sJobTimeA = ""; string sJobTimeB = "";

            if (dtpStartTime.Text.Length == 19) sJobTimeA = dtpStartTime.Text;
            else sJobTimeA = "";

            if (dtpDoneTime.Text.Length == 19) sJobTimeB = dtpDoneTime.Text;
            else sJobTimeB = "";
            string sUserID = G.UserID;

            string sProd = tbProd.Tag.ToString();
            string sMat11 = tbCurMat11.Text.Trim(); string sMat12 = tbCurMat12.Text.Trim(); string sMat13 = tbCurMat13.Text.Trim(); string sMat14 = tbCurMat14.Text.Trim(); string sMat15 = tbCurMat15.Text.Trim(); string sMat16 = tbCurMat16.Text.Trim();
            string sMat21 = ""; string sMat22 = tbCurMat22.Text.Trim(); string sMat23 = tbCurMat23.Text.Trim(); string sMat24 = tbCurMat24.Text.Trim(); string sMat25 = tbCurMat25.Text.Trim(); string sMat26 = tbCurMat26.Text.Trim();
            string sTemp = tbCurTemp.Text.Trim();
            string spdM1 = tbCurSpeed11.Text.Trim(); string spdM2 = tbCurSpeed12.Text.Trim(); string spd3 = tbCurSpeed13.Text.Trim();     // Main 압출, 모터, 인취속도
            string spdS1 = tbCurSpeed21.Text.Trim(); string spdS2 = tbCurSpeed22.Text.Trim();     // Sub 압출, 모터 속도

            if (string.IsNullOrEmpty(tbGoodQty.Text.Trim()) || string.IsNullOrEmpty(tbNgQty.Text.Trim()))
            {
                MessageBox.Show("생산량을 입력하고 저장해 주시기 바랍니다.");
                return;
            }
            {
                // Result Update
                sql = "update tb_prod_result set qty = " + tbGoodQty.Text.Trim() + ", ng_qty = " + tbNgQty.Text.Trim() + ", proc_flag = 1" +
                        " where job_no = '" + sJobNo + "' and machine_id = " + sMachine;
                m.dbCUD(sql, ref msg);
            }
            if (isResultSpec(sJobNo, sMachine))
            {
                // Spec Update
                sql = "update tb_prod_result_spec " +
                    "set main_mat1 = '" + sMat11 + "', main_mat2 = '" + sMat12 + "', main_mat3 = '" + sMat13 + "', main_mat4 = '" + sMat14 + "', main_mat5 = '" + sMat15 + "', main_mat6 = '" + sMat16 +
                    "', sub_mat1 = '" + sMat21 + "', sub_mat2 = '" + sMat22 + "', sub_mat3 = '" + sMat23 + "', sub_mat4 = '" + sMat24 + "', sub_mat5 = '" + sMat25 + "', sub_mat6 = '" + sMat26 +
                    "', main_speed1 = '" + spdM1 + "', main_speed2 = '" + spdM2 + "', sub_speed1 = '" + spdS1 + "', sub_speed2 = '" + spdS2 + "', coolant = '" + sTemp + "', import_good = '" + spd3 +
                    "' where job_no = '" + sJobNo + "' and machine_id = " + sMachine;
                m.dbCUD(sql, ref msg);
            }
            else
            {
                sql = "insert into tb_prod_result_spec (job_no, machine_id, main_mat1, main_mat2, main_mat3, main_mat4, main_mat5, main_mat6, " +
                    "sub_mat1, sub_mat2, sub_mat3, sub_mat4, sub_mat5, sub_mat6, main_speed1, main_speed2, sub_speed1, sub_speed2, coolant, import_good , enter_man) " +
                    "values ('" + sJobNo + "'," + sMachine + ",'" + sMat11 + "','" + sMat12 + "','" + sMat13 + "','" + sMat14 + "','" + sMat15 + "','" + sMat16 + "','" + sMat21 +
                    "','" + sMat22 + "','" + sMat23 + "','" + sMat24 + "','" + sMat25 + "','" + sMat26 + "','" + spdM1 + "','" + spdM2 + "','" + spdS1 + "','" + spdS2 +
                    "','" + sTemp + "','" + spd3 + "','" + G.UserID + "') ";
                m.dbCUD(sql, ref msg);
            }

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }
            ListSearch1();

            for (int i = 0; i < dataGridViewList.Rows.Count; i++)
            {
                if (dataGridViewList.Rows[i].Cells[0].Value.ToString() == sJobNo)
                {
                    dataGridViewList.CurrentCell = dataGridViewList[1, i];      // 생산일자
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

        #region other function
        private void P1C02_PROD_RESULT_Shown(object sender, EventArgs e)
        {
            dataGridViewList.CurrentCell = null;
            dataGridViewList.ClearSelection();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            //set_production_result(dtpDate.Value.ToString("yyyy-MM-dd"));
        }
        // tb_prod_result_spec 테이블에 데이터 있는지 없는지 확인
        private bool isResultSpec(string _jobNo, string _machNo)
        {
            string sql = @"SELECT * FROM tb_prod_result_spec WHERE job_no = '" + _jobNo + "' and machine_id  = " + _machNo;

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            object id = m.dbRonlyOne(sql, ref msg);

            if (msg == "OK" && id != null)
                return true;
            else
                return false;
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
            string sUserID = G.UserID;

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sJobNo = tbJobNo.Text.Trim();
            string sMachineId = tbMachine.Tag.ToString().Trim();
            string sProdID = string.Empty;
            string sAddSize = string.Empty;
            string sGdQty = string.Empty;
            string sNgQty = string.Empty;
            string sDepot = string.Empty;
            string sTime = string.Empty;

            sql = "update tb_prod_result " +
                "set jobtime_start = if('" + sJobTimeA + "' = '',now(),'" + sJobTimeA + "'), jobtime_finish = if('" + sJobTimeB + "' = '',null,'" + sJobTimeB + "')" +
                " where job_no = '" + sJobNo + "' and machine_id = " + sMachineId;

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    if (dataGridView1.Rows[i].Cells[3].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString())) continue;        // 품목코드

            //    sProdID = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
            //    sTime = DateTime.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            //    sAddSize = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
            //    sGdQty = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();
            //    sNgQty = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();
            //    sDepot = dataGridView1.Rows[i].Cells[12].Value.ToString().Trim();

            //    if (dataGridView1.Rows[i].Cells[1].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()))
            //        sSeq1 = getProdDoneSeq(sJobDate);
            //    else
            //        sSeq1 = dataGridView1.Rows[i].Cells[15].Value.ToString();

            //    if (dataGridView1.Rows[i].Cells[2].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString()))
            //        sSeq = getProdNoSeq();
            //    else
            //        sSeq = dataGridView1.Rows[i].Cells[2].Value.ToString();

            //    if (string.IsNullOrEmpty(sGdQty)) sGdQty = "0";
            //    if (string.IsNullOrEmpty(sNgQty)) sNgQty = "0";

            //    sql = "insert into tb_prod_done_sub (job_date, job_part, job_seq, prod_no, prod_id, add_size, done_qty, ng_qty, depot, enter_dt) " +
            //         "values('" + sJobDate + "', 'A'," + sSeq1 + ",'" + sSeq + "','" + sProdID + "','" + sAddSize + "'," + sGdQty + "," + sNgQty + ",'" + sDepot + "','" + sTime + "')" +
            //        " on duplicate key update" +
            //        " prod_id = '" + sProdID + "', add_size = '" + sAddSize + "', done_qty = " + sGdQty + ", ng_qty = " + sNgQty + ", depot = '" + sDepot + "', enter_dt = '" + sTime + "'";

            //    m.dbCUD(sql, ref msg);
            //}
            //}

            //if (msg != "OK")
            //{
            //    lblMsg.Text = "저장에 문제가 있습니다. 확인해 주세요.";
            //    return;
            //}

            //int rowIndex = 0;
            //ListSearch1();
            //dataGridViewList.CurrentCell = dataGridViewList[0, rowIndex];
            //dataGridViewList.CurrentCell.Selected = true;

            //ListSearch2(rowIndex);

            lblMsg.Text = "작업시작되었습니다.";
            btnStart.Tag = DateTime.Now.ToString();
            timer1.Start();
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

            timer1.Stop();
            string sJobDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sJobNo = tbJobNo.Text.Trim();
            string sMachineId = tbMachine.Tag.ToString().Trim();

            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sql = @"update tb_prod_result set jobtime_finish = now() where job_no = '" + sJobNo + "', machine_id = " + sMachineId;

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }
            int rowIndex = dataGridViewList.CurrentRow.Index;
            ListSearch1();
            dataGridViewList.CurrentCell = dataGridViewList[1, rowIndex];
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

            P1C02_PROD_RESULT_IDLE sub = new P1C02_PROD_RESULT_IDLE();
            sub.parentWin = this;
            sub.jobDate = dtpDate.Value.ToString("yyyy-MM-dd");
            sub.ShowDialog();
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

            DisplayMachineStatus(tbMachine.Tag.ToString());
        }

        private void DisplayMachineStatus(string v)
        {
            tbCurMat11.Text = tbMat11.Text;
            tbCurMat12.Text = tbMat12.Text;
            tbCurMat13.Text = tbMat13.Text;
            tbCurMat14.Text = tbMat14.Text;
            tbCurMat15.Text = tbMat15.Text;
            tbCurMat16.Text = tbMat16.Text;
            tbCurMat22.Text = tbMat22.Text;
            tbCurMat23.Text = tbMat23.Text;
            tbCurMat24.Text = tbMat24.Text;
            tbCurMat25.Text = tbMat25.Text;
            tbCurMat26.Text = tbMat26.Text;
            tbCurSpeed11.Text = tbSpeed11.Text;
            tbCurSpeed12.Text = tbSpeed12.Text;
            tbCurSpeed13.Text = tbSpeed13.Text;
            tbCurSpeed21.Text = tbSpeed21.Text;
            tbCurSpeed22.Text = tbSpeed22.Text;
            tbCurTemp.Text = tbTemp.Text;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbProd_TextChanged(object sender, EventArgs e)
        {
            DisplayStdData();
        }

        private void DisplayStdData()
        {
            string msg = string.Empty;
            string sql = string.Empty;
            string sProd_id = tbProd.Tag.ToString();
            if (string.IsNullOrEmpty(sProd_id)) return;

            MariaCRUD m = new MariaCRUD();
            sql = "SELECT * FROM tb_gi_product_spec WHERE prod_id = '" + sProd_id + "'";

            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                tbMat11.Text = table.Rows[0]["main_mat1"].ToString();
                tbMat12.Text = table.Rows[0]["main_mat2"].ToString();
                tbMat13.Text = table.Rows[0]["main_mat3"].ToString();
                tbMat14.Text = table.Rows[0]["main_mat4"].ToString();
                tbMat15.Text = table.Rows[0]["main_mat5"].ToString();
                tbMat16.Text = table.Rows[0]["main_mat6"].ToString();
                tbSpeed11.Text = table.Rows[0]["main_speed1"].ToString();
                tbSpeed12.Text = table.Rows[0]["main_speed2"].ToString();
                tbSpeed13.Text = table.Rows[0]["import_good"].ToString();
                tbMat22.Text = table.Rows[0]["sub_mat2"].ToString();
                tbMat23.Text = table.Rows[0]["sub_mat3"].ToString();
                tbMat24.Text = table.Rows[0]["sub_mat4"].ToString();
                tbMat25.Text = table.Rows[0]["sub_mat5"].ToString();
                tbMat26.Text = table.Rows[0]["sub_mat6"].ToString();
                tbSpeed21.Text = table.Rows[0]["sub_speed1"].ToString();
                tbSpeed22.Text = table.Rows[0]["sub_speed2"].ToString();
                tbTemp.Text = table.Rows[0]["coolant"].ToString();
            }
        }

        private void DisplayProductionMachineData(string JobNo)
        {
            string msg = string.Empty;
            string sql = string.Empty;

            try
            {
                MariaCRUD m = new MariaCRUD();
                sql = "SELECT qty, ng_qty FROM tb_prod_result WHERE job_no = '" + JobNo + "'";
                DataTable table = m.dbDataTable(sql, ref msg);

                if (msg == "OK")
                {
                    tbGoodQty.Text = table.Rows[0]["qty"].ToString();
                    tbNgQty.Text = table.Rows[0]["ng_qty"].ToString();
                }

                sql = "SELECT * FROM tb_prod_result_spec WHERE job_no = '" + JobNo + "'";

                table = m.dbDataTable(sql, ref msg);

                if (msg == "OK")
                {
                    tbCurMat11.Text = table.Rows[0]["main_mat1"].ToString();
                    tbCurMat12.Text = table.Rows[0]["main_mat2"].ToString();
                    tbCurMat13.Text = table.Rows[0]["main_mat3"].ToString();
                    tbCurMat14.Text = table.Rows[0]["main_mat4"].ToString();
                    tbCurMat15.Text = table.Rows[0]["main_mat5"].ToString();
                    tbCurMat16.Text = table.Rows[0]["main_mat6"].ToString();
                    tbCurSpeed11.Text = table.Rows[0]["main_speed1"].ToString();
                    tbCurSpeed12.Text = table.Rows[0]["main_speed2"].ToString();
                    tbCurSpeed13.Text = table.Rows[0]["import_good"].ToString();
                    tbCurMat22.Text = table.Rows[0]["sub_mat2"].ToString();
                    tbCurMat23.Text = table.Rows[0]["sub_mat3"].ToString();
                    tbCurMat24.Text = table.Rows[0]["sub_mat4"].ToString();
                    tbCurMat25.Text = table.Rows[0]["sub_mat5"].ToString();
                    tbCurMat26.Text = table.Rows[0]["sub_mat6"].ToString();
                    tbCurSpeed21.Text = table.Rows[0]["sub_speed1"].ToString();
                    tbCurSpeed22.Text = table.Rows[0]["sub_speed2"].ToString();
                    tbCurTemp.Text = table.Rows[0]["coolant"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("입력된 데이터가 없습니다", "확인");
            }
        }
    }
}
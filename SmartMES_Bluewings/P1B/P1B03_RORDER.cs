using System;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1B03_RORDER : SmartMES_Bluewings.FormBasic
    {
        int columnIndex = 0;
        int rowIndex = 0;
        bool endEdit = false;

        public P1B03_RORDER()
        {
            InitializeComponent();
        }
        private void P1B03_RORDER_Load(object sender, EventArgs e)
        {
            cbGubun.SelectedIndex = 0;
            ListSearch1();
        }
        public async void ListSearch1()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();

                sP_ROrderMain_QueryTableAdapter.Fill(dataSetP1B.SP_ROrderMain_Query, sSearch);
                var data = dataSetP1B.SP_ROrderMain_Query;
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
        public void ListSearch2(int rowIndex)
        {
            Cursor.Current = Cursors.WaitCursor;
            lblMsg.Text = "";

            cbNo.Checked = false;
            tbNo.Text = dataGridViewList.Rows[rowIndex].Cells[0].Value.ToString();
            dtpDate.Value = DateTime.Parse(dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString());
            tbCust.Tag = dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString();
            tbCust.Text = dataGridViewList.Rows[rowIndex].Cells[4].Value.ToString();
            tbPlace.Text = dataGridViewList.Rows[rowIndex].Cells[6].Value.ToString();
            dtpDeliDate.Value = DateTime.Parse(dataGridViewList.Rows[rowIndex].Cells[7].Value.ToString());
            tbContents.Text = dataGridViewList.Rows[rowIndex].Cells[8].Value.ToString();
            if (dataGridViewList.Rows[rowIndex].Cells[11].Value.ToString() == "B") cbGubun.Text = "B.민간";
            else cbGubun.Text = "A.조달";
            tbMethod.Text = dataGridViewList.Rows[rowIndex].Cells[12].Value.ToString();

            Cursor.Current = Cursors.Default;
        }
        public async void ListSearch3()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sNo = tbNo.Text;

                sP_ROrderSub_QueryTableAdapter.Fill(dataSetP1B.SP_ROrderSub_Query, sNo);
                var data = dataSetP1B.SP_ROrderSub_Query;
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
        public void ListSearch4()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                int iCnt = 0;
                long lSum = 0;
                string sMoney;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value != null) iCnt++;

                    if (dataGridView1.Rows[i].Cells[10].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[10].Value.ToString()))
                        sMoney = "0";
                    else
                        sMoney = dataGridView1.Rows[i].Cells[10].Value.ToString();

                    lSum += long.Parse(sMoney);
                }

                lblSumMoney.Text = "합계금액 : " + lSum.ToString("#,##0") + "원";
                lblCnt.Text = iCnt.ToString() + "건";
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

            cbNo.Checked = false;
            tbNo.Text = string.Empty;
            dtpDate.Value = DateTime.Today;
            tbCust.Tag = string.Empty;
            tbCust.Text = string.Empty;
            tbPlace.Text = string.Empty;
            dtpDeliDate.Value = DateTime.Today;
            tbContents.Text = string.Empty;
            cbGubun.SelectedIndex = 0;
            tbMethod.Text = string.Empty;

            sP_ROrderSub_QueryTableAdapter.Fill(dataSetP1B.SP_ROrderSub_Query, "");

            lblSumMoney.Text = "합계금액 : 0원";
            lblCnt.Text = "0건";
        }

        #region Controls Event
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch1();
            }
        }
        private async void btnCopy_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (!cbNo.Checked)
            {
                lblMsg.Text = "복사할 수주번호를 체크해 주세요.";
                return;
            }

            string sNo = tbNo.Text;

            if (string.IsNullOrEmpty(sNo))
            {
                lblMsg.Text = "저장된 수주번호만 복사할 수 있습니다.";
                return;
            }

            DialogResult dr = MessageBox.Show("수주번호 : " + sNo + "\r\r해당 수주정보를 새로운 수주번호로 복사하시겠습니까?", this.lblTitle.Text + "[수주복사]", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();
            string sNewNo = getROrderNo();

            sql = "insert into tb_rorder_main (rorder_id, pos, rorder_date, cust_id, gubun, project, place, deli_date, method, enter_man) " +
                  "select '" + sNewNo + "','" + G.Pos + "', CURDATE(), cust_id, gubun, project, place, CURDATE(), method, '" + G.UserID + "' " +
                  "from tb_rorder_main " +
                  "where rorder_id = '" + sNo + "'";

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            sql = "insert into tb_rorder_sub (rorder_id, rorder_seq, prod_id, add_name, add_size, qty, danga, discount, amount, vat, bigo, proc_std) " +
                  "select '" + sNewNo + "', rorder_seq, prod_id, add_name, add_size, qty, danga, discount, amount, vat, bigo, proc_std " +
                  "from tb_rorder_sub " +
                  "where rorder_id = '" + sNo + "' " +
                  "order by rorder_seq";

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            tbSearch.Text = "";
            ListSearch1();

            for (int i = 0; i < dataGridViewList.Rows.Count; i++)
            {
                if (dataGridViewList.Rows[i].Cells[0].Value.ToString() == sNewNo)
                {
                    dataGridViewList.CurrentCell = dataGridViewList[2, i];
                    dataGridViewList.CurrentCell.Selected = true;

                    ListSearch2(i);
                    ListSearch3();
                    ListSearch4();
                    break;
                }
            }

            lblMsg.Text = "복사되었습니다.";
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가
        }
        private void lblCust_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            CustFinder sub = new CustFinder();
            sub.FormSendEvent += new CustFinder.FormSendDataHandler(PostEventMethod);
            sub._gubun = "103";
            sub.ShowDialog();
        }
        private void PostEventMethod(object sender)
        {
            string sCust = sender.ToString();

            if (string.IsNullOrEmpty(sCust)) return;

            tbCust.Tag = sCust.Substring(0, sCust.IndexOf("#1/"));
            tbCust.Text = sCust.Substring(sCust.IndexOf("#1/") + 3, sCust.IndexOf("#2/") - (sCust.IndexOf("#1/") + 3));
            tbPlace.Focus();
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
            ListSearch3();
            ListSearch4();
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
                        dataGridView1.CurrentCell = dataGridView1[4, rowIndex + 1];
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

                float money1 = 0;
                float money2 = 0;
                long moneyA = 0;
                long moneyB = 0;
                float discount = 100;

                if (columnIndex == 7 || columnIndex == 8 || columnIndex == 9)
                {
                    if (dataGridView1.Rows[rowIndex].Cells[7].Value != null && dataGridView1.Rows[rowIndex].Cells[7].Value.ToString().Length != 0)
                        money1 = float.Parse(dataGridView1.Rows[rowIndex].Cells[7].Value.ToString());   // 수량

                    if (dataGridView1.Rows[rowIndex].Cells[8].Value != null && dataGridView1.Rows[rowIndex].Cells[8].Value.ToString().Length != 0)
                        money2 = float.Parse(dataGridView1.Rows[rowIndex].Cells[8].Value.ToString());   // 단가

                    moneyA = (long)(money1 * money2);

                    if (dataGridView1.Rows[rowIndex].Cells[9].Value != null && dataGridView1.Rows[rowIndex].Cells[9].Value.ToString().Length != 0)  // 할인율 추가 (1/19)
                    {
                        discount = (float.Parse(dataGridView1.Rows[rowIndex].Cells[9].Value.ToString()) / 100);
                        moneyA -= (long) (moneyA * discount);
                    }
                }
                
                dataGridView1.Rows[rowIndex].Cells[10].Value = moneyA;
                ListSearch4();
            }
            catch(Exception)
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
                    if (columnIndex == 10)
                        dataGridView1.CurrentCell = dataGridView1[4, rowIndex + 1];
                    else
                        dataGridView1.CurrentCell = dataGridView1[columnIndex + 1, rowIndex];

                    endEdit = false;
                }
            }
            catch(Exception)
            {
                return;
            }
        }
        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMsg.Text = "";
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 3) //"품목"
            {
                ProdFinder pop = new ProdFinder();
                pop.cbGubun.SelectedIndex = 1;
                pop._kind = "%";
                pop._stockFlag = "%";
                pop.FormSendEvent += new ProdFinder.FormSendDataHandler(ProdEventMethod);
                pop.ShowDialog();
            }
            else if (e.ColumnIndex == 19) //"X"
            {
                try
                {
                    string sNo = tbNo.Text;

                    if (string.IsNullOrEmpty(sNo))
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                        return;
                    }

                    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()))
                    {
                        dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                        return;
                    }

                    if (dataGridView1.RowCount <= 2)
                    {
                        lblMsg.Text = "수주건 전체를 삭제해주세요";
                        return;
                    }

                    string sSeq = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                    DialogResult dr = MessageBox.Show("해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.No) return;

                    MariaCRUD m = new MariaCRUD();
                    string sql = "delete from tb_rorder_sub where rorder_id = '" + sNo + "' and rorder_seq = " + sSeq;
                    string msg = string.Empty;
                    m.dbCUD(sql, ref msg);

                    if (msg != "OK")
                    {
                        MessageBox.Show(msg);
                        return;
                    }

                    //string sEstimateNo = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                    //string sEstimateSeq = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
                    //if (!string.IsNullOrEmpty(sEstimateNo))
                    //{
                    //    sql = "update tb_estimate_sub set rorder_flag = 0 where estimate_id = '" + sEstimateNo + "' and estimate_seq = " + sEstimateSeq;
                    //    m.dbCUD(sql, ref msg);
                    //}

                    var data = sql;
                    var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.삭제, data);//삭제로그추가
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                    m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sNo + " " + sSeq);
                }
                catch (Exception)
                {
                    return;
                }
            }

            ListSearch4();
        }
        private void ProdEventMethod(object sender)
        {
            try
            {
                string sProd = sender.ToString();
                if (string.IsNullOrEmpty(sProd)) return;

                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (rowIndex < 0) return;

                dataGridView1.Rows[rowIndex].Cells[2].Value = sProd.Substring(0, sProd.IndexOf("#1/"));
                dataGridView1.Rows[rowIndex].Cells[4].Value = sProd.Substring(sProd.IndexOf("#1/") + 3, sProd.IndexOf("#2/") - (sProd.IndexOf("#1/") + 3));
                dataGridView1.Rows[rowIndex].Cells[6].Value = sProd.Substring(sProd.IndexOf("#2/") + 3, sProd.IndexOf("#3/") - (sProd.IndexOf("#2/") + 3)); // sProd.Substring(sProd.IndexOf("#2/") + 3, sProd.Length - (sProd.IndexOf("#2/") + 3));
                dataGridView1.CurrentCell = dataGridView1[7, rowIndex];

                //if (rowIndex < 1)
                //    dataGridView1.Rows[rowIndex].Cells[21].Value = "0001";
                //else
                //    dataGridView1.Rows[rowIndex].Cells[21].Value = dataGridView1.Rows[rowIndex - 1].Cells[21].Value;
            }
            catch(Exception)
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
                if (columnIndex == 7 || columnIndex == 8 || columnIndex == 9 || columnIndex == 10 || columnIndex == 11)
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

            string sNo = tbNo.Text;
            if (string.IsNullOrEmpty(sNo))
            {
                ListInit();
            }
            else
            {
                for (int i = 0; i < dataGridViewList.Rows.Count; i++)
                {
                    if (dataGridViewList.Rows[i].Cells[0].Value.ToString() == sNo)
                    {
                        dataGridViewList.CurrentCell = dataGridViewList[2, i];
                        dataGridViewList.CurrentCell.Selected = true;

                        ListSearch2(i);
                        ListSearch3();
                        ListSearch4();
                        break;
                    }
                }
            }
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            ListSearch1();
            ListInit();
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (!cbNo.Checked)
            {
                lblMsg.Text = "삭제할 수주번호를 체크해 주세요.";
                return;
            }

            string sNo = tbNo.Text;

            if (string.IsNullOrEmpty(sNo))
            {
                lblMsg.Text = "저장된 수주번호만 삭제할 수 있습니다.";
                return;
            }

            DialogResult dr = MessageBox.Show("수주번호 : " + sNo + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_rorder_main where rorder_id = '" + sNo + "'";
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }

            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.삭제, data);//삭제로그추가
            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sNo + " " + tbCust.Text);

            ListSearch1();
            ListInit();
        }
        private async void pbSave_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            dataGridView1.CurrentCell = dataGridView1[4, 0];
            lblMsg.Text = "";

            if (tbCust.Tag == null || string.IsNullOrEmpty(tbCust.Tag.ToString()))
            {
                lblMsg.Text = "거래처명을 선택해 주세요.";
                lblCust.Focus();
                return;
            }

            int iCnt = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (!(dataGridView1.Rows[i].Cells[2].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString()))) iCnt++;
            }

            if (iCnt == 0)
            {
                lblMsg.Text = "품목정보를 확인해 주세요.";
                dataGridView1.Focus();
                return;
            }

            string sNo = tbNo.Text;
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sCust = tbCust.Tag.ToString();
            string sCustName = tbCust.Text;
            string sProject = tbPlace.Text.Trim();
            string sPlace = ""; // tbPlace.Text.Trim();
            string sDeliDate = dtpDeliDate.Value.ToString("yyyy-MM-dd");
            string sContents = tbContents.Text.Trim();
            string sGubun = cbGubun.Text.Substring(0,1);
            string sMethod = tbMethod.Text.Trim();

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sSeq = string.Empty;
            string sProdID = string.Empty;
            string sAddSize = string.Empty;
            string sQty = string.Empty;
            string sDanga = string.Empty;
            string discount = string.Empty;
            string sAmount = string.Empty;
            string sProcStd = "0001";

            if (string.IsNullOrEmpty(sNo)) //추가
            {
                sNo = getROrderNo();
                sql = "insert into tb_rorder_main (rorder_id, pos, rorder_date, cust_id, gubun, project, place, deli_date, method, contents, enter_man) " +
                    "values('" + sNo + "','" + G.Pos + "','" + sDate + "','" + sCust + "','" + sGubun + "','" + sProject + "','" + sPlace + "','" + sDeliDate + "','" + sMethod + "','" + sContents + "','" + G.UserID + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }

                tbNo.Text = sNo;

                int seq = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString())) continue;

                    seq = seq + 10;
                    sSeq = seq.ToString();
                    sProdID = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
                    sAddSize = dataGridView1.Rows[i].Cells[5].Value.ToString().Trim();
                    sQty = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
                    sDanga = dataGridView1.Rows[i].Cells[8].Value.ToString().Trim();
                    discount = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();  // 할인율
                    sAmount = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();

                    if (string.IsNullOrEmpty(sQty)) sQty = "0";
                    if (string.IsNullOrEmpty(sDanga)) sDanga = "0";
                    if (string.IsNullOrEmpty(discount)) discount = "100";
                    if (string.IsNullOrEmpty(sAmount)) sAmount = "0";

                    sql = "insert into tb_rorder_sub (rorder_id, rorder_seq, prod_id, add_size, qty, danga, discount, amount, proc_std) " +
                          "values('" + sNo + "'," + sSeq + ",'" + sProdID + "','" + sAddSize + "'," + sQty + "," + sDanga + "," + discount + "," + sAmount + ",'" + sProcStd + "')";

                    m.dbCUD(sql, ref msg);
                    var data = sql;
                    var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

                }
            }
            else //수정
            {
                sql = "update tb_rorder_main " +
                    "set rorder_date = '" + sDate + "', cust_id = '" + sCust + "', gubun = '" + sGubun + "', project = '" + sProject + "', place = '" + sPlace + "', deli_date = '" + sDeliDate + "', method = '" + sMethod + "', contents = '" + sContents + "'" +
                    " where rorder_id = '" + sNo + "'";

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
                    if (dataGridView1.Rows[i].Cells[2].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString())) continue;

                    sProdID = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
                    sAddSize = dataGridView1.Rows[i].Cells[5].Value.ToString().Trim();
                    sQty = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
                    sDanga = dataGridView1.Rows[i].Cells[8].Value.ToString().Trim();
                    discount = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();  // 할인율
                    sAmount = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();

                    if (dataGridView1.Rows[i].Cells[1].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                        sSeq = getROrderSeq(sNo);
                    else
                        sSeq = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    if (string.IsNullOrEmpty(sQty)) sQty = "0";
                    if (string.IsNullOrEmpty(sDanga)) sDanga = "0";
                    if (string.IsNullOrEmpty(discount)) discount = "100";
                    if (string.IsNullOrEmpty(sAmount)) sAmount = "0";

                    sql = "insert into tb_rorder_sub (rorder_id, rorder_seq, prod_id, add_size, qty, danga, discount, amount, proc_std) " +
                        " values('" + sNo + "'," + sSeq + ",'" + sProdID + "','" + sAddSize + "'," + sQty + "," + sDanga + "," + discount + "," + sAmount + ",'" + sProcStd + "')" +
                        " on duplicate key update" +
                        " prod_id = '" + sProdID + "', add_size = '" + sAddSize + "', qty = " + sQty + ", danga = " + sDanga + ", discount = " + discount + ", amount = " + sAmount + ", proc_std = '" + sProcStd + "'";

                    m.dbCUD(sql, ref msg);
                }
            }

            tbSearch.Text = "";
            ListSearch1();

            for (int i = 0; i < dataGridViewList.Rows.Count; i++)
            {
                if (dataGridViewList.Rows[i].Cells[0].Value.ToString() == sNo)
                {
                    dataGridViewList.CurrentCell = dataGridViewList[2, i];
                    dataGridViewList.CurrentCell.Selected = true;

                    ListSearch2(i);
                    ListSearch3();
                    ListSearch4();
                    break;
                }
            }

            m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sNo + "-" + tbCust.Text);
            lblMsg.Text = "저장되었습니다.";
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            //
        }
        #endregion

        #region 수주번호 생성
        private string getROrderNo()
        {
            string sql = @"select UF_ROrderNoGenerator('" + G.Pos + "')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        private string getROrderSeq(string sNo)
        {
            string sql = @"select UF_ROrderSeqGenerator('" + sNo + "')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        #endregion
    }
}

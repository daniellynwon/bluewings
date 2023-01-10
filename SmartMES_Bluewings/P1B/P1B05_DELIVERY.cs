using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1B05_DELIVERY : SmartMES_Bluewings.FormBasic
    {
        int columnIndex = 0;
        int rowIndex = 0;
        bool endEdit = false;

        public P1B05_DELIVERY()
        {
            InitializeComponent();
        }
        private void P1B05_DELIVERY_Load(object sender, EventArgs e)
        {
            ListSearch1();
            cbDeliCar.SelectedIndex = 0;
        }
        public async void ListSearch1()
        {
            lblMsg.Text = "";
            lblBarcode.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();

                sP_DeliveryMain_QueryTableAdapter.Fill(dataSetP1B.SP_DeliveryMain_Query, sSearch);
                var data = dataSetP1B.SP_DeliveryMain_Query;
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
            lblBarcode.Text = "";

            cbNo.Checked = false;
            tbNo.Text = dataGridViewList.Rows[rowIndex].Cells[0].Value.ToString();
            dtpDate.Value = DateTime.Parse(dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString());
            tbCust.Tag = dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString();
            tbCust.Text = dataGridViewList.Rows[rowIndex].Cells[4].Value.ToString();
            tbPlace.Text = dataGridViewList.Rows[rowIndex].Cells[7].Value.ToString();
            tbSaleMan.Text = dataGridViewList.Rows[rowIndex].Cells[5].Value.ToString();

            string sCar = dataGridViewList.Rows[rowIndex].Cells[8].Value.ToString();
            if (sCar == "9") cbDeliCar.SelectedIndex = cbDeliCar.Items.Count - 1;
            else cbDeliCar.SelectedIndex = Int32.Parse(sCar) - 1;

            tbDeliInfo.Text = dataGridViewList.Rows[rowIndex].Cells[9].Value.ToString();
            tbContents.Text = dataGridViewList.Rows[rowIndex].Cells[11].Value.ToString();
            tbDOrder.Text = dataGridViewList.Rows[rowIndex].Cells[12].Value.ToString();

            Cursor.Current = Cursors.Default;
        }
        public async void ListSearch3()
        {
            lblMsg.Text = "";
            lblBarcode.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sNo = tbNo.Text;

                sP_DeliverySub_QueryTableAdapter.Fill(dataSetP1B.SP_DeliverySub_Query, sNo);
                var data = dataSetP1B.SP_DeliverySub_Query;
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
            lblBarcode.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                int iCnt = 0;
                long lSum = 0;
                long lTot = 0;
                string sMoneySum;
                string sMoneyTot;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value != null) iCnt++;
                    //
                    if (dataGridView1.Rows[i].Cells[9].Value == null ||
                        string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[9].Value.ToString()))
                        sMoneySum = "0";
                    else
                        sMoneySum = dataGridView1.Rows[i].Cells[9].Value.ToString();

                    lSum += long.Parse(sMoneySum);
                    //
                    if (dataGridView1.Rows[i].Cells[11].Value == null ||
                        string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[11].Value.ToString()))
                        sMoneyTot = "0";
                    else
                        sMoneyTot = dataGridView1.Rows[i].Cells[11].Value.ToString();

                    lTot += long.Parse(sMoneyTot);
                }

                lblSumMoney.Text = "합계금액 : " + lSum.ToString("#,##0") + "원";
                lblTotMoney.Text = "전체금액 : " + lTot.ToString("#,##0") + "원";
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
            lblBarcode.Text = "";

            cbNo.Checked = false;
            tbNo.Text = string.Empty;
            tbDOrder.Text = string.Empty;
            dtpDate.Value = DateTime.Today;
            tbCust.Tag = string.Empty;
            tbCust.Text = string.Empty;
            tbPlace.Text = string.Empty;
            tbSaleMan.Text = string.Empty;
            tbContents.Text = string.Empty;
            tbDeliInfo.Text = string.Empty;

            sP_DeliverySub_QueryTableAdapter.Fill(dataSetP1B.SP_DeliverySub_Query, "");

            lblSumMoney.Text = "합계금액 : 0원";
            lblTotMoney.Text = "전체금액 : 0원";
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
            tbSaleMan.Text = sCust.Substring(sCust.IndexOf("#2/") + 3, sCust.Length - (sCust.IndexOf("#2/") + 3));
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

                    if (columnIndex == 12)
                        dataGridView1.CurrentCell = dataGridView1[3, rowIndex + 1];
                    else
                        dataGridView1.CurrentCell = dataGridView1[columnIndex + 1, rowIndex];
                }
                if (e.KeyCode == Keys.Tab)
                {
                    e.Handled = true;
                }
            }
            //catch (ArgumentOutOfRangeException)
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

                int money1 = 0;
                int money2 = 0;
                int moneyMon = 0;

                if (columnIndex == 7 || columnIndex == 8) //수량, 단가
                {
                    if (dataGridView1.Rows[rowIndex].Cells[7].Value != null &&
                        dataGridView1.Rows[rowIndex].Cells[7].Value.ToString().Length != 0)
                        money1 = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[7].Value.ToString());

                    if (dataGridView1.Rows[rowIndex].Cells[8].Value != null &&
                        dataGridView1.Rows[rowIndex].Cells[8].Value.ToString().Length != 0)
                        money2 = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[8].Value.ToString());

                    moneyMon = money1 * money2;
                    dataGridView1.Rows[rowIndex].Cells[9].Value = moneyMon;
                    dataGridView1.Rows[rowIndex].Cells[10].Value = Math.Round(moneyMon * 0.1);
                    dataGridView1.Rows[rowIndex].Cells[11].Value = moneyMon + Math.Round(moneyMon * 0.1);

                    ListSearch4();
                }
                else if (columnIndex == 9) //금액
                {
                    if (dataGridView1.Rows[rowIndex].Cells[9].Value != null &&
                        dataGridView1.Rows[rowIndex].Cells[9].Value.ToString().Length != 0)
                        moneyMon = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[9].Value.ToString());

                    dataGridView1.Rows[rowIndex].Cells[10].Value = Math.Round(moneyMon * 0.1);
                    dataGridView1.Rows[rowIndex].Cells[11].Value = moneyMon + Math.Round(moneyMon * 0.1);

                    ListSearch4();
                }
                else if (columnIndex == 10) //부가세
                {
                    if (dataGridView1.Rows[rowIndex].Cells[9].Value != null &&
                        dataGridView1.Rows[rowIndex].Cells[9].Value.ToString().Length != 0)
                        money1 = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[9].Value.ToString());

                    if (dataGridView1.Rows[rowIndex].Cells[10].Value != null &&
                        dataGridView1.Rows[rowIndex].Cells[10].Value.ToString().Length != 0)
                        money2 = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[10].Value.ToString());

                    moneyMon = money1 + money2;
                    dataGridView1.Rows[rowIndex].Cells[11].Value = moneyMon;

                    ListSearch4();
                }
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
                    if (columnIndex == 12)
                        dataGridView1.CurrentCell = dataGridView1[3, rowIndex + 1];
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
            lblBarcode.Text = "";
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 17)
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
                        lblMsg.Text = "출하건 전체를 삭제해주세요";
                        return;
                    }

                    string sSeq = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                    DialogResult dr = MessageBox.Show("해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.No) return;

                    MariaCRUD m = new MariaCRUD();
                    string sql = "delete from tb_delivery_sub where deli_id = '" + sNo + "' and deli_seq = " + sSeq;
                    string msg = string.Empty;
                    m.dbCUD(sql, ref msg);

                    if (msg != "OK")
                    {
                        MessageBox.Show(msg);
                        return;
                    }
                    var data = sql;
                    var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.삭제, data);//삭제로그추가
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                    m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sNo + " " + sSeq);
                }
                //catch (InvalidOperationException)
                catch (Exception)
                {
                    return;
                }
            }

            ListSearch4();
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.RowCount < 2) return;

            long lQty = 0;
            long lDanga = 0;
            long lAmount = 0;
            long lVat = 0;
            long lTot = 0;

            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    lQty = Convert.ToInt64(row.Cells[7].Value);
                    lDanga = Convert.ToInt64(row.Cells[8].Value);
                    lAmount = Convert.ToInt64(row.Cells[9].Value);
                    lVat = Convert.ToInt64(row.Cells[10].Value);
                    lTot = Convert.ToInt64(row.Cells[11].Value);

                    if ((lQty * lDanga) == lAmount)
                        row.Cells[9].Style.ForeColor = Color.Empty;
                    else
                        row.Cells[9].Style.ForeColor = Color.Red;

                    if ((lAmount + lVat) == lTot)
                        row.Cells[11].Style.ForeColor = Color.Empty;
                    else
                        row.Cells[11].Style.ForeColor = Color.Red;
                }
                ListSearch4();
            }
            //catch (InvalidCastException)
            catch (Exception)
            {
                return;
            }
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

            P1B05_DELIVERY_SUB sub = new P1B05_DELIVERY_SUB();
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (!cbNo.Checked)
            {
                lblMsg.Text = "삭제할 전표번호를 체크해 주세요.";
                return;
            }

            string sNo = tbNo.Text;

            if (string.IsNullOrEmpty(sNo))
            {
                lblMsg.Text = "저장된 전표번호만 삭제할 수 있습니다.";
                return;
            }

            DialogResult dr = MessageBox.Show("전표번호 : " + sNo + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_delivery_main where deli_id = '" + sNo + "'";
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show("전표번호 : '" + sNo + "'\r\r이미 타 업무에서 사용중인 전표번호이므로,\r삭제할 수 없습니다.");
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

            dataGridView1.CurrentCell = dataGridView1[3, 0];
            lblMsg.Text = "";
            lblBarcode.Text = "";
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
            if (tbCust.Tag == null || string.IsNullOrEmpty(tbCust.Tag.ToString()))
            {
                lblMsg.Text = "거래처명을 선택해 주세요.";
                lblCust.Focus();
                return;
            }

            string sNo = tbNo.Text;
            string sDNo = tbDOrder.Text;
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sCust = tbCust.Tag.ToString();
            string sPlace = tbPlace.Text.Trim();
            string sDeliCar = cbDeliCar.Text.Substring(0, 1);
            string sDeliInfo = tbDeliInfo.Text.Trim();
            string sContents = tbContents.Text.Trim();

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sSeq = string.Empty;
            string sProdID = string.Empty;
            string sAddSize = string.Empty;
            string sQty = string.Empty;
            string sDanga = string.Empty;
            string sAmount = string.Empty;
            string sVat = string.Empty;
            string sProdNo = string.Empty;
            string sRorderNo = string.Empty;
            string sRorderSeq = string.Empty;

            if (string.IsNullOrEmpty(sNo)) //추가
            {
                sNo = getDeliNo(sDate);
                sql = "insert into tb_delivery_main (deli_id, pos, deli_date, dorder_id, cust_id, place, deli_car, deli_info, contents, enter_man) " +
                    "values('" + sNo + "','" + G.Pos + "','" + sDate + "','" + sDNo + "','" + sCust + "','" + sPlace + "'," + sDeliCar + ",'" + sDeliInfo + "','" + sContents + "','" + G.UserID + "')";

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
                    sAmount = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();
                    sVat = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();
                    sProdNo = dataGridView1.Rows[i].Cells[12].Value.ToString().Trim();
                    sRorderNo = dataGridView1.Rows[i].Cells[14].Value.ToString().Trim();
                    sRorderSeq = dataGridView1.Rows[i].Cells[15].Value.ToString().Trim();

                    if (string.IsNullOrEmpty(sQty)) sQty = "0";
                    if (string.IsNullOrEmpty(sDanga)) sDanga = "0";
                    if (string.IsNullOrEmpty(sAmount)) sAmount = "0";
                    if (string.IsNullOrEmpty(sVat)) sVat = "0";

                    sql = "insert into tb_delivery_sub (deli_id, deli_seq, depot, prod_id, add_size, qty, danga, amount, vat, rorder_id, rorder_seq, prod_no, dorder_id, dorder_seq, deli_dt) " +
                          "values('" + sNo + "'," + sSeq + ",'0001','" + sProdID + "','" + sAddSize + "'," + sQty + "," + sDanga + "," + sAmount + "," + sVat + ",'" + sRorderNo + "'," + sRorderSeq + ",'" + sProdNo + "','" + sDNo + "'," + sSeq + ",'" + sDate + "')";
                    m.dbCUD(sql, ref msg);

                    // 출하지시 flag = 1
                    sql = "UPDATE tb_rorder_sub set deli_flag = 1 WHERE (1) AND " +
                        "(SELECT SUM(ds.qty) FROM tb_deliorder_sub dos INNER JOIN tb_delivery_sub ds ON ds.dorder_id = dos.dorder_id AND ds.dorder_seq = dos.dorder_seq " +
                        " WHERE dos.rorder_id = rs.rorder_id AND dos.rorder_seq = rs.rorder_seq) >= rs.qty AND rs.rorder_id = '" + sRorderNo + "' AND rs.rorder_seq = " + sRorderSeq;
                    m.dbCUD(sql, ref msg);
                    var data = sql;
                    var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가
                }
            }
            else //수정
            {
                sql = "update tb_delivery_main " +
                    "set deli_date = '" + sDate + "', dorder_id = '" + sDNo + "', cust_id = '" + sCust + "', place = '" + sPlace + "', deli_car = '" + sDeliCar + "', deli_info = '" + sDeliInfo + "', contents = '" + sContents + "'" +
                    " where deli_id = '" + sNo + "'";

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
                    sAmount = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();
                    sVat = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();
                    sProdNo = dataGridView1.Rows[i].Cells[12].Value.ToString().Trim();
                    sRorderNo = dataGridView1.Rows[i].Cells[14].Value.ToString().Trim();
                    sRorderSeq = dataGridView1.Rows[i].Cells[15].Value.ToString().Trim();



                    if (string.IsNullOrEmpty(sQty)) sQty = "0";
                    if (string.IsNullOrEmpty(sDanga)) sDanga = "0";
                    if (string.IsNullOrEmpty(sAmount)) sAmount = "0";
                    if (string.IsNullOrEmpty(sVat)) sVat = "0";

                    sql = "insert into tb_delivery_sub (deli_id, deli_seq, depot, prod_id, add_size, qty, danga, amount, vat, rorder_id, rorder_seq, prod_no, dorder_id, dorder_seq, deli_dt) " +
                        "values('" + sNo + "'," + sSeq + ",'0001','" + sProdID + "','" + sAddSize + "'," + sQty + "," + sDanga + "," + sAmount + "," + sVat + ",'" + sRorderNo + "'," + sRorderSeq + ",'" + sProdNo + "','" + sDNo + "'," + sSeq + ",'" + sDate + "')" +
                    " on duplicate key update " +
                        "prod_id = '" + sProdID + "', add_size = '" + sAddSize + "', qty = " + sQty + ", danga = " + sDanga + ", amount = " + sAmount + ", vat = " + sVat + ", prod_no = '" + sProdNo +"', dorder_id = '" + sDNo + "', dorder_seq = " + sSeq;

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

            m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sNo + " " + tbCust.Text);
            lblMsg.Text = "저장되었습니다.";
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            string sNo = tbNo.Text;

            if (string.IsNullOrEmpty(sNo))
            {
                lblMsg.Text = "저장된 출하건만 명세서 출력이 가능합니다.";
                return;
            }

            sP_Delivery_PrintTableAdapter.Fill(dataSetP1B.SP_Delivery_Print, sNo);

            string sql = @"select sum(amount+vat) from tb_delivery_sub where deli_id = '" + sNo + "'";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            long lTotAmount = long.Parse(m.dbRonlyOne(sql, ref msg).ToString());

            string reportFileName = "SmartMES_Bluewings.Reports.P1B05_DELIVERY.rdlc";

            string reportParm1 = "합계금액 : ";
            reportParm1 = reportParm1 + new MyClass().Number2Hangle(lTotAmount) + " 원정";

            ViewReport_V viewReport = new ViewReport_V();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPDeliveryPrintBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

        #region 출하번호 생성
        private string getDeliNo(string sDate)
        {
            string sql = @"select UF_DeliveryNoGenerator('" + G.Pos + "','" + sDate + "')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        private string getDeliSeq(string sNo)
        {
            string sql = @"select UF_DeliverySeqGenerator('" + sNo + "')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        #endregion

        #region Functions
        private void tbBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            lblBarcode.Text = "";
            if (e.KeyCode != Keys.Enter) return;

            string sBarcode = tbBarcode.Text.Trim();

            if (string.IsNullOrEmpty(sBarcode))
            {
                lblBarcode.Text = "바코드가 입력되지 않았습니다.";
                return;
            }

            // 유효한 값인지 확인하기
            if (sBarcode.Length < 10)
            {
                lblBarcode.Text = "바코드의 값이 정확하지 않습니다.";
                return;
            }

            if (DBSearch(sBarcode) == true)
            {
                lblBarcode.Text = "이미 처리된 포대번호 입니다.";
                return;
            }

            if (GridSearch(sBarcode) == true)
            {
                lblBarcode.Text = "현재 등록된 포대번호 입니다.";
                return;
            }

            MariaCRUD m = new MariaCRUD();
            string sql = @"select pd.prod_no, pd.prod_id, (select p.prod_name from tb_gi_product p where p.prod_id = pd.prod_id), pd.add_size, pd.done_qty " +
                            "from tb_prod_done_sub pd where pd.prod_no = '" + sBarcode + "'";
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg != "OK")
            {
                lblBarcode.Text = "존재하지 않는 바코드 번호 입니다.";
                return;
            }

            DataRow[] row = table.Select();

            if (row.Length > 0)
            {
                int idx = dataGridView1.RowCount - 1;
                sPDeliverySubQueryBindingSource.AddNew();

                dataGridView1.Rows[idx].Cells[12].Value = row[0][0].ToString();// ProdNo
                dataGridView1.Rows[idx].Cells[2].Value = row[0][1].ToString(); // 품목코드
                dataGridView1.Rows[idx].Cells[3].Value = row[0][2].ToString(); // 품목명
                dataGridView1.Rows[idx].Cells[5].Value = row[0][3].ToString(); // 규격
                dataGridView1.Rows[idx].Cells[7].Value = row[0][4].ToString(); // 수량
            }
            else
            {
                lblBarcode.Text = "존재하지 않는 바코드 번호 입니다.";
                return;
            }
            tbBarcode.Text = "";
        }

        private bool DBSearch(string sNo)
        {
            string sql = @"select count(*) from tb_delivery_sub where prod_no = '" + sNo + "'";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            int cnt = Int32.Parse(m.dbRonlyOne(sql, ref msg).ToString());

            if (cnt > 0) return true;
            else return false;
        }
        private bool GridSearch(string sNo)
        {
            bool b = false;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[13].Value.ToString() == sNo)
                {
                    b = true;
                    continue;
                }
            }
            return b;
        }
        private void btnProd_Click(object sender, EventArgs e)  // 품질검사완료 SP  보는 화면 연결.
        {
            if (G.Authority == "D") return;

            P1B05_DELIVERY_SUB1 sub = new P1B05_DELIVERY_SUB1();
            sub.parentWin = this;
            sub.ShowDialog();
        }
        #endregion
    }
}

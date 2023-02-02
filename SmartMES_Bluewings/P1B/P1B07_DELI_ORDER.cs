using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1B07_DELI_ORDER : SmartMES_Bluewings.FormBasic
    {
        int columnIndex = 0;
        int rowIndex = 0;
        bool endEdit = false;

        public P1B07_DELI_ORDER()
        {
            InitializeComponent();
        }
        private void P1B07_DELI_ORDER_Load(object sender, EventArgs e)
        {
            ListSearch1();
            cbDeliCar.SelectedIndex = 0;
        }
        public async void ListSearch1()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();

                sP_Deliorder_Main_QueryTableAdapter.Fill(dataSetP1B.SP_Deliorder_Main_Query, sSearch);
                var data = dataSetP1B.SP_Deliorder_Main_Query;
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
            tbRorder.Text = dataGridViewList.Rows[rowIndex].Cells[1].Value.ToString();
            dtpDate.Value = DateTime.Parse(dataGridViewList.Rows[rowIndex].Cells[2].Value.ToString());
            tbCust.Tag = dataGridViewList.Rows[rowIndex].Cells[3].Value.ToString();
            tbCust.Text = dataGridViewList.Rows[rowIndex].Cells[4].Value.ToString();
            tbPlace.Text = dataGridViewList.Rows[rowIndex].Cells[5].Value.ToString();
            if (dataGridViewList.Rows[rowIndex].Cells[10].Value.ToString() == "B") cbGubun.Text = "B.민간";
            else cbGubun.Text = "A.조달";

            string sCar = dataGridViewList.Rows[rowIndex].Cells[6].Value.ToString();
            if (sCar == "9") cbDeliCar.SelectedIndex = cbDeliCar.Items.Count - 1;
            else cbDeliCar.SelectedIndex = Int32.Parse(sCar) - 1;

            //tbDeliInfo.Text = dataGridViewList.Rows[rowIndex].Cells[9].Value.ToString();
            //tbContents.Text = dataGridViewList.Rows[rowIndex].Cells[11].Value.ToString();

            Cursor.Current = Cursors.Default;
        }
        public async void ListSearch3()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sNo = tbNo.Text;

                sP_Deliorder_Sub_QueryTableAdapter.Fill(dataSetP1B.SP_Deliorder_Sub_Query, sNo);
                var data = dataSetP1B.SP_Deliorder_Sub_Query;
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

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value != null) iCnt++;   // 품목코드
                }

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
            tbRorder.Text = string.Empty;
            dtpDate.Value = DateTime.Today;
            tbCust.Tag = string.Empty;
            tbCust.Text = string.Empty;
            tbPlace.Text = string.Empty;
            tbContents.Text = string.Empty;
            tbDeliInfo.Text = string.Empty;
            cbGubun.SelectedIndex = 0;

            sP_Deliorder_Sub_QueryTableAdapter.Fill(dataSetP1B.SP_Deliorder_Sub_Query, "");

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

                    if (columnIndex == 9)
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

                int qty1 = 0;
                int qty2 = 0;
                int qty3 = 0;
                long moneyA = 0;
                long moneyB = 0;

                if (columnIndex == 6 || columnIndex == 7)   // 수량6,잔량7,수주수량12
                {
                    if (dataGridView1.Rows[rowIndex].Cells[6].Value != null && dataGridView1.Rows[rowIndex].Cells[6].Value.ToString().Length != 0)
                        qty1 = Int32.Parse(dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());   // 수량

                    if (dataGridView1.Rows[rowIndex].Cells[7].Value != null && dataGridView1.Rows[rowIndex].Cells[7].Value.ToString().Length != 0)
                        qty2 = Int32.Parse(dataGridView1.Rows[rowIndex].Cells[7].Value.ToString());   // 잔량

                    if (dataGridView1.Rows[rowIndex].Cells[12].Value != null && dataGridView1.Rows[rowIndex].Cells[12].Value.ToString().Length != 0)  // 수주수량
                        qty3 = Int32.Parse(dataGridView1.Rows[rowIndex].Cells[12].Value.ToString());

                    qty2 = (qty3 - qty1);
                    dataGridView1.Rows[rowIndex].Cells[7].Value = qty2;
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
            //
        }
        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMsg.Text = "";
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 10)
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
                    string sql = "delete from tb_deliorder_sub where dorder_id = '" + sNo + "' and dorder_seq = " + sSeq;
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
            //
        }
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                if (columnIndex == 6)
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

            P1B07_DELI_ORDER_SUB sub = new P1B07_DELI_ORDER_SUB();
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (!cbNo.Checked)
            {
                lblMsg.Text = "삭제할 지시번호를 체크해 주세요.";
                return;
            }

            string sNo = tbNo.Text;

            if (string.IsNullOrEmpty(sNo))
            {
                lblMsg.Text = "저장된 지시번호만 삭제할 수 있습니다.";
                return;
            }

            DialogResult dr = MessageBox.Show("지시번호 : " + sNo + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_deliorder_main where dorder_id = '" + sNo + "'";
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show("지시번호 : '" + sNo + "'\r\r이미 타 업무에서 사용중인 지시번호이므로,\r삭제할 수 없습니다.");
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
            string sRorderNo = tbRorder.Text;
            // string sDate = DateTime.Today.ToString("yyyy-MM-dd");
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sReqDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sCust = tbCust.Tag.ToString();
            string sDeliCar = cbDeliCar.Text.Substring(0, 1);
            string sDeliInfo = tbDeliInfo.Text.Trim();
            string sContents = tbContents.Text.Trim(); string sGubun = cbGubun.Text.Substring(0, 1);

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sSeq = string.Empty;
            string sProdID = string.Empty;
            string sAddSize = string.Empty;
            string sUnit = string.Empty;
            string sQty = string.Empty; string sRmQty = string.Empty;
            string sRorderSeq = string.Empty;
            string sConts = string.Empty;

            if (string.IsNullOrEmpty(sNo)) //추가
            {
                sNo = getDeliNo(sDate);
                sql = "insert into tb_deliorder_main (dorder_id, rorder_id, dorder_date, cust_id, gubun, deli_car, deli_info, request_date, contents, enter_man) " +
                    "values('" + sNo + "','" + sRorderNo + "','" + sDate + "','" + sCust + "','" + sGubun +"'," + sDeliCar + ",'" + sDeliInfo + "','" + sReqDate + "','" + sContents + "','" + G.UserID + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

                tbNo.Text = sNo;

                int seq = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString())) continue;

                    seq = seq + 10;
                    sSeq = seq.ToString();
                    sProdID = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
                    sAddSize = dataGridView1.Rows[i].Cells[4].Value.ToString().Trim();
                    sUnit = dataGridView1.Rows[i].Cells[5].Value.ToString().Trim();
                    sQty = dataGridView1.Rows[i].Cells[6].Value.ToString().Trim();
                    sRmQty = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
                    sRorderNo = dataGridView1.Rows[i].Cells[8].Value.ToString().Trim();
                    sRorderSeq = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();
                    sConts = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();

                    if (string.IsNullOrEmpty(sQty)) sQty = "0";

                    sql = "insert into tb_deliorder_sub (dorder_id, dorder_seq, depot, prod_id, add_size, qty, rm_qty, rorder_id, rorder_seq) " +
                          "values('" + sNo + "'," + sSeq + ",'0001','" + sProdID + "','" + sAddSize + "'," + sQty + "," + sRmQty + ",'" + sRorderNo + "'," + sRorderSeq + ")";
                    m.dbCUD(sql, ref msg);

                    // yychoi - 1014
                    //sql = "update tb_rorder_sub set dorder_flag = 1 where rorder_id = '" + sRorderNo + "' and rorder_seq = " + sRorderSeq;
                    //m.dbCUD(sql, ref msg);
                }
            }
            else //수정
            {
                sql = "update tb_deliorder_main " +
                    "set cust_id = '" + sCust + "', gubun = '" + sGubun + "', deli_car = '" + sDeliCar + "', deli_info = '" + sDeliInfo + ", request_date" + sReqDate + "', contents = '" + sContents + "'" +
                    " where dorder_id = '" + sNo + "'";

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
                    sAddSize = dataGridView1.Rows[i].Cells[4].Value.ToString().Trim();
                    sUnit = dataGridView1.Rows[i].Cells[5].Value.ToString().Trim();
                    sQty = dataGridView1.Rows[i].Cells[6].Value.ToString().Trim();
                    sRmQty = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
                    sRorderNo = dataGridView1.Rows[i].Cells[8].Value.ToString().Trim();
                    sRorderSeq = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();
                    sConts = dataGridView1.Rows[i].Cells[10].Value.ToString().Trim();

                    if (dataGridView1.Rows[i].Cells[1].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                        sSeq = getDeliSeq(sNo);
                    else
                        sSeq = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    if (string.IsNullOrEmpty(sQty)) sQty = "0";

                    sql = "insert into tb_deliorder_sub (dorder_id, dorder_seq, depot, prod_id, add_size, qty, rm_qty, rorder_id, rorder_seq) " +
                        "values('" + sNo + "'," + sSeq + ",'0001','" + sProdID + "','" + sAddSize + "'," + sQty + "," + sRmQty + ",'" + sRorderNo + "'," + sRorderSeq + ")" +
                    " on duplicate key update " +
                        "prod_id = '" + sProdID + "', add_size = '" + sAddSize + "', qty = " + sQty + ", rm_qty = " + sRmQty + ", rorder_id = '" + sRorderNo + "', rorder_seq = " + sRorderSeq;

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
            //sP_Delivery_PrintTableAdapter.Fill(dataSetP1B.SP_Delivery_Print, sNo);

            //string sql = @"select sum(amount+vat) from tb_delivery_sub where deli_id = '" + sNo + "'";
            //MariaCRUD m = new MariaCRUD();
            //string msg = string.Empty;
            //long lTotAmount = long.Parse(m.dbRonlyOne(sql, ref msg).ToString());

            //string reportFileName = "SmartMES_Bluewings.Reports.P1B07_DELI_ORDER.rdlc";

            //string reportParm1 = "합계금액 : ";
            //reportParm1 = reportParm1 + new MyClass().Number2Hangle(lTotAmount) + " 원정";

            //ViewReport_V viewReport = new ViewReport_V();
            //viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            //viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            //ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            //viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1 });

            //ReportDataSource rds = new ReportDataSource("DataSet1", sPDeliveryPrintBindingSource);
            //viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            //viewReport.reportViewer1.LocalReport.Refresh();

            //viewReport.ShowDialog();
        }
        #endregion

        #region 출하지시번호 생성
        private string getDeliNo(string sDate)
        {
            string sql = @"select UF_DeliOrderNoGenerator('" + sDate + "')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        private string getDeliSeq(string sNo)
        {
            string sql = @"select UF_DeliOrderSeqGenerator('" + sNo + "')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        #endregion
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1C01_PROD_ORDER_SUB2 : Form
    {
        MySqlConnection con;
        public P1C01_PROD_ORDER parentWin;
        public int rowIndex;
        private string rorderID;
        private string rorderSeq;
        // 검색조건 거래처/영업담당/프로젝트명/현장
        public P1C01_PROD_ORDER_SUB2()
        {
            InitializeComponent();
        }
        private void P1C01_PROD_ORDER_SUB2_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            tbJobNo.Text = getCode();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                string sql = @"select co_code, co_item from tb_gi_common where co_kind = 'C' order by co_code";
                MariaCRUD m = new MariaCRUD();
                string msg = string.Empty;
                DataTable table = m.dbDataTable(sql, ref msg);

                if (msg == "OK")
                {
                    cbProc.DataSource = table;
                    cbProc.ValueMember = "co_code";
                    cbProc.DisplayMember = "co_item";
                }

                cbMatKind.SelectedIndex = 0;
                ListSearch();
                this.ActiveControl = tbSearch;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;
                label10.Visible = true; tbJobNo.Visible = true; lblProd.Visible = true; tbProd.Visible = true;

                dtpDate.Value = (DateTime)parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value;    // 생산계획일
                tbJobNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();    // JobNo
                //tbSeq.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();      // 순번
                tbProd.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();   // 품목코드
                tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();   // 품목명
                //tbQty.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();      // 지시수량
                //dtpExpDate.Value = (DateTime)parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value;    // 유효기간

                this.ActiveControl = btnSave;
            }

        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                //string sSearch = tbSearch.Text.Trim();
                //DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                //DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                //// sP_ProdOrder_ROderTableAdapter.Fill(dataSetP1C.SP_ProdOrder_ROder, sSearch, sfromDate, stoDate);
                //sP_ProdOrder_ROrderTableAdapter.Fill(dataSetP1C.SP_ProdOrder_ROrder, sSearch, dtFromDate, dtToDate);

                //dataGridView1.CurrentCell = null;
                //dataGridView1.ClearSelection();
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

        #region 품목명
        private void lblProd_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            ProdFinder pop = new ProdFinder();
            pop.cbGubun.Text = "<전체>";
            pop._kind = "%";
            pop._stockFlag = "%";
            pop.FormSendEvent += new ProdFinder.FormSendDataHandler(ProdEventMethod);
            pop.ShowDialog();
        }
        private void ProdEventMethod(object sender)
        {
            string sProd = sender.ToString();

            if (string.IsNullOrEmpty(sProd)) return;

            tbProd.Tag = sProd.Substring(0, 8);
            tbProd.Text = sProd.Substring(9, sProd.Length - 9);
            tbSizeT.Focus();
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
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        #endregion

        #region 텍스트 박스 숫자 처리
        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText;

                lgsText = tbQty.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbQty.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));

                tbQty.SelectionStart = tbQty.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbQty.SelectionLength = 0;
            }
            catch (FormatException)
            {
                return;
            }
        }
        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        #endregion

        #region grid View Event
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            //if (!(e.ColumnIndex == 2 || e.ColumnIndex == 7)) return;

            if (e.ColumnIndex == 2)     // 프로젝트명

            {
                string sSujuNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (sSujuNo == dataGridView1.Rows[i].Cells[0].Value.ToString())
                        dataGridView1.Rows[i].Cells[4].Value = 1;
                    else
                        dataGridView1.Rows[i].Cells[4].Value = 0;
                }
            }
            else if (e.ColumnIndex == 7)    // 품목명
            {
                tbCust.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                // ERP 연동으로 인한 DeliDate null로 들어오는 value null처리 6/23
                if (string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) || dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "")
                {
                    dtpDeli.Value = DateTime.Today; dtpDeli.Enabled = true;
                }
                else dtpDeli.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                tbProd.Tag = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbProd.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                tbQty.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                cbProc.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                tbSizeT.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
                tbSizeW.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
                tbSizeL.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                tbDoc.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
                tbProdNo.Text = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString() == "1") cbMatKind.SelectedIndex = 0;
                else if (dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString() == "2") cbMatKind.SelectedIndex = 1;

                rorderID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                rorderSeq = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[4].Value = 0;
                }
                dataGridView1.Rows[e.RowIndex].Cells[4].Value = 1;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.RowCount < 2) return;

            try
            {
                string sSujuNo = dataGridView1.Rows[0].Cells[0].Value.ToString();

                for (int i = 1; i < dataGridView1.RowCount; i++)
                {
                    if (sSujuNo == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[1].Style.ForeColor = Color.Transparent;
                        //dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Transparent;
                        //dataGridView1.Rows[i].Cells[0].Value = "";
                        //dataGridView1.Rows[i].Cells[1].Value = "";
                        dataGridView1.Rows[i].Cells[2].Value = "";
                        //dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Transparent;
                    }
                    sSujuNo = dataGridView1.Rows[i].Cells[0].Value.ToString();
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void Save()
        {
            lblMsg.Text = "";

            if (tbProd.Tag == null)
            {
                lblMsg.Text = "품목명을 선택해 주세요.";
                lblProd.Focus();
                return;
            }

            string sQty = tbQty.Text.Replace(",", "").Trim();

            if (string.IsNullOrEmpty(sQty))
            {
                lblMsg.Text = "지시수량을 입력해 주세요.";
                tbQty.Focus();
                return;
            }

            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sProd = tbProd.Tag.ToString();
            string sSizeT = tbSizeT.Text.Trim();
            string sSizeW = tbSizeW.Text.Trim();
            string sSizeL = tbSizeL.Text.Trim();
            string sProc = cbProc.SelectedValue.ToString();
            string sJobNo = getCode();
            string sSujuQty = sQty;
            string sRework = "0";
            if (cbRework.Checked) sRework = "1";
            string sDoc = tbDoc.Text.Trim();
            string sProdNo = tbProdNo.Text.Trim();
            string sMatKind = cbMatKind.Text.Substring(0, 1);
            string sConts = tbContents.Text.Trim();

            string sProcStd = "0001";
            if (cbProc.SelectedValue.ToString() == "0001") sProcStd = "0002";   // 절단만
            else if (cbProc.SelectedValue.ToString() == "0002" && sMatKind == "2")
            {
                sProcStd = "0003";   // 밀링만
                sProdNo = "20";
            }
            else sProcStd = "0001";

            if (string.IsNullOrEmpty(rorderSeq))
            {
                rorderSeq = "null";
            }
            else
            {
                string sqlQty = "select qty from vw_rorder where rorder_id = '" + rorderID + "' and rorder_seq = " + rorderSeq;
                MariaCRUD mQty = new MariaCRUD();
                string msgQty = string.Empty;
                string com = mQty.dbRonlyOne(sqlQty, ref msgQty).ToString();

                if (msgQty == "OK") sSujuQty = com;
            }

            string sql = "insert into tb_prod_order (job_no, proc_no, pos, lot_date, prod_id, size_t, size_w, size_l, proc_kind, proc_std, doc_no, prod_no, mat_kind, rework, rorder_id, rorder_seq, rorder_date, order_qty, ment, enter_man) " +
                "select '" + sJobNo + "',p.proc_no,'" + G.Pos + "','" + sDate + "','" + sProd + "'," + sSizeT + "," + sSizeW + "," + sSizeL + ",'" + sProc + "','" + sProcStd + "','" + sDoc + "','" + sProdNo + "'," + sMatKind + "," + sRework + ",'" + rorderID + "'," + rorderSeq + ",'" + sDate + "'," 
                + sSujuQty + " - ifnull((select sum(v.gd_qty) from vw_production v where v.rorder_id = '" + rorderID + "' and v.rorder_seq = " + rorderSeq + " and v.proc_std = p.proc_no),0),'" + sConts + "','" + G.UserID + "' " + 
                "from tb_gi_process p where p.proc_std = '" + sProcStd + "' order by p.proc_no";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }
            QRCodeCreate(rorderID, rorderSeq);
            QRImageSave(rorderID + rorderSeq);

            lblMsg.Text = "저장되었습니다.";

            parentWin.ListSearch();

            for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
            {
                if (parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString() == sJobNo)
                {
                    parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
                    parentWin.dataGridView1.CurrentCell.Selected = true;
                    break;
                }
            }

            tbJobNo.Text = getCode();
            tbProd.Tag = null;
            tbProd.Text = string.Empty;
            tbSizeT.Text = string.Empty;
            tbSizeW.Text = string.Empty;
            tbSizeL.Text = string.Empty;
            tbQty.Text = string.Empty;
            tbDoc.Text = string.Empty;
            tbProdNo.Text = string.Empty;
            cbRework.Checked = false;
            cbMatKind.SelectedIndex = 0;
        }
        #endregion

        #region JobNo.(LotNo.) 생성
        private string getCode()
        {
            string sql = @"select UF_JobNoGenerator()";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        #endregion

        #region 작업지시일괄등록
        private async void btnBatch_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (dataGridView1.RowCount < 1) return;

            int iCnt = 0;
            int iNoCnt = 0;
            string sSujuNo = string.Empty;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value != null && dataGridView1.Rows[i].Cells[4].Value.ToString() == "1")
                {
                    iCnt++;
                    if (iCnt == 1)
                        sSujuNo = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    else
                        if (sSujuNo != dataGridView1.Rows[i].Cells[0].Value.ToString()) iNoCnt++;
                }
            }

            if (iCnt < 1)
            {
                MessageBox.Show("작업지시대상이 선택되지 않았습니다.");
                return;
            }
            //if (iNoCnt > 0)
            //{
            //    MessageBox.Show("동일 수주건만 선택 가능합니다.");
            //    return;
            //}

            string sql;
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;

            string sProc = string.Empty;
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sProd = string.Empty;
            string sSizeT = string.Empty;
            string sSizeW = string.Empty;
            string sSizeL = string.Empty;
            string sSujuSeq = string.Empty;
            string sMat = string.Empty;
            string sDoc = string.Empty;
            string sProdNo = string.Empty;
            string sRework = "0";
            if (cbRework.Checked) sRework = "1";
            string sQty = string.Empty;
            string sSujuQty = sQty;
            string sConts = string.Empty;

            string sqlQty;
            MariaCRUD mQty;
            string msgQty = string.Empty;
            string com;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value != null && dataGridView1.Rows[i].Cells[4].Value.ToString() == "1")
                {
                    string sJobNo = getCode();
                    sSujuNo = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    sProd = dataGridView1.Rows[i].Cells[6].Value.ToString();    // 품목코드
                    sSujuSeq = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    sQty = dataGridView1.Rows[i].Cells[10].Value.ToString();
                    sProc = dataGridView1.Rows[i].Cells[11].Value.ToString();
                    sSizeT = dataGridView1.Rows[i].Cells[16].Value.ToString(); 
                    sSizeW = dataGridView1.Rows[i].Cells[17].Value.ToString();
                    sSizeL = dataGridView1.Rows[i].Cells[18].Value.ToString();
                    sDoc = dataGridView1.Rows[i].Cells[19].Value.ToString();
                    sProdNo = dataGridView1.Rows[i].Cells[20].Value.ToString();
                    sMat = dataGridView1.Rows[i].Cells[21].Value.ToString();
                    sConts = dataGridView1.Rows[i].Cells[23].Value.ToString();

                    string sProcStd = "0001";
                    if (sProc == "0001") sProcStd = "0002";   // 절단만
                    else if (sProc == "0002" && sMat == "2")
                    {
                        sProcStd = "0003";   // 밀링만
                        sProdNo = "20";
                    }

                    sqlQty = "select qty from vw_rorder where rorder_id = '" + sSujuNo + "' and rorder_seq = " + sSujuSeq;
                    mQty = new MariaCRUD();
                    
                    com = mQty.dbRonlyOne(sqlQty, ref msgQty).ToString();

                    if (msgQty == "OK") sSujuQty = com;

                    sql = "insert into tb_prod_order (job_no, proc_no, pos, lot_date, prod_id, size_t, size_w, size_l, proc_kind, proc_std, doc_no, prod_no, mat_kind, rework, rorder_id, rorder_seq, rorder_date, order_qty, ment, enter_man) " +
                        "select '" + sJobNo + "',p.proc_no,'" + G.Pos + "','" + sDate + "','" + sProd + "'," + sSizeT + "," + sSizeW + "," + sSizeL + ",'" + sProc + "','" + sProcStd + "','" + sDoc + "','" + sProdNo + "'," + sMat + "," + sRework + ",'" + sSujuNo + "'," + sSujuSeq + ",'" + sDate + "',"
                        + sSujuQty + " - ifnull((select sum(v.gd_qty) from vw_production v where v.rorder_id = '" + sSujuNo + "' and v.rorder_seq = " + sSujuSeq + " and v.proc_std = p.proc_no),0),'" + sConts + "','" + G.UserID + "' " +
                        "from tb_gi_process p where p.proc_std = '" + sProcStd + "' order by p.proc_no";

                    //m = new MariaCRUD();
                    m.dbCUD(sql, ref msg);

                    if (msg != "OK")
                    {
                        lblMsg.Text = msg;
                        return;
                    }
                    var data = sql;
                    var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

                    QRCodeCreate(sSujuNo, sSujuSeq);
                    QRImageSave(sSujuNo + sSujuSeq);
                }
            }

            parentWin.ListSearch();
            this.Dispose();
        }
        #endregion

        #region QR
        private void QRCodeCreate(string s1, string s2) // s1 수주번호, s2 수주순번
        {
            ZXing.BarcodeWriter barcodeWriter = new ZXing.BarcodeWriter();
            barcodeWriter.Format = ZXing.BarcodeFormat.QR_CODE;

            barcodeWriter.Options.Width = 128;
            barcodeWriter.Options.Height = 128;

            string str = s1 + s2;

            barcodeWriter.Write(str).Save(s1 + s2 + ".png", ImageFormat.Png);
        }
        private void QRImageSave(string _id)
        {
            string sql = string.Empty;
            UInt32 FileSize;
            byte[] rawData;
            FileStream fs;

            con = new MySqlConnection(G.conStr);
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                fs = new FileStream(_id + ".png", FileMode.Open, FileAccess.Read);
                FileSize = (UInt32)fs.Length;

                rawData = new byte[FileSize];
                fs.Read(rawData, 0, (int)FileSize);
                fs.Close();

                string sRorder = _id.Substring(0, 10);
                string sSeq = _id.Substring(10,Int32.Parse((_id.Length-10).ToString()));    // ERP 연동으로 인한 수주순번 자릿수 변경으로 로직 변경. 6/23

                con.Open();
                sql = "update tb_prod_order set qrcode = @QRCODE where rorder_id = @CODE_NOA and rorder_seq = @CODE_NOB";

                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@CODE_NOA", sRorder);
                cmd.Parameters.AddWithValue("@CODE_NOB", sSeq);
                cmd.Parameters.AddWithValue("@QRCODE", rawData);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpToDate.Value >= dtpFromDate.Value)
                ListSearch();
        }
    }
}
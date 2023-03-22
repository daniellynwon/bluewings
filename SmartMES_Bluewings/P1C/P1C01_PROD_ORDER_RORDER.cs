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
    public partial class P1C01_PROD_ORDER_RORDER : Form
    {
        MySqlConnection con;
        public P1C01_PROD_ORDER parentWin;
        public int rowIndex;
        private string rorderID;
        private string rorderSeq;
        // 검색조건 거래처/영업담당/프로젝트명/현장
        public P1C01_PROD_ORDER_RORDER()
        {
            InitializeComponent();
        }
        private void P1C01_PROD_ORDER_RORDER_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            tbJobNo.Text = getCode();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                string sql = @"SELECT machine_id, machine_name FROM tb_machinecard WHERE model_no = '0003'";
                MariaCRUD m = new MariaCRUD();
                string msg = string.Empty;
                DataTable table = m.dbDataTable(sql, ref msg);

                if (msg == "OK")
                {
                    cbComb.DataSource = table;
                    cbComb.ValueMember = "machine_id";
                    cbComb.DisplayMember = "machine_name";
                }

                ListSearch();
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;
                //label13.Visible = false; dtpFromDate.Visible = false; dtpToDate.Visible = false;

                dtpDate.Value = (DateTime)parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value;    // 생산계획일
                tbJobNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();    // JobNo
                tbMachine.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();      // 설비코드
                tbMachine.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();      // 설비명
                cbComb.SelectedValue = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString(); // 배합기
                tbProd.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();   // 품목코드
                tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();   // 품목명
                tbQty.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();      // 지시수량
                tbQtyA.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
                tbQtyB.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
                tbQtyMB.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
                tbTime.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();

                this.ActiveControl = btnSave;
            }
        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                sP_ProdOrder_ROrder1TableAdapter.Fill(dataSetP1C.SP_ProdOrder_ROrder1,dtFromDate, dtToDate);

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
            tbQtyA.Focus();
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
        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpToDate.Value >= dtpFromDate.Value)
                ListSearch();
        }
        #endregion

        #region 텍스트 박스 숫자 처리
        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText, min;

                lgsText = tbQty.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbQty.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));
                min = tbTime.Text.Replace(",", ""); tbTime.Text = String.Format("{0:#,##0}", Convert.ToDouble(min));

                tbQty.SelectionStart = tbQty.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbQty.SelectionLength = 0;
                tbTime.SelectionStart = tbTime.TextLength; tbQty.SelectionLength = 0;
            }
            catch (FormatException)
            {
                return;
            }
        }
        private void qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText1, lgsText2, lgsText3;

                lgsText1 = tbQtyA.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbQtyA.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText1));
                lgsText2 = tbQtyB.Text.Replace(",", ""); tbQtyB.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText2));
                lgsText3 = tbQtyMB.Text.Replace(",", ""); tbQtyMB.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText3));

                tbQtyA.SelectionStart = tbQtyA.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbQtyA.SelectionLength = 0;
                tbQtyB.SelectionStart = tbQtyB.TextLength; tbQtyB.SelectionLength = 0;
                tbQtyMB.SelectionStart = tbQtyMB.TextLength; tbQtyMB.SelectionLength = 0;
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
            
            if (e.ColumnIndex == 9)    // 품목명
            {
                tbMachine.Tag = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbMachine.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbProd.Tag = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbProd.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                tbQtyA.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                tbQtyB.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                tbQtyMB.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[7].Value = 0;
                }
                dataGridView1.Rows[e.RowIndex].Cells[7].Value = 1;
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
                //string sSujuNo = dataGridView1.Rows[0].Cells[0].Value.ToString();

                //for (int i = 1; i < dataGridView1.RowCount; i++)
                //{
                //    if (sSujuNo == dataGridView1.Rows[i].Cells[0].Value.ToString())
                //    {
                //        dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Transparent;
                //        dataGridView1.Rows[i].Cells[1].Style.ForeColor = Color.Transparent;
                //        //dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Transparent;
                //        dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Transparent;
                //        //dataGridView1.Rows[i].Cells[0].Value = "";
                //        //dataGridView1.Rows[i].Cells[1].Value = "";
                //        dataGridView1.Rows[i].Cells[2].Value = "";
                //        //dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Transparent;
                //    }
                //    sSujuNo = dataGridView1.Rows[i].Cells[0].Value.ToString();
                //}
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
            if (tbMachine.Tag == null)
            {
                lblMsg.Text = "생산계획을 선택해주세요.";
                lblProd.Focus();
                return;
            }

            string sQty = tbQty.Text.Replace(",", "").Trim();
            string sQtyA = tbQtyA.Text.Replace(",", "").Trim();
            string sQtyB = tbQtyB.Text.Replace(",", "").Trim();
            string sQtyMB = tbQtyMB.Text.Replace(",", "").Trim();

            if (string.IsNullOrEmpty(sQty))
            {
                lblMsg.Text = "지시수량을 입력해 주세요.";
                tbQty.Focus();
                return;
            }

            if(string.IsNullOrEmpty(sQtyA) || string.IsNullOrEmpty(sQtyB) || string.IsNullOrEmpty(sQtyMB))
            {
                lblMsg.Text = "배합중량을 확인하세요.";
                tbQtyA.Focus();
                return;
            }

            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sMachine = tbMachine.Tag.ToString();
            string sComb = cbComb.SelectedValue.ToString();
            string sProd = tbProd.Tag.ToString();
            string sJobNo = getCode();
            string sTime = tbTime.Text.Trim();

            string sql = "insert into tb_prod_order (job_no, pos, lot_date, machine_id, comb_id, prod_id, qty, qty1, qty2, qty3, comb_time, enter_man) " +
                "values('" + sJobNo + "','" + G.Pos + "','" + sDate + "'," + sMachine + "," + sComb + ",'" + sProd + "'," + sQty + "," + sQtyA + "," + sQtyB + "," + sQtyMB + ",'" + sTime + "','" + G.UserID + "')";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            //QRCodeCreate(rorderID, rorderSeq); //QRImageSave(rorderID + rorderSeq);
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
            tbQtyA.Text = string.Empty;
            tbQtyB.Text = string.Empty;
            tbQtyMB.Text = string.Empty;
            tbQty.Text = string.Empty;
            tbTime.Text = string.Empty;
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

    }
}
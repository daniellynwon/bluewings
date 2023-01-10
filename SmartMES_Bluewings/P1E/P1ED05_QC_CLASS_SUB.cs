using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1ED05_QC_CLASS_SUB : Form
    {
        public P1ED05_QC_CLASS parentWin;
        private int rowIndex;
        MySqlConnection con;
        private string sProc;

        public P1ED05_QC_CLASS_SUB()
        {
            InitializeComponent();
        }
        private void P1ED05_QC_CLASS_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string sql = @"select user_id, user_name from tb_sys_user where authority in ('B','C') and user_flag = 1 order by user_name";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbWorker.DataSource = table;
                cbWorker.ValueMember = "user_id";
                cbWorker.DisplayMember = "user_name";
            }

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                ListSearch();
                this.ActiveControl = tbQc1;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                dtpDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                tbJobNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbProdNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                tbProd.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                string rbClass = parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
                tbQc1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                //cbWorker.SelectedValue = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                tbContents.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
                tbQc2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
                this.ActiveControl = btnSave;
            }
        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                sP_QcClass_SubTableAdapter.Fill(dataSetP1E.SP_QcClass_Sub);

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

        #region Grid View Control
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 0) return;

            tbJobNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbProdNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbProd.Tag = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbProd.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (dataGridView1.RowCount < 2) return;

            //try
            //{
            //    string sSujuNo = dataGridView1.Rows[0].Cells[0].Value.ToString();

            //    for (int i = 1; i < dataGridView1.RowCount; i++)
            //    {
            //        if (sSujuNo == dataGridView1.Rows[i].Cells[0].Value.ToString())
            //        {
            //            dataGridView1.Rows[i].Cells[1].Style.ForeColor = Color.Transparent;
            //            dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Transparent;
            //            dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Transparent;
            //        }
            //        sSujuNo = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //    }
            //}
            //catch (NullReferenceException)
            //{
            //    return;
            //}
        }
        #endregion

        #region Button Control
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

            if (string.IsNullOrEmpty(tbJobNo.Text))
            {
                lblMsg.Text = "LotNo.가 생성되지 않았습니다.";
                return;
            }
            if (tbProd.Tag == null)
            {
                lblMsg.Text = "품목명을 선택해 주세요.";
                return;
            }
            if (string.IsNullOrEmpty(tbProdNo.Text))
            {
                lblMsg.Text = "포장No를 입력해주세요.";
                return;
            }
            string sQty = tbQc1.Text.Replace(",", "").Trim();
            string sNgQty = tbQc2.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(sNgQty)) sNgQty = "0";

            if (string.IsNullOrEmpty(sQty))
            {
                lblMsg.Text = "검사수량을 입력해 주세요.";
                tbQc1.Focus();
                return;
            }

            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sProd = tbProd.Tag.ToString();
            string sContents = tbContents.Text.Trim();
            string sJobNo = tbJobNo.Text;
            string sUnitNo = tbProdNo.Text;
            string sWorker = cbWorker.SelectedValue.ToString();
            string sClass = string.Empty;

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                tbJobNo.Text = sJobNo;

                sql = "insert into tb_prod_done (job_no, unit_no, prod_class, pos, done_date, prod_id, proc_std, done_qty, ng_qty, qc_man, contents, depot, enter_man) " +
                    "values('" + sJobNo + "'," + sUnitNo + ",'" + sClass + "','" + G.Pos + "','" + sDate + "','" + sProd + "','0001'," + sQty + "," + sNgQty + ",'" + sWorker + "','" + sContents + "','0001','" + G.UserID + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                if (Int32.Parse(tbQc1.Tag.ToString()) <= (Int32.Parse(sQty) + Int32.Parse(sNgQty)))
                {
                    sql = "update tb_prod_order set prod_flag = 1 where job_no = '" + sJobNo + "' and proc_no = " + sProc;
                    m.dbCUD(sql, ref msg);
                }

                string sLotNo = sJobNo + "-" + sUnitNo;
                QRCodeCreate(sLotNo);
                QRImageSave(sLotNo);

                lblMsg.Text = "저장되었습니다.";

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
                {
                    if (parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString() == sJobNo)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbProd.Tag = null;
                tbProd.Text = string.Empty;
                tbQc1.Text = string.Empty;
                tbContents.Text = string.Empty;

                ListSearch();
            }
            else
            {
                sql = "update tb_prod_done " +
                    "set done_date = '" + sDate + "', unit_no = " + sUnitNo + ", prod_class = '" + sClass + "', done_date = '" + sDate + "', done_qty = " + sQty + ", ng_qty = " + sNgQty + ", qc_man = '" + sWorker + "', contents = '" + sContents + "'" +
                    " where job_no = '" + sJobNo + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                lblMsg.Text = "수정되었습니다.";
                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sJobNo);

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
                {
                    if (parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString() == sJobNo)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                this.DialogResult = DialogResult.OK;
            }
        }
        private void QRCodeCreate(string sCode)
        {
            //QRCode barcode = new QRCode();
            //barcode.Code = sCode;
            //barcode.ModuleSize = 6.0f;
            //barcode.Resolution = 300;
            //barcode.drawBarcode2ImageFile(sCode + ".png");

            ZXing.BarcodeWriter barcodeWriter = new ZXing.BarcodeWriter();
            barcodeWriter.Format = ZXing.BarcodeFormat.QR_CODE;

            barcodeWriter.Options.Width = 128;
            barcodeWriter.Options.Height = 128;

            barcodeWriter.Write(sCode).Save(sCode + ".png", ImageFormat.Png);
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

                con.Open();
                sql = "INSERT INTO tb_qrcode VALUES('B', @CODE_NO, @QRCODE)";

                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@CODE_NO", _id);
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

        #region 텍스트 박스 숫자 처리
        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText;

                lgsText = tbQc1.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbQc1.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));

                tbQc1.SelectionStart = tbQc1.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbQc1.SelectionLength = 0;
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

    }
}

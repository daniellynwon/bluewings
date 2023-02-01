using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1B10_PURCHASE_MAT_IN : Form
    {
        public P1B10_PURCHASE_MAT parentWin;

        public bool isModify = false;

        private int rowIndex = 0;

        public P1B10_PURCHASE_MAT_IN()
        {
            InitializeComponent();
        }
        private void P1B10_PURCHASE_MAT_IN_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string sql = @"select co_code, co_item from tb_gi_common where co_kind = 'B' order by co_code";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbDepot.DataSource = table;
                cbDepot.ValueMember = "co_code";
                cbDepot.DisplayMember = "co_item";
            }

            rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

            tbNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            tbCust.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            tbCust.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            dtpPutchDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
            dtpRequestDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[11].Value.ToString());
            tbProd.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            tbSize.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            tbQty.Text = long.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString()).ToString("#,##0");
            tbDanga.Text = long.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString()).ToString("#,##0");
            lblTitle.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
            tbBigo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[21].Value.ToString();
            tbInNum.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[23].Value.ToString();
            if (parentWin.dataGridView1.Rows[rowIndex].Cells[24].Value.ToString() == "1") rb1.Checked = true;

            if (lblTitle.Tag.ToString() == "0" && (isModify == false))
            {
                int inputQty = 0;
                long lQty = long.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString());
                checkAmount(lQty.ToString(), ref inputQty);
                lQty = lQty - (long)inputQty;

                long lDanga = long.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString());

                tbInQty.Text = lQty.ToString();
                tbAmount.Text = (lQty * lDanga).ToString();
                tbVat.Text = (lQty * lDanga * 0.1).ToString();
                tbMoney.Text = ((lQty * lDanga) + (lQty * lDanga * 0.1)).ToString("#,##0");

                // lblDel.Visible = false;
            }
            else
            {
                dtpInDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[14].Value.ToString());
                tbInQty.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
                tbAmount.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
                tbVat.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[17].Value.ToString();
                cbDepot.SelectedValue = parentWin.dataGridView1.Rows[rowIndex].Cells[19].Value;

                long lAmount = long.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[16].Value.ToString());
                long lVat = long.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[17].Value.ToString());
                tbMoney.Text = (lAmount + lVat).ToString("#,##0");

                if (!isModify)
                    cbEndInput.Checked = true;
            }

            this.ActiveControl = btnSave;
        }

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
        private void tbInQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText = tbInQty.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbInQty.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));

                tbInQty.SelectionStart = tbInQty.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbInQty.SelectionLength = 0;

                long lQty = long.Parse(tbInQty.Text.Replace(",", "").Trim());
                long lDanga = long.Parse(tbDanga.Text.Replace(",", "").Trim());
                tbAmount.Text = (lQty * lDanga).ToString("#,##0");
                tbVat.Text = (lQty * lDanga * 0.1).ToString("#,##0");
                tbMoney.Text = ((lQty * lDanga) + (lQty * lDanga * 0.1)).ToString("#,##0");
            }
            catch (FormatException)
            {
                return;
            }
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText = tbAmount.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbAmount.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));

                tbAmount.SelectionStart = tbAmount.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbAmount.SelectionLength = 0;

                long lAmount = long.Parse(tbAmount.Text.Replace(",", "").Trim());
                tbVat.Text = (lAmount * 0.1).ToString("#,##0");
                tbMoney.Text = (lAmount + (lAmount * 0.1)).ToString("#,##0");
            }
            catch (FormatException)
            {
                return;
            }
        }

        private void tbVat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText = tbVat.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbVat.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));

                tbVat.SelectionStart = tbVat.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbVat.SelectionLength = 0;

                long lAmount = long.Parse(tbAmount.Text.Replace(",", "").Trim());
                long lVat = long.Parse(tbVat.Text.Replace(",", "").Trim());
                tbMoney.Text = (lAmount + lVat).ToString("#,##0");
            }
            catch (FormatException)
            {
                return;
            }
        }
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private async void Save()
        {
            lblMsg.Text = "";

            string sInQty = tbInQty.Text.Replace(",", "").Trim();
            string sAmount = tbAmount.Text.Replace(",", "").Trim();

            if (string.IsNullOrEmpty(sInQty))
            {
                lblMsg.Text = "입고수량을 입력해 주세요.";
                tbInQty.Focus();
                return;
            }
            if (string.IsNullOrEmpty(sAmount))
            {
                lblMsg.Text = "매입액을 입력해 주세요.";
                tbAmount.Focus();
                return;
            }
            string purch_flag = "0";
            int inputQty = 0;

            if (cbEndInput.Checked || checkAmount(sInQty, ref inputQty))
            {
                if (MessageBox.Show("입고를 마감하시겠습니까?","YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    purch_flag = "1";
            }

            string sNo = tbNo.Text;
            string sSeq = tbInNum.Text;
            string sInDate = dtpInDate.Value.ToString("yyyy-MM-dd");
            string sVat = tbVat.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(sVat)) sVat = "0";
            string sDepot = cbDepot.SelectedValue.ToString();
            string sBigo = tbBigo.Text.Trim();
            string sCheck = "0";
            if (rb1.Checked = true) sCheck = "1";

            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sql = "update tb_purchase_mat " +
                    "set putch_flag = " + purch_flag + ", in_date = '" + sInDate + "', in_qty = (SELECT in_qty FROM tb_purchase_mat WHERE purch_id = '" + sNo + "')+" + sInQty + 
                    ", enter_dt2 = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', enter_man2 = '" + G.UserID + "'" +
                    " where purch_id = '" + sNo + "'";

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }
            if (lblTitle.Tag.ToString() == "0" && (isModify == false))
                sSeq =  getPurchSeq(sNo);

            sql = "insert into tb_purchase_mat_sub (purch_id, purch_seq, in_date, in_qty, vat, amount, depot, checkYN, enter_man, contents) " +
                "values ('" + sNo + "'," + sSeq + ",'" +sInDate + "'," + sInQty + "," + sVat + "," + sAmount + ",'" + sDepot + "'," + sCheck + ",'" + G.UserID + "','" + sBigo + "')" +
                " on duplicate key update " +
                "in_date = '" + sInDate + "', in_qty = " + sInQty + ", vat = " + sVat + ", amount = " + sAmount + ", depot = '" + sDepot + "', checkYN = " + sCheck + ", contents = '" + sBigo + "'";

            m.dbCUD(sql, ref msg);
            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

            if (lblDel.Visible)
                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sNo + " " + sInDate);

            parentWin.ListSearch();

            for (int i = 0; i < parentWin.dataGridView1.Rows.Count - 1; i++)
            {
                if (parentWin.dataGridView1.Rows[i].Cells[0].Value.ToString() == sNo)
                {
                    parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, i];
                    parentWin.dataGridView1.CurrentCell.Selected = true;
                    break;
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private string getPurchSeq(string sNo)
        {
            string sql = @"select UF_PurchSeqGenerator('" + sNo + "')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;

            return m.dbRonlyOne(sql, ref msg).ToString();
        }

        private bool checkAmount(string sInQty, ref int inpuQty)
        {

            string Id = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string pQty = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            string sql = @"SELECT SUM(ps.in_qty) as qty FROM tb_purchase_mat pm LEFT JOIN tb_purchase_mat_sub ps ON pm.purch_id = ps.purch_id WHERE pm.purch_id = '" + Id + "';";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            string qty = m.dbRonlyOne(sql, ref msg).ToString();

            if (msg == "OK")
            {
                if (string.IsNullOrEmpty(qty))
                    inpuQty = 0;
                else
                    inpuQty = int.Parse(qty); ;

                if (inpuQty + int.Parse(sInQty) >= int.Parse(pQty))
                    return true;
                else
                    return false;
            }
            else return false;
        }

        private void lblDel_Click(object sender, EventArgs e)
        {
            try
            {
                string sNo = tbNo.Text;
                string sSeq = tbInNum.Text;

                int qty = int.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[15].Value.ToString(), System.Globalization.NumberStyles.AllowThousands);


                DialogResult dr = MessageBox.Show("입고번호 : " + sNo + ", 순번 : " + sSeq + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No) return;

                MariaCRUD m = new MariaCRUD();

                string sql = "delete from tb_purchase_mat_sub where purch_id = '" + sNo + "' and purch_seq = " + sSeq;

                string msg = string.Empty;
                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }
                sql = "update tb_purchase_mat " +
                    "set putch_flag = 0, in_qty = (SELECT in_qty FROM tb_purchase_mat WHERE purch_id = '" + sNo + "')-" + qty.ToString() +
                    " where purch_id = '" + sNo + "'";

                msg = string.Empty;
                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    MessageBox.Show(msg);
                    return;
                }

                m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sNo + " 입고정보");

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridView1.Rows.Count - 1; i++)
                {
                    if (parentWin.dataGridView1.Rows[i].Cells[0].Value.ToString() == sNo)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (InvalidOperationException)
            {
                return;
            }
        }
    }
}

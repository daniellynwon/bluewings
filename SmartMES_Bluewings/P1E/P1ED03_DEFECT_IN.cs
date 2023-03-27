using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1ED03_DEFECT_IN : Form
    {
        public P1ED03_DEFECT_LIST parentWin;

        public bool isModify = false;

        private int rowIndex = 0;

        public P1ED03_DEFECT_IN()
        {
            InitializeComponent();
        }
        private void P1ED03_DEFECT_IN_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

            tbNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            tbCust.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            tbCust.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            tbProd.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            dtpPutchDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString());
            dtpRequestDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString());
            tbQty.Text = long.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString()).ToString("#,##0");
            ptAmount.Text = long.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString()).ToString("#,##0");
            lblTitle.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();   // 입고여부

            if (!(lblTitle.Tag.ToString() == "0" && (isModify == false)))
            {
                tbInQty.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
                tbRate.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[14].Value.ToString();
                dtpInDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[15].Value.ToString());
            }

            tbInQty.Focus();
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
                string lgsText = tbRate.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbRate.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));

                tbRate.SelectionStart = tbRate.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbRate.SelectionLength = 0;
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
        private void tbRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.'))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        private async void Save()
        {
            lblMsg.Text = "";

            string sInQty = tbInQty.Text.Replace(",", "").Trim();
            string sRate = tbRate.Text;

            if (string.IsNullOrEmpty(sInQty))
            {
                lblMsg.Text = "입고수량을 입력해 주세요.";
                tbInQty.Focus();
                return;
            }
            if (string.IsNullOrEmpty(sRate))
            {
                lblMsg.Text = "수율을 입력해 주세요.";
                tbRate.Focus();
                return;
            }

            string sNo = tbNo.Text;
            string sInDate = dtpInDate.Value.ToString("yyyy-MM-dd");

            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sql = "update tb_defect_product " +
                    "set in_flag = 1, in_prod_id = '" + tbProd.Tag + "', in_qty = " + sInQty + ", prod_ratio = " + sRate + ", in_dt = '" + sInDate + "', in_man = '" + G.UserID + "'" +
                    " where id = " + sNo;

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

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

        #region other functions
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
                string sSeq = tbRate.Text;

                int qty = int.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[16].Value.ToString(), System.Globalization.NumberStyles.AllowThousands);


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
        #endregion
    }
}

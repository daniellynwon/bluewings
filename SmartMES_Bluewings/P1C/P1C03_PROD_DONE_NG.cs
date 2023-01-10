using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1C03_PROD_DONE_NG : Form
    {
        public P1C03_PROD_DONE_SUB parentWin;
        public string jobNo;
        public string procNo;
        public string facID;

        public P1C03_PROD_DONE_NG()
        {
            InitializeComponent();
        }
        private void P1C03_PROD_DONE_NG_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            //불량항목
            string sql = @"select co_code, co_item from tb_gi_common where co_kind = 'L' order by co_code";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                lbNgList.DataSource = table;
                lbNgList.ValueMember = "co_code";
                lbNgList.DisplayMember = "co_item";
            }

            if (parentWin.tbNgQty.Tag == null ||
                string.IsNullOrEmpty(parentWin.tbNgQty.Tag.ToString())) return;

            lbNgList.SelectedValue = parentWin.tbNgQty.Tag.ToString();

            if (!string.IsNullOrEmpty(parentWin.tbNgQty.Text))
                tbQty.Text = parentWin.tbNgQty.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbNgList.SelectedValue == null ||
                string.IsNullOrEmpty(lbNgList.SelectedValue.ToString()))
            {
                lblMsg.Text = "불량항목이 선택되지 않았습니다.";
                lbNgList.Focus();
                return;
            }

            string sItem = lbNgList.SelectedValue.ToString();
            string sQty = tbQty.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(sQty)) sQty = "0";

            if (sQty == "0")
            {
                lblMsg.Text = "불량수량을 확인해 주세요.";
                tbQty.Focus();
                return;
            }

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            string sql = "update tb_prod_result set ng_qty = " + sQty + ", ng_item = '" + sItem + "' where job_no = '" + jobNo + "' and proc_no = " + procNo + " and machine_id = " + facID;

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            parentWin.tbNgQty.Tag = lbNgList.SelectedValue.ToString();
            parentWin.tbNgQty.Text = tbQty.Text;

            parentWin.lblMsg.Text = "불량보고 되었습니다.";
            this.DialogResult = DialogResult.OK;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

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

        private void lbMinus_Click(object sender, EventArgs e)
        {
            if (tbQty.Text == "1") return;

            tbQty.Text = (Int32.Parse(tbQty.Text.Replace(",", "")) - 1).ToString("#,##0");
        }
        private void lbPlus_Click(object sender, EventArgs e)
        {
            tbQty.Text = (Int32.Parse(tbQty.Text.Replace(",", "")) + 1).ToString("#,##0");
        }
    }
}

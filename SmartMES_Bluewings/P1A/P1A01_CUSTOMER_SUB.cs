using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1A01_CUSTOMER_SUB : Form
    {
        public P1A01_CUSTOMER parentWin;
        private int rowIndex = 0;
        private string custCode = string.Empty;

        public P1A01_CUSTOMER_SUB()
        {
            InitializeComponent();
        }

        private void P1A01_CUSTOMER_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string sql = @"select saleman from tb_gi_customer where use_flag = 'O' group by saleman order by saleman";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbSaleMan.DataSource = table;
                cbSaleMan.ValueMember = "saleman";
                cbSaleMan.DisplayMember = "saleman";
            }

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                this.ActiveControl = tbCustName;
                cbGubun.SelectedIndex = 0;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                custCode = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbCustName.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                tbCeo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                cbGubun.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                tbBusiNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
                cbSaleMan.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[20].Value.ToString();
                tbPostNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
                tbAddr1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();
                tbAddr2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
                tbTel.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
                tbFax.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
                tbCustMan.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[17].Value.ToString();
                tbHp.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[18].Value.ToString();
                tbContents.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[21].Value.ToString();
                if (parentWin.dataGridView1.Rows[rowIndex].Cells[22].Value.ToString() == "X")
                    cbFlag.Checked = true;

                this.ActiveControl = btnSave;
            }
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

        #region 주소
        private void lblPost_Click(object sender, EventArgs e)
        {
            PostAddr post = new PostAddr();
            post.FormSendEvent += new PostAddr.FormSendDataHandler(PostEventMethod);
            post.ShowDialog();
        }
        private void PostEventMethod(object sender)
        {
            string sAddr = sender.ToString();

            if (string.IsNullOrEmpty(sAddr)) return;

            tbPostNo.Text = sAddr.Substring(1, 5);
            tbAddr1.Text = sAddr.Substring(7, sAddr.Length - 7);
            tbAddr2.Focus();
        }
        #endregion

        private async void Save()
        {
            lblMsg.Text = "";

            string sCustName = tbCustName.Text.Trim();

            if (String.IsNullOrEmpty(sCustName))
            {
                lblMsg.Text = "거래처명을 입력해 주세요.";
                tbCustName.Focus();
                return;
            }

            string sCeo = tbCeo.Text.Trim();
            string sGubun = cbGubun.Text.Substring(0, 1);
            string sBusiNo = tbBusiNo.Text.Trim();
            string sSaleMan = cbSaleMan.Text.Trim();
            string sPostNo = tbPostNo.Text.Trim();
            string sAddr1 = tbAddr1.Text.Trim();
            string sAddr2 = tbAddr2.Text.Trim();
            string sTel = tbTel.Text.Trim();
            string sFax = tbFax.Text.Trim();
            string sCustMan = tbCustMan.Text.Trim();
            string sManHp = tbHp.Text.Trim();
            string sContents = tbContents.Text.Trim();
            string sFlag = "O";
            if (cbFlag.Checked) sFlag = "X";


            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                //입력한 거래처명이 중복인지 확인..
                if (isCustName(sCustName))
                {
                    lblMsg.Text = "이미 존재하는 거래처명입니다.";
                    tbCustName.Focus();
                    return;
                }

                custCode = getCustCode();

                sql = "insert into tb_gi_customer (cust_id, fullname, abbname, gubun, busi_no, ceo, post_no, address1, address2, tel, fax, cust_man, man_hp, saleman, contents, use_flag, enter_man) " +
                    "values('" + custCode + "','" + sCustName + "','" + sCustName + "'," + sGubun + ",'" + sBusiNo + "','" + sCeo + "','" + sPostNo + "','" + sAddr1 + "','" + sAddr2 + "','" + sTel + "','" + sFax + "','" + sCustMan + "','" + sManHp + "','" + sSaleMan + "','" + sContents + "','" + sFlag + "','" + G.UserID + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                lblMsg.Text = "저장되었습니다.";
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
                {
                    if (parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString() == custCode)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbCustName.Text = string.Empty;
                tbCeo.Text = string.Empty;
                tbBusiNo.Text = string.Empty;
                tbPostNo.Text = string.Empty;
                tbAddr1.Text = string.Empty;
                tbAddr2.Text = string.Empty;
                tbTel.Text = string.Empty;
                tbFax.Text = string.Empty;
                tbCustMan.Text = string.Empty;
                tbHp.Text = string.Empty;
                tbContents.Text = string.Empty;
                tbCustName.Focus();
            }
            else
            {
                sql = "update tb_gi_customer " +
                    "set fullname = '" + sCustName + "', abbname = '" + sCustName + "', gubun = " + sGubun + ", busi_no = '" + sBusiNo + "', ceo = '" + sCeo + "', post_no = '" + sPostNo + "', address1 = '" + sAddr1 + "', address2 = '" + sAddr2 + "', tel = '" + sTel + "', fax = '" + sFax + "', cust_man = '" + sCustMan + "', man_hp = '" + sManHp + "', saleman = '" + sSaleMan + "', contents = '" + sContents + "', use_flag = '" + sFlag + "' " +
                    " where cust_id = '" + custCode + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, custCode + " " + sCustName);

                parentWin.ListSearch();
                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, rowIndex];
                parentWin.dataGridView1.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 거래처코드 생성 / 거래처명 확인
        private string getCustCode()
        {
            string sql = @"select UF_CustCodeGenerator('A')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        private bool isCustName(string _custName)
        {
            string sql = @"select cust_id from tb_gi_customer where fullname = '" + _custName + "' or abbname = '" + _custName + "'";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            object id = m.dbRonlyOne(sql, ref msg);

            if (msg == "OK" && id != null)
                return true;
            else
                return false;
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
    }
}

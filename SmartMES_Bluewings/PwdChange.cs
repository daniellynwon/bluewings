using System;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class PwdChange : Form
    {
        public PwdChange()
        {
            InitializeComponent();
        }

        private void PwdChange_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
        }

        private void ubtnSave_Click(object sender, EventArgs e)
        {
            ufSave();
        }

        private void ubtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected void ufSave()
        {
            lblMsg.Text = String.Empty;

            string stPwd1 = tbPwd1.Text.Trim();
            string stPwd2 = tbPwd2.Text.Trim();
            string stPwd3 = tbPwd3.Text.Trim();

            if (String.IsNullOrEmpty(stPwd1))
            {
                lblMsg.Text = "현재암호를 입력하지 않았습니다.";
                tbPwd1.Focus();
                return;
            }
            if (String.IsNullOrEmpty(stPwd2))
            {
                lblMsg.Text = "변경암호를 입력하지 않았습니다.";
                tbPwd2.Focus();
                return;
            }
            if (String.IsNullOrEmpty(stPwd3))
            {
                lblMsg.Text = "암호확인을 입력하지 않았습니다.";
                tbPwd3.Focus();
                return;
            }
            if (stPwd2 != stPwd3)
            {
                lblMsg.Text = "변경암호와 암호확인이 일치하지 않습니다.";
                tbPwd2.Focus();
                return;
            }
            if (stPwd1 == stPwd2)
            {
                lblMsg.Text = "현재암호와 변경하려는 암호가 동일합니다.";
                tbPwd1.Focus();
                return;
            }
            if (stPwd2.Length < 4)
            {
                lblMsg.Text = "암호는 최대 4자리 이상이여야 합니다.";
                tbPwd2.Focus();
                return;
            }

            MariaCRUD m = new MariaCRUD();
            string sql = "select pwd from tb_sys_user where user_id = '" + G.UserID + "'";
            string msg = string.Empty;
            string strDBpwd = m.dbRonlyOne(sql, ref msg).ToString();
            string strENCpwd = new MyClass().EncryptSHA512(stPwd1);

            if (strENCpwd != strDBpwd)
            {
                lblMsg.Text = "현재암호가 정확하지 않습니다.";
                tbPwd1.Focus();
                return;
            }

            strENCpwd = new MyClass().EncryptSHA512(stPwd2);

            sql = "update tb_sys_user set pwd = '" + strENCpwd + "' where user_id = '" + G.UserID + "'";
            m.dbCUD(sql, ref msg);

            if (msg == "OK")
            {
                MessageBox.Show("패스워드가 정상 변경되었습니다.\r\r다음 로그인 부터 변경된 패스워드가 적용됩니다.");
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(msg);
        }

        private void tbPwd3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ufSave();
            }
        }

        private void tbPwd_TextChanged(object sender, EventArgs e)
        {
            lblMsg.Text = "";
        }
    }
}

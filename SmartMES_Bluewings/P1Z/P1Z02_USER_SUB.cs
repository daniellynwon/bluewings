using System;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1Z02_USER_SUB : Form
    {
        public P1Z02_USER parentWin;
        private int rowIndex = 0;

        public P1Z02_USER_SUB()
        {
            InitializeComponent();
        }

        #region 사번생성 / 확인
        private string getUserID()
        {
            string sql = @"select UF_UserIDGenerator()";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        private bool isUserID(string ID)
        {
            string sql = @"select user_id from tb_sys_user where user_id = '" + ID + "'";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            object id = m.dbRonlyOne(sql, ref msg);

            if (msg == "OK" && id != null)
                return true;
            else
                return false;
        }
        #endregion

        private void P1Z02_USER_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                tbID.Text = getUserID();

                this.ActiveControl = tbName;
                cbAuthority.SelectedIndex = 2;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                tbID.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                tbID.Enabled = false;

                tbName.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbJob.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                tbPhone.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                cbAuthority.SelectedItem = parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                if (parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString() == "0")
                    cbFlag.Checked = true;

                this.ActiveControl = btnSave;
            }
        }

        private async void Save()
        {
            lblMsg.Text = "";

            string userID, userName, job, phone, authority;
            int useFlag = 1;

            userID = tbID.Text.Trim();
            userName = tbName.Text.Trim();
            job = tbJob.Text.Trim();
            phone = tbPhone.Text.Trim();
            authority = cbAuthority.Text.Substring(0, 1);
            if (cbFlag.Checked) useFlag = 0;

            if (String.IsNullOrEmpty(userID))
            {
                lblMsg.Text = "사용자ID를 입력해 주세요.";
                tbID.Focus();
                return;
            }
            if (String.IsNullOrEmpty(userName))
            {
                lblMsg.Text = "사용자명을 입력해 주세요.";
                tbName.Focus();
                return;
            }

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                //입력한 ID가 중복인지 확인..
                if (isUserID(userID))
                {
                    lblMsg.Text = "이미 존재하는 사용자ID입니다.";
                    tbID.Focus();
                    return;
                }

                string pwd = "1234";
                pwd = new MyClass().EncryptSHA512(pwd);

                sql = "insert into tb_sys_user (user_id, user_name, pos, job, user_tel, pwd, authority, user_flag, enter_man) " +
                    "values('" + userID + "','" + userName + "','A','" + job + "','" + phone + "','" + pwd + "','" + authority + "'," + useFlag.ToString() + ",'" + G.UserID + "')";

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
                    if (parentWin.dataGridView1.Rows[i].Cells[0].Value.ToString() == userID)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbID.Text = getUserID();
                tbName.Text = string.Empty;
                tbJob.Text = string.Empty;
                tbPhone.Text = string.Empty;
                tbName.Focus();
            }
            else
            {
                sql = "update tb_sys_user " +
                    "set user_name = '" + userName + "', job = '" + job + "', user_tel = '" + phone + "', authority = '" + authority + "', user_flag = " + useFlag.ToString() +
                    " where user_id = '" + userID + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, userID);

                parentWin.ListSearch();
                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, rowIndex];
                parentWin.dataGridView1.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
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

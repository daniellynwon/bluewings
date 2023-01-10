using Microsoft.Win32;//RegistryKey 사용
using System;
using System.Data;
using System.Runtime.InteropServices;//DllImport
using System.Windows.Forms;
using System.Reflection;
using System.Security.Principal;
using System.Diagnostics;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class FormLogin : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            //if (!IsRunningAsAdministrator())
            //{
            //    ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase);
            //    {
            //        var withBlock = processStartInfo;
            //        withBlock.UseShellExecute = true;
            //        withBlock.Verb = "runas";
            //        Process.Start(processStartInfo);
            //        Application.Exit();
            //    }
            //}

            timer1.Start();
            lblMsg.Text = "";

            string sql = @"select com_name from tb_sys_pos where pos = 'A'";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            string com = m.dbRonlyOne(sql, ref msg).ToString();

            if (msg == "OK") lblCompany.Text = com;
            else lblCompany.Text = "";

            sql = @"select user_id, concat(user_name, if(authority='B',' (관리자)','')) as user_name from tb_sys_user where user_flag = 1 order by authority, user_id";
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbID.DataSource = table;
                cbID.ValueMember = "user_id";
                cbID.DisplayMember = "user_name";
            }

            string ID = string.Empty;
            if (ReadRegistry(ref ID)) cbID.SelectedValue = ID;
        }
        public bool IsRunningAsAdministrator()
        {
            WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);
            return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public bool ReadRegistry(ref string id)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("SoftWare").CreateSubKey("rmis");

            id = reg.GetValue("ID", "").ToString();

            if (string.IsNullOrEmpty(id))
                return false;
            else
                return true;
        }

        public void WriteRegistry(string id)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("SoftWare").CreateSubKey("rmis");

            reg.SetValue("ID", id);
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            tbPWD.Focus();
            tbPWD.SelectAll();
        }

        private void tbPWD_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ufConnection();
            }
        }

        private void ubtnConnect_Click(object sender, EventArgs e)
        {
            ufConnection();
        }

        private void ubtnCancel_Click(object sender, EventArgs e)
        {
            Application.OpenForms["FormLogin"].Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool CapsLock = (((ushort)GetKeyState(0x14)) & 0xffff) != 0;
            lblCapsLock.Text = CapsLock ? "CapsLock On" : "";
        }

        protected async void ufConnection()
        {
            lblMsg.Text = "";

            string empPwd = tbPWD.Text.Trim();
            if (String.IsNullOrEmpty(empPwd))
            {
                lblMsg.Text = "패스워드를 입력하세요.";
                tbPWD.Focus();
                return;
            }

            G.UserID = cbID.SelectedValue.ToString();

            string sql = @"select po.pos, po.com_name, po.pos_name, us.user_name, us.pwd, us.authority " +
                "from tb_sys_user us inner join tb_sys_pos po on us.pos = po.pos " +
                "where us.user_id = '" + G.UserID + "'";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }

            DataRow[] row = table.Select();
            string strPwd;

            if (row.Length > 0)
            {
                strPwd = row[0][4].ToString();

                if (new MyClass().EncryptSHA512(empPwd) != strPwd)
                {
                    lblMsg.Text = "패스워드가 정확하지 않습니다.";
                    tbPWD.Focus();
                    return;
                }

                G.Pos = row[0][0].ToString();
                G.ComName = row[0][1].ToString();
                G.PosName = row[0][2].ToString();
                G.UserName = row[0][3].ToString();
                G.Authority = row[0][5].ToString();

                WriteRegistry(G.UserID);
                m.TransLogCreate(G.Authority, G.UserID, "I", "FormLogin", "Login", "로그인");
                this.DialogResult = DialogResult.OK;
                var result = await Logger.ApiLog(G.UserID, "로그인", ActionType.접속, "");
            }
        }
    }
}

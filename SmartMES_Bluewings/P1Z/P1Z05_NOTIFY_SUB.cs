using System;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1Z05_NOTIFY_SUB : Form
    {
        public P1Z05_NOTIFY parentWin;
        private int rowIndex = 0;
        private string sDateTime;

        public P1Z05_NOTIFY_SUB()
        {
            InitializeComponent();
        }

        private void P1Z05_NOTIFY_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                this.ActiveControl = tbSubject;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                sDateTime = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                sDateTime = DateTime.Parse(sDateTime).ToString("yyyy-MM-dd HH:mm:ss");

                tbSubject.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbContents.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();

                if (parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString() == "게시중")
                    cbFlag.Checked = true;

                this.ActiveControl = btnSave;
            }
        }

        private async void Save()
        {
            lblMsg.Text = "";

            string subject, contents;
            int notiFlag = 0;

            subject = tbSubject.Text.Trim();
            contents = tbContents.Text.Trim();
            if (cbFlag.Checked) notiFlag = 1;

            if (String.IsNullOrEmpty(subject))
            {
                lblMsg.Text = "공지제목을 입력해 주세요.";
                tbSubject.Focus();
                return;
            }

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (notiFlag == 1)
            {
                sql = "update tb_sys_notify set noti_flag = 0";
                m.dbCUD(sql, ref msg);
            }

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                sql = "insert into tb_sys_notify (subject, contents, user_id, noti_flag) " +
                    "values('" + subject + "','" + contents + "','" + G.UserID + "'," + notiFlag + ")";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

                parentWin.ListSearch();

                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, 0];
                parentWin.dataGridView1.CurrentCell.Selected = true;

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                sql = "update tb_sys_notify " +
                    "set subject = '" + subject + "', contents = '" + contents + "', noti_flag = " + notiFlag +
                    " where noti_dt = '" + sDateTime + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sDateTime);

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

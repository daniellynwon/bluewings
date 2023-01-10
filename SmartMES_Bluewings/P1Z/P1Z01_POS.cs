using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1Z01_POS : SmartMES_Bluewings.FormBasic
    {
        public P1Z01_POS()
        {
            InitializeComponent();
        }
        private void P1Z01_POS_Load(object sender, EventArgs e)
        {
            PosSearch(G.Pos);
        }

        private void PosSearch(string pos)
        {
            lblMsg.Text = "";

            MariaCRUD m = new MariaCRUD();
            string sql = @"select com_name, ceo, homepage, busi_no, bubin_no, uptae, jongmog, post_no, address1, address2, tel, fax, SEC_TO_TIME(job_starttime) " +
                "from tb_sys_pos where pos = '" + pos + "'";
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg != "OK") return;

            DataRow[] row = table.Select();

            if (row.Length > 0)
            {
                tbName.Text = row[0][0].ToString();
                tbCeo.Text = row[0][1].ToString();
                tbHomePage.Text = row[0][2].ToString();
                tbBusiNo.Text = row[0][3].ToString();
                tbBubinNo.Text = row[0][4].ToString();
                tbUpTae.Text = row[0][5].ToString();
                tbJongMong.Text = row[0][6].ToString();
                tbPostNo.Text = row[0][7].ToString();
                tbAddr1.Text = row[0][8].ToString();
                tbAddr2.Text = row[0][9].ToString();
                tbTel.Text = row[0][10].ToString();
                tbFax.Text = row[0][11].ToString();
                mtbJobStartTime.Text = row[0][12].ToString().Substring(0, 5);
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

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            PosSearch(G.Pos);
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            //
        }
        private async void pbSave_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string sName = tbName.Text.Trim();
            string sCeo = tbCeo.Text.Trim();
            string sHomePage = tbHomePage.Text.Trim();
            string sBusiNo = tbBusiNo.Text.Trim();
            string sBubinNo = tbBubinNo.Text.Trim();
            string sUpTae = tbUpTae.Text.Trim();
            string sJongMong = tbJongMong.Text.Trim();
            string sPostNo = tbPostNo.Text.Trim();
            string sAddr1 = tbAddr1.Text.Trim();
            string sAddr2 = tbAddr2.Text.Trim();
            string sTel = tbTel.Text.Trim();
            string sFax = tbFax.Text.Trim();
            string sStartTime = mtbJobStartTime.Text.Trim();

            if (string.IsNullOrEmpty(sName))
            {
                lblMsg.Text = "회사공식명을 입력해 주세요.";
                tbName.Focus();
                return;
            }

            if (sStartTime == ":") sStartTime = "00:00";

            if (sStartTime.Length != 5)
            {
                lblMsg.Text = "작업시작시간을 확인해 주세요.";
                mtbJobStartTime.Focus();
                return;
            }
            sStartTime = sStartTime + ":00";

            string sql = "update tb_sys_pos " +
                "set pos_name = '" + sName + "', ceo = '" + sCeo + "', homepage = '" + sHomePage + "', busi_no = '" + sBusiNo + "', bubin_no = '" + sBubinNo + "', uptae = '" + sUpTae + "', jongmog = '" + sJongMong + "', post_no = '" + sPostNo + "', address1 = '" + sAddr1 + "', address2 = '" + sAddr2 + "', tel = '" + sTel + "', fax = '" + sFax + "', job_starttime = TIME_TO_SEC('" + sStartTime + "'), enter_dt = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', enter_man = '" + G.UserID + "' " +
                "where pos = 'A'";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

            lblMsg.Text = "저장되었습니다.";
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            //
        }
        #endregion

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
    }
}

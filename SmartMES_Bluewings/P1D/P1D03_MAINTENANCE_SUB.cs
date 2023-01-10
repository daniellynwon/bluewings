using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1D03_MAINTENANCE_SUB : Form
    {
        public P1D03_MAINTENANCE parentWin;

        private int rowIndex = 0;
        private string machineID = string.Empty;
        private string seq = string.Empty;

        public P1D03_MAINTENANCE_SUB()
        {
            InitializeComponent();
        }

        private void P1D03_MAINTENANCE_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                cbKind.SelectedIndex = 0;
                this.ActiveControl = tbGoal;
            }
            else
            {
                lblSelect.Enabled = false;
                lblSelect.ForeColor = lblHo.ForeColor;
                lblSelect.Font = new Font(lblSelect.Font, FontStyle.Regular);

                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                machineID = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                seq = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();

                tbHo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbName.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                tbModel.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                tbModel.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();
                dtpDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString());
                dtpDateA.Text = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                dtpDateB.Text = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                cbKind.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
                tbGoal.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
                tbResult.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
                tbMan.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();
                tbMoney.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
                tbContents.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[14].Value.ToString();

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

        private async void Save()
        {
            lblMsg.Text = "";

            if (string.IsNullOrEmpty(machineID))
            {
                lblMsg.Text = "설비정보를 확인해주세요.";
                lblSelect.Focus();
                return;
            }

            if (string.IsNullOrEmpty(dtpDateA.Text) || dtpDateA.Text.Length != 19)
            {
                lblMsg.Text = "고장일시를 확인해주세요";
                dtpDateA.Focus();
                return;
            }
            if(string.IsNullOrEmpty(dtpDateA.Text) && !(string.IsNullOrEmpty(dtpDateB.Text)))
            {
                lblMsg.Text = "고장일시를 입력하세요";
                dtpDate.Focus();
                return;
            }
            //if (string.IsNullOrEmpty(dtpDateB.Text))
            //{
            //    lblMsg.Text = "수리일시를 확인해주세요";
            //    dtpDateA.Focus();
            //    return;
            //}

            string sDate = DateTime.Parse(dtpDate.Value.ToString()).ToString("yyyy-MM-dd");
            string sDate1 = dtpDateA.Text;
            string sDate2 = string.Empty;

            if (dtpDateB.Text.Length == 19) sDate2 = dtpDateB.Text;
            else sDate2 = "";

            string sKind = cbKind.Text.Substring(0, 1);
            string sGoal = tbGoal.Text.Trim();
            string sResult = tbResult.Text.Trim();
            string sMan = tbMan.Text.Trim();
            string sMoeny = tbMoney.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(sMoeny)) sMoeny = "NULL";
            string sContents = tbContents.Text.Trim();

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                seq = getSeq(machineID);

                sql = "insert into tb_machine_repair (machine_id, seq, repair_date, repairtime_a, repairtime_b, repair_kind, repair_goal, repair_result, repair_man, repair_money, contents, enter_man) " +
                    "values(" + machineID + "," + seq + ",'" + sDate + "','" + sDate1 + "',if('" + sDate2 + "' = '',null,'" + sDate2 + "')," + sKind + ",'" + sGoal + "','" + sResult + "','" + sMan + "'," + sMoeny + ",'" + sContents + "','" + G.UserID + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

                lblMsg.Text = "저장되었습니다.";

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridView1.Rows.Count - 1; i++)
                {
                    if (parentWin.dataGridView1.Rows[i].Cells[0].Value.ToString() == machineID
                        && DateTime.Parse(parentWin.dataGridView1.Rows[i].Cells[5].Value.ToString()).ToString("yyyy-MM-dd") == sDate
                        && parentWin.dataGridView1.Rows[i].Cells[6].Value.ToString().Substring(0, 1) == sKind)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                machineID = string.Empty;
                seq = string.Empty;
                tbHo.Text = string.Empty;
                dtpDateA.Text = string.Empty;
                dtpDateB.Text = string.Empty;
                tbName.Text = string.Empty;
                tbModel.Text = string.Empty;
                tbModel.Tag = string.Empty;
                tbGoal.Text = string.Empty;
                tbResult.Text = string.Empty;
                tbMan.Text = string.Empty;
                tbMoney.Text = string.Empty;
                tbContents.Text = string.Empty;
                tbGoal.Focus();
            }
            else // 수정 및 update
            {
                sql = "update tb_machine_repair " +
                    "set repair_date = '" + sDate + "', repairtime_a = '" + sDate1 + "', repairtime_b = if('" + sDate2 + "' = '',null,'" + sDate2 + "'), repair_kind = " + sKind + ", repair_goal = '" + sGoal + "', repair_result = '" + sResult + "', repair_man = '" + sMan + "', repair_money = " + sMoeny + ", contents = '" + sContents + "'" +
                    " where machine_id = " + machineID + " and seq = " + seq;

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, machineID + "-" + seq + " " + tbName.Text + " " + tbModel.Text);

                parentWin.ListSearch();
                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, rowIndex];
                parentWin.dataGridView1.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 설비별 seq 생성
        private string getSeq(string _mid)
        {
            string sql = @"select seq from tb_machine_repair where machine_id = " + _mid + " order by seq desc limit 1";

            MariaCRUD m = new MariaCRUD();

            try
            {
                string msg = string.Empty;
                string seq = m.dbRonlyOne(sql, ref msg).ToString();

                seq = (Int32.Parse(seq) + 1).ToString();

                return seq;
            }
            catch (NullReferenceException)
            {
                return "1";
            }

        }
        #endregion

        #region 텍스트 박스 숫자 처리
        private void tbMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText;

                lgsText = tbMoney.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbMoney.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));

                tbMoney.SelectionStart = tbMoney.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbMoney.SelectionLength = 0;
            }
            catch (FormatException)
            {
                return;
            }
        }
        private void tbMoney_KeyPress(object sender, KeyPressEventArgs e)
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

        #region 설비선택
        private void lblSelect_Click(object sender, EventArgs e)
        {
            MachineFinder sub = new MachineFinder();
            sub.FormSendEvent += new MachineFinder.FormSendDataHandler(PostEventMethod);
            sub.ShowDialog();
        }
        private void PostEventMethod(object sender)
        {
            string sAddr = sender.ToString();

            if (string.IsNullOrEmpty(sAddr)) return;

            machineID = sAddr.Substring(0, sAddr.IndexOf("#1/"));
            tbHo.Text = sAddr.Substring(sAddr.IndexOf("#1/") + 3, sAddr.IndexOf("#2/") - (sAddr.IndexOf("#1/") + 3));
            tbName.Text = sAddr.Substring(sAddr.IndexOf("#2/") + 3, sAddr.IndexOf("#3/") - (sAddr.IndexOf("#2/") + 3));
            tbModel.Tag = sAddr.Substring(sAddr.IndexOf("#3/") + 3, sAddr.IndexOf("#4/") - (sAddr.IndexOf("#3/") + 3));
            tbModel.Text = sAddr.Substring(sAddr.IndexOf("#4/") + 3, sAddr.Length - (sAddr.IndexOf("#4/") + 3));
            tbGoal.Focus();
        }
        #endregion
    }
}

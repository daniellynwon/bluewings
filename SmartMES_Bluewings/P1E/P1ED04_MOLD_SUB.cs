using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1ED04_MOLD_SUB : Form
    {
        public P1ED04_MOLD parentWin;

        private int rowIndex = 0;
        private string moldID = string.Empty;

        public P1ED04_MOLD_SUB()
        {
            InitializeComponent();
        }

        private void P1ED04_MOLD_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                cbPlace.SelectedIndex = 0; cbStatus.SelectedIndex = 0;
                this.ActiveControl = tbName;
                tbNo.Text = getMoldCode();
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;
                string sPlace = "A.생산"; string sStat = "0.양호";
                moldID = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                tbNo.Text = moldID;
                tbName.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbCust.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                tbCust.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                dtpDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
                tbMoneyA.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                cbPlace.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();

                if (parentWin.dataGridView1.Rows[rowIndex].Cells[14].Value.ToString() == "0")
                    cbStatus.Text = "0.양호";
                else cbStatus.Text = "1.수리중";

                if (parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString() == "")
                    dtpDateA.Text = "";
                else 
                    dtpDateA.Text = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                tbLap.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
                tbMoneyB.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
                string sFile1 = parentWin.dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();

                if (string.IsNullOrEmpty(sFile1))
                {
                    doc1.buttonImage = Properties.Resources.clipB;
                    doc1.Tag = "";
                }
                else
                {
                    doc1.buttonImage = Properties.Resources.clipA;
                    doc1.Tag = sFile1;
                }

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

            if (string.IsNullOrEmpty(tbName.Text))
            {
                lblMsg.Text = "금형명을 입력하세요.";
                tbName.Focus();
                return;
            }

            string sNo = tbNo.Text;
            string sName = tbName.Text; string sCust = tbCust.Tag.ToString();
            string sDate = DateTime.Parse(dtpDate.Value.ToString()).ToString("yyyy-MM-dd"); // 제작일자
            string sDate1 = string.Empty;

            if (dtpDateA.Text.Length == 19) sDate1 = dtpDateA.Text;
            else sDate1 = "";

            string sPlace = cbPlace.Text.Substring(0, 1);
            string sStat = cbStatus.Text.Substring(0, 1);
            string sMoneyA = tbMoneyA.Text.Replace(",", "").Trim();
            string sLap = tbLap.Text;
            if (string.IsNullOrEmpty(sMoneyA)) sMoneyA = "NULL";
            string sMoneyB = tbMoneyB.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(sMoneyB)) sMoneyB = "NULL";

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                //sNo = getMoldCode();
                sql = "insert into tb_mold_info (mold_id, mold_name, cust_id, mold_date, mold_amount, location, mold_status, time_move, time_h, use_amount, enter_man) " +
                    "values('" + sNo + "','" + sName + "','" + sCust + "','" + sDate + "'," + sMoneyA + ",'" + sPlace + "','" + sStat + "','" + sDate1 + "'," + sLap + "," + sMoneyB + ",'" + G.UserID + "')";

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
                    if (parentWin.dataGridView1.Rows[i].Cells[0].Value.ToString() == sNo)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                moldID = string.Empty; tbNo.Text = string.Empty;
                dtpDateA.Text = string.Empty;
                tbLap.Text = string.Empty;
                tbName.Text = string.Empty;
                tbMoneyA.Text = string.Empty;
                tbMoneyB.Text = string.Empty;
                tbCust.Text = string.Empty;
                tbName.Focus();
            }
            else // 수정 및 update
            {
                sql = "update tb_mold_info " +
                    "set mold_name = '" + sName + "', cust_id = '" + sCust + "',mold_date = '" + sDate + "', mold_amount = " + sMoneyA + "', location = '" + sPlace + "', mold_status = '" + sStat +
                    "', time_move = '" + sDate1 + "', time_h = " + sLap + ", use_amount = " + sMoneyB +
                    " where machine_id = '" + moldID + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, moldID + " " + tbName.Text);

                parentWin.ListSearch();
                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, rowIndex];
                parentWin.dataGridView1.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 텍스트 박스 숫자 처리
        private void tbMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText, lgsText1;

                lgsText = tbMoneyA.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                lgsText1 = tbLap.Text.Replace(",", "");
                tbMoneyA.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));
                tbLap.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText1));

                tbMoneyA.SelectionStart = tbMoneyA.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbMoneyA.SelectionLength = 0;
                tbLap.SelectionStart = tbLap.TextLength; tbLap.SelectionLength = 0;
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

        #region Controls Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void lblCust_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            CustFinder sub = new CustFinder();
            sub.FormSendEvent += new CustFinder.FormSendDataHandler(PostEventMethod);
            sub._gubun = "103";
            sub.ShowDialog();
        }
        private void PostEventMethod(object sender)
        {
            string sCust = sender.ToString();

            if (string.IsNullOrEmpty(sCust)) return;

            tbCust.Tag = sCust.Substring(0, sCust.IndexOf("#1/"));
            tbCust.Text = sCust.Substring(sCust.IndexOf("#1/") + 3, sCust.IndexOf("#2/") - (sCust.IndexOf("#1/") + 3));
            tbMoneyA.Focus();
        }
        #endregion

        #region 금형코드 생성
        private string getMoldCode()
        {
            string sql = @"select UF_MoldCodeGenerator()";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        #endregion

        #region User Buttons
        public void userButtonA1_Click(object sender, EventArgs e)
        {
            if (parentWin.dataGridView1.CurrentRow == null || parentWin.dataGridView1.CurrentRow.Index < 0) return;

            //P1ED04_MOLD_SUB_DOC sub = new P1ED04_MOLD_SUB_DOC();
            //sub.parentWin = this;
            //sub.sNo = "1";
            //sub.sParentCode = moldID;   // 설비ID
            //sub.sFileName = doc1.Tag.ToString();
            //sub.ShowDialog();
        }
        public void userButtonA2_Click(object sender, EventArgs e)
        {
            if (parentWin.dataGridView1.CurrentRow == null || parentWin.dataGridView1.CurrentRow.Index < 0) return;

            //P1ED04_MOLD_SUB_DOC sub = new P1ED04_MOLD_SUB_DOC();
            //sub.parentWin = this;
            //sub.sNo = "2";
            //sub.sParentCode = moldID;   // 작성일자
            //sub.sFileName = doc2.Tag.ToString();
            //sub.ShowDialog();
        }
        #endregion
    }
}

using System;
using System.Drawing;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1ED04_MOLD_MOVE : Form
    {
        public P1ED04_MOLD parentWin;

        private int rowIndex = 0;
        private string moldID = string.Empty;

        public P1ED04_MOLD_MOVE()
        {
            InitializeComponent();
        }

        private void P1ED04_MOLD_MOVE_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            cbGubun.SelectedIndex = 0;
            cbLocationB.SelectedIndex = 0;

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                cbLocationA.SelectedIndex = 0;
                this.ActiveControl = tbMoney;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                moldID = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                tbNo.Text = moldID;
                tbName.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                cbLocationA.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
                dtpDateA.Text = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
                tbMoney.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
                string sFile1 = parentWin.dataGridView1.Rows[rowIndex].Cells[19].Value.ToString();

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
            string sDate = dtpDateA.Text;   //DateTime.Parse(dtpDateA.Text.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            string sGubun = cbGubun.Text.Substring(0, 1);
            string sPlaceA = cbLocationA.Text.Substring(0, 1);
            string sPlaceB = cbLocationB.Text.Substring(0, 1);
            string sMoeny = tbMoney.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(sMoeny)) sMoeny = "NULL";

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                moldID = getMoldCode();

                sql = "insert into tb_mold_move (mold_id, gubun, org_location, mv_location, time_move, amount, enter_man) " +
                    "values('" + moldID + "','" + sGubun + "','" + sPlaceA + "','" + sPlaceB + "',if('" + sDate + "' = '',null,'" + sDate + "')," + sMoeny + "," + G.UserID + "')";

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
                    if (parentWin.dataGridView1.Rows[i].Cells[0].Value.ToString() == moldID)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                moldID = string.Empty;
                cbGubun.SelectedIndex = 0;
                cbLocationA.SelectedIndex = 0;
                cbLocationB.SelectedIndex = 0;
                tbMoney.Text = string.Empty;
                tbMoney.Focus();
            }
            else // 수정 및 update
            {
                sql = "update tb_mold_move " +
                    "set gubun = '" + sGubun + "', org_location = '" + sPlaceA + "', mv_location = '" + sPlaceB + "', time_move = if('" + sDate + "' = '',null,'" + sDate + "'), amount = " + sMoeny +
                    " where mold_id = '" + moldID + "'";

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

        #region 버튼
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region User Buttons
        public void userButtonA1_Click(object sender, EventArgs e)
        {
            if (parentWin.dataGridView1.CurrentRow == null || parentWin.dataGridView1.CurrentRow.Index < 0) return;

            //P1ED04_MOLD_MOVE_DOC sub = new P1ED04_MOLD_MOVE_DOC();
            //sub.parentWin = this;
            //sub.sNo = "1";
            //sub.sParentCode = moldID;   // 설비ID
            //sub.sFileName = doc1.Tag.ToString();
            //sub.ShowDialog();
        }
        public void userButtonA2_Click(object sender, EventArgs e)
        {
            if (parentWin.dataGridView1.CurrentRow == null || parentWin.dataGridView1.CurrentRow.Index < 0) return;

            //P1ED04_MOLD_MOVE_DOC sub = new P1ED04_MOLD_MOVE_DOC();
            //sub.parentWin = this;
            //sub.sNo = "2";
            //sub.sParentCode = moldID;   // 작성일자
            //sub.sFileName = doc2.Tag.ToString();
            //sub.ShowDialog();
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
    }
}

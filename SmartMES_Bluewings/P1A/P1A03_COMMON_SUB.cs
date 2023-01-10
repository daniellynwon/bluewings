using System;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1A03_COMMON_SUB : Form
    {
        public P1A03_COMMON parentWin;
        public string kind;
        private int rowIndex = 0;
        private string custCode = string.Empty;

        public P1A03_COMMON_SUB()
        {
            InitializeComponent();
        }

        private void P1A03_COMMON_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            tbKind.Text = parentWin.lblSubject.Text;

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                tbCode.Text = getCommonCode(kind);
                this.ActiveControl = tbItem;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                tbCode.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                tbItem.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                tbContents.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();

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

            string sItem = tbItem.Text.Trim();

            if (String.IsNullOrEmpty(sItem))
            {
                lblMsg.Text = "항목명을 입력해 주세요.";
                tbKind.Focus();
                return;
            }

            string sCode = tbCode.Text;
            string sContents = tbContents.Text.Trim();

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                //입력한 거래처명이 중복인지 확인..
                if (isCommonItem(kind, sItem))
                {
                    lblMsg.Text = "이미 존재하는 항목명입니다.";
                    tbItem.Focus();
                    return;
                }

                sql = "insert into tb_gi_common (co_kind, co_code, co_item, contents) " +
                    "values('" + kind + "','" + sCode + "','" + sItem + "','" + sContents + "')";

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
                    if (parentWin.dataGridView1.Rows[i].Cells[3].Value.ToString() == sCode)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbCode.Text = getCommonCode(kind);
                tbItem.Text = string.Empty;
                tbContents.Text = string.Empty;
                tbItem.Focus();
            }
            else
            {
                sql = "update tb_gi_common " +
                    "set co_item = '" + sItem + "', contents = '" + sContents + "'" +
                    " where co_kind = '" + kind + "' and co_code = '" + sCode + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, tbKind.Text + " " + sCode);
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                parentWin.ListSearch();
                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, rowIndex];
                parentWin.dataGridView1.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 공통코드 생성 / 항목명 확인
        private string getCommonCode(string _kind)
        {
            string sql = @"select UF_CommonCodeGenerator('" + _kind + "')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        private bool isCommonItem(string _kind, string _item)
        {
            string sql = @"select co_code from tb_gi_common where co_kind = '" + _kind + "' and co_item = '" + _item + "'";

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

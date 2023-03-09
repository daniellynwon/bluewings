using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1ED03_QC_DOC_SUB : Form
    {
        public P1ED03_QC_DOC parentWin;
        private int rowIndex = 0;
        private string custCode = string.Empty;

        public P1ED03_QC_DOC_SUB()
        {
            InitializeComponent();
        }

        private void P1ED03_QC_DOC_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                this.ActiveControl = tbNo;
                cbGubun.SelectedIndex = 0;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                tbNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                cbGubun.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                string sFile1 = parentWin.dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
                string sFile2 = parentWin.dataGridView1.Rows[rowIndex].Cells[17].Value.ToString();

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
                if (string.IsNullOrEmpty(sFile2))
                {
                    doc2.buttonImage = Properties.Resources.clipB;
                    doc2.Tag = "";
                }
                else
                {
                    doc2.buttonImage = Properties.Resources.clipA;
                    doc2.Tag = sFile2;
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

            string sNo = tbNo.Text.Trim();
            if (tbNo.Text == "") sNo = "null";
            string sGubun = cbGubun.Text.Substring(0, 1);
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                sql = "insert into tb_quality_doc (docdata_no, check_date, gubun, enter_man) " +
                    "values('" + sNo + "','" + sDate + "','" + sGubun + "','" + G.UserID + "')";

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

                tbNo.Text = string.Empty;
                tbNo.Focus();
            }
            else
            {
                sql = "update tb_quality_doc " +
                    "set check_date = '" + sDate + "', gubun = " + sGubun + ", enter_man = '" + G.UserID + "' where docdata_no = '" + sNo + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sDate + " " + sNo);

                parentWin.ListSearch();
                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, rowIndex];
                parentWin.dataGridView1.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region Button Control
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
            P1ED03_QC_DOC_DOC sub = new P1ED03_QC_DOC_DOC();
            sub.parentWin = this;
            sub.sNo = "1";
            sub.sParentCode = tbNo.Text;    // 문서번호
            if (tbNo.Text == "") lblMsg.Text = "작성일자와 구분을 먼저 저장하세요.";
            if (doc1.Tag == null) sub.sFileName = "";
            else
                sub.sFileName = doc1.Tag.ToString();
            sub.ShowDialog();
        }
        public void userButtonA2_Click(object sender, EventArgs e)
        {
            if (parentWin.dataGridView1.CurrentRow == null || parentWin.dataGridView1.CurrentRow.Index < 0) return;

            P1ED03_QC_DOC_DOC sub = new P1ED03_QC_DOC_DOC();
            sub.parentWin = this;
            sub.sNo = "2";
            sub.sParentCode = tbNo.Text;    // 문서번호
            if (tbNo.Text == "") lblMsg.Text = "작성일자와 구분을 먼저 저장하세요.";
            if (doc2.Tag == null) sub.sFileName = "";
            else
                sub.sFileName = doc2.Tag.ToString();
            sub.ShowDialog();
        }
        #endregion
    }
}

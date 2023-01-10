using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1Z02_USER : SmartMES_Bluewings.FormBasic
    {
        public P1Z02_USER()
        {
            InitializeComponent();
        }
        private void P1Z02_USER_Load(object sender, EventArgs e)
        {
            cbFlag.SelectedIndex = 0;
            ListSearch();

            this.ActiveControl = tbSearch;
        }

        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();
                int iFlag = Int32.Parse(cbFlag.Text.Substring(0, 1));

                sP_User_QueryTableAdapter.Fill(dataSetP1Z.SP_User_Query, sSearch, iFlag);
                var data = dataSetP1Z.SP_User_Query;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
            }
            catch (NullReferenceException)
            {
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            P1Z02_USER_SUB sub = new P1Z02_USER_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        #endregion

        #region Condition Bar Events
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }

        private void cbFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int rowIndex = dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible);
            if (rowIndex <= 0) return;

            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(93, 123, 157);
            dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

            dataGridView1[1, rowIndex].Value = rowIndex.ToString() + "명";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible) == e.RowIndex) return;

            if (e.ColumnIndex == 0)
            {
                P1Z02_USER_SUB sub = new P1Z02_USER_SUB();
                sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
                sub.parentWin = this;
                sub.ShowDialog();
            }
            else if (e.ColumnIndex == 6)
            {
                int index = 0;
                string userID = string.Empty;
                string userName = string.Empty;

                try
                {
                    index = dataGridView1.CurrentRow.Index;
                    userID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    userName = dataGridView1.Rows[index].Cells[1].Value.ToString();

                    if (dataGridView1.Rows[index].Selected != true) return;
                }
                catch (NullReferenceException)
                {
                    return;
                }

                if (string.IsNullOrEmpty(userID)) return;

                DialogResult dr = MessageBox.Show(userName + "\r\r선택된 사용자의 암호를 초기화(1234) 하시겠습니까?", this.lblTitle.Text + "[암호초기화]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.No) return;


                string InitPwd = new MyClass().EncryptSHA512("1234");
                string sql = "update tb_sys_user set pwd = '" + InitPwd + "' where user_id = '" + userID + "'";

                MariaCRUD m = new MariaCRUD();
                string msg = string.Empty;
                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                    MessageBox.Show(msg);
            }
            else
            {
                return;
            }
        }
        #endregion
    }
}

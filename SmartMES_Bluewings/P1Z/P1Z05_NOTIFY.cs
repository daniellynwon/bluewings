using System;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1Z05_NOTIFY : SmartMES_Bluewings.FormBasic
    {
        public P1Z05_NOTIFY()
        {
            InitializeComponent();
        }
        private void P1Z05_NOTIFY_Load(object sender, EventArgs e)
        {
            ListSearch();
            this.ActiveControl = tbSearch;
        }

        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();

                sP_Notify_QueryTableAdapter.Fill(dataSetP1Z.SP_Notify_Query, sSearch);
                var data = dataSetP1Z.SP_Notify_Query;
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
            P1Z05_NOTIFY_SUB sub = new P1Z05_NOTIFY_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            int index = 0;
            string sDateTime = string.Empty;
            string sTitle = string.Empty;

            try
            {
                index = dataGridView1.CurrentRow.Index;
                sDateTime = dataGridView1.Rows[index].Cells[0].Value.ToString();
                sDateTime = DateTime.Parse(sDateTime).ToString("yyyy-MM-dd HH:mm:ss");
                sTitle = dataGridView1.Rows[index].Cells[1].Value.ToString();

                if (dataGridView1.Rows[index].Selected != true)
                {
                    MessageBox.Show("삭제 정보가 선택되지 않았습니다.", this.lblTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("삭제 정보가 선택되지 않았습니다.", this.lblTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult dr = MessageBox.Show(sTitle + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_sys_notify where noti_dt = '" + sDateTime + "'";
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.삭제, data);//삭제로그추가

            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sTitle);

            ListSearch();
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            //
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
        private void btnTest_Click(object sender, EventArgs e)
        {
            string check = "-";
            int notiIndex = -1;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                check = dataGridView1.Rows[i].Cells[3].Value.ToString();
                if (check == "게시중")
                {
                    notiIndex = i;
                    break;
                }
            }

            if (notiIndex < 0)
            {
                MessageBox.Show("게시중인 공지가 존재하지 않습니다.");
                return;
            }

            FormNotify sub = new FormNotify();
            sub.lblSubject.Text = dataGridView1.Rows[notiIndex].Cells[1].Value.ToString();
            sub.tbContents.Text = dataGridView1.Rows[notiIndex].Cells[2].Value.ToString();
            sub.ckbToday.Enabled = false;
            sub.ShowDialog();
        }
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 1) return;

            P1Z05_NOTIFY_SUB sub = new P1Z05_NOTIFY_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        #endregion
    }
}

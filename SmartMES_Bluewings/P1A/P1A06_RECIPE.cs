using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{ 
    public partial class P1A06_RECIPE : SmartMES_Bluewings.FormBasic
    {
        public P1A06_RECIPE()
        {
            InitializeComponent();
        }
        private void P1A06_RECIPE_Load(object sender, EventArgs e)
        {
            ListSearch();
            this.ActiveControl = tbSearch;
        }

        public async void ListSearch()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();
                sP_Recipe_QueryTableAdapter.Fill(dataSetP1A.SP_Recipe_Query, sSearch);
                var data = dataSetP1A.SP_Recipe_Query;
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
            P1A06_RECIPE_SUB sub = new P1A06_RECIPE_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (G.Authority == "D") return;
            if (dataGridView1.RowCount == 0) return;

            int index = 0;
            string sRecipeNo = string.Empty;

            try
            {
                index = dataGridView1.CurrentRow.Index;
                sRecipeNo = dataGridView1.Rows[index].Cells[1].Value.ToString();

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

            DialogResult dr = MessageBox.Show("레시피No. : " + sRecipeNo + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;


            string sql = @"select count(recipe_no) from tb_gi_recipe where recipe_no = '" + sRecipeNo + "'";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            string com = m.dbRonlyOne(sql, ref msg).ToString();

            sql = "delete from tb_gi_recipe where recipe_no = '" + sRecipeNo + "'";
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.삭제, data);//삭제로그추가

            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sRecipeNo);

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
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.RowCount < 1) return;

            try
            {
                string sCodeA = dataGridView1.Rows[0].Cells[1].Value.ToString();
                string sCodeB = dataGridView1.Rows[0].Cells[2].Value.ToString();

                for (int i = 1; i < dataGridView1.RowCount; i++)
                {
                    if (sCodeA == dataGridView1.Rows[i].Cells[1].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[1].Style.ForeColor = Color.Transparent;
                    }
                    sCodeA = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    if (sCodeB == dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[2].Style.ForeColor = Color.Transparent;
                    }
                    sCodeB = dataGridView1.Rows[i].Cells[2].Value.ToString();

                    if(dataGridView1.Rows[i].Cells[5].Value.ToString() == "0")  // 비율이 0이면 안보이게 하기.
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            //if (e.ColumnIndex != 1) return;

            //P1A06_RECIPE_SUB sub = new P1A06_RECIPE_SUB();
            //sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
            //sub.parentWin = this;
            //sub.ShowDialog();
        }
        #endregion
    }
}

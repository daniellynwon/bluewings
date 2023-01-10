using System;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1Z06_LOG : SmartMES_Bluewings.FormBasic
    {
        public P1Z06_LOG()
        {
            InitializeComponent();
        }
        private void P1Z06_LOG_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Today.AddDays(-7);
            ListSearch();
            this.ActiveControl = tbSearch;
        }

        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sGubun = "";
                if (cbI.Checked) sGubun = sGubun + "I";
                else sGubun = sGubun + "-";
                if (cbO.Checked) sGubun = sGubun + "O";
                else sGubun = sGubun + "-";
                if (cbS.Checked) sGubun = sGubun + "S";
                else sGubun = sGubun + "-";
                if (cbD.Checked) sGubun = sGubun + "D";
                else sGubun = sGubun + "-";
                if (cbM.Checked) sGubun = sGubun + "M";
                else sGubun = sGubun + "-";
                if (cbP.Checked) sGubun = sGubun + "P";
                else sGubun = sGubun + "-";

                string sSearch = tbSearch.Text.Trim();
                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                if (dtFromDate > dtToDate)
                    MessageBox.Show("기간 설정이 정확하지 않습니다.\r\r다시 확인해 주세요.");

                sP_Log_QueryTableAdapter.Fill(dataSetP1Z.SP_Log_Query, sGubun, sSearch, dtFromDate, dtToDate);
                var data = dataSetP1Z.SP_Log_Query;
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
            //
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MessageBox.Show("삭제 정보가 존재하지 않았습니다.", this.lblTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("조회된 해당 정보를 모두 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            string sGubun = "";
            if (cbI.Checked) sGubun = sGubun + "I";
            else sGubun = sGubun + "-";
            if (cbO.Checked) sGubun = sGubun + "O";
            else sGubun = sGubun + "-";
            if (cbS.Checked) sGubun = sGubun + "S";
            else sGubun = sGubun + "-";
            if (cbD.Checked) sGubun = sGubun + "D";
            else sGubun = sGubun + "-";
            if (cbM.Checked) sGubun = sGubun + "M";
            else sGubun = sGubun + "-";
            if (cbP.Checked) sGubun = sGubun + "P";
            else sGubun = sGubun + "-";

            string sSearch = tbSearch.Text.Trim();
            if (string.IsNullOrEmpty(sSearch)) sSearch = "%";
            if (string.IsNullOrEmpty(sSearch)) sSearch = "%";
            else sSearch = "%" + sSearch + "%";

            string sFromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
            string sToDate = dtpToDate.Value.ToString("yyyy-MM-dd");

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_sys_log " +
                "where date(log_dt) between '" + sFromDate + "' and '" + sToDate + "' " +
                "and gubun in (substr('" + sGubun + "',1,1), substr('" + sGubun + "', 2, 1), substr('" + sGubun + "', 3, 1), substr('" + sGubun + "', 4, 1), substr('" + sGubun + "', 5, 1), substr('" + sGubun + "', 6, 1)) " +
                "and CONCAT((select u.user_name from tb_sys_user u where u.user_id = tb_sys_log.user_id),' ',log_ip,' ',pg_name,' ',contents) LIKE '" + sSearch + "'";

            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }

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
        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
        #endregion
    }
}

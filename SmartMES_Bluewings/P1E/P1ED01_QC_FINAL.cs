using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1ED01_QC_FINAL : SmartMES_Bluewings.FormBasic
    {
        public P1ED01_QC_FINAL()
        {
            InitializeComponent();
        }
        private void P1ED01_QC_FINAL_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Today.AddDays(-15);

            string sql = @"select t.user_id, t.user_name
                            from(
                            select '-' as user_id, '-' as user_name
                            union 
                            select user_id, user_name from tb_sys_user where authority in ('B','C') and user_flag = 1) as t
                            order by t.user_name";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbQcMan.DataSource = table;
                cbQcMan.ValueMember = "user_id";
                cbQcMan.DisplayMember = "user_name";
            }
        }
        public async void ListSearch1()
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                if (dtFromDate > dtToDate)
                    MessageBox.Show("기간 설정이 정확하지 않습니다.\r\r다시 확인해 주세요.");

                string sSearch1 = tbSearch1.Text.Trim();
                string sSearch2 = tbSearch2.Text.Trim();

                sP_QcFinal_ROderTableAdapter.Fill(dataSetP1E.SP_QcFinal_ROder, dtFromDate, dtToDate, sSearch1, sSearch2);
                var data = dataSetP1E.SP_QcFinal_ROder;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

                dataGridViewList.CurrentCell = null;
                dataGridViewList.ClearSelection();
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
        public async void ListSearch2(string jobNo)
        {
            lblMsg.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                sP_QcFinal_QueryTableAdapter.Fill(dataSetP1E.SP_QcFinal_Query, jobNo, "%");
                var data = dataSetP1E.SP_QcFinal_Query;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();

                //dtpDate.Value = DateTime.Parse(dataGridView1[6, 0].Value.ToString());   // 납기
                cbQcMan.SelectedValue = dataGridView1[7, 0].Value.ToString();
                tbContents.Text = dataGridView1[5, 0].Value.ToString();
                int idx = dataGridViewList.CurrentRow.Index;
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
        public void ListInit()
        {
            lblMsg.Text = "";
            try
            {
                sP_QcFinal_QueryTableAdapter.Fill(dataSetP1E.SP_QcFinal_Query, "-", "-");

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();

                dtpDate.Value = DateTime.Today;
                cbQcMan.SelectedValue = "-";
                tbContents.Text = string.Empty;
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        #region Controls Event
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListSearch1();
        }
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch1();
            }
        }
        #endregion

        #region GridView Events
        private void dataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int index = dataGridViewList.CurrentRow.Index;
            string sPoNo = dataGridViewList[0, index].Value.ToString();
            int qcCnt = Int32.Parse(dataGridViewList[6, index].Value.ToString());

            if (qcCnt > 0) ListSearch2(sPoNo);
            else ListInit();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMsg.Text = "";
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 9) return;

            dataGridView1.Rows[e.RowIndex].Cells[3].Value = "";
            dataGridView1.Rows[e.RowIndex].Cells[4].Value = "0.대 기";
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch1();
            ListInit();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (dataGridViewList.RowCount <= 0 || dataGridViewList.CurrentRow == null)
            {
                lblMsg.Text = "추가할 검사건이 선택되지 않았습니다.";
                return;
            }
            if (dataGridView1.RowCount > 0)
            {
                lblMsg.Text = "이미 검사 데이터가 존재합니다.";
                return;
            }
            try
            {
                sP_QcFinal_QueryTableAdapter.Fill(dataSetP1E.SP_QcFinal_Query, "", "%");

                dataGridView1.CurrentCell = dataGridView1[3, 0];

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[4].Value = "1.합 격";
                }

                cbQcMan.SelectedValue = "-";
                tbContents.Text = string.Empty;
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (dataGridView1.RowCount <= 0)
            {
                lblMsg.Text = "삭제할 검사 건이 선택되지 않았습니다.";
                return;
            }

            if (dataGridView1[9, 0].Value == null || string.IsNullOrEmpty(dataGridView1[9, 0].Value.ToString()))
            {
                lblMsg.Text = "저장되지 않은 검사 건입니다.";
                return;
            }

            string sJobNo = dataGridView1[9, 0].Value.ToString();

            DialogResult dr = MessageBox.Show("포대번호 : " + sJobNo + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_qc_final where prod_no = '" + sJobNo + "'";
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }
            sql = "update tb_prod_done_sub set qc_flag = 0 where prod_no = '" + sJobNo + "'";
            m.dbCUD(sql, ref msg);

            dataGridViewList[7, dataGridViewList.CurrentRow.Index].Value = 0;
            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sJobNo + " " + "");
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

            ListInit();
            lblMsg.Text = "삭제되었습니다.";
        }
        private async void pbSave_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            if (dataGridViewList.RowCount <= 0 || dataGridViewList.CurrentRow == null)
            {
                lblMsg.Text = "저장할 검사건이 선택되지 않았습니다.";
                return;
            }
            if (dataGridView1.RowCount <= 0)
            {
                lblMsg.Text = "저장 검사 건이 추가되지 않았습니다.";
                return;
            }
            if (string.IsNullOrEmpty(cbQcMan.SelectedValue.ToString()) || cbQcMan.SelectedValue.ToString() == "-")
            {
                lblMsg.Text = "검사원이 선택되지 않았습니다.";
                return;
            }
            dataGridView1.CurrentCell = dataGridView1[1, 0];

            string sQcMan = cbQcMan.SelectedValue.ToString();
            string sProdNo = dataGridViewList.Rows[dataGridViewList.CurrentRow.Index].Cells[0].Value.ToString();
            string sItem = string.Empty;
            string sResult = string.Empty;
            string sDecison = string.Empty;
            string sContents = tbContents.Text.Trim();
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            int q = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                sItem = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
                sResult = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
                sDecison = dataGridView1.Rows[i].Cells[4].Value.ToString().Substring(0, 1);

                sql = "INSERT INTO tb_qc_final(qc_item, prod_no, qc_result, qc_decision, contents, qc_date, qc_man, enter_man) " +
                        "VALUES('" + sItem + "','" + sProdNo + "','" + sResult + "'," + sDecison + ",'" + sContents + "','" + sDate + "','" + sQcMan + "','" + G.UserID + "') " +
                        "ON DUPLICATE KEY UPDATE " +
                        "qc_result = '" + sResult + "', qc_decision = " + sDecison + ", contents = '" + sContents + "', qc_date = '" + sDate + "', qc_man = '" + sQcMan + "'";

                m.dbCUD(sql, ref msg);

                q++;
            }
            sql = "update tb_prod_done_sub set qc_flag = 1 where prod_no = '" + sProdNo + "'";
            m.dbCUD(sql, ref msg);
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

            dataGridViewList[6, dataGridViewList.CurrentRow.Index].Value = q;   // 검사건수
            lblMsg.Text = "저장되었습니다.";
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (dataGridView1.RowCount <= 0)
            {
                lblMsg.Text = "성적서 발행건이 선택되지 않았습니다.";
                return;
            }

            if (dataGridView1[6, 0].Value == null || string.IsNullOrEmpty(dataGridView1[6, 0].Value.ToString()))
            {
                lblMsg.Text = "저장된 검사건만 성적서 출력이 가능합니다.";
                return;
            }

            string sJobNo = dataGridViewList.Rows[dataGridViewList.CurrentRow.Index].Cells[0].Value.ToString();
            sP_QcFinal_PrintTableAdapter.Fill(dataSetP1E.SP_QcFinal_Print, sJobNo);

            string reportFileName = "SmartMES_Bluewings.Reports.P1ED01_QC_FINAL.rdlc";

            ViewReport_V viewReport = new ViewReport_V();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportDataSource rds = new ReportDataSource("DataSet1", sPQcFinalPrintBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion
    }
}

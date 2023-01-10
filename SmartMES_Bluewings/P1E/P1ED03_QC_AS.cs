using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1ED03_QC_AS : SmartMES_Bluewings.FormBasic
    {
        public P1ED03_QC_AS()
        {
            InitializeComponent();
        }
        private void P1ED03_QC_AS_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-01-01"));
            cbState.SelectedIndex = 0;
            this.ActiveControl = tbSearch;
        }
        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sFrom = dtpFromDate.Value.ToString("yyyy-MM-dd");
                string sTo = dtpToDate.Value.ToString("yyyy-MM-dd");
                string sSearch = tbSearch.Text.Trim();
                string sState = cbState.Text;
                if (sState == "<전체>") sState = "%";
                else sState = sState.Substring(0, 1);

                sP_QcAS_QueryTableAdapter.Fill(dataSetP1E.SP_QcAS_Query, DateTime.Parse(sFrom), DateTime.Parse(sTo), sSearch, sState);
                var data = dataSetP1E.SP_QcAS_Query;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #region Condition Bar Events
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
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

            dataGridView1[11, rowIndex].Value = rowIndex.ToString() + "건";

            long iSum = 0;

            for (int i = 0; i < rowIndex; i++)
            {
                iSum += long.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
            }

            dataGridView1[9, rowIndex].Value = iSum;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 0) return;
            if (dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible) == e.RowIndex) return;

            P1ED03_QC_AS_SUB sub = new P1ED03_QC_AS_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            P1ED03_QC_AS_SUB sub = new P1ED03_QC_AS_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            int index = 0;
            string sID = string.Empty;
            string sDate = string.Empty;
            string sCustName = string.Empty;

            try
            {
                index = dataGridView1.CurrentRow.Index;
                sID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                sDate = DateTime.Parse(dataGridView1.Rows[index].Cells[5].Value.ToString()).ToString("yyyy-MM-dd");
                sCustName = dataGridView1.Rows[index].Cells[2].Value.ToString();

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

            DialogResult dr = MessageBox.Show(sID + "\r" + sDate + "\r" + sCustName + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_qc_claim where claim_id = '" + sID + "'";
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.삭제, data);//삭제로그추가

            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sID + " " + sDate + " " + sCustName);

            ListSearch();
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 1) return;

            string reportFileName = "SmartMES_Bluewings.Reports.P1ED03_QC_AS.rdlc";

            string reportParm1 = "발생기간 : ";
            string reportParm2 = "거래처/발생내역 : ";
            string reportParm3 = "진 행 : ";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(tbSearch.Text.Trim())) reportParm2 = reportParm2 + "전체";
            else reportParm2 = reportParm2 + tbSearch.Text.Trim();
            reportParm3 = reportParm3 + cbState.Text;

            ViewReport_H viewReport = new ViewReport_H();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPQcASQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion
    }
}

using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1C04_MATERIAL_USE : SmartMES_Bluewings.FormBasic
    {
        public P1C04_MATERIAL_USE()
        {
            InitializeComponent();
        }
        private void P1C04_MATERIAL_USE_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));

            string sql = @"select t.co_code, t.co_item from (select '%' as co_code, '<전체>' as co_item union select co_code, co_item from tb_gi_common where co_kind = 'B') as t order by t.co_code";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbDepot.DataSource = table;
                cbDepot.ValueMember = "co_code";
                cbDepot.DisplayMember = "co_item";
            }

            sql = @"select t.co_code, t.co_item from (select '%' as co_code, '<전체>' as co_item union select co_code, co_item from tb_gi_common where co_kind = 'C') as t order by t.co_code";
            m = new MariaCRUD();
            msg = string.Empty;
            table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbKind.DataSource = table;
                cbKind.ValueMember = "co_code";
                cbKind.DisplayMember = "co_item";
            }
        }
        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sFrom = dtpFromDate.Value.ToString("yyyy-MM-dd");
                string sTo = dtpToDate.Value.ToString("yyyy-MM-dd");
                string sDepot = cbDepot.SelectedValue.ToString();
                string sKind = cbKind.SelectedValue.ToString();

                sP_MaterialUse_QueryTableAdapter.Fill(dataSetP1C.SP_MaterialUse_Query, G.Pos, DateTime.Parse(sFrom), DateTime.Parse(sTo), sDepot, sKind);

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();
                var data = dataSetP1C.SP_MaterialUse_Query;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

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

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            P1C04_MATERIAL_USE_SUB sub = new P1C04_MATERIAL_USE_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            int index = 0;
            string sID = string.Empty;
            string sDate = string.Empty;
            string sProdName = string.Empty;

            try
            {
                index = dataGridView1.CurrentRow.Index;
                sID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                sDate = DateTime.Parse(dataGridView1.Rows[index].Cells[1].Value.ToString()).ToString("yyyy-MM-dd");
                sProdName = dataGridView1.Rows[index].Cells[4].Value.ToString();

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


            DialogResult dr = MessageBox.Show(sDate + "\r" + sProdName + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_material_use where use_id = " + sID;
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.삭제, data);//삭제로그추가

            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sDate + " " + sProdName);

            ListSearch();
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 1) return;

            string reportFileName = "SmartMES_Bluewings.Reports.P1C04_MATERIAL_USE.rdlc";

            string reportParm1 = "생산기간 : ";
            string reportParm2 = "자재창고 : ";
            string reportParm3 = "자재분류 : ";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");
            reportParm2 = reportParm2 + cbDepot.Text;
            reportParm3 = reportParm3 + cbKind.Text;

            ViewReport_V viewReport = new ViewReport_V();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPMaterialUseQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

        #region Condition Bar Events
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListSearch();
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

            long iSum = 0;

            for (int i = 0; i < rowIndex; i++)
            {
                iSum += long.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
            }

            dataGridView1[2, rowIndex].Value = rowIndex.ToString() + "건";
            dataGridView1[7, rowIndex].Value = iSum;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 4) return;
            if (dataGridView1.Rows.GetLastRow(DataGridViewElementStates.Visible) == e.RowIndex) return;

            P1C04_MATERIAL_USE_SUB sub = new P1C04_MATERIAL_USE_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        #endregion
    }
}

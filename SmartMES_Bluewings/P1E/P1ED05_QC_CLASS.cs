using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1ED05_QC_CLASS : FormBasic
    {
        public P1ED05_QC_CLASS()
        {
            InitializeComponent();
        }
        private void P1ED05_QC_CLASS_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
            this.ActiveControl = tbSearch;
        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                string sSearch = tbSearch.Text.Trim();
                string sClass = string.Empty;;

                if (dtFromDate > dtToDate)
                    MessageBox.Show("기간 설정이 정확하지 않습니다.\r\r다시 확인해 주세요.");

                sP_Qc_Class_QueryTableAdapter.Fill(dataSetP1E.SP_Qc_Class_Query, dtFromDate, dtToDate, sSearch);

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

        #region Condition Bar Events
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void cbA_CheckedChanged(object sender, EventArgs e)
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

            dataGridView1[0, rowIndex].Value = rowIndex.ToString() + "건";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (dataGridView1.RowCount <= 0) return;

            if (e.ColumnIndex == 1) //LotNo
            {
                P1ED05_QC_CLASS_SUB sub = new P1ED05_QC_CLASS_SUB();
                sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
                sub.parentWin = this;
                sub.ShowDialog();
            }

            if (e.ColumnIndex == 11)
            {
                string sJobNo = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sUnitNo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string sNo = sJobNo + "-" + sUnitNo;

                //P1ED05_QC_CLASS_SUB1 sub = new P1ED05_QC_CLASS_SUB1();
                //sub.parentWin = this;
                //sub.rowIndex = e.RowIndex;
                //sub.ShowDialog();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (dataGridView1.RowCount <= 0) return;
            if (e.ColumnIndex != 15) return;

            string sJobNo = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string sProdNo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (string.IsNullOrEmpty(sJobNo)) return;

            DialogResult dr = MessageBox.Show("JobNo.: " + sJobNo + "\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_prod_done_main where job_no = '" + sJobNo + "'";
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }

            sql = "update tb_prod_order a set a.prod_flag = 0 where a.job_no = '" + sJobNo + "' and a.proc_no = (select s.proc_no from tb_gi_process s where s.proc_std = a.proc_std and s.final_flag = 1)";
            m.dbCUD(sql, ref msg);

            //sql = "delete from tb_qrcode where kind = 'B' and code_no = '" + sProdNo + "'";
            //m.dbCUD(sql, ref msg);

            ListSearch();
        }
        // 자식 폼 중복 여부
        private bool formIsExist(Type tp)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == tp)
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            P1ED05_QC_CLASS_SUB sub = new P1ED05_QC_CLASS_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            sub.parentWin = this;
            sub.ShowDialog();
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 1) return;

            string reportFileName = "SmartMES_Bluewings.Reports.P1ED05_QC_CLASS.rdlc";

            string reportParm1 = "검사기간 : ";
            string reportParm2 = " ";
            string reportParm3 = " ";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");

            ViewReport_H viewReport = new ViewReport_H();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds1 = new ReportDataSource("DataSet1", sPQcClassQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds1);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        #endregion

    }
}

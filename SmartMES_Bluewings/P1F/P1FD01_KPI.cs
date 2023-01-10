using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1FD01_KPI : SmartMES_Bluewings.FormBasic
    {
        public P1FD01_KPI()
        {
            InitializeComponent();
        }
        private void P1FD01_KPI_Load(object sender, EventArgs e)
        {
            cbYYYY.Text = DateTime.Today.Year.ToString();
        }
        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                int iYYYY = Int32.Parse(cbYYYY.Text);

                sP_KPITableAdapter.Fill(dataSetP1F.SP_KPI, iYYYY);
                var data = dataSetP1F.SP_KPI;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();

                ChartSearch();
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
        public void ChartSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DataSet dsOrigin = dataSetP1F.SP_KPI.DataSet;
                string sCheckItem = string.Empty;

                foreach (DataRow order in dsOrigin.Tables[0].Rows)
                {
                    if (order["M_NO"].ToString() == "1")
                    {
                        sCheckItem = "시간당생산량(톤/시간)";
                        chart1.Series[sCheckItem].Points.Clear();

                        chart1.Series[sCheckItem].Points.AddXY("1월", order["M01"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("2월", order["M02"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("3월", order["M03"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("4월", order["M04"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("5월", order["M05"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("6월", order["M06"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("7월", order["M07"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("8월", order["M08"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("9월", order["M09"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("10월", order["M10"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("11월", order["M11"].ToString());
                        chart1.Series[sCheckItem].Points.AddXY("12월", order["M12"].ToString());
                    }
                    else if (order["M_NO"].ToString() == "2")
                    {
                        sCheckItem = "완제품불량률(%)";
                        chart2.Series[sCheckItem].Points.Clear();

                        chart2.Series[sCheckItem].Points.AddXY("1월", order["M01"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("2월", order["M02"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("3월", order["M03"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("4월", order["M04"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("5월", order["M05"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("6월", order["M06"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("7월", order["M07"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("8월", order["M08"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("9월", order["M09"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("10월", order["M10"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("11월", order["M11"].ToString());
                        chart2.Series[sCheckItem].Points.AddXY("12월", order["M12"].ToString());
                    }
                    else if (order["M_NO"].ToString() == "3")
                    {
                        sCheckItem = "전력사용량(W)";
                        chart3.Series[sCheckItem].Points.Clear();

                        chart3.Series[sCheckItem].Points.AddXY("1월", order["M01"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("2월", order["M02"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("3월", order["M03"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("4월", order["M04"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("5월", order["M05"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("6월", order["M06"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("7월", order["M07"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("8월", order["M08"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("9월", order["M09"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("10월", order["M10"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("11월", order["M11"].ToString());
                        chart3.Series[sCheckItem].Points.AddXY("12월", order["M12"].ToString());
                    }
                    else if (order["M_NO"].ToString() == "4")
                    {
                        sCheckItem = "월별매입액(천원)";
                        chart4.Series[sCheckItem].Points.Clear();

                        chart4.Series[sCheckItem].Points.AddXY("1월", order["M01"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("2월", order["M02"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("3월", order["M03"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("4월", order["M04"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("5월", order["M05"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("6월", order["M06"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("7월", order["M07"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("8월", order["M08"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("9월", order["M09"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("10월", order["M10"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("11월", order["M11"].ToString());
                        chart4.Series[sCheckItem].Points.AddXY("12월", order["M12"].ToString());
                    }
                    else if (order["M_NO"].ToString() == "5")
                    {
                        sCheckItem = "월별매출액(천원)";
                        chart5.Series[sCheckItem].Points.Clear();

                        chart5.Series[sCheckItem].Points.AddXY("1월", order["M01"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("2월", order["M02"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("3월", order["M03"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("4월", order["M04"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("5월", order["M05"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("6월", order["M06"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("7월", order["M07"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("8월", order["M08"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("9월", order["M09"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("10월", order["M10"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("11월", order["M11"].ToString());
                        chart5.Series[sCheckItem].Points.AddXY("12월", order["M12"].ToString());
                    }
                    //else if (order["M_NO"].ToString() == "4")
                    //{
                    //    sCheckItem = "납기리드타임(일)";
                    //    chart4.Series[sCheckItem].Points.Clear();

                    //    chart4.Series[sCheckItem].Points.AddXY("1월", order["M01"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("2월", order["M02"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("3월", order["M03"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("4월", order["M04"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("5월", order["M05"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("6월", order["M06"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("7월", order["M07"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("8월", order["M08"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("9월", order["M09"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("10월", order["M10"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("11월", order["M11"].ToString());
                    //    chart4.Series[sCheckItem].Points.AddXY("12월", order["M12"].ToString());
                    //}
                    else
                        return;
                }
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
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
        #endregion

        #region GridView Events
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "0") dataGridView1[3, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "0") dataGridView1[4, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "0") dataGridView1[5, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "0") dataGridView1[6, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "0") dataGridView1[7, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "0") dataGridView1[8, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[9].Value.ToString() == "0") dataGridView1[9, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[10].Value.ToString() == "0") dataGridView1[10, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "0") dataGridView1[11, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[12].Value.ToString() == "0") dataGridView1[12, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[13].Value.ToString() == "0") dataGridView1[13, i].Style.ForeColor = Color.Transparent;
                if (dataGridView1.Rows[i].Cells[14].Value.ToString() == "0") dataGridView1[14, i].Style.ForeColor = Color.Transparent;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        #endregion

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
            //
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 1) return;

            string reportFileName = "SmartMES_Bluewings.Reports.P1FD01_KPI.rdlc";

            string reportParm1 = "조회년도 : ";
            string reportParm2 = "";
            string reportParm3 = "";

            reportParm1 = reportParm1 + cbYYYY.Text + "년도";


            ViewReport_H viewReport = new ViewReport_H();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPKPIBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }

        #endregion

        private void P1FD01_KPI_Activated(object sender, EventArgs e)
        {
            ListSearch();
        }
    }
}

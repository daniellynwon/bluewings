using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.IO;
using System;

namespace SmartMES_Bluewings
{
    public partial class P1ED02_QC_LIST : SmartMES_Bluewings.FormBasic
    {
        DataTable dt = null;

        public P1ED02_QC_LIST()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.dtpFrom.ValueChanged -= new System.EventHandler(this.dtpFrom_ValueChanged);
            this.dtpTo.ValueChanged -= new System.EventHandler(this.dtpTo_ValueChanged);

            DateTime today = DateTime.Now;
            DateTime firstDay = today.AddDays(1 - today.Day);
            dtpFrom.Value = firstDay;


            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
        }

        private void P1ED02_QC_LIST_Load(object sender, EventArgs e)
        {
            // 차트설정
            //chartA.ChartAreas[0].AxisX.LabelStyle.Format = "M-d h:m:s";
            chartA.ChartAreas[0].AxisY.Title = "단편신장율[%]";
            //chartB.ChartAreas[0].AxisX.LabelStyle.Format = "M-d h:m:s";
            chartB.ChartAreas[0].AxisY.Title = "시편무게[g]";

            chartA.Series[0].Name = "1라인";
            chartA.Series[1].Name = "2라인";
            chartA.Series[2].Name = "3라인";

            chartB.Series[0].Name = "1라인";
            chartB.Series[1].Name = "2라인";
            chartB.Series[2].Name = "3라인";
            //chartA.Series[0].ToolTip = string.Format("생산량 {0}[Kg]", "#VALY{N0}");
            //chartB.Series[0].ToolTip = string.Format("생산량 {0}[%]", "#VALY{N0}");

            Init();

            Search();
        }
        
        public void Search()
        {
            try
            {
                //sP_QualityInspection_QueryTableAdapter.Fill(dataSetP1E.SP_QualityInspection_Query,dtpFrom.Value, dtpTo.Value);

                dgv1.CurrentCell = null;
                dgv1.ClearSelection();

                foreach (var series in chartA.Series)
                    series.Points.Clear();
                foreach (var series in chartB.Series)
                    series.Points.Clear();

                //sP_QualityInspection_Chart_QueryTableAdapter.Fill(dataSetP1E.SP_QualityInspection_Chart_Query,dtpFrom.Value, dtpTo.Value);
                //dt = G.Table(sPWorkResultDayQueryBindingSource);
                chartA.DataSource = sPQualityInspectionChartQueryBindingSource;
                chartB.DataSource = sPQualityInspectionChartQueryBindingSource;

                chartA.Series[0].XValueMember = "row_num";
                chartA.Series[0].YValueMembers = "1라인_단편신장율";
                chartA.Series[1].XValueMember = "row_num";
                chartA.Series[1].YValueMembers = "2라인_단편신장율";
                chartA.Series[2].XValueMember = "row_num";
                chartA.Series[2].YValueMembers = "3라인_단편신장율";

                chartB.Series[0].XValueMember = "row_num";
                chartB.Series[0].YValueMembers = "1라인_시편무게";
                chartB.Series[1].XValueMember = "row_num";
                chartB.Series[1].YValueMembers = "2라인_시편무게";
                chartB.Series[2].XValueMember = "row_num";
                chartB.Series[2].YValueMembers = "3라인_시편무게";
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnExcelSave_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string sFileName = string.Format("측정데이터 {0}.csv", 
                DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
            string sFile = string.Format(@"{0}\{1}", path, sFileName);
            //string sTemp = "";

            Stream FS = new FileStream(sFile, FileMode.Create, FileAccess.Write);
            StreamWriter wr = new StreamWriter(FS, Encoding.UTF8);
            wr.WriteLine("측정시각,온도1,온도2,온도3,온도4,온도5,온도6,습도1,습도2,습도3,습도4,습도5,습도6");

            foreach (DataRow row in dt.Rows)
            {
                wr.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}",
                    row["측정시각"].ToString(),
                    row["온도1"].ToString(), row["온도2"].ToString(), row["온도3"].ToString(),
                    row["온도4"].ToString(), row["온도5"].ToString(), row["온도6"].ToString(),
                    row["습도1"].ToString(), row["습도2"].ToString(), row["습도3"].ToString(),
                    row["습도4"].ToString(), row["습도5"].ToString(), row["습도6"].ToString()));
                //wr.Write("\r\n");
            }     

            wr.Close();

            //MyMsgBox msgbox = new MyMsgBox();
            //msgbox.Set(MessageBoxIcon.Warning, MessageBoxButtons.OK, MessageBoxDefaultButton.Button1, string.Format("'{0}'을\n 내문서에 저장했습니다!", sFileName));
            //msgbox.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var series in chartA.Series)
                series.Points.Clear();
            foreach (var series in chartB.Series)
                series.Points.Clear();
            while (dgv1.Rows.Count > 0)
                dgv1.Rows.RemoveAt(0);
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}

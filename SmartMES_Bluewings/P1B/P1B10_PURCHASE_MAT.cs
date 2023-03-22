using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1B10_PURCHASE_MAT : SmartMES_Bluewings.FormBasic
    {
        public P1B10_PURCHASE_MAT()
        {
            InitializeComponent();
        }
        private void P1B10_PURCHASE_MAT_Load(object sender, EventArgs e)
        {
            cbTerm.SelectedIndex = 0;
            dtpFromDate.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-01"));
            cbGubun.SelectedIndex = 0;

            this.ActiveControl = tbSearch;
        }
        public async void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sFlag = cbTerm.Text.Substring(0, 1);
                DateTime dtFromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd"));
                DateTime dtToDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd"));

                if (dtFromDate > dtToDate)
                    MessageBox.Show("기간 설정이 정확하지 않습니다.\r\r다시 확인해 주세요.");

                string sSearch = tbSearch.Text.Trim();
                string sGubun = cbGubun.Text;
                if (sGubun == "<전체>") sGubun = "%";
                else if (!string.IsNullOrEmpty(sGubun)) sGubun = sGubun.Substring(0, 1);

                sP_PurchaseMat_QueryTableAdapter.Fill(dataSetP1B.SP_PurchaseMat_Query, sFlag, dtFromDate, dtToDate, sSearch, sGubun, "A");
                var data = dataSetP1B.SP_PurchaseMat_Query;
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

        #region Condition Bar Events
        private void cbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSearch();
        }
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
        private void cbGubun_SelectedIndexChanged(object sender, EventArgs e)
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

            dataGridView1[3, rowIndex].Value = rowIndex.ToString() + "건";

            try
            {
                long iSum1 = 0, iSum2 = 0, iSum3 = 0, iSum4 = 0, iSum5 = 0, iSum6 = 0;
                DataGridViewButtonCell buttonCell;

                for (int i = 0; i < rowIndex; i++)
                {
                    iSum1 += (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[8].Value.ToString()) ? 0 : long.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()));
                    iSum2 += (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[10].Value.ToString()) ? 0 : long.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()));   //발주액
                    iSum3 += (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[16].Value.ToString()) ? 0 : long.Parse(dataGridView1.Rows[i].Cells[16].Value.ToString()));   //입고량
                    iSum4 += (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[17].Value.ToString()) ? 0 : long.Parse(dataGridView1.Rows[i].Cells[17].Value.ToString()));   //매입액
                    iSum5 += (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[18].Value.ToString()) ? 0 : long.Parse(dataGridView1.Rows[i].Cells[18].Value.ToString()));   //부가세
                    iSum6 += (string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[19].Value.ToString()) ? 0 : long.Parse(dataGridView1.Rows[i].Cells[19].Value.ToString()));   //합계
                }

                dataGridView1[8, rowIndex].Value = iSum1;
                dataGridView1[10, rowIndex].Value = iSum2;
                dataGridView1[16, rowIndex].Value = iSum3;
                dataGridView1[17, rowIndex].Value = iSum4;
                dataGridView1[18, rowIndex].Value = iSum5;
                dataGridView1[19, rowIndex].Value = iSum6;

                buttonCell = (DataGridViewButtonCell)dataGridView1.Rows[rowIndex].Cells[13];
                buttonCell.FlatStyle = FlatStyle.Flat;
                buttonCell.Value = ""; buttonCell.ReadOnly = true;
            }
            catch (NullReferenceException)
            {
                return;
            }
            // 중복
            if (dataGridView1.RowCount < 1) return;

            try
            {
                //string sCodeA = dataGridView1.Rows[0].Cells[0].Value.ToString();

                //for (int i = 1; i < dataGridView1.RowCount; i++)
                //{
                //    if (sCodeA == dataGridView1.Rows[i].Cells[0].Value.ToString())
                //    {
                //        dataGridView1.Rows[i].Cells[12].Value = "";
                //        dataGridView1.Rows[i].Cells[5].Value = "";
                //        for (int j = 1; j < 13; j++)
                //        {
                //            dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.Transparent;
                //        }
                //    }
                //    sCodeA = dataGridView1.Rows[i].Cells[0].Value.ToString();
                //}
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
            if (e.RowIndex == dataGridView1.RowCount - 1) return;

            dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            dataGridView1.CurrentCell.Selected = true;

            if (e.ColumnIndex == 5)
            {
                P1B10_PURCHASE_MAT_SUB sub = new P1B10_PURCHASE_MAT_SUB();
                sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
                sub._gubun = "A";
                sub.parentWin = this;
                sub.ShowDialog();
            }
            else if (e.ColumnIndex == 12)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[12].Value == null)
                    dataGridView1.Rows[e.RowIndex].Cells[12].Value = 1;
                else
                    dataGridView1.Rows[e.RowIndex].Cells[12].Value = 0;
            }
            else if (e.ColumnIndex == 13)   // 입고
            {
                P1B10_PURCHASE_MAT_IN sub = new P1B10_PURCHASE_MAT_IN();
                if (dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString() == "0")
                    sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
                else
                    sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
                sub.parentWin = this;
                sub.isModify = false;
                sub.ShowDialog();
            }
            else if (e.ColumnIndex == 15)       // 입고일
            {
                P1B10_PURCHASE_MAT_IN sub = new P1B10_PURCHASE_MAT_IN();
                if (dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString() == "0")
                    sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
                else
                    sub.lblTitle.Text = sub.lblTitle.Text + "[수정]";
                sub.parentWin = this;
                sub.isModify = true;
                sub.ShowDialog();
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == dataGridView1.RowCount - 1) return;

            if (!(e.ColumnIndex == 16 || e.ColumnIndex == 17 || e.ColumnIndex == 18 || e.ColumnIndex == 19))
                return;

            if (string.IsNullOrEmpty(e.Value.ToString()))
            {
                e.CellStyle.ForeColor = Color.Transparent;
                return;
            }

            if (e.Value.ToString() == "0")
                e.CellStyle.ForeColor = Color.Transparent;
            else
            {
                if (e.ColumnIndex == 18)
                {
                    long lQty = long.Parse(dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString());
                    long lDanga = long.Parse(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
                    long lAmount = long.Parse(dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString());

                    if ((lQty * lDanga) == lAmount)
                        e.CellStyle.ForeColor = Color.Black;
                    else
                        e.CellStyle.ForeColor = Color.Red;
                }
                else
                    e.CellStyle.ForeColor = Color.Black;
            }
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            P1B10_PURCHASE_MAT_SUB sub = new P1B10_PURCHASE_MAT_SUB();
            sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            sub.parentWin = this;
            sub._gubun = "A";
            sub.ShowDialog();
        }
        private async void pbDel_Click(object sender, EventArgs e)
        {
            int index = 0;
            string sNo = string.Empty;
            string sCustName = string.Empty;
            string sProdName = string.Empty;

            try
            {
                index = dataGridView1.CurrentRow.Index;
                sNo = dataGridView1.Rows[index].Cells[0].Value.ToString();
                sCustName = dataGridView1.Rows[index].Cells[3].Value.ToString();
                sProdName = dataGridView1.Rows[index].Cells[5].Value.ToString();

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


            DialogResult dr = MessageBox.Show(sNo + "\r" + sCustName + "\r(" + sProdName + ")\r\r해당 정보를 삭제하시겠습니까?", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = "delete from tb_purchase_mat where purch_id = '" + sNo + "'";
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.삭제, data);//삭제로그추가

            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sNo + " " + sCustName + " (" + sProdName + ")");

            ListSearch();
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            string reportFileName = "SmartMES_Bluewings.Reports.P1B10_PURCHASE_MAT.rdlc";

            string reportParm1 = cbTerm.Text.Substring(2, cbTerm.Text.Length - 2) + " : ";
            string reportParm2 = "발주처/품목명 : ";
            string reportParm3 = "구 분 : ";

            reportParm1 = reportParm1 + dtpFromDate.Value.ToString("yyyy-MM-dd") + " ~ " + dtpToDate.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(tbSearch.Text.Trim())) reportParm2 = reportParm2 + "전체";
            else reportParm2 = reportParm2 + tbSearch.Text.Trim();

            reportParm3 = reportParm3 + cbGubun.Text;

            ViewReport_H viewReport = new ViewReport_H();
            viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2, rp3 });

            ReportDataSource rds = new ReportDataSource("DataSet1", sPPurchaseMatQueryBindingSource);
            viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            viewReport.reportViewer1.LocalReport.Refresh();

            viewReport.ShowDialog();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1) return;
            int iCnt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                bool chkeck = Convert.ToBoolean(dataGridView1.Rows[i].Cells[12].Selected.ToString());
                if (chkeck == true)
                {
                    iCnt++;
                }
            }
            MessageBox.Show("준비중...");
            //DialogResult dr = MessageBox.Show("자재발주서 선택출력 \r\r선택내용을 출력 하시겠습니까?", this.lblTitle.Text + "[출력]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dr == DialogResult.No) return;

            //if (iCnt == 0)
            //{
            //    MessageBox.Show("선택한 내용이 없어 발주서 출력이 불가능합니다..");
            //    return;
            //}
            //if (iCnt > 15)
            //{
            //    MessageBox.Show("발주서는 15건 이상 선택이 불가능합니다..");
            //    return;
            //}
            //string reportFileName = "SmartMES_Hansungtech.Reports.P1C01_PURCHASE_MAT.rdlc";

            //string reportParm1 = "";
            //string reportParm2 = "";
            //string reportParm3 = "";
            //string reportParm4 = "";
            //string reportParm5 = "";
            //string reportParm6 = "";
            //string reportParm7 = "";
            //string reportParm8 = "";
            //string reportParm9 = "";
            //string reportParm10 = "";

            //string reportParm11 = "";
            //string reportParm12 = "";
            //string reportParm13 = "";
            //string reportParm14 = "";
            //string reportParm15 = "";
            //string reportParm16 = "";
            //string reportParm17 = "";
            //string reportParm18 = "";
            //string reportParm19 = "";
            //string reportParm20 = "";

            //string reportParm21 = "";
            //string reportParm22 = "";
            //string reportParm23 = "";
            //string reportParm24 = "";
            //string reportParm25 = "";
            //string reportParm26 = "";
            //string reportParm27 = "";
            //string reportParm28 = "";
            //string reportParm29 = "";
            //string reportParm30 = "";

            //string reportParm31 = "";
            //string reportParm32 = "";
            //string reportParm33 = "";
            //string reportParm34 = "";
            //string reportParm35 = "";
            //string reportParm36 = "";
            //string reportParm37 = "";
            //string reportParm38 = "";
            //string reportParm39 = "";
            //string reportParm40 = "";

            //string reportParm41 = "";
            //string reportParm42 = "";
            //string reportParm43 = "";
            //string reportParm44 = "";
            //string reportParm45 = "";
            //string reportParm46 = "";
            //string reportParm47 = "";
            //string reportParm48 = "";
            //string reportParm49 = "";
            //string reportParm50 = "";

            //string reportParm51 = "";
            //string reportParm52 = "";
            //string reportParm53 = "";
            //string reportParm54 = "";
            //string reportParm55 = "";
            //string reportParm56 = "";
            //string reportParm57 = "";
            //string reportParm58 = "";
            //string reportParm59 = "";
            //string reportParm60 = "";

            //string reportParm61 = "";
            //string reportParm62 = "";
            //string reportParm63 = "";
            //string reportParm64 = "";
            //string reportParm65 = "";
            //string reportParm66 = "";
            //string reportParm67 = "";
            //string reportParm68 = "";
            //string reportParm69 = "";
            //string reportParm70 = "";

            //string reportParm71 = "";
            //string reportParm72 = "";
            //string reportParm73 = "";
            //string reportParm74 = "";
            //string reportParm75 = "";
            //string reportParm76 = "";
            //string reportParm77 = "";
            //string reportParm78 = "";
            //string reportParm79 = "";
            //string reportParm80 = "";

            //string reportParm81 = "";
            //string reportParm82 = "";
            //string reportParm83 = "";
            //string reportParm84 = "";
            //string reportParm85 = "";
            //string reportParm86 = "";
            //string reportParm87 = "";
            //string reportParm88 = "";
            //string reportParm89 = "";
            //string reportParm90 = "";

            //string reportParm91 = "";
            //string reportParm92 = "";
            //string reportParm93 = "";
            //string reportParm94 = "";
            //string reportParm95 = "";
            //string reportParm96 = "";
            //string reportParm97 = "";
            //string reportParm98 = "";
            //string reportParm99 = "";
            //string reportParm100 = "";

            //string reportParm101 = "";
            //string reportParm102 = "";
            //string reportParm103 = "";
            //string reportParm104 = "";
            //string reportParm105 = "";
            //string reportParm106 = "";
            //string reportParm107 = "";
            //string reportParm108 = "";
            //string reportParm109 = "";
            //string reportParm110 = "";

            //string reportParm111 = "";
            //string reportParm112 = "";
            //string reportParm113 = "";
            //string reportParm114 = "";
            //string reportParm115 = "";
            //string reportParm116 = "";
            //string reportParm117 = "";
            //string reportParm118 = "";
            //string reportParm119 = "";
            //string reportParm120 = "";

            //string reportParm121 = "";
            //string reportParm122 = "";
            //string reportParm123 = "";
            //string reportParm124 = "";
            //string reportParm125 = "";
            //string reportParm126 = "";
            //string reportParm127 = "";
            //string reportParm128 = "";
            //string reportParm129 = "";
            //string reportParm130 = "";

            //string reportParm131 = "";
            //string reportParm132 = "";
            //string reportParm133 = "";
            //string reportParm134 = "";
            //string reportParm135 = "";
            //string reportParm136 = "";
            //string reportParm137 = "";
            //string reportParm138 = "";
            //string reportParm139 = "";
            //string reportParm140 = "";

            //string reportParm141 = "";
            //string reportParm142 = "";
            //string reportParm143 = "";
            //string reportParm144 = "";
            //string reportParm145 = "";
            //string reportParm146 = "";
            //string reportParm147 = "";
            //string reportParm148 = "";
            //string reportParm149 = "";
            //string reportParm150 = "";

            //string reportParm151 = "";
            //string reportParm152 = "";
            //string reportParm153 = "";
            //string reportParm154 = "";
            //string reportParm155 = "";
            //string reportParm156 = "";
            //string reportParm157 = "";
            //string reportParm158 = "";
            //string reportParm159 = "";
            //string reportParm160 = "";

            //string reportParm161 = "";
            //string reportParm162 = "";
            //string reportParm163 = "";
            //string reportParm164 = "";
            //string reportParm165 = "";
            //string reportParm166 = "";

            //string sCust = string.Empty;            // dataGridView1.Rows[Irowindex].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[Irowindex].Cells[2].Value.ToString().Trim();
            //string sNo = string.Empty;              // dataGridView1.Rows[Irowindex].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[Irowindex].Cells[0].Value.ToString().Trim();
            //string sDt = string.Empty;              //dataGridView1.Rows[Irowindex].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[Irowindex].Cells[1].Value.ToString().Substring(0, 10);
            //string sPname = string.Empty;           //dataGridView1.Rows[Irowindex].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[Irowindex].Cells[6].Value.ToString().Trim();
            //string sSpec = string.Empty;            //dataGridView1.Rows[Irowindex].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[Irowindex].Cells[36].Value.ToString().Trim();
            //string sUnit = string.Empty;            //dataGridView1.Rows[Irowindex].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[Irowindex].Cells[27].Value.ToString().Trim();
            //string sQty = string.Empty;             //dataGridView1.Rows[Irowindex].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[Irowindex].Cells[14].Value.ToString().Trim();
            //string sDanga = string.Empty;           //= dataGridView1.Rows[Irowindex].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[Irowindex].Cells[7].Value.ToString().Trim();
            //string sAmt = string.Empty;             //dataGridView1.Rows[Irowindex].Cells[20].Value.ToString() == "" ? "0" : dataGridView1.Rows[Irowindex].Cells[20].Value.ToString().Trim();

            //sCust = dataGridView1.Rows[0].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[0].Cells[2].Value.ToString().Trim();
            //sNo = dataGridView1.Rows[0].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[0].Cells[0].Value.ToString().Trim();
            //sDt = dataGridView1.Rows[0].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[0].Cells[1].Value.ToString().Trim();

            //reportParm1 = reportParm1 + sCust;
            //reportParm2 = reportParm2 + "귀중";
            //reportParm3 = reportParm3 + "아래와 같이 가공을 요청합니다.";
            //reportParm4 = reportParm4 + "발주 NO.";
            //reportParm5 = reportParm5 + sNo;
            //reportParm6 = reportParm6 + "발행일자";
            //reportParm7 = reportParm7 + sDt;
            //reportParm8 = reportParm8 + "No";
            //reportParm9 = reportParm9 + "품  명";
            //reportParm10 = reportParm10 + "규  격";

            //reportParm11 = reportParm11 + "단위";
            //reportParm12 = reportParm12 + "수 량";
            //reportParm13 = reportParm13 + "단 가";
            //reportParm14 = reportParm14 + "금 액";
            //reportParm15 = reportParm15 + "비고";
            //reportParm16 = reportParm16 + "1";

            ////// ============================ 1
            //reportParm17 = reportParm17 + " ";
            //reportParm18 = reportParm18 + " ";
            //reportParm19 = reportParm19 + " ";
            //reportParm20 = reportParm20 + " ";

            //reportParm21 = reportParm21 + " ";
            //reportParm22 = reportParm22 + " ";
            //reportParm23 = reportParm23 + " ";

            //if (dataGridView1.Rows.Count - 1 > 0)   // 1행
            //{
            //    sCust = dataGridView1.Rows[0].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[0].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[0].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[0].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[0].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[0].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[0].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[0].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[0].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[0].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[0].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[0].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[0].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[0].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[0].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[0].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[0].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[0].Cells[17].Value.ToString().Trim();  // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm17 = reportParm17 + sPname;           // 품명
            //    reportParm18 = reportParm18 + sSpec;            // 규격
            //    reportParm19 = reportParm19 + sUnit;            // 단위
            //    reportParm20 = reportParm20 + sQty;             // 수량

            //    reportParm21 = reportParm21 + sDanga;           // 단가
            //    reportParm22 = reportParm22 + sAmt;             // 금액(합계금액)
            //    reportParm23 = reportParm23 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm24 = reportParm24 + "2";
            //reportParm25 = reportParm25 + " ";
            //reportParm26 = reportParm26 + " ";
            //reportParm27 = reportParm27 + " ";
            //reportParm28 = reportParm28 + " ";
            //reportParm29 = reportParm29 + " ";
            //reportParm30 = reportParm30 + " ";

            //reportParm31 = reportParm31 + " ";

            //if (dataGridView1.Rows.Count - 1 > 1)   // 2행
            //{
            //    sCust = dataGridView1.Rows[1].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[1].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[1].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[1].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[1].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[1].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[1].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[1].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[1].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[1].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[1].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[1].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[1].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[1].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[1].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[1].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[1].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[1].Cells[17].Value.ToString().Trim();  // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm25 = reportParm25 + sPname;           // 품명
            //    reportParm26 = reportParm26 + sSpec;            // 규격
            //    reportParm27 = reportParm27 + sUnit;            // 단위
            //    reportParm28 = reportParm28 + sQty;             // 수량

            //    reportParm29 = reportParm29 + sDanga;           // 단가
            //    reportParm30 = reportParm30 + sAmt;             // 금액(합계금액)
            //    reportParm31 = reportParm31 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm32 = reportParm32 + "3";
            //reportParm33 = reportParm33 + "4";
            //reportParm34 = reportParm34 + "5";
            //reportParm35 = reportParm35 + "6";
            //reportParm36 = reportParm36 + "7";
            //reportParm37 = reportParm37 + "8";
            //reportParm38 = reportParm38 + "9";
            //reportParm39 = reportParm39 + "10";
            //reportParm40 = reportParm40 + "11";

            //reportParm41 = reportParm41 + "12";
            //reportParm42 = reportParm42 + "13";
            //reportParm43 = reportParm43 + "14";
            //reportParm44 = reportParm44 + "15";
            //reportParm45 = reportParm45 + "계";
            //reportParm46 = reportParm46 + " "; // 총합계는 아래에서
            //reportParm47 = reportParm47 + "1.도면 & SAMPLE 기준 작업 요망합니다. ";
            //reportParm48 = reportParm48 + " ";
            //reportParm49 = reportParm49 + "  ";
            //reportParm50 = reportParm50 + "납기";

            //reportParm51 = reportParm51 + " ";
            //reportParm52 = reportParm52 + "인도장소";
            //reportParm53 = reportParm53 + "--------------";
            //reportParm54 = reportParm54 + "지불조건";
            //reportParm55 = reportParm55 + "정기지불 ";
            //reportParm56 = reportParm56 + "검사벙법 ";
            //reportParm57 = reportParm57 + "육안 및 치수검사";
            //reportParm58 = reportParm58 + " ";
            //reportParm59 = reportParm59 + " ";
            //reportParm60 = reportParm60 + "(주)한성테크 ";

            //reportParm61 = reportParm61 + "대표이사 XXXXXX ";
            //reportParm62 = reportParm62 + "담\r당\r자";
            //reportParm63 = reportParm63 + "전화";
            //reportParm64 = reportParm64 + "(031)xxx-xxxxx";
            //reportParm65 = reportParm65 + "FAX";
            //reportParm66 = reportParm66 + "(031)xxx-xxxxx";
            //reportParm67 = reportParm67 + " ";
            //reportParm68 = reportParm68 + " ";
            //reportParm69 = reportParm69 + "DLF-7004-03 ";
            //reportParm70 = reportParm70 + "(주)한성테크";

            //reportParm71 = reportParm71 + "A4(210X297)";

            //reportParm72 = reportParm72 + " ";
            //reportParm73 = reportParm73 + " ";
            //reportParm74 = reportParm74 + " ";
            //reportParm75 = reportParm75 + " ";
            //reportParm76 = reportParm76 + " ";
            //reportParm77 = reportParm77 + " ";
            //reportParm78 = reportParm78 + " ";

            //if (dataGridView1.Rows.Count - 1 > 2)   // 3행
            //{
            //    sCust = dataGridView1.Rows[2].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[2].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[2].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[2].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[2].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[2].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[2].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[2].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[2].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[2].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[2].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[2].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[2].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[2].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[2].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[2].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[2].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[2].Cells[17].Value.ToString().Trim();  // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm72 = reportParm72 + sPname;           // 품명
            //    reportParm73 = reportParm73 + sSpec;            // 규격
            //    reportParm74 = reportParm74 + sUnit;            // 단위
            //    reportParm75 = reportParm75 + sQty;             // 수량

            //    reportParm76 = reportParm76 + sDanga;           // 단가
            //    reportParm77 = reportParm77 + sAmt;             // 금액(합계금액)
            //    reportParm78 = reportParm78 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm79 = reportParm79 + " ";
            //reportParm80 = reportParm80 + " ";

            //reportParm81 = reportParm81 + " ";
            //reportParm82 = reportParm82 + " ";
            //reportParm83 = reportParm83 + " ";
            //reportParm84 = reportParm84 + " ";
            //reportParm85 = reportParm85 + " ";

            //if (dataGridView1.Rows.Count - 1 > 3)   // 4행
            //{
            //    sCust = dataGridView1.Rows[3].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[3].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[3].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[3].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[3].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[3].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[3].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[3].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[3].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[3].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[3].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[3].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[3].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[3].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[3].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[3].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[3].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[3].Cells[17].Value.ToString().Trim();  // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm79 = reportParm79 + sPname;           // 품명
            //    reportParm80 = reportParm80 + sSpec;            // 규격
            //    reportParm81 = reportParm81 + sUnit;            // 단위
            //    reportParm82 = reportParm82 + sQty;             // 수량

            //    reportParm83 = reportParm83 + sDanga;           // 단가
            //    reportParm84 = reportParm84 + sAmt;             // 금액(합계금액)
            //    reportParm85 = reportParm85 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm86 = reportParm86 + " ";
            //reportParm87 = reportParm87 + " ";
            //reportParm88 = reportParm88 + " ";
            //reportParm89 = reportParm89 + " ";
            //reportParm90 = reportParm90 + " ";

            //reportParm91 = reportParm91 + " ";
            //reportParm92 = reportParm92 + " ";

            //if (dataGridView1.Rows.Count - 1 > 4)   // 5행
            //{
            //    sCust = dataGridView1.Rows[4].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[4].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[4].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[4].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[4].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[4].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[4].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[4].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[4].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[4].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[4].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[4].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[4].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[4].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[4].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[4].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[4].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[4].Cells[17].Value.ToString().Trim();   // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm86 = reportParm86 + sPname;           // 품명
            //    reportParm87 = reportParm87 + sSpec;            // 규격
            //    reportParm88 = reportParm88 + sUnit;            // 단위
            //    reportParm89 = reportParm89 + sQty;             // 수량

            //    reportParm90 = reportParm90 + sDanga;           // 단가
            //    reportParm91 = reportParm91 + sAmt;             // 금액(합계금액)
            //    reportParm92 = reportParm92 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm93 = reportParm93 + " ";
            //reportParm94 = reportParm94 + " ";
            //reportParm95 = reportParm95 + " ";
            //reportParm96 = reportParm96 + " ";
            //reportParm97 = reportParm97 + " ";
            //reportParm98 = reportParm98 + " ";
            //reportParm99 = reportParm99 + " ";

            //if (dataGridView1.Rows.Count - 1 > 5)   // 6행
            //{
            //    sCust = dataGridView1.Rows[5].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[5].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[5].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[5].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[5].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[5].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[5].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[5].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[5].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[5].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[5].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[5].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[5].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[5].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[5].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[5].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[5].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[5].Cells[17].Value.ToString().Trim();   // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm93 = reportParm93 + sPname;           // 품명
            //    reportParm94 = reportParm94 + sSpec;            // 규격
            //    reportParm95 = reportParm95 + sUnit;            // 단위
            //    reportParm96 = reportParm96 + sQty;             // 수량

            //    reportParm97 = reportParm97 + sDanga;           // 단가
            //    reportParm98 = reportParm98 + sAmt;             // 금액(합계금액)
            //    reportParm99 = reportParm99 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}


            //reportParm100 = reportParm100 + " ";

            //reportParm101 = reportParm101 + " ";
            //reportParm102 = reportParm102 + " ";
            //reportParm103 = reportParm103 + " ";
            //reportParm104 = reportParm104 + " ";
            //reportParm105 = reportParm105 + " ";
            //reportParm106 = reportParm106 + " ";

            //if (dataGridView1.Rows.Count - 1 > 6)   // 7행
            //{
            //    sCust = dataGridView1.Rows[6].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[6].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[6].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[6].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[6].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[6].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[6].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[6].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[6].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[6].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[6].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[6].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[6].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[6].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[6].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[6].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[6].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[6].Cells[17].Value.ToString().Trim();   // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm100 = reportParm100 + sPname;           // 품명
            //    reportParm101 = reportParm101 + sSpec;            // 규격
            //    reportParm102 = reportParm102 + sUnit;            // 단위
            //    reportParm103 = reportParm103 + sQty;             // 수량

            //    reportParm104 = reportParm104 + sDanga;           // 단가
            //    reportParm105 = reportParm105 + sAmt;             // 금액(합계금액)
            //    reportParm106 = reportParm106 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm107 = reportParm107 + " ";
            //reportParm108 = reportParm108 + " ";
            //reportParm109 = reportParm109 + " ";
            //reportParm110 = reportParm110 + " ";

            //reportParm111 = reportParm111 + " ";
            //reportParm112 = reportParm112 + " ";
            //reportParm113 = reportParm113 + " ";

            //if (dataGridView1.Rows.Count - 1 > 7)   // 8행
            //{
            //    sCust = dataGridView1.Rows[7].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[7].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[7].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[7].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[7].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[7].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[7].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[7].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[7].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[7].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[7].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[7].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[7].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[7].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[7].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[7].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[7].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[7].Cells[17].Value.ToString().Trim();  // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm107 = reportParm107 + sPname;           // 품명
            //    reportParm108 = reportParm108 + sSpec;            // 규격
            //    reportParm109 = reportParm109 + sUnit;            // 단위
            //    reportParm110 = reportParm110 + sQty;             // 수량

            //    reportParm111 = reportParm111 + sDanga;           // 단가
            //    reportParm112 = reportParm112 + sAmt;             // 금액(합계금액)
            //    reportParm113 = reportParm113 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm114 = reportParm114 + " ";
            //reportParm115 = reportParm115 + " ";
            //reportParm116 = reportParm116 + " ";
            //reportParm117 = reportParm117 + " ";
            //reportParm118 = reportParm118 + " ";
            //reportParm119 = reportParm119 + " ";
            //reportParm120 = reportParm120 + " ";

            //if (dataGridView1.Rows.Count - 1 > 8)   // 9행
            //{
            //    sCust = dataGridView1.Rows[8].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[8].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[8].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[8].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[8].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[8].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[8].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[8].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[8].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[8].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[8].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[8].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[8].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[8].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[8].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[8].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[8].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[8].Cells[17].Value.ToString().Trim();  // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm114 = reportParm114 + sPname;           // 품명
            //    reportParm115 = reportParm115 + sSpec;            // 규격
            //    reportParm116 = reportParm116 + sUnit;            // 단위
            //    reportParm117 = reportParm117 + sQty;             // 수량

            //    reportParm118 = reportParm118 + sDanga;           // 단가
            //    reportParm119 = reportParm119 + sAmt;             // 금액(합계금액)
            //    reportParm120 = reportParm120 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm121 = reportParm121 + " ";
            //reportParm122 = reportParm122 + " ";
            //reportParm123 = reportParm123 + " ";
            //reportParm124 = reportParm124 + " ";
            //reportParm125 = reportParm125 + " ";
            //reportParm126 = reportParm126 + " ";
            //reportParm127 = reportParm127 + " ";

            //if (dataGridView1.Rows.Count - 1 > 9)   // 10행
            //{
            //    sCust = dataGridView1.Rows[9].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[9].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[9].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[9].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[9].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[9].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[9].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[9].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[9].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[9].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[9].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[9].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[9].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[9].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[9].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[9].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[9].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[9].Cells[17].Value.ToString().Trim();  // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm121 = reportParm121 + sPname;           // 품명
            //    reportParm122 = reportParm122 + sSpec;            // 규격
            //    reportParm123 = reportParm123 + sUnit;            // 단위
            //    reportParm124 = reportParm124 + sQty;             // 수량

            //    reportParm125 = reportParm125 + sDanga;           // 단가
            //    reportParm126 = reportParm126 + sAmt;             // 금액(합계금액)
            //    reportParm127 = reportParm127 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm128 = reportParm128 + " ";
            //reportParm129 = reportParm129 + " ";
            //reportParm130 = reportParm130 + " ";

            //reportParm131 = reportParm131 + " ";
            //reportParm132 = reportParm132 + " ";
            //reportParm133 = reportParm133 + " ";
            //reportParm134 = reportParm134 + " ";

            //if (dataGridView1.Rows.Count - 1 > 10)   // 11행
            //{
            //    sCust = dataGridView1.Rows[10].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[10].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[10].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[10].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[10].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[10].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[10].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[10].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[10].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[10].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[10].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[10].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[10].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[10].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[10].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[10].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[10].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[10].Cells[17].Value.ToString().Trim();  // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm128 = reportParm128 + sPname;           // 품명
            //    reportParm129 = reportParm129 + sSpec;            // 규격
            //    reportParm130 = reportParm130 + sUnit;            // 단위
            //    reportParm131 = reportParm131 + sQty;             // 수량

            //    reportParm132 = reportParm132 + sDanga;           // 단가
            //    reportParm133 = reportParm133 + sAmt;             // 금액(합계금액)
            //    reportParm134 = reportParm134 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm135 = reportParm135 + " ";
            //reportParm136 = reportParm136 + " ";
            //reportParm137 = reportParm137 + " ";
            //reportParm138 = reportParm138 + " ";
            //reportParm139 = reportParm139 + " ";
            //reportParm140 = reportParm140 + " ";

            //reportParm141 = reportParm141 + " ";

            //if (dataGridView1.Rows.Count - 1 > 11)   // 12행
            //{
            //    sCust = dataGridView1.Rows[11].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[11].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[11].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[11].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[11].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[11].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[11].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[11].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[11].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[11].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[11].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[11].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[11].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[11].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[11].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[11].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[11].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[11].Cells[17].Value.ToString().Trim();   // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm135 = reportParm135 + sPname;           // 품명
            //    reportParm136 = reportParm136 + sSpec;            // 규격
            //    reportParm137 = reportParm137 + sUnit;            // 단위
            //    reportParm138 = reportParm138 + sQty;             // 수량

            //    reportParm139 = reportParm139 + sDanga;           // 단가
            //    reportParm140 = reportParm140 + sAmt;             // 금액(합계금액)
            //    reportParm141 = reportParm141 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm142 = reportParm142 + " ";
            //reportParm143 = reportParm143 + " ";
            //reportParm144 = reportParm144 + " ";
            //reportParm145 = reportParm145 + " ";
            //reportParm146 = reportParm146 + " ";
            //reportParm147 = reportParm147 + " ";
            //reportParm148 = reportParm148 + " ";

            //if (dataGridView1.Rows.Count - 1 > 12)   // 13행
            //{
            //    sCust = dataGridView1.Rows[12].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[12].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[12].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[12].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[12].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[12].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[12].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[12].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[12].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[12].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[12].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[12].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[12].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[12].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[12].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[12].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[12].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[12].Cells[17].Value.ToString().Trim();   // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm142 = reportParm142 + sPname;           // 품명
            //    reportParm143 = reportParm143 + sSpec;            // 규격
            //    reportParm144 = reportParm144 + sUnit;            // 단위
            //    reportParm145 = reportParm145 + sQty;             // 수량

            //    reportParm146 = reportParm146 + sDanga;           // 단가
            //    reportParm147 = reportParm147 + sAmt;             // 금액(합계금액)
            //    reportParm148 = reportParm148 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm149 = reportParm149 + " ";
            //reportParm150 = reportParm150 + " ";

            //reportParm151 = reportParm151 + " ";
            //reportParm152 = reportParm152 + " ";
            //reportParm153 = reportParm153 + " ";
            //reportParm154 = reportParm154 + " ";
            //reportParm155 = reportParm155 + " ";

            //if (dataGridView1.Rows.Count - 1 > 13)   // 14행
            //{
            //    sCust = dataGridView1.Rows[13].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[13].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[13].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[13].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[13].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[13].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[13].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[13].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[13].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[13].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[13].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[13].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[13].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[13].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[13].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[13].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[13].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[13].Cells[17].Value.ToString().Trim();   // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm149 = reportParm149 + sPname;           // 품명
            //    reportParm150 = reportParm150 + sSpec;            // 규격
            //    reportParm151 = reportParm151 + sUnit;            // 단위
            //    reportParm152 = reportParm152 + sQty;             // 수량

            //    reportParm153 = reportParm153 + sDanga;           // 단가
            //    reportParm154 = reportParm154 + sAmt;             // 금액(합계금액)
            //    reportParm155 = reportParm155 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //reportParm156 = reportParm156 + " ";
            //reportParm157 = reportParm157 + " ";
            //reportParm158 = reportParm158 + " ";
            //reportParm159 = reportParm159 + " ";
            //reportParm160 = reportParm160 + " ";

            //reportParm161 = reportParm161 + " ";
            //reportParm162 = reportParm162 + " ";

            //if (dataGridView1.Rows.Count - 1 > 14)   // 15행
            //{
            //    sCust = dataGridView1.Rows[14].Cells[2].Value.ToString() == "" ? " " : dataGridView1.Rows[14].Cells[2].Value.ToString().Trim();
            //    sNo = dataGridView1.Rows[14].Cells[0].Value.ToString() == "" ? " " : dataGridView1.Rows[14].Cells[0].Value.ToString().Trim();
            //    sDt = dataGridView1.Rows[14].Cells[1].Value.ToString() == "" ? " " : dataGridView1.Rows[14].Cells[1].Value.ToString().Substring(0, 10);
            //    sPname = dataGridView1.Rows[14].Cells[6].Value.ToString() == "" ? " " : dataGridView1.Rows[14].Cells[6].Value.ToString().Trim();
            //    sSpec = dataGridView1.Rows[14].Cells[36].Value.ToString() == "" ? " " : dataGridView1.Rows[14].Cells[36].Value.ToString().Trim();
            //    sUnit = dataGridView1.Rows[14].Cells[27].Value.ToString() == "" ? " " : dataGridView1.Rows[14].Cells[27].Value.ToString().Trim();
            //    sQty = dataGridView1.Rows[14].Cells[14].Value.ToString() == "" ? "0" : dataGridView1.Rows[14].Cells[14].Value.ToString().Trim();
            //    sDanga = dataGridView1.Rows[14].Cells[7].Value.ToString() == "" ? "0" : dataGridView1.Rows[14].Cells[7].Value.ToString().Trim();
            //    sAmt = dataGridView1.Rows[14].Cells[17].Value.ToString() == "" ? "0" : dataGridView1.Rows[14].Cells[17].Value.ToString().Trim();   // 부가세 제외 (19-부가세포함)

            //    sQty = string.Format("{0:#,##0}", int.Parse(sQty));
            //    sDanga = string.Format("{0:#,##0}", int.Parse(sDanga));
            //    sAmt = string.Format("{0:#,##0}", int.Parse(sAmt));

            //    reportParm156 = reportParm156 + sPname;           // 품명
            //    reportParm157 = reportParm157 + sSpec;            // 규격
            //    reportParm158 = reportParm158 + sUnit;            // 단위
            //    reportParm159 = reportParm159 + sQty;             // 수량

            //    reportParm160 = reportParm160 + sDanga;           // 단가
            //    reportParm161 = reportParm161 + sAmt;             // 금액(합계금액)
            //    reportParm162 = reportParm162 + " ";              // 비고

            //    DQty += double.Parse(sQty);
            //    DDanga += double.Parse(sDanga);
            //    DAmt += double.Parse(sAmt);
            //}

            //sQty = string.Format("{0:#,##0}", DQty);
            //sDanga = string.Format("{0:#,##0}", DDanga);
            //sAmt = string.Format("{0:#,##0}", DAmt);

            //reportParm46 = reportParm46 + sAmt;             // 금액(합계금액)

            //reportParm163 = reportParm163 + "1.도면 & SAMPLE 기준 작업 요망합니다. ";
            //reportParm164 = reportParm164 + "2.상기 수량은 양품 기준 수량입니다.";
            //reportParm165 = reportParm165 + "3.사상 철저히 하여 납품하여 주십시요.";
            //reportParm166 = reportParm166 + "4.납기 필히 준히 요망합니다.";

            //ViewReport_V viewReport = new ViewReport_V();
            //viewReport.reportViewer1.ProcessingMode = ProcessingMode.Local;
            //viewReport.reportViewer1.LocalReport.ReportEmbeddedResource = reportFileName;

            //ReportParameter rp1 = new ReportParameter("ReportParameter1", reportParm1);
            //ReportParameter rp2 = new ReportParameter("ReportParameter2", reportParm2);
            //ReportParameter rp3 = new ReportParameter("ReportParameter3", reportParm3);
            //ReportParameter rp4 = new ReportParameter("ReportParameter4", reportParm4);
            //ReportParameter rp5 = new ReportParameter("ReportParameter5", reportParm5);
            //ReportParameter rp6 = new ReportParameter("ReportParameter6", reportParm6);
            //ReportParameter rp7 = new ReportParameter("ReportParameter7", reportParm7);
            //ReportParameter rp8 = new ReportParameter("ReportParameter8", reportParm8);
            //ReportParameter rp9 = new ReportParameter("ReportParameter9", reportParm9);
            //ReportParameter rp10 = new ReportParameter("ReportParameter10", reportParm10);

            //ReportParameter rp11 = new ReportParameter("ReportParameter11", reportParm11);
            //ReportParameter rp12 = new ReportParameter("ReportParameter12", reportParm12);
            //ReportParameter rp13 = new ReportParameter("ReportParameter13", reportParm13);
            //ReportParameter rp14 = new ReportParameter("ReportParameter14", reportParm14);
            //ReportParameter rp15 = new ReportParameter("ReportParameter15", reportParm15);
            //ReportParameter rp16 = new ReportParameter("ReportParameter16", reportParm16);
            //ReportParameter rp17 = new ReportParameter("ReportParameter17", reportParm17);
            //ReportParameter rp18 = new ReportParameter("ReportParameter18", reportParm18);
            //ReportParameter rp19 = new ReportParameter("ReportParameter19", reportParm19);
            //ReportParameter rp20 = new ReportParameter("ReportParameter20", reportParm20);

            //ReportParameter rp21 = new ReportParameter("ReportParameter21", reportParm21);
            //ReportParameter rp22 = new ReportParameter("ReportParameter22", reportParm22);
            //ReportParameter rp23 = new ReportParameter("ReportParameter23", reportParm23);
            //ReportParameter rp24 = new ReportParameter("ReportParameter24", reportParm24);
            //ReportParameter rp25 = new ReportParameter("ReportParameter25", reportParm25);
            //ReportParameter rp26 = new ReportParameter("ReportParameter26", reportParm26);
            //ReportParameter rp27 = new ReportParameter("ReportParameter27", reportParm27);
            //ReportParameter rp28 = new ReportParameter("ReportParameter28", reportParm28);
            //ReportParameter rp29 = new ReportParameter("ReportParameter29", reportParm29);
            //ReportParameter rp30 = new ReportParameter("ReportParameter30", reportParm30);

            //ReportParameter rp31 = new ReportParameter("ReportParameter31", reportParm31);
            //ReportParameter rp32 = new ReportParameter("ReportParameter32", reportParm32);
            //ReportParameter rp33 = new ReportParameter("ReportParameter33", reportParm33);
            //ReportParameter rp34 = new ReportParameter("ReportParameter34", reportParm34);
            //ReportParameter rp35 = new ReportParameter("ReportParameter35", reportParm35);
            //ReportParameter rp36 = new ReportParameter("ReportParameter36", reportParm36);
            //ReportParameter rp37 = new ReportParameter("ReportParameter37", reportParm37);
            //ReportParameter rp38 = new ReportParameter("ReportParameter38", reportParm38);
            //ReportParameter rp39 = new ReportParameter("ReportParameter39", reportParm39);
            //ReportParameter rp40 = new ReportParameter("ReportParameter40", reportParm40);

            //ReportParameter rp41 = new ReportParameter("ReportParameter41", reportParm41);
            //ReportParameter rp42 = new ReportParameter("ReportParameter42", reportParm42);
            //ReportParameter rp43 = new ReportParameter("ReportParameter43", reportParm43);
            //ReportParameter rp44 = new ReportParameter("ReportParameter44", reportParm44);
            //ReportParameter rp45 = new ReportParameter("ReportParameter45", reportParm45);
            //ReportParameter rp46 = new ReportParameter("ReportParameter46", reportParm46);
            //ReportParameter rp47 = new ReportParameter("ReportParameter47", reportParm47);
            //ReportParameter rp48 = new ReportParameter("ReportParameter48", reportParm48);
            //ReportParameter rp49 = new ReportParameter("ReportParameter49", reportParm49);
            //ReportParameter rp50 = new ReportParameter("ReportParameter50", reportParm50);

            //ReportParameter rp51 = new ReportParameter("ReportParameter51", reportParm51);
            //ReportParameter rp52 = new ReportParameter("ReportParameter52", reportParm52);
            //ReportParameter rp53 = new ReportParameter("ReportParameter53", reportParm53);
            //ReportParameter rp54 = new ReportParameter("ReportParameter54", reportParm54);
            //ReportParameter rp55 = new ReportParameter("ReportParameter55", reportParm55);
            //ReportParameter rp56 = new ReportParameter("ReportParameter56", reportParm56);
            //ReportParameter rp57 = new ReportParameter("ReportParameter57", reportParm57);
            //ReportParameter rp58 = new ReportParameter("ReportParameter58", reportParm58);
            //ReportParameter rp59 = new ReportParameter("ReportParameter59", reportParm59);
            //ReportParameter rp60 = new ReportParameter("ReportParameter60", reportParm60);

            //ReportParameter rp61 = new ReportParameter("ReportParameter61", reportParm61);
            //ReportParameter rp62 = new ReportParameter("ReportParameter62", reportParm62);
            //ReportParameter rp63 = new ReportParameter("ReportParameter63", reportParm63);
            //ReportParameter rp64 = new ReportParameter("ReportParameter64", reportParm64);
            //ReportParameter rp65 = new ReportParameter("ReportParameter65", reportParm65);
            //ReportParameter rp66 = new ReportParameter("ReportParameter66", reportParm66);
            //ReportParameter rp67 = new ReportParameter("ReportParameter67", reportParm67);
            //ReportParameter rp68 = new ReportParameter("ReportParameter68", reportParm68);
            //ReportParameter rp69 = new ReportParameter("ReportParameter69", reportParm69);
            //ReportParameter rp70 = new ReportParameter("ReportParameter70", reportParm70);

            //ReportParameter rp71 = new ReportParameter("ReportParameter71", reportParm71);
            //ReportParameter rp72 = new ReportParameter("ReportParameter72", reportParm72);
            //ReportParameter rp73 = new ReportParameter("ReportParameter73", reportParm73);
            //ReportParameter rp74 = new ReportParameter("ReportParameter74", reportParm74);
            //ReportParameter rp75 = new ReportParameter("ReportParameter75", reportParm75);
            //ReportParameter rp76 = new ReportParameter("ReportParameter76", reportParm76);
            //ReportParameter rp77 = new ReportParameter("ReportParameter77", reportParm77);
            //ReportParameter rp78 = new ReportParameter("ReportParameter78", reportParm78);
            //ReportParameter rp79 = new ReportParameter("ReportParameter79", reportParm79);
            //ReportParameter rp80 = new ReportParameter("ReportParameter80", reportParm80);

            //ReportParameter rp81 = new ReportParameter("ReportParameter81", reportParm81);
            //ReportParameter rp82 = new ReportParameter("ReportParameter82", reportParm82);
            //ReportParameter rp83 = new ReportParameter("ReportParameter83", reportParm83);
            //ReportParameter rp84 = new ReportParameter("ReportParameter84", reportParm84);
            //ReportParameter rp85 = new ReportParameter("ReportParameter85", reportParm85);
            //ReportParameter rp86 = new ReportParameter("ReportParameter86", reportParm86);
            //ReportParameter rp87 = new ReportParameter("ReportParameter87", reportParm87);
            //ReportParameter rp88 = new ReportParameter("ReportParameter88", reportParm88);
            //ReportParameter rp89 = new ReportParameter("ReportParameter89", reportParm89);
            //ReportParameter rp90 = new ReportParameter("ReportParameter90", reportParm90);

            //ReportParameter rp91 = new ReportParameter("ReportParameter91", reportParm91);
            //ReportParameter rp92 = new ReportParameter("ReportParameter92", reportParm92);
            //ReportParameter rp93 = new ReportParameter("ReportParameter93", reportParm93);
            //ReportParameter rp94 = new ReportParameter("ReportParameter94", reportParm94);
            //ReportParameter rp95 = new ReportParameter("ReportParameter95", reportParm95);
            //ReportParameter rp96 = new ReportParameter("ReportParameter96", reportParm96);
            //ReportParameter rp97 = new ReportParameter("ReportParameter97", reportParm97);
            //ReportParameter rp98 = new ReportParameter("ReportParameter98", reportParm98);
            //ReportParameter rp99 = new ReportParameter("ReportParameter99", reportParm99);
            //ReportParameter rp100 = new ReportParameter("ReportParameter100", reportParm100);

            //ReportParameter rp101 = new ReportParameter("ReportParameter101", reportParm101);
            //ReportParameter rp102 = new ReportParameter("ReportParameter102", reportParm102);
            //ReportParameter rp103 = new ReportParameter("ReportParameter103", reportParm103);
            //ReportParameter rp104 = new ReportParameter("ReportParameter104", reportParm104);
            //ReportParameter rp105 = new ReportParameter("ReportParameter105", reportParm105);
            //ReportParameter rp106 = new ReportParameter("ReportParameter106", reportParm106);
            //ReportParameter rp107 = new ReportParameter("ReportParameter107", reportParm107);
            //ReportParameter rp108 = new ReportParameter("ReportParameter108", reportParm108);
            //ReportParameter rp109 = new ReportParameter("ReportParameter109", reportParm109);
            //ReportParameter rp110 = new ReportParameter("ReportParameter110", reportParm110);

            //ReportParameter rp111 = new ReportParameter("ReportParameter111", reportParm111);
            //ReportParameter rp112 = new ReportParameter("ReportParameter112", reportParm112);
            //ReportParameter rp113 = new ReportParameter("ReportParameter113", reportParm113);
            //ReportParameter rp114 = new ReportParameter("ReportParameter114", reportParm114);
            //ReportParameter rp115 = new ReportParameter("ReportParameter115", reportParm115);
            //ReportParameter rp116 = new ReportParameter("ReportParameter116", reportParm116);
            //ReportParameter rp117 = new ReportParameter("ReportParameter117", reportParm117);
            //ReportParameter rp118 = new ReportParameter("ReportParameter118", reportParm118);
            //ReportParameter rp119 = new ReportParameter("ReportParameter119", reportParm119);
            //ReportParameter rp120 = new ReportParameter("ReportParameter120", reportParm120);

            //ReportParameter rp121 = new ReportParameter("ReportParameter121", reportParm121);
            //ReportParameter rp122 = new ReportParameter("ReportParameter122", reportParm122);
            //ReportParameter rp123 = new ReportParameter("ReportParameter123", reportParm123);
            //ReportParameter rp124 = new ReportParameter("ReportParameter124", reportParm124);
            //ReportParameter rp125 = new ReportParameter("ReportParameter125", reportParm125);
            //ReportParameter rp126 = new ReportParameter("ReportParameter126", reportParm126);
            //ReportParameter rp127 = new ReportParameter("ReportParameter127", reportParm127);
            //ReportParameter rp128 = new ReportParameter("ReportParameter128", reportParm128);
            //ReportParameter rp129 = new ReportParameter("ReportParameter129", reportParm129);
            //ReportParameter rp130 = new ReportParameter("ReportParameter130", reportParm130);

            //ReportParameter rp131 = new ReportParameter("ReportParameter131", reportParm131);
            //ReportParameter rp132 = new ReportParameter("ReportParameter132", reportParm132);
            //ReportParameter rp133 = new ReportParameter("ReportParameter133", reportParm133);
            //ReportParameter rp134 = new ReportParameter("ReportParameter134", reportParm134);
            //ReportParameter rp135 = new ReportParameter("ReportParameter135", reportParm135);
            //ReportParameter rp136 = new ReportParameter("ReportParameter136", reportParm136);
            //ReportParameter rp137 = new ReportParameter("ReportParameter137", reportParm137);
            //ReportParameter rp138 = new ReportParameter("ReportParameter138", reportParm138);
            //ReportParameter rp139 = new ReportParameter("ReportParameter139", reportParm139);
            //ReportParameter rp140 = new ReportParameter("ReportParameter140", reportParm140);

            //ReportParameter rp141 = new ReportParameter("ReportParameter141", reportParm141);
            //ReportParameter rp142 = new ReportParameter("ReportParameter142", reportParm142);
            //ReportParameter rp143 = new ReportParameter("ReportParameter143", reportParm143);
            //ReportParameter rp144 = new ReportParameter("ReportParameter144", reportParm144);
            //ReportParameter rp145 = new ReportParameter("ReportParameter145", reportParm145);
            //ReportParameter rp146 = new ReportParameter("ReportParameter146", reportParm146);
            //ReportParameter rp147 = new ReportParameter("ReportParameter147", reportParm147);
            //ReportParameter rp148 = new ReportParameter("ReportParameter148", reportParm148);
            //ReportParameter rp149 = new ReportParameter("ReportParameter149", reportParm149);
            //ReportParameter rp150 = new ReportParameter("ReportParameter150", reportParm150);

            //ReportParameter rp151 = new ReportParameter("ReportParameter151", reportParm151);
            //ReportParameter rp152 = new ReportParameter("ReportParameter152", reportParm152);
            //ReportParameter rp153 = new ReportParameter("ReportParameter153", reportParm153);
            //ReportParameter rp154 = new ReportParameter("ReportParameter154", reportParm154);
            //ReportParameter rp155 = new ReportParameter("ReportParameter155", reportParm155);
            //ReportParameter rp156 = new ReportParameter("ReportParameter156", reportParm156);
            //ReportParameter rp157 = new ReportParameter("ReportParameter157", reportParm157);
            //ReportParameter rp158 = new ReportParameter("ReportParameter158", reportParm158);
            //ReportParameter rp159 = new ReportParameter("ReportParameter159", reportParm159);
            //ReportParameter rp160 = new ReportParameter("ReportParameter160", reportParm160);

            //ReportParameter rp161 = new ReportParameter("ReportParameter161", reportParm161);
            //ReportParameter rp162 = new ReportParameter("ReportParameter162", reportParm162);
            //ReportParameter rp163 = new ReportParameter("ReportParameter163", reportParm163);
            //ReportParameter rp164 = new ReportParameter("ReportParameter164", reportParm164);
            //ReportParameter rp165 = new ReportParameter("ReportParameter165", reportParm165);
            //ReportParameter rp166 = new ReportParameter("ReportParameter166", reportParm166);

            //viewReport.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
            //        rp1, rp2, rp3, rp4, rp5, rp6, rp7, rp8, rp9, rp10,
            //        rp11, rp12, rp13, rp14, rp15, rp16, rp17, rp18, rp19, rp20,
            //        rp21, rp22, rp23, rp24, rp25, rp26, rp27, rp28, rp29, rp30,
            //        rp31, rp32, rp33, rp34, rp35, rp36, rp37, rp38, rp39, rp40,
            //        rp41, rp42, rp43, rp44, rp45, rp46, rp47, rp48, rp49, rp50,
            //        rp51, rp52, rp53, rp54, rp55, rp56, rp57, rp58, rp59, rp60,
            //        rp61, rp62, rp63, rp64, rp65, rp66, rp67, rp68, rp69, rp70,
            //        rp71, rp72, rp73, rp74, rp75, rp76, rp77, rp78, rp79, rp80,
            //        rp81, rp82, rp83, rp84, rp85, rp86, rp87, rp88, rp89, rp90,
            //        rp91, rp92, rp93, rp94, rp95, rp96, rp97, rp98, rp99, rp100,
            //        rp101, rp102, rp103, rp104, rp105, rp106, rp107, rp108, rp109, rp110,
            //        rp111, rp112, rp113, rp114, rp115, rp116, rp117, rp118, rp119, rp120,
            //        rp121, rp122, rp123, rp124, rp125, rp126, rp127, rp128, rp129, rp130,
            //        rp131, rp132, rp133, rp134, rp135, rp136, rp137, rp138, rp139, rp140,
            //        rp141, rp142, rp143, rp144, rp145, rp146, rp147, rp148, rp149, rp150,
            //        rp151, rp152, rp153, rp154, rp155, rp156, rp157, rp158, rp159, rp160,
            //        rp161, rp162, rp163, rp164, rp165, rp166
            //    });

            //ReportDataSource rds = new ReportDataSource("DataSet1", sPPurchaseMatQueryBindingSource);
            //viewReport.reportViewer1.LocalReport.DataSources.Add(rds);
            //viewReport.reportViewer1.LocalReport.Refresh();
            //viewReport.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            //viewReport.ShowDialog();
        }
        #endregion

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }
    }
}

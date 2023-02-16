using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1C01_PROD_ORDER_SUB2 : Form
    {
        MySqlConnection con;
        public P1C01_PROD_ORDER parentWin;
        public int rowIndex;
        private string rorderID;
        private string rorderSeq;
        public P1C01_PROD_ORDER_SUB2()
        {
            InitializeComponent();
        }
        private void P1C01_PROD_ORDER_SUB2_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                ListSearch();
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                //dataGridView1.Rows[rowIndex].Cells[0].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();    // JobNo
                //dataGridView1.Rows[rowIndex].Cells[3].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();    // 설비코드
                //dataGridView1.Rows[rowIndex].Cells[4].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();    // 설비명
                //dataGridView1.Rows[rowIndex].Cells[5].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();   // 품목코드
                //dataGridView1.Rows[rowIndex].Cells[6].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();   // 품목명
                //dataGridView1.Rows[rowIndex].Cells[7].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();   // 자재A
                //dataGridView1.Rows[rowIndex].Cells[8].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();   // 중량A
                //dataGridView1.Rows[rowIndex].Cells[9].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();   // 자재B
                //dataGridView1.Rows[rowIndex].Cells[10].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();   // 중량B
                //dataGridView1.Rows[rowIndex].Cells[11].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();   // 자재MB
                //dataGridView1.Rows[rowIndex].Cells[12].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();   // 중량MB
                //dataGridView1.Rows[rowIndex].Cells[13].Value = parentWin.dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();   // 배합시간

                this.ActiveControl = btnSave;
            }
        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DateTime dtDate = DateTime.Parse(parentWin.dtpDate.Value.ToString("yyyy-MM-dd"));

                sP_ProdOrder_ROrder1TableAdapter.Fill(dataSetP1C.SP_ProdOrder_ROrder1, dtDate);

                dataGridView1.CurrentCell = null;
                dataGridView1.ClearSelection();

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Columns[7].HeaderText = "자재"; dataGridView1.Columns[8].HeaderText = "중량";
                    dataGridView1.Columns[9].HeaderText = "자재"; dataGridView1.Columns[10].HeaderText = "중량";
                    dataGridView1.Columns[11].HeaderText = "자재"; dataGridView1.Columns[12].HeaderText = "중량";
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

        #region 품목명
        private void lblProd_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            ProdFinder pop = new ProdFinder();
            pop.cbGubun.Text = "<전체>";
            pop._kind = "%";
            pop._stockFlag = "%";
            pop.FormSendEvent += new ProdFinder.FormSendDataHandler(ProdEventMethod);
            pop.ShowDialog();
        }
        private void ProdEventMethod(object sender)
        {
            string sProd = sender.ToString();
            if (string.IsNullOrEmpty(sProd)) return;

            string sRow = lblRow.Text.ToString().Trim();
            string sCol = lblCol.Text.ToString().Trim();

            if (string.IsNullOrEmpty(sRow)) return;
            if (string.IsNullOrEmpty(sCol)) return;
            if (sRow.Trim() == "-") return;
            if (sCol.Trim() == "-") return;

            int irow = Convert.ToInt32(sRow);
            int icol = Convert.ToInt32(sCol);

            dataGridView1.Rows[irow].Cells[icol].Value = sProd.Substring(0, sProd.IndexOf("#1/")) + "/" + sProd.Substring(sProd.IndexOf("#1/") + 3, sProd.IndexOf("#2/") - (sProd.IndexOf("#1/") + 3));
        }
        #endregion

        #region gridView Event
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = -1;

            lblRow.Text = "-"; lblCol.Text = "-";

            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;

            irow = e.RowIndex + 1; int icol = e.ColumnIndex;

            if (e.ColumnIndex > 6 && e.ColumnIndex < 13)   // (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 10) //업체, 수주명 선택
            {
                if (!(icol % 2 == 0 && icol != 0))
                {
                    dataGridView1.Columns[icol].ReadOnly = true;
                    lblRow.Text = e.RowIndex.ToString();
                    lblCol.Text = e.ColumnIndex.ToString();

                    ProdFinder sub = new ProdFinder();
                    sub.FormSendEvent += new ProdFinder.FormSendDataHandler(ProdEventMethod);
                    sub.cbGubun.SelectedIndex = 1;
                    sub._kind = "%";
                    sub._stockFlag = "1";
                    sub.ShowDialog();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.RowCount < 2) return;
            try
            {
                string sSujuNo = dataGridView1.Rows[0].Cells[0].Value.ToString();

                for (int i = 1; i < dataGridView1.RowCount; i++)
                {
                    if (sSujuNo == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[0].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[1].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[3].Style.ForeColor = Color.Transparent;
                        dataGridView1.Rows[i].Cells[2].Value = "";
                    }
                    sSujuNo = dataGridView1.Rows[i].Cells[0].Value.ToString();
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        #endregion

        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("이대로 작업지시를 저장하시겠습니까?", "품목과 중량, 배합시간을 확인하세요.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void Save()
        {
            lblMsg.Text = "";
            
            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sDate = parentWin.dtpDate.Value.ToString("yyyy-MM-dd");

            if(lblJob.Text == "" || string.IsNullOrEmpty(lblJob.Text))
            {
                lblJob.Text = getCode();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    string mNo = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string sProd = dataGridView1.Rows[i].Cells[5].Value.ToString();

                    string sMat1 = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    string sMat2 = dataGridView1.Rows[i].Cells[9].Value.ToString();
                    string sMat3 = dataGridView1.Rows[i].Cells[11].Value.ToString();
                    string sQty1 = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    string sQty2 = dataGridView1.Rows[i].Cells[10].Value.ToString();
                    string sQty3 = dataGridView1.Rows[i].Cells[12].Value.ToString();
                    string sTime = dataGridView1.Rows[i].Cells[15].Value.ToString();

                    sql = "insert into tb_prod_order (job_no, pos, lot_date, machine_id, prod_id, mat1, mat2, mat3, qty1, qty2, qty3, comb_time, enter_man) " +
                        "values('" + lblJob.Text + "','" + G.Pos + "','" + sDate + "'," + mNo + ",'" + sProd + "','" + sMat1 + "','" + sMat2 + "','" + sMat3 +"'," + sQty1 + 
                        "," + sQty2 + "," + sQty3 + ",'" + sTime + "','" + G.UserID + "')";

                    m.dbCUD(sql, ref msg);

                    if (msg != "OK")
                    {
                        lblMsg.Text = msg;
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    string mNo = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string sProd = dataGridView1.Rows[i].Cells[5].Value.ToString();

                    string sMat1 = dataGridView1.Rows[i].Cells[7].Value.ToString().Split('/')[0];
                    string sMat2 = dataGridView1.Rows[i].Cells[9].Value.ToString().Split('/')[0];
                    string sMat3 = dataGridView1.Rows[i].Cells[11].Value.ToString().Split('/')[0];
                    string sQty1 = dataGridView1.Rows[i].Cells[8].Value.ToString().Split('/')[0];
                    string sQty2 = dataGridView1.Rows[i].Cells[10].Value.ToString().Split('/')[0];
                    string sQty3 = dataGridView1.Rows[i].Cells[12].Value.ToString().Split('/')[0];
                    string sTime = dataGridView1.Rows[i].Cells[15].Value.ToString();

                    sql = "update tb_prod_order " +
                        "set lot_date = '" + sDate + "', prod_id = '" + sProd + "', mat1 = '" + sMat1 + "', mat2 = '" + sMat2 + ", mat3 = '" + sMat3
                        + "', qty1 = " + sQty1 + ", qty2 = " + sQty2 + ", qty3 = " + sQty3 + ", comb_time = '" + sTime + "' " +
                        "where job_no = '" + lblJob.Text + "' and machine_id = " + mNo;

                    m.dbCUD(sql, ref msg);

                    if (msg != "OK")
                    {
                        lblMsg.Text = msg;
                        return;
                    }
                }
            }
            lblMsg.Text = "저장되었습니다.";
            this.Dispose();
        }
        #endregion

        #region JobNo.(LotNo.) 생성
        private string getCode()
        {
            string sql = @"select UF_JobNoGenerator()";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        #endregion

        #region Cell Paint
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;
            string[] strHeaders = { "폴리에틸렌수지(A)", "폴리에틸렌수지(B)", "폴리에틸렌수지(M/B)" };
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // Category Painting 헤더 그리는 부분
            {
                //--------------------------------- 범위 지정
                Rectangle r1 = gv.GetCellDisplayRectangle(7, -1, false);  //범위 시작
                int width1 = gv.GetCellDisplayRectangle(8, -1, false).Width;

                r1.X += 1;
                r1.Y += 1;
                r1.Width = r1.Width + width1 - 2; // + width1 + width2 + width3 + width4 + width5 + width6
                r1.Height = (r1.Height / 2) - 2;

                //--------------------------------- 범위 지정 END

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r1);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r1);   // 셀 병합

                e.Graphics.DrawString(strHeaders[0],
                    gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor),
                    r1,
                    format);
            }
            {
                Rectangle r2 = gv.GetCellDisplayRectangle(9, -1, false);
                int width = gv.GetCellDisplayRectangle(10, -1, false).Width;

                r2.X += 1; r2.Y += 1;
                r2.Width = r2.Width + width - 2;
                r2.Height = (r2.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r2);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r2);
                e.Graphics.DrawString(strHeaders[1], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r2, format);
            }
            {
                Rectangle r3 = gv.GetCellDisplayRectangle(11, -1, false);
                int width = gv.GetCellDisplayRectangle(12, -1, false).Width;

                r3.X += 1; r3.Y += 1;
                r3.Width = r3.Width + width - 2;
                r3.Height = (r3.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r3);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r3);
                e.Graphics.DrawString(strHeaders[2], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r3, format);
            }
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r = e.CellBounds;
                r.Y += e.CellBounds.Height / 2;
                r.Height = e.CellBounds.Height / 2;
                e.PaintBackground(r, true);
                e.PaintContent(r);
                e.Handled = true;
            }
        }
        #endregion
    }
}
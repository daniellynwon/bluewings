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

                //dtpDate.Value = (DateTime)parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value;    // 생산계획일
                //tbJobNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();    // JobNo
                //tbSeq.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();      // 순번
                //tbProd.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();   // 품목코드
                //tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();   // 품목명
                //tbQty.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();      // 지시수량
                //dtpExpDate.Value = (DateTime)parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value;    // 유효기간

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
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void Save()
        {
            lblMsg.Text = "";

            //string sQty = tbQty.Text.Replace(",", "").Trim();

            //if (string.IsNullOrEmpty(sQty))
            //{
            //    lblMsg.Text = "지시수량을 입력해 주세요.";
            //    tbQty.Focus();
            //    return;
            //}

            //string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            //string sProd = tbProd.Tag.ToString();
            //string sSizeT = tbSizeT.Text.Trim();
            //string sSizeW = tbSizeW.Text.Trim();
            //string sSizeL = tbSizeL.Text.Trim();
            //string sProc = cbProc.SelectedValue.ToString();
            //string sJobNo = getCode();
            //string sSujuQty = sQty;
            //string sRework = "0";
            //if (cbRework.Checked) sRework = "1";
            //string sDoc = tbDoc.Text.Trim();
            //string sProdNo = tbProdNo.Text.Trim();
            //string sMatKind = cbMatKind.Text.Substring(0, 1);
            //string sConts = tbContents.Text.Trim();

            //string sProcStd = "0001";
            //if (cbProc.SelectedValue.ToString() == "0001") sProcStd = "0002";   // 절단만
            //else if (cbProc.SelectedValue.ToString() == "0002" && sMatKind == "2")
            //{
            //    sProcStd = "0003";   // 밀링만
            //    sProdNo = "20";
            //}
            //else sProcStd = "0001";

            //if (string.IsNullOrEmpty(rorderSeq))
            //{
            //    rorderSeq = "null";
            //}
            //else
            //{
            //    string sqlQty = "select qty from vw_rorder where rorder_id = '" + rorderID + "' and rorder_seq = " + rorderSeq;
            //    MariaCRUD mQty = new MariaCRUD();
            //    string msgQty = string.Empty;
            //    string com = mQty.dbRonlyOne(sqlQty, ref msgQty).ToString();

            //    if (msgQty == "OK") sSujuQty = com;
            //}

            //string sql = "insert into tb_prod_order (job_no, proc_no, pos, lot_date, prod_id, size_t, size_w, size_l, proc_kind, proc_std, doc_no, prod_no, mat_kind, rework, rorder_id, rorder_seq, rorder_date, order_qty, ment, enter_man) " +
            //    "select '" + sJobNo + "',p.proc_no,'" + G.Pos + "','" + sDate + "','" + sProd + "'," + sSizeT + "," + sSizeW + "," + sSizeL + ",'" + sProc + "','" + sProcStd + "','" + sDoc + "','" + sProdNo + "'," + sMatKind + "," + sRework + ",'" + rorderID + "'," + rorderSeq + ",'" + sDate + "'," 
            //    + sSujuQty + " - ifnull((select sum(v.gd_qty) from vw_production v where v.rorder_id = '" + rorderID + "' and v.rorder_seq = " + rorderSeq + " and v.proc_std = p.proc_no),0),'" + sConts + "','" + G.UserID + "' " + 
            //    "from tb_gi_process p where p.proc_std = '" + sProcStd + "' order by p.proc_no";

            //MariaCRUD m = new MariaCRUD();
            //string msg = string.Empty;
            //m.dbCUD(sql, ref msg);

            //if (msg != "OK")
            //{
            //    lblMsg.Text = msg;
            //    return;
            //}
            //QRCodeCreate(rorderID, rorderSeq);
            //QRImageSave(rorderID + rorderSeq);

            //lblMsg.Text = "저장되었습니다.";

            //parentWin.ListSearch();

            //for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
            //{
            //    if (parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString() == sJobNo)
            //    {
            //        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
            //        parentWin.dataGridView1.CurrentCell.Selected = true;
            //        break;
            //    }
            //}
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
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartFactory;
using System.Drawing;

namespace SmartMES_Bluewings
{
    public partial class P1C02_PROD_RESULT1 : SmartMES_Bluewings.FormBasic
    {
        public P1C02_PROD_RESULT1()
        {
            InitializeComponent();
        }
        private void P1C02_PROD_RESULT1_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            dataGridView1.ClearSelection();
            this.ActiveControl = tbBarcode;
        }
        private void P1C02_PROD_RESULT1_Load(object sender, EventArgs e)
        {
            ListSearch1();
        }
        public async void ListSearch1()
        {
            lblMsg.Text = "";
            lblBarcode.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DateTime dtDate = DateTime.Parse(dtpDate.Value.ToString("yyyy-MM-dd"));
                sP_ProdResult_OrderTableAdapter.Fill(dataSetP1C.SP_ProdResult_Order, dtDate);
                var data = dataSetP1C.SP_ProdResult_Order;
                await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

                dataGridView1.DataSource = dataSetP1C.SP_ProdResult_Order;

                if (dataSetP1C.SP_ProdResult_Order.Count > 0)
                {
                    dataGridView_CellClick(null, new DataGridViewCellEventArgs(0, 0));
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
        public async void ListSearch2(int rowIndex)
        {
            lblMsg.Text = ""; lblBarcode.Text = "";
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string sNo = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

                sP_ProdResult_QueryTableAdapter.Fill(dataSetP1C.SP_ProdResult_Query, sNo);
                var data = dataSetP1C.SP_ProdResult_Query;
                await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가
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
            lblMsg.Text = ""; lblBarcode.Text = ""; tbBarcode.Text = ""; 

            dataGridView1.CurrentCell = null;
            dataGridView1.ClearSelection();

            sP_ProdResult_QueryTableAdapter.Fill(dataSetP1C.SP_ProdResult_Query, "");
        }

        #region Condition Bar Events1
        private void userButtonA1_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddDays(-1);
            ListInit();
            ListSearch1();
        }
        private void userButtonA2_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddDays(1);
            ListInit();
            ListSearch1();
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListInit();
            ListSearch1();
        }
        #endregion

        #region GridView Events
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        
        {
            if (e.RowIndex < 0) return;

            int index = dataGridView1.CurrentRow.Index;
            //ListSearch2(index);
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (G.Authority == "D") return;
            if (e.RowIndex < 0) return;
            if (dataGridView1.SelectedRows.Count < 0) return;
            //int rowIndex = dataGridViewA.CurrentCell.RowIndex;

            //if(grp == "A")
            //{
            //    //if (e.ColumnIndex != 4) return;

            //}
            //else if (grp == "B")
            //{
            //    if (e.ColumnIndex != 3) return;
            //}

            //P1C02_PROD_RESULT1_LOT sub = new P1C02_PROD_RESULT1_LOT();
            //sub.grp = grp;
            //sub.prodID = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            //sub.rowIndex = rowIndex;
            //sub.parentWin = this;
            //sub.ShowDialog();
        }
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }
        #endregion

        #region Button Events
        private void btnItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("부자재 사용량 저장 후 생산완료처리 하세요.", this.lblTitle.Text + "[삭제]", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;

            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                lblMsg.Text = "생산 품목이 선택되지 않았습니다.";
                return;
            }
            int index = dataGridView1.CurrentRow.Index;

            string sNo = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string sSeq = dataGridView1.Rows[index].Cells[2].Value.ToString();  // 순번
            string sProd = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string sName = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string sQty = dataGridView1.Rows[index].Cells[5].Value.ToString();  // 수량
            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            dr = MessageBox.Show("LotNo: " + sNo + "\r 품목코드: " + sProd + " 품목명: " + sName + " \r\r생산완료처리 하시겠습니까?","", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;

            MariaCRUD m = new MariaCRUD();
            string sql = string.Empty;
            string msg = string.Empty;

            // 생산실적등록 완료
            //sql = "update tb_prod_result set gd_qty = " + sQty + ", jobtime_finish = '" + sTime + "' where job_no = '" + sNo + "' and seq = " + sSeq;
            sql = $@"insert into tb_prod_result (job_no, seq, machine_id, prod_date, user_id, prod_id, gd_qty, jobtime_finish, enter_man) values ('{sNo}',{sSeq},0,'{sDate}','{G.UserID}','{sProd}',{sQty},'{sTime}','{G.UserID}') 
            on duplicate key update prod_date = '{sDate}', user_id = '{G.UserID}', gd_qty = {sQty}, jobtime_finish = '{sTime}'";

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = "이미 실적 등록되었거나 저장에 문제가 있습니다.";
                return;
            }

            sql = "update tb_prod_order set prod_flag = 1 where job_no = '" + sNo + "' and seq = " + sSeq;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }

            sql = $@"insert into tb_prod_done (job_no, seq, pos, done_date, prod_id, done_qty, enter_man) values('{sNo}',{sSeq},'A','{sDate}','{sProd}',{sQty},'{G.UserID}')
                  on duplicate key update done_date = '{sDate}', prod_id ='{sProd}', done_qty = {sQty}";

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                MessageBox.Show(msg);
                return;
            }

            m.TransLogCreate(G.Authority, G.UserID, "D", this.Name, lblTitle.Text, sNo + " " + sProd);
            ListSearch1();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == sNo)
                {
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    dataGridView1.CurrentCell.Selected = true;

                    //ListSearch2(i);
                    break;
                }
            }
            lblMsg.Text = "생산완료 되었습니다.";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            set_production_result(dtpDate.Value.ToString("yyyy-MM-dd"));
        }
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListInit();
            ListSearch1();
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 0) return;

            //P1C02_PROD_RESULT1_SUB sub = new P1C02_PROD_RESULT1_SUB();
            //sub.lblTitle.Text = sub.lblTitle.Text + "[추가]";
            //sub.parentWin = this;
            //sub.ShowDialog();
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            //
        }
        private async void pbSave_Click(object sender, EventArgs e)
        {
            if (G.Authority == "D") return;

            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sJobNo = string.Empty;
            string sMachine = string.Empty;
            string sProd = string.Empty;
            string sMat1 = string.Empty; string sMat2 = string.Empty; string sMat3 = string.Empty;
            string sQty1 = string.Empty; string sQty2 = string.Empty; string sQty3 = string.Empty;
            string sJobTimeA = "";
            string sJobTimeB = "";

            if (dtpStartTime.Text.Length == 19) sJobTimeA = dtpStartTime.Text;
            else sJobTimeA = "";

            if (dtpDoneTime.Text.Length == 19) sJobTimeB = dtpDoneTime.Text;
            else sJobTimeB = "";

            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();
            string sql = string.Empty;

            int seq = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[1].Value.ToString())) continue;

                sJobNo = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
                sMachine = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
                sProd = dataGridView1.Rows[i].Cells[4].Value.ToString().Trim();
                sMat1 = dataGridView1.Rows[i].Cells[6].Value.ToString().Trim();
                sMat2 = dataGridView1.Rows[i].Cells[9].Value.ToString().Trim();
                sMat3 = dataGridView1.Rows[i].Cells[12].Value.ToString().Trim();
                sQty1 = dataGridView1.Rows[i].Cells[8].Value.ToString().Trim();
                sQty2 = dataGridView1.Rows[i].Cells[11].Value.ToString().Trim();
                sQty3 = dataGridView1.Rows[i].Cells[14].Value.ToString().Trim();

                if (string.IsNullOrEmpty(sQty1)) sQty1 = "0";
                if (string.IsNullOrEmpty(sQty2)) sQty2 = "0";
                if (string.IsNullOrEmpty(sQty3)) sQty3 = "0";

                sql = "insert into tb_prod_result (job_no, machine_id, prod_date, prod_id, mat1, mat2, mat3, qty1, qty2, qty3, jobtime_start, enter_man) " +
                    "values ('" + sJobNo + "'," + sMachine + ",'" + sDate + "','" + sProd + "','" + sMat1 + "','" + sMat2 + "','" + sMat3 + "'," + sQty1 + "," + sQty2 + "," + sQty3 +
                    ", if('" + sJobTimeA + "' = '',NOW(),'" + sJobTimeA + "'),'" + G.UserID + "')";
                m.dbCUD(sql, ref msg);
            }
            ListSearch1();

            var data = sql;
            await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

            m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sJobNo);
            lblMsg.Text = "저장되었습니다.";
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0) return;
            int index = dataGridView1.CurrentRow.Index;
            string sNo = dataGridView1.Rows[index].Cells[0].Value.ToString();

            //P1C02_PROD_RESULT1_LOT sub = new P1C02_PROD_RESULT1_LOT();
            //sub.parentWin = this;
            //sub.lblLot.Text = sNo;
            //sub.tbTot1.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
            //sub.tbTot2.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
            //sub.tbTot3.Text = dataGridView1.Rows[index].Cells[10].Value.ToString();
            //sub.tbConts1.Text = dataGridView1.Rows[index].Cells[11].Value.ToString();
            //sub.ShowDialog();
        }
        #endregion

        #region 사용량 가져오기
        private void set_production_result(string date)
        {
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            //ProResult[] proResult = new ProResult[10];
            int seq = 10;
            int i = 0;

            using (MySqlConnection conn = new MySqlConnection(G.conStr))
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;

                    cmd.CommandText = "SP_ProductionResult_Query";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new MySqlParameter("_date", MySqlDbType.DateTime));
                    cmd.Parameters["_date"].Value = date;

                    cmd.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(ds);
                    int value = 0; string str;
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        //dataGridView1.DataSource = null;
                        //dataGridView1.Rows.Add();
                        
                        str = r["수량"].ToString();
                        value += Int32.Parse(str);
                        seq += 1;
                        i += 1;
                    }
                    //dataGridViewB.Rows[0].Cells[5].Value = value.ToString();
                    //lblMsg.Text = "생산실적이 반영되었습니다.";   주석처리 -> 삭제할때도 뜸.
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                conn.Close();
                conn.Dispose();
            }
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
                Rectangle r2 = gv.GetCellDisplayRectangle(10, -1, false);
                int width = gv.GetCellDisplayRectangle(11, -1, false).Width;

                r2.X += 1; r2.Y += 1;
                r2.Width = r2.Width + width - 2;
                r2.Height = (r2.Height / 2) - 2;

                e.Graphics.DrawRectangle(new Pen(gv.BackgroundColor), r2);
                e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r2);
                e.Graphics.DrawString(strHeaders[1], gv.ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r2, format);
            }
            {
                Rectangle r3 = gv.GetCellDisplayRectangle(13, -1, false);
                int width = gv.GetCellDisplayRectangle(14, -1, false).Width;

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
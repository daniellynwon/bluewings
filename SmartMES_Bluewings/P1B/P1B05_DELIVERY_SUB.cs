using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1B05_DELIVERY_SUB : Form
    {
        public P1B05_DELIVERY parentWin;

        public P1B05_DELIVERY_SUB()
        {
            InitializeComponent();
        }
        private void P1B05_DELIVERY_SUB_Load(object sender, EventArgs e)
        {
            ListSearch();
            this.ActiveControl = tbSearch;
        }
        public void ListSearch()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string sSearch = tbSearch.Text.Trim();

                sP_Delivery_ROderTableAdapter.Fill(dataSetP1B.SP_Delivery_ROder, sSearch);

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

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListSearch();
            }
        }
        private void pbSearch_Click(object sender, EventArgs e)
        {
            ListSearch();
        }
        private void pbSearch_MouseDown(object sender, MouseEventArgs e)
        {
            pbSearch.Location = new Point(pbSearch.Location.X + 1, pbSearch.Location.Y + 1);
        }
        private void pbSearch_MouseUp(object sender, MouseEventArgs e)
        {
            pbSearch.Location = new Point(pbSearch.Location.X - 1, pbSearch.Location.Y - 1);
        }
        private void btnDeli_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1) return;

            int iCnt = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[7].Value != null && dataGridView1.Rows[i].Cells[7].Value.ToString() == "1")
                {
                    iCnt++;
                }
            }
            if (iCnt < 1)
            {
                MessageBox.Show("출하대상이 선택되지 않았습니다.");
                return;
            }
            prodDoneDelivery();
        }
        private void prodDoneDelivery()
        {
            long lMoney = 0;
            int iSeq = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[7].Value != null && dataGridView1.Rows[i].Cells[7].Value.ToString() == "1")
                {
                    parentWin.sPDeliverySubQueryBindingSource.AddNew();
                    parentWin.tbCust.Tag = dataGridView1.Rows[i].Cells[1].Value.ToString();   // 거래처ID
                    parentWin.tbCust.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();   // 거래처명
                    parentWin.tbSaleMan.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();   // 영업담당
                    parentWin.tbPlace.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();   // 현장정보
                    parentWin.tbDOrder.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();   // 지시번호
                    //parentWin.dataGridView1.Rows[iSeq].Cells[12].Value = dataGridView1.Rows[i].Cells[1].Value; //LotNo
                    //parentWin.dataGridView1.Rows[iSeq].Cells[13].Value = dataGridView1.Rows[i].Cells[2].Value; //포대번호
                    parentWin.dataGridView1.Rows[iSeq].Cells[2].Value = dataGridView1.Rows[i].Cells[9].Value; //품목코드
                    parentWin.dataGridView1.Rows[iSeq].Cells[3].Value = dataGridView1.Rows[i].Cells[10].Value; //품목명
                    parentWin.dataGridView1.Rows[iSeq].Cells[6].Value = dataGridView1.Rows[i].Cells[13].Value; //단위
                    parentWin.dataGridView1.Rows[iSeq].Cells[7].Value = dataGridView1.Rows[i].Cells[14].Value; //수량
                    parentWin.dataGridView1.Rows[iSeq].Cells[8].Value = dataGridView1.Rows[i].Cells[15].Value; //단가
                    parentWin.dataGridView1.Rows[iSeq].Cells[9].Value = dataGridView1.Rows[i].Cells[16].Value; //금액

                    lMoney = Convert.ToInt32(dataGridView1.Rows[i].Cells[16].Value.ToString());
                    parentWin.dataGridView1.Rows[iSeq].Cells[10].Value = Math.Round(lMoney * 0.1); //부가세
                    parentWin.dataGridView1.Rows[iSeq].Cells[11].Value = lMoney + Math.Round(lMoney * 0.1); //합계금액

                    parentWin.dataGridView1.Rows[iSeq].Cells[13].Value = "0001"; //출하창고
                    parentWin.dataGridView1.Rows[iSeq].Cells[14].Value = dataGridView1.Rows[i].Cells[0].Value; //수주번호
                    parentWin.dataGridView1.Rows[iSeq].Cells[15].Value = dataGridView1.Rows[i].Cells[8].Value; //수주순번

                    iSeq++;
                }
            }
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != 2) return;

            string sSujuNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (sSujuNo == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    dataGridView1.Rows[i].Cells[7].Value = 1;
                else
                    dataGridView1.Rows[i].Cells[7].Value = 0;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.RowCount < 2) return;
        }
    }
}

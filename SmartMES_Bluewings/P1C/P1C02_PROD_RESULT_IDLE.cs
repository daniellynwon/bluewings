using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1C02_PROD_RESULT_IDLE : Form
    {
        public P1C02_PROD_RESULT parentWin;
        public string jobDate;
        public string seq;

        public P1C02_PROD_RESULT_IDLE()
        {
            InitializeComponent();
        }
        private void P1C02_PROD_RESULT_IDLE_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            //비가동항목
            string sql = @"select co_code, co_item from tb_gi_common where co_kind = 'F' order by co_code";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                lbIdleList.DataSource = table;
                lbIdleList.ValueMember = "co_code";
                lbIdleList.DisplayMember = "co_item";
            }

            DataGridView gridIdle = parentWin.Controls.Find("gridIdle", true).FirstOrDefault() as DataGridView;

            if (gridIdle.RowCount == 0) return;

            int iRow = gridIdle.RowCount - 1;

            if (gridIdle.Rows[iRow].Cells[3].Value == null
                || string.IsNullOrEmpty(gridIdle.Rows[iRow].Cells[3].Value.ToString()))
            {
                lbIdleList.SelectedValue = gridIdle.Rows[iRow].Cells[4].Value.ToString();
                lbIdleList.Enabled = false;
                btnStart.Enabled = false;
                btnFinish.Enabled = true;
                seq = gridIdle.Rows[iRow].Cells[1].Value.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string sql = @"select max(idle_seq) from tb_prod_idle where job_date = '" + jobDate + "'";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            seq = m.dbRonlyOne(sql, ref msg).ToString();

            if (msg != "OK" || string.IsNullOrEmpty(seq)) seq = "1";
            else seq = (Int32.Parse(seq) + 1).ToString();

            string sItem = lbIdleList.SelectedValue.ToString();
            string sStart = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            sql = "insert into tb_prod_idle (job_date, idle_seq, idle_item, idle_start, enter_man) " +
                    "values('" + jobDate + "'," + seq + ",'" + sItem + "','" + sStart + "','" + G.UserID + "')";

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                this.lblMsg.Text = msg;
                return;
            }

            parentWin.sP_ProdResult_ListTableAdapter.Fill(parentWin.dataSetP1C.SP_ProdResult_List);

            Label lblMsg = parentWin.Controls.Find("lblMsg", true).FirstOrDefault() as Label;
            DataGridView dataGridView = parentWin.Controls.Find("dataGridViewList", true).FirstOrDefault() as DataGridView;

            int rowIndex = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value.ToString() == jobDate)
                {
                    dataGridView.CurrentCell = dataGridView[0, i];
                    dataGridView.CurrentCell.Selected = true;
                    rowIndex = i;
                    break;
                }
            }

            parentWin.ListSearch2(rowIndex);
            lblMsg.Text = "비가동시작되었습니다.";

            this.DialogResult = DialogResult.OK;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            string sFinish = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = "update tb_prod_idle set idle_finish = '" + sFinish + "' where job_date = '" + jobDate + "'";

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                this.lblMsg.Text = msg;
                return;
            }

            parentWin.sP_ProdResult_ListTableAdapter.Fill(parentWin.dataSetP1C.SP_ProdResult_List);

            Label lblMsg = parentWin.Controls.Find("lblMsg", true).FirstOrDefault() as Label;
            DataGridView dataGridView = parentWin.Controls.Find("dataGridViewList", true).FirstOrDefault() as DataGridView;

            int rowIndex = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value.ToString() == jobDate)
                {
                    dataGridView.CurrentCell = dataGridView[0, i];
                    dataGridView.CurrentCell.Selected = true;
                    rowIndex = i;
                    break;
                }
            }

            parentWin.ListSearch2(rowIndex);
            lblMsg.Text = "비가동종료되었습니다.";

            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

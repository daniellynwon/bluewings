using System;
using System.Data;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1C03_PROD_DONE_SUB : Form
    {
        public P1C03_PROD_DONE parentWin;
        private int rowIndex = 0;

        public P1C03_PROD_DONE_SUB()
        {
            InitializeComponent();
        }

        private void P1C03_PROD_DONE_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            //운전자
            string sql = @"select user_id, user_name from tb_sys_user where user_flag = 1 and authority = 'C' order by authority, user_id";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbUser.DataSource = table;
                cbUser.ValueMember = "user_id";
                cbUser.DisplayMember = "user_name";
            }

            rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

            tbJobNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            tbMachine.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            tbMachine.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            cbUser.SelectedValue = parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
            tbName.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
            tbSize.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
            tbGdQty.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();            
            tbNgQty.Text = Int32.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[13].Value.ToString()).ToString("#,##0");
            tbSumQty.Text = Int32.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[14].Value.ToString()).ToString("#,##0");
            tbNgQty.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
            lblProc.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[26].Value.ToString();
            lblProc.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[27].Value.ToString();
            dtpDate1.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[17].Value.ToString());
            dtpDate2.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[18].Value.ToString());

            this.ActiveControl = btnSave;
        }

        private void Save()
        {
            lblMsg.Text = "";

            if (string.IsNullOrEmpty(cbUser.Text))
            {
                lblMsg.Text = "운전자가 선택되지 않았습니다.";
                cbUser.Focus();
                return;
            }

            string sDate = dtpDate2.Value.ToString("yyyy-MM-dd");
            string sUser = cbUser.SelectedValue.ToString();
            string sQty = tbGdQty.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(sQty)) sQty = "0";
            string sDT1 = dtpDate1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string sDT2 = dtpDate2.Value.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = "update tb_prod_result " +
                    "set prod_date = '" + sDate + "', user_id = '" + sUser + "', gd_qty = " + sQty + ", jobtime_start = '" + sDT1 + "', jobtime_finish = '" + sDT2 + "'" +
                    " where job_no = '" + tbJobNo.Text + "' and proc_no = " + lblProc.Tag.ToString() + " and machine_id = " + tbMachine.Tag.ToString() ;

            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }

            m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, tbJobNo.Text + " " + lblProc.Text + " " + tbMachine.Text);

            parentWin.ListSearch();
            parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[2, rowIndex];
            parentWin.dataGridView1.Rows[rowIndex].Selected = true;
            this.DialogResult = DialogResult.OK;
        }

        #region 텍스트 박스 숫자 처리
        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText;

                lgsText = tbGdQty.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbGdQty.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));

                tbGdQty.SelectionStart = tbGdQty.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbGdQty.SelectionLength = 0;
            }
            catch (FormatException)
            {
                return;
            }
        }
        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnNg_Click(object sender, EventArgs e)
        {
            P1C03_PROD_DONE_NG sub = new P1C03_PROD_DONE_NG();
            sub.parentWin = this;
            sub.jobNo = tbJobNo.Text;
            sub.procNo = lblProc.Tag.ToString();
            sub.facID = tbMachine.Tag.ToString();
            sub.ShowDialog();
        }
    }
}

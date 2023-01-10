using System;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1B13_STOCK_TABLE_DANGA : Form
    {
        public P1B13_STOCK_TABLE parentWin;
        private int rowIndex = 0;

        public P1B13_STOCK_TABLE_DANGA()
        {
            InitializeComponent();
        }
        private void P1B13_STOCK_TABLE_DANGA_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

            tbCode.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            tbDanga.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();

            this.ActiveControl = tbDanga;
        }

        #region 엔터키로 포커스 이동
        public bool NextFocus(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                return true;
            }
            return false;
        }
        private void nextFocus_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = NextFocus(sender, e);
        }
        #endregion

        private async void Save()
        {
            lblMsg.Text = "";

            string sProd = tbCode.Text;
            string sDanga = tbDanga.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(sDanga)) sDanga = "0";

            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sql = "update tb_gi_product set stock_money = " + sDanga + " where prod_id = '" + sProd + "'";

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

            parentWin.ListSearch();

            for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
            {
                if (parentWin.dataGridView1.Rows[i].Cells[2].Value.ToString() == sProd)
                {
                    parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
                    parentWin.dataGridView1.CurrentCell.Selected = true;
                    break;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        #region 텍스트 박스 숫자 처리
        private void tbDanga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText;

                lgsText = tbDanga.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbDanga.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));

                tbDanga.SelectionStart = tbDanga.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbDanga.SelectionLength = 0;
            }
            catch (FormatException)
            {
                return;
            }
        }
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1C01_PROD_PLAN_SUB : Form
    {
        public P1C01_PROD_PLAN parentWin;

        public P1C01_PROD_PLAN_SUB()
        {
            InitializeComponent();
        }
        private void P1C01_PROD_PLAN_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            this.ActiveControl = tbSaleQty;
        }

        private async void Save()
        {
            lblMsg.Text = "";

            string sSaleQty = tbSaleQty.Text.Replace(",", "").Trim();
            string sProdQty = tbProdQty.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(sSaleQty)) sSaleQty = "0";
            if (string.IsNullOrEmpty(sProdQty)) sProdQty = "0";

            //if (sSaleQty == "0"  && sProdQty == "0")
            //{
            //    lblMsg.Text = "판매 또는 생산 계획수량이 입력되지 않았습니다.";
            //    return;
            //}

            string sPlanDate = tbPlanDate.Text;
            string sProd = tbProduct.Tag.ToString();
            string sBigo = tbContents.Text.Trim();

            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            string sql = "insert into tb_prod_plan(pos, plan_date, prod_id, sale_qty, plan_qty, contents)" +
                    " values( 'A', '" + sPlanDate + "', '" + sProd + "', " + sSaleQty + ", " + sProdQty + ", '" + sBigo + "')" +
                    " on duplicate key update" +
                    " sale_qty = " + sSaleQty + ", plan_qty = " + sProdQty + ", contents = '" + sBigo + "'";

            if (sSaleQty == "0" && sProdQty == "0")
            {
                sql = "delete from tb_prod_plan where plan_date = '" + sPlanDate + "' and prod_id = '" + sProd + "'";
            }

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

            parentWin.CalendarMade(parentWin.tbYM.Text);
            this.DialogResult = DialogResult.OK;
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

        #region 버튼 이벤트
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                Save();
            }
        }
        #endregion

        #region 텍스트 박스 숫자 처리
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}

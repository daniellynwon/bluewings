using System;
using System.Data;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1A06_RECIPE_SUB : Form
    {
        public P1A06_RECIPE parentWin;
        public int parentRowIdx;

        public P1A06_RECIPE_SUB()
        {
            InitializeComponent();
        }
        private void P1A06_RECIPE_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[수정]")
            {
                cbProd.Enabled = false;

                tbNo.Text = parentWin.dataGridView1.Rows[parentRowIdx].Cells[1].Value.ToString();
                tbNo.Tag = parentWin.dataGridView1.Rows[parentRowIdx].Cells[2].Value.ToString();

                cbProd.SelectedValue = parentWin.dataGridView1.Rows[parentRowIdx].Cells[3].Value;
                cbMat1.SelectedValue = parentWin.dataGridView1.Rows[parentRowIdx].Cells[5].Value;
                cbMat2.SelectedValue = parentWin.dataGridView1.Rows[parentRowIdx].Cells[1].Value;
                cbMat3.SelectedValue = parentWin.dataGridView1.Rows[parentRowIdx].Cells[1].Value;
                tbPer1.Text = parentWin.dataGridView1.Rows[parentRowIdx].Cells[9].Value.ToString();
                tbPer2.Text = parentWin.dataGridView1.Rows[parentRowIdx].Cells[9].Value.ToString();
                tbPer3.Text = parentWin.dataGridView1.Rows[parentRowIdx].Cells[9].Value.ToString();
            }
            this.ActiveControl = tbPer1;
        }

        private void Save()
        {
            lblMsg.Text = "";

            //string sProdID = string.Empty;
            //if (tbProduct.Tag != null) sProdID = tbProduct.Tag.ToString();
            //string sPlanId = tbPlanId.Text;

            //string sProdQty = tbProdQty.Text.Replace(",", "").Trim();
            //if (string.IsNullOrEmpty(sProdQty)) sProdQty = "0";

            //if (string.IsNullOrEmpty(sProdID))
            //{
            //    lblMsg.Text = "제품이 선택되지 않았습니다.";
            //    return;
            //}

            //if (sProdQty == "0")
            //{
            //    lblMsg.Text = "작업지시 수량이 입력되지 않았습니다.";
            //    return;
            //}

            //string sPlanDate = dtpPlanDate.Value.ToString("yyyy-MM-dd");
            //string sBigo = tbContents.Text.Trim();

            //string sql = string.Empty;
            //string msg = string.Empty;
            //MariaCRUD m = new MariaCRUD();

            //if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            //{
            //    sql = "insert into productionplan(PlanDate, ProductID, SaleQty, ProdQty, Contents)" +
            //        " values('" + sPlanDate + "', " + sProdID + ", 0, " + sProdQty + ", '" + sBigo + "')" +
            //        " on duplicate key update" +
            //        " ProdQty = " + sProdQty + ", Contents = '" + sBigo + "'";

            //    m.dbCUD(sql, ref msg);

            //    if (msg != "OK")
            //    {
            //        lblMsg.Text = msg;
            //        return;
            //    }

            //    lblMsg.Text = "저장되었습니다.";

            //    parentWin.ListSearch();

            //    for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
            //    {
            //        if (DateTime.Parse(parentWin.dataGridView1.Rows[i].Cells[0].Value.ToString()).ToString("yyyy-MM-dd") + "_" + parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString()
            //            == sPlanDate + "_" + sProdID)
            //        {
            //            parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
            //            parentWin.dataGridView1.CurrentCell.Selected = true;
            //            break;
            //        }
            //    }

            //    tbProduct.Tag = null;
            //    tbProduct.Text = string.Empty;
            //    tbModel.Text = string.Empty;
            //    tbProdQty.Text = string.Empty;
            //    tbContents.Text = string.Empty;
            //    tbProdQty.Focus();
            //}
            //else
            //{
            //    sql = "update productionplan set ProdQty = " + sProdQty + ", Contents = '" + sBigo + "' " +
            //        "where ProdPlanID = " + sPlanId;

            //    m.dbCUD(sql, ref msg);

            //    if (msg != "OK")
            //    {
            //        lblMsg.Text = msg;
            //        return;
            //    }

            //    m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, sPlanDate + " " + tbProduct.Text);

            //    parentWin.ListSearch();
            //    parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, parentRowIdx];
            //    parentWin.dataGridView1.Rows[parentRowIdx].Selected = true;
            //    this.DialogResult = DialogResult.OK;
            //}
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

        private void lbProd_Click(object sender, EventArgs e)
        {
            ProdFinder pop = new ProdFinder();
            pop.cbGubun.Text = "A.제품";
            pop.FormSendEvent += new ProdFinder.FormSendDataHandler(ProdEventMethod);
            pop.ShowDialog();
        }
        private void ProdEventMethod(object sender)
        {
            string sProd = sender.ToString();
            if (string.IsNullOrEmpty(sProd)) return;

            //tbProduct.Tag = sProd.Substring(0, sProd.IndexOf("#1/"));
            //tbProduct.Text = sProd.Substring(sProd.IndexOf("#2/") + 3, sProd.IndexOf("#3/") - (sProd.IndexOf("#2/") + 3));
            //tbModel.Text = sProd.Substring(sProd.IndexOf("#3/") + 3, sProd.IndexOf("#4/") - (sProd.IndexOf("#3/") + 3));
        }
    }
}

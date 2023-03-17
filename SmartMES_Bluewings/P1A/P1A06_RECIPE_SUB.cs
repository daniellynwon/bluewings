using System;
using System.Data;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class P1A06_RECIPE_SUB : Form
    {
        public P1A06_RECIPE parentWin;
        public int rowIndex;

        public P1A06_RECIPE_SUB()
        {
            InitializeComponent();
        }
        private void P1A06_RECIPE_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[수정]")
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                //dtpDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                tbNo.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                tbProd.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                tbKg1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                tbKg2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                tbKg3.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            }
            else
            {
                tbNo.Text = getRecipeCode();
            }
            this.ActiveControl = tbKg1;
        }

        private void Save()
        {
            lblMsg.Text = "";

            string sNo = tbNo.Text;
            string sDate = DateTime.Today.ToString("yyyy-MM-dd");
            string sProdID = string.Empty;
            if (tbProd.Tag != null) sProdID = tbProd.Tag.ToString();

            string sKg1 = tbKg1.Text.Replace(",", "").Trim();
            string sKg2 = tbKg2.Text.Replace(",", "").Trim();
            string sKg3 = tbKg3.Text.Replace(",", "").Trim();
            
            if (string.IsNullOrEmpty(sKg1)) sKg1 = "0";
            if (string.IsNullOrEmpty(sKg2)) sKg2 = "0";
            if (string.IsNullOrEmpty(sKg3)) sKg3 = "0";

            if (string.IsNullOrEmpty(sProdID))
            {
                lblMsg.Text = "제품이 선택되지 않았습니다.";
                return;
            }

            if (sKg1 == "0" || sKg2 == "0" || sKg3 == "0")
            {
                lblMsg.Text = "배합 중량이 입력되지 않았습니다.";
                return;
            }

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            sql = "insert into tb_gi_recipe(recipe_no, prod_id, recipe_date, qty1, qty2, qty3)" +
                " values('" + sNo + "','" + sProdID + "','" + sDate + "'," + sKg1 + "," + sKg2 + "," + sKg3 + ")" +
                    " on duplicate key update" +
                    " qty1 = " + sKg1 + ", qty2 = " + sKg2 + ", qty3 = " + sKg3;

            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }
            lblMsg.Text = "저장되었습니다.";

            parentWin.ListSearch();

            for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
            {
                //if (DateTime.Parse(parentWin.dataGridView1.Rows[i].Cells[0].Value.ToString()).ToString("yyyy-MM-dd") + "_" + parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString()
                //    == sPlanDate + "_" + sProdID)
                //{
                //    parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
                //    parentWin.dataGridView1.CurrentCell.Selected = true;
                //    break;
                //}
            }

            tbProd.Tag = null; tbProd.Text = string.Empty;
            tbKg1.Text = string.Empty;
            tbKg2.Text = string.Empty;
            tbKg3.Text = string.Empty;
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

        #region 품목명 / RecipeNo. 생성
        private void lblProd_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[수정]") return;

            ProdFinder pop = new ProdFinder();
            pop.cbGubun.Text = "A.제품";
            pop._kind = "%";
            pop._stockFlag = "%";
            pop.FormSendEvent += new ProdFinder.FormSendDataHandler(ProdEventMethod);
            pop.ShowDialog();
        }
        private void ProdEventMethod(object sender)
        {
            string sProd = sender.ToString();

            if (string.IsNullOrEmpty(sProd)) return;

            tbProd.Tag = sProd.Substring(0, sProd.IndexOf("#1/"));
            tbProd.Text = sProd.Substring(sProd.IndexOf("#1/") + 3, sProd.IndexOf("#2/") - (sProd.IndexOf("#1/") + 3));
            //tbQty.Focus();
        }
        private string getRecipeCode()
        {
            string sql = @"select UF_RecipeNoGenerator()";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        #endregion
    }
}
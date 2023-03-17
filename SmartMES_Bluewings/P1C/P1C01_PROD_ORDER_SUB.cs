using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1C01_PROD_ORDER_SUB : Form
    {
        public P1C01_PROD_ORDER parentWin;
        private int rowIndex = 0;

        public P1C01_PROD_ORDER_SUB()
        {
            InitializeComponent();
        }
        private void P1C01_PROD_ORDER_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            tbJobNo.Text = getCode();

            string sql = @"SELECT prod_id, prod_name FROM tb_gi_product WHERE gubun = 'B' and prod_kind = '0005'";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbMat1.DataSource = table;
                cbMat1.ValueMember = "prod_id";
                cbMat1.DisplayMember = "prod_name";
            }

            sql = @"SELECT prod_id, prod_name FROM tb_gi_product WHERE gubun = 'B' and prod_kind = '0005'";
            m = new MariaCRUD();
            msg = string.Empty;
            table = m.dbDataTable(sql, ref msg);
            if (msg == "OK")
            {
                cbMat2.DataSource = table;
                cbMat2.ValueMember = "prod_id";
                cbMat2.DisplayMember = "prod_name";
            }
            
            sql = @"SELECT prod_id, prod_name FROM tb_gi_product WHERE gubun = 'B' and prod_kind = '0005'";
            m = new MariaCRUD();
            msg = string.Empty;
            table = m.dbDataTable(sql, ref msg);
            if (msg == "OK")
            {
                cbMat3.DataSource = table;
                cbMat3.ValueMember = "prod_id";
                cbMat3.DisplayMember = "prod_name";
            }

            sql = @"SELECT prod_id, prod_name FROM tb_gi_product WHERE gubun = 'B' and prod_kind = '0005'";
            m = new MariaCRUD();
            msg = string.Empty;
            table = m.dbDataTable(sql, ref msg);
            if (msg == "OK")
            {
                cbMat4.DataSource = table;
                cbMat4.ValueMember = "prod_id";
                cbMat4.DisplayMember = "prod_name";
            }
            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                this.ActiveControl = lblProd;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                //useID = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                //dtpDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
                //tbProd.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                //tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                //tbQty.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                //cbDepot.SelectedValue = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();

                this.ActiveControl = btnSave;
            }
        }

        #region 품목명
        private void lblProd_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

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
            tbQty.Focus();
        }
        #endregion

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

        #region 텍스트 박스 숫자 처리
        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            TextBox tbQty = (TextBox)sender;
            try
            {
                string lgsText;

                lgsText = tbQty.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbQty.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText));

                tbQty.SelectionStart = tbQty.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbQty.SelectionLength = 0;
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

        #region Button Controls
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private async void Save()
        {
            lblMsg.Text = "";

            if (tbProd.Tag == null)
            {
                lblMsg.Text = "품목명을 선택해 주세요.";
                lblProd.Focus();
                return;
            }

            string sQty = tbQty.Text.Replace(",", "").Trim();

            if (string.IsNullOrEmpty(sQty))
            {
                lblMsg.Text = "계획수량을 입력해 주세요.";
                tbQty.Focus();
                return;
            }
            string sPer1 = tbPer1.Text;
            string sPer2 = tbPer2.Text;
            string sPer3 = tbPer3.Text;
            string sPer4 = tbPer4.Text;

            if (string.IsNullOrEmpty(sPer2)) sPer2 = "0";
            if (string.IsNullOrEmpty(sPer3)) sPer3 = "0";
            //if(string.IsNullOrEmpty(sPer4)) sPer4 = "0";

            int iNo1 = Int32.Parse(sPer1);
            int iNo2 = Int32.Parse(sPer2);
            int iNo3 = Int32.Parse(sPer3);
            //int iNo4 = Int32.Parse(sPer4);

            if (iNo1 + iNo2 + iNo3 != 100)
            {
                lblMsg.Text = "비율을 확인해주세요";
                return;
            }

            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sProd = tbProd.Tag.ToString();
            string sDate1 = dtpDate1.Value.ToString("yyyy-MM-dd");
            string sJobNo = getCode();
            string sContents = tbContents.Text.Trim();

            string sql = "insert into tb_prod_order (job_no, pos, lot_date, prod_id, rorder_date, order_qty, ment, enter_man) " +
                    "values('" + sJobNo + "','"+ G.Pos + "','" + sDate + "','" + sProd + "','" + sDate1 + "'," + sQty + ",'" + sContents + "','" + G.UserID + "')";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            m.dbCUD(sql, ref msg);

            if (msg != "OK")
            {
                lblMsg.Text = msg;
                return;
            }
            string sId = getRecipeCode();
            string sMat1 = cbMat1.SelectedValue.ToString();
            string sMat2 = cbMat2.SelectedValue.ToString();
            string sMat3 = cbMat3.SelectedValue.ToString();
            string sMat4 = cbMat4.SelectedValue.ToString();

            sql = "insert into tb_gi_recipe (recipe_no, gubun, job_no, material_id, config_rat) " +
                    "values('" + sId + "', 1,'" + sJobNo + "','" + sMat1 + "','" + sPer1 + "')";
            m.dbCUD(sql, ref msg);

            sql = "insert into tb_gi_recipe (recipe_no, gubun, job_no, material_id, config_rat) " +
                    "values('" + sId + "', 2,'" + sJobNo + "','" + sMat2 + "','" + sPer2 + "') ";
            m.dbCUD(sql, ref msg);

            sql = "insert into tb_gi_recipe (recipe_no, gubun, job_no, material_id, config_rat) " +
                    "values('" + sId + "', 3,'" + sJobNo + "','" + sMat3 + "','" + sPer3 + "') ";
            m.dbCUD(sql, ref msg);

            if (!string.IsNullOrEmpty(sPer4))
            {
                sql = "insert into tb_gi_recipe (recipe_no, gubun, job_no, material_id, config_rat) " +
                         "values('" + sId + "', 4,'" + sJobNo + "','" + sMat4 + "','" + sPer4 + "') ";
                m.dbCUD(sql, ref msg);
            }

            lblMsg.Text = "저장되었습니다.";
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

            parentWin.ListSearch();
            tbJobNo.Text = getCode();
            tbProd.Tag = null;
            tbProd.Text = string.Empty;
            tbQty.Text = string.Empty;
        }
        #endregion

        #region JobNo.(LotNo.) / RecipeNo. 생성
        private string getCode()
        {
            string sql = @"select UF_JobNoGenerator()";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
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

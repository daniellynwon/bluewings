using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1A02_PRODUCT_SPEC : Form
    {
        public P1A02_PRODUCT_SUB parentWin;
        public string gubun;

        private int rowIndex = 0;
        private string prodCode = string.Empty;

        public P1A02_PRODUCT_SPEC()
        {
            InitializeComponent();
        }

        private void P1A02_PRODUCT_SPEC_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            //if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            //{
            //    lblProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            //    this.ActiveControl = btnSave;
            //}
            //else
            //{
            //    rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

            //    prodCode = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            //    main1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
            //    main2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
            //    main3.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[17].Value.ToString();
            //    main4.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[18].Value.ToString();
            //    main5.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[19].Value.ToString();
            //    main6.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[20].Value.ToString();
            //    sub1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[21].Value.ToString();
            //    sub2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[22].Value.ToString();
            //    sub3.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[23].Value.ToString();
            //    sub4.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[24].Value.ToString();
            //    sub5.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[25].Value.ToString();
            //    sub6.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[26].Value.ToString();
            //    mrpm1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[27].Value.ToString();
            //    mrpm2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[28].Value.ToString();
            //    srpm1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[29].Value.ToString();
            //    srpm2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[30].Value.ToString();
            //    temp.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[31].Value.ToString();
            //    speed.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[32].Value.ToString();
            //    tbKg.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[33].Value.ToString();
            //    tbThick1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[34].Value.ToString();
            //    tbThick2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[35].Value.ToString();
            //    tbDiameter.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[36].Value.ToString();
            //    tbLength.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[37].Value.ToString();

            //    this.ActiveControl = btnSave;
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

        private async void Save()
        {
            lblMsg.Text = "";
            string sProdName = lblProd.Text.Trim();

            if (String.IsNullOrEmpty(sProdName))
            {
                lblMsg.Text = "품목명이 선택되지 않았습니다. \r 품목명을 다시 선택하세요.";
                btnClose.Focus();
                return;
            }

            string sMain1 = main1.Text.Trim();
            string sMain2 = main2.Text.Trim();
            string sMain3 = main3.Text.Trim();
            string sMain4 = main4.Text.Trim();
            string sMain5 = main5.Text.Trim();
            string sMain6 = main6.Text.Trim();
            string sSub1 = sub1.Text.Trim();
            string sSub2 = sub2.Text.Trim();
            string sSub3 = sub3.Text.Trim();
            string sSub4 = sub4.Text.Trim();
            string sSub5 = sub5.Text.Trim();
            string sSub6 = sub6.Text.Trim();
            string sMrpm1 = mrpm1.Text.Trim();
            string sMrpm2 = mrpm2.Text.Trim();
            string sSrpm1 = srpm1.Text.Trim();
            string sSrpm2 = srpm2.Text.Trim();
            string sTemp = temp.Text.Trim();
            string sSpeed = speed.Text.Trim();
            string sKg = tbKg.Text.Trim();
            string sThick1 = tbThick1.Text.Trim();
            string sThick2 = tbThick2.Text.Trim();
            string sDiam = tbDiameter.Text.Trim();
            string sLength = tbLength.Text.Trim();

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                sql = "insert into tb_gi_product_spec (prod_id, main_mat1, main_mat2, main_mat3, main_mat4, main_mat5, main_mat6, sub_mat1, sub_mat2, sub_mat3, sub_mat4, sub_mat5, sub_mat6," +
                    " main_speed1, main_speed2, sub_speed1, sub_speed2, coolant, import_good, weight, tube_skin_thickness, min_in_thickness, avg_inner_diameter, product_length) " +
                    "values('" + sProdName + "','" + sMain1 + "','" + sMain2 + "','" + sMain3 + "','" + sMain4 + "','" + sMain5 + "','" + sMain6 + "'," + sSub1 + ",'" + sSub2 + "','" + sSub3 + 
                    "','" + sSub4 + "','" + sSub5 + "','" + sSub6 + "','" + sMrpm1 + "','" + sMrpm2 + "','" + sSrpm1 + "','" + sSrpm2 + "','" + sTemp + "','" + sSpeed + "','" + sKg + "','" +
                    sThick1 + "','" + sThick2 + "','" + sDiam + "','" + sLength + "')";

                m.dbCUD(sql, ref msg);
                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                lblMsg.Text = "저장되었습니다.";
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

                //parentWin.ListSearch();

                //for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
                //{
                //    if (parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString() == prodCode)
                //    {
                //        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
                //        parentWin.dataGridView1.CurrentCell.Selected = true;
                //        break;
                //    }
                //}
            }
            else
            {
                sql = "update tb_gi_product_spec " +
                    "set main_mat1 = '" + sMain1 + "', main_mat2 = '" + sMain2 + "', main_mat3 = '" + sMain3 + "', main_mat4 = '" + sMain4 + "', main_mat5 = '" + sMain5 + /*"', stock_flag = " + sStockFlag + ", use_flag = '" + sUseFlag + */"'" +
                    " where prod_id = '" + prodCode + "'";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, prodCode + " " + sProdName);

                //parentWin.ListSearch();
                //parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, rowIndex];
                //parentWin.dataGridView1.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 품목코드 생성 / 품목명 확인
        private string getProdCode(string _gubun)
        {
            string sql = @"select UF_ProdCodeGenerator('" + _gubun + "')";

            MariaCRUD m = new MariaCRUD();

            string msg = string.Empty;
            return m.dbRonlyOne(sql, ref msg).ToString();
        }
        private bool isProdName(string _gubun, string _prodName)
        {
            string sql = @"select prod_id from tb_gi_product where gubun = '" + _gubun + "' and prod_name = '" + _prodName + "'";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            object id = m.dbRonlyOne(sql, ref msg);

            if (msg == "OK" && id != null)
                return true;
            else
                return false;
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

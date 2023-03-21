using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1A02_PRODUCT_SUB : Form
    {
        public P1A02_PRODUCT parentWin;
        public string gubun;

        private int rowIndex = 0;
        private string prodCode = string.Empty;

        public P1A02_PRODUCT_SUB()
        {
            InitializeComponent();
        }

        private void P1A02_PRODUCT_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (gubun == "A") cbGubun.Text = "A.제품";
            else if (gubun == "B") cbGubun.Text = "B.원/부자재";
            //else if (gubun == "C") cbGubun.Text = "C.반제품";
            //else if (gubun == "D") cbGubun.Text = "D.세트";
            else cbGubun.Text = "Z.기타";

            string sql = @"select co_code, co_item from tb_gi_common where co_kind = 'C' order by co_code";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbKind.DataSource = table;
                cbKind.ValueMember = "co_code";
                cbKind.DisplayMember = "co_item";
            }

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                cbKind.SelectedIndex = 0;
                this.ActiveControl = tbProdName;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                prodCode = parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                cbKind.SelectedValue = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value;
                tbProdName.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                tbModel.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                tbUnit.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                tbUnitSub.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
                tbPrice1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
                tbPrice2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();

                if (parentWin.dataGridView1.Rows[rowIndex].Cells[12].Value.ToString() == "0")
                    ckbStockFlag.Checked = true;
                if (parentWin.dataGridView1.Rows[rowIndex].Cells[14].Value.ToString() == "X")
                    ckbUseFlag.Checked = true;
                
                ///// 규격
                main1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
                main2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
                main3.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[17].Value.ToString();
                main4.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[18].Value.ToString();
                main5.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[19].Value.ToString();
                main6.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[20].Value.ToString();
                sub1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[21].Value.ToString();
                sub2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[22].Value.ToString();
                sub3.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[23].Value.ToString();
                sub4.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[24].Value.ToString();
                sub5.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[25].Value.ToString();
                sub6.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[26].Value.ToString();
                mrpm1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[27].Value.ToString();
                mrpm2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[28].Value.ToString();
                srpm1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[29].Value.ToString();
                srpm2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[30].Value.ToString();
                temp.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[31].Value.ToString();
                speed.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[32].Value.ToString();
                tbKg.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[33].Value.ToString();
                tbThick1.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[34].Value.ToString();
                tbThick2.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[35].Value.ToString();
                tbDiameter.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[36].Value.ToString();
                tbLength.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[37].Value.ToString();

                cbGubun.Enabled = false;
                this.ActiveControl = btnSave;
            }
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

            string sProdName = tbProdName.Text.Trim();

            if (String.IsNullOrEmpty(sProdName))
            {
                lblMsg.Text = "품목명을 입력해 주세요.";
                tbProdName.Focus();
                return;
            }

            string sGubun = cbGubun.Text.Substring(0, 1);
            string sKind = cbKind.SelectedValue.ToString();
            string sPrice1 = tbPrice1.Text.Replace(",", "").Trim(); string sPrice2 = tbPrice2.Text.Replace(",", "").Trim();
            string sUnit = tbUnit.Text.Trim(); string sUnitSub = tbUnitSub.Text.Trim();
            string sID = tbIDNo.Text.Trim(); string sModel = tbModel.Text.Trim();

            string sStockFlag = "1";
            if (ckbStockFlag.Checked) sStockFlag = "0";
            string sUseFlag = "O";
            if (ckbUseFlag.Checked) sUseFlag = "X";

            string sMain1 = main1.Text.Trim(); string sMain2 = main2.Text.Trim(); string sMain3 = main3.Text.Trim(); string sMain4 = main4.Text.Trim(); string sMain5 = main5.Text.Trim();
            string sMain6 = main6.Text.Trim();
            string sSub1 = sub1.Text.Trim(); string sSub2 = sub2.Text.Trim(); string sSub3 = sub3.Text.Trim(); string sSub4 = sub4.Text.Trim(); string sSub5 = sub5.Text.Trim(); 
            string sSub6 = sub6.Text.Trim();
            string sMrpm1 = mrpm1.Text.Trim(); string sMrpm2 = mrpm2.Text.Trim(); string sSrpm1 = srpm1.Text.Trim(); string sSrpm2 = srpm2.Text.Trim();
            string sTemp = temp.Text.Trim(); string sSpeed = speed.Text.Trim(); string sKg = tbKg.Text.Trim();
            string sThick1 = tbThick1.Text.Trim(); string sThick2 = tbThick2.Text.Trim(); string sDiam = tbDiameter.Text.Trim(); string sLength = tbLength.Text.Trim();
            if (string.IsNullOrEmpty(sPrice1)) sPrice1 = "0"; if (string.IsNullOrEmpty(sPrice2)) sPrice2 = "0";

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                //입력한 품목명이 중복인지 확인..
                if (isProdName(sGubun, sProdName))
                {
                    lblMsg.Text = "이미 존재하는 품목명입니다.";
                    tbProdName.Focus();
                    return;
                }

                prodCode = getProdCode(sGubun);

                sql = "insert into tb_gi_product (gubun, prod_id, prod_kind, prod_name, model_name, unit, unit_sub, procure_price, regular_price, stock_flag, identify_no, use_flag, enter_man) " +
                    "values('" + sGubun + "','" + prodCode + "','" + sKind + "','" + sProdName + "','" + sModel + "','" + sUnit + "','" + sUnitSub + "','" + sPrice1 + "','" + sPrice2 + "'," + sStockFlag + ",'" + sID + "','" + sUseFlag + "','" + G.UserID + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                sql = "insert into tb_gi_product_spec (prod_id, main_mat1, main_mat2, main_mat3, main_mat4, main_mat5, main_mat6, sub_mat1, sub_mat2, sub_mat3, sub_mat4, sub_mat5, sub_mat6," +
                    " main_speed1, main_speed2, sub_speed1, sub_speed2, coolant, import_good, weight, tube_skin_thickness, min_in_thickness, avg_inner_diameter, product_length) " +
                    "values('" + prodCode + "','" + sMain1 + "','" + sMain2 + "','" + sMain3 + "','" + sMain4 + "','" + sMain5 + "','" + sMain6 + "','" + sSub1 + "','" + sSub2 + "','" + sSub3 +
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

                parentWin.tbSearch.Text = "";
                if (sGubun == "A") parentWin.rbA.Checked = true;
                else if (sGubun == "B") parentWin.rbB.Checked = true;
                else if (sGubun == "C") parentWin.rbC.Checked = true;
                else if (sGubun == "D") parentWin.rbD.Checked = true;
                else parentWin.rbZ.Checked = true;

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
                {
                    if (parentWin.dataGridView1.Rows[i].Cells[1].Value.ToString() == prodCode)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbProdName.Text = string.Empty;
                tbPrice2.Text = string.Empty;
                tbProdName.Focus();
            }
            else
            {
                sql = "update tb_gi_product " +
                    "set prod_kind = '" + sKind + "', prod_name = '" + sProdName + "', model_name ='" + sModel + "', unit = '" + sUnit + "', unit_sub = '" + sUnitSub + "', procure_price = " + sPrice1 + ", regular_price = " + sPrice2 + ", stock_flag = " + sStockFlag + ", identify_no = '" + sID + "', use_flag = '" + sUseFlag + "'" +
                    " where prod_id = '" + prodCode + "'";

                m.dbCUD(sql, ref msg);


                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                sql = "update tb_gi_product_spec " +
                    "set main_mat1 = '" + sMain1 + "', main_mat2 = '" + sMain2 + "', main_mat3 = '" + sMain3 + "', main_mat4 = '" + sMain4 + "', main_mat5 = '" + sMain5 + "', main_mat6 = '" + sMain6 + 
                    "', sub_mat1 = '" + sSub1 + "', sub_mat2 = '" + sSub2 + "', sub_mat3 = '" + sSub3 + "', sub_mat4 = '" + sSub4 + "', sub_mat5 = '" + sSub5 + "', sub_mat6 = '" + sSub6 + 
                    "', main_speed1 = '" + sMrpm1 + "', main_speed2 = '" + sMrpm2 + "', sub_speed1 = '" + sSrpm1 + "', sub_speed2 = '" + sSrpm2 + "', coolant = '" + sTemp + "', import_good = '" + sSpeed + 
                    "', weight = '" + sKg + "', tube_skin_thickness = '" + sThick1 + "', min_in_thickness = '" + sThick2 + "', avg_inner_diameter = '" + sDiam + "', product_length = '" + sLength + "'" +
                    " where prod_id = '" + prodCode + "'";

                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, prodCode + " " + sProdName);

                parentWin.ListSearch();
                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[0, rowIndex];
                parentWin.dataGridView1.Rows[rowIndex].Selected = true;
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

        #region 텍스트 박스 숫자 처리
        private void tbQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lgsText1, lgsText2;

                lgsText1 = tbPrice1.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                lgsText2 = tbPrice2.Text.Replace(",", ""); //** 숫자변환시 콤마로 발생하는 에러방지...
                tbPrice1.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText1));
                tbPrice2.Text = String.Format("{0:#,##0}", Convert.ToDouble(lgsText2));

                tbPrice1.SelectionStart = tbPrice1.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbPrice1.SelectionLength = 0;
                tbPrice2.SelectionStart = tbPrice2.TextLength; //** 캐럿을 맨 뒤로 보낸다...
                tbPrice2.SelectionLength = 0;
            }
            catch (FormatException)
            {
                return;
            }
        }
        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-'))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}

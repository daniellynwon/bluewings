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
                tbSize.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                tbUnit.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
                tbUnitSub.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();

                if (parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString() == "0")
                    ckbStockFlag.Checked = true;
                if (parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString() == "X")
                    ckbUseFlag.Checked = true;

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
            string sSize = tbSize.Text.Trim();
            string sUnit = tbUnit.Text.Trim();
            string sUnitSub = tbUnitSub.Text.Trim();

            string sStockFlag = "1";
            if (ckbStockFlag.Checked) sStockFlag = "0";
            string sUseFlag = "O";
            if (ckbUseFlag.Checked) sUseFlag = "X";

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

                sql = "insert into tb_gi_product (gubun, prod_id, prod_kind, prod_name, prod_size, unit, unit_sub, stock_flag, use_flag, enter_man) " +
                    "values('" + sGubun + "','" + prodCode + "','" + sKind + "','" + sProdName + "','" + sSize + "','" + sUnit + "','" + sUnitSub + "'," + sStockFlag + ",'" + sUseFlag + "','" + G.UserID + "')";

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
                tbSize.Text = string.Empty;
                tbProdName.Focus();
            }
            else
            {
                sql = "update tb_gi_product " +
                    "set prod_kind = '" + sKind + "', prod_name = '" + sProdName + "', prod_size = '" + sSize + "', unit = '" + sUnit + "', unit_sub = '" + sUnitSub + "', stock_flag = " + sStockFlag + ", use_flag = '" + sUseFlag + "'" +
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
    }
}

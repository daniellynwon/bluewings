using System;
using System.Data;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1A05_STOCK_MOVE_SUB : Form
    {
        public P1A05_STOCK_MOVE parentWin;
        private int rowIndex = 0;
        private string moveID;

        public P1A05_STOCK_MOVE_SUB()
        {
            InitializeComponent();
        }

        private void P1A05_STOCK_MOVE_SUB_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            string sql = @"select co_code, co_item from tb_gi_common where co_kind = 'B' order by co_code";
            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbDepot.DataSource = table;
                cbDepot.ValueMember = "co_code";
                cbDepot.DisplayMember = "co_item";
            }

            cbDepot.SelectedIndex = parentWin.cbDepot.SelectedIndex;

            sql = @"select co_code, co_item from tb_gi_common where co_kind = 'E' order by co_code";
            m = new MariaCRUD();
            table = m.dbDataTable(sql, ref msg);

            if (msg == "OK")
            {
                cbKind.DataSource = table;
                cbKind.ValueMember = "co_code";
                cbKind.DisplayMember = "co_item";
            }

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                this.ActiveControl = tbQty;
            }
            else
            {
                rowIndex = parentWin.dataGridView1.CurrentCell.RowIndex;

                moveID = parentWin.dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                dtpDate.Value = DateTime.Parse(parentWin.dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
                tbProd.Tag = parentWin.dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                tbProd.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                cbKind.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
                tbQty.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
                tbContents.Text = parentWin.dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();

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

            if (tbProd.Tag == null)
            {
                lblMsg.Text = "품목명을 선택해 주세요.";
                lblProd.Focus();
                return;
            }

            string sProd = tbProd.Tag.ToString();
            string sQty = tbQty.Text.Replace(",", "").Trim();

            if (String.IsNullOrEmpty(sQty))
            {
                lblMsg.Text = "조정수량을 입력해 주세요.";
                tbQty.Focus();
                return;
            }

            if (sQty.Substring(0, 1) == "-")
            {
                DialogResult dr = MessageBox.Show("0보다 적은 수량을 입력했습니다.\r\r조정수량을 저장하시겠습니까?", this.lblTitle.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No) return;
            }

            string sDate = dtpDate.Value.ToString("yyyy-MM-dd");
            string sDepot = cbDepot.SelectedValue.ToString();
            string sKind = cbKind.SelectedValue.ToString();
            string sContents = tbContents.Text.Trim();

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (lblTitle.Text.Substring(lblTitle.Text.Length - 4, 4) == "[추가]")
            {
                sql = "insert into tb_stock_move (pos, move_date, depot, prod_id, move_kind, move_qty, contents, enter_man) " +
                    "values('" + G.Pos + "','" + sDate + "','" + sDepot + "','" + sProd + "','" + sKind + "'," + sQty + ",'" + sContents + "','" + G.UserID + "')";

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }

                lblMsg.Text = "저장되었습니다.";
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가

                sql = @"select move_id from tb_stock_move order by move_id desc limit 1";
                m = new MariaCRUD();
                string com = m.dbRonlyOne(sql, ref msg).ToString();

                parentWin.ListSearch();

                for (int i = 0; i < parentWin.dataGridView1.Rows.Count; i++)
                {
                    if (parentWin.dataGridView1.Rows[i].Cells[0].Value.ToString() == com)
                    {
                        parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, i];
                        parentWin.dataGridView1.CurrentCell.Selected = true;
                        break;
                    }
                }

                tbProd.Tag = null;
                tbProd.Text = string.Empty;
                tbQty.Text = string.Empty;
                tbContents.Text = string.Empty;
                lblMsg.Focus();
            }
            else
            {
                sql = "update tb_stock_move " +
                    "set move_date = '" + sDate + "', depot = '" + sDepot + "', prod_id = '" + sProd + "', move_kind = '" + sKind + "', move_qty = " + sQty + ", contents = '" + sContents + "'" +
                    " where move_id = " + moveID;

                m.dbCUD(sql, ref msg);

                if (msg != "OK")
                {
                    lblMsg.Text = msg;
                    return;
                }
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.수정, data);//수정로그추가

                m.TransLogCreate(G.Authority, G.UserID, "M", this.Name, lblTitle.Text, moveID + " " + sDate + " " + sProd);

                parentWin.ListSearch();
                parentWin.dataGridView1.CurrentCell = parentWin.dataGridView1[1, rowIndex];
                parentWin.dataGridView1.Rows[rowIndex].Selected = true;
                this.DialogResult = DialogResult.OK;
            }
        }

        #region 품목명
        private void lblProd_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            ProdFinder pop = new ProdFinder();
            pop.cbGubun.Text = parentWin.cbGubun.Text;
            pop._kind = "%";
            pop._stockFlag = "1";
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

        #region 텍스트 박스 숫자 처리
        private void tbQty_TextChanged(object sender, EventArgs e)
        {
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
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '-'))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
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

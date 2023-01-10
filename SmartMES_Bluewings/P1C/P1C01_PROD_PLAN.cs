using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class P1C01_PROD_PLAN : SmartMES_Bluewings.FormBasic
    {
        public P1C01_PROD_PLAN()
        {
            InitializeComponent();
        }

        private void P1C01_PROD_PLAN_Load(object sender, EventArgs e)
        {
            tbYM.Text = DateTime.Today.ToString("yyyy년 MM월");
            lblM.Text = DateTime.Today.ToString("M월");

            CalendarMade(tbYM.Text);
        }

        public async void CalendarMade(string _date)
        {
            Cursor.Current = Cursors.WaitCursor;

            DateTime dtFromDate = DateTime.Parse(_date.Substring(0, 4) + "-" + _date.Substring(6, 2) + "-01");
            DateTime dtToDate = dtFromDate.AddMonths(1).AddDays(-1);

            int[] array = Enumerable.Repeat<int>(0, 37).ToArray<int>();

            int iStart = Int32.Parse(dtFromDate.DayOfWeek.ToString("d"));
            int iDay = 0;

            for (int i = iStart; i < (dtToDate.Day + iStart); i++)
            {
                iDay++;
                array[i] = iDay;
            }
            // 여기까지 달력 모양 만들어줌

            Label lbD, lbJ, lbY, lbJU, lbYA, lbS;
            Label lbZ, lbZZ;
            string workDate;

            string sProd = "%";
            if (!(tbProd.Tag == null || string.IsNullOrEmpty(tbProd.Tag.ToString())))
                sProd = tbProd.Tag.ToString();

            string msg = string.Empty;
            string sql = " SELECT SUM(prod_qty + purch_qty + move_qty - use_qty - deli_qty) FROM vw_stock WHERE prod_id LIKE '" + sProd + "' AND stock_date <= CURDATE()";      // 현재 재고
            MariaCRUD m = new MariaCRUD();
            string stock = m.dbRonlyOne(sql, ref msg).ToString();

            if (msg != "OK" || string.IsNullOrEmpty(stock)) stock = "0";
            var data = sql;
            var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.조회, data); //조회로그추가

            sql = "SELECT pp.plan_date, Sum(pp.sale_qty), Sum(pp.plan_qty), if('" + sProd + "' = '%', '',Max(pp.contents))," +
                    "if(pp.plan_date = curdate()," + stock + ",if(pp.plan_date > curdate()," + stock + " + ifnull((select sum(a.plan_qty-a.sale_qty) from tb_prod_plan a where (a.plan_date between date_add(curdate(), interval 1 day) and pp.plan_date) and concat(a.prod_id) like '" + sProd + "'),0),0)) " +
                    "FROM tb_prod_plan pp " +
                    "WHERE pp.plan_date BETWEEN '" + dtFromDate.ToString("yyyy-MM-dd") + "' AND '" + dtToDate.ToString("yyyy-MM-dd") + "' " +
                    "AND CONCAT(pp.prod_id) LIKE '" + sProd + "' " +
                    "GROUP BY pp.plan_date ORDER BY pp.plan_date";

            //sql = "select t.plan_date, sum(t.sale_qty), sum(t.plan_qty), max(t.contents), sum(t.stock) from( SELECT CURDATE() as plan_date, 0 as sale_qty, 0 as plan_qty, '' as contents,  0 as stock UNION ALL " + 
            //    "SELECT pp.plan_date as plan_date, Sum(pp.sale_qty) as sale_qty, Sum(pp.plan_qty) as plan_qty, if('" + sProd + "' = '%', '',Max(pp.contents)) as contents," +
            //        "if(pp.plan_date = curdate()," + stock + ",if(pp.plan_date > curdate()," + stock + " + ifnull((select sum(a.plan_qty-a.sale_qty) from tb_prod_plan a where (a.plan_date between date_add(curdate(), interval 1 day) and pp.plan_date) and concat(a.prod_id) like '" + sProd + "'),0),0)) as stock " +
            //        "FROM tb_prod_plan pp " +
            //        "WHERE pp.plan_date BETWEEN '" + dtFromDate.ToString("yyyy-MM-dd") + "' AND '" + dtToDate.ToString("yyyy-MM-dd") + "' " +
            //        "AND CONCAT(pp.prod_id) LIKE '" + sProd + "' " +
            //        "GROUP BY pp.plan_date) as t group by t.plan_date ORDER BY t.plan_date";


            m = new MariaCRUD();
            DataTable table = m.dbDataTable(sql, ref msg);
            DataRow[] row;

            for (int i = 0; i < array.Length; i++)
            {
                lbD = this.Controls.Find("lbDay" + i.ToString(), true).FirstOrDefault() as Label;
                lbJ = this.Controls.Find("lbJ" + i.ToString(), true).FirstOrDefault() as Label;
                lbY = this.Controls.Find("lbY" + i.ToString(), true).FirstOrDefault() as Label;
                lbJU = this.Controls.Find("lbJU" + i.ToString(), true).FirstOrDefault() as Label;
                lbYA = this.Controls.Find("lbYA" + i.ToString(), true).FirstOrDefault() as Label;
                lbS = this.Controls.Find("lbScript" + i.ToString(), true).FirstOrDefault() as Label;
                lbZ = this.Controls.Find("lbZ" + i.ToString(), true).FirstOrDefault() as Label;
                lbZZ = this.Controls.Find("lbZZ" + i.ToString(), true).FirstOrDefault() as Label;

                if (array[i] == 0)
                {
                    lbD.Text = string.Empty;
                    lbJ.Text = string.Empty;
                    lbY.Text = string.Empty;
                    lbJU.Text = string.Empty;
                    lbYA.Text = string.Empty;
                    lbS.Text = string.Empty;
                    lbZ.Text = string.Empty;
                    lbZZ.Text = string.Empty;
                }
                else
                {
                    lbD.Text = array[i].ToString();
                    workDate = dtFromDate.ToString("yyyy-MM") + "-" + array[i].ToString("00");

                    lbJ.Text = "판매";
                    lbY.Text = "생산";
                    lbJU.Text = string.Empty;
                    lbYA.Text = string.Empty;
                    lbS.Text = string.Empty;
                    lbZ.Text = string.Empty;
                    lbZZ.Text = string.Empty;

                    if (msg == "OK")
                    {
                        row = table.Select("plan_date='" + workDate + "'");
                        if (row.Length > 0)
                        {
                            lbJU.Text = row[0][1].ToString();
                            lbYA.Text = row[0][2].ToString();
                            lbS.Text = row[0][3].ToString();

                            if (DateTime.Parse(workDate) >= DateTime.Today)
                            {
                                if (DateTime.Parse(workDate) == DateTime.Today) lbZ.Text = "현재고";
                                else lbZ.Text = "재고";

                                lbZZ.Text = row[0][4].ToString();
                            }                            
                        }
                    }
                }
            }

            Cursor.Current = Cursors.Default;
        }

        #region Condition Bar Events
        private void lblProd_Click(object sender, EventArgs e)
        {
            ProdFinder pop = new ProdFinder();
            pop.cbGubun.Text = "A.정품";
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

            CalendarMade(tbYM.Text);
        }
        private void pbProdDel_Click(object sender, EventArgs e)
        {
            tbProd.Tag = null;
            tbProd.Text = "";

            CalendarMade(tbYM.Text);
        }
        private void ubtnLeft_Click(object sender, EventArgs e)
        {
            tbYM.Text = DateTime.Parse(tbYM.Text.Substring(0, 4) + "-" + tbYM.Text.Substring(6, 2) + "-01").AddMonths(-1).ToString("yyyy년 MM월");
            lblM.Text = Int32.Parse(tbYM.Text.Substring(6, 2)).ToString() + "월";

            CalendarMade(tbYM.Text);
        }
        private void ubtnRight_Click(object sender, EventArgs e)
        {
            tbYM.Text = DateTime.Parse(tbYM.Text.Substring(0, 4) + "-" + tbYM.Text.Substring(6, 2) + "-01").AddMonths(1).ToString("yyyy년 MM월");
            lblM.Text = Int32.Parse(tbYM.Text.Substring(6, 2)).ToString() + "월";

            CalendarMade(tbYM.Text);
        }
        #endregion

        #region Button Events
        private void pbSearch_Click(object sender, EventArgs e)
        {
            CalendarMade(tbYM.Text);
        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbDel_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbSave_Click(object sender, EventArgs e)
        {
            //
        }
        private void pbPrint_Click(object sender, EventArgs e)
        {
            //
        }
        #endregion

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            if (tbProd.Tag == null || string.IsNullOrEmpty(tbProd.Tag.ToString()))
            {
                MessageBox.Show("제품명을 선택해 주세요.");
                return;
            }

            Panel p = (Panel)sender;

            Label lbD = this.Controls.Find("lbDay" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;

            if (string.IsNullOrEmpty(lbD.Text)) return;

            Label lbJ = this.Controls.Find("lbJU" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;
            Label lbY = this.Controls.Find("lbYA" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;
            Label lbS = this.Controls.Find("lbScript" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;

            P1C01_PROD_PLAN_SUB sub = new P1C01_PROD_PLAN_SUB();
            sub.parentWin = this;

            sub.tbPlanDate.Text = tbYM.Text.Substring(0, 4) + "-" + tbYM.Text.Substring(6, 2) + "-" + Int32.Parse(lbD.Text).ToString("00");
            sub.tbProduct.Tag = tbProd.Tag;
            sub.tbProduct.Text = tbProd.Text;
            if (lbJ.Text != "0") sub.tbSaleQty.Text = lbJ.Text;
            if (lbY.Text != "0") sub.tbProdQty.Text = lbY.Text;
            sub.tbContents.Text = lbS.Text;

            sub.ShowDialog();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (tbProd.Tag == null || string.IsNullOrEmpty(tbProd.Tag.ToString()))
            {
                return;
            }

            if ((Control.ModifierKeys & Keys.Control) != 0)
            {
                Panel p = (Panel)sender;

                Label lbD = this.Controls.Find("lbDay" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;

                if (string.IsNullOrEmpty(lbD.Text)) return;

                string sDate = tbYM.Text.Substring(0, 4) + "-" + tbYM.Text.Substring(6, 2) + "-" + Int32.Parse(lbD.Text).ToString("00");
                sDate = sDate + p.Name.Substring(1, p.Name.Length - 1);

                DoDragDrop(sDate, DragDropEffects.Copy);
            }
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (tbProd.Tag == null || string.IsNullOrEmpty(tbProd.Tag.ToString()))
            {
                return;
            }

            if (e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private async void panel_DragDrop(object sender, DragEventArgs e)
        {
            if (tbProd.Tag == null || string.IsNullOrEmpty(tbProd.Tag.ToString()))
            {
                return;
            }

            Panel p = (Panel)sender;

            Label lbD = this.Controls.Find("lbDay" + p.Name.Substring(1, p.Name.Length - 1), true).FirstOrDefault() as Label;
            
            if (string.IsNullOrEmpty(lbD.Text))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            string sScrDate = (string)e.Data.GetData(DataFormats.StringFormat);
            string sScrNo = sScrDate.Substring(10, sScrDate.Length-10);
            sScrDate = sScrDate.Substring(0, 10);
            string sTrkDate = tbYM.Text.Substring(0, 4) + "-" + tbYM.Text.Substring(6, 2) + "-" + Int32.Parse(lbD.Text).ToString("00");
            string sProd = tbProd.Tag.ToString();

            Label lbJ = this.Controls.Find("lbJU" + sScrNo, true).FirstOrDefault() as Label;
            Label lbY = this.Controls.Find("lbYA" + sScrNo, true).FirstOrDefault() as Label;
            Label lbS = this.Controls.Find("lbScript" + sScrNo, true).FirstOrDefault() as Label;
            string sJ = lbJ.Text;
            string sY = lbY.Text;
            string sS = lbS.Text;
            if (sJ == null || string.IsNullOrEmpty(sJ)) sJ = "0";
            if (sY == null || string.IsNullOrEmpty(sY)) sY = "0";

            string sql = string.Empty;
            string msg = string.Empty;
            MariaCRUD m = new MariaCRUD();

            if (DateTime.Parse(sScrDate) < DateTime.Parse(sTrkDate))
            {
                for (int i = 0; i < Int32.Parse(lbD.Text) - DateTime.Parse(sScrDate).Day; i++)
                {
                    sql = "insert into tb_prod_plan(pos, plan_date, prod_id, sale_qty, plan_qty, contents, enter_man)" +
                    " values( 'A', '" + sTrkDate + "', '" + sProd + "', " + sJ + ", " + sY + ", '" + sS + "','" + G.UserID + "')" +
                    " on duplicate key update" +
                    " sale_qty = " + sJ + ", plan_qty = " + sY + ", contents = '" + sS + "'";

                    m.dbCUD(sql, ref msg);
                    var data = sql;
                    var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가
                    sTrkDate = DateTime.Parse(sTrkDate).AddDays(-1).ToString("yyyy-MM-dd");
                }
            }
            else
            {
                sql = "insert into tb_prod_plan(pos, plan_date, prod_id, sale_qty, plan_qty, contents)" +
                    " values( 'A', '" + sTrkDate + "', '" + sProd + "', " + sJ + ", " + sY + ", '" + sS + "','" + G.UserID + "')" +
                    " on duplicate key update" +
                    " sale_qty = " + sJ + ", plan_qty = " + sY + ", contents = '" + sS + "'";

                m.dbCUD(sql, ref msg);
                var data = sql;
                var result = await Logger.ApiLog(G.UserID, lblTitle.Text, ActionType.등록, data);//등록로그추가
            }

            CalendarMade(tbYM.Text);
        }
    }
}

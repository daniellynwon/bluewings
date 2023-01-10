using Microsoft.Win32;//RegistryKey 사용
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmartFactory;

namespace SmartMES_Bluewings
{
    public partial class MDIForm : Form
    {
        private MySqlConnection con;
        //private TreeNode rootNode;

        public MDIForm()
        {
            InitializeComponent();

            if (Screen.PrimaryScreen.Bounds.Width < 1500)
                this.panel1.Visible = false;
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            fm.MdiParent = this;
            fm.Dock = DockStyle.Fill;
            fm.Show();

            TreeViewCreate("KO");
            Notify();
        }

        //메뉴구성
        protected void TreeViewCreate(string lang)
        {
            string menuLavel1 = "select a.menu_id, a.menu_name " +
                                "from tb_sys_menu a " +
                                "where a.menu_lang = '" + lang + "' and a.menu_level = '1' and a.menu_kind = 'G' " +
                                "order by a.seq";

            string menuLavel2 = "select a.menu_id, a.menu_name, a.upmenu_id, if(a.menu_type='M','-',a.pg_id) as menu_pgid, " +
                                "ifnull((select count(*) from tb_sys_authority t where t.user_id = '" + G.UserID + "' and t.menu_lang = '" + lang + "' and t.menu_id = a.menu_id),0) as menu_autho " +
                                "from tb_sys_menu a " +
                                "where a.menu_lang = '" + lang + "' and a.menu_level = '2' and a.menu_kind = 'G' " +
                                "order by a.seq";

            string menuLavel3 = "select a.menu_id, a.menu_name, a.upmenu_id, if(a.menu_type='M','-',a.pg_id) as menu_pgid, " +
                                "ifnull((select count(*) from tb_sys_authority t where t.user_id = '" + G.UserID + "' and t.menu_lang = '" + lang + "' and t.menu_id = a.menu_id),0) as menu_autho " +
                                "from tb_sys_menu a " +
                                "where a.menu_lang = '" + lang + "' and a.menu_level = '3' and a.menu_kind = 'G' " +
                                "order by a.seq";
            //관리자메뉴
            string adminMenu1 = "select menu_id, menu_name from tb_sys_menu where menu_lang = '" + lang + "' and menu_level = '1' and menu_kind = 'M' order by seq";
            string adminMenu2 = "select menu_id, menu_name, upmenu_id, if(menu_type='M','-',pg_id) as menu_pgid from tb_sys_menu where menu_lang = '" + lang + "' and menu_level = '2' and menu_kind = 'M' order by seq";

            try
            {
                con = new MySqlConnection(G.conStr);
                con.Open();

                MySqlDataAdapter adt1 = new MySqlDataAdapter(menuLavel1, con);
                MySqlDataAdapter adt2 = new MySqlDataAdapter(menuLavel2, con);
                MySqlDataAdapter adt3 = new MySqlDataAdapter(menuLavel3, con);
                MySqlDataAdapter adt_adm1 = new MySqlDataAdapter(adminMenu1, con);
                MySqlDataAdapter adt_adm2 = new MySqlDataAdapter(adminMenu2, con);

                DataSet ds = new DataSet();
                adt1.Fill(ds, "menuLavel1");
                adt2.Fill(ds, "menuLavel2");
                adt3.Fill(ds, "menuLavel3");
                adt_adm1.Fill(ds, "adminMenu1");
                adt_adm2.Fill(ds, "adminMenu2");

                ds.Relations.Add("refer1", ds.Tables["menuLavel1"].Columns["menu_id"], ds.Tables["menuLavel2"].Columns["upmenu_id"]);
                ds.Relations.Add("refer2", ds.Tables["menuLavel2"].Columns["menu_id"], ds.Tables["menuLavel3"].Columns["upmenu_id"]);
                ds.Relations.Add("refer3", ds.Tables["adminMenu1"].Columns["menu_id"], ds.Tables["adminMenu2"].Columns["upmenu_id"]);


                tvMenu.Nodes.Clear();
                //rootNode = new TreeNode("MES...");
                //tvMenu.Nodes.Add(rootNode);

                foreach (DataRow masterRow in ds.Tables["menuLavel1"].Rows)
                {
                    TreeNode masterNode = new TreeNode((string)masterRow["menu_name"]);
                    //masterNode.Name = (string)masterRow["menu_pgid"];
                    masterNode.ForeColor = Color.Lime;

                    ToolStripMenuItem itemMenu = new ToolStripMenuItem((string)masterRow["menu_name"]);

                    foreach (DataRow childRow1 in masterRow.GetChildRows("refer1"))
                    {
                        TreeNode childNode1 = new TreeNode("■ " + childRow1["menu_name"].ToString());
                        ToolStripItem childMenu1 = itemMenu.DropDownItems.Add(childRow1["menu_name"].ToString());
                        childMenu1.Name = childRow1["menu_pgid"].ToString();
                        childMenu1.Click += new EventHandler(MenuItemClick);

                        if (childRow1["menu_autho"].ToString() == "0")
                        {
                            childNode1.ForeColor = Color.Silver;
                            childMenu1.Enabled = false;
                        }
                        else
                            childNode1.Name = childRow1["menu_pgid"].ToString();


                        foreach (DataRow childRow2 in masterRow.GetChildRows("refer2"))
                        {
                            TreeNode childNode2 = new TreeNode(childRow2["menu_name"].ToString());

                            if (childRow2["menu_autho"].ToString() == "0")
                                childNode2.ForeColor = Color.Silver;
                            else
                                childNode2.Name = childRow2["menu_pgid"].ToString();

                            masterNode.Nodes.Add(childNode2);
                        }

                        masterNode.Nodes.Add(childNode1);
                    }

                    //rootNode.Nodes.Add(masterNode);
                    tvMenu.Nodes.Add(masterNode);
                    menuStrip1.Items.Add(itemMenu);

                    //if (!(masterNode.Text.Substring(0, 1) == "A" || masterNode.Text.Substring(0, 1) == "G"))
                    if (!(masterNode.Text.Substring(0, 1) == "A"))
                        masterNode.ExpandAll();
                }


                //Admin, 관리자 계정이면 관리자 메뉴 추가
                if (G.Authority == "A" || G.Authority == "B")
                {
                    foreach (DataRow adminRow in ds.Tables["adminMenu1"].Rows)
                    {
                        TreeNode adminNode = new TreeNode((string)adminRow["menu_name"]);
                        //adminNode.Name = (string)adminRow["menu_pgid"];
                        adminNode.ForeColor = Color.Lime;

                        ToolStripMenuItem adminMenu = new ToolStripMenuItem((string)adminRow["menu_name"]);

                        foreach (DataRow childRow3 in adminRow.GetChildRows("refer3"))
                        {
                            TreeNode childNode3 = new TreeNode("■ " + childRow3["menu_name"].ToString());
                            childNode3.Name = childRow3["menu_pgid"].ToString();
                            adminNode.Nodes.Add(childNode3);

                            ToolStripItem childMenu3 = adminMenu.DropDownItems.Add(childRow3["menu_name"].ToString());
                            childMenu3.Name = childRow3["menu_pgid"].ToString();
                            childMenu3.Click += new EventHandler(MenuItemClick);
                        }

                        //rootNode.Nodes.Add(adminNode);
                        tvMenu.Nodes.Add(adminNode);
                        menuStrip1.Items.Add(adminMenu);
                        //adminNode.ExpandAll();
                    }
                }

                TreeNode exitAppNode = new TreeNode("MES종료");
                exitAppNode.ForeColor = Color.Navy;
                tvMenu.Nodes.Add(exitAppNode);
                //rootNode.Nodes.Add(exitAppNode);
                //rootNode.ExpandAll();

                ToolStripMenuItem exitAppMenu = new ToolStripMenuItem("MES종료");
                exitAppMenu.ForeColor = Color.Navy;
                exitAppMenu.Click += new EventHandler(MenuItemClick);
                menuStrip1.Items.Add(exitAppMenu);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        // 자식 폼 중복 여부
        private bool formIsExist(Type tp)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == tp)
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }

        //트리뷰 이벤트
        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Text == "MES종료")
                {
                    Application.Exit();
                    return;
                }

                string sName = e.Node.Name;
                if (string.IsNullOrEmpty(sName)) return;

                string sNameSpace = "SmartMES_Bluewings." + sName;

                Type type = Type.GetType(sNameSpace);
                var varFormInstance = Activator.CreateInstance(type) as Form;

                Form form = varFormInstance;

                if (formIsExist(form.GetType()))
                {
                    form.Dispose();
                }
                else
                {
                    form.MdiParent = this;
                    form.Dock = DockStyle.Fill;
                    form.Show();
                }

                //tvMenu.SelectedNode = rootNode;
                tvMenu.SelectedNode = tvMenu.SelectedNode.Parent;
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        //메뉴 이벤트
        private void MenuItemClick(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

                if (clickedItem.Text == "MES종료")
                {
                    Application.Exit();
                    return;
                }

                string sName = clickedItem.Name;
                if (string.IsNullOrEmpty(sName)) return;

                string sNameSpace = "SmartMES_Bluewings." + sName;

                Type type = Type.GetType(sNameSpace);
                var varFormInstance = Activator.CreateInstance(type) as Form;
                Form form = varFormInstance;

                if (formIsExist(form.GetType()))
                {
                    form.Dispose();
                }
                else
                {
                    form.MdiParent = this;
                    form.Dock = DockStyle.Fill;
                    form.Show();
                }
            }
            catch (ArgumentNullException)
            {
                return;
            }
        }

        private async void MDIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            (new MariaCRUD()).TransLogCreate(G.Authority, G.UserID, "O", "MDIForm", "Logout", "로그아웃");
            await Logger.ApiLog(G.UserID, "로그아웃", ActionType.종료, "");
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            string sql = "select homepage from tb_sys_pos where pos = '" + G.Pos + "'";

            MariaCRUD m = new MariaCRUD();
            string msg = string.Empty;
            string url = m.dbRonlyOne(sql, ref msg).ToString();

            if (msg == "OK" && !string.IsNullOrEmpty(url))
            {
                if (!url.Contains("http")) url = "http://" + url;
                System.Diagnostics.Process.Start(url);
            }
        }

        //공지사항
        private void Notify()
        {
            MariaCRUD m = new MariaCRUD();
            string sql = @"select subject, contents from tb_sys_notify where noti_flag = 1 order by noti_dt desc limit 1";
            string msg = string.Empty;
            DataTable table = m.dbDataTable(sql, ref msg);

            if (msg != "OK") return;

            DataRow[] row = table.Select();

            if (row.Length > 0)
            {
                string curDT = string.Empty;
                if (ReadRegistry(ref curDT))
                {
                    if (curDT == DateTime.Today.ToString("yyyy-MM-dd")) return;
                }

                FormNotify sub = new FormNotify();
                sub.lblSubject.Text = row[0][0].ToString();
                sub.tbContents.Text = row[0][1].ToString();
                sub.ShowDialog();
            }
        }
        public bool ReadRegistry(ref string curDT)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("SoftWare").CreateSubKey("notify");

            curDT = reg.GetValue("curDT", "").ToString();

            if (string.IsNullOrEmpty(curDT))
                return false;
            else
                return true;
        }
    }
}

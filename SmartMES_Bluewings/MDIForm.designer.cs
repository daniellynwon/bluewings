namespace SmartMES_Bluewings
{
    partial class MDIForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1167, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tvMenu);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 574);
            this.panel1.TabIndex = 2;
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tvMenu.ForeColor = System.Drawing.Color.White;
            this.tvMenu.Location = new System.Drawing.Point(0, 58);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.ShowLines = false;
            this.tvMenu.Size = new System.Drawing.Size(210, 516);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterSelect);
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::SmartMES_Bluewings.Properties.Resources.ComLogo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(210, 58);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MDIForm";
            this.Text = "Smart Factory MES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIForm_FormClosing);
            this.Load += new System.EventHandler(this.MDIForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TreeView tvMenu;
        public System.Windows.Forms.Panel panel1;
    }
}


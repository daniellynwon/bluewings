namespace SmartMES_Bluewings
{
    partial class FormBasic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFormID = new System.Windows.Forms.Label();
            this.panButtonBar = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.panButtonBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormID
            // 
            this.lblFormID.AutoSize = true;
            this.lblFormID.BackColor = System.Drawing.Color.Transparent;
            this.lblFormID.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFormID.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFormID.Location = new System.Drawing.Point(1570, 3);
            this.lblFormID.Name = "lblFormID";
            this.lblFormID.Size = new System.Drawing.Size(44, 13);
            this.lblFormID.TabIndex = 0;
            this.lblFormID.Text = "FormID";
            this.lblFormID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panButtonBar
            // 
            this.panButtonBar.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.buttonbar;
            this.panButtonBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panButtonBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panButtonBar.Controls.Add(this.lbVersion);
            this.panButtonBar.Controls.Add(this.lblFormID);
            this.panButtonBar.Controls.Add(this.lblUser);
            this.panButtonBar.Controls.Add(this.pbClose);
            this.panButtonBar.Controls.Add(this.pbPrint);
            this.panButtonBar.Controls.Add(this.pbSave);
            this.panButtonBar.Controls.Add(this.pbDel);
            this.panButtonBar.Controls.Add(this.pbAdd);
            this.panButtonBar.Controls.Add(this.pbSearch);
            this.panButtonBar.Controls.Add(this.lblTitle);
            this.panButtonBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panButtonBar.Location = new System.Drawing.Point(0, 0);
            this.panButtonBar.Name = "panButtonBar";
            this.panButtonBar.Size = new System.Drawing.Size(1325, 56);
            this.panButtonBar.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(857, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(290, 18);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "OOO님께서 업무 중 입니다.";
            // 
            // pbClose
            // 
            this.pbClose.Image = global::SmartMES_Bluewings.Properties.Resources.exit_A;
            this.pbClose.Location = new System.Drawing.Point(709, 11);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(55, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbClose.TabIndex = 6;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            this.pbClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
            // 
            // pbPrint
            // 
            this.pbPrint.Enabled = false;
            this.pbPrint.Image = global::SmartMES_Bluewings.Properties.Resources.out_B;
            this.pbPrint.Location = new System.Drawing.Point(637, 11);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(55, 30);
            this.pbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPrint.TabIndex = 5;
            this.pbPrint.TabStop = false;
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            this.pbPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            this.pbPrint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
            // 
            // pbSave
            // 
            this.pbSave.Enabled = false;
            this.pbSave.Image = global::SmartMES_Bluewings.Properties.Resources.save_B;
            this.pbSave.Location = new System.Drawing.Point(565, 11);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(55, 30);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSave.TabIndex = 4;
            this.pbSave.TabStop = false;
            this.pbSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            this.pbSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
            // 
            // pbDel
            // 
            this.pbDel.Image = global::SmartMES_Bluewings.Properties.Resources.del_A;
            this.pbDel.Location = new System.Drawing.Point(493, 11);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(55, 30);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDel.TabIndex = 3;
            this.pbDel.TabStop = false;
            this.pbDel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            this.pbDel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::SmartMES_Bluewings.Properties.Resources.add_A;
            this.pbAdd.Location = new System.Drawing.Point(421, 11);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(55, 30);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAdd.TabIndex = 2;
            this.pbAdd.TabStop = false;
            this.pbAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            this.pbAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
            // 
            // pbSearch
            // 
            this.pbSearch.Image = global::SmartMES_Bluewings.Properties.Resources.sear_A;
            this.pbSearch.Location = new System.Drawing.Point(349, 11);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(55, 30);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSearch.TabIndex = 1;
            this.pbSearch.TabStop = false;
            this.pbSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            this.pbSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitle.Location = new System.Drawing.Point(38, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "프로그램명";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.ForeColor = System.Drawing.Color.White;
            this.lbVersion.Location = new System.Drawing.Point(1208, 21);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(63, 21);
            this.lbVersion.TabIndex = 7;
            this.lbVersion.Text = "version";
            // 
            // FormBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.ControlBox = false;
            this.Controls.Add(this.panButtonBar);
            this.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBasic";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormBasic";
            this.Load += new System.EventHandler(this.FormBasic_Load);
            this.panButtonBar.ResumeLayout(false);
            this.panButtonBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox pbPrint;
        public System.Windows.Forms.PictureBox pbSave;
        public System.Windows.Forms.PictureBox pbDel;
        public System.Windows.Forms.PictureBox pbAdd;
        public System.Windows.Forms.PictureBox pbSearch;
        public System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panButtonBar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblFormID;
        private System.Windows.Forms.Label lbVersion;
    }
}
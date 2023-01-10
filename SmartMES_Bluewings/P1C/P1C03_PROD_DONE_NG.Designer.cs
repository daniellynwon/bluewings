namespace SmartMES_Bluewings
{
    partial class P1C03_PROD_DONE_NG
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
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lbNgList = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPlus = new System.Windows.Forms.Label();
            this.lbMinus = new System.Windows.Forms.Label();
            this.panTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.photo_background;
            this.panTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(540, 54);
            this.panTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "불량보고";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(28, 73);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // lbNgList
            // 
            this.lbNgList.FormattingEnabled = true;
            this.lbNgList.ItemHeight = 21;
            this.lbNgList.Location = new System.Drawing.Point(32, 111);
            this.lbNgList.Name = "lbNgList";
            this.lbNgList.Size = new System.Drawing.Size(235, 361);
            this.lbNgList.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::SmartMES_Bluewings.Properties.Resources.saveng;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(316, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 95);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "불량 등록";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::SmartMES_Bluewings.Properties.Resources.PowerOff1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(316, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 95);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "닫 기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.tbQty.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbQty.Location = new System.Drawing.Point(366, 149);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(94, 32);
            this.tbQty.TabIndex = 2;
            this.tbQty.Text = "1";
            this.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(376, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "불량수량";
            // 
            // lbPlus
            // 
            this.lbPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPlus.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lbPlus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbPlus.Location = new System.Drawing.Point(466, 143);
            this.lbPlus.Name = "lbPlus";
            this.lbPlus.Size = new System.Drawing.Size(45, 45);
            this.lbPlus.TabIndex = 0;
            this.lbPlus.Text = "+";
            this.lbPlus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPlus.Click += new System.EventHandler(this.lbPlus_Click);
            // 
            // lbMinus
            // 
            this.lbMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMinus.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.lbMinus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbMinus.Location = new System.Drawing.Point(316, 143);
            this.lbMinus.Name = "lbMinus";
            this.lbMinus.Size = new System.Drawing.Size(45, 45);
            this.lbMinus.TabIndex = 0;
            this.lbMinus.Text = "-";
            this.lbMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbMinus.Click += new System.EventHandler(this.lbMinus_Click);
            // 
            // P1C03_PROD_DONE_NG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(540, 508);
            this.Controls.Add(this.lbMinus);
            this.Controls.Add(this.lbPlus);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbNgList);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1C03_PROD_DONE_NG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1C03_PROD_DONE_NG_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ListBox lbNgList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPlus;
        private System.Windows.Forms.Label lbMinus;
    }
}
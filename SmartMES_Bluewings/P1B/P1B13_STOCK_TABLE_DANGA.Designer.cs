namespace SmartMES_Bluewings
{
    partial class P1B13_STOCK_TABLE_DANGA
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbDanga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProd = new System.Windows.Forms.TextBox();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.tbCode = new System.Windows.Forms.TextBox();
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
            this.panTitle.Size = new System.Drawing.Size(530, 54);
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
            this.lblTitle.Text = "재고단가";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(73, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "품 목 명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(73, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목코드";
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
            // tbDanga
            // 
            this.tbDanga.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbDanga.Location = new System.Drawing.Point(156, 318);
            this.tbDanga.Name = "tbDanga";
            this.tbDanga.Size = new System.Drawing.Size(266, 29);
            this.tbDanga.TabIndex = 1;
            this.tbDanga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDanga.TextChanged += new System.EventHandler(this.tbDanga_TextChanged);
            this.tbDanga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbDanga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(73, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "재고단가";
            // 
            // tbProd
            // 
            this.tbProd.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbProd.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbProd.Location = new System.Drawing.Point(156, 230);
            this.tbProd.Name = "tbProd";
            this.tbProd.ReadOnly = true;
            this.tbProd.Size = new System.Drawing.Size(266, 29);
            this.tbProd.TabIndex = 0;
            this.tbProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(292, 414);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.buttonImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(136, 414);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbCode
            // 
            this.tbCode.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCode.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbCode.Location = new System.Drawing.Point(156, 142);
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.Size = new System.Drawing.Size(266, 29);
            this.tbCode.TabIndex = 0;
            this.tbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P1B13_STOCK_TABLE_DANGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(530, 489);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDanga);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1B13_STOCK_TABLE_DANGA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "재고집계표";
            this.Load += new System.EventHandler(this.P1B13_STOCK_TABLE_DANGA_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        private System.Windows.Forms.TextBox tbDanga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.TextBox tbCode;
    }
}
namespace SmartMES_Bluewings
{
    partial class P1A02_PRODUCT_SUB
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
            this.cbGubun = new System.Windows.Forms.ComboBox();
            this.tbUnitSub = new System.Windows.Forms.TextBox();
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.ckbUseFlag = new System.Windows.Forms.CheckBox();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbStockFlag = new System.Windows.Forms.CheckBox();
            this.cbKind = new System.Windows.Forms.ComboBox();
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
            this.panTitle.Size = new System.Drawing.Size(629, 54);
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
            this.lblTitle.Text = "품목정보";
            // 
            // cbGubun
            // 
            this.cbGubun.BackColor = System.Drawing.SystemColors.Window;
            this.cbGubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGubun.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbGubun.FormattingEnabled = true;
            this.cbGubun.Items.AddRange(new object[] {
            "A.제품",
            "B.원/부자재",
            "Z.기타"});
            this.cbGubun.Location = new System.Drawing.Point(185, 136);
            this.cbGubun.Name = "cbGubun";
            this.cbGubun.Size = new System.Drawing.Size(322, 29);
            this.cbGubun.TabIndex = 1;
            this.cbGubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbUnitSub
            // 
            this.tbUnitSub.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbUnitSub.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbUnitSub.Location = new System.Drawing.Point(408, 421);
            this.tbUnitSub.Name = "tbUnitSub";
            this.tbUnitSub.Size = new System.Drawing.Size(99, 29);
            this.tbUnitSub.TabIndex = 6;
            this.tbUnitSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUnitSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbProdName
            // 
            this.tbProdName.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbProdName.Location = new System.Drawing.Point(185, 278);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(322, 29);
            this.tbProdName.TabIndex = 3;
            this.tbProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(104, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "분 류";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(104, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목구분";
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
            // ckbUseFlag
            // 
            this.ckbUseFlag.AutoSize = true;
            this.ckbUseFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ckbUseFlag.Location = new System.Drawing.Point(392, 483);
            this.ckbUseFlag.Name = "ckbUseFlag";
            this.ckbUseFlag.Size = new System.Drawing.Size(115, 25);
            this.ckbUseFlag.TabIndex = 8;
            this.ckbUseFlag.Text = "미사용 코드";
            this.ckbUseFlag.UseVisualStyleBackColor = true;
            // 
            // tbUnit
            // 
            this.tbUnit.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbUnit.Location = new System.Drawing.Point(185, 420);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(113, 29);
            this.tbUnit.TabIndex = 5;
            this.tbUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(104, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "규 격";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(104, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "단 위";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(104, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "품목명";
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbSize.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbSize.Location = new System.Drawing.Point(185, 349);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(322, 29);
            this.tbSize.TabIndex = 4;
            this.tbSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(341, 572);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.buttonImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(185, 572);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 9;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(337, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "(부)단위";
            // 
            // ckbStockFlag
            // 
            this.ckbStockFlag.AutoSize = true;
            this.ckbStockFlag.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ckbStockFlag.Location = new System.Drawing.Point(185, 483);
            this.ckbStockFlag.Name = "ckbStockFlag";
            this.ckbStockFlag.Size = new System.Drawing.Size(125, 25);
            this.ckbStockFlag.TabIndex = 7;
            this.ckbStockFlag.Text = "재고대상아님";
            this.ckbStockFlag.UseVisualStyleBackColor = true;
            // 
            // cbKind
            // 
            this.cbKind.BackColor = System.Drawing.SystemColors.Window;
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Items.AddRange(new object[] {
            "1.매출처",
            "2.매입처",
            "3.공통"});
            this.cbKind.Location = new System.Drawing.Point(185, 207);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(322, 29);
            this.cbKind.TabIndex = 2;
            this.cbKind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // P1A02_PRODUCT_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(629, 646);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.ckbStockFlag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ckbUseFlag);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbGubun);
            this.Controls.Add(this.tbUnitSub);
            this.Controls.Add(this.tbProdName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1A02_PRODUCT_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1A02_PRODUCT_SUB_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbGubun;
        private System.Windows.Forms.TextBox tbUnitSub;
        private System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        private System.Windows.Forms.CheckBox ckbUseFlag;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbStockFlag;
        private System.Windows.Forms.ComboBox cbKind;
    }
}
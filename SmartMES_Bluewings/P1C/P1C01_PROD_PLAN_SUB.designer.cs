namespace SmartMES_Bluewings
{
    partial class P1C01_PROD_PLAN_SUB
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbProdQty = new System.Windows.Forms.TextBox();
            this.tbSaleQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHo = new System.Windows.Forms.Label();
            this.tbPlanDate = new System.Windows.Forms.TextBox();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(28, 73);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(156, 23);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(85, 489);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "업무내용";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(85, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "제 품 명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(85, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "계획일자";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.photo_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 54);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "생산계획";
            // 
            // tbContents
            // 
            this.tbContents.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbContents.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbContents.Location = new System.Drawing.Point(166, 484);
            this.tbContents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbContents.Name = "tbContents";
            this.tbContents.Size = new System.Drawing.Size(343, 29);
            this.tbContents.TabIndex = 3;
            this.tbContents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbContents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(344, 596);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 35;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.buttonImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(175, 596);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 34;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbProdQty);
            this.groupBox1.Controls.Add(this.tbSaleQty);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblHo);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(57, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "계획수량";
            // 
            // tbProdQty
            // 
            this.tbProdQty.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbProdQty.Location = new System.Drawing.Point(339, 59);
            this.tbProdQty.Name = "tbProdQty";
            this.tbProdQty.Size = new System.Drawing.Size(113, 29);
            this.tbProdQty.TabIndex = 2;
            this.tbProdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbProdQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbProdQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tbSaleQty
            // 
            this.tbSaleQty.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbSaleQty.Location = new System.Drawing.Point(109, 59);
            this.tbSaleQty.Name = "tbSaleQty";
            this.tbSaleQty.Size = new System.Drawing.Size(113, 29);
            this.tbSaleQty.TabIndex = 1;
            this.tbSaleQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSaleQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbSaleQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(287, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "생 산";
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblHo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHo.Location = new System.Drawing.Point(57, 63);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(48, 21);
            this.lblHo.TabIndex = 0;
            this.lblHo.Text = "판 매";
            // 
            // tbPlanDate
            // 
            this.tbPlanDate.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbPlanDate.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbPlanDate.Location = new System.Drawing.Point(166, 180);
            this.tbPlanDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbPlanDate.Name = "tbPlanDate";
            this.tbPlanDate.ReadOnly = true;
            this.tbPlanDate.Size = new System.Drawing.Size(343, 29);
            this.tbPlanDate.TabIndex = 0;
            this.tbPlanDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProduct
            // 
            this.tbProduct.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbProduct.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbProduct.Location = new System.Drawing.Point(166, 238);
            this.tbProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.ReadOnly = true;
            this.tbProduct.Size = new System.Drawing.Size(343, 29);
            this.tbProduct.TabIndex = 0;
            this.tbProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P1C01_PROD_PLAN_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(629, 665);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.tbPlanDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1C01_PROD_PLAN_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1C01_PROD_PLAN_SUB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbContents;
        private UserButtonA btnClose;
        private UserButtonA btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHo;
        public System.Windows.Forms.TextBox tbPlanDate;
        public System.Windows.Forms.TextBox tbProduct;
        public System.Windows.Forms.TextBox tbProdQty;
        public System.Windows.Forms.TextBox tbSaleQty;
    }
}
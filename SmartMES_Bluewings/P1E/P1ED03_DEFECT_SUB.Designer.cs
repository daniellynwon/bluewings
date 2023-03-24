namespace SmartMES_Bluewings
{
    partial class P1ED03_DEFECT_SUB
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
            this.tbDanga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.dtpPutchDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCust = new System.Windows.Forms.TextBox();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbProd = new System.Windows.Forms.TextBox();
            this.tbKg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
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
            this.panTitle.Size = new System.Drawing.Size(746, 54);
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
            this.lblTitle.Size = new System.Drawing.Size(102, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "불량품발주";
            // 
            // tbDanga
            // 
            this.tbDanga.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbDanga.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbDanga.Location = new System.Drawing.Point(483, 289);
            this.tbDanga.Name = "tbDanga";
            this.tbDanga.Size = new System.Drawing.Size(211, 29);
            this.tbDanga.TabIndex = 12;
            this.tbDanga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDanga.Visible = false;
            this.tbDanga.TextChanged += new System.EventHandler(this.tbDanga_TextChanged);
            this.tbDanga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbDanga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(406, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "발주일자";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(406, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "규 격";
            this.label10.Visible = false;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblCost.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCost.Location = new System.Drawing.Point(406, 293);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(48, 21);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "단 가";
            this.lblCost.Visible = false;
            // 
            // dtpPutchDate
            // 
            this.dtpPutchDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpPutchDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpPutchDate.Location = new System.Drawing.Point(483, 139);
            this.dtpPutchDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPutchDate.Name = "dtpPutchDate";
            this.dtpPutchDate.Size = new System.Drawing.Size(211, 29);
            this.dtpPutchDate.TabIndex = 4;
            this.dtpPutchDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(51, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "No.";
            // 
            // tbNo
            // 
            this.tbNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbNo.ForeColor = System.Drawing.Color.Blue;
            this.tbNo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbNo.Location = new System.Drawing.Point(128, 139);
            this.tbNo.Name = "tbNo";
            this.tbNo.ReadOnly = true;
            this.tbNo.Size = new System.Drawing.Size(211, 29);
            this.tbNo.TabIndex = 1;
            this.tbNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpRequestDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpRequestDate.Location = new System.Drawing.Point(483, 206);
            this.dtpRequestDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(211, 29);
            this.dtpRequestDate.TabIndex = 7;
            this.dtpRequestDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(406, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "입고요청";
            // 
            // tbCust
            // 
            this.tbCust.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCust.Location = new System.Drawing.Point(128, 206);
            this.tbCust.Name = "tbCust";
            this.tbCust.ReadOnly = true;
            this.tbCust.Size = new System.Drawing.Size(211, 29);
            this.tbCust.TabIndex = 3;
            this.tbCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCust.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblCust.ForeColor = System.Drawing.Color.Blue;
            this.lblCust.Location = new System.Drawing.Point(51, 210);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(70, 21);
            this.lblCust.TabIndex = 2;
            this.lblCust.Text = "발 주 처";
            this.lblCust.Click += new System.EventHandler(this.lblCust_Click);
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblProd.ForeColor = System.Drawing.Color.Blue;
            this.lblProd.Location = new System.Drawing.Point(51, 293);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(70, 21);
            this.lblProd.TabIndex = 8;
            this.lblProd.Text = "자 재 명";
            this.lblProd.Click += new System.EventHandler(this.lblProd_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblQty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQty.Location = new System.Drawing.Point(51, 361);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(74, 21);
            this.lblQty.TabIndex = 0;
            this.lblQty.Text = "발주중량";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(406, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "금 액";
            // 
            // tbMoney
            // 
            this.tbMoney.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbMoney.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbMoney.Location = new System.Drawing.Point(483, 357);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.ReadOnly = true;
            this.tbMoney.Size = new System.Drawing.Size(211, 29);
            this.tbMoney.TabIndex = 14;
            this.tbMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbSize.Location = new System.Drawing.Point(483, 424);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(211, 29);
            this.tbSize.TabIndex = 11;
            this.tbSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSize.Visible = false;
            this.tbSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbProd
            // 
            this.tbProd.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbProd.Location = new System.Drawing.Point(125, 289);
            this.tbProd.Name = "tbProd";
            this.tbProd.ReadOnly = true;
            this.tbProd.Size = new System.Drawing.Size(211, 29);
            this.tbProd.TabIndex = 9;
            this.tbProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbKg
            // 
            this.tbKg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbKg.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbKg.Location = new System.Drawing.Point(125, 357);
            this.tbKg.Name = "tbKg";
            this.tbKg.Size = new System.Drawing.Size(211, 29);
            this.tbKg.TabIndex = 10;
            this.tbKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbKg.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbKg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(479, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "자재단가표";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.lblCost_Click);
            // 
            // tbWeight
            // 
            this.tbWeight.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbWeight.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbWeight.Location = new System.Drawing.Point(125, 424);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(211, 29);
            this.tbWeight.TabIndex = 34;
            this.tbWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbWeight.Visible = false;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWeight.Location = new System.Drawing.Point(69, 377);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(38, 21);
            this.lblWeight.TabIndex = 33;
            this.lblWeight.Text = "(kg)";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(398, 550);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 31;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.buttonImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(242, 550);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 30;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // P1ED03_DEFECT_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(746, 615);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKg);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.tbProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.tbCust);
            this.Controls.Add(this.dtpRequestDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.dtpPutchDate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDanga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1ED03_DEFECT_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1ED03_DEFECT_SUB_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbDanga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.DateTimePicker dtpPutchDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCust;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblQty;
        public System.Windows.Forms.Label lblWeight;
        public System.Windows.Forms.TextBox tbWeight;
        public System.Windows.Forms.TextBox tbKg;
    }
}
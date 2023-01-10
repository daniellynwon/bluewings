namespace SmartMES_Bluewings
{
    partial class P1C03_PROD_DONE_SUB
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
            this.lblProc = new System.Windows.Forms.Label();
            this.tbSumQty = new System.Windows.Forms.TextBox();
            this.tbNgQty = new System.Windows.Forms.TextBox();
            this.tbGdQty = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbProd = new System.Windows.Forms.TextBox();
            this.tbJobNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNg = new System.Windows.Forms.Button();
            this.tbMachine = new System.Windows.Forms.TextBox();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.panTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panTitle.Size = new System.Drawing.Size(775, 54);
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
            this.lblTitle.Size = new System.Drawing.Size(130, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "생산실적[수정]";
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
            // lblProc
            // 
            this.lblProc.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProc.ForeColor = System.Drawing.Color.Black;
            this.lblProc.Location = new System.Drawing.Point(460, 133);
            this.lblProc.Name = "lblProc";
            this.lblProc.Size = new System.Drawing.Size(234, 21);
            this.lblProc.TabIndex = 31;
            this.lblProc.Text = "CNC";
            this.lblProc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSumQty
            // 
            this.tbSumQty.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbSumQty.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbSumQty.Location = new System.Drawing.Point(144, 486);
            this.tbSumQty.Name = "tbSumQty";
            this.tbSumQty.ReadOnly = true;
            this.tbSumQty.Size = new System.Drawing.Size(262, 29);
            this.tbSumQty.TabIndex = 29;
            this.tbSumQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNgQty
            // 
            this.tbNgQty.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbNgQty.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbNgQty.Location = new System.Drawing.Point(320, 435);
            this.tbNgQty.Name = "tbNgQty";
            this.tbNgQty.ReadOnly = true;
            this.tbNgQty.Size = new System.Drawing.Size(86, 29);
            this.tbNgQty.TabIndex = 28;
            this.tbNgQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbGdQty
            // 
            this.tbGdQty.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbGdQty.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbGdQty.Location = new System.Drawing.Point(144, 435);
            this.tbGdQty.Name = "tbGdQty";
            this.tbGdQty.Size = new System.Drawing.Size(86, 29);
            this.tbGdQty.TabIndex = 27;
            this.tbGdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGdQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbGdQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbSize.Location = new System.Drawing.Point(144, 384);
            this.tbSize.Name = "tbSize";
            this.tbSize.ReadOnly = true;
            this.tbSize.Size = new System.Drawing.Size(262, 29);
            this.tbSize.TabIndex = 26;
            this.tbSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbName.Location = new System.Drawing.Point(144, 333);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(262, 29);
            this.tbName.TabIndex = 25;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbProd
            // 
            this.tbProd.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbProd.Location = new System.Drawing.Point(144, 282);
            this.tbProd.Name = "tbProd";
            this.tbProd.ReadOnly = true;
            this.tbProd.Size = new System.Drawing.Size(262, 29);
            this.tbProd.TabIndex = 24;
            this.tbProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbJobNo
            // 
            this.tbJobNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbJobNo.Location = new System.Drawing.Point(144, 129);
            this.tbJobNo.Name = "tbJobNo";
            this.tbJobNo.ReadOnly = true;
            this.tbJobNo.Size = new System.Drawing.Size(262, 29);
            this.tbJobNo.TabIndex = 23;
            this.tbJobNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDate2);
            this.groupBox1.Controls.Add(this.dtpDate1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(446, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 237);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // dtpDate2
            // 
            this.dtpDate2.CalendarFont = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDate2.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.dtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate2.Location = new System.Drawing.Point(16, 180);
            this.dtpDate2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(224, 33);
            this.dtpDate2.TabIndex = 4;
            // 
            // dtpDate1
            // 
            this.dtpDate1.CalendarFont = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDate1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate1.Location = new System.Drawing.Point(16, 65);
            this.dtpDate1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(224, 33);
            this.dtpDate1.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(16, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "작업시작시간";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(16, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "작업종료시간";
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(144, 231);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(262, 29);
            this.cbUser.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(66, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 19;
            this.label14.Text = "생산합계";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(242, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "불량수량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(66, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "양품수량";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(66, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "규 격";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(66, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "제품명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(66, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "품목명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(66, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "운전자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(66, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "설비명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(66, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "LotNo.";
            // 
            // btnNg
            // 
            this.btnNg.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.불량보고;
            this.btnNg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNg.Location = new System.Drawing.Point(446, 443);
            this.btnNg.Name = "btnNg";
            this.btnNg.Size = new System.Drawing.Size(262, 72);
            this.btnNg.TabIndex = 32;
            this.btnNg.UseVisualStyleBackColor = true;
            this.btnNg.Click += new System.EventHandler(this.btnNg_Click);
            // 
            // tbMachine
            // 
            this.tbMachine.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbMachine.Location = new System.Drawing.Point(144, 181);
            this.tbMachine.Name = "tbMachine";
            this.tbMachine.ReadOnly = true;
            this.tbMachine.Size = new System.Drawing.Size(262, 29);
            this.tbMachine.TabIndex = 33;
            this.tbMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(415, 570);
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
            this.btnSave.Location = new System.Drawing.Point(259, 570);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // P1C03_PROD_DONE_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(775, 632);
            this.Controls.Add(this.tbMachine);
            this.Controls.Add(this.btnNg);
            this.Controls.Add(this.lblProc);
            this.Controls.Add(this.tbSumQty);
            this.Controls.Add(this.tbNgQty);
            this.Controls.Add(this.tbGdQty);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbProd);
            this.Controls.Add(this.tbJobNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1C03_PROD_DONE_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1C03_PROD_DONE_SUB_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        public System.Windows.Forms.Label lblProc;
        public System.Windows.Forms.TextBox tbSumQty;
        public System.Windows.Forms.TextBox tbNgQty;
        public System.Windows.Forms.TextBox tbGdQty;
        public System.Windows.Forms.TextBox tbSize;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbProd;
        public System.Windows.Forms.TextBox tbJobNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        public System.Windows.Forms.Button btnNg;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        public System.Windows.Forms.TextBox tbMachine;
        public System.Windows.Forms.Label lblMsg;
    }
}
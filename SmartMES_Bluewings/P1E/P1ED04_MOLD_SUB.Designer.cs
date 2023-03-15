namespace SmartMES_Bluewings
{
    partial class P1ED04_MOLD_SUB
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
            this.tbMoneyA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.dtpDateA = new System.Windows.Forms.MaskedTextBox();
            this.doc3 = new SmartMES_Bluewings.UserButtonA();
            this.doc2 = new SmartMES_Bluewings.UserButtonA();
            this.doc1 = new SmartMES_Bluewings.UserButtonA();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHo = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMoneyB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCust = new System.Windows.Forms.TextBox();
            this.lblCust = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLap = new System.Windows.Forms.TextBox();
            this.panTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMoneyA
            // 
            this.tbMoneyA.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbMoneyA.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbMoneyA.Location = new System.Drawing.Point(419, 224);
            this.tbMoneyA.Name = "tbMoneyA";
            this.tbMoneyA.Size = new System.Drawing.Size(211, 29);
            this.tbMoneyA.TabIndex = 3;
            this.tbMoneyA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMoneyA.TextChanged += new System.EventHandler(this.tbMoney_TextChanged);
            this.tbMoneyA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbMoneyA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMoney_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(352, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "상 태";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(28, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "이동시각";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(342, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "제작비용";
            // 
            // cbPlace
            // 
            this.cbPlace.BackColor = System.Drawing.SystemColors.Window;
            this.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlace.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Items.AddRange(new object[] {
            "A.생산",
            "B.대기",
            "C.업체"});
            this.cbPlace.Location = new System.Drawing.Point(105, 223);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(211, 29);
            this.cbPlace.TabIndex = 4;
            // 
            // dtpDateA
            // 
            this.dtpDateA.Location = new System.Drawing.Point(104, 272);
            this.dtpDateA.Mask = "0000-90-90 90:90:90";
            this.dtpDateA.Name = "dtpDateA";
            this.dtpDateA.Size = new System.Drawing.Size(211, 29);
            this.dtpDateA.TabIndex = 6;
            this.dtpDateA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // doc3
            // 
            this.doc3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.doc3.BackColor = System.Drawing.Color.Transparent;
            this.doc3.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.clipA;
            this.doc3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doc3.buttonImage = global::SmartMES_Bluewings.Properties.Resources.clipA;
            this.doc3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doc3.Location = new System.Drawing.Point(566, 373);
            this.doc3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doc3.Name = "doc3";
            this.doc3.Size = new System.Drawing.Size(24, 23);
            this.doc3.TabIndex = 83;
            this.doc3.Visible = false;
            // 
            // doc2
            // 
            this.doc2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.doc2.BackColor = System.Drawing.Color.Transparent;
            this.doc2.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.clipA;
            this.doc2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doc2.buttonImage = global::SmartMES_Bluewings.Properties.Resources.clipA;
            this.doc2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doc2.Location = new System.Drawing.Point(534, 373);
            this.doc2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doc2.Name = "doc2";
            this.doc2.Size = new System.Drawing.Size(24, 23);
            this.doc2.TabIndex = 82;
            this.doc2.Visible = false;
            this.doc2.Click += new System.EventHandler(this.userButtonA2_Click);
            // 
            // doc1
            // 
            this.doc1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.doc1.BackColor = System.Drawing.Color.Transparent;
            this.doc1.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.clipA;
            this.doc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doc1.buttonImage = global::SmartMES_Bluewings.Properties.Resources.clipA;
            this.doc1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.doc1.Location = new System.Drawing.Point(502, 373);
            this.doc1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doc1.Name = "doc1";
            this.doc1.Size = new System.Drawing.Size(24, 23);
            this.doc1.TabIndex = 81;
            this.doc1.Click += new System.EventHandler(this.userButtonA1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(365, 442);
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
            this.btnSave.Location = new System.Drawing.Point(209, 442);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panTitle
            // 
            this.panTitle.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.photo_background;
            this.panTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(653, 54);
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
            this.lblTitle.Text = "금형관리";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbName.Location = new System.Drawing.Point(419, 127);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(211, 29);
            this.tbName.TabIndex = 1;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNo
            // 
            this.tbNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbNo.Location = new System.Drawing.Point(105, 127);
            this.tbNo.Name = "tbNo";
            this.tbNo.ReadOnly = true;
            this.tbNo.Size = new System.Drawing.Size(211, 29);
            this.tbNo.TabIndex = 0;
            this.tbNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(28, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 87;
            this.label6.Text = "보관장소";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(352, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 88;
            this.label7.Text = "금형명";
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblHo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHo.Location = new System.Drawing.Point(28, 131);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(74, 21);
            this.lblHo.TabIndex = 89;
            this.lblHo.Text = "금형코드";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "0.양호",
            "1.수리중"});
            this.cbStatus.Location = new System.Drawing.Point(419, 277);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(211, 29);
            this.cbStatus.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(342, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 90;
            this.label13.Text = "경과시간";
            // 
            // tbMoneyB
            // 
            this.tbMoneyB.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbMoneyB.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbMoneyB.Location = new System.Drawing.Point(104, 324);
            this.tbMoneyB.Name = "tbMoneyB";
            this.tbMoneyB.Size = new System.Drawing.Size(211, 29);
            this.tbMoneyB.TabIndex = 8;
            this.tbMoneyB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMoneyB.TextChanged += new System.EventHandler(this.tbMoney_TextChanged);
            this.tbMoneyB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbMoneyB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMoney_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(28, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "소요비용";
            // 
            // tbCust
            // 
            this.tbCust.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCust.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbCust.Location = new System.Drawing.Point(105, 175);
            this.tbCust.Name = "tbCust";
            this.tbCust.ReadOnly = true;
            this.tbCust.Size = new System.Drawing.Size(211, 29);
            this.tbCust.TabIndex = 93;
            this.tbCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCust
            // 
            this.lblCust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCust.AutoSize = true;
            this.lblCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCust.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblCust.ForeColor = System.Drawing.Color.Blue;
            this.lblCust.Location = new System.Drawing.Point(28, 178);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(74, 21);
            this.lblCust.TabIndex = 94;
            this.lblCust.Text = "거래처명";
            this.lblCust.Click += new System.EventHandler(this.lblCust_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Location = new System.Drawing.Point(419, 69);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(211, 29);
            this.dtpDate.TabIndex = 95;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(344, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 96;
            this.label8.Text = "등록일자";
            // 
            // tbLap
            // 
            this.tbLap.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbLap.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbLap.Location = new System.Drawing.Point(419, 326);
            this.tbLap.Name = "tbLap";
            this.tbLap.Size = new System.Drawing.Size(211, 29);
            this.tbLap.TabIndex = 97;
            this.tbLap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbLap.TextChanged += new System.EventHandler(this.tbMoney_TextChanged);
            this.tbLap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMoney_KeyPress);
            // 
            // P1ED04_MOLD_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(653, 529);
            this.Controls.Add(this.tbLap);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCust);
            this.Controls.Add(this.tbCust);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHo);
            this.Controls.Add(this.doc3);
            this.Controls.Add(this.doc2);
            this.Controls.Add(this.doc1);
            this.Controls.Add(this.dtpDateA);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbMoneyB);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMoneyA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1ED04_MOLD_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1ED04_MOLD_SUB_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbMoneyA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.MaskedTextBox dtpDateA;
        public UserButtonA doc1;
        public UserButtonA doc2;
        public UserButtonA doc3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMoneyB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCust;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLap;
    }
}
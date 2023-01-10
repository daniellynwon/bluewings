namespace SmartMES_Bluewings
{
    partial class P1D03_MAINTENANCE_SUB
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
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.tbGoal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbMan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.dtpDateA = new System.Windows.Forms.MaskedTextBox();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateB = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.panTitle.Size = new System.Drawing.Size(740, 54);
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
            this.lblTitle.Size = new System.Drawing.Size(120, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "설비보전등록";
            // 
            // tbMoney
            // 
            this.tbMoney.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbMoney.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbMoney.Location = new System.Drawing.Point(460, 538);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(211, 29);
            this.tbMoney.TabIndex = 7;
            this.tbMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMoney.TextChanged += new System.EventHandler(this.tbMoney_TextChanged);
            this.tbMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMoney_KeyPress);
            // 
            // tbGoal
            // 
            this.tbGoal.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbGoal.Location = new System.Drawing.Point(146, 382);
            this.tbGoal.Multiline = true;
            this.tbGoal.Name = "tbGoal";
            this.tbGoal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGoal.Size = new System.Drawing.Size(525, 53);
            this.tbGoal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(383, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "점검형태";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(69, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "고장일시";
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
            // tbMan
            // 
            this.tbMan.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbMan.Location = new System.Drawing.Point(146, 537);
            this.tbMan.Name = "tbMan";
            this.tbMan.Size = new System.Drawing.Size(211, 29);
            this.tbMan.TabIndex = 6;
            this.tbMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(69, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "조치결과";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(69, 538);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "점검자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(66, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "내역/목표";
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbResult.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbResult.Location = new System.Drawing.Point(146, 448);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(525, 53);
            this.tbResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(383, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "소요비용";
            // 
            // cbKind
            // 
            this.cbKind.BackColor = System.Drawing.SystemColors.Window;
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Items.AddRange(new object[] {
            "1.예방보전",
            "2.정기보전",
            "3.개량보전",
            "4.사후보전",
            "5.고장등록",
            "6.고장수리",
            "9.기타"});
            this.cbKind.Location = new System.Drawing.Point(460, 268);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(211, 29);
            this.cbKind.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelect);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbHo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblHo);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(32, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSelect.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblSelect.ForeColor = System.Drawing.Color.Blue;
            this.lblSelect.Location = new System.Drawing.Point(34, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(74, 21);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "설비선택";
            this.lblSelect.Click += new System.EventHandler(this.lblSelect_Click);
            // 
            // tbModel
            // 
            this.tbModel.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbModel.Location = new System.Drawing.Point(428, 96);
            this.tbModel.Name = "tbModel";
            this.tbModel.ReadOnly = true;
            this.tbModel.Size = new System.Drawing.Size(211, 29);
            this.tbModel.TabIndex = 0;
            this.tbModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbName.Location = new System.Drawing.Point(114, 96);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(211, 29);
            this.tbName.TabIndex = 0;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHo
            // 
            this.tbHo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbHo.Location = new System.Drawing.Point(114, 53);
            this.tbHo.Name = "tbHo";
            this.tbHo.ReadOnly = true;
            this.tbHo.Size = new System.Drawing.Size(211, 29);
            this.tbHo.TabIndex = 0;
            this.tbHo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(351, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "설비그룹";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(37, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "설비명";
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblHo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHo.Location = new System.Drawing.Point(37, 57);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(48, 21);
            this.lblHo.TabIndex = 0;
            this.lblHo.Text = "호 기";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(33, 556);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "(A/S업체/연락처)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(69, 606);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "비 고";
            // 
            // tbContents
            // 
            this.tbContents.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbContents.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbContents.Location = new System.Drawing.Point(146, 602);
            this.tbContents.Name = "tbContents";
            this.tbContents.Size = new System.Drawing.Size(525, 29);
            this.tbContents.TabIndex = 8;
            this.tbContents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // dtpDateA
            // 
            this.dtpDateA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDateA.Location = new System.Drawing.Point(146, 322);
            this.dtpDateA.Mask = "0000-90-90 90:90:90";
            this.dtpDateA.Name = "dtpDateA";
            this.dtpDateA.Size = new System.Drawing.Size(211, 29);
            this.dtpDateA.TabIndex = 76;
            this.dtpDateA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(398, 675);
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
            this.btnSave.Location = new System.Drawing.Point(242, 675);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Location = new System.Drawing.Point(146, 268);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(211, 29);
            this.dtpDate.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(69, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 77;
            this.label8.Text = "등록일자";
            // 
            // dtpDateB
            // 
            this.dtpDateB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDateB.Location = new System.Drawing.Point(460, 323);
            this.dtpDateB.Mask = "0000-90-90 90:90:90";
            this.dtpDateB.Name = "dtpDateB";
            this.dtpDateB.Size = new System.Drawing.Size(211, 29);
            this.dtpDateB.TabIndex = 80;
            this.dtpDateB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(383, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 79;
            this.label9.Text = "수리일시";
            // 
            // P1D03_MAINTENANCE_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(740, 738);
            this.Controls.Add(this.dtpDateB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDateA);
            this.Controls.Add(this.tbMan);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.tbGoal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1D03_MAINTENANCE_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1D03_MAINTENANCE_SUB_Load);
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
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.TextBox tbGoal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        private System.Windows.Forms.TextBox tbMan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbContents;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.MaskedTextBox dtpDateA;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox dtpDateB;
        private System.Windows.Forms.Label label9;
    }
}
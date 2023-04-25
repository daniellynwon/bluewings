namespace SmartMES_Bluewings
{
    partial class P1ED03_QC_AS_SUB
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
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDeli = new System.Windows.Forms.TextBox();
            this.lblDeliID = new System.Windows.Forms.Label();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.dtpClaimDate = new System.Windows.Forms.DateTimePicker();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.lblHo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClaimContents = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbActionContents = new System.Windows.Forms.TextBox();
            this.dtpActionDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.cbCharge = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbClaim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCause = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbInform = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDeal = new System.Windows.Forms.TextBox();
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
            this.panTitle.Size = new System.Drawing.Size(811, 54);
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
            this.lblTitle.Text = "사후관리";
            // 
            // cbState
            // 
            this.cbState.BackColor = System.Drawing.SystemColors.Window;
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "0.대 기",
            "1.처리중",
            "2.완 료"});
            this.cbState.Location = new System.Drawing.Point(523, 110);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(223, 29);
            this.cbState.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(446, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "진행상태";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(60, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "발생일자";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(28, 63);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbQty.Location = new System.Drawing.Point(523, 164);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(223, 29);
            this.tbQty.TabIndex = 2;
            this.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(446, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "대상수량";
            // 
            // tbDeli
            // 
            this.tbDeli.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbDeli.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbDeli.Location = new System.Drawing.Point(137, 164);
            this.tbDeli.Name = "tbDeli";
            this.tbDeli.ReadOnly = true;
            this.tbDeli.Size = new System.Drawing.Size(223, 29);
            this.tbDeli.TabIndex = 0;
            this.tbDeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDeliID
            // 
            this.lblDeliID.AutoSize = true;
            this.lblDeliID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeliID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblDeliID.ForeColor = System.Drawing.Color.Blue;
            this.lblDeliID.Location = new System.Drawing.Point(18, 168);
            this.lblDeliID.Name = "lblDeliID";
            this.lblDeliID.Size = new System.Drawing.Size(116, 21);
            this.lblDeliID.TabIndex = 0;
            this.lblDeliID.Text = "출하(전표)번호";
            this.lblDeliID.Click += new System.EventHandler(this.lblDeliID_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(435, 660);
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
            this.btnSave.Location = new System.Drawing.Point(279, 660);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpClaimDate
            // 
            this.dtpClaimDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpClaimDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpClaimDate.Location = new System.Drawing.Point(137, 212);
            this.dtpClaimDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpClaimDate.Name = "dtpClaimDate";
            this.dtpClaimDate.Size = new System.Drawing.Size(223, 29);
            this.dtpClaimDate.TabIndex = 3;
            // 
            // tbNo
            // 
            this.tbNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbNo.ForeColor = System.Drawing.Color.Blue;
            this.tbNo.Location = new System.Drawing.Point(137, 110);
            this.tbNo.Name = "tbNo";
            this.tbNo.ReadOnly = true;
            this.tbNo.Size = new System.Drawing.Size(223, 29);
            this.tbNo.TabIndex = 0;
            this.tbNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblHo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHo.Location = new System.Drawing.Point(60, 114);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(74, 21);
            this.lblHo.TabIndex = 0;
            this.lblHo.Text = "접수번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(60, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "발생내역";
            // 
            // tbClaimContents
            // 
            this.tbClaimContents.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbClaimContents.Location = new System.Drawing.Point(64, 278);
            this.tbClaimContents.Multiline = true;
            this.tbClaimContents.Name = "tbClaimContents";
            this.tbClaimContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbClaimContents.Size = new System.Drawing.Size(296, 64);
            this.tbClaimContents.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(446, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "조치내역";
            // 
            // tbActionContents
            // 
            this.tbActionContents.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbActionContents.Location = new System.Drawing.Point(450, 278);
            this.tbActionContents.Multiline = true;
            this.tbActionContents.Name = "tbActionContents";
            this.tbActionContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbActionContents.Size = new System.Drawing.Size(296, 64);
            this.tbActionContents.TabIndex = 6;
            // 
            // dtpActionDate
            // 
            this.dtpActionDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpActionDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpActionDate.Location = new System.Drawing.Point(523, 212);
            this.dtpActionDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpActionDate.Name = "dtpActionDate";
            this.dtpActionDate.Size = new System.Drawing.Size(223, 29);
            this.dtpActionDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(446, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "조치일자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(60, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "처리비용";
            // 
            // tbMoney
            // 
            this.tbMoney.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbMoney.Location = new System.Drawing.Point(137, 586);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(223, 29);
            this.tbMoney.TabIndex = 7;
            this.tbMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMoney.TextChanged += new System.EventHandler(this.tbMoney_TextChanged);
            this.tbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // cbCharge
            // 
            this.cbCharge.BackColor = System.Drawing.SystemColors.Window;
            this.cbCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCharge.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbCharge.FormattingEnabled = true;
            this.cbCharge.Location = new System.Drawing.Point(523, 586);
            this.cbCharge.Name = "cbCharge";
            this.cbCharge.Size = new System.Drawing.Size(223, 29);
            this.cbCharge.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(446, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "책 임 자";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(446, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "고객요구";
            // 
            // tbClaim
            // 
            this.tbClaim.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbClaim.Location = new System.Drawing.Point(450, 379);
            this.tbClaim.Multiline = true;
            this.tbClaim.Name = "tbClaim";
            this.tbClaim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbClaim.Size = new System.Drawing.Size(296, 64);
            this.tbClaim.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(60, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "원인분석";
            // 
            // tbCause
            // 
            this.tbCause.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCause.Location = new System.Drawing.Point(64, 379);
            this.tbCause.Multiline = true;
            this.tbCause.Name = "tbCause";
            this.tbCause.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCause.Size = new System.Drawing.Size(296, 64);
            this.tbCause.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(448, 457);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "고객통지내용";
            // 
            // tbInform
            // 
            this.tbInform.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbInform.Location = new System.Drawing.Point(452, 481);
            this.tbInform.Multiline = true;
            this.tbInform.Name = "tbInform";
            this.tbInform.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInform.Size = new System.Drawing.Size(296, 64);
            this.tbInform.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(62, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "처리방법";
            // 
            // tbDeal
            // 
            this.tbDeal.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbDeal.Location = new System.Drawing.Point(66, 481);
            this.tbDeal.Multiline = true;
            this.tbDeal.Name = "tbDeal";
            this.tbDeal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDeal.Size = new System.Drawing.Size(296, 64);
            this.tbDeal.TabIndex = 18;
            // 
            // P1ED03_QC_AS_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(811, 698);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbInform);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbDeal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbClaim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbCause);
            this.Controls.Add(this.cbCharge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbActionContents);
            this.Controls.Add(this.dtpActionDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClaimContents);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.lblHo);
            this.Controls.Add(this.dtpClaimDate);
            this.Controls.Add(this.lblDeliID);
            this.Controls.Add(this.tbDeli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1ED03_QC_AS_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1ED03_QC_AS_SUB_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDeli;
        private System.Windows.Forms.Label lblDeliID;
        private System.Windows.Forms.DateTimePicker dtpClaimDate;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClaimContents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbActionContents;
        private System.Windows.Forms.DateTimePicker dtpActionDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.ComboBox cbCharge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbClaim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCause;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbInform;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDeal;
    }
}
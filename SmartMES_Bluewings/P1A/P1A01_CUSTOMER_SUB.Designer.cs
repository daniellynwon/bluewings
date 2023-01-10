namespace SmartMES_Bluewings
{
    partial class P1A01_CUSTOMER_SUB
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
            this.tbFax = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbCeo = new System.Windows.Forms.TextBox();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cbFlag = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.tbAddr2 = new System.Windows.Forms.TextBox();
            this.tbAddr1 = new System.Windows.Forms.TextBox();
            this.tbPostNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBusiNo = new System.Windows.Forms.TextBox();
            this.tbHp = new System.Windows.Forms.TextBox();
            this.tbCustMan = new System.Windows.Forms.TextBox();
            this.cbSaleMan = new System.Windows.Forms.ComboBox();
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
            this.panTitle.Size = new System.Drawing.Size(1007, 54);
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
            this.lblTitle.Text = "거래처정보";
            // 
            // cbGubun
            // 
            this.cbGubun.BackColor = System.Drawing.SystemColors.Window;
            this.cbGubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGubun.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbGubun.FormattingEnabled = true;
            this.cbGubun.Items.AddRange(new object[] {
            "1.매출처",
            "2.매입처",
            "3.공통"});
            this.cbGubun.Location = new System.Drawing.Point(485, 187);
            this.cbGubun.Name = "cbGubun";
            this.cbGubun.Size = new System.Drawing.Size(217, 29);
            this.cbGubun.TabIndex = 3;
            this.cbGubun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbFax
            // 
            this.tbFax.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbFax.Location = new System.Drawing.Point(485, 448);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(217, 29);
            this.tbFax.TabIndex = 10;
            this.tbFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbTel.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbTel.Location = new System.Drawing.Point(124, 448);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(217, 29);
            this.tbTel.TabIndex = 9;
            this.tbTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbCeo
            // 
            this.tbCeo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCeo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbCeo.Location = new System.Drawing.Point(124, 187);
            this.tbCeo.Name = "tbCeo";
            this.tbCeo.Size = new System.Drawing.Size(217, 29);
            this.tbCeo.TabIndex = 2;
            this.tbCeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCeo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbCustName
            // 
            this.tbCustName.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCustName.Location = new System.Drawing.Point(124, 124);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(578, 29);
            this.tbCustName.TabIndex = 1;
            this.tbCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(30, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "대표자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(379, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "입출처구분";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "거래처명";
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
            // cbFlag
            // 
            this.cbFlag.AutoSize = true;
            this.cbFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbFlag.Location = new System.Drawing.Point(805, 513);
            this.cbFlag.Name = "cbFlag";
            this.cbFlag.Size = new System.Drawing.Size(109, 25);
            this.cbFlag.TabIndex = 14;
            this.cbFlag.Text = "미사용업체";
            this.cbFlag.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(379, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "담당자연락처";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(30, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "거래담당자";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(379, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "팩스번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(30, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "전화번호";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(736, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "특이사항";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(379, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "영업관리자";
            // 
            // tbContents
            // 
            this.tbContents.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbContents.Location = new System.Drawing.Point(730, 187);
            this.tbContents.Multiline = true;
            this.tbContents.Name = "tbContents";
            this.tbContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContents.Size = new System.Drawing.Size(251, 290);
            this.tbContents.TabIndex = 13;
            // 
            // tbAddr2
            // 
            this.tbAddr2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbAddr2.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbAddr2.Location = new System.Drawing.Point(124, 385);
            this.tbAddr2.Name = "tbAddr2";
            this.tbAddr2.Size = new System.Drawing.Size(578, 29);
            this.tbAddr2.TabIndex = 8;
            this.tbAddr2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbAddr1
            // 
            this.tbAddr1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbAddr1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbAddr1.Location = new System.Drawing.Point(124, 349);
            this.tbAddr1.Name = "tbAddr1";
            this.tbAddr1.Size = new System.Drawing.Size(578, 29);
            this.tbAddr1.TabIndex = 7;
            this.tbAddr1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbPostNo
            // 
            this.tbPostNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbPostNo.Location = new System.Drawing.Point(124, 313);
            this.tbPostNo.Name = "tbPostNo";
            this.tbPostNo.Size = new System.Drawing.Size(217, 29);
            this.tbPostNo.TabIndex = 6;
            this.tbPostNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPostNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(30, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "우편주소";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(30, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "상세주소";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPost.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblPost.ForeColor = System.Drawing.Color.Blue;
            this.lblPost.Location = new System.Drawing.Point(30, 317);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(74, 21);
            this.lblPost.TabIndex = 0;
            this.lblPost.Text = "우편번호";
            this.lblPost.Click += new System.EventHandler(this.lblPost_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(30, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "사업자번호";
            // 
            // tbBusiNo
            // 
            this.tbBusiNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbBusiNo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbBusiNo.Location = new System.Drawing.Point(124, 250);
            this.tbBusiNo.Name = "tbBusiNo";
            this.tbBusiNo.Size = new System.Drawing.Size(217, 29);
            this.tbBusiNo.TabIndex = 4;
            this.tbBusiNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBusiNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbHp
            // 
            this.tbHp.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbHp.Location = new System.Drawing.Point(485, 511);
            this.tbHp.Name = "tbHp";
            this.tbHp.Size = new System.Drawing.Size(217, 29);
            this.tbHp.TabIndex = 12;
            this.tbHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbCustMan
            // 
            this.tbCustMan.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCustMan.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbCustMan.Location = new System.Drawing.Point(124, 511);
            this.tbCustMan.Name = "tbCustMan";
            this.tbCustMan.Size = new System.Drawing.Size(217, 29);
            this.tbCustMan.TabIndex = 11;
            this.tbCustMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // cbSaleMan
            // 
            this.cbSaleMan.BackColor = System.Drawing.SystemColors.Window;
            this.cbSaleMan.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbSaleMan.FormattingEnabled = true;
            this.cbSaleMan.ItemHeight = 21;
            this.cbSaleMan.Location = new System.Drawing.Point(485, 250);
            this.cbSaleMan.Name = "cbSaleMan";
            this.cbSaleMan.Size = new System.Drawing.Size(217, 29);
            this.cbSaleMan.TabIndex = 5;
            this.cbSaleMan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(525, 593);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 16;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.buttonImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(369, 593);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 15;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // P1A01_CUSTOMER_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1007, 656);
            this.Controls.Add(this.cbSaleMan);
            this.Controls.Add(this.tbHp);
            this.Controls.Add(this.tbCustMan);
            this.Controls.Add(this.tbBusiNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAddr2);
            this.Controls.Add(this.tbAddr1);
            this.Controls.Add(this.tbPostNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbFlag);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbGubun);
            this.Controls.Add(this.tbFax);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbCeo);
            this.Controls.Add(this.tbCustName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1A01_CUSTOMER_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1A01_CUSTOMER_SUB_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbGubun;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbCeo;
        private System.Windows.Forms.TextBox tbCustName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        private System.Windows.Forms.CheckBox cbFlag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbContents;
        private System.Windows.Forms.TextBox tbAddr2;
        private System.Windows.Forms.TextBox tbAddr1;
        private System.Windows.Forms.TextBox tbPostNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBusiNo;
        private System.Windows.Forms.TextBox tbHp;
        private System.Windows.Forms.TextBox tbCustMan;
        private System.Windows.Forms.ComboBox cbSaleMan;
    }
}
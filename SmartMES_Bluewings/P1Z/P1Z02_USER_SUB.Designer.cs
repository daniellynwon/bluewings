namespace SmartMES_Bluewings
{
    partial class P1Z02_USER_SUB
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
            this.cbAuthority = new System.Windows.Forms.ComboBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFlag = new System.Windows.Forms.CheckBox();
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
            this.panTitle.Size = new System.Drawing.Size(596, 54);
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
            this.lblTitle.Text = "사용자정보";
            // 
            // cbAuthority
            // 
            this.cbAuthority.BackColor = System.Drawing.SystemColors.Window;
            this.cbAuthority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthority.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbAuthority.FormattingEnabled = true;
            this.cbAuthority.Items.AddRange(new object[] {
            "A.Admin",
            "B.관리자",
            "C.일반사용자",
            "D.조회자",
            "Z.기타"});
            this.cbAuthority.Location = new System.Drawing.Point(170, 382);
            this.cbAuthority.Name = "cbAuthority";
            this.cbAuthority.Size = new System.Drawing.Size(189, 29);
            this.cbAuthority.TabIndex = 5;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbPhone.Location = new System.Drawing.Point(170, 319);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(298, 29);
            this.tbPhone.TabIndex = 4;
            this.tbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbJob
            // 
            this.tbJob.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbJob.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbJob.Location = new System.Drawing.Point(170, 256);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(298, 29);
            this.tbJob.TabIndex = 3;
            this.tbJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbJob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbName.Location = new System.Drawing.Point(170, 193);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 29);
            this.tbName.TabIndex = 2;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbID.Location = new System.Drawing.Point(170, 130);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(298, 29);
            this.tbID.TabIndex = 1;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(86, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "사용등급";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(86, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "연 락 처";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(86, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "담당업무";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(86, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "사용자명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(86, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자ID";
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.buttonImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(170, 481);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(326, 481);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(107, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 0;
            this.label6.Tag = "";
            this.label6.Text = "(사번)";
            // 
            // cbFlag
            // 
            this.cbFlag.AutoSize = true;
            this.cbFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbFlag.Location = new System.Drawing.Point(375, 384);
            this.cbFlag.Name = "cbFlag";
            this.cbFlag.Size = new System.Drawing.Size(93, 25);
            this.cbFlag.TabIndex = 6;
            this.cbFlag.Text = "미사용자";
            this.cbFlag.UseVisualStyleBackColor = true;
            // 
            // P1Z02_USER_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(596, 553);
            this.Controls.Add(this.cbFlag);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbAuthority);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbJob);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1Z02_USER_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1Z02_USER_SUB_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbAuthority;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbFlag;
    }
}
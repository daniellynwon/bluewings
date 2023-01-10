namespace SmartMES_Bluewings
{
    partial class PwdChange
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
            this.tbPwd3 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPWD = new System.Windows.Forms.Label();
            this.lblSmartMES = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbPwd2 = new System.Windows.Forms.TextBox();
            this.tbPwd1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ubtnClose = new SmartMES_Bluewings.UserButtonA();
            this.ubtnSave = new SmartMES_Bluewings.UserButtonA();
            this.SuspendLayout();
            // 
            // tbPwd3
            // 
            this.tbPwd3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPwd3.Location = new System.Drawing.Point(472, 306);
            this.tbPwd3.Name = "tbPwd3";
            this.tbPwd3.PasswordChar = '●';
            this.tbPwd3.Size = new System.Drawing.Size(180, 29);
            this.tbPwd3.TabIndex = 3;
            this.tbPwd3.TextChanged += new System.EventHandler(this.tbPwd_TextChanged);
            this.tbPwd3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPwd3_KeyUp);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.ForeColor = System.Drawing.Color.DimGray;
            this.lblID.Location = new System.Drawing.Point(388, 267);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(74, 21);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "변경암호";
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.BackColor = System.Drawing.Color.Transparent;
            this.lblPWD.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPWD.ForeColor = System.Drawing.Color.DimGray;
            this.lblPWD.Location = new System.Drawing.Point(388, 310);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(74, 21);
            this.lblPWD.TabIndex = 6;
            this.lblPWD.Text = "암호확인";
            // 
            // lblSmartMES
            // 
            this.lblSmartMES.AutoSize = true;
            this.lblSmartMES.BackColor = System.Drawing.Color.Transparent;
            this.lblSmartMES.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSmartMES.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSmartMES.Location = new System.Drawing.Point(145, 461);
            this.lblSmartMES.Name = "lblSmartMES";
            this.lblSmartMES.Size = new System.Drawing.Size(225, 30);
            this.lblSmartMES.TabIndex = 7;
            this.lblSmartMES.Text = "Smart Factory MES ...";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(56, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(97, 30);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "암호변경";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(389, 182);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "메세지 라벨입니다.";
            // 
            // tbPwd2
            // 
            this.tbPwd2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPwd2.Location = new System.Drawing.Point(472, 263);
            this.tbPwd2.Name = "tbPwd2";
            this.tbPwd2.PasswordChar = '●';
            this.tbPwd2.Size = new System.Drawing.Size(180, 29);
            this.tbPwd2.TabIndex = 2;
            this.tbPwd2.TextChanged += new System.EventHandler(this.tbPwd_TextChanged);
            // 
            // tbPwd1
            // 
            this.tbPwd1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPwd1.Location = new System.Drawing.Point(472, 220);
            this.tbPwd1.Name = "tbPwd1";
            this.tbPwd1.PasswordChar = '●';
            this.tbPwd1.Size = new System.Drawing.Size(180, 29);
            this.tbPwd1.TabIndex = 1;
            this.tbPwd1.TextChanged += new System.EventHandler(this.tbPwd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(388, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "현재암호";
            // 
            // ubtnClose
            // 
            this.ubtnClose.BackColor = System.Drawing.Color.Transparent;
            this.ubtnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.ubtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ubtnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.ubtnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ubtnClose.Location = new System.Drawing.Point(571, 355);
            this.ubtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ubtnClose.Name = "ubtnClose";
            this.ubtnClose.Size = new System.Drawing.Size(81, 25);
            this.ubtnClose.TabIndex = 5;
            this.ubtnClose.Click += new System.EventHandler(this.ubtnClose_Click);
            // 
            // ubtnSave
            // 
            this.ubtnSave.BackColor = System.Drawing.Color.Transparent;
            this.ubtnSave.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.ubtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ubtnSave.buttonImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.ubtnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ubtnSave.Location = new System.Drawing.Point(472, 355);
            this.ubtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ubtnSave.Name = "ubtnSave";
            this.ubtnSave.Size = new System.Drawing.Size(81, 25);
            this.ubtnSave.TabIndex = 4;
            this.ubtnSave.Click += new System.EventHandler(this.ubtnSave_Click);
            // 
            // PwdChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPwd1);
            this.Controls.Add(this.tbPwd2);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.ubtnClose);
            this.Controls.Add(this.ubtnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSmartMES);
            this.Controls.Add(this.lblPWD);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbPwd3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PwdChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PwdChange";
            this.Load += new System.EventHandler(this.PwdChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPwd3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.Label lblSmartMES;
        private System.Windows.Forms.Label lblTitle;
        private UserButtonA ubtnSave;
        private UserButtonA ubtnClose;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox tbPwd2;
        private System.Windows.Forms.TextBox tbPwd1;
        private System.Windows.Forms.Label label1;
    }
}
namespace SmartMES_Bluewings
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblSmartMES = new System.Windows.Forms.Label();
            this.lblPWD = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbPWD = new System.Windows.Forms.TextBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.lblCapsLock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ubtnCancel = new SmartMES_Bluewings.UserButtonA();
            this.ubtnConnect = new SmartMES_Bluewings.UserButtonA();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblCompany.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblCompany.ForeColor = System.Drawing.Color.Navy;
            this.lblCompany.Location = new System.Drawing.Point(311, 104);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(391, 30);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "CompanyName";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(395, 203);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "메세지 라벨입니다.";
            // 
            // lblSmartMES
            // 
            this.lblSmartMES.AutoSize = true;
            this.lblSmartMES.BackColor = System.Drawing.Color.Transparent;
            this.lblSmartMES.Font = new System.Drawing.Font("맑은 고딕", 16F);
            this.lblSmartMES.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSmartMES.Location = new System.Drawing.Point(145, 461);
            this.lblSmartMES.Name = "lblSmartMES";
            this.lblSmartMES.Size = new System.Drawing.Size(225, 30);
            this.lblSmartMES.TabIndex = 0;
            this.lblSmartMES.Text = "Smart Factory MES ...";
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.BackColor = System.Drawing.Color.Transparent;
            this.lblPWD.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblPWD.ForeColor = System.Drawing.Color.DimGray;
            this.lblPWD.Location = new System.Drawing.Point(367, 302);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(74, 21);
            this.lblPWD.TabIndex = 0;
            this.lblPWD.Text = "패스워드";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblID.ForeColor = System.Drawing.Color.DimGray;
            this.lblID.Location = new System.Drawing.Point(367, 251);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 21);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "사용자 ID";
            // 
            // tbPWD
            // 
            this.tbPWD.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbPWD.Location = new System.Drawing.Point(450, 298);
            this.tbPWD.Name = "tbPWD";
            this.tbPWD.PasswordChar = '●';
            this.tbPWD.Size = new System.Drawing.Size(224, 29);
            this.tbPWD.TabIndex = 1;
            this.tbPWD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPWD_KeyUp);
            // 
            // cbID
            // 
            this.cbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbID.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(450, 247);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(224, 29);
            this.cbID.TabIndex = 4;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // lblCapsLock
            // 
            this.lblCapsLock.AutoSize = true;
            this.lblCapsLock.BackColor = System.Drawing.Color.Transparent;
            this.lblCapsLock.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblCapsLock.ForeColor = System.Drawing.Color.Blue;
            this.lblCapsLock.Location = new System.Drawing.Point(450, 329);
            this.lblCapsLock.Name = "lblCapsLock";
            this.lblCapsLock.Size = new System.Drawing.Size(106, 21);
            this.lblCapsLock.TabIndex = 0;
            this.lblCapsLock.Text = "CapsLock On";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ubtnCancel
            // 
            this.ubtnCancel.BackColor = System.Drawing.Color.Transparent;
            this.ubtnCancel.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.cancel;
            this.ubtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ubtnCancel.buttonImage = global::SmartMES_Bluewings.Properties.Resources.cancel;
            this.ubtnCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ubtnCancel.Location = new System.Drawing.Point(584, 364);
            this.ubtnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ubtnCancel.Name = "ubtnCancel";
            this.ubtnCancel.Size = new System.Drawing.Size(90, 25);
            this.ubtnCancel.TabIndex = 3;
            this.ubtnCancel.Click += new System.EventHandler(this.ubtnCancel_Click);
            // 
            // ubtnConnect
            // 
            this.ubtnConnect.BackColor = System.Drawing.Color.Transparent;
            this.ubtnConnect.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.login_connect;
            this.ubtnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ubtnConnect.buttonImage = global::SmartMES_Bluewings.Properties.Resources.login_connect;
            this.ubtnConnect.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ubtnConnect.Location = new System.Drawing.Point(450, 364);
            this.ubtnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ubtnConnect.Name = "ubtnConnect";
            this.ubtnConnect.Size = new System.Drawing.Size(90, 25);
            this.ubtnConnect.TabIndex = 2;
            this.ubtnConnect.Click += new System.EventHandler(this.ubtnConnect_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.ubtnCancel);
            this.Controls.Add(this.ubtnConnect);
            this.Controls.Add(this.lblCapsLock);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblSmartMES);
            this.Controls.Add(this.lblPWD);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbPWD);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.lblCompany);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblSmartMES;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbPWD;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Label lblCapsLock;
        private UserButtonA ubtnConnect;
        private UserButtonA ubtnCancel;
        private System.Windows.Forms.Timer timer1;
    }
}
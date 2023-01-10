namespace SmartMES_Bluewings
{
    partial class P1A06_RECIPE_SUB
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPer3 = new System.Windows.Forms.TextBox();
            this.tbPer2 = new System.Windows.Forms.TextBox();
            this.tbPer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMat3 = new System.Windows.Forms.ComboBox();
            this.cbMat2 = new System.Windows.Forms.ComboBox();
            this.cbMat1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProd = new System.Windows.Forms.ComboBox();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(39, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목명";
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
            this.lblTitle.Size = new System.Drawing.Size(117, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "RECIPE 관리";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(382, 503);
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
            this.btnSave.Location = new System.Drawing.Point(213, 503);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 34;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPer3);
            this.groupBox1.Controls.Add(this.tbPer2);
            this.groupBox1.Controls.Add(this.tbPer1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMat3);
            this.groupBox1.Controls.Add(this.cbMat2);
            this.groupBox1.Controls.Add(this.cbMat1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(32, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbPer3
            // 
            this.tbPer3.Location = new System.Drawing.Point(418, 176);
            this.tbPer3.Name = "tbPer3";
            this.tbPer3.Size = new System.Drawing.Size(199, 29);
            this.tbPer3.TabIndex = 7;
            // 
            // tbPer2
            // 
            this.tbPer2.Location = new System.Drawing.Point(418, 120);
            this.tbPer2.Name = "tbPer2";
            this.tbPer2.Size = new System.Drawing.Size(199, 29);
            this.tbPer2.TabIndex = 5;
            // 
            // tbPer1
            // 
            this.tbPer1.Location = new System.Drawing.Point(418, 65);
            this.tbPer1.Name = "tbPer1";
            this.tbPer1.Size = new System.Drawing.Size(199, 29);
            this.tbPer1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(308, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "비  율 (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(308, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "비  율 (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(308, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "비  율 (%)";
            // 
            // cbMat3
            // 
            this.cbMat3.FormattingEnabled = true;
            this.cbMat3.Location = new System.Drawing.Point(82, 176);
            this.cbMat3.Name = "cbMat3";
            this.cbMat3.Size = new System.Drawing.Size(199, 29);
            this.cbMat3.TabIndex = 6;
            // 
            // cbMat2
            // 
            this.cbMat2.FormattingEnabled = true;
            this.cbMat2.Location = new System.Drawing.Point(82, 118);
            this.cbMat2.Name = "cbMat2";
            this.cbMat2.Size = new System.Drawing.Size(199, 29);
            this.cbMat2.TabIndex = 4;
            // 
            // cbMat1
            // 
            this.cbMat1.FormattingEnabled = true;
            this.cbMat1.Location = new System.Drawing.Point(82, 65);
            this.cbMat1.Name = "cbMat1";
            this.cbMat1.Size = new System.Drawing.Size(199, 29);
            this.cbMat1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "자재명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(7, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "자재명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "자재명";
            // 
            // cbProd
            // 
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Location = new System.Drawing.Point(114, 121);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(199, 29);
            this.cbProd.TabIndex = 1;
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(450, 121);
            this.tbNo.Name = "tbNo";
            this.tbNo.ReadOnly = true;
            this.tbNo.Size = new System.Drawing.Size(199, 29);
            this.tbNo.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(340, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "레시피No";
            // 
            // P1A06_RECIPE_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(738, 588);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1A06_RECIPE_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1A06_RECIPE_SUB_Load);
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
        private System.Windows.Forms.Label label1;
        private UserButtonA btnClose;
        private UserButtonA btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbProd;
        private System.Windows.Forms.ComboBox cbMat3;
        private System.Windows.Forms.ComboBox cbMat2;
        private System.Windows.Forms.ComboBox cbMat1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPer3;
        private System.Windows.Forms.TextBox tbPer2;
        private System.Windows.Forms.TextBox tbPer1;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label8;
    }
}
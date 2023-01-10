namespace SmartMES_Bluewings
{
    partial class FormMain
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
            this.lbMES = new System.Windows.Forms.Label();
            this.lbMade = new System.Windows.Forms.Label();
            this.llbPwChange = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbMES
            // 
            this.lbMES.AutoSize = true;
            this.lbMES.BackColor = System.Drawing.Color.Transparent;
            this.lbMES.Font = new System.Drawing.Font("Consolas", 30F);
            this.lbMES.ForeColor = System.Drawing.Color.Navy;
            this.lbMES.Location = new System.Drawing.Point(285, 124);
            this.lbMES.Name = "lbMES";
            this.lbMES.Size = new System.Drawing.Size(394, 47);
            this.lbMES.TabIndex = 0;
            this.lbMES.Text = "Smart Factory MES";
            // 
            // lbMade
            // 
            this.lbMade.AutoSize = true;
            this.lbMade.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lbMade.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbMade.Location = new System.Drawing.Point(87, 264);
            this.lbMade.Name = "lbMade";
            this.lbMade.Size = new System.Drawing.Size(431, 20);
            this.lbMade.TabIndex = 0;
            this.lbMade.Text = "MES system made by INNOBE Corporation. (82) 31-8069-8932";
            // 
            // llbPwChange
            // 
            this.llbPwChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.llbPwChange.AutoSize = true;
            this.llbPwChange.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.llbPwChange.LinkColor = System.Drawing.Color.Navy;
            this.llbPwChange.Location = new System.Drawing.Point(47, 475);
            this.llbPwChange.Name = "llbPwChange";
            this.llbPwChange.Size = new System.Drawing.Size(112, 21);
            this.llbPwChange.TabIndex = 0;
            this.llbPwChange.TabStop = true;
            this.llbPwChange.Text = "패스워드 변경";
            this.llbPwChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbPwChange_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox1.Location = new System.Drawing.Point(191, 473);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 25);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Side Menu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 632);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.llbPwChange);
            this.Controls.Add(this.lbMade);
            this.Controls.Add(this.lbMES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMES;
        private System.Windows.Forms.Label lbMade;
        private System.Windows.Forms.LinkLabel llbPwChange;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
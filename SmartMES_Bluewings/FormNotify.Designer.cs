namespace SmartMES_Bluewings
{
    partial class FormNotify
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
            this.ckbToday = new System.Windows.Forms.CheckBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ckbToday
            // 
            this.ckbToday.AutoSize = true;
            this.ckbToday.BackColor = System.Drawing.Color.Transparent;
            this.ckbToday.ForeColor = System.Drawing.Color.Gray;
            this.ckbToday.Location = new System.Drawing.Point(449, 6);
            this.ckbToday.Name = "ckbToday";
            this.ckbToday.Size = new System.Drawing.Size(127, 25);
            this.ckbToday.TabIndex = 0;
            this.ckbToday.Text = "오늘은 그만...";
            this.ckbToday.UseVisualStyleBackColor = false;
            this.ckbToday.Click += new System.EventHandler(this.ckbToday_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.lblSubject.ForeColor = System.Drawing.Color.Navy;
            this.lblSubject.Location = new System.Drawing.Point(14, 75);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(536, 26);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbContents
            // 
            this.tbContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.tbContents.ForeColor = System.Drawing.Color.White;
            this.tbContents.Location = new System.Drawing.Point(12, 106);
            this.tbContents.Multiline = true;
            this.tbContents.Name = "tbContents";
            this.tbContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContents.Size = new System.Drawing.Size(556, 235);
            this.tbContents.TabIndex = 0;
            // 
            // FormNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.notify;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 374);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.ckbToday);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "공지사항";
            this.Load += new System.EventHandler(this.FormNotify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblSubject;
        public System.Windows.Forms.TextBox tbContents;
        public System.Windows.Forms.CheckBox ckbToday;
    }
}
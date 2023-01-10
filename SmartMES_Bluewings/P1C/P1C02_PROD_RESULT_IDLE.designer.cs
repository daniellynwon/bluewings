namespace SmartMES_Bluewings
{
    partial class P1C02_PROD_RESULT_IDLE
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.lbIdleList = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.panTitle.Size = new System.Drawing.Size(540, 54);
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
            this.lblTitle.Text = "비가동보고";
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
            // lbIdleList
            // 
            this.lbIdleList.FormattingEnabled = true;
            this.lbIdleList.ItemHeight = 21;
            this.lbIdleList.Location = new System.Drawing.Point(32, 111);
            this.lbIdleList.Name = "lbIdleList";
            this.lbIdleList.Size = new System.Drawing.Size(235, 361);
            this.lbIdleList.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::SmartMES_Bluewings.Properties.Resources.Alert;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStart.Location = new System.Drawing.Point(316, 111);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(195, 95);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "비가동 시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Image = global::SmartMES_Bluewings.Properties.Resources.minus;
            this.btnFinish.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFinish.Location = new System.Drawing.Point(316, 244);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(195, 95);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "비가동 종료";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::SmartMES_Bluewings.Properties.Resources.PowerOff1;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(316, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 95);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "닫 기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // P1C02_PROD_RESULT_IDLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(540, 508);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbIdleList);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1C02_PROD_RESULT_IDLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1C02_PROD_RESULT_IDLE_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ListBox lbIdleList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnClose;
    }
}
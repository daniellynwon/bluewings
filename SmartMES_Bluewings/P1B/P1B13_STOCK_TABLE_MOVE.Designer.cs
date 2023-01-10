namespace SmartMES_Bluewings
{
    partial class P1B13_STOCK_TABLE_MOVE
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
            this.cbDepot = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProd = new System.Windows.Forms.TextBox();
            this.lblProd = new System.Windows.Forms.Label();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContents = new System.Windows.Forms.TextBox();
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
            this.panTitle.Size = new System.Drawing.Size(645, 54);
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
            this.lblTitle.Size = new System.Drawing.Size(127, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "재고이동/조정";
            // 
            // cbDepot
            // 
            this.cbDepot.BackColor = System.Drawing.SystemColors.Window;
            this.cbDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepot.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbDepot.FormattingEnabled = true;
            this.cbDepot.Location = new System.Drawing.Point(152, 217);
            this.cbDepot.Name = "cbDepot";
            this.cbDepot.Size = new System.Drawing.Size(211, 29);
            this.cbDepot.TabIndex = 2;
            this.cbDepot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(73, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "입출창고";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(73, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "처리일자";
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
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbQty.Location = new System.Drawing.Point(388, 367);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(128, 29);
            this.tbQty.TabIndex = 5;
            this.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(311, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "조정수량";
            // 
            // tbProd
            // 
            this.tbProd.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbProd.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbProd.Location = new System.Drawing.Point(152, 292);
            this.tbProd.Name = "tbProd";
            this.tbProd.ReadOnly = true;
            this.tbProd.Size = new System.Drawing.Size(364, 29);
            this.tbProd.TabIndex = 0;
            this.tbProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblProd.ForeColor = System.Drawing.Color.Blue;
            this.lblProd.Location = new System.Drawing.Point(73, 296);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(58, 21);
            this.lblProd.TabIndex = 3;
            this.lblProd.Text = "품목명";
            this.lblProd.Click += new System.EventHandler(this.lblProd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(348, 520);
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
            this.btnSave.Location = new System.Drawing.Point(192, 520);
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
            this.dtpDate.Location = new System.Drawing.Point(152, 142);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(211, 29);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // cbKind
            // 
            this.cbKind.BackColor = System.Drawing.SystemColors.Window;
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Location = new System.Drawing.Point(152, 367);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(128, 29);
            this.cbKind.TabIndex = 4;
            this.cbKind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(73, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "조정유형";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(73, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "조정사유";
            // 
            // tbContents
            // 
            this.tbContents.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbContents.Location = new System.Drawing.Point(152, 442);
            this.tbContents.Name = "tbContents";
            this.tbContents.Size = new System.Drawing.Size(364, 29);
            this.tbContents.TabIndex = 6;
            this.tbContents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // P1B13_STOCK_TABLE_MOVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(645, 586);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.tbProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbDepot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1B13_STOCK_TABLE_MOVE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "재고집계표";
            this.Load += new System.EventHandler(this.P1B13_STOCK_TABLE_MOVE_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbDepot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private UserButtonA btnSave;
        private UserButtonA btnClose;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbContents;
    }
}
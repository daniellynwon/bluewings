namespace SmartMES_Bluewings
{
    partial class P1C01_PROD_ORDER_SUB
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProd = new System.Windows.Forms.TextBox();
            this.lblProd = new System.Windows.Forms.Label();
            this.tbJobNo = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbMat1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPer1 = new System.Windows.Forms.TextBox();
            this.cbMat2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPer2 = new System.Windows.Forms.TextBox();
            this.cbMat3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPer3 = new System.Windows.Forms.TextBox();
            this.cbMat4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPer4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClose = new SmartMES_Bluewings.UserButtonA();
            this.btnSave = new SmartMES_Bluewings.UserButtonA();
            this.label17 = new System.Windows.Forms.Label();
            this.panTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "생산지시등록";
            // 
            // panTitle
            // 
            this.panTitle.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.photo_background;
            this.panTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(693, 54);
            this.panTitle.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(28, 70);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(33, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "LotNo.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(357, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "생산일자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(357, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "지시수량";
            // 
            // tbProd
            // 
            this.tbProd.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbProd.Location = new System.Drawing.Point(117, 175);
            this.tbProd.Name = "tbProd";
            this.tbProd.ReadOnly = true;
            this.tbProd.Size = new System.Drawing.Size(207, 29);
            this.tbProd.TabIndex = 3;
            this.tbProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblProd.ForeColor = System.Drawing.Color.Blue;
            this.lblProd.Location = new System.Drawing.Point(33, 179);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(70, 21);
            this.lblProd.TabIndex = 0;
            this.lblProd.Text = "품 목 명";
            this.lblProd.Click += new System.EventHandler(this.lblProd_Click);
            // 
            // tbJobNo
            // 
            this.tbJobNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbJobNo.ForeColor = System.Drawing.Color.Blue;
            this.tbJobNo.Location = new System.Drawing.Point(117, 108);
            this.tbJobNo.Name = "tbJobNo";
            this.tbJobNo.ReadOnly = true;
            this.tbJobNo.Size = new System.Drawing.Size(207, 29);
            this.tbJobNo.TabIndex = 1;
            this.tbJobNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Location = new System.Drawing.Point(441, 108);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(207, 29);
            this.dtpDate.TabIndex = 2;
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbQty.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbQty.Location = new System.Drawing.Point(441, 175);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(207, 29);
            this.tbQty.TabIndex = 4;
            this.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(33, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "지시일자";
            this.label3.Visible = false;
            // 
            // dtpDate1
            // 
            this.dtpDate1.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate1.Location = new System.Drawing.Point(117, 242);
            this.dtpDate1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(207, 29);
            this.dtpDate1.TabIndex = 5;
            this.dtpDate1.Visible = false;
            // 
            // tbContents
            // 
            this.tbContents.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbContents.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbContents.Location = new System.Drawing.Point(117, 535);
            this.tbContents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbContents.Name = "tbContents";
            this.tbContents.Size = new System.Drawing.Size(531, 29);
            this.tbContents.TabIndex = 35;
            this.tbContents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(36, 540);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 21);
            this.label13.TabIndex = 34;
            this.label13.Text = "작업지도";
            // 
            // cbMat1
            // 
            this.cbMat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMat1.FormattingEnabled = true;
            this.cbMat1.Location = new System.Drawing.Point(117, 302);
            this.cbMat1.Name = "cbMat1";
            this.cbMat1.Size = new System.Drawing.Size(207, 29);
            this.cbMat1.TabIndex = 6;
            this.cbMat1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(35, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "자재명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(357, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "비 율 (%)";
            // 
            // tbPer1
            // 
            this.tbPer1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbPer1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbPer1.Location = new System.Drawing.Point(441, 302);
            this.tbPer1.Name = "tbPer1";
            this.tbPer1.Size = new System.Drawing.Size(207, 29);
            this.tbPer1.TabIndex = 7;
            this.tbPer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPer1.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbPer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbPer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // cbMat2
            // 
            this.cbMat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMat2.FormattingEnabled = true;
            this.cbMat2.Location = new System.Drawing.Point(117, 356);
            this.cbMat2.Name = "cbMat2";
            this.cbMat2.Size = new System.Drawing.Size(207, 29);
            this.cbMat2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(35, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "자재명";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(357, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "비 율 (%)";
            // 
            // tbPer2
            // 
            this.tbPer2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbPer2.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbPer2.Location = new System.Drawing.Point(441, 356);
            this.tbPer2.Name = "tbPer2";
            this.tbPer2.Size = new System.Drawing.Size(207, 29);
            this.tbPer2.TabIndex = 9;
            this.tbPer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPer2.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbPer2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbPer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // cbMat3
            // 
            this.cbMat3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMat3.FormattingEnabled = true;
            this.cbMat3.Location = new System.Drawing.Point(117, 414);
            this.cbMat3.Name = "cbMat3";
            this.cbMat3.Size = new System.Drawing.Size(207, 29);
            this.cbMat3.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(35, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "자재명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(357, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "비 율 (%)";
            // 
            // tbPer3
            // 
            this.tbPer3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbPer3.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbPer3.Location = new System.Drawing.Point(441, 414);
            this.tbPer3.Name = "tbPer3";
            this.tbPer3.Size = new System.Drawing.Size(207, 29);
            this.tbPer3.TabIndex = 11;
            this.tbPer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPer3.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbPer3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbPer3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // cbMat4
            // 
            this.cbMat4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMat4.FormattingEnabled = true;
            this.cbMat4.Location = new System.Drawing.Point(117, 470);
            this.cbMat4.Name = "cbMat4";
            this.cbMat4.Size = new System.Drawing.Size(207, 29);
            this.cbMat4.TabIndex = 12;
            this.cbMat4.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(35, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "자재명";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(357, 474);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "비 율 (%)";
            this.label11.Visible = false;
            // 
            // tbPer4
            // 
            this.tbPer4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbPer4.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbPer4.Location = new System.Drawing.Point(441, 470);
            this.tbPer4.Name = "tbPer4";
            this.tbPer4.Size = new System.Drawing.Size(207, 29);
            this.tbPer4.TabIndex = 13;
            this.tbPer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPer4.Visible = false;
            this.tbPer4.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            this.tbPer4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            this.tbPer4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(36, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 21);
            this.label14.TabIndex = 36;
            this.label14.Text = "창고A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(38, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 21);
            this.label15.TabIndex = 37;
            this.label15.Text = "창고B";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(38, 434);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 21);
            this.label16.TabIndex = 38;
            this.label16.Text = "창고C";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.buttonImage = global::SmartMES_Bluewings.Properties.Resources.close;
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(361, 623);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 33;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.buttonImage = global::SmartMES_Bluewings.Properties.Resources.save;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(217, 623);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 32;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(37, 492);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 21);
            this.label17.TabIndex = 39;
            this.label17.Text = "창고D";
            this.label17.Visible = false;
            // 
            // P1C01_PROD_ORDER_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(693, 693);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbPer4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbMat4);
            this.Controls.Add(this.tbPer3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMat3);
            this.Controls.Add(this.tbPer2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMat2);
            this.Controls.Add(this.tbPer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbQty);
            this.Controls.Add(this.cbMat1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbJobNo);
            this.Controls.Add(this.tbProd);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panTitle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1C01_PROD_ORDER_SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1C01_PROD_ORDER_SUB_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panTitle;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.TextBox tbJobNo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbQty;
        private UserButtonA btnClose;
        private UserButtonA btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        public System.Windows.Forms.TextBox tbContents;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbMat1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPer1;
        private System.Windows.Forms.ComboBox cbMat2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPer2;
        private System.Windows.Forms.ComboBox cbMat3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPer3;
        private System.Windows.Forms.ComboBox cbMat4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPer4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}
namespace SmartMES_Bluewings
{
    partial class P1Z01_POS
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sPLogQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1Z = new SmartMES_Bluewings.P1Z.DataSetP1Z();
            this.sP_Log_QueryTableAdapter = new SmartMES_Bluewings.P1Z.DataSetP1ZTableAdapters.SP_Log_QueryTableAdapter();
            this.panSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbJobStartTime = new System.Windows.Forms.MaskedTextBox();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.tbJongMong = new System.Windows.Forms.TextBox();
            this.tbBubinNo = new System.Windows.Forms.TextBox();
            this.tbHomePage = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbAddr2 = new System.Windows.Forms.TextBox();
            this.tbAddr1 = new System.Windows.Forms.TextBox();
            this.tbPostNo = new System.Windows.Forms.TextBox();
            this.tbUpTae = new System.Windows.Forms.TextBox();
            this.tbBusiNo = new System.Windows.Forms.TextBox();
            this.tbCeo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLogQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1Z)).BeginInit();
            this.panSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "사업장정보";
            // 
            // pbPrint
            // 
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // pbSave
            // 
            this.pbSave.Enabled = true;
            this.pbSave.Image = global::SmartMES_Bluewings.Properties.Resources.save_A;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbDel
            // 
            this.pbDel.Enabled = false;
            this.pbDel.Image = global::SmartMES_Bluewings.Properties.Resources.del_B;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Enabled = false;
            this.pbAdd.Image = global::SmartMES_Bluewings.Properties.Resources.add_B;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // sPLogQueryBindingSource
            // 
            this.sPLogQueryBindingSource.DataMember = "SP_Log_Query";
            this.sPLogQueryBindingSource.DataSource = this.dataSetP1Z;
            // 
            // dataSetP1Z
            // 
            this.dataSetP1Z.DataSetName = "DataSetP1Z";
            this.dataSetP1Z.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_Log_QueryTableAdapter
            // 
            this.sP_Log_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // panSearch
            // 
            this.panSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearch.AutoSize = true;
            this.panSearch.BackColor = System.Drawing.SystemColors.Info;
            this.panSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Controls.Add(this.mtbJobStartTime);
            this.panSearch.Controls.Add(this.tbFax);
            this.panSearch.Controls.Add(this.tbJongMong);
            this.panSearch.Controls.Add(this.tbBubinNo);
            this.panSearch.Controls.Add(this.tbHomePage);
            this.panSearch.Controls.Add(this.tbTel);
            this.panSearch.Controls.Add(this.tbAddr2);
            this.panSearch.Controls.Add(this.tbAddr1);
            this.panSearch.Controls.Add(this.tbPostNo);
            this.panSearch.Controls.Add(this.tbUpTae);
            this.panSearch.Controls.Add(this.tbBusiNo);
            this.panSearch.Controls.Add(this.tbCeo);
            this.panSearch.Controls.Add(this.tbName);
            this.panSearch.Controls.Add(this.label15);
            this.panSearch.Controls.Add(this.label13);
            this.panSearch.Controls.Add(this.label14);
            this.panSearch.Controls.Add(this.label12);
            this.panSearch.Controls.Add(this.label8);
            this.panSearch.Controls.Add(this.label9);
            this.panSearch.Controls.Add(this.label10);
            this.panSearch.Controls.Add(this.lblPost);
            this.panSearch.Controls.Add(this.label6);
            this.panSearch.Controls.Add(this.label7);
            this.panSearch.Controls.Add(this.label5);
            this.panSearch.Controls.Add(this.label4);
            this.panSearch.Controls.Add(this.lblMsg);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 925);
            this.panSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(210, 672);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "작업시작";
            // 
            // mtbJobStartTime
            // 
            this.mtbJobStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtbJobStartTime.Location = new System.Drawing.Point(308, 676);
            this.mtbJobStartTime.Mask = "90:90";
            this.mtbJobStartTime.Name = "mtbJobStartTime";
            this.mtbJobStartTime.Size = new System.Drawing.Size(298, 29);
            this.mtbJobStartTime.TabIndex = 13;
            this.mtbJobStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbJobStartTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbFax
            // 
            this.tbFax.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFax.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbFax.Location = new System.Drawing.Point(765, 602);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(298, 29);
            this.tbFax.TabIndex = 12;
            this.tbFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbJongMong
            // 
            this.tbJongMong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbJongMong.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbJongMong.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbJongMong.Location = new System.Drawing.Point(765, 380);
            this.tbJongMong.Name = "tbJongMong";
            this.tbJongMong.Size = new System.Drawing.Size(298, 29);
            this.tbJongMong.TabIndex = 7;
            this.tbJongMong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbJongMong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbBubinNo
            // 
            this.tbBubinNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbBubinNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbBubinNo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbBubinNo.Location = new System.Drawing.Point(765, 307);
            this.tbBubinNo.Name = "tbBubinNo";
            this.tbBubinNo.Size = new System.Drawing.Size(298, 29);
            this.tbBubinNo.TabIndex = 5;
            this.tbBubinNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBubinNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbHomePage
            // 
            this.tbHomePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbHomePage.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbHomePage.Location = new System.Drawing.Point(765, 234);
            this.tbHomePage.Name = "tbHomePage";
            this.tbHomePage.Size = new System.Drawing.Size(298, 29);
            this.tbHomePage.TabIndex = 3;
            this.tbHomePage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHomePage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbTel
            // 
            this.tbTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTel.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbTel.Location = new System.Drawing.Point(308, 602);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(298, 29);
            this.tbTel.TabIndex = 11;
            this.tbTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbAddr2
            // 
            this.tbAddr2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAddr2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbAddr2.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbAddr2.Location = new System.Drawing.Point(308, 529);
            this.tbAddr2.Name = "tbAddr2";
            this.tbAddr2.Size = new System.Drawing.Size(755, 29);
            this.tbAddr2.TabIndex = 10;
            this.tbAddr2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbAddr1
            // 
            this.tbAddr1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAddr1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbAddr1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbAddr1.Location = new System.Drawing.Point(308, 491);
            this.tbAddr1.Name = "tbAddr1";
            this.tbAddr1.Size = new System.Drawing.Size(755, 29);
            this.tbAddr1.TabIndex = 9;
            this.tbAddr1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbPostNo
            // 
            this.tbPostNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPostNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbPostNo.Location = new System.Drawing.Point(308, 453);
            this.tbPostNo.Name = "tbPostNo";
            this.tbPostNo.Size = new System.Drawing.Size(298, 29);
            this.tbPostNo.TabIndex = 8;
            this.tbPostNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPostNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbUpTae
            // 
            this.tbUpTae.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbUpTae.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbUpTae.Location = new System.Drawing.Point(308, 380);
            this.tbUpTae.Name = "tbUpTae";
            this.tbUpTae.Size = new System.Drawing.Size(298, 29);
            this.tbUpTae.TabIndex = 6;
            this.tbUpTae.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUpTae.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbBusiNo
            // 
            this.tbBusiNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbBusiNo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbBusiNo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbBusiNo.Location = new System.Drawing.Point(308, 307);
            this.tbBusiNo.Name = "tbBusiNo";
            this.tbBusiNo.Size = new System.Drawing.Size(298, 29);
            this.tbBusiNo.TabIndex = 4;
            this.tbBusiNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBusiNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbCeo
            // 
            this.tbCeo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCeo.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCeo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbCeo.Location = new System.Drawing.Point(308, 234);
            this.tbCeo.Name = "tbCeo";
            this.tbCeo.Size = new System.Drawing.Size(298, 29);
            this.tbCeo.TabIndex = 2;
            this.tbCeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCeo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbName.Location = new System.Drawing.Point(308, 161);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 29);
            this.tbName.TabIndex = 1;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(679, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "홈페이지";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(679, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "종 목";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(210, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "업 태";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(210, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "대표자";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(679, 606);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "팩스번호";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(210, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "우편주소";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(210, 533);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "상세주소";
            // 
            // lblPost
            // 
            this.lblPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPost.AutoSize = true;
            this.lblPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPost.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblPost.ForeColor = System.Drawing.Color.Blue;
            this.lblPost.Location = new System.Drawing.Point(210, 457);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(74, 21);
            this.lblPost.TabIndex = 0;
            this.lblPost.Text = "우편번호";
            this.lblPost.Click += new System.EventHandler(this.lblPost_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(210, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "전화번호";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(679, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "법인번호";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(210, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "사업자번호";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(210, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "회사공식명";
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(136, 82);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(203, 688);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "시간(시:분)";
            // 
            // P1Z01_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.panSearch);
            this.Name = "P1Z01_POS";
            this.Text = "P1Z01_POS";
            this.Load += new System.EventHandler(this.P1Z01_POS_Load);
            this.Controls.SetChildIndex(this.panSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLogQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1Z)).EndInit();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private P1Z.DataSetP1Z dataSetP1Z;        
        private System.Windows.Forms.BindingSource sPLogQueryBindingSource;
        private P1Z.DataSetP1ZTableAdapters.SP_Log_QueryTableAdapter sP_Log_QueryTableAdapter;
        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.TextBox tbJongMong;
        private System.Windows.Forms.TextBox tbBubinNo;
        private System.Windows.Forms.TextBox tbHomePage;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbAddr2;
        private System.Windows.Forms.TextBox tbAddr1;
        private System.Windows.Forms.TextBox tbPostNo;
        private System.Windows.Forms.TextBox tbUpTae;
        private System.Windows.Forms.TextBox tbBusiNo;
        private System.Windows.Forms.TextBox tbCeo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbJobStartTime;
        private System.Windows.Forms.Label label2;
    }
}

namespace SmartMES_Bluewings
{
    partial class P1C02_PROD_RESULT1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.dtpDoneTime = new System.Windows.Forms.MaskedTextBox();
            this.dtpStartTime = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.lblBar = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.userButtonA2 = new SmartMES_Bluewings.UserButtonA();
            this.userButtonA1 = new SmartMES_Bluewings.UserButtonA();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.jobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공정명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업자IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.규격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조건7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.외봉투탈피여부 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.외봉투탈피일시 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.양품수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불량수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPProdResultOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1C = new SmartMES_Bluewings.P1C.DataSetP1C();
            this.sPProdResultQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ProdResult_QueryTableAdapter = new SmartMES_Bluewings.P1C.DataSetP1CTableAdapters.SP_ProdResult_QueryTableAdapter();
            this.sP_ProdResult_OrderTableAdapter = new SmartMES_Bluewings.P1C.DataSetP1CTableAdapters.SP_ProdResult_OrderTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lotNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재ADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재명ADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.중량ADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재BDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재명BDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.중량BDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재MBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재명MBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.중량MBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.배합시간DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업시작 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업종료 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.소요시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.배합기 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPProdResultOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPProdResultQueryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "생산일지등록";
            // 
            // pbPrint
            // 
            this.pbPrint.Enabled = true;
            this.pbPrint.Image = global::SmartMES_Bluewings.Properties.Resources.out_A;
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
            // panSearch
            // 
            this.panSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearch.AutoSize = true;
            this.panSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSearch.Controls.Add(this.lblDone);
            this.panSearch.Controls.Add(this.lblNo);
            this.panSearch.Controls.Add(this.btnFinish);
            this.panSearch.Controls.Add(this.btnStart);
            this.panSearch.Controls.Add(this.dtpDoneTime);
            this.panSearch.Controls.Add(this.dtpStartTime);
            this.panSearch.Controls.Add(this.label5);
            this.panSearch.Controls.Add(this.label4);
            this.panSearch.Controls.Add(this.btnUpdate);
            this.panSearch.Controls.Add(this.btnDone);
            this.panSearch.Controls.Add(this.lblBarcode);
            this.panSearch.Controls.Add(this.tbBarcode);
            this.panSearch.Controls.Add(this.lblBar);
            this.panSearch.Controls.Add(this.lblMsg);
            this.panSearch.Controls.Add(this.userButtonA2);
            this.panSearch.Controls.Add(this.userButtonA1);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.dtpDate);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 152);
            this.panSearch.TabIndex = 0;
            // 
            // lblDone
            // 
            this.lblDone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDone.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblDone.Location = new System.Drawing.Point(1006, 99);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(20, 28);
            this.lblDone.TabIndex = 84;
            this.lblDone.Text = "-";
            // 
            // lblNo
            // 
            this.lblNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNo.Location = new System.Drawing.Point(343, 45);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(56, 21);
            this.lblNo.TabIndex = 83;
            this.lblNo.Text = "LotNo";
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFinish.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.작업종료;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinish.Location = new System.Drawing.Point(181, 70);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(154, 50);
            this.btnFinish.TabIndex = 81;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.작업시작;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Location = new System.Drawing.Point(181, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 50);
            this.btnStart.TabIndex = 82;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dtpDoneTime
            // 
            this.dtpDoneTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDoneTime.Enabled = false;
            this.dtpDoneTime.Location = new System.Drawing.Point(739, 74);
            this.dtpDoneTime.Mask = "0000-90-90 90:90:90";
            this.dtpDoneTime.Name = "dtpDoneTime";
            this.dtpDoneTime.Size = new System.Drawing.Size(211, 29);
            this.dtpDoneTime.TabIndex = 80;
            this.dtpDoneTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStartTime.Enabled = false;
            this.dtpStartTime.Location = new System.Drawing.Point(424, 74);
            this.dtpStartTime.Mask = "0000-90-90 90:90:90";
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(211, 29);
            this.dtpStartTime.TabIndex = 79;
            this.dtpStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(662, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 78;
            this.label5.Text = "작업종료";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(343, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "작업시작";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Location = new System.Drawing.Point(1005, 16);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 29);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "사용량 가져오기";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDone.Location = new System.Drawing.Point(864, 15);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(122, 29);
            this.btnDone.TabIndex = 30;
            this.btnDone.Text = "생산완료처리";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblBarcode.ForeColor = System.Drawing.Color.Red;
            this.lblBarcode.Location = new System.Drawing.Point(1166, 0);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(148, 21);
            this.lblBarcode.TabIndex = 29;
            this.lblBarcode.Text = "메시지 라벨입니다.";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbBarcode.Location = new System.Drawing.Point(1070, 45);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(244, 29);
            this.tbBarcode.TabIndex = 27;
            this.tbBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBarcode.Visible = false;
            // 
            // lblBar
            // 
            this.lblBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBar.AutoSize = true;
            this.lblBar.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBar.Location = new System.Drawing.Point(1006, 49);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(58, 21);
            this.lblBar.TabIndex = 28;
            this.lblBar.Text = "바코드";
            this.lblBar.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(-1, 48);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // userButtonA2
            // 
            this.userButtonA2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userButtonA2.BackColor = System.Drawing.Color.Transparent;
            this.userButtonA2.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.right2;
            this.userButtonA2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userButtonA2.buttonImage = global::SmartMES_Bluewings.Properties.Resources.right2;
            this.userButtonA2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userButtonA2.Location = new System.Drawing.Point(797, 24);
            this.userButtonA2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userButtonA2.Name = "userButtonA2";
            this.userButtonA2.Size = new System.Drawing.Size(60, 20);
            this.userButtonA2.TabIndex = 3;
            this.userButtonA2.Click += new System.EventHandler(this.userButtonA2_Click);
            // 
            // userButtonA1
            // 
            this.userButtonA1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userButtonA1.BackColor = System.Drawing.Color.Transparent;
            this.userButtonA1.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.left2;
            this.userButtonA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userButtonA1.buttonImage = global::SmartMES_Bluewings.Properties.Resources.left2;
            this.userButtonA1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userButtonA1.Location = new System.Drawing.Point(516, 24);
            this.userButtonA1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userButtonA1.Name = "userButtonA1";
            this.userButtonA1.Size = new System.Drawing.Size(60, 20);
            this.userButtonA1.TabIndex = 1;
            this.userButtonA1.Click += new System.EventHandler(this.userButtonA1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(436, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "작업일자";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Location = new System.Drawing.Point(581, 20);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(211, 29);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // jobNoDataGridViewTextBoxColumn
            // 
            this.jobNoDataGridViewTextBoxColumn.DataPropertyName = "JobNo";
            this.jobNoDataGridViewTextBoxColumn.HeaderText = "JobNo";
            this.jobNoDataGridViewTextBoxColumn.Name = "jobNoDataGridViewTextBoxColumn";
            this.jobNoDataGridViewTextBoxColumn.Width = 189;
            // 
            // 공정명DataGridViewTextBoxColumn
            // 
            this.공정명DataGridViewTextBoxColumn.DataPropertyName = "공정명";
            this.공정명DataGridViewTextBoxColumn.HeaderText = "공정명";
            this.공정명DataGridViewTextBoxColumn.Name = "공정명DataGridViewTextBoxColumn";
            this.공정명DataGridViewTextBoxColumn.Visible = false;
            // 
            // 작업자IDDataGridViewTextBoxColumn
            // 
            this.작업자IDDataGridViewTextBoxColumn.DataPropertyName = "작업자ID";
            this.작업자IDDataGridViewTextBoxColumn.HeaderText = "작업자ID";
            this.작업자IDDataGridViewTextBoxColumn.Name = "작업자IDDataGridViewTextBoxColumn";
            this.작업자IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 작업자DataGridViewTextBoxColumn
            // 
            this.작업자DataGridViewTextBoxColumn.DataPropertyName = "작업자";
            this.작업자DataGridViewTextBoxColumn.HeaderText = "작업자";
            this.작업자DataGridViewTextBoxColumn.Name = "작업자DataGridViewTextBoxColumn";
            this.작업자DataGridViewTextBoxColumn.Visible = false;
            // 
            // 품목코드DataGridViewTextBoxColumn
            // 
            this.품목코드DataGridViewTextBoxColumn.DataPropertyName = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.HeaderText = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.Name = "품목코드DataGridViewTextBoxColumn";
            this.품목코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 품목명DataGridViewTextBoxColumn
            // 
            this.품목명DataGridViewTextBoxColumn.DataPropertyName = "품목명";
            this.품목명DataGridViewTextBoxColumn.HeaderText = "균주명";
            this.품목명DataGridViewTextBoxColumn.Name = "품목명DataGridViewTextBoxColumn";
            this.품목명DataGridViewTextBoxColumn.Width = 188;
            // 
            // 규격DataGridViewTextBoxColumn
            // 
            this.규격DataGridViewTextBoxColumn.DataPropertyName = "규격";
            this.규격DataGridViewTextBoxColumn.HeaderText = "규격";
            this.규격DataGridViewTextBoxColumn.Name = "규격DataGridViewTextBoxColumn";
            this.규격DataGridViewTextBoxColumn.Visible = false;
            // 
            // 조건1
            // 
            this.조건1.DataPropertyName = "조건1";
            this.조건1.HeaderText = "조건1";
            this.조건1.Name = "조건1";
            this.조건1.Visible = false;
            // 
            // 조건2
            // 
            this.조건2.DataPropertyName = "조건2";
            this.조건2.HeaderText = "조건2";
            this.조건2.Name = "조건2";
            this.조건2.Visible = false;
            // 
            // 조건3
            // 
            this.조건3.DataPropertyName = "조건3";
            this.조건3.HeaderText = "조건3";
            this.조건3.Name = "조건3";
            this.조건3.Visible = false;
            // 
            // 조건4
            // 
            this.조건4.DataPropertyName = "조건4";
            this.조건4.HeaderText = "조건4";
            this.조건4.Name = "조건4";
            this.조건4.Visible = false;
            // 
            // 조건5
            // 
            this.조건5.DataPropertyName = "조건5";
            this.조건5.HeaderText = "조건5";
            this.조건5.Name = "조건5";
            this.조건5.Visible = false;
            // 
            // 조건6
            // 
            this.조건6.DataPropertyName = "조건6";
            this.조건6.HeaderText = "조건6";
            this.조건6.Name = "조건6";
            this.조건6.Visible = false;
            // 
            // 조건7
            // 
            this.조건7.DataPropertyName = "조건7";
            this.조건7.HeaderText = "조건7";
            this.조건7.Name = "조건7";
            this.조건7.Visible = false;
            // 
            // 외봉투탈피여부
            // 
            this.외봉투탈피여부.DataPropertyName = "외봉투탈피여부";
            this.외봉투탈피여부.HeaderText = "외봉투탈피여부";
            this.외봉투탈피여부.Name = "외봉투탈피여부";
            this.외봉투탈피여부.Visible = false;
            // 
            // 외봉투탈피일시
            // 
            this.외봉투탈피일시.DataPropertyName = "외봉투탈피일시";
            this.외봉투탈피일시.HeaderText = "외봉투탈피일시";
            this.외봉투탈피일시.Name = "외봉투탈피일시";
            this.외봉투탈피일시.Visible = false;
            // 
            // 양품수량DataGridViewTextBoxColumn
            // 
            this.양품수량DataGridViewTextBoxColumn.DataPropertyName = "양품수량";
            this.양품수량DataGridViewTextBoxColumn.HeaderText = "양품수량";
            this.양품수량DataGridViewTextBoxColumn.Name = "양품수량DataGridViewTextBoxColumn";
            this.양품수량DataGridViewTextBoxColumn.Visible = false;
            // 
            // 불량수량DataGridViewTextBoxColumn
            // 
            this.불량수량DataGridViewTextBoxColumn.DataPropertyName = "불량수량";
            this.불량수량DataGridViewTextBoxColumn.HeaderText = "불량수량";
            this.불량수량DataGridViewTextBoxColumn.Name = "불량수량DataGridViewTextBoxColumn";
            this.불량수량DataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lotNoDataGridViewTextBoxColumn,
            this.일자DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.품목코드DataGridViewTextBoxColumn1,
            this.품목명DataGridViewTextBoxColumn1,
            this.자재ADataGridViewTextBoxColumn,
            this.자재명ADataGridViewTextBoxColumn,
            this.중량ADataGridViewTextBoxColumn,
            this.자재BDataGridViewTextBoxColumn,
            this.자재명BDataGridViewTextBoxColumn,
            this.중량BDataGridViewTextBoxColumn,
            this.자재MBDataGridViewTextBoxColumn,
            this.자재명MBDataGridViewTextBoxColumn,
            this.중량MBDataGridViewTextBoxColumn,
            this.배합시간DataGridViewTextBoxColumn,
            this.작업시작,
            this.작업종료,
            this.소요시간,
            this.배합기});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPProdResultOrderBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 214);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 764);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // sPProdResultOrderBindingSource
            // 
            this.sPProdResultOrderBindingSource.DataMember = "SP_ProdResult_Order";
            this.sPProdResultOrderBindingSource.DataSource = this.dataSetP1C;
            // 
            // dataSetP1C
            // 
            this.dataSetP1C.DataSetName = "DataSetP1C";
            this.dataSetP1C.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPProdResultQueryBindingSource
            // 
            this.sPProdResultQueryBindingSource.DataMember = "SP_ProdResult_Query";
            this.sPProdResultQueryBindingSource.DataSource = this.dataSetP1C;
            // 
            // sP_ProdResult_QueryTableAdapter
            // 
            this.sP_ProdResult_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // sP_ProdResult_OrderTableAdapter
            // 
            this.sP_ProdResult_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // lotNoDataGridViewTextBoxColumn
            // 
            this.lotNoDataGridViewTextBoxColumn.DataPropertyName = "LotNo";
            this.lotNoDataGridViewTextBoxColumn.HeaderText = "LotNo";
            this.lotNoDataGridViewTextBoxColumn.Name = "lotNoDataGridViewTextBoxColumn";
            this.lotNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // 일자DataGridViewTextBoxColumn
            // 
            this.일자DataGridViewTextBoxColumn.DataPropertyName = "일자";
            this.일자DataGridViewTextBoxColumn.HeaderText = "일자";
            this.일자DataGridViewTextBoxColumn.Name = "일자DataGridViewTextBoxColumn";
            this.일자DataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "설비코드";
            this.dataGridViewTextBoxColumn1.HeaderText = "설비코드";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "설비명";
            this.dataGridViewTextBoxColumn2.HeaderText = "설비명";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // 품목코드DataGridViewTextBoxColumn1
            // 
            this.품목코드DataGridViewTextBoxColumn1.DataPropertyName = "품목코드";
            this.품목코드DataGridViewTextBoxColumn1.HeaderText = "품목코드";
            this.품목코드DataGridViewTextBoxColumn1.Name = "품목코드DataGridViewTextBoxColumn1";
            this.품목코드DataGridViewTextBoxColumn1.Visible = false;
            // 
            // 품목명DataGridViewTextBoxColumn1
            // 
            this.품목명DataGridViewTextBoxColumn1.DataPropertyName = "품목명";
            this.품목명DataGridViewTextBoxColumn1.HeaderText = "품목명";
            this.품목명DataGridViewTextBoxColumn1.Name = "품목명DataGridViewTextBoxColumn1";
            // 
            // 자재ADataGridViewTextBoxColumn
            // 
            this.자재ADataGridViewTextBoxColumn.DataPropertyName = "자재A";
            this.자재ADataGridViewTextBoxColumn.HeaderText = "자재A";
            this.자재ADataGridViewTextBoxColumn.Name = "자재ADataGridViewTextBoxColumn";
            this.자재ADataGridViewTextBoxColumn.Visible = false;
            // 
            // 자재명ADataGridViewTextBoxColumn
            // 
            this.자재명ADataGridViewTextBoxColumn.DataPropertyName = "자재명A";
            this.자재명ADataGridViewTextBoxColumn.HeaderText = "자재명A";
            this.자재명ADataGridViewTextBoxColumn.Name = "자재명ADataGridViewTextBoxColumn";
            this.자재명ADataGridViewTextBoxColumn.Visible = false;
            // 
            // 중량ADataGridViewTextBoxColumn
            // 
            this.중량ADataGridViewTextBoxColumn.DataPropertyName = "중량A";
            this.중량ADataGridViewTextBoxColumn.HeaderText = "중량A";
            this.중량ADataGridViewTextBoxColumn.Name = "중량ADataGridViewTextBoxColumn";
            // 
            // 자재BDataGridViewTextBoxColumn
            // 
            this.자재BDataGridViewTextBoxColumn.DataPropertyName = "자재B";
            this.자재BDataGridViewTextBoxColumn.HeaderText = "자재B";
            this.자재BDataGridViewTextBoxColumn.Name = "자재BDataGridViewTextBoxColumn";
            this.자재BDataGridViewTextBoxColumn.Visible = false;
            // 
            // 자재명BDataGridViewTextBoxColumn
            // 
            this.자재명BDataGridViewTextBoxColumn.DataPropertyName = "자재명B";
            this.자재명BDataGridViewTextBoxColumn.HeaderText = "자재명B";
            this.자재명BDataGridViewTextBoxColumn.Name = "자재명BDataGridViewTextBoxColumn";
            this.자재명BDataGridViewTextBoxColumn.Visible = false;
            // 
            // 중량BDataGridViewTextBoxColumn
            // 
            this.중량BDataGridViewTextBoxColumn.DataPropertyName = "중량B";
            this.중량BDataGridViewTextBoxColumn.HeaderText = "중량B";
            this.중량BDataGridViewTextBoxColumn.Name = "중량BDataGridViewTextBoxColumn";
            // 
            // 자재MBDataGridViewTextBoxColumn
            // 
            this.자재MBDataGridViewTextBoxColumn.DataPropertyName = "자재MB";
            this.자재MBDataGridViewTextBoxColumn.HeaderText = "자재MB";
            this.자재MBDataGridViewTextBoxColumn.Name = "자재MBDataGridViewTextBoxColumn";
            this.자재MBDataGridViewTextBoxColumn.Visible = false;
            // 
            // 자재명MBDataGridViewTextBoxColumn
            // 
            this.자재명MBDataGridViewTextBoxColumn.DataPropertyName = "자재명MB";
            this.자재명MBDataGridViewTextBoxColumn.HeaderText = "자재명MB";
            this.자재명MBDataGridViewTextBoxColumn.Name = "자재명MBDataGridViewTextBoxColumn";
            this.자재명MBDataGridViewTextBoxColumn.Visible = false;
            // 
            // 중량MBDataGridViewTextBoxColumn
            // 
            this.중량MBDataGridViewTextBoxColumn.DataPropertyName = "중량MB";
            this.중량MBDataGridViewTextBoxColumn.HeaderText = "중량MB";
            this.중량MBDataGridViewTextBoxColumn.Name = "중량MBDataGridViewTextBoxColumn";
            // 
            // 배합시간DataGridViewTextBoxColumn
            // 
            this.배합시간DataGridViewTextBoxColumn.DataPropertyName = "배합시간";
            this.배합시간DataGridViewTextBoxColumn.HeaderText = "배합시간";
            this.배합시간DataGridViewTextBoxColumn.Name = "배합시간DataGridViewTextBoxColumn";
            this.배합시간DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 작업시작
            // 
            this.작업시작.DataPropertyName = "작업시작";
            this.작업시작.HeaderText = "작업시작시간";
            this.작업시작.Name = "작업시작";
            this.작업시작.ReadOnly = true;
            // 
            // 작업종료
            // 
            this.작업종료.DataPropertyName = "작업종료";
            this.작업종료.HeaderText = "작업종료";
            this.작업종료.Name = "작업종료";
            this.작업종료.Visible = false;
            // 
            // 소요시간
            // 
            this.소요시간.DataPropertyName = "소요시간";
            this.소요시간.HeaderText = "소요시간";
            this.소요시간.Name = "소요시간";
            this.소요시간.Visible = false;
            // 
            // 배합기
            // 
            this.배합기.DataPropertyName = "배합기";
            this.배합기.HeaderText = "배합기";
            this.배합기.Name = "배합기";
            this.배합기.Visible = false;
            // 
            // P1C02_PROD_RESULT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1C02_PROD_RESULT1";
            this.Text = "P1C02_PROD_RESULT1";
            this.Load += new System.EventHandler(this.P1C02_PROD_RESULT1_Load);
            this.Shown += new System.EventHandler(this.P1C02_PROD_RESULT1_Shown);
            this.Controls.SetChildIndex(this.panSearch, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPProdResultOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPProdResultQueryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private UserButtonA userButtonA2;
        private UserButtonA userButtonA1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn118;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn119;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn 최종공정여부DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품창고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 운전자IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 운전자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 호기DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 접종DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량사유DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량내역DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 타공여부DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 타공일시DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업자IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건6;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조건7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 외봉투탈피여부;
        private System.Windows.Forms.DataGridViewTextBoxColumn 외봉투탈피일시;
        private System.Windows.Forms.DataGridViewTextBoxColumn 양품수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 순번DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.BindingSource sPProdResultQuery1BindingSource;
        private System.Windows.Forms.Label lblBarcode;
        public System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부자재품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부자재명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산수율DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 로스율DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn jonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 원료품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 원료명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 투입계산량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재로트DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 실투입량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산지시일DataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox dtpDoneTime;
        private System.Windows.Forms.MaskedTextBox dtpStartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sPProdResultQueryBindingSource;
        private P1C.DataSetP1C dataSetP1C;
        private P1C.DataSetP1CTableAdapters.SP_ProdResult_QueryTableAdapter sP_ProdResult_QueryTableAdapter;
        private System.Windows.Forms.BindingSource sPProdResultOrderBindingSource;
        private P1C.DataSetP1CTableAdapters.SP_ProdResult_OrderTableAdapter sP_ProdResult_OrderTableAdapter;
        public System.Windows.Forms.Button btnFinish;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재ADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재명ADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 중량ADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재BDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재명BDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 중량BDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재MBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재명MBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 중량MBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 배합시간DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업시작;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업종료;
        private System.Windows.Forms.DataGridViewTextBoxColumn 소요시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 배합기;
    }
}

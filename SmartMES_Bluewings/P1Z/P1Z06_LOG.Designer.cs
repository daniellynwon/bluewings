namespace SmartMES_Bluewings
{
    partial class P1Z06_LOG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cbP = new System.Windows.Forms.CheckBox();
            this.cbM = new System.Windows.Forms.CheckBox();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.cbS = new System.Windows.Forms.CheckBox();
            this.cbO = new System.Windows.Forms.CheckBox();
            this.cbI = new System.Windows.Forms.CheckBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.작업일시DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용자명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.접속IPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.프로그램명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업내용DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPLogQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1Z = new SmartMES_Bluewings.P1Z.DataSetP1Z();
            this.sP_Log_QueryTableAdapter = new SmartMES_Bluewings.P1Z.DataSetP1ZTableAdapters.SP_Log_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPLogQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1Z)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "사용로그정보";
            // 
            // pbPrint
            // 
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // pbSave
            // 
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbDel
            // 
            this.pbDel.Image = global::SmartMES_Bluewings.Properties.Resources.del_A;
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
            this.panSearch.Controls.Add(this.label3);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.dtpToDate);
            this.panSearch.Controls.Add(this.dtpFromDate);
            this.panSearch.Controls.Add(this.cbP);
            this.panSearch.Controls.Add(this.cbM);
            this.panSearch.Controls.Add(this.cbD);
            this.panSearch.Controls.Add(this.cbS);
            this.panSearch.Controls.Add(this.cbO);
            this.panSearch.Controls.Add(this.cbI);
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 71);
            this.panSearch.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(1066, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(808, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "기간";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpToDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Location = new System.Drawing.Point(1089, 19);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(211, 29);
            this.dtpToDate.TabIndex = 9;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromDate.Location = new System.Drawing.Point(853, 19);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(211, 29);
            this.dtpFromDate.TabIndex = 8;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cbP
            // 
            this.cbP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbP.AutoSize = true;
            this.cbP.Checked = true;
            this.cbP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbP.Location = new System.Drawing.Point(424, 21);
            this.cbP.Name = "cbP";
            this.cbP.Size = new System.Drawing.Size(61, 25);
            this.cbP.TabIndex = 6;
            this.cbP.Text = "인쇄";
            this.cbP.UseVisualStyleBackColor = true;
            this.cbP.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbM
            // 
            this.cbM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbM.AutoSize = true;
            this.cbM.Checked = true;
            this.cbM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbM.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbM.Location = new System.Drawing.Point(353, 21);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(61, 25);
            this.cbM.TabIndex = 5;
            this.cbM.Text = "수정";
            this.cbM.UseVisualStyleBackColor = true;
            this.cbM.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbD
            // 
            this.cbD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbD.AutoSize = true;
            this.cbD.Checked = true;
            this.cbD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbD.Location = new System.Drawing.Point(282, 21);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(61, 25);
            this.cbD.TabIndex = 4;
            this.cbD.Text = "삭제";
            this.cbD.UseVisualStyleBackColor = true;
            this.cbD.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbS
            // 
            this.cbS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbS.AutoSize = true;
            this.cbS.Checked = true;
            this.cbS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbS.Location = new System.Drawing.Point(211, 21);
            this.cbS.Name = "cbS";
            this.cbS.Size = new System.Drawing.Size(61, 25);
            this.cbS.TabIndex = 3;
            this.cbS.Text = "조회";
            this.cbS.UseVisualStyleBackColor = true;
            this.cbS.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbO
            // 
            this.cbO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbO.AutoSize = true;
            this.cbO.Checked = true;
            this.cbO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbO.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbO.Location = new System.Drawing.Point(108, 21);
            this.cbO.Name = "cbO";
            this.cbO.Size = new System.Drawing.Size(93, 25);
            this.cbO.TabIndex = 2;
            this.cbO.Text = "로그아웃";
            this.cbO.UseVisualStyleBackColor = true;
            this.cbO.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbI
            // 
            this.cbI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbI.AutoSize = true;
            this.cbI.Checked = true;
            this.cbI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbI.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbI.Location = new System.Drawing.Point(21, 21);
            this.cbI.Name = "cbI";
            this.cbI.Size = new System.Drawing.Size(77, 25);
            this.cbI.TabIndex = 1;
            this.cbI.Text = "로그인";
            this.cbI.UseVisualStyleBackColor = true;
            this.cbI.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(567, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(218, 29);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(506, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "검색어";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.작업일시DataGridViewTextBoxColumn,
            this.구분DataGridViewTextBoxColumn,
            this.사용자명DataGridViewTextBoxColumn,
            this.접속IPDataGridViewTextBoxColumn,
            this.프로그램명DataGridViewTextBoxColumn,
            this.작업내용DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPLogQueryBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 852);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // 작업일시DataGridViewTextBoxColumn
            // 
            this.작업일시DataGridViewTextBoxColumn.DataPropertyName = "작업일시";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm:ss";
            this.작업일시DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.작업일시DataGridViewTextBoxColumn.FillWeight = 80F;
            this.작업일시DataGridViewTextBoxColumn.HeaderText = "작업일시";
            this.작업일시DataGridViewTextBoxColumn.Name = "작업일시DataGridViewTextBoxColumn";
            this.작업일시DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 구분DataGridViewTextBoxColumn
            // 
            this.구분DataGridViewTextBoxColumn.DataPropertyName = "구분";
            this.구분DataGridViewTextBoxColumn.FillWeight = 50F;
            this.구분DataGridViewTextBoxColumn.HeaderText = "구분";
            this.구분DataGridViewTextBoxColumn.Name = "구분DataGridViewTextBoxColumn";
            this.구분DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 사용자명DataGridViewTextBoxColumn
            // 
            this.사용자명DataGridViewTextBoxColumn.DataPropertyName = "사용자명";
            this.사용자명DataGridViewTextBoxColumn.FillWeight = 50F;
            this.사용자명DataGridViewTextBoxColumn.HeaderText = "사용자명";
            this.사용자명DataGridViewTextBoxColumn.Name = "사용자명DataGridViewTextBoxColumn";
            this.사용자명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 접속IPDataGridViewTextBoxColumn
            // 
            this.접속IPDataGridViewTextBoxColumn.DataPropertyName = "접속IP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.접속IPDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.접속IPDataGridViewTextBoxColumn.FillWeight = 120F;
            this.접속IPDataGridViewTextBoxColumn.HeaderText = "접속IP";
            this.접속IPDataGridViewTextBoxColumn.Name = "접속IPDataGridViewTextBoxColumn";
            this.접속IPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 프로그램명DataGridViewTextBoxColumn
            // 
            this.프로그램명DataGridViewTextBoxColumn.DataPropertyName = "프로그램명";
            this.프로그램명DataGridViewTextBoxColumn.FillWeight = 80F;
            this.프로그램명DataGridViewTextBoxColumn.HeaderText = "프로그램명";
            this.프로그램명DataGridViewTextBoxColumn.Name = "프로그램명DataGridViewTextBoxColumn";
            this.프로그램명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 작업내용DataGridViewTextBoxColumn
            // 
            this.작업내용DataGridViewTextBoxColumn.DataPropertyName = "작업내용";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.작업내용DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.작업내용DataGridViewTextBoxColumn.FillWeight = 170F;
            this.작업내용DataGridViewTextBoxColumn.HeaderText = "작업내용";
            this.작업내용DataGridViewTextBoxColumn.Name = "작업내용DataGridViewTextBoxColumn";
            this.작업내용DataGridViewTextBoxColumn.ReadOnly = true;
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
            // P1Z06_LOG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1Z06_LOG";
            this.Text = "P1Z06_LOG";
            this.Load += new System.EventHandler(this.P1Z06_LOG_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPLogQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1Z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private P1Z.DataSetP1Z dataSetP1Z;        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.CheckBox cbP;
        private System.Windows.Forms.CheckBox cbM;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.CheckBox cbS;
        private System.Windows.Forms.CheckBox cbO;
        private System.Windows.Forms.CheckBox cbI;
        private System.Windows.Forms.BindingSource sPLogQueryBindingSource;
        private P1Z.DataSetP1ZTableAdapters.SP_Log_QueryTableAdapter sP_Log_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업일시DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용자명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 접속IPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 프로그램명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업내용DataGridViewTextBoxColumn;
    }
}

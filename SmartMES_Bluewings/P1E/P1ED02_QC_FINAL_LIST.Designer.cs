namespace SmartMES_Bluewings
{
    partial class P1ED02_QC_FINAL_LIST
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetP1E = new SmartMES_Bluewings.P1E.DataSetP1E();
            this.sP_QcFinalList_QueryTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_QcFinalList_QueryTableAdapter();
            this.sPQcFinalListQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.검사일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.현장정보 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수주번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.의견DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.불합격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.합격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대기DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.항목수DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사원DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사원IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.출하DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납기DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.접수DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalListQueryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "품질검사현황";
            // 
            // pbPrint
            // 
            this.pbPrint.Enabled = true;
            this.pbPrint.Image = global::SmartMES_Bluewings.Properties.Resources.out_A;
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // pbSave
            // 
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
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label4);
            this.panSearch.Controls.Add(this.label3);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.dtpToDate);
            this.panSearch.Controls.Add(this.dtpFromDate);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 71);
            this.panSearch.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(910, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(265, 29);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(747, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "거래처명/현장정보";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(429, 24);
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
            this.label2.Location = new System.Drawing.Point(139, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "검사기간";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpToDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Location = new System.Drawing.Point(452, 20);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(211, 29);
            this.dtpToDate.TabIndex = 2;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromDate.Location = new System.Drawing.Point(216, 20);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(211, 29);
            this.dtpFromDate.TabIndex = 1;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.수주번호DataGridViewTextBoxColumn,
            this.접수DataGridViewTextBoxColumn,
            this.거래처명DataGridViewTextBoxColumn,
            this.현장정보,
            this.납기DataGridViewTextBoxColumn,
            this.출하DataGridViewTextBoxColumn,
            this.검사일DataGridViewTextBoxColumn,
            this.검사원IDDataGridViewTextBoxColumn,
            this.검사원DataGridViewTextBoxColumn,
            this.항목수DataGridViewTextBoxColumn,
            this.대기DataGridViewTextBoxColumn,
            this.합격DataGridViewTextBoxColumn,
            this.불합격DataGridViewTextBoxColumn,
            this.의견DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPQcFinalListQueryBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 852);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSetP1E
            // 
            this.dataSetP1E.DataSetName = "DataSetP1E";
            this.dataSetP1E.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_QcFinalList_QueryTableAdapter
            // 
            this.sP_QcFinalList_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // sPQcFinalListQueryBindingSource
            // 
            this.sPQcFinalListQueryBindingSource.DataMember = "SP_QcFinalList_Query";
            this.sPQcFinalListQueryBindingSource.DataSource = this.dataSetP1E;
            // 
            // 검사일DataGridViewTextBoxColumn
            // 
            this.검사일DataGridViewTextBoxColumn.DataPropertyName = "검사일";
            dataGridViewCellStyle6.Format = "MM\\/dd";
            this.검사일DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.검사일DataGridViewTextBoxColumn.FillWeight = 40F;
            this.검사일DataGridViewTextBoxColumn.HeaderText = "검사일";
            this.검사일DataGridViewTextBoxColumn.Name = "검사일DataGridViewTextBoxColumn";
            this.검사일DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 현장정보
            // 
            this.현장정보.DataPropertyName = "현장정보";
            this.현장정보.FillWeight = 80F;
            this.현장정보.HeaderText = "현장정보";
            this.현장정보.Name = "현장정보";
            this.현장정보.ReadOnly = true;
            // 
            // 수주번호DataGridViewTextBoxColumn
            // 
            this.수주번호DataGridViewTextBoxColumn.DataPropertyName = "수주번호";
            this.수주번호DataGridViewTextBoxColumn.HeaderText = "수주번호";
            this.수주번호DataGridViewTextBoxColumn.Name = "수주번호DataGridViewTextBoxColumn";
            this.수주번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.수주번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 의견DataGridViewTextBoxColumn
            // 
            this.의견DataGridViewTextBoxColumn.DataPropertyName = "의견";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.의견DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.의견DataGridViewTextBoxColumn.HeaderText = "의견";
            this.의견DataGridViewTextBoxColumn.Name = "의견DataGridViewTextBoxColumn";
            this.의견DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 불합격DataGridViewTextBoxColumn
            // 
            this.불합격DataGridViewTextBoxColumn.DataPropertyName = "불합격";
            this.불합격DataGridViewTextBoxColumn.FillWeight = 40F;
            this.불합격DataGridViewTextBoxColumn.HeaderText = "불합격";
            this.불합격DataGridViewTextBoxColumn.Name = "불합격DataGridViewTextBoxColumn";
            this.불합격DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 합격DataGridViewTextBoxColumn
            // 
            this.합격DataGridViewTextBoxColumn.DataPropertyName = "합격";
            this.합격DataGridViewTextBoxColumn.FillWeight = 40F;
            this.합격DataGridViewTextBoxColumn.HeaderText = "합격";
            this.합격DataGridViewTextBoxColumn.Name = "합격DataGridViewTextBoxColumn";
            this.합격DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 대기DataGridViewTextBoxColumn
            // 
            this.대기DataGridViewTextBoxColumn.DataPropertyName = "대기";
            this.대기DataGridViewTextBoxColumn.FillWeight = 40F;
            this.대기DataGridViewTextBoxColumn.HeaderText = "대기";
            this.대기DataGridViewTextBoxColumn.Name = "대기DataGridViewTextBoxColumn";
            this.대기DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 항목수DataGridViewTextBoxColumn
            // 
            this.항목수DataGridViewTextBoxColumn.DataPropertyName = "항목수";
            this.항목수DataGridViewTextBoxColumn.FillWeight = 40F;
            this.항목수DataGridViewTextBoxColumn.HeaderText = "항목수";
            this.항목수DataGridViewTextBoxColumn.Name = "항목수DataGridViewTextBoxColumn";
            this.항목수DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 검사원DataGridViewTextBoxColumn
            // 
            this.검사원DataGridViewTextBoxColumn.DataPropertyName = "검사원";
            this.검사원DataGridViewTextBoxColumn.FillWeight = 40F;
            this.검사원DataGridViewTextBoxColumn.HeaderText = "검사원";
            this.검사원DataGridViewTextBoxColumn.Name = "검사원DataGridViewTextBoxColumn";
            this.검사원DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 검사원IDDataGridViewTextBoxColumn
            // 
            this.검사원IDDataGridViewTextBoxColumn.DataPropertyName = "검사원ID";
            this.검사원IDDataGridViewTextBoxColumn.HeaderText = "검사원ID";
            this.검사원IDDataGridViewTextBoxColumn.Name = "검사원IDDataGridViewTextBoxColumn";
            this.검사원IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.검사원IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 출하DataGridViewTextBoxColumn
            // 
            this.출하DataGridViewTextBoxColumn.DataPropertyName = "출하";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle5.Format = "MM\\/dd";
            this.출하DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.출하DataGridViewTextBoxColumn.FillWeight = 40F;
            this.출하DataGridViewTextBoxColumn.HeaderText = "출하";
            this.출하DataGridViewTextBoxColumn.Name = "출하DataGridViewTextBoxColumn";
            this.출하DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 납기DataGridViewTextBoxColumn
            // 
            this.납기DataGridViewTextBoxColumn.DataPropertyName = "납기";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle4.Format = "MM\\/dd";
            this.납기DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.납기DataGridViewTextBoxColumn.FillWeight = 40F;
            this.납기DataGridViewTextBoxColumn.HeaderText = "납기";
            this.납기DataGridViewTextBoxColumn.Name = "납기DataGridViewTextBoxColumn";
            this.납기DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 거래처명DataGridViewTextBoxColumn
            // 
            this.거래처명DataGridViewTextBoxColumn.DataPropertyName = "거래처명";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            this.거래처명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.거래처명DataGridViewTextBoxColumn.FillWeight = 80F;
            this.거래처명DataGridViewTextBoxColumn.HeaderText = "거래처명";
            this.거래처명DataGridViewTextBoxColumn.Name = "거래처명DataGridViewTextBoxColumn";
            this.거래처명DataGridViewTextBoxColumn.ReadOnly = true;
            this.거래처명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.거래처명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 접수DataGridViewTextBoxColumn
            // 
            this.접수DataGridViewTextBoxColumn.DataPropertyName = "접수";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Format = "MM\\/dd";
            this.접수DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.접수DataGridViewTextBoxColumn.FillWeight = 40F;
            this.접수DataGridViewTextBoxColumn.HeaderText = "접수";
            this.접수DataGridViewTextBoxColumn.Name = "접수DataGridViewTextBoxColumn";
            this.접수DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // P1ED02_QC_FINAL_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1ED02_QC_FINAL_LIST";
            this.Text = "P1ED02_QC_FINAL_LIST";
            this.Load += new System.EventHandler(this.P1ED02_QC_FINAL_LIST_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalListQueryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpToDate;
        public System.Windows.Forms.DateTimePicker dtpFromDate;
        public System.Windows.Forms.TextBox tbSearch;
        private P1E.DataSetP1E dataSetP1E;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 접수DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 거래처명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 현장정보;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납기DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 출하DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사원IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사원DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 항목수DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대기DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 합격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불합격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 의견DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPQcFinalListQueryBindingSource;
        private P1E.DataSetP1ETableAdapters.SP_QcFinalList_QueryTableAdapter sP_QcFinalList_QueryTableAdapter;
    }
}

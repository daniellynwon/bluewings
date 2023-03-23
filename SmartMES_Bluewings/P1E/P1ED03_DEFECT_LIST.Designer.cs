namespace SmartMES_Bluewings
{
    partial class P1ED03_DEFECT_LIST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1ED03_DEFECT_LIST));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.외관DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관벽두께1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관벽두께2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관벽두께3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.최소내벽1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.최소내벽2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.최소내벽3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.안지름1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.안지름2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.안지름3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.길이1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.길이2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.길이3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판정DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPQcQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1E = new SmartMES_Bluewings.P1E.DataSetP1E();
            this.sP_Qc_QueryTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_Qc_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "불량품관리";
            // 
            // pbPrint
            // 
            this.pbPrint.Enabled = true;
            this.pbPrint.Image = global::SmartMES_Bluewings.Properties.Resources.out_A;
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
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
            this.panSearch.Controls.Add(this.label5);
            this.panSearch.Controls.Add(this.label3);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.dtpToDate);
            this.panSearch.Controls.Add(this.dtpFromDate);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 68);
            this.panSearch.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.Location = new System.Drawing.Point(850, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(169, 29);
            this.tbSearch.TabIndex = 20;
            this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(721, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "설비명/품목명";
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
            this.label2.Text = "발주기간";
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobNoDataGridViewTextBoxColumn,
            this.설비코드DataGridViewTextBoxColumn,
            this.설비명DataGridViewTextBoxColumn,
            this.검사일자DataGridViewTextBoxColumn,
            this.품목코드DataGridViewTextBoxColumn,
            this.품목명DataGridViewTextBoxColumn,
            this.외관DataGridViewTextBoxColumn,
            this.관벽두께1DataGridViewTextBoxColumn,
            this.관벽두께2DataGridViewTextBoxColumn,
            this.관벽두께3DataGridViewTextBoxColumn,
            this.최소내벽1DataGridViewTextBoxColumn,
            this.최소내벽2DataGridViewTextBoxColumn,
            this.최소내벽3DataGridViewTextBoxColumn,
            this.안지름1DataGridViewTextBoxColumn,
            this.안지름2DataGridViewTextBoxColumn,
            this.안지름3DataGridViewTextBoxColumn,
            this.길이1DataGridViewTextBoxColumn,
            this.길이2DataGridViewTextBoxColumn,
            this.길이3DataGridViewTextBoxColumn,
            this.판정DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPQcQueryBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 132);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 851);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // jobNoDataGridViewTextBoxColumn
            // 
            this.jobNoDataGridViewTextBoxColumn.DataPropertyName = "jobNo";
            this.jobNoDataGridViewTextBoxColumn.FillWeight = 80F;
            this.jobNoDataGridViewTextBoxColumn.HeaderText = "jobNo";
            this.jobNoDataGridViewTextBoxColumn.Name = "jobNoDataGridViewTextBoxColumn";
            this.jobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 설비코드DataGridViewTextBoxColumn
            // 
            this.설비코드DataGridViewTextBoxColumn.DataPropertyName = "설비코드";
            this.설비코드DataGridViewTextBoxColumn.HeaderText = "설비코드";
            this.설비코드DataGridViewTextBoxColumn.Name = "설비코드DataGridViewTextBoxColumn";
            this.설비코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.설비코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 설비명DataGridViewTextBoxColumn
            // 
            this.설비명DataGridViewTextBoxColumn.DataPropertyName = "설비명";
            this.설비명DataGridViewTextBoxColumn.FillWeight = 80F;
            this.설비명DataGridViewTextBoxColumn.HeaderText = "설비명";
            this.설비명DataGridViewTextBoxColumn.Name = "설비명DataGridViewTextBoxColumn";
            this.설비명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 검사일자DataGridViewTextBoxColumn
            // 
            this.검사일자DataGridViewTextBoxColumn.DataPropertyName = "검사일자";
            this.검사일자DataGridViewTextBoxColumn.HeaderText = "검사일자";
            this.검사일자DataGridViewTextBoxColumn.Name = "검사일자DataGridViewTextBoxColumn";
            this.검사일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 품목코드DataGridViewTextBoxColumn
            // 
            this.품목코드DataGridViewTextBoxColumn.DataPropertyName = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.HeaderText = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.Name = "품목코드DataGridViewTextBoxColumn";
            this.품목코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.품목코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 품목명DataGridViewTextBoxColumn
            // 
            this.품목명DataGridViewTextBoxColumn.DataPropertyName = "품목명";
            this.품목명DataGridViewTextBoxColumn.FillWeight = 80F;
            this.품목명DataGridViewTextBoxColumn.HeaderText = "품목명";
            this.품목명DataGridViewTextBoxColumn.Name = "품목명DataGridViewTextBoxColumn";
            this.품목명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 외관DataGridViewTextBoxColumn
            // 
            this.외관DataGridViewTextBoxColumn.DataPropertyName = "외관";
            this.외관DataGridViewTextBoxColumn.FillWeight = 30F;
            this.외관DataGridViewTextBoxColumn.HeaderText = "외관";
            this.외관DataGridViewTextBoxColumn.Name = "외관DataGridViewTextBoxColumn";
            this.외관DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 관벽두께1DataGridViewTextBoxColumn
            // 
            this.관벽두께1DataGridViewTextBoxColumn.DataPropertyName = "관벽두께1";
            this.관벽두께1DataGridViewTextBoxColumn.FillWeight = 50F;
            this.관벽두께1DataGridViewTextBoxColumn.HeaderText = "n1";
            this.관벽두께1DataGridViewTextBoxColumn.Name = "관벽두께1DataGridViewTextBoxColumn";
            this.관벽두께1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 관벽두께2DataGridViewTextBoxColumn
            // 
            this.관벽두께2DataGridViewTextBoxColumn.DataPropertyName = "관벽두께2";
            this.관벽두께2DataGridViewTextBoxColumn.FillWeight = 50F;
            this.관벽두께2DataGridViewTextBoxColumn.HeaderText = "n2";
            this.관벽두께2DataGridViewTextBoxColumn.Name = "관벽두께2DataGridViewTextBoxColumn";
            this.관벽두께2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 관벽두께3DataGridViewTextBoxColumn
            // 
            this.관벽두께3DataGridViewTextBoxColumn.DataPropertyName = "관벽두께3";
            this.관벽두께3DataGridViewTextBoxColumn.FillWeight = 50F;
            this.관벽두께3DataGridViewTextBoxColumn.HeaderText = "n3";
            this.관벽두께3DataGridViewTextBoxColumn.Name = "관벽두께3DataGridViewTextBoxColumn";
            this.관벽두께3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 최소내벽1DataGridViewTextBoxColumn
            // 
            this.최소내벽1DataGridViewTextBoxColumn.DataPropertyName = "최소내벽1";
            this.최소내벽1DataGridViewTextBoxColumn.FillWeight = 50F;
            this.최소내벽1DataGridViewTextBoxColumn.HeaderText = "n1";
            this.최소내벽1DataGridViewTextBoxColumn.Name = "최소내벽1DataGridViewTextBoxColumn";
            this.최소내벽1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 최소내벽2DataGridViewTextBoxColumn
            // 
            this.최소내벽2DataGridViewTextBoxColumn.DataPropertyName = "최소내벽2";
            this.최소내벽2DataGridViewTextBoxColumn.FillWeight = 50F;
            this.최소내벽2DataGridViewTextBoxColumn.HeaderText = "n2";
            this.최소내벽2DataGridViewTextBoxColumn.Name = "최소내벽2DataGridViewTextBoxColumn";
            this.최소내벽2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 최소내벽3DataGridViewTextBoxColumn
            // 
            this.최소내벽3DataGridViewTextBoxColumn.DataPropertyName = "최소내벽3";
            this.최소내벽3DataGridViewTextBoxColumn.FillWeight = 50F;
            this.최소내벽3DataGridViewTextBoxColumn.HeaderText = "n3";
            this.최소내벽3DataGridViewTextBoxColumn.Name = "최소내벽3DataGridViewTextBoxColumn";
            this.최소내벽3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 안지름1DataGridViewTextBoxColumn
            // 
            this.안지름1DataGridViewTextBoxColumn.DataPropertyName = "안지름1";
            this.안지름1DataGridViewTextBoxColumn.FillWeight = 50F;
            this.안지름1DataGridViewTextBoxColumn.HeaderText = "n1";
            this.안지름1DataGridViewTextBoxColumn.Name = "안지름1DataGridViewTextBoxColumn";
            this.안지름1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 안지름2DataGridViewTextBoxColumn
            // 
            this.안지름2DataGridViewTextBoxColumn.DataPropertyName = "안지름2";
            this.안지름2DataGridViewTextBoxColumn.FillWeight = 50F;
            this.안지름2DataGridViewTextBoxColumn.HeaderText = "n2";
            this.안지름2DataGridViewTextBoxColumn.Name = "안지름2DataGridViewTextBoxColumn";
            this.안지름2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 안지름3DataGridViewTextBoxColumn
            // 
            this.안지름3DataGridViewTextBoxColumn.DataPropertyName = "안지름3";
            this.안지름3DataGridViewTextBoxColumn.FillWeight = 50F;
            this.안지름3DataGridViewTextBoxColumn.HeaderText = "n3";
            this.안지름3DataGridViewTextBoxColumn.Name = "안지름3DataGridViewTextBoxColumn";
            this.안지름3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 길이1DataGridViewTextBoxColumn
            // 
            this.길이1DataGridViewTextBoxColumn.DataPropertyName = "길이1";
            dataGridViewCellStyle8.Format = "#,##0";
            this.길이1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.길이1DataGridViewTextBoxColumn.FillWeight = 50F;
            this.길이1DataGridViewTextBoxColumn.HeaderText = "n1";
            this.길이1DataGridViewTextBoxColumn.Name = "길이1DataGridViewTextBoxColumn";
            this.길이1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 길이2DataGridViewTextBoxColumn
            // 
            this.길이2DataGridViewTextBoxColumn.DataPropertyName = "길이2";
            dataGridViewCellStyle9.Format = "#,##0";
            this.길이2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.길이2DataGridViewTextBoxColumn.FillWeight = 50F;
            this.길이2DataGridViewTextBoxColumn.HeaderText = "n2";
            this.길이2DataGridViewTextBoxColumn.Name = "길이2DataGridViewTextBoxColumn";
            this.길이2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 길이3DataGridViewTextBoxColumn
            // 
            this.길이3DataGridViewTextBoxColumn.DataPropertyName = "길이3";
            dataGridViewCellStyle10.Format = "#,##0";
            this.길이3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.길이3DataGridViewTextBoxColumn.FillWeight = 50F;
            this.길이3DataGridViewTextBoxColumn.HeaderText = "n3";
            this.길이3DataGridViewTextBoxColumn.Name = "길이3DataGridViewTextBoxColumn";
            this.길이3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 판정DataGridViewTextBoxColumn
            // 
            this.판정DataGridViewTextBoxColumn.DataPropertyName = "판정";
            this.판정DataGridViewTextBoxColumn.FillWeight = 30F;
            this.판정DataGridViewTextBoxColumn.HeaderText = "판정";
            this.판정DataGridViewTextBoxColumn.Name = "판정DataGridViewTextBoxColumn";
            this.판정DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPQcQueryBindingSource
            // 
            this.sPQcQueryBindingSource.DataMember = "SP_Qc_Query";
            this.sPQcQueryBindingSource.DataSource = this.dataSetP1E;
            // 
            // dataSetP1E
            // 
            this.dataSetP1E.DataSetName = "DataSetP1E";
            this.dataSetP1E.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_Qc_QueryTableAdapter
            // 
            this.sP_Qc_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1ED03_DEFECT_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1ED03_DEFECT_LIST";
            this.Text = "P1ED03_DEFECT_LIST";
            this.Load += new System.EventHandler(this.P1ED03_DEFECT_LIST_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPQcQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpToDate;
        public System.Windows.Forms.DateTimePicker dtpFromDate;
        private P1E.DataSetP1E dataSetP1E;
        private System.Windows.Forms.BindingSource sPQcQueryBindingSource;
        private P1E.DataSetP1ETableAdapters.SP_Qc_QueryTableAdapter sP_Qc_QueryTableAdapter;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 외관DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관벽두께1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관벽두께2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관벽두께3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 최소내벽1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 최소내벽2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 최소내벽3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 안지름1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 안지름2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 안지름3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 길이1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 길이2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 길이3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판정DataGridViewTextBoxColumn;
    }
}

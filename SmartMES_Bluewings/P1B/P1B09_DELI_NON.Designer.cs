namespace SmartMES_Bluewings
{
    partial class P1B09_DELI_NON
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.수주번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.접수일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.영업담당DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.프로젝트명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.현장정보DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.납기DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목수DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.금액DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPDeliNonQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1B = new SmartMES_Bluewings.P1B.DataSetP1B();
            this.sP_DeliNon_QueryTableAdapter = new SmartMES_Bluewings.P1B.DataSetP1BTableAdapters.SP_DeliNon_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDeliNonQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1B)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "미출하현황";
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
            this.panSearch.Controls.Add(this.label3);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.dtpToDate);
            this.panSearch.Controls.Add(this.dtpFromDate);
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
            this.label3.Location = new System.Drawing.Point(363, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(73, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "수주기간";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpToDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Location = new System.Drawing.Point(386, 20);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(211, 29);
            this.dtpToDate.TabIndex = 3;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromDate.Location = new System.Drawing.Point(150, 20);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(211, 29);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(973, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(257, 29);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(801, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "거래처/영업담당/현장";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.수주번호DataGridViewTextBoxColumn,
            this.접수일자DataGridViewTextBoxColumn,
            this.거래처IDDataGridViewTextBoxColumn,
            this.거래처명DataGridViewTextBoxColumn,
            this.영업담당DataGridViewTextBoxColumn,
            this.프로젝트명DataGridViewTextBoxColumn,
            this.현장정보DataGridViewTextBoxColumn,
            this.납기DataGridViewTextBoxColumn,
            this.품목수DataGridViewTextBoxColumn,
            this.수량DataGridViewTextBoxColumn,
            this.금액DataGridViewTextBoxColumn,
            this.구분DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPDeliNonQueryBindingSource;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
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
            // 수주번호DataGridViewTextBoxColumn
            // 
            this.수주번호DataGridViewTextBoxColumn.DataPropertyName = "수주번호";
            this.수주번호DataGridViewTextBoxColumn.HeaderText = "수주번호";
            this.수주번호DataGridViewTextBoxColumn.Name = "수주번호DataGridViewTextBoxColumn";
            this.수주번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.수주번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 접수일자DataGridViewTextBoxColumn
            // 
            this.접수일자DataGridViewTextBoxColumn.DataPropertyName = "접수일자";
            dataGridViewCellStyle15.Format = "yyyy-MM-dd";
            this.접수일자DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.접수일자DataGridViewTextBoxColumn.HeaderText = "접수일자";
            this.접수일자DataGridViewTextBoxColumn.Name = "접수일자DataGridViewTextBoxColumn";
            this.접수일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 거래처IDDataGridViewTextBoxColumn
            // 
            this.거래처IDDataGridViewTextBoxColumn.DataPropertyName = "거래처ID";
            this.거래처IDDataGridViewTextBoxColumn.HeaderText = "거래처ID";
            this.거래처IDDataGridViewTextBoxColumn.Name = "거래처IDDataGridViewTextBoxColumn";
            this.거래처IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.거래처IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 거래처명DataGridViewTextBoxColumn
            // 
            this.거래처명DataGridViewTextBoxColumn.DataPropertyName = "거래처명";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.거래처명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.거래처명DataGridViewTextBoxColumn.FillWeight = 120F;
            this.거래처명DataGridViewTextBoxColumn.HeaderText = "거래처명";
            this.거래처명DataGridViewTextBoxColumn.Name = "거래처명DataGridViewTextBoxColumn";
            this.거래처명DataGridViewTextBoxColumn.ReadOnly = true;
            this.거래처명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.거래처명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 영업담당DataGridViewTextBoxColumn
            // 
            this.영업담당DataGridViewTextBoxColumn.DataPropertyName = "영업담당";
            this.영업담당DataGridViewTextBoxColumn.FillWeight = 70F;
            this.영업담당DataGridViewTextBoxColumn.HeaderText = "영업담당";
            this.영업담당DataGridViewTextBoxColumn.Name = "영업담당DataGridViewTextBoxColumn";
            this.영업담당DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 프로젝트명DataGridViewTextBoxColumn
            // 
            this.프로젝트명DataGridViewTextBoxColumn.DataPropertyName = "프로젝트명";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.프로젝트명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.프로젝트명DataGridViewTextBoxColumn.FillWeight = 170F;
            this.프로젝트명DataGridViewTextBoxColumn.HeaderText = "프로젝트명";
            this.프로젝트명DataGridViewTextBoxColumn.Name = "프로젝트명DataGridViewTextBoxColumn";
            this.프로젝트명DataGridViewTextBoxColumn.ReadOnly = true;
            this.프로젝트명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.프로젝트명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.프로젝트명DataGridViewTextBoxColumn.Visible = false;
            // 
            // 현장정보DataGridViewTextBoxColumn
            // 
            this.현장정보DataGridViewTextBoxColumn.DataPropertyName = "현장정보";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.현장정보DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.현장정보DataGridViewTextBoxColumn.HeaderText = "현장정보";
            this.현장정보DataGridViewTextBoxColumn.Name = "현장정보DataGridViewTextBoxColumn";
            this.현장정보DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 납기DataGridViewTextBoxColumn
            // 
            this.납기DataGridViewTextBoxColumn.DataPropertyName = "납기";
            dataGridViewCellStyle19.Format = "MM\\/dd";
            this.납기DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.납기DataGridViewTextBoxColumn.FillWeight = 50F;
            this.납기DataGridViewTextBoxColumn.HeaderText = "납기";
            this.납기DataGridViewTextBoxColumn.Name = "납기DataGridViewTextBoxColumn";
            this.납기DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 품목수DataGridViewTextBoxColumn
            // 
            this.품목수DataGridViewTextBoxColumn.DataPropertyName = "품목수";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N0";
            dataGridViewCellStyle20.NullValue = null;
            this.품목수DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.품목수DataGridViewTextBoxColumn.FillWeight = 60F;
            this.품목수DataGridViewTextBoxColumn.HeaderText = "품목수";
            this.품목수DataGridViewTextBoxColumn.Name = "품목수DataGridViewTextBoxColumn";
            this.품목수DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 수량DataGridViewTextBoxColumn
            // 
            this.수량DataGridViewTextBoxColumn.DataPropertyName = "수량";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N0";
            this.수량DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.수량DataGridViewTextBoxColumn.FillWeight = 60F;
            this.수량DataGridViewTextBoxColumn.HeaderText = "수량";
            this.수량DataGridViewTextBoxColumn.Name = "수량DataGridViewTextBoxColumn";
            this.수량DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 금액DataGridViewTextBoxColumn
            // 
            this.금액DataGridViewTextBoxColumn.DataPropertyName = "금액";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N0";
            this.금액DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.금액DataGridViewTextBoxColumn.HeaderText = "금액";
            this.금액DataGridViewTextBoxColumn.Name = "금액DataGridViewTextBoxColumn";
            this.금액DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 구분DataGridViewTextBoxColumn
            // 
            this.구분DataGridViewTextBoxColumn.DataPropertyName = "구분";
            this.구분DataGridViewTextBoxColumn.FillWeight = 50F;
            this.구분DataGridViewTextBoxColumn.HeaderText = "구분";
            this.구분DataGridViewTextBoxColumn.Name = "구분DataGridViewTextBoxColumn";
            this.구분DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPDeliNonQueryBindingSource
            // 
            this.sPDeliNonQueryBindingSource.DataMember = "SP_DeliNon_Query";
            this.sPDeliNonQueryBindingSource.DataSource = this.dataSetP1B;
            // 
            // dataSetP1B
            // 
            this.dataSetP1B.DataSetName = "DataSetP1B";
            this.dataSetP1B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DeliNon_QueryTableAdapter
            // 
            this.sP_DeliNon_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1B09_DELI_NON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1B09_DELI_NON";
            this.Text = "P1B09_DELI_NON";
            this.Activated += new System.EventHandler(this.P1B09_DELI_NON_Activated);
            this.Load += new System.EventHandler(this.P1B09_DELI_NON_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPDeliNonQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sPDeliNonQueryBindingSource;
        private P1B.DataSetP1B dataSetP1B;
        private P1B.DataSetP1BTableAdapters.SP_DeliNon_QueryTableAdapter sP_DeliNon_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 접수일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 거래처명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 영업담당DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 프로젝트명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 현장정보DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 납기DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목수DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금액DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분DataGridViewTextBoxColumn;
    }
}

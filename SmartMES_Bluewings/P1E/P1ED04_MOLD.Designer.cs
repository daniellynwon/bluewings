namespace SmartMES_Bluewings
{
    partial class P1ED04_MOLD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1ED04_MOLD));
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPMoldListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1E = new SmartMES_Bluewings.P1E.DataSetP1E();
            this.sP_Mold_ListTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_Mold_ListTableAdapter();
            this.금형번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.금형명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제작사DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제작사명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제작일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제작비용DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보관장소DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상태DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.이동시각DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.경과시간DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.소요비용DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.파일명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용여부DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.금형상태 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구분 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.현위치 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.이동장소 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.이동시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.첨부파일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.장소 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMoldListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "금형관리";
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
            this.pbAdd.Image = global::SmartMES_Bluewings.Properties.Resources.add_A;
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
            this.label3.Location = new System.Drawing.Point(934, 24);
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
            this.label2.Location = new System.Drawing.Point(673, 24);
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
            this.dtpToDate.Location = new System.Drawing.Point(957, 20);
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
            this.dtpFromDate.Location = new System.Drawing.Point(721, 20);
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
            this.tbSearch.Location = new System.Drawing.Point(299, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(265, 29);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(165, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "금형명/제작사";
            // 
            // dataGridView1
            // 
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
            this.금형번호DataGridViewTextBoxColumn,
            this.금형명DataGridViewTextBoxColumn,
            this.제작사DataGridViewTextBoxColumn,
            this.제작사명DataGridViewTextBoxColumn,
            this.제작일자DataGridViewTextBoxColumn,
            this.제작비용DataGridViewTextBoxColumn,
            this.보관장소DataGridViewTextBoxColumn,
            this.상태DataGridViewTextBoxColumn,
            this.이동시각DataGridViewTextBoxColumn,
            this.경과시간DataGridViewTextBoxColumn,
            this.소요비용DataGridViewTextBoxColumn,
            this.파일명DataGridViewTextBoxColumn,
            this.사용여부DataGridViewTextBoxColumn,
            this.Column1,
            this.금형상태,
            this.구분,
            this.현위치,
            this.이동장소,
            this.이동시간,
            this.첨부파일,
            this.장소});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPMoldListBindingSource;
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
            // sPMoldListBindingSource
            // 
            this.sPMoldListBindingSource.DataMember = "SP_Mold_List";
            this.sPMoldListBindingSource.DataSource = this.dataSetP1E;
            // 
            // dataSetP1E
            // 
            this.dataSetP1E.DataSetName = "DataSetP1E";
            this.dataSetP1E.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_Mold_ListTableAdapter
            // 
            this.sP_Mold_ListTableAdapter.ClearBeforeFill = true;
            // 
            // 금형번호DataGridViewTextBoxColumn
            // 
            this.금형번호DataGridViewTextBoxColumn.DataPropertyName = "금형번호";
            this.금형번호DataGridViewTextBoxColumn.HeaderText = "금형번호";
            this.금형번호DataGridViewTextBoxColumn.Name = "금형번호DataGridViewTextBoxColumn";
            this.금형번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.금형번호DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.금형번호DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 금형명DataGridViewTextBoxColumn
            // 
            this.금형명DataGridViewTextBoxColumn.DataPropertyName = "금형명";
            this.금형명DataGridViewTextBoxColumn.HeaderText = "금형명";
            this.금형명DataGridViewTextBoxColumn.Name = "금형명DataGridViewTextBoxColumn";
            this.금형명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 제작사DataGridViewTextBoxColumn
            // 
            this.제작사DataGridViewTextBoxColumn.DataPropertyName = "제작사";
            this.제작사DataGridViewTextBoxColumn.HeaderText = "제작사";
            this.제작사DataGridViewTextBoxColumn.Name = "제작사DataGridViewTextBoxColumn";
            this.제작사DataGridViewTextBoxColumn.ReadOnly = true;
            this.제작사DataGridViewTextBoxColumn.Visible = false;
            // 
            // 제작사명DataGridViewTextBoxColumn
            // 
            this.제작사명DataGridViewTextBoxColumn.DataPropertyName = "제작사명";
            this.제작사명DataGridViewTextBoxColumn.HeaderText = "제작사";
            this.제작사명DataGridViewTextBoxColumn.Name = "제작사명DataGridViewTextBoxColumn";
            this.제작사명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 제작일자DataGridViewTextBoxColumn
            // 
            this.제작일자DataGridViewTextBoxColumn.DataPropertyName = "제작일자";
            this.제작일자DataGridViewTextBoxColumn.HeaderText = "제작일자";
            this.제작일자DataGridViewTextBoxColumn.Name = "제작일자DataGridViewTextBoxColumn";
            this.제작일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 제작비용DataGridViewTextBoxColumn
            // 
            this.제작비용DataGridViewTextBoxColumn.DataPropertyName = "제작비용";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0";
            this.제작비용DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.제작비용DataGridViewTextBoxColumn.HeaderText = "제작비용";
            this.제작비용DataGridViewTextBoxColumn.Name = "제작비용DataGridViewTextBoxColumn";
            this.제작비용DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 보관장소DataGridViewTextBoxColumn
            // 
            this.보관장소DataGridViewTextBoxColumn.DataPropertyName = "보관장소";
            this.보관장소DataGridViewTextBoxColumn.HeaderText = "보관장소";
            this.보관장소DataGridViewTextBoxColumn.Name = "보관장소DataGridViewTextBoxColumn";
            this.보관장소DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 상태DataGridViewTextBoxColumn
            // 
            this.상태DataGridViewTextBoxColumn.DataPropertyName = "상태";
            this.상태DataGridViewTextBoxColumn.FillWeight = 60F;
            this.상태DataGridViewTextBoxColumn.HeaderText = "상태";
            this.상태DataGridViewTextBoxColumn.Name = "상태DataGridViewTextBoxColumn";
            this.상태DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 이동시각DataGridViewTextBoxColumn
            // 
            this.이동시각DataGridViewTextBoxColumn.DataPropertyName = "이동시각";
            this.이동시각DataGridViewTextBoxColumn.HeaderText = "이동시각";
            this.이동시각DataGridViewTextBoxColumn.Name = "이동시각DataGridViewTextBoxColumn";
            this.이동시각DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 경과시간DataGridViewTextBoxColumn
            // 
            this.경과시간DataGridViewTextBoxColumn.DataPropertyName = "경과시간";
            this.경과시간DataGridViewTextBoxColumn.HeaderText = "경과시간";
            this.경과시간DataGridViewTextBoxColumn.Name = "경과시간DataGridViewTextBoxColumn";
            this.경과시간DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 소요비용DataGridViewTextBoxColumn
            // 
            this.소요비용DataGridViewTextBoxColumn.DataPropertyName = "비용";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,##0";
            this.소요비용DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.소요비용DataGridViewTextBoxColumn.HeaderText = "비용";
            this.소요비용DataGridViewTextBoxColumn.Name = "소요비용DataGridViewTextBoxColumn";
            this.소요비용DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 파일명DataGridViewTextBoxColumn
            // 
            this.파일명DataGridViewTextBoxColumn.DataPropertyName = "파일명";
            this.파일명DataGridViewTextBoxColumn.HeaderText = "파일명";
            this.파일명DataGridViewTextBoxColumn.Name = "파일명DataGridViewTextBoxColumn";
            this.파일명DataGridViewTextBoxColumn.ReadOnly = true;
            this.파일명DataGridViewTextBoxColumn.Visible = false;
            // 
            // 사용여부DataGridViewTextBoxColumn
            // 
            this.사용여부DataGridViewTextBoxColumn.DataPropertyName = "사용여부";
            this.사용여부DataGridViewTextBoxColumn.HeaderText = "사용여부";
            this.사용여부DataGridViewTextBoxColumn.Name = "사용여부DataGridViewTextBoxColumn";
            this.사용여부DataGridViewTextBoxColumn.ReadOnly = true;
            this.사용여부DataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "이동";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "이동";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // 금형상태
            // 
            this.금형상태.DataPropertyName = "금형상태";
            this.금형상태.HeaderText = "금형상태";
            this.금형상태.Name = "금형상태";
            this.금형상태.ReadOnly = true;
            this.금형상태.Visible = false;
            // 
            // 구분
            // 
            this.구분.DataPropertyName = "구분";
            this.구분.HeaderText = "구분";
            this.구분.Name = "구분";
            this.구분.ReadOnly = true;
            this.구분.Visible = false;
            // 
            // 현위치
            // 
            this.현위치.DataPropertyName = "현위치";
            this.현위치.HeaderText = "현위치";
            this.현위치.Name = "현위치";
            this.현위치.ReadOnly = true;
            this.현위치.Visible = false;
            // 
            // 이동장소
            // 
            this.이동장소.DataPropertyName = "이동장소";
            this.이동장소.HeaderText = "이동장소";
            this.이동장소.Name = "이동장소";
            this.이동장소.ReadOnly = true;
            this.이동장소.Visible = false;
            // 
            // 이동시간
            // 
            this.이동시간.DataPropertyName = "이동시간";
            this.이동시간.HeaderText = "이동시간";
            this.이동시간.Name = "이동시간";
            this.이동시간.ReadOnly = true;
            this.이동시간.Visible = false;
            // 
            // 첨부파일
            // 
            this.첨부파일.DataPropertyName = "첨부파일";
            this.첨부파일.HeaderText = "첨부파일";
            this.첨부파일.Name = "첨부파일";
            this.첨부파일.ReadOnly = true;
            this.첨부파일.Visible = false;
            // 
            // 장소
            // 
            this.장소.DataPropertyName = "장소";
            this.장소.HeaderText = "장소";
            this.장소.Name = "장소";
            this.장소.ReadOnly = true;
            this.장소.Visible = false;
            // 
            // P1ED04_MOLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1ED04_MOLD";
            this.Text = "P1ED04_MOLD";
            this.Load += new System.EventHandler(this.P1ED04_MOLD_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPMoldListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.BindingSource sPMoldListBindingSource;
        private P1E.DataSetP1E dataSetP1E;
        private P1E.DataSetP1ETableAdapters.SP_Mold_ListTableAdapter sP_Mold_ListTableAdapter;
        private System.Windows.Forms.DataGridViewLinkColumn 금형번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금형명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제작사DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제작사명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제작일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제작비용DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보관장소DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상태DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이동시각DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 경과시간DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 소요비용DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 파일명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용여부DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 금형상태;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분;
        private System.Windows.Forms.DataGridViewTextBoxColumn 현위치;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이동장소;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이동시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 첨부파일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 장소;
    }
}

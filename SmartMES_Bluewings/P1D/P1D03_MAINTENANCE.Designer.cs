namespace SmartMES_Bluewings
{
    partial class P1D03_MAINTENANCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1D03_MAINTENANCE));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.설비IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.호기DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.설비그룹 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.순번DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.점검일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.고장일시 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수리일시 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.소요시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.점검형태DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보전목표DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조치결과DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.점검자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.소요비용DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모델번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.파일이름1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.파일이름2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.파일이름3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPMachineRepairQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1D = new SmartMES_Bluewings.P1D.DataSetP1D();
            this.sP_MachineRepair_QueryTableAdapter = new SmartMES_Bluewings.P1D.DataSetP1DTableAdapters.SP_MachineRepair_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMachineRepairQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1D)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "설비보전등록";
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
            this.pbDel.Image = global::SmartMES_Bluewings.Properties.Resources.del_A;
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
            this.label2.Location = new System.Drawing.Point(644, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "점검기간";
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
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "설비그룹/설비명";
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
            this.설비IDDataGridViewTextBoxColumn,
            this.호기DataGridViewTextBoxColumn,
            this.설비명DataGridViewTextBoxColumn,
            this.설비그룹,
            this.순번DataGridViewTextBoxColumn,
            this.점검일자DataGridViewTextBoxColumn,
            this.고장일시,
            this.수리일시,
            this.소요시간,
            this.점검형태DataGridViewTextBoxColumn,
            this.보전목표DataGridViewTextBoxColumn,
            this.조치결과DataGridViewTextBoxColumn,
            this.점검자DataGridViewTextBoxColumn,
            this.소요비용DataGridViewTextBoxColumn,
            this.비고DataGridViewTextBoxColumn,
            this.모델번호DataGridViewTextBoxColumn,
            this.파일이름1,
            this.파일이름2,
            this.파일이름3});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPMachineRepairQueryBindingSource;
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
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // 설비IDDataGridViewTextBoxColumn
            // 
            this.설비IDDataGridViewTextBoxColumn.DataPropertyName = "설비ID";
            this.설비IDDataGridViewTextBoxColumn.HeaderText = "설비ID";
            this.설비IDDataGridViewTextBoxColumn.Name = "설비IDDataGridViewTextBoxColumn";
            this.설비IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.설비IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 호기DataGridViewTextBoxColumn
            // 
            this.호기DataGridViewTextBoxColumn.DataPropertyName = "호기";
            this.호기DataGridViewTextBoxColumn.FillWeight = 60F;
            this.호기DataGridViewTextBoxColumn.HeaderText = "호기";
            this.호기DataGridViewTextBoxColumn.Name = "호기DataGridViewTextBoxColumn";
            this.호기DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 설비명DataGridViewTextBoxColumn
            // 
            this.설비명DataGridViewTextBoxColumn.DataPropertyName = "설비명";
            this.설비명DataGridViewTextBoxColumn.FillWeight = 120F;
            this.설비명DataGridViewTextBoxColumn.HeaderText = "설비명";
            this.설비명DataGridViewTextBoxColumn.Name = "설비명DataGridViewTextBoxColumn";
            this.설비명DataGridViewTextBoxColumn.ReadOnly = true;
            this.설비명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.설비명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 설비그룹
            // 
            this.설비그룹.DataPropertyName = "설비그룹";
            this.설비그룹.FillWeight = 80F;
            this.설비그룹.HeaderText = "설비그룹";
            this.설비그룹.Name = "설비그룹";
            this.설비그룹.ReadOnly = true;
            // 
            // 순번DataGridViewTextBoxColumn
            // 
            this.순번DataGridViewTextBoxColumn.DataPropertyName = "순번";
            this.순번DataGridViewTextBoxColumn.HeaderText = "순번";
            this.순번DataGridViewTextBoxColumn.Name = "순번DataGridViewTextBoxColumn";
            this.순번DataGridViewTextBoxColumn.ReadOnly = true;
            this.순번DataGridViewTextBoxColumn.Visible = false;
            // 
            // 점검일자DataGridViewTextBoxColumn
            // 
            this.점검일자DataGridViewTextBoxColumn.DataPropertyName = "점검일자";
            this.점검일자DataGridViewTextBoxColumn.FillWeight = 80F;
            this.점검일자DataGridViewTextBoxColumn.HeaderText = "등록일";
            this.점검일자DataGridViewTextBoxColumn.Name = "점검일자DataGridViewTextBoxColumn";
            this.점검일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 고장일시
            // 
            this.고장일시.DataPropertyName = "고장일시";
            dataGridViewCellStyle3.Format = "MM\\/dd HH:mm";
            this.고장일시.DefaultCellStyle = dataGridViewCellStyle3;
            this.고장일시.HeaderText = "고장일시";
            this.고장일시.Name = "고장일시";
            this.고장일시.ReadOnly = true;
            this.고장일시.Visible = false;
            // 
            // 수리일시
            // 
            this.수리일시.DataPropertyName = "수리일시";
            dataGridViewCellStyle4.Format = "MM\\/dd HH:mm";
            this.수리일시.DefaultCellStyle = dataGridViewCellStyle4;
            this.수리일시.HeaderText = "수리일시";
            this.수리일시.Name = "수리일시";
            this.수리일시.ReadOnly = true;
            this.수리일시.Visible = false;
            // 
            // 소요시간
            // 
            this.소요시간.DataPropertyName = "소요시간";
            this.소요시간.HeaderText = "소요시간";
            this.소요시간.Name = "소요시간";
            this.소요시간.ReadOnly = true;
            this.소요시간.Visible = false;
            // 
            // 점검형태DataGridViewTextBoxColumn
            // 
            this.점검형태DataGridViewTextBoxColumn.DataPropertyName = "점검형태";
            this.점검형태DataGridViewTextBoxColumn.HeaderText = "점검형태";
            this.점검형태DataGridViewTextBoxColumn.Name = "점검형태DataGridViewTextBoxColumn";
            this.점검형태DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 보전목표DataGridViewTextBoxColumn
            // 
            this.보전목표DataGridViewTextBoxColumn.DataPropertyName = "보전목표";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.보전목표DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.보전목표DataGridViewTextBoxColumn.FillWeight = 180F;
            this.보전목표DataGridViewTextBoxColumn.HeaderText = "보전목표";
            this.보전목표DataGridViewTextBoxColumn.Name = "보전목표DataGridViewTextBoxColumn";
            this.보전목표DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 조치결과DataGridViewTextBoxColumn
            // 
            this.조치결과DataGridViewTextBoxColumn.DataPropertyName = "조치결과";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.조치결과DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.조치결과DataGridViewTextBoxColumn.FillWeight = 180F;
            this.조치결과DataGridViewTextBoxColumn.HeaderText = "조치결과";
            this.조치결과DataGridViewTextBoxColumn.Name = "조치결과DataGridViewTextBoxColumn";
            this.조치결과DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 점검자DataGridViewTextBoxColumn
            // 
            this.점검자DataGridViewTextBoxColumn.DataPropertyName = "점검자";
            this.점검자DataGridViewTextBoxColumn.HeaderText = "점검자";
            this.점검자DataGridViewTextBoxColumn.Name = "점검자DataGridViewTextBoxColumn";
            this.점검자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 소요비용DataGridViewTextBoxColumn
            // 
            this.소요비용DataGridViewTextBoxColumn.DataPropertyName = "소요비용";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.소요비용DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.소요비용DataGridViewTextBoxColumn.HeaderText = "소요비용";
            this.소요비용DataGridViewTextBoxColumn.Name = "소요비용DataGridViewTextBoxColumn";
            this.소요비용DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 비고DataGridViewTextBoxColumn
            // 
            this.비고DataGridViewTextBoxColumn.DataPropertyName = "비고";
            this.비고DataGridViewTextBoxColumn.HeaderText = "비고";
            this.비고DataGridViewTextBoxColumn.Name = "비고DataGridViewTextBoxColumn";
            this.비고DataGridViewTextBoxColumn.ReadOnly = true;
            this.비고DataGridViewTextBoxColumn.Visible = false;
            // 
            // 모델번호DataGridViewTextBoxColumn
            // 
            this.모델번호DataGridViewTextBoxColumn.DataPropertyName = "모델번호";
            this.모델번호DataGridViewTextBoxColumn.HeaderText = "모델번호";
            this.모델번호DataGridViewTextBoxColumn.Name = "모델번호DataGridViewTextBoxColumn";
            this.모델번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.모델번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 파일이름1
            // 
            this.파일이름1.DataPropertyName = "파일이름1";
            this.파일이름1.HeaderText = "파일이름1";
            this.파일이름1.Name = "파일이름1";
            this.파일이름1.ReadOnly = true;
            this.파일이름1.Visible = false;
            // 
            // 파일이름2
            // 
            this.파일이름2.DataPropertyName = "파일이름2";
            this.파일이름2.HeaderText = "파일이름2";
            this.파일이름2.Name = "파일이름2";
            this.파일이름2.ReadOnly = true;
            this.파일이름2.Visible = false;
            // 
            // 파일이름3
            // 
            this.파일이름3.DataPropertyName = "파일이름3";
            this.파일이름3.HeaderText = "파일이름3";
            this.파일이름3.Name = "파일이름3";
            this.파일이름3.ReadOnly = true;
            this.파일이름3.Visible = false;
            // 
            // sPMachineRepairQueryBindingSource
            // 
            this.sPMachineRepairQueryBindingSource.DataMember = "SP_MachineRepair_Query";
            this.sPMachineRepairQueryBindingSource.DataSource = this.dataSetP1D;
            // 
            // dataSetP1D
            // 
            this.dataSetP1D.DataSetName = "DataSetP1D";
            this.dataSetP1D.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_MachineRepair_QueryTableAdapter
            // 
            this.sP_MachineRepair_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1D03_MAINTENANCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1D03_MAINTENANCE";
            this.Text = "P1D03_MAINTENANCE";
            this.Load += new System.EventHandler(this.P1D03_MAINTENANCE_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPMachineRepairQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1D)).EndInit();
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
        private System.Windows.Forms.BindingSource sPMachineRepairQueryBindingSource;
        private P1D.DataSetP1D dataSetP1D;
        private P1D.DataSetP1DTableAdapters.SP_MachineRepair_QueryTableAdapter sP_MachineRepair_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 호기DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 설비명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비그룹;
        private System.Windows.Forms.DataGridViewTextBoxColumn 순번DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 점검일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 고장일시;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수리일시;
        private System.Windows.Forms.DataGridViewTextBoxColumn 소요시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 점검형태DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보전목표DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조치결과DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 점검자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 소요비용DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 파일이름1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 파일이름2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 파일이름3;
    }
}

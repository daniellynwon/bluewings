namespace SmartMES_Bluewings
{
    partial class P1ED03_QC_AS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1ED03_QC_AS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPQcASQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1E = new SmartMES_Bluewings.P1E.DataSetP1E();
            this.sP_QcAS_QueryTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_QcAS_QueryTableAdapter();
            this.접수번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.거래처IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.출하DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대상수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.발생일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.발생내역DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조치일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조치내역DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.처리비용DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.책임자IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.책임자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.진행DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전표번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.원인분석 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.고객요구 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.처리방법 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.통지내용 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcASQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "클레임관리";
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
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Controls.Add(this.label4);
            this.panSearch.Controls.Add(this.dtpToDate);
            this.panSearch.Controls.Add(this.dtpFromDate);
            this.panSearch.Controls.Add(this.cbState);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.label3);
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
            this.tbSearch.Location = new System.Drawing.Point(791, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(207, 29);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(364, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "~";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(74, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "발생기간";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpToDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Location = new System.Drawing.Point(387, 20);
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
            this.dtpFromDate.Location = new System.Drawing.Point(151, 20);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(211, 29);
            this.dtpFromDate.TabIndex = 1;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // cbState
            // 
            this.cbState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "<전체>",
            "0.대 기",
            "1.처리중",
            "2.완 료"});
            this.cbState.Location = new System.Drawing.Point(1096, 19);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(121, 29);
            this.cbState.TabIndex = 4;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(661, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "거래처/발생내역";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(1051, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "진행";
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
            this.접수번호DataGridViewTextBoxColumn,
            this.거래처IDDataGridViewTextBoxColumn,
            this.거래처명DataGridViewTextBoxColumn,
            this.출하DataGridViewTextBoxColumn,
            this.대상수량DataGridViewTextBoxColumn,
            this.발생일자DataGridViewTextBoxColumn,
            this.발생내역DataGridViewTextBoxColumn,
            this.조치일자DataGridViewTextBoxColumn,
            this.조치내역DataGridViewTextBoxColumn,
            this.처리비용DataGridViewTextBoxColumn,
            this.책임자IDDataGridViewTextBoxColumn,
            this.책임자DataGridViewTextBoxColumn,
            this.진행DataGridViewTextBoxColumn,
            this.전표번호,
            this.원인분석,
            this.고객요구,
            this.처리방법,
            this.통지내용});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPQcASQueryBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
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
            this.dataGridView1.Size = new System.Drawing.Size(1319, 852);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // sPQcASQueryBindingSource
            // 
            this.sPQcASQueryBindingSource.DataMember = "SP_QcAS_Query";
            this.sPQcASQueryBindingSource.DataSource = this.dataSetP1E;
            // 
            // dataSetP1E
            // 
            this.dataSetP1E.DataSetName = "DataSetP1E";
            this.dataSetP1E.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_QcAS_QueryTableAdapter
            // 
            this.sP_QcAS_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // 접수번호DataGridViewTextBoxColumn
            // 
            this.접수번호DataGridViewTextBoxColumn.DataPropertyName = "접수번호";
            this.접수번호DataGridViewTextBoxColumn.FillWeight = 70F;
            this.접수번호DataGridViewTextBoxColumn.HeaderText = "접수번호";
            this.접수번호DataGridViewTextBoxColumn.Name = "접수번호DataGridViewTextBoxColumn";
            this.접수번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.접수번호DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.접수번호DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.거래처명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.거래처명DataGridViewTextBoxColumn.HeaderText = "거래처명";
            this.거래처명DataGridViewTextBoxColumn.Name = "거래처명DataGridViewTextBoxColumn";
            this.거래처명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 출하DataGridViewTextBoxColumn
            // 
            this.출하DataGridViewTextBoxColumn.DataPropertyName = "출하";
            dataGridViewCellStyle4.Format = "MM\\/dd";
            this.출하DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.출하DataGridViewTextBoxColumn.FillWeight = 50F;
            this.출하DataGridViewTextBoxColumn.HeaderText = "출하";
            this.출하DataGridViewTextBoxColumn.Name = "출하DataGridViewTextBoxColumn";
            this.출하DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 대상수량DataGridViewTextBoxColumn
            // 
            this.대상수량DataGridViewTextBoxColumn.DataPropertyName = "대상수량";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0";
            this.대상수량DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.대상수량DataGridViewTextBoxColumn.FillWeight = 60F;
            this.대상수량DataGridViewTextBoxColumn.HeaderText = "대상수량";
            this.대상수량DataGridViewTextBoxColumn.Name = "대상수량DataGridViewTextBoxColumn";
            this.대상수량DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 발생일자DataGridViewTextBoxColumn
            // 
            this.발생일자DataGridViewTextBoxColumn.DataPropertyName = "발생일자";
            dataGridViewCellStyle6.Format = "MM\\/dd";
            this.발생일자DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.발생일자DataGridViewTextBoxColumn.FillWeight = 50F;
            this.발생일자DataGridViewTextBoxColumn.HeaderText = "발생일";
            this.발생일자DataGridViewTextBoxColumn.Name = "발생일자DataGridViewTextBoxColumn";
            this.발생일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 발생내역DataGridViewTextBoxColumn
            // 
            this.발생내역DataGridViewTextBoxColumn.DataPropertyName = "발생내역";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.발생내역DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.발생내역DataGridViewTextBoxColumn.FillWeight = 200F;
            this.발생내역DataGridViewTextBoxColumn.HeaderText = "발생내역";
            this.발생내역DataGridViewTextBoxColumn.Name = "발생내역DataGridViewTextBoxColumn";
            this.발생내역DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 조치일자DataGridViewTextBoxColumn
            // 
            this.조치일자DataGridViewTextBoxColumn.DataPropertyName = "조치일자";
            dataGridViewCellStyle8.Format = "MM\\/dd";
            this.조치일자DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.조치일자DataGridViewTextBoxColumn.FillWeight = 50F;
            this.조치일자DataGridViewTextBoxColumn.HeaderText = "조치일";
            this.조치일자DataGridViewTextBoxColumn.Name = "조치일자DataGridViewTextBoxColumn";
            this.조치일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 조치내역DataGridViewTextBoxColumn
            // 
            this.조치내역DataGridViewTextBoxColumn.DataPropertyName = "조치내역";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.조치내역DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.조치내역DataGridViewTextBoxColumn.FillWeight = 200F;
            this.조치내역DataGridViewTextBoxColumn.HeaderText = "조치내역";
            this.조치내역DataGridViewTextBoxColumn.Name = "조치내역DataGridViewTextBoxColumn";
            this.조치내역DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 처리비용DataGridViewTextBoxColumn
            // 
            this.처리비용DataGridViewTextBoxColumn.DataPropertyName = "처리비용";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#,##0";
            this.처리비용DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.처리비용DataGridViewTextBoxColumn.FillWeight = 80F;
            this.처리비용DataGridViewTextBoxColumn.HeaderText = "처리비용";
            this.처리비용DataGridViewTextBoxColumn.Name = "처리비용DataGridViewTextBoxColumn";
            this.처리비용DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 책임자IDDataGridViewTextBoxColumn
            // 
            this.책임자IDDataGridViewTextBoxColumn.DataPropertyName = "책임자ID";
            this.책임자IDDataGridViewTextBoxColumn.HeaderText = "책임자ID";
            this.책임자IDDataGridViewTextBoxColumn.Name = "책임자IDDataGridViewTextBoxColumn";
            this.책임자IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.책임자IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 책임자DataGridViewTextBoxColumn
            // 
            this.책임자DataGridViewTextBoxColumn.DataPropertyName = "책임자";
            this.책임자DataGridViewTextBoxColumn.FillWeight = 60F;
            this.책임자DataGridViewTextBoxColumn.HeaderText = "책임자";
            this.책임자DataGridViewTextBoxColumn.Name = "책임자DataGridViewTextBoxColumn";
            this.책임자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 진행DataGridViewTextBoxColumn
            // 
            this.진행DataGridViewTextBoxColumn.DataPropertyName = "진행";
            this.진행DataGridViewTextBoxColumn.FillWeight = 60F;
            this.진행DataGridViewTextBoxColumn.HeaderText = "진행";
            this.진행DataGridViewTextBoxColumn.Name = "진행DataGridViewTextBoxColumn";
            this.진행DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 전표번호
            // 
            this.전표번호.DataPropertyName = "전표번호";
            this.전표번호.HeaderText = "전표번호";
            this.전표번호.Name = "전표번호";
            this.전표번호.ReadOnly = true;
            this.전표번호.Visible = false;
            // 
            // 원인분석
            // 
            this.원인분석.DataPropertyName = "원인분석";
            this.원인분석.HeaderText = "원인분석";
            this.원인분석.Name = "원인분석";
            this.원인분석.ReadOnly = true;
            this.원인분석.Visible = false;
            // 
            // 고객요구
            // 
            this.고객요구.DataPropertyName = "고객요구";
            this.고객요구.HeaderText = "고객요구";
            this.고객요구.Name = "고객요구";
            this.고객요구.ReadOnly = true;
            this.고객요구.Visible = false;
            // 
            // 처리방법
            // 
            this.처리방법.DataPropertyName = "처리방법";
            this.처리방법.HeaderText = "처리방법";
            this.처리방법.Name = "처리방법";
            this.처리방법.ReadOnly = true;
            this.처리방법.Visible = false;
            // 
            // 통지내용
            // 
            this.통지내용.DataPropertyName = "통지내용";
            this.통지내용.HeaderText = "통지내용";
            this.통지내용.Name = "통지내용";
            this.통지내용.ReadOnly = true;
            this.통지내용.Visible = false;
            // 
            // P1ED03_QC_AS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1ED03_QC_AS";
            this.Text = "`";
            this.Load += new System.EventHandler(this.P1ED03_QC_AS_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPQcASQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbState;
        public System.Windows.Forms.DateTimePicker dtpToDate;
        public System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.BindingSource sPQcASQueryBindingSource;
        private P1E.DataSetP1E dataSetP1E;
        private P1E.DataSetP1ETableAdapters.SP_QcAS_QueryTableAdapter sP_QcAS_QueryTableAdapter;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewLinkColumn 접수번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 출하DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대상수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 발생일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 발생내역DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조치일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조치내역DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 처리비용DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 책임자IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 책임자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 진행DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전표번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 원인분석;
        private System.Windows.Forms.DataGridViewTextBoxColumn 고객요구;
        private System.Windows.Forms.DataGridViewTextBoxColumn 처리방법;
        private System.Windows.Forms.DataGridViewTextBoxColumn 통지내용;
    }
}

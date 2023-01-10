namespace SmartMES_Bluewings
{
    partial class P1ED01_QC_FINAL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.항목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사항목DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.규격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사결과DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판정 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.의견DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사원DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.포대번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPQcFinalQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1E = new SmartMES_Bluewings.P1E.DataSetP1E();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSearch2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSearch1 = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panSearch = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cbQcMan = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.sPQcFinalROderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_QcFinal_QueryTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_QcFinal_QueryTableAdapter();
            this.sP_QcFinal_ROderTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_QcFinal_ROderTableAdapter();
            this.sPQcFinalPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_QcFinal_PrintTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_QcFinal_PrintTableAdapter();
            this.포대번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.규격DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사건수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상태 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).BeginInit();
            this.panel1.SuspendLayout();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalROderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalPrintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "품질검사";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.항목코드DataGridViewTextBoxColumn,
            this.검사항목DataGridViewTextBoxColumn,
            this.규격DataGridViewTextBoxColumn,
            this.검사결과DataGridViewTextBoxColumn,
            this.판정,
            this.의견DataGridViewTextBoxColumn,
            this.검사일자DataGridViewTextBoxColumn,
            this.검사원DataGridViewTextBoxColumn,
            this.ColumnDel,
            this.포대번호});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPQcFinalQueryBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(497, 187);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(824, 796);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 항목코드DataGridViewTextBoxColumn
            // 
            this.항목코드DataGridViewTextBoxColumn.DataPropertyName = "항목코드";
            this.항목코드DataGridViewTextBoxColumn.HeaderText = "항목코드";
            this.항목코드DataGridViewTextBoxColumn.Name = "항목코드DataGridViewTextBoxColumn";
            this.항목코드DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.항목코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 검사항목DataGridViewTextBoxColumn
            // 
            this.검사항목DataGridViewTextBoxColumn.DataPropertyName = "검사항목";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.검사항목DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.검사항목DataGridViewTextBoxColumn.HeaderText = "검사항목";
            this.검사항목DataGridViewTextBoxColumn.Name = "검사항목DataGridViewTextBoxColumn";
            this.검사항목DataGridViewTextBoxColumn.ReadOnly = true;
            this.검사항목DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 규격DataGridViewTextBoxColumn
            // 
            this.규격DataGridViewTextBoxColumn.DataPropertyName = "규격";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.규격DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.규격DataGridViewTextBoxColumn.HeaderText = "규격";
            this.규격DataGridViewTextBoxColumn.Name = "규격DataGridViewTextBoxColumn";
            this.규격DataGridViewTextBoxColumn.ReadOnly = true;
            this.규격DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 검사결과DataGridViewTextBoxColumn
            // 
            this.검사결과DataGridViewTextBoxColumn.DataPropertyName = "검사결과";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            this.검사결과DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.검사결과DataGridViewTextBoxColumn.HeaderText = "검사결과";
            this.검사결과DataGridViewTextBoxColumn.Name = "검사결과DataGridViewTextBoxColumn";
            this.검사결과DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 판정
            // 
            this.판정.DataPropertyName = "판정";
            this.판정.FillWeight = 50F;
            this.판정.HeaderText = "판정";
            this.판정.Items.AddRange(new object[] {
            "0.대 기",
            "1.합 격",
            "2.불합격"});
            this.판정.Name = "판정";
            this.판정.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.판정.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 의견DataGridViewTextBoxColumn
            // 
            this.의견DataGridViewTextBoxColumn.DataPropertyName = "의견";
            this.의견DataGridViewTextBoxColumn.HeaderText = "의견";
            this.의견DataGridViewTextBoxColumn.Name = "의견DataGridViewTextBoxColumn";
            this.의견DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.의견DataGridViewTextBoxColumn.Visible = false;
            // 
            // 검사일자DataGridViewTextBoxColumn
            // 
            this.검사일자DataGridViewTextBoxColumn.DataPropertyName = "검사일자";
            this.검사일자DataGridViewTextBoxColumn.HeaderText = "검사일자";
            this.검사일자DataGridViewTextBoxColumn.Name = "검사일자DataGridViewTextBoxColumn";
            this.검사일자DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.검사일자DataGridViewTextBoxColumn.Visible = false;
            // 
            // 검사원DataGridViewTextBoxColumn
            // 
            this.검사원DataGridViewTextBoxColumn.DataPropertyName = "검사원";
            this.검사원DataGridViewTextBoxColumn.HeaderText = "검사원";
            this.검사원DataGridViewTextBoxColumn.Name = "검사원DataGridViewTextBoxColumn";
            this.검사원DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.검사원DataGridViewTextBoxColumn.Visible = false;
            // 
            // ColumnDel
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "X";
            this.ColumnDel.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnDel.FillWeight = 20F;
            this.ColumnDel.HeaderText = "";
            this.ColumnDel.Name = "ColumnDel";
            this.ColumnDel.Text = "X";
            // 
            // 포대번호
            // 
            this.포대번호.DataPropertyName = "포대번호";
            this.포대번호.HeaderText = "포대번호";
            this.포대번호.Name = "포대번호";
            this.포대번호.Visible = false;
            // 
            // sPQcFinalQueryBindingSource
            // 
            this.sPQcFinalQueryBindingSource.DataMember = "SP_QcFinal_Query";
            this.sPQcFinalQueryBindingSource.DataSource = this.dataSetP1E;
            // 
            // dataSetP1E
            // 
            this.dataSetP1E.DataSetName = "DataSetP1E";
            this.dataSetP1E.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbSearch2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbSearch1);
            this.panel1.Controls.Add(this.dtpToDate);
            this.panel1.Controls.Add(this.dtpFromDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 123);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(24, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "거래처/현장정보";
            this.label5.Visible = false;
            // 
            // tbSearch2
            // 
            this.tbSearch2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch2.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch2.Location = new System.Drawing.Point(258, 85);
            this.tbSearch2.Name = "tbSearch2";
            this.tbSearch2.Size = new System.Drawing.Size(207, 29);
            this.tbSearch2.TabIndex = 4;
            this.tbSearch2.Visible = false;
            this.tbSearch2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(258, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "품목/제품/규격";
            this.label6.Visible = false;
            // 
            // tbSearch1
            // 
            this.tbSearch1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch1.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch1.Location = new System.Drawing.Point(24, 85);
            this.tbSearch1.Name = "tbSearch1";
            this.tbSearch1.Size = new System.Drawing.Size(207, 29);
            this.tbSearch1.TabIndex = 3;
            this.tbSearch1.Visible = false;
            this.tbSearch1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpToDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Location = new System.Drawing.Point(258, 14);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(207, 29);
            this.dtpToDate.TabIndex = 2;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromDate.Location = new System.Drawing.Point(24, 14);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(207, 29);
            this.dtpFromDate.TabIndex = 1;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(234, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "~";
            // 
            // panSearch
            // 
            this.panSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearch.AutoSize = true;
            this.panSearch.BackColor = System.Drawing.SystemColors.Info;
            this.panSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSearch.Controls.Add(this.lblMsg);
            this.panSearch.Controls.Add(this.cbQcMan);
            this.panSearch.Controls.Add(this.dtpDate);
            this.panSearch.Controls.Add(this.label7);
            this.panSearch.Controls.Add(this.tbContents);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Location = new System.Drawing.Point(497, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(824, 123);
            this.panSearch.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(12, 98);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // cbQcMan
            // 
            this.cbQcMan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbQcMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQcMan.FormattingEnabled = true;
            this.cbQcMan.Location = new System.Drawing.Point(166, 69);
            this.cbQcMan.Name = "cbQcMan";
            this.cbQcMan.Size = new System.Drawing.Size(211, 29);
            this.cbQcMan.TabIndex = 12;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Location = new System.Drawing.Point(166, 18);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(211, 29);
            this.dtpDate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(88, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "검 사 원";
            // 
            // tbContents
            // 
            this.tbContents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbContents.Location = new System.Drawing.Point(480, 18);
            this.tbContents.Multiline = true;
            this.tbContents.Name = "tbContents";
            this.tbContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContents.Size = new System.Drawing.Size(231, 80);
            this.tbContents.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(425, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "의 견";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(88, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "검사일자";
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewList.AutoGenerateColumns = false;
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewList.ColumnHeadersHeight = 35;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.포대번호DataGridViewTextBoxColumn,
            this.작업일자DataGridViewTextBoxColumn,
            this.품목코드DataGridViewTextBoxColumn,
            this.품목명DataGridViewTextBoxColumn,
            this.규격DataGridViewTextBoxColumn1,
            this.수량DataGridViewTextBoxColumn,
            this.검사건수,
            this.상태});
            this.dataGridViewList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridViewList.DataSource = this.sPQcFinalROderBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewList.EnableHeadersVisualStyles = false;
            this.dataGridViewList.Location = new System.Drawing.Point(2, 187);
            this.dataGridViewList.MultiSelect = false;
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.RowHeadersWidth = 35;
            this.dataGridViewList.RowTemplate.Height = 35;
            this.dataGridViewList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(489, 796);
            this.dataGridViewList.TabIndex = 10;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            // 
            // sPQcFinalROderBindingSource
            // 
            this.sPQcFinalROderBindingSource.DataMember = "SP_QcFinal_ROder";
            this.sPQcFinalROderBindingSource.DataSource = this.dataSetP1E;
            // 
            // sP_QcFinal_QueryTableAdapter
            // 
            this.sP_QcFinal_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // sP_QcFinal_ROderTableAdapter
            // 
            this.sP_QcFinal_ROderTableAdapter.ClearBeforeFill = true;
            // 
            // sPQcFinalPrintBindingSource
            // 
            this.sPQcFinalPrintBindingSource.DataMember = "SP_QcFinal_Print";
            this.sPQcFinalPrintBindingSource.DataSource = this.dataSetP1E;
            // 
            // sP_QcFinal_PrintTableAdapter
            // 
            this.sP_QcFinal_PrintTableAdapter.ClearBeforeFill = true;
            // 
            // 포대번호DataGridViewTextBoxColumn
            // 
            this.포대번호DataGridViewTextBoxColumn.DataPropertyName = "포대번호";
            this.포대번호DataGridViewTextBoxColumn.HeaderText = "포대번호";
            this.포대번호DataGridViewTextBoxColumn.Name = "포대번호DataGridViewTextBoxColumn";
            this.포대번호DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 작업일자DataGridViewTextBoxColumn
            // 
            this.작업일자DataGridViewTextBoxColumn.DataPropertyName = "작업일자";
            dataGridViewCellStyle11.Format = "MM\\/dd";
            this.작업일자DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.작업일자DataGridViewTextBoxColumn.FillWeight = 70F;
            this.작업일자DataGridViewTextBoxColumn.HeaderText = "작업일자";
            this.작업일자DataGridViewTextBoxColumn.Name = "작업일자DataGridViewTextBoxColumn";
            this.작업일자DataGridViewTextBoxColumn.ReadOnly = true;
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
            this.품목명DataGridViewTextBoxColumn.HeaderText = "품목명";
            this.품목명DataGridViewTextBoxColumn.Name = "품목명DataGridViewTextBoxColumn";
            this.품목명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 규격DataGridViewTextBoxColumn1
            // 
            this.규격DataGridViewTextBoxColumn1.DataPropertyName = "규격";
            this.규격DataGridViewTextBoxColumn1.HeaderText = "규격";
            this.규격DataGridViewTextBoxColumn1.Name = "규격DataGridViewTextBoxColumn1";
            this.규격DataGridViewTextBoxColumn1.ReadOnly = true;
            this.규격DataGridViewTextBoxColumn1.Visible = false;
            // 
            // 수량DataGridViewTextBoxColumn
            // 
            this.수량DataGridViewTextBoxColumn.DataPropertyName = "수량";
            this.수량DataGridViewTextBoxColumn.HeaderText = "수량";
            this.수량DataGridViewTextBoxColumn.Name = "수량DataGridViewTextBoxColumn";
            this.수량DataGridViewTextBoxColumn.ReadOnly = true;
            this.수량DataGridViewTextBoxColumn.Visible = false;
            // 
            // 검사건수
            // 
            this.검사건수.DataPropertyName = "검사건수";
            this.검사건수.HeaderText = "검사건수";
            this.검사건수.Name = "검사건수";
            this.검사건수.ReadOnly = true;
            this.검사건수.Visible = false;
            // 
            // 상태
            // 
            this.상태.DataPropertyName = "상태";
            this.상태.FillWeight = 50F;
            this.상태.HeaderText = "상태";
            this.상태.Name = "상태";
            this.상태.ReadOnly = true;
            // 
            // P1ED01_QC_FINAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.panSearch);
            this.Controls.Add(this.panel1);
            this.Name = "P1ED01_QC_FINAL";
            this.Tag = "";
            this.Text = "P1ED01_QC_FINAL";
            this.Load += new System.EventHandler(this.P1ED01_QC_FINAL_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panSearch, 0);
            this.Controls.SetChildIndex(this.dataGridViewList, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalROderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalPrintBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panSearch;
        public System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbContents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.BindingSource sPQcFinalQueryBindingSource;
        private P1E.DataSetP1E dataSetP1E;
        private System.Windows.Forms.BindingSource sPQcFinalROderBindingSource;
        private P1E.DataSetP1ETableAdapters.SP_QcFinal_QueryTableAdapter sP_QcFinal_QueryTableAdapter;
        private P1E.DataSetP1ETableAdapters.SP_QcFinal_ROderTableAdapter sP_QcFinal_ROderTableAdapter;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpToDate;
        public System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbSearch2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbSearch1;
        public System.Windows.Forms.ComboBox cbQcMan;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.BindingSource sPQcFinalPrintBindingSource;
        private P1E.DataSetP1ETableAdapters.SP_QcFinal_PrintTableAdapter sP_QcFinal_PrintTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 항목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사항목DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사결과DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 판정;
        private System.Windows.Forms.DataGridViewTextBoxColumn 의견DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사원DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn 포대번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 포대번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사건수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상태;
    }
}

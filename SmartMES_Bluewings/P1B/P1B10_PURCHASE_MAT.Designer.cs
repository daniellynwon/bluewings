namespace SmartMES_Bluewings
{
    partial class P1B10_PURCHASE_MAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1B10_PURCHASE_MAT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.cbGubun = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.발주번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.발주일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.발주처IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.발주처DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.자재명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.규격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.발주량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단가DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.발주액DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.요청일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.입고여부DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.입고일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.입고량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매입액DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.부가세DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.합계금액DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.창고IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.입고창고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.요청일자 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.순번 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPPurchaseMatQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1B = new SmartMES_Bluewings.P1B.DataSetP1B();
            this.sP_PurchaseMat_QueryTableAdapter = new SmartMES_Bluewings.P1B.DataSetP1BTableAdapters.SP_PurchaseMat_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPurchaseMatQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1B)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "자재발주/매입등록";
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
            this.panSearch.Controls.Add(this.cbTerm);
            this.panSearch.Controls.Add(this.cbGubun);
            this.panSearch.Controls.Add(this.label7);
            this.panSearch.Controls.Add(this.label3);
            this.panSearch.Controls.Add(this.dtpToDate);
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Controls.Add(this.dtpFromDate);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 71);
            this.panSearch.TabIndex = 0;
            // 
            // cbTerm
            // 
            this.cbTerm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Items.AddRange(new object[] {
            "1.발주기간",
            "2.입고기간"});
            this.cbTerm.Location = new System.Drawing.Point(63, 20);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(104, 29);
            this.cbTerm.TabIndex = 1;
            this.cbTerm.SelectedIndexChanged += new System.EventHandler(this.cbTerm_SelectedIndexChanged);
            // 
            // cbGubun
            // 
            this.cbGubun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbGubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGubun.FormattingEnabled = true;
            this.cbGubun.Items.AddRange(new object[] {
            "<전체>",
            "0.대기분",
            "1.입고분"});
            this.cbGubun.Location = new System.Drawing.Point(1128, 19);
            this.cbGubun.Name = "cbGubun";
            this.cbGubun.Size = new System.Drawing.Size(117, 29);
            this.cbGubun.TabIndex = 5;
            this.cbGubun.SelectedIndexChanged += new System.EventHandler(this.cbGubun_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(1083, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "구분";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(382, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "~";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpToDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Location = new System.Drawing.Point(405, 20);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(211, 29);
            this.dtpToDate.TabIndex = 3;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(778, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(265, 29);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(663, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "발주처/품목명";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFromDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromDate.Location = new System.Drawing.Point(169, 20);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(211, 29);
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dataGridView1
            // 
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
            this.발주번호DataGridViewTextBoxColumn,
            this.발주일DataGridViewTextBoxColumn,
            this.발주처IDDataGridViewTextBoxColumn,
            this.발주처DataGridViewTextBoxColumn,
            this.품목코드DataGridViewTextBoxColumn,
            this.품목명DataGridViewTextBoxColumn,
            this.자재명DataGridViewTextBoxColumn,
            this.규격DataGridViewTextBoxColumn,
            this.발주량DataGridViewTextBoxColumn,
            this.단가DataGridViewTextBoxColumn,
            this.발주액DataGridViewTextBoxColumn,
            this.요청일,
            this.ColumnBtn,
            this.입고여부DataGridViewTextBoxColumn,
            this.입고일DataGridViewTextBoxColumn,
            this.입고량DataGridViewTextBoxColumn,
            this.매입액DataGridViewTextBoxColumn,
            this.부가세DataGridViewTextBoxColumn,
            this.합계금액DataGridViewTextBoxColumn,
            this.창고IDDataGridViewTextBoxColumn,
            this.입고창고DataGridViewTextBoxColumn,
            this.비고DataGridViewTextBoxColumn,
            this.요청일자,
            this.순번});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPPurchaseMatQueryBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 852);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // 발주번호DataGridViewTextBoxColumn
            // 
            this.발주번호DataGridViewTextBoxColumn.DataPropertyName = "발주번호";
            this.발주번호DataGridViewTextBoxColumn.HeaderText = "발주번호";
            this.발주번호DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.발주번호DataGridViewTextBoxColumn.Name = "발주번호DataGridViewTextBoxColumn";
            this.발주번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.발주번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 발주일DataGridViewTextBoxColumn
            // 
            this.발주일DataGridViewTextBoxColumn.DataPropertyName = "발주일";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Format = "MM\\/dd";
            this.발주일DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.발주일DataGridViewTextBoxColumn.FillWeight = 45F;
            this.발주일DataGridViewTextBoxColumn.HeaderText = "발주";
            this.발주일DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.발주일DataGridViewTextBoxColumn.Name = "발주일DataGridViewTextBoxColumn";
            this.발주일DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 발주처IDDataGridViewTextBoxColumn
            // 
            this.발주처IDDataGridViewTextBoxColumn.DataPropertyName = "발주처ID";
            this.발주처IDDataGridViewTextBoxColumn.HeaderText = "발주처ID";
            this.발주처IDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.발주처IDDataGridViewTextBoxColumn.Name = "발주처IDDataGridViewTextBoxColumn";
            this.발주처IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.발주처IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 발주처DataGridViewTextBoxColumn
            // 
            this.발주처DataGridViewTextBoxColumn.DataPropertyName = "발주처";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            this.발주처DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.발주처DataGridViewTextBoxColumn.HeaderText = "발주처";
            this.발주처DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.발주처DataGridViewTextBoxColumn.Name = "발주처DataGridViewTextBoxColumn";
            this.발주처DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 품목코드DataGridViewTextBoxColumn
            // 
            this.품목코드DataGridViewTextBoxColumn.DataPropertyName = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.HeaderText = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.품목코드DataGridViewTextBoxColumn.Name = "품목코드DataGridViewTextBoxColumn";
            this.품목코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.품목코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 품목명DataGridViewTextBoxColumn
            // 
            this.품목명DataGridViewTextBoxColumn.DataPropertyName = "품목명";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            this.품목명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.품목명DataGridViewTextBoxColumn.HeaderText = "품목명";
            this.품목명DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.품목명DataGridViewTextBoxColumn.Name = "품목명DataGridViewTextBoxColumn";
            this.품목명DataGridViewTextBoxColumn.ReadOnly = true;
            this.품목명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.품목명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 자재명DataGridViewTextBoxColumn
            // 
            this.자재명DataGridViewTextBoxColumn.DataPropertyName = "자재명";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            this.자재명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.자재명DataGridViewTextBoxColumn.HeaderText = "자재명";
            this.자재명DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.자재명DataGridViewTextBoxColumn.Name = "자재명DataGridViewTextBoxColumn";
            this.자재명DataGridViewTextBoxColumn.ReadOnly = true;
            this.자재명DataGridViewTextBoxColumn.Visible = false;
            // 
            // 규격DataGridViewTextBoxColumn
            // 
            this.규격DataGridViewTextBoxColumn.DataPropertyName = "규격";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Beige;
            this.규격DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.규격DataGridViewTextBoxColumn.HeaderText = "규격";
            this.규격DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.규격DataGridViewTextBoxColumn.Name = "규격DataGridViewTextBoxColumn";
            this.규격DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 발주량DataGridViewTextBoxColumn
            // 
            this.발주량DataGridViewTextBoxColumn.DataPropertyName = "발주량";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.발주량DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.발주량DataGridViewTextBoxColumn.FillWeight = 60F;
            this.발주량DataGridViewTextBoxColumn.HeaderText = "발주량";
            this.발주량DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.발주량DataGridViewTextBoxColumn.Name = "발주량DataGridViewTextBoxColumn";
            this.발주량DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 단가DataGridViewTextBoxColumn
            // 
            this.단가DataGridViewTextBoxColumn.DataPropertyName = "단가";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle8.Format = "N0";
            this.단가DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.단가DataGridViewTextBoxColumn.FillWeight = 70F;
            this.단가DataGridViewTextBoxColumn.HeaderText = "단가";
            this.단가DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.단가DataGridViewTextBoxColumn.Name = "단가DataGridViewTextBoxColumn";
            this.단가DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 발주액DataGridViewTextBoxColumn
            // 
            this.발주액DataGridViewTextBoxColumn.DataPropertyName = "발주액";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle9.Format = "N0";
            this.발주액DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.발주액DataGridViewTextBoxColumn.FillWeight = 90F;
            this.발주액DataGridViewTextBoxColumn.HeaderText = "발주액";
            this.발주액DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.발주액DataGridViewTextBoxColumn.Name = "발주액DataGridViewTextBoxColumn";
            this.발주액DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 요청일
            // 
            this.요청일.DataPropertyName = "요청일";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Beige;
            this.요청일.DefaultCellStyle = dataGridViewCellStyle10;
            this.요청일.FillWeight = 45F;
            this.요청일.HeaderText = "요청";
            this.요청일.MinimumWidth = 6;
            this.요청일.Name = "요청일";
            this.요청일.ReadOnly = true;
            // 
            // ColumnBtn
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.NullValue = "입고";
            this.ColumnBtn.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnBtn.FillWeight = 30F;
            this.ColumnBtn.HeaderText = "";
            this.ColumnBtn.MinimumWidth = 6;
            this.ColumnBtn.Name = "ColumnBtn";
            this.ColumnBtn.ReadOnly = true;
            this.ColumnBtn.Text = "입고";
            // 
            // 입고여부DataGridViewTextBoxColumn
            // 
            this.입고여부DataGridViewTextBoxColumn.DataPropertyName = "입고여부";
            this.입고여부DataGridViewTextBoxColumn.HeaderText = "입고여부";
            this.입고여부DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.입고여부DataGridViewTextBoxColumn.Name = "입고여부DataGridViewTextBoxColumn";
            this.입고여부DataGridViewTextBoxColumn.ReadOnly = true;
            this.입고여부DataGridViewTextBoxColumn.Visible = false;
            // 
            // 입고일DataGridViewTextBoxColumn
            // 
            this.입고일DataGridViewTextBoxColumn.DataPropertyName = "입고일";
            dataGridViewCellStyle12.Format = "MM\\/dd";
            this.입고일DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.입고일DataGridViewTextBoxColumn.FillWeight = 45F;
            this.입고일DataGridViewTextBoxColumn.HeaderText = "입고";
            this.입고일DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.입고일DataGridViewTextBoxColumn.Name = "입고일DataGridViewTextBoxColumn";
            this.입고일DataGridViewTextBoxColumn.ReadOnly = true;
            this.입고일DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.입고일DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 입고량DataGridViewTextBoxColumn
            // 
            this.입고량DataGridViewTextBoxColumn.DataPropertyName = "입고량";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N0";
            this.입고량DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.입고량DataGridViewTextBoxColumn.FillWeight = 60F;
            this.입고량DataGridViewTextBoxColumn.HeaderText = "입고량";
            this.입고량DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.입고량DataGridViewTextBoxColumn.Name = "입고량DataGridViewTextBoxColumn";
            this.입고량DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 매입액DataGridViewTextBoxColumn
            // 
            this.매입액DataGridViewTextBoxColumn.DataPropertyName = "매입액";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N0";
            this.매입액DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.매입액DataGridViewTextBoxColumn.FillWeight = 90F;
            this.매입액DataGridViewTextBoxColumn.HeaderText = "매입액";
            this.매입액DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.매입액DataGridViewTextBoxColumn.Name = "매입액DataGridViewTextBoxColumn";
            this.매입액DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 부가세DataGridViewTextBoxColumn
            // 
            this.부가세DataGridViewTextBoxColumn.DataPropertyName = "부가세";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N0";
            this.부가세DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.부가세DataGridViewTextBoxColumn.FillWeight = 80F;
            this.부가세DataGridViewTextBoxColumn.HeaderText = "부가세";
            this.부가세DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.부가세DataGridViewTextBoxColumn.Name = "부가세DataGridViewTextBoxColumn";
            this.부가세DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 합계금액DataGridViewTextBoxColumn
            // 
            this.합계금액DataGridViewTextBoxColumn.DataPropertyName = "합계금액";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N0";
            this.합계금액DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.합계금액DataGridViewTextBoxColumn.HeaderText = "합계금액";
            this.합계금액DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.합계금액DataGridViewTextBoxColumn.Name = "합계금액DataGridViewTextBoxColumn";
            this.합계금액DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 창고IDDataGridViewTextBoxColumn
            // 
            this.창고IDDataGridViewTextBoxColumn.DataPropertyName = "창고ID";
            this.창고IDDataGridViewTextBoxColumn.HeaderText = "창고ID";
            this.창고IDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.창고IDDataGridViewTextBoxColumn.Name = "창고IDDataGridViewTextBoxColumn";
            this.창고IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.창고IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 입고창고DataGridViewTextBoxColumn
            // 
            this.입고창고DataGridViewTextBoxColumn.DataPropertyName = "입고창고";
            this.입고창고DataGridViewTextBoxColumn.FillWeight = 65F;
            this.입고창고DataGridViewTextBoxColumn.HeaderText = "창고";
            this.입고창고DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.입고창고DataGridViewTextBoxColumn.Name = "입고창고DataGridViewTextBoxColumn";
            this.입고창고DataGridViewTextBoxColumn.ReadOnly = true;
            this.입고창고DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 비고DataGridViewTextBoxColumn
            // 
            this.비고DataGridViewTextBoxColumn.DataPropertyName = "비고";
            this.비고DataGridViewTextBoxColumn.HeaderText = "비고";
            this.비고DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.비고DataGridViewTextBoxColumn.Name = "비고DataGridViewTextBoxColumn";
            this.비고DataGridViewTextBoxColumn.ReadOnly = true;
            this.비고DataGridViewTextBoxColumn.Visible = false;
            // 
            // 요청일자
            // 
            this.요청일자.DataPropertyName = "요청일자";
            this.요청일자.HeaderText = "요청일자";
            this.요청일자.MinimumWidth = 6;
            this.요청일자.Name = "요청일자";
            this.요청일자.ReadOnly = true;
            this.요청일자.Visible = false;
            // 
            // 순번
            // 
            this.순번.DataPropertyName = "순번";
            this.순번.HeaderText = "순번";
            this.순번.MinimumWidth = 6;
            this.순번.Name = "순번";
            this.순번.ReadOnly = true;
            this.순번.Visible = false;
            // 
            // sPPurchaseMatQueryBindingSource
            // 
            this.sPPurchaseMatQueryBindingSource.DataMember = "SP_PurchaseMat_Query";
            this.sPPurchaseMatQueryBindingSource.DataSource = this.dataSetP1B;
            // 
            // dataSetP1B
            // 
            this.dataSetP1B.DataSetName = "DataSetP1B";
            this.dataSetP1B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_PurchaseMat_QueryTableAdapter
            // 
            this.sP_PurchaseMat_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1B10_PURCHASE_MAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 830);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1B10_PURCHASE_MAT";
            this.Text = "P1B10_PURCHASE_MAT";
            this.Load += new System.EventHandler(this.P1B10_PURCHASE_MAT_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPPurchaseMatQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.BindingSource sPPurchaseMatQueryBindingSource;
        private P1B.DataSetP1B dataSetP1B;
        private P1B.DataSetP1BTableAdapters.SP_PurchaseMat_QueryTableAdapter sP_PurchaseMat_QueryTableAdapter;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.ComboBox cbGubun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 발주번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 발주일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 발주처IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 발주처DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 발주량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단가DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 발주액DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 요청일;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입고여부DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 입고일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입고량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매입액DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부가세DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 합계금액DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 창고IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입고창고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 요청일자;
        private System.Windows.Forms.DataGridViewTextBoxColumn 순번;
    }
}

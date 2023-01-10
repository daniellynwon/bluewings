namespace SmartMES_Bluewings
{
    partial class P1B08_DELI_TERM
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPDeliTermQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1B = new SmartMES_Bluewings.P1B.DataSetP1B();
            this.sP_DeliTerm_QueryTableAdapter = new SmartMES_Bluewings.P1B.DataSetP1BTableAdapters.SP_DeliTerm_QueryTableAdapter();
            this.전표번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.출하일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.영업담당DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.프로젝트명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.현장정보DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.배송수단DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.공급가액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.부가세 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.합계금액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDeliTermQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1B)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "기간별출하현황";
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
            this.label2.Text = "출하기간";
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
            this.label1.Location = new System.Drawing.Point(839, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "거래처/현장정보";
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
            this.전표번호DataGridViewTextBoxColumn,
            this.출하일자DataGridViewTextBoxColumn,
            this.거래처IDDataGridViewTextBoxColumn,
            this.거래처명DataGridViewTextBoxColumn,
            this.영업담당DataGridViewTextBoxColumn,
            this.프로젝트명DataGridViewTextBoxColumn,
            this.현장정보DataGridViewTextBoxColumn,
            this.배송수단DataGridViewTextBoxColumn,
            this.품목수,
            this.수량,
            this.공급가액,
            this.부가세,
            this.합계금액});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPDeliTermQueryBindingSource;
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
            // sPDeliTermQueryBindingSource
            // 
            this.sPDeliTermQueryBindingSource.DataMember = "SP_DeliTerm_Query";
            this.sPDeliTermQueryBindingSource.DataSource = this.dataSetP1B;
            // 
            // dataSetP1B
            // 
            this.dataSetP1B.DataSetName = "DataSetP1B";
            this.dataSetP1B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_DeliTerm_QueryTableAdapter
            // 
            this.sP_DeliTerm_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // 전표번호DataGridViewTextBoxColumn
            // 
            this.전표번호DataGridViewTextBoxColumn.DataPropertyName = "전표번호";
            this.전표번호DataGridViewTextBoxColumn.HeaderText = "전표번호";
            this.전표번호DataGridViewTextBoxColumn.Name = "전표번호DataGridViewTextBoxColumn";
            this.전표번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.전표번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 출하일자DataGridViewTextBoxColumn
            // 
            this.출하일자DataGridViewTextBoxColumn.DataPropertyName = "출하일자";
            dataGridViewCellStyle3.Format = "MM\\/dd";
            this.출하일자DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.출하일자DataGridViewTextBoxColumn.FillWeight = 40F;
            this.출하일자DataGridViewTextBoxColumn.HeaderText = "일자";
            this.출하일자DataGridViewTextBoxColumn.Name = "출하일자DataGridViewTextBoxColumn";
            this.출하일자DataGridViewTextBoxColumn.ReadOnly = true;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.거래처명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.거래처명DataGridViewTextBoxColumn.HeaderText = "거래처명";
            this.거래처명DataGridViewTextBoxColumn.Name = "거래처명DataGridViewTextBoxColumn";
            this.거래처명DataGridViewTextBoxColumn.ReadOnly = true;
            this.거래처명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.거래처명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 영업담당DataGridViewTextBoxColumn
            // 
            this.영업담당DataGridViewTextBoxColumn.DataPropertyName = "영업담당";
            this.영업담당DataGridViewTextBoxColumn.FillWeight = 60F;
            this.영업담당DataGridViewTextBoxColumn.HeaderText = "영업담당";
            this.영업담당DataGridViewTextBoxColumn.Name = "영업담당DataGridViewTextBoxColumn";
            this.영업담당DataGridViewTextBoxColumn.ReadOnly = true;
            this.영업담당DataGridViewTextBoxColumn.Visible = false;
            // 
            // 프로젝트명DataGridViewTextBoxColumn
            // 
            this.프로젝트명DataGridViewTextBoxColumn.DataPropertyName = "프로젝트명";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.프로젝트명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.현장정보DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.현장정보DataGridViewTextBoxColumn.HeaderText = "현장정보";
            this.현장정보DataGridViewTextBoxColumn.Name = "현장정보DataGridViewTextBoxColumn";
            this.현장정보DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 배송수단DataGridViewTextBoxColumn
            // 
            this.배송수단DataGridViewTextBoxColumn.DataPropertyName = "배송수단";
            this.배송수단DataGridViewTextBoxColumn.FillWeight = 50F;
            this.배송수단DataGridViewTextBoxColumn.HeaderText = "배송";
            this.배송수단DataGridViewTextBoxColumn.Name = "배송수단DataGridViewTextBoxColumn";
            this.배송수단DataGridViewTextBoxColumn.ReadOnly = true;
            this.배송수단DataGridViewTextBoxColumn.Visible = false;
            // 
            // 품목수
            // 
            this.품목수.DataPropertyName = "품목수";
            this.품목수.FillWeight = 60F;
            this.품목수.HeaderText = "품목수";
            this.품목수.Name = "품목수";
            this.품목수.ReadOnly = true;
            // 
            // 수량
            // 
            this.수량.DataPropertyName = "수량";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.수량.DefaultCellStyle = dataGridViewCellStyle7;
            this.수량.FillWeight = 60F;
            this.수량.HeaderText = "수량";
            this.수량.Name = "수량";
            this.수량.ReadOnly = true;
            // 
            // 공급가액
            // 
            this.공급가액.DataPropertyName = "공급가액";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "#,##0";
            this.공급가액.DefaultCellStyle = dataGridViewCellStyle8;
            this.공급가액.FillWeight = 90F;
            this.공급가액.HeaderText = "공급가액";
            this.공급가액.Name = "공급가액";
            this.공급가액.ReadOnly = true;
            // 
            // 부가세
            // 
            this.부가세.DataPropertyName = "부가세";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "#,##0";
            this.부가세.DefaultCellStyle = dataGridViewCellStyle9;
            this.부가세.FillWeight = 80F;
            this.부가세.HeaderText = "부가세";
            this.부가세.Name = "부가세";
            this.부가세.ReadOnly = true;
            // 
            // 합계금액
            // 
            this.합계금액.DataPropertyName = "합계금액";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#,##0";
            this.합계금액.DefaultCellStyle = dataGridViewCellStyle10;
            this.합계금액.HeaderText = "합계금액";
            this.합계금액.Name = "합계금액";
            this.합계금액.ReadOnly = true;
            // 
            // P1B08_DELI_TERM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1B08_DELI_TERM";
            this.Text = "P1B08_DELI_TERM";
            this.Activated += new System.EventHandler(this.P1B08_DELI_TERM_Activated);
            this.Load += new System.EventHandler(this.P1B08_DELI_TERM_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPDeliTermQueryBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource sPDeliTermQueryBindingSource;
        private P1B.DataSetP1B dataSetP1B;
        private P1B.DataSetP1BTableAdapters.SP_DeliTerm_QueryTableAdapter sP_DeliTerm_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목수DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공급가액DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부가세DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 합계금액DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전표번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 출하일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 거래처명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 영업담당DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 프로젝트명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 현장정보DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 배송수단DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공급가액;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부가세;
        private System.Windows.Forms.DataGridViewTextBoxColumn 합계금액;
    }
}

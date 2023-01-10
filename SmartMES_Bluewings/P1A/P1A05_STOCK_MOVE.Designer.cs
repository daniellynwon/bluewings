namespace SmartMES_Bluewings
{
    partial class P1A05_STOCK_MOVE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cbGubun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDepot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.처리IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.처리일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.입출창고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.분류DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.규격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.유형코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조정유형DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조정사유DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.등록자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPStockMoveQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1A = new SmartMES_Bluewings.P1A.DataSetP1A();
            this.sP_StockMove_QueryTableAdapter = new SmartMES_Bluewings.P1A.DataSetP1ATableAdapters.SP_StockMove_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPStockMoveQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "기초재고등록";
            // 
            // pbPrint
            // 
            this.pbPrint.Image = global::SmartMES_Bluewings.Properties.Resources.out_B;
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
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Controls.Add(this.label4);
            this.panSearch.Controls.Add(this.dtpToDate);
            this.panSearch.Controls.Add(this.dtpFromDate);
            this.panSearch.Controls.Add(this.cbGubun);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.cbDepot);
            this.panSearch.Controls.Add(this.label3);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 71);
            this.panSearch.TabIndex = 0;
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
            this.label4.Text = "조정기간";
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
            // cbGubun
            // 
            this.cbGubun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbGubun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGubun.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbGubun.FormattingEnabled = true;
            this.cbGubun.Items.AddRange(new object[] {
            "A.제품",
            "B.원/부자재",
            "Z.기타"});
            this.cbGubun.Location = new System.Drawing.Point(1089, 19);
            this.cbGubun.Name = "cbGubun";
            this.cbGubun.Size = new System.Drawing.Size(154, 29);
            this.cbGubun.TabIndex = 4;
            this.cbGubun.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(676, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "입출창고";
            // 
            // cbDepot
            // 
            this.cbDepot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDepot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepot.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbDepot.FormattingEnabled = true;
            this.cbDepot.Location = new System.Drawing.Point(753, 19);
            this.cbDepot.Name = "cbDepot";
            this.cbDepot.Size = new System.Drawing.Size(193, 29);
            this.cbDepot.TabIndex = 3;
            this.cbDepot.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(1012, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "품목구분";
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
            this.처리IDDataGridViewTextBoxColumn,
            this.처리일자DataGridViewTextBoxColumn,
            this.품목코드DataGridViewTextBoxColumn,
            this.입출창고DataGridViewTextBoxColumn,
            this.분류DataGridViewTextBoxColumn,
            this.품목명DataGridViewTextBoxColumn,
            this.규격DataGridViewTextBoxColumn,
            this.유형코드DataGridViewTextBoxColumn,
            this.조정유형DataGridViewTextBoxColumn,
            this.수량DataGridViewTextBoxColumn,
            this.조정사유DataGridViewTextBoxColumn,
            this.등록자DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPStockMoveQueryBindingSource;
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
            // 처리IDDataGridViewTextBoxColumn
            // 
            this.처리IDDataGridViewTextBoxColumn.DataPropertyName = "처리ID";
            this.처리IDDataGridViewTextBoxColumn.HeaderText = "처리ID";
            this.처리IDDataGridViewTextBoxColumn.Name = "처리IDDataGridViewTextBoxColumn";
            this.처리IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.처리IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 처리일자DataGridViewTextBoxColumn
            // 
            this.처리일자DataGridViewTextBoxColumn.DataPropertyName = "처리일자";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd";
            this.처리일자DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.처리일자DataGridViewTextBoxColumn.FillWeight = 70F;
            this.처리일자DataGridViewTextBoxColumn.HeaderText = "처리일자";
            this.처리일자DataGridViewTextBoxColumn.Name = "처리일자DataGridViewTextBoxColumn";
            this.처리일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 품목코드DataGridViewTextBoxColumn
            // 
            this.품목코드DataGridViewTextBoxColumn.DataPropertyName = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.HeaderText = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.Name = "품목코드DataGridViewTextBoxColumn";
            this.품목코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.품목코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 입출창고DataGridViewTextBoxColumn
            // 
            this.입출창고DataGridViewTextBoxColumn.DataPropertyName = "입출창고";
            this.입출창고DataGridViewTextBoxColumn.HeaderText = "입출창고";
            this.입출창고DataGridViewTextBoxColumn.Name = "입출창고DataGridViewTextBoxColumn";
            this.입출창고DataGridViewTextBoxColumn.ReadOnly = true;
            this.입출창고DataGridViewTextBoxColumn.Visible = false;
            // 
            // 분류DataGridViewTextBoxColumn
            // 
            this.분류DataGridViewTextBoxColumn.DataPropertyName = "분류";
            this.분류DataGridViewTextBoxColumn.FillWeight = 60F;
            this.분류DataGridViewTextBoxColumn.HeaderText = "분류";
            this.분류DataGridViewTextBoxColumn.Name = "분류DataGridViewTextBoxColumn";
            this.분류DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 품목명DataGridViewTextBoxColumn
            // 
            this.품목명DataGridViewTextBoxColumn.DataPropertyName = "품목명";
            this.품목명DataGridViewTextBoxColumn.FillWeight = 150F;
            this.품목명DataGridViewTextBoxColumn.HeaderText = "품목명";
            this.품목명DataGridViewTextBoxColumn.Name = "품목명DataGridViewTextBoxColumn";
            this.품목명DataGridViewTextBoxColumn.ReadOnly = true;
            this.품목명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.품목명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 규격DataGridViewTextBoxColumn
            // 
            this.규격DataGridViewTextBoxColumn.DataPropertyName = "규격";
            this.규격DataGridViewTextBoxColumn.HeaderText = "규격";
            this.규격DataGridViewTextBoxColumn.Name = "규격DataGridViewTextBoxColumn";
            this.규격DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 유형코드DataGridViewTextBoxColumn
            // 
            this.유형코드DataGridViewTextBoxColumn.DataPropertyName = "유형코드";
            this.유형코드DataGridViewTextBoxColumn.HeaderText = "유형코드";
            this.유형코드DataGridViewTextBoxColumn.Name = "유형코드DataGridViewTextBoxColumn";
            this.유형코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.유형코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 조정유형DataGridViewTextBoxColumn
            // 
            this.조정유형DataGridViewTextBoxColumn.DataPropertyName = "조정유형";
            this.조정유형DataGridViewTextBoxColumn.FillWeight = 70F;
            this.조정유형DataGridViewTextBoxColumn.HeaderText = "조정유형";
            this.조정유형DataGridViewTextBoxColumn.Name = "조정유형DataGridViewTextBoxColumn";
            this.조정유형DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 수량DataGridViewTextBoxColumn
            // 
            this.수량DataGridViewTextBoxColumn.DataPropertyName = "수량";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,##0";
            this.수량DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.수량DataGridViewTextBoxColumn.FillWeight = 80F;
            this.수량DataGridViewTextBoxColumn.HeaderText = "수량";
            this.수량DataGridViewTextBoxColumn.Name = "수량DataGridViewTextBoxColumn";
            this.수량DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 조정사유DataGridViewTextBoxColumn
            // 
            this.조정사유DataGridViewTextBoxColumn.DataPropertyName = "조정사유";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.조정사유DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.조정사유DataGridViewTextBoxColumn.FillWeight = 200F;
            this.조정사유DataGridViewTextBoxColumn.HeaderText = "조정사유";
            this.조정사유DataGridViewTextBoxColumn.Name = "조정사유DataGridViewTextBoxColumn";
            this.조정사유DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 등록자DataGridViewTextBoxColumn
            // 
            this.등록자DataGridViewTextBoxColumn.DataPropertyName = "등록자";
            this.등록자DataGridViewTextBoxColumn.FillWeight = 60F;
            this.등록자DataGridViewTextBoxColumn.HeaderText = "등록자";
            this.등록자DataGridViewTextBoxColumn.Name = "등록자DataGridViewTextBoxColumn";
            this.등록자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPStockMoveQueryBindingSource
            // 
            this.sPStockMoveQueryBindingSource.DataMember = "SP_StockMove_Query";
            this.sPStockMoveQueryBindingSource.DataSource = this.dataSetP1A;
            // 
            // dataSetP1A
            // 
            this.dataSetP1A.DataSetName = "DataSetP1A";
            this.dataSetP1A.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_StockMove_QueryTableAdapter
            // 
            this.sP_StockMove_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1A05_STOCK_MOVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1A05_STOCK_MOVE";
            this.Text = "`";
            this.Load += new System.EventHandler(this.P1A05_STOCK_MOVE_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPStockMoveQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 처리IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 처리일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입출창고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분류DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 유형코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조정유형DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조정사유DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등록자DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPStockMoveQueryBindingSource;
        private P1A.DataSetP1A dataSetP1A;
        private P1A.DataSetP1ATableAdapters.SP_StockMove_QueryTableAdapter sP_StockMove_QueryTableAdapter;
        public System.Windows.Forms.ComboBox cbDepot;
        public System.Windows.Forms.ComboBox cbGubun;
        public System.Windows.Forms.DateTimePicker dtpToDate;
        public System.Windows.Forms.DateTimePicker dtpFromDate;
    }
}

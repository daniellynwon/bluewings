namespace SmartMES_Bluewings
{
    partial class P1C01_PROD_ORDER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPProdOrderQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1C = new SmartMES_Bluewings.P1C.DataSetP1C();
            this.sP_ProdOrder_QueryTableAdapter = new SmartMES_Bluewings.P1C.DataSetP1CTableAdapters.SP_ProdOrder_QueryTableAdapter();
            this.lotNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.설비코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.중량A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.중량B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재MB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.중량MB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.배합시간 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.완료DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재명A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재명B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재명MB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.레시피 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPProdOrderQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1C)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "작업지시등록";
            // 
            // pbPrint
            // 
            this.pbPrint.Enabled = true;
            this.pbPrint.Image = global::SmartMES_Bluewings.Properties.Resources.out_A;
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = global::SmartMES_Bluewings.Properties.Resources.save_B;
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
            this.panSearch.Controls.Add(this.lblMsg);
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label5);
            this.panSearch.Controls.Add(this.label4);
            this.panSearch.Controls.Add(this.dtpDate);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 71);
            this.panSearch.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(15, 48);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(879, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(176, 29);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(739, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "품목명/레시피No";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(37, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lot생성기간";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Location = new System.Drawing.Point(138, 19);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(211, 29);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lotNoDataGridViewTextBoxColumn,
            this.설비코드,
            this.설비명,
            this.품목코드DataGridViewTextBoxColumn,
            this.품목명DataGridViewTextBoxColumn,
            this.일자DataGridViewTextBoxColumn,
            this.자재A,
            this.중량A,
            this.자재B,
            this.중량B,
            this.자재MB,
            this.중량MB,
            this.배합시간,
            this.완료DataGridViewTextBoxColumn,
            this.자재명A,
            this.자재명B,
            this.자재명MB,
            this.레시피});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPProdOrderQueryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 858);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // sPProdOrderQueryBindingSource
            // 
            this.sPProdOrderQueryBindingSource.DataMember = "SP_ProdOrder_Query";
            this.sPProdOrderQueryBindingSource.DataSource = this.dataSetP1C;
            // 
            // dataSetP1C
            // 
            this.dataSetP1C.DataSetName = "DataSetP1C";
            this.dataSetP1C.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_ProdOrder_QueryTableAdapter
            // 
            this.sP_ProdOrder_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // lotNoDataGridViewTextBoxColumn
            // 
            this.lotNoDataGridViewTextBoxColumn.DataPropertyName = "LotNo";
            this.lotNoDataGridViewTextBoxColumn.HeaderText = "LotNo";
            this.lotNoDataGridViewTextBoxColumn.Name = "lotNoDataGridViewTextBoxColumn";
            this.lotNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.lotNoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lotNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 설비코드
            // 
            this.설비코드.DataPropertyName = "설비코드";
            this.설비코드.HeaderText = "설비코드";
            this.설비코드.Name = "설비코드";
            this.설비코드.ReadOnly = true;
            this.설비코드.Visible = false;
            // 
            // 설비명
            // 
            this.설비명.DataPropertyName = "설비명";
            this.설비명.HeaderText = "설비명";
            this.설비명.Name = "설비명";
            this.설비명.ReadOnly = true;
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
            // 일자DataGridViewTextBoxColumn
            // 
            this.일자DataGridViewTextBoxColumn.DataPropertyName = "일자";
            this.일자DataGridViewTextBoxColumn.FillWeight = 70F;
            this.일자DataGridViewTextBoxColumn.HeaderText = "생산일자";
            this.일자DataGridViewTextBoxColumn.Name = "일자DataGridViewTextBoxColumn";
            this.일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 자재A
            // 
            this.자재A.DataPropertyName = "자재명A";
            this.자재A.HeaderText = "자재";
            this.자재A.Name = "자재A";
            this.자재A.ReadOnly = true;
            this.자재A.Visible = false;
            // 
            // 중량A
            // 
            this.중량A.DataPropertyName = "중량A";
            this.중량A.HeaderText = "중량";
            this.중량A.Name = "중량A";
            this.중량A.ReadOnly = true;
            // 
            // 자재B
            // 
            this.자재B.DataPropertyName = "자재명B";
            this.자재B.HeaderText = "자재";
            this.자재B.Name = "자재B";
            this.자재B.ReadOnly = true;
            this.자재B.Visible = false;
            // 
            // 중량B
            // 
            this.중량B.DataPropertyName = "중량B";
            this.중량B.HeaderText = "중량";
            this.중량B.Name = "중량B";
            this.중량B.ReadOnly = true;
            // 
            // 자재MB
            // 
            this.자재MB.DataPropertyName = "자재명MB";
            this.자재MB.HeaderText = "자재";
            this.자재MB.Name = "자재MB";
            this.자재MB.ReadOnly = true;
            this.자재MB.Visible = false;
            // 
            // 중량MB
            // 
            this.중량MB.DataPropertyName = "중량MB";
            this.중량MB.HeaderText = "중량";
            this.중량MB.Name = "중량MB";
            this.중량MB.ReadOnly = true;
            // 
            // 배합시간
            // 
            this.배합시간.DataPropertyName = "배합시간";
            this.배합시간.HeaderText = "배합시간(분)";
            this.배합시간.Name = "배합시간";
            this.배합시간.ReadOnly = true;
            // 
            // 완료DataGridViewTextBoxColumn
            // 
            this.완료DataGridViewTextBoxColumn.DataPropertyName = "완료";
            this.완료DataGridViewTextBoxColumn.FillWeight = 50F;
            this.완료DataGridViewTextBoxColumn.HeaderText = "완료";
            this.완료DataGridViewTextBoxColumn.Name = "완료DataGridViewTextBoxColumn";
            this.완료DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 자재명A
            // 
            this.자재명A.DataPropertyName = "자재A";
            this.자재명A.HeaderText = "자재A";
            this.자재명A.Name = "자재명A";
            this.자재명A.ReadOnly = true;
            this.자재명A.Visible = false;
            // 
            // 자재명B
            // 
            this.자재명B.DataPropertyName = "자재B";
            this.자재명B.HeaderText = "자재B";
            this.자재명B.Name = "자재명B";
            this.자재명B.ReadOnly = true;
            this.자재명B.Visible = false;
            // 
            // 자재명MB
            // 
            this.자재명MB.DataPropertyName = "자재MB";
            this.자재명MB.HeaderText = "자재MB";
            this.자재명MB.Name = "자재명MB";
            this.자재명MB.ReadOnly = true;
            this.자재명MB.Visible = false;
            // 
            // 레시피
            // 
            this.레시피.DataPropertyName = "레시피";
            this.레시피.FillWeight = 70F;
            this.레시피.HeaderText = "레시피";
            this.레시피.Name = "레시피";
            this.레시피.ReadOnly = true;
            this.레시피.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.레시피.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.레시피.Visible = false;
            // 
            // P1C01_PROD_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1C01_PROD_ORDER";
            this.Text = "P1C01_PROD_ORDER";
            this.Load += new System.EventHandler(this.P1C01_PROD_ORDER_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPProdOrderQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1C)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산그룹IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산그룹DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lot번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 공정명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn 작업조DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업지도DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 완료여부DataGridViewTextBoxColumn;
        private P1C.DataSetP1C dataSetP1C;
        private System.Windows.Forms.BindingSource sPProdOrderQueryBindingSource;
        private P1C.DataSetP1CTableAdapters.SP_ProdOrder_QueryTableAdapter sP_ProdOrder_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewLinkColumn lotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재A;
        private System.Windows.Forms.DataGridViewTextBoxColumn 중량A;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재B;
        private System.Windows.Forms.DataGridViewTextBoxColumn 중량B;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재MB;
        private System.Windows.Forms.DataGridViewTextBoxColumn 중량MB;
        private System.Windows.Forms.DataGridViewTextBoxColumn 배합시간;
        private System.Windows.Forms.DataGridViewTextBoxColumn 완료DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재명A;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재명B;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재명MB;
        private System.Windows.Forms.DataGridViewLinkColumn 레시피;
    }
}

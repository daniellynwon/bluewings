namespace SmartMES_Bluewings
{
    partial class P1C03_PROD_DONE
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
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.생산일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.작업시간DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업인원DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.집진기DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.생산량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPProdDoneQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1C = new SmartMES_Bluewings.P1C.DataSetP1C();
            this.sP_ProdDone_QueryTableAdapter = new SmartMES_Bluewings.P1C.DataSetP1CTableAdapters.SP_ProdDone_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPProdDoneQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1C)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "생산완료현황";
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
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Controls.Add(this.dtpToDate);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.dtpFromDate);
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
            this.label1.TabIndex = 6;
            this.label1.Text = "~";
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
            this.dtpToDate.TabIndex = 5;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(74, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "생산기간";
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
            this.dtpFromDate.TabIndex = 2;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
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
            this.생산일자DataGridViewTextBoxColumn,
            this.작업시간DataGridViewTextBoxColumn,
            this.작업인원DataGridViewTextBoxColumn,
            this.집진기DataGridViewTextBoxColumn,
            this.생산량DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPProdDoneQueryBindingSource;
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
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // 생산일자DataGridViewTextBoxColumn
            // 
            this.생산일자DataGridViewTextBoxColumn.DataPropertyName = "생산일자";
            this.생산일자DataGridViewTextBoxColumn.HeaderText = "생산일자";
            this.생산일자DataGridViewTextBoxColumn.Name = "생산일자DataGridViewTextBoxColumn";
            this.생산일자DataGridViewTextBoxColumn.ReadOnly = true;
            this.생산일자DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.생산일자DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 작업시간DataGridViewTextBoxColumn
            // 
            this.작업시간DataGridViewTextBoxColumn.DataPropertyName = "작업시간";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.작업시간DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.작업시간DataGridViewTextBoxColumn.HeaderText = "작업시간";
            this.작업시간DataGridViewTextBoxColumn.Name = "작업시간DataGridViewTextBoxColumn";
            this.작업시간DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 작업인원DataGridViewTextBoxColumn
            // 
            this.작업인원DataGridViewTextBoxColumn.DataPropertyName = "작업인원";
            this.작업인원DataGridViewTextBoxColumn.HeaderText = "작업인원";
            this.작업인원DataGridViewTextBoxColumn.Name = "작업인원DataGridViewTextBoxColumn";
            this.작업인원DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 집진기DataGridViewTextBoxColumn
            // 
            this.집진기DataGridViewTextBoxColumn.DataPropertyName = "집진기";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,###";
            this.집진기DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.집진기DataGridViewTextBoxColumn.HeaderText = "집진기";
            this.집진기DataGridViewTextBoxColumn.Name = "집진기DataGridViewTextBoxColumn";
            this.집진기DataGridViewTextBoxColumn.ReadOnly = true;
            this.집진기DataGridViewTextBoxColumn.Visible = false;
            // 
            // 생산량DataGridViewTextBoxColumn
            // 
            this.생산량DataGridViewTextBoxColumn.DataPropertyName = "생산량";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0";
            this.생산량DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.생산량DataGridViewTextBoxColumn.HeaderText = "생산량";
            this.생산량DataGridViewTextBoxColumn.Name = "생산량DataGridViewTextBoxColumn";
            this.생산량DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPProdDoneQueryBindingSource
            // 
            this.sPProdDoneQueryBindingSource.DataMember = "SP_ProdDone_Query";
            this.sPProdDoneQueryBindingSource.DataSource = this.dataSetP1C;
            // 
            // dataSetP1C
            // 
            this.dataSetP1C.DataSetName = "DataSetP1C";
            this.dataSetP1C.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_ProdDone_QueryTableAdapter
            // 
            this.sP_ProdDone_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1C03_PROD_DONE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1C03_PROD_DONE";
            this.Text = "P1C03_PROD_DONE";
            this.Activated += new System.EventHandler(this.P1C03_PROD_DONE_Activated);
            this.Load += new System.EventHandler(this.P1C03_PROD_DONE_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPProdDoneQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1C)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sPProdDoneQueryBindingSource;
        private P1C.DataSetP1C dataSetP1C;
        private P1C.DataSetP1CTableAdapters.SP_ProdDone_QueryTableAdapter sP_ProdDone_QueryTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산그룹DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 호기DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 운전자IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 운전자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 양품수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산합계DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량사유DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 불량내역DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업시작DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업종료DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 소요시간DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비가동DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 실가동DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고DataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewLinkColumn 생산일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업시간DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업인원DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 집진기DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산량DataGridViewTextBoxColumn;
    }
}

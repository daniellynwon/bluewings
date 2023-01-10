namespace SmartMES_Bluewings
{
    partial class P1D02_MACHINE_LIST
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.관리번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.호기DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비그룹 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제작사DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제작일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구입사DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구입일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비가격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설치장소DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.책임자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aS업체DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비스펙DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비이미지DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.이미지사이즈DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.통신구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비IPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모델번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPMachineCardQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1D = new SmartMES_Bluewings.P1D.DataSetP1D();
            this.sP_MachineCard_QueryTableAdapter = new SmartMES_Bluewings.P1D.DataSetP1DTableAdapters.SP_MachineCard_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMachineCardQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1D)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "보유설비현황";
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
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label1);
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
            this.tbSearch.Location = new System.Drawing.Point(553, 19);
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
            this.label1.Location = new System.Drawing.Point(384, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "호기/설비명/설비그룹";
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
            this.관리번호DataGridViewTextBoxColumn,
            this.호기DataGridViewTextBoxColumn,
            this.설비명DataGridViewTextBoxColumn,
            this.설비그룹,
            this.제작사DataGridViewTextBoxColumn,
            this.제작일자DataGridViewTextBoxColumn,
            this.구입사DataGridViewTextBoxColumn,
            this.구입일자DataGridViewTextBoxColumn,
            this.설비가격DataGridViewTextBoxColumn,
            this.설치장소DataGridViewTextBoxColumn,
            this.책임자DataGridViewTextBoxColumn,
            this.aS업체DataGridViewTextBoxColumn,
            this.설비스펙DataGridViewTextBoxColumn,
            this.비고DataGridViewTextBoxColumn,
            this.설비이미지DataGridViewImageColumn,
            this.이미지사이즈DataGridViewTextBoxColumn,
            this.통신구분DataGridViewTextBoxColumn,
            this.설비IPDataGridViewTextBoxColumn,
            this.모델번호DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPMachineCardQueryBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 852);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // 관리번호DataGridViewTextBoxColumn
            // 
            this.관리번호DataGridViewTextBoxColumn.DataPropertyName = "관리번호";
            this.관리번호DataGridViewTextBoxColumn.HeaderText = "관리번호";
            this.관리번호DataGridViewTextBoxColumn.Name = "관리번호DataGridViewTextBoxColumn";
            this.관리번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.관리번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 호기DataGridViewTextBoxColumn
            // 
            this.호기DataGridViewTextBoxColumn.DataPropertyName = "호기";
            this.호기DataGridViewTextBoxColumn.FillWeight = 50F;
            this.호기DataGridViewTextBoxColumn.HeaderText = "호기";
            this.호기DataGridViewTextBoxColumn.Name = "호기DataGridViewTextBoxColumn";
            this.호기DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 설비명DataGridViewTextBoxColumn
            // 
            this.설비명DataGridViewTextBoxColumn.DataPropertyName = "설비명";
            this.설비명DataGridViewTextBoxColumn.HeaderText = "설비명";
            this.설비명DataGridViewTextBoxColumn.Name = "설비명DataGridViewTextBoxColumn";
            this.설비명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 설비그룹
            // 
            this.설비그룹.DataPropertyName = "설비그룹";
            this.설비그룹.FillWeight = 70F;
            this.설비그룹.HeaderText = "설비그룹";
            this.설비그룹.Name = "설비그룹";
            this.설비그룹.ReadOnly = true;
            // 
            // 제작사DataGridViewTextBoxColumn
            // 
            this.제작사DataGridViewTextBoxColumn.DataPropertyName = "제작사";
            this.제작사DataGridViewTextBoxColumn.HeaderText = "제작사";
            this.제작사DataGridViewTextBoxColumn.Name = "제작사DataGridViewTextBoxColumn";
            this.제작사DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 제작일자DataGridViewTextBoxColumn
            // 
            this.제작일자DataGridViewTextBoxColumn.DataPropertyName = "제작일자";
            this.제작일자DataGridViewTextBoxColumn.FillWeight = 80F;
            this.제작일자DataGridViewTextBoxColumn.HeaderText = "제작일자";
            this.제작일자DataGridViewTextBoxColumn.Name = "제작일자DataGridViewTextBoxColumn";
            this.제작일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 구입사DataGridViewTextBoxColumn
            // 
            this.구입사DataGridViewTextBoxColumn.DataPropertyName = "구입사";
            this.구입사DataGridViewTextBoxColumn.HeaderText = "구입사";
            this.구입사DataGridViewTextBoxColumn.Name = "구입사DataGridViewTextBoxColumn";
            this.구입사DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 구입일자DataGridViewTextBoxColumn
            // 
            this.구입일자DataGridViewTextBoxColumn.DataPropertyName = "구입일자";
            this.구입일자DataGridViewTextBoxColumn.FillWeight = 80F;
            this.구입일자DataGridViewTextBoxColumn.HeaderText = "구입일자";
            this.구입일자DataGridViewTextBoxColumn.Name = "구입일자DataGridViewTextBoxColumn";
            this.구입일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 설비가격DataGridViewTextBoxColumn
            // 
            this.설비가격DataGridViewTextBoxColumn.DataPropertyName = "설비가격";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0";
            this.설비가격DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.설비가격DataGridViewTextBoxColumn.HeaderText = "설비가격";
            this.설비가격DataGridViewTextBoxColumn.Name = "설비가격DataGridViewTextBoxColumn";
            this.설비가격DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 설치장소DataGridViewTextBoxColumn
            // 
            this.설치장소DataGridViewTextBoxColumn.DataPropertyName = "설치장소";
            this.설치장소DataGridViewTextBoxColumn.HeaderText = "설치장소";
            this.설치장소DataGridViewTextBoxColumn.Name = "설치장소DataGridViewTextBoxColumn";
            this.설치장소DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 책임자DataGridViewTextBoxColumn
            // 
            this.책임자DataGridViewTextBoxColumn.DataPropertyName = "책임자";
            this.책임자DataGridViewTextBoxColumn.FillWeight = 60F;
            this.책임자DataGridViewTextBoxColumn.HeaderText = "책임자";
            this.책임자DataGridViewTextBoxColumn.Name = "책임자DataGridViewTextBoxColumn";
            this.책임자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aS업체DataGridViewTextBoxColumn
            // 
            this.aS업체DataGridViewTextBoxColumn.DataPropertyName = "AS업체";
            this.aS업체DataGridViewTextBoxColumn.HeaderText = "A/S업체";
            this.aS업체DataGridViewTextBoxColumn.Name = "aS업체DataGridViewTextBoxColumn";
            this.aS업체DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 설비스펙DataGridViewTextBoxColumn
            // 
            this.설비스펙DataGridViewTextBoxColumn.DataPropertyName = "설비스펙";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.설비스펙DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.설비스펙DataGridViewTextBoxColumn.HeaderText = "설비스펙";
            this.설비스펙DataGridViewTextBoxColumn.Name = "설비스펙DataGridViewTextBoxColumn";
            this.설비스펙DataGridViewTextBoxColumn.ReadOnly = true;
            this.설비스펙DataGridViewTextBoxColumn.Visible = false;
            // 
            // 비고DataGridViewTextBoxColumn
            // 
            this.비고DataGridViewTextBoxColumn.DataPropertyName = "비고";
            this.비고DataGridViewTextBoxColumn.HeaderText = "비고";
            this.비고DataGridViewTextBoxColumn.Name = "비고DataGridViewTextBoxColumn";
            this.비고DataGridViewTextBoxColumn.ReadOnly = true;
            this.비고DataGridViewTextBoxColumn.Visible = false;
            // 
            // 설비이미지DataGridViewImageColumn
            // 
            this.설비이미지DataGridViewImageColumn.DataPropertyName = "설비이미지";
            this.설비이미지DataGridViewImageColumn.HeaderText = "설비이미지";
            this.설비이미지DataGridViewImageColumn.Name = "설비이미지DataGridViewImageColumn";
            this.설비이미지DataGridViewImageColumn.ReadOnly = true;
            this.설비이미지DataGridViewImageColumn.Visible = false;
            // 
            // 이미지사이즈DataGridViewTextBoxColumn
            // 
            this.이미지사이즈DataGridViewTextBoxColumn.DataPropertyName = "이미지사이즈";
            this.이미지사이즈DataGridViewTextBoxColumn.HeaderText = "이미지사이즈";
            this.이미지사이즈DataGridViewTextBoxColumn.Name = "이미지사이즈DataGridViewTextBoxColumn";
            this.이미지사이즈DataGridViewTextBoxColumn.ReadOnly = true;
            this.이미지사이즈DataGridViewTextBoxColumn.Visible = false;
            // 
            // 통신구분DataGridViewTextBoxColumn
            // 
            this.통신구분DataGridViewTextBoxColumn.DataPropertyName = "통신구분";
            this.통신구분DataGridViewTextBoxColumn.HeaderText = "통신구분";
            this.통신구분DataGridViewTextBoxColumn.Name = "통신구분DataGridViewTextBoxColumn";
            this.통신구분DataGridViewTextBoxColumn.ReadOnly = true;
            this.통신구분DataGridViewTextBoxColumn.Visible = false;
            // 
            // 설비IPDataGridViewTextBoxColumn
            // 
            this.설비IPDataGridViewTextBoxColumn.DataPropertyName = "설비IP";
            this.설비IPDataGridViewTextBoxColumn.HeaderText = "설비IP";
            this.설비IPDataGridViewTextBoxColumn.Name = "설비IPDataGridViewTextBoxColumn";
            this.설비IPDataGridViewTextBoxColumn.ReadOnly = true;
            this.설비IPDataGridViewTextBoxColumn.Visible = false;
            // 
            // 모델번호DataGridViewTextBoxColumn
            // 
            this.모델번호DataGridViewTextBoxColumn.DataPropertyName = "모델번호";
            this.모델번호DataGridViewTextBoxColumn.HeaderText = "모델번호";
            this.모델번호DataGridViewTextBoxColumn.Name = "모델번호DataGridViewTextBoxColumn";
            this.모델번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.모델번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // sPMachineCardQueryBindingSource
            // 
            this.sPMachineCardQueryBindingSource.DataMember = "SP_MachineCard_Query";
            this.sPMachineCardQueryBindingSource.DataSource = this.dataSetP1D;
            // 
            // dataSetP1D
            // 
            this.dataSetP1D.DataSetName = "DataSetP1D";
            this.dataSetP1D.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_MachineCard_QueryTableAdapter
            // 
            this.sP_MachineCard_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1D02_MACHINE_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1D02_MACHINE_LIST";
            this.Text = "P1D02_MACHINE_LIST";
            this.Activated += new System.EventHandler(this.P1D02_MACHINE_LIST_Activated);
            this.Load += new System.EventHandler(this.P1D02_MACHINE_LIST_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPMachineCardQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.BindingSource sPMachineCardQueryBindingSource;
        private P1D.DataSetP1D dataSetP1D;
        private P1D.DataSetP1DTableAdapters.SP_MachineCard_QueryTableAdapter sP_MachineCard_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관리번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 호기DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비그룹;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제작사DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제작일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구입사DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구입일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비가격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설치장소DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 책임자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aS업체DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비스펙DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn 설비이미지DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이미지사이즈DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 통신구분DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비IPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델번호DataGridViewTextBoxColumn;
    }
}

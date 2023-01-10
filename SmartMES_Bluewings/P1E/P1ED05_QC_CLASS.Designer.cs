
namespace SmartMES_Bluewings
{
    partial class P1ED05_QC_CLASS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPQcClassQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1E = new SmartMES_Bluewings.P1E.DataSetP1E();
            this.sP_Qc_Class_QueryTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_Qc_Class_QueryTableAdapter();
            this.검사일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.포대번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.규격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.항목1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결과1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판정1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.항목2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결과2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판정2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.항목3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결과3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판정3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사원이름DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사원DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcClassQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).BeginInit();
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
            // pbDel
            // 
            this.pbDel.Image = global::SmartMES_Bluewings.Properties.Resources.del_B;
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
            this.panSearch.Controls.Add(this.label3);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.dtpToDate);
            this.panSearch.Controls.Add(this.dtpFromDate);
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 71);
            this.panSearch.TabIndex = 1;
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
            this.label2.Text = "검사기간";
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
            this.tbSearch.Location = new System.Drawing.Point(771, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(180, 29);
            this.tbSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(655, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "LotNo/검사원";
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
            this.검사일자DataGridViewTextBoxColumn,
            this.lotNoDataGridViewTextBoxColumn,
            this.포대번호DataGridViewTextBoxColumn,
            this.규격DataGridViewTextBoxColumn,
            this.항목1DataGridViewTextBoxColumn,
            this.결과1DataGridViewTextBoxColumn,
            this.판정1DataGridViewTextBoxColumn,
            this.항목2DataGridViewTextBoxColumn,
            this.결과2DataGridViewTextBoxColumn,
            this.판정2DataGridViewTextBoxColumn,
            this.항목3DataGridViewTextBoxColumn,
            this.결과3DataGridViewTextBoxColumn,
            this.판정3DataGridViewTextBoxColumn,
            this.검사원이름DataGridViewTextBoxColumn,
            this.검사원DataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPQcClassQueryBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 852);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // sPQcClassQueryBindingSource
            // 
            this.sPQcClassQueryBindingSource.DataMember = "SP_Qc_Class_Query";
            this.sPQcClassQueryBindingSource.DataSource = this.dataSetP1E;
            // 
            // dataSetP1E
            // 
            this.dataSetP1E.DataSetName = "DataSetP1E";
            this.dataSetP1E.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_Qc_Class_QueryTableAdapter
            // 
            this.sP_Qc_Class_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // 검사일자DataGridViewTextBoxColumn
            // 
            this.검사일자DataGridViewTextBoxColumn.DataPropertyName = "검사일자";
            this.검사일자DataGridViewTextBoxColumn.HeaderText = "검사일자";
            this.검사일자DataGridViewTextBoxColumn.Name = "검사일자DataGridViewTextBoxColumn";
            this.검사일자DataGridViewTextBoxColumn.ReadOnly = true;
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
            // 포대번호DataGridViewTextBoxColumn
            // 
            this.포대번호DataGridViewTextBoxColumn.DataPropertyName = "포대번호";
            this.포대번호DataGridViewTextBoxColumn.HeaderText = "포대번호";
            this.포대번호DataGridViewTextBoxColumn.Name = "포대번호DataGridViewTextBoxColumn";
            this.포대번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.포대번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 규격DataGridViewTextBoxColumn
            // 
            this.규격DataGridViewTextBoxColumn.DataPropertyName = "규격";
            this.규격DataGridViewTextBoxColumn.HeaderText = "규격";
            this.규격DataGridViewTextBoxColumn.Name = "규격DataGridViewTextBoxColumn";
            this.규격DataGridViewTextBoxColumn.ReadOnly = true;
            this.규격DataGridViewTextBoxColumn.Visible = false;
            // 
            // 항목1DataGridViewTextBoxColumn
            // 
            this.항목1DataGridViewTextBoxColumn.DataPropertyName = "항목1";
            this.항목1DataGridViewTextBoxColumn.HeaderText = "항목";
            this.항목1DataGridViewTextBoxColumn.Name = "항목1DataGridViewTextBoxColumn";
            this.항목1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 결과1DataGridViewTextBoxColumn
            // 
            this.결과1DataGridViewTextBoxColumn.DataPropertyName = "결과1";
            this.결과1DataGridViewTextBoxColumn.HeaderText = "결과";
            this.결과1DataGridViewTextBoxColumn.Name = "결과1DataGridViewTextBoxColumn";
            this.결과1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 판정1DataGridViewTextBoxColumn
            // 
            this.판정1DataGridViewTextBoxColumn.DataPropertyName = "판정1";
            this.판정1DataGridViewTextBoxColumn.HeaderText = "판정";
            this.판정1DataGridViewTextBoxColumn.Name = "판정1DataGridViewTextBoxColumn";
            this.판정1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 항목2DataGridViewTextBoxColumn
            // 
            this.항목2DataGridViewTextBoxColumn.DataPropertyName = "항목2";
            this.항목2DataGridViewTextBoxColumn.HeaderText = "항목";
            this.항목2DataGridViewTextBoxColumn.Name = "항목2DataGridViewTextBoxColumn";
            this.항목2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 결과2DataGridViewTextBoxColumn
            // 
            this.결과2DataGridViewTextBoxColumn.DataPropertyName = "결과2";
            this.결과2DataGridViewTextBoxColumn.HeaderText = "결과";
            this.결과2DataGridViewTextBoxColumn.Name = "결과2DataGridViewTextBoxColumn";
            this.결과2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 판정2DataGridViewTextBoxColumn
            // 
            this.판정2DataGridViewTextBoxColumn.DataPropertyName = "판정2";
            this.판정2DataGridViewTextBoxColumn.HeaderText = "판정";
            this.판정2DataGridViewTextBoxColumn.Name = "판정2DataGridViewTextBoxColumn";
            this.판정2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 항목3DataGridViewTextBoxColumn
            // 
            this.항목3DataGridViewTextBoxColumn.DataPropertyName = "항목3";
            this.항목3DataGridViewTextBoxColumn.HeaderText = "항목";
            this.항목3DataGridViewTextBoxColumn.Name = "항목3DataGridViewTextBoxColumn";
            this.항목3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 결과3DataGridViewTextBoxColumn
            // 
            this.결과3DataGridViewTextBoxColumn.DataPropertyName = "결과3";
            this.결과3DataGridViewTextBoxColumn.HeaderText = "결과";
            this.결과3DataGridViewTextBoxColumn.Name = "결과3DataGridViewTextBoxColumn";
            this.결과3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 판정3DataGridViewTextBoxColumn
            // 
            this.판정3DataGridViewTextBoxColumn.DataPropertyName = "판정3";
            this.판정3DataGridViewTextBoxColumn.HeaderText = "판정";
            this.판정3DataGridViewTextBoxColumn.Name = "판정3DataGridViewTextBoxColumn";
            this.판정3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 검사원이름DataGridViewTextBoxColumn
            // 
            this.검사원이름DataGridViewTextBoxColumn.DataPropertyName = "검사원이름";
            this.검사원이름DataGridViewTextBoxColumn.HeaderText = "검사원";
            this.검사원이름DataGridViewTextBoxColumn.Name = "검사원이름DataGridViewTextBoxColumn";
            this.검사원이름DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 검사원DataGridViewTextBoxColumn
            // 
            this.검사원DataGridViewTextBoxColumn.DataPropertyName = "검사원";
            this.검사원DataGridViewTextBoxColumn.HeaderText = "검사원";
            this.검사원DataGridViewTextBoxColumn.Name = "검사원DataGridViewTextBoxColumn";
            this.검사원DataGridViewTextBoxColumn.ReadOnly = true;
            this.검사원DataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "X";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // P1ED05_QC_CLASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Name = "P1ED05_QC_CLASS";
            this.Text = "P1ED05_QC_CLASS";
            this.Load += new System.EventHandler(this.P1ED05_QC_CLASS_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPQcClassQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 철망번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등급DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 의견DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPQcClassQueryBindingSource;
        private P1E.DataSetP1E dataSetP1E;
        private P1E.DataSetP1ETableAdapters.SP_Qc_Class_QueryTableAdapter sP_Qc_Class_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn lotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 포대번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 항목1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결과1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판정1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 항목2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결과2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판정2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 항목3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결과3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판정3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사원이름DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사원DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
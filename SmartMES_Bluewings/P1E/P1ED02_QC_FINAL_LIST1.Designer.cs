namespace SmartMES_Bluewings
{
    partial class P1ED02_QC_FINAL_LIST1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPQcFinalListListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1E = new SmartMES_Bluewings.P1E.DataSetP1E();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sP_QcFinalList_ListTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_QcFinalList_ListTableAdapter();
            this.번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.포대번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사일DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.항목1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결과1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판정1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.항목2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결과2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판정2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.항목3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.결과3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판정3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사자ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.검사자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalListListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "품질검사현황";
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
            this.panSearch.Controls.Add(this.label4);
            this.panSearch.Controls.Add(this.label3);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.dtpToDate);
            this.panSearch.Controls.Add(this.dtpFromDate);
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
            this.tbSearch.Location = new System.Drawing.Point(910, 20);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(265, 29);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(846, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "검사자";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(429, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(139, 24);
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
            this.dtpToDate.Location = new System.Drawing.Point(452, 20);
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
            this.dtpFromDate.Location = new System.Drawing.Point(216, 20);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(211, 29);
            this.dtpFromDate.TabIndex = 1;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.번호,
            this.포대번호,
            this.검사일DataGridViewTextBoxColumn,
            this.항목1DataGridViewTextBoxColumn,
            this.결과1DataGridViewTextBoxColumn,
            this.판정1DataGridViewTextBoxColumn,
            this.항목2DataGridViewTextBoxColumn,
            this.결과2DataGridViewTextBoxColumn,
            this.판정2DataGridViewTextBoxColumn,
            this.항목3,
            this.결과3,
            this.판정3,
            this.비고DataGridViewTextBoxColumn,
            this.검사자ID,
            this.검사자DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPQcFinalListListBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 368);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // sPQcFinalListListBindingSource
            // 
            this.sPQcFinalListListBindingSource.DataMember = "SP_QcFinalList_List";
            this.sPQcFinalListListBindingSource.DataSource = this.dataSetP1E;
            // 
            // dataSetP1E
            // 
            this.dataSetP1E.DataSetName = "DataSetP1E";
            this.dataSetP1E.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chartA);
            this.panel1.Location = new System.Drawing.Point(2, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 473);
            this.panel1.TabIndex = 11;
            // 
            // chartA
            // 
            this.chartA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartA.BackColor = System.Drawing.Color.AliceBlue;
            this.chartA.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartA.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartA.Legends.Add(legend1);
            this.chartA.Location = new System.Drawing.Point(0, 0);
            this.chartA.Name = "chartA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.chartA.Series.Add(series1);
            this.chartA.Series.Add(series2);
            this.chartA.Series.Add(series3);
            this.chartA.Size = new System.Drawing.Size(1319, 473);
            this.chartA.TabIndex = 2;
            this.chartA.Text = "chart1";
            // 
            // sP_QcFinalList_ListTableAdapter
            // 
            this.sP_QcFinalList_ListTableAdapter.ClearBeforeFill = true;
            // 
            // 번호
            // 
            this.번호.DataPropertyName = "번호";
            this.번호.FillWeight = 30F;
            this.번호.HeaderText = "";
            this.번호.Name = "번호";
            this.번호.ReadOnly = true;
            // 
            // 포대번호
            // 
            this.포대번호.DataPropertyName = "포대번호";
            this.포대번호.HeaderText = "포대번호";
            this.포대번호.Name = "포대번호";
            this.포대번호.ReadOnly = true;
            // 
            // 검사일DataGridViewTextBoxColumn
            // 
            this.검사일DataGridViewTextBoxColumn.DataPropertyName = "검사일";
            this.검사일DataGridViewTextBoxColumn.HeaderText = "검사일";
            this.검사일DataGridViewTextBoxColumn.Name = "검사일DataGridViewTextBoxColumn";
            this.검사일DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 항목1DataGridViewTextBoxColumn
            // 
            this.항목1DataGridViewTextBoxColumn.DataPropertyName = "항목1";
            this.항목1DataGridViewTextBoxColumn.FillWeight = 80F;
            this.항목1DataGridViewTextBoxColumn.HeaderText = "항목";
            this.항목1DataGridViewTextBoxColumn.Name = "항목1DataGridViewTextBoxColumn";
            this.항목1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 결과1DataGridViewTextBoxColumn
            // 
            this.결과1DataGridViewTextBoxColumn.DataPropertyName = "결과1";
            this.결과1DataGridViewTextBoxColumn.FillWeight = 80F;
            this.결과1DataGridViewTextBoxColumn.HeaderText = "결과";
            this.결과1DataGridViewTextBoxColumn.Name = "결과1DataGridViewTextBoxColumn";
            this.결과1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 판정1DataGridViewTextBoxColumn
            // 
            this.판정1DataGridViewTextBoxColumn.DataPropertyName = "판정1";
            this.판정1DataGridViewTextBoxColumn.FillWeight = 80F;
            this.판정1DataGridViewTextBoxColumn.HeaderText = "판정";
            this.판정1DataGridViewTextBoxColumn.Name = "판정1DataGridViewTextBoxColumn";
            this.판정1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 항목2DataGridViewTextBoxColumn
            // 
            this.항목2DataGridViewTextBoxColumn.DataPropertyName = "항목2";
            this.항목2DataGridViewTextBoxColumn.FillWeight = 80F;
            this.항목2DataGridViewTextBoxColumn.HeaderText = "항목";
            this.항목2DataGridViewTextBoxColumn.Name = "항목2DataGridViewTextBoxColumn";
            this.항목2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 결과2DataGridViewTextBoxColumn
            // 
            this.결과2DataGridViewTextBoxColumn.DataPropertyName = "결과2";
            this.결과2DataGridViewTextBoxColumn.FillWeight = 80F;
            this.결과2DataGridViewTextBoxColumn.HeaderText = "결과";
            this.결과2DataGridViewTextBoxColumn.Name = "결과2DataGridViewTextBoxColumn";
            this.결과2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 판정2DataGridViewTextBoxColumn
            // 
            this.판정2DataGridViewTextBoxColumn.DataPropertyName = "판정2";
            this.판정2DataGridViewTextBoxColumn.FillWeight = 80F;
            this.판정2DataGridViewTextBoxColumn.HeaderText = "판정";
            this.판정2DataGridViewTextBoxColumn.Name = "판정2DataGridViewTextBoxColumn";
            this.판정2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 항목3
            // 
            this.항목3.DataPropertyName = "항목3";
            this.항목3.FillWeight = 80F;
            this.항목3.HeaderText = "항목";
            this.항목3.Name = "항목3";
            this.항목3.ReadOnly = true;
            // 
            // 결과3
            // 
            this.결과3.DataPropertyName = "결과3";
            this.결과3.FillWeight = 80F;
            this.결과3.HeaderText = "결과";
            this.결과3.Name = "결과3";
            this.결과3.ReadOnly = true;
            // 
            // 판정3
            // 
            this.판정3.DataPropertyName = "판정3";
            this.판정3.FillWeight = 80F;
            this.판정3.HeaderText = "판정";
            this.판정3.Name = "판정3";
            this.판정3.ReadOnly = true;
            // 
            // 비고DataGridViewTextBoxColumn
            // 
            this.비고DataGridViewTextBoxColumn.DataPropertyName = "비고";
            this.비고DataGridViewTextBoxColumn.FillWeight = 150F;
            this.비고DataGridViewTextBoxColumn.HeaderText = "비고";
            this.비고DataGridViewTextBoxColumn.Name = "비고DataGridViewTextBoxColumn";
            this.비고DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 검사자ID
            // 
            this.검사자ID.DataPropertyName = "검사자ID";
            this.검사자ID.HeaderText = "검사자ID";
            this.검사자ID.Name = "검사자ID";
            this.검사자ID.ReadOnly = true;
            this.검사자ID.Visible = false;
            // 
            // 검사자DataGridViewTextBoxColumn
            // 
            this.검사자DataGridViewTextBoxColumn.DataPropertyName = "검사자";
            this.검사자DataGridViewTextBoxColumn.HeaderText = "검사자";
            this.검사자DataGridViewTextBoxColumn.Name = "검사자DataGridViewTextBoxColumn";
            this.검사자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // P1ED02_QC_FINAL_LIST1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1ED02_QC_FINAL_LIST1";
            this.Text = "P1ED02_QC_FINAL_LIST1";
            this.Load += new System.EventHandler(this.P1ED02_QC_FINAL_LIST1_Load);
            this.Controls.SetChildIndex(this.panSearch, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalListListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpToDate;
        public System.Windows.Forms.DateTimePicker dtpFromDate;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn 항목DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결과DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판정DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPQcFinalListListBindingSource;
        private P1E.DataSetP1E dataSetP1E;
        private P1E.DataSetP1ETableAdapters.SP_QcFinalList_ListTableAdapter sP_QcFinalList_ListTableAdapter;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartA;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 포대번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사일DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 항목1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결과1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판정1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 항목2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결과2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판정2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 항목3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 결과3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판정3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사자ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 검사자DataGridViewTextBoxColumn;
    }
}

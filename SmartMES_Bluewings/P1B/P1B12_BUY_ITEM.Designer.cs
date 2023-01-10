namespace SmartMES_Bluewings
{
    partial class P1B12_BUY_ITEM
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
            this.ubDel = new SmartMES_Bluewings.UserButtonA();
            this.tbCust = new System.Windows.Forms.TextBox();
            this.lblCust = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPBuyItemQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1B = new SmartMES_Bluewings.P1B.DataSetP1B();
            this.sP_BuyItem_QueryTableAdapter = new SmartMES_Bluewings.P1B.DataSetP1BTableAdapters.SP_BuyItem_QueryTableAdapter();
            this.입고일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매입처IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매입처명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.규격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단가DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매입액DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.부가세DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.합계금액DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.창고IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.입고창고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBuyItemQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1B)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "품목별매입현황";
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
            this.panSearch.Controls.Add(this.ubDel);
            this.panSearch.Controls.Add(this.tbCust);
            this.panSearch.Controls.Add(this.lblCust);
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
            // ubDel
            // 
            this.ubDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ubDel.BackColor = System.Drawing.Color.Transparent;
            this.ubDel.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.eraser;
            this.ubDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ubDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ubDel.buttonImage = global::SmartMES_Bluewings.Properties.Resources.eraser;
            this.ubDel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ubDel.Location = new System.Drawing.Point(349, 22);
            this.ubDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ubDel.Name = "ubDel";
            this.ubDel.Size = new System.Drawing.Size(26, 25);
            this.ubDel.TabIndex = 0;
            this.ubDel.Click += new System.EventHandler(this.ubDel_Click);
            // 
            // tbCust
            // 
            this.tbCust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCust.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbCust.Location = new System.Drawing.Point(136, 20);
            this.tbCust.Name = "tbCust";
            this.tbCust.ReadOnly = true;
            this.tbCust.Size = new System.Drawing.Size(211, 29);
            this.tbCust.TabIndex = 0;
            this.tbCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCust
            // 
            this.lblCust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCust.AutoSize = true;
            this.lblCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCust.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline);
            this.lblCust.ForeColor = System.Drawing.Color.Blue;
            this.lblCust.Location = new System.Drawing.Point(63, 24);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(70, 21);
            this.lblCust.TabIndex = 11;
            this.lblCust.Text = "매 입 처";
            this.lblCust.Click += new System.EventHandler(this.lblCust_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(719, 24);
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
            this.label2.Location = new System.Drawing.Point(429, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "매입기간";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpToDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Location = new System.Drawing.Point(742, 20);
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
            this.dtpFromDate.Location = new System.Drawing.Point(506, 20);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(211, 29);
            this.dtpFromDate.TabIndex = 1;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(1105, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(162, 29);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(1006, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목명/규격";
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
            this.입고일자DataGridViewTextBoxColumn,
            this.매입처IDDataGridViewTextBoxColumn,
            this.매입처명DataGridViewTextBoxColumn,
            this.품목코드DataGridViewTextBoxColumn,
            this.품목명DataGridViewTextBoxColumn,
            this.자재명DataGridViewTextBoxColumn,
            this.규격DataGridViewTextBoxColumn,
            this.수량DataGridViewTextBoxColumn,
            this.단가DataGridViewTextBoxColumn,
            this.매입액DataGridViewTextBoxColumn,
            this.부가세DataGridViewTextBoxColumn,
            this.합계금액DataGridViewTextBoxColumn,
            this.창고IDDataGridViewTextBoxColumn,
            this.입고창고DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPBuyItemQueryBindingSource;
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
            // sPBuyItemQueryBindingSource
            // 
            this.sPBuyItemQueryBindingSource.DataMember = "SP_BuyItem_Query";
            this.sPBuyItemQueryBindingSource.DataSource = this.dataSetP1B;
            // 
            // dataSetP1B
            // 
            this.dataSetP1B.DataSetName = "DataSetP1B";
            this.dataSetP1B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_BuyItem_QueryTableAdapter
            // 
            this.sP_BuyItem_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // 입고일자DataGridViewTextBoxColumn
            // 
            this.입고일자DataGridViewTextBoxColumn.DataPropertyName = "입고일자";
            dataGridViewCellStyle3.Format = "MM\\/dd";
            this.입고일자DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.입고일자DataGridViewTextBoxColumn.FillWeight = 70F;
            this.입고일자DataGridViewTextBoxColumn.HeaderText = "입고일자";
            this.입고일자DataGridViewTextBoxColumn.Name = "입고일자DataGridViewTextBoxColumn";
            this.입고일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 매입처IDDataGridViewTextBoxColumn
            // 
            this.매입처IDDataGridViewTextBoxColumn.DataPropertyName = "매입처ID";
            this.매입처IDDataGridViewTextBoxColumn.HeaderText = "매입처ID";
            this.매입처IDDataGridViewTextBoxColumn.Name = "매입처IDDataGridViewTextBoxColumn";
            this.매입처IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.매입처IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 매입처명DataGridViewTextBoxColumn
            // 
            this.매입처명DataGridViewTextBoxColumn.DataPropertyName = "매입처명";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.매입처명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.매입처명DataGridViewTextBoxColumn.HeaderText = "매입처명";
            this.매입처명DataGridViewTextBoxColumn.Name = "매입처명DataGridViewTextBoxColumn";
            this.매입처명DataGridViewTextBoxColumn.ReadOnly = true;
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
            // 자재명DataGridViewTextBoxColumn
            // 
            this.자재명DataGridViewTextBoxColumn.DataPropertyName = "자재명";
            this.자재명DataGridViewTextBoxColumn.HeaderText = "자재명";
            this.자재명DataGridViewTextBoxColumn.Name = "자재명DataGridViewTextBoxColumn";
            this.자재명DataGridViewTextBoxColumn.ReadOnly = true;
            this.자재명DataGridViewTextBoxColumn.Visible = false;
            // 
            // 규격DataGridViewTextBoxColumn
            // 
            this.규격DataGridViewTextBoxColumn.DataPropertyName = "규격";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.규격DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.규격DataGridViewTextBoxColumn.HeaderText = "규격";
            this.규격DataGridViewTextBoxColumn.Name = "규격DataGridViewTextBoxColumn";
            this.규격DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 수량DataGridViewTextBoxColumn
            // 
            this.수량DataGridViewTextBoxColumn.DataPropertyName = "수량";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0";
            this.수량DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.수량DataGridViewTextBoxColumn.HeaderText = "수량";
            this.수량DataGridViewTextBoxColumn.Name = "수량DataGridViewTextBoxColumn";
            this.수량DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 단가DataGridViewTextBoxColumn
            // 
            this.단가DataGridViewTextBoxColumn.DataPropertyName = "단가";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#,##0";
            this.단가DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.단가DataGridViewTextBoxColumn.HeaderText = "단가";
            this.단가DataGridViewTextBoxColumn.Name = "단가DataGridViewTextBoxColumn";
            this.단가DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 매입액DataGridViewTextBoxColumn
            // 
            this.매입액DataGridViewTextBoxColumn.DataPropertyName = "매입액";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "#,##0";
            this.매입액DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.매입액DataGridViewTextBoxColumn.HeaderText = "매입액";
            this.매입액DataGridViewTextBoxColumn.Name = "매입액DataGridViewTextBoxColumn";
            this.매입액DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 부가세DataGridViewTextBoxColumn
            // 
            this.부가세DataGridViewTextBoxColumn.DataPropertyName = "부가세";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "#,##0";
            this.부가세DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.부가세DataGridViewTextBoxColumn.HeaderText = "부가세";
            this.부가세DataGridViewTextBoxColumn.Name = "부가세DataGridViewTextBoxColumn";
            this.부가세DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 합계금액DataGridViewTextBoxColumn
            // 
            this.합계금액DataGridViewTextBoxColumn.DataPropertyName = "합계금액";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#,##0";
            this.합계금액DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.합계금액DataGridViewTextBoxColumn.HeaderText = "합계금액";
            this.합계금액DataGridViewTextBoxColumn.Name = "합계금액DataGridViewTextBoxColumn";
            this.합계금액DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 창고IDDataGridViewTextBoxColumn
            // 
            this.창고IDDataGridViewTextBoxColumn.DataPropertyName = "창고ID";
            this.창고IDDataGridViewTextBoxColumn.HeaderText = "창고ID";
            this.창고IDDataGridViewTextBoxColumn.Name = "창고IDDataGridViewTextBoxColumn";
            this.창고IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.창고IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 입고창고DataGridViewTextBoxColumn
            // 
            this.입고창고DataGridViewTextBoxColumn.DataPropertyName = "입고창고";
            this.입고창고DataGridViewTextBoxColumn.HeaderText = "입고창고";
            this.입고창고DataGridViewTextBoxColumn.Name = "입고창고DataGridViewTextBoxColumn";
            this.입고창고DataGridViewTextBoxColumn.ReadOnly = true;
            this.입고창고DataGridViewTextBoxColumn.Visible = false;
            // 
            // P1B12_BUY_ITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1B12_BUY_ITEM";
            this.Text = "P1B12_BUY_ITEM";
            this.Activated += new System.EventHandler(this.P1B12_BUY_ITEM_Activated);
            this.Load += new System.EventHandler(this.P1B12_BUY_ITEM_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPBuyItemQueryBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource sPBuyItemQueryBindingSource;
        private P1B.DataSetP1B dataSetP1B;
        private P1B.DataSetP1BTableAdapters.SP_BuyItem_QueryTableAdapter sP_BuyItem_QueryTableAdapter;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.TextBox tbCust;
        private UserButtonA ubDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입고일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매입처IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매입처명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단가DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매입액DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 부가세DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 합계금액DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 창고IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입고창고DataGridViewTextBoxColumn;
    }
}

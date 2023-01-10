namespace SmartMES_Bluewings
{
    partial class P1B07_DELI_ORDER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.지시번호DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.지시순번DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.규격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단위DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수주번호DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수주순번DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sPDeliorderSubQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1B = new SmartMES_Bluewings.P1B.DataSetP1B();
            this.sPZCommonIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panSearch = new System.Windows.Forms.Panel();
            this.tbRorder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDeliCar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.tbPlace = new System.Windows.Forms.TextBox();
            this.tbCust = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.tbDeliInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNo = new System.Windows.Forms.CheckBox();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.지시번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.수주번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.출하지시일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.현장정보DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.배송수단DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.요청일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.등록일시DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.등록자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPDeliorderMainQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.sP_Z_Common_IDTableAdapter = new SmartMES_Bluewings.P1B.DataSetP1BTableAdapters.SP_Z_Common_IDTableAdapter();
            this.sP_Deliorder_Main_QueryTableAdapter = new SmartMES_Bluewings.P1B.DataSetP1BTableAdapters.SP_Deliorder_Main_QueryTableAdapter();
            this.sP_Deliorder_Sub_QueryTableAdapter = new SmartMES_Bluewings.P1B.DataSetP1BTableAdapters.SP_Deliorder_Sub_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDeliorderSubQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPZCommonIDBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDeliorderMainQueryBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "출하지시";
            // 
            // pbPrint
            // 
            this.pbPrint.Image = global::SmartMES_Bluewings.Properties.Resources.out_B;
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
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbSearch
            // 
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // dataGridView1
            // 
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
            this.지시번호DataGridViewTextBoxColumn1,
            this.지시순번DataGridViewTextBoxColumn,
            this.품목코드DataGridViewTextBoxColumn,
            this.품목명DataGridViewTextBoxColumn,
            this.규격DataGridViewTextBoxColumn,
            this.단위DataGridViewTextBoxColumn,
            this.수량DataGridViewTextBoxColumn,
            this.수주번호DataGridViewTextBoxColumn1,
            this.수주순번DataGridViewTextBoxColumn,
            this.비고DataGridViewTextBoxColumn,
            this.ColumnDel});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPDeliorderSubQueryBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(310, 292);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 691);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // 지시번호DataGridViewTextBoxColumn1
            // 
            this.지시번호DataGridViewTextBoxColumn1.DataPropertyName = "지시번호";
            this.지시번호DataGridViewTextBoxColumn1.HeaderText = "지시번호";
            this.지시번호DataGridViewTextBoxColumn1.Name = "지시번호DataGridViewTextBoxColumn1";
            this.지시번호DataGridViewTextBoxColumn1.Visible = false;
            // 
            // 지시순번DataGridViewTextBoxColumn
            // 
            this.지시순번DataGridViewTextBoxColumn.DataPropertyName = "지시순번";
            this.지시순번DataGridViewTextBoxColumn.HeaderText = "지시순번";
            this.지시순번DataGridViewTextBoxColumn.Name = "지시순번DataGridViewTextBoxColumn";
            this.지시순번DataGridViewTextBoxColumn.Visible = false;
            // 
            // 품목코드DataGridViewTextBoxColumn
            // 
            this.품목코드DataGridViewTextBoxColumn.DataPropertyName = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.HeaderText = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.Name = "품목코드DataGridViewTextBoxColumn";
            this.품목코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 품목명DataGridViewTextBoxColumn
            // 
            this.품목명DataGridViewTextBoxColumn.DataPropertyName = "품목명";
            this.품목명DataGridViewTextBoxColumn.HeaderText = "품목명";
            this.품목명DataGridViewTextBoxColumn.Name = "품목명DataGridViewTextBoxColumn";
            // 
            // 규격DataGridViewTextBoxColumn
            // 
            this.규격DataGridViewTextBoxColumn.DataPropertyName = "규격";
            this.규격DataGridViewTextBoxColumn.HeaderText = "규격";
            this.규격DataGridViewTextBoxColumn.Name = "규격DataGridViewTextBoxColumn";
            // 
            // 단위DataGridViewTextBoxColumn
            // 
            this.단위DataGridViewTextBoxColumn.DataPropertyName = "단위";
            this.단위DataGridViewTextBoxColumn.HeaderText = "단위";
            this.단위DataGridViewTextBoxColumn.Name = "단위DataGridViewTextBoxColumn";
            // 
            // 수량DataGridViewTextBoxColumn
            // 
            this.수량DataGridViewTextBoxColumn.DataPropertyName = "수량";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0";
            this.수량DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.수량DataGridViewTextBoxColumn.HeaderText = "수량";
            this.수량DataGridViewTextBoxColumn.Name = "수량DataGridViewTextBoxColumn";
            // 
            // 수주번호DataGridViewTextBoxColumn1
            // 
            this.수주번호DataGridViewTextBoxColumn1.DataPropertyName = "수주번호";
            this.수주번호DataGridViewTextBoxColumn1.HeaderText = "수주번호";
            this.수주번호DataGridViewTextBoxColumn1.Name = "수주번호DataGridViewTextBoxColumn1";
            this.수주번호DataGridViewTextBoxColumn1.Visible = false;
            // 
            // 수주순번DataGridViewTextBoxColumn
            // 
            this.수주순번DataGridViewTextBoxColumn.DataPropertyName = "수주순번";
            this.수주순번DataGridViewTextBoxColumn.HeaderText = "수주순번";
            this.수주순번DataGridViewTextBoxColumn.Name = "수주순번DataGridViewTextBoxColumn";
            this.수주순번DataGridViewTextBoxColumn.Visible = false;
            // 
            // 비고DataGridViewTextBoxColumn
            // 
            this.비고DataGridViewTextBoxColumn.DataPropertyName = "비고";
            this.비고DataGridViewTextBoxColumn.FillWeight = 150F;
            this.비고DataGridViewTextBoxColumn.HeaderText = "비고";
            this.비고DataGridViewTextBoxColumn.Name = "비고DataGridViewTextBoxColumn";
            // 
            // ColumnDel
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "X";
            this.ColumnDel.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnDel.FillWeight = 20F;
            this.ColumnDel.HeaderText = "";
            this.ColumnDel.Name = "ColumnDel";
            this.ColumnDel.Text = "X";
            this.ColumnDel.Visible = false;
            // 
            // sPDeliorderSubQueryBindingSource
            // 
            this.sPDeliorderSubQueryBindingSource.DataMember = "SP_Deliorder_Sub_Query";
            this.sPDeliorderSubQueryBindingSource.DataSource = this.dataSetP1B;
            // 
            // dataSetP1B
            // 
            this.dataSetP1B.DataSetName = "DataSetP1B";
            this.dataSetP1B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Location = new System.Drawing.Point(2, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 71);
            this.panel1.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(31, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(237, 29);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // panSearch
            // 
            this.panSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearch.AutoSize = true;
            this.panSearch.BackColor = System.Drawing.SystemColors.Info;
            this.panSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSearch.Controls.Add(this.tbRorder);
            this.panSearch.Controls.Add(this.label3);
            this.panSearch.Controls.Add(this.cbDeliCar);
            this.panSearch.Controls.Add(this.label6);
            this.panSearch.Controls.Add(this.tbContents);
            this.panSearch.Controls.Add(this.tbPlace);
            this.panSearch.Controls.Add(this.tbCust);
            this.panSearch.Controls.Add(this.dtpDate);
            this.panSearch.Controls.Add(this.tbNo);
            this.panSearch.Controls.Add(this.label10);
            this.panSearch.Controls.Add(this.label7);
            this.panSearch.Controls.Add(this.lblCust);
            this.panSearch.Controls.Add(this.tbDeliInfo);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Controls.Add(this.cbNo);
            this.panSearch.Location = new System.Drawing.Point(310, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1011, 184);
            this.panSearch.TabIndex = 0;
            // 
            // tbRorder
            // 
            this.tbRorder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbRorder.Location = new System.Drawing.Point(460, 15);
            this.tbRorder.Name = "tbRorder";
            this.tbRorder.ReadOnly = true;
            this.tbRorder.Size = new System.Drawing.Size(211, 29);
            this.tbRorder.TabIndex = 16;
            this.tbRorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(383, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "수주번호";
            // 
            // cbDeliCar
            // 
            this.cbDeliCar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDeliCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeliCar.FormattingEnabled = true;
            this.cbDeliCar.Items.AddRange(new object[] {
            "1.용차",
            "2.택배",
            "3.직납",
            "4.자차",
            "5.퀵",
            "9.기타"});
            this.cbDeliCar.Location = new System.Drawing.Point(460, 95);
            this.cbDeliCar.Name = "cbDeliCar";
            this.cbDeliCar.Size = new System.Drawing.Size(211, 29);
            this.cbDeliCar.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(54, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "현장정보";
            // 
            // tbContents
            // 
            this.tbContents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbContents.Location = new System.Drawing.Point(145, 135);
            this.tbContents.Name = "tbContents";
            this.tbContents.Size = new System.Drawing.Size(526, 29);
            this.tbContents.TabIndex = 12;
            this.tbContents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbPlace
            // 
            this.tbPlace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPlace.Location = new System.Drawing.Point(145, 95);
            this.tbPlace.Name = "tbPlace";
            this.tbPlace.Size = new System.Drawing.Size(211, 29);
            this.tbPlace.TabIndex = 8;
            this.tbPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPlace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbCust
            // 
            this.tbCust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCust.Location = new System.Drawing.Point(460, 55);
            this.tbCust.Name = "tbCust";
            this.tbCust.ReadOnly = true;
            this.tbCust.Size = new System.Drawing.Size(211, 29);
            this.tbCust.TabIndex = 6;
            this.tbCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Location = new System.Drawing.Point(145, 55);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(211, 29);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // tbNo
            // 
            this.tbNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNo.Location = new System.Drawing.Point(145, 16);
            this.tbNo.Name = "tbNo";
            this.tbNo.ReadOnly = true;
            this.tbNo.Size = new System.Drawing.Size(211, 29);
            this.tbNo.TabIndex = 4;
            this.tbNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nextFocus_KeyDown);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(54, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "비  고";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(383, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "배송수단";
            // 
            // lblCust
            // 
            this.lblCust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCust.AutoSize = true;
            this.lblCust.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCust.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCust.Location = new System.Drawing.Point(383, 59);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(74, 21);
            this.lblCust.TabIndex = 0;
            this.lblCust.Text = "거래처명";
            this.lblCust.Click += new System.EventHandler(this.lblCust_Click);
            // 
            // tbDeliInfo
            // 
            this.tbDeliInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDeliInfo.Location = new System.Drawing.Point(693, 56);
            this.tbDeliInfo.Multiline = true;
            this.tbDeliInfo.Name = "tbDeliInfo";
            this.tbDeliInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDeliInfo.Size = new System.Drawing.Size(264, 108);
            this.tbDeliInfo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(695, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "배송정보";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(54, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "요청일자";
            // 
            // cbNo
            // 
            this.cbNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNo.AutoSize = true;
            this.cbNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbNo.Location = new System.Drawing.Point(39, 18);
            this.cbNo.Name = "cbNo";
            this.cbNo.Size = new System.Drawing.Size(93, 25);
            this.cbNo.TabIndex = 3;
            this.cbNo.Text = "지시번호";
            this.cbNo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewList.AutoGenerateColumns = false;
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewList.ColumnHeadersHeight = 35;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.지시번호DataGridViewTextBoxColumn,
            this.수주번호DataGridViewTextBoxColumn,
            this.출하지시일자DataGridViewTextBoxColumn,
            this.거래처IDDataGridViewTextBoxColumn,
            this.거래처명DataGridViewTextBoxColumn,
            this.현장정보DataGridViewTextBoxColumn,
            this.배송수단DataGridViewTextBoxColumn,
            this.요청일자DataGridViewTextBoxColumn,
            this.등록일시DataGridViewTextBoxColumn,
            this.등록자DataGridViewTextBoxColumn});
            this.dataGridViewList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridViewList.DataSource = this.sPDeliorderMainQueryBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewList.EnableHeadersVisualStyles = false;
            this.dataGridViewList.Location = new System.Drawing.Point(2, 132);
            this.dataGridViewList.MultiSelect = false;
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.RowHeadersWidth = 35;
            this.dataGridViewList.RowTemplate.Height = 35;
            this.dataGridViewList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(302, 851);
            this.dataGridViewList.TabIndex = 2;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            // 
            // 지시번호DataGridViewTextBoxColumn
            // 
            this.지시번호DataGridViewTextBoxColumn.DataPropertyName = "지시번호";
            this.지시번호DataGridViewTextBoxColumn.HeaderText = "지시번호";
            this.지시번호DataGridViewTextBoxColumn.Name = "지시번호DataGridViewTextBoxColumn";
            this.지시번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.지시번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 수주번호DataGridViewTextBoxColumn
            // 
            this.수주번호DataGridViewTextBoxColumn.DataPropertyName = "수주번호";
            this.수주번호DataGridViewTextBoxColumn.HeaderText = "수주번호";
            this.수주번호DataGridViewTextBoxColumn.Name = "수주번호DataGridViewTextBoxColumn";
            this.수주번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.수주번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 출하지시일자DataGridViewTextBoxColumn
            // 
            this.출하지시일자DataGridViewTextBoxColumn.DataPropertyName = "출하지시일자";
            dataGridViewCellStyle9.Format = "MM\\/dd";
            this.출하지시일자DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.출하지시일자DataGridViewTextBoxColumn.FillWeight = 45F;
            this.출하지시일자DataGridViewTextBoxColumn.HeaderText = "지시";
            this.출하지시일자DataGridViewTextBoxColumn.Name = "출하지시일자DataGridViewTextBoxColumn";
            this.출하지시일자DataGridViewTextBoxColumn.ReadOnly = true;
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
            this.거래처명DataGridViewTextBoxColumn.HeaderText = "거래처명";
            this.거래처명DataGridViewTextBoxColumn.Name = "거래처명DataGridViewTextBoxColumn";
            this.거래처명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 현장정보DataGridViewTextBoxColumn
            // 
            this.현장정보DataGridViewTextBoxColumn.DataPropertyName = "현장정보";
            this.현장정보DataGridViewTextBoxColumn.HeaderText = "현장정보";
            this.현장정보DataGridViewTextBoxColumn.Name = "현장정보DataGridViewTextBoxColumn";
            this.현장정보DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 배송수단DataGridViewTextBoxColumn
            // 
            this.배송수단DataGridViewTextBoxColumn.DataPropertyName = "배송수단";
            this.배송수단DataGridViewTextBoxColumn.HeaderText = "배송수단";
            this.배송수단DataGridViewTextBoxColumn.Name = "배송수단DataGridViewTextBoxColumn";
            this.배송수단DataGridViewTextBoxColumn.ReadOnly = true;
            this.배송수단DataGridViewTextBoxColumn.Visible = false;
            // 
            // 요청일자DataGridViewTextBoxColumn
            // 
            this.요청일자DataGridViewTextBoxColumn.DataPropertyName = "요청일자";
            this.요청일자DataGridViewTextBoxColumn.HeaderText = "요청일자";
            this.요청일자DataGridViewTextBoxColumn.Name = "요청일자DataGridViewTextBoxColumn";
            this.요청일자DataGridViewTextBoxColumn.ReadOnly = true;
            this.요청일자DataGridViewTextBoxColumn.Visible = false;
            // 
            // 등록일시DataGridViewTextBoxColumn
            // 
            this.등록일시DataGridViewTextBoxColumn.DataPropertyName = "등록일시";
            this.등록일시DataGridViewTextBoxColumn.HeaderText = "등록일시";
            this.등록일시DataGridViewTextBoxColumn.Name = "등록일시DataGridViewTextBoxColumn";
            this.등록일시DataGridViewTextBoxColumn.ReadOnly = true;
            this.등록일시DataGridViewTextBoxColumn.Visible = false;
            // 
            // 등록자DataGridViewTextBoxColumn
            // 
            this.등록자DataGridViewTextBoxColumn.DataPropertyName = "등록자";
            this.등록자DataGridViewTextBoxColumn.HeaderText = "등록자";
            this.등록자DataGridViewTextBoxColumn.Name = "등록자DataGridViewTextBoxColumn";
            this.등록자DataGridViewTextBoxColumn.ReadOnly = true;
            this.등록자DataGridViewTextBoxColumn.Visible = false;
            // 
            // sPDeliorderMainQueryBindingSource
            // 
            this.sPDeliorderMainQueryBindingSource.DataMember = "SP_Deliorder_Main_Query";
            this.sPDeliorderMainQueryBindingSource.DataSource = this.dataSetP1B;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblMsg);
            this.panel2.Controls.Add(this.lblCnt);
            this.panel2.Location = new System.Drawing.Point(310, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 38);
            this.panel2.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(7, 9);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // lblCnt
            // 
            this.lblCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCnt.AutoSize = true;
            this.lblCnt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCnt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCnt.Location = new System.Drawing.Point(920, 9);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(35, 21);
            this.lblCnt.TabIndex = 0;
            this.lblCnt.Text = "0건";
            // 
            // sP_Z_Common_IDTableAdapter
            // 
            this.sP_Z_Common_IDTableAdapter.ClearBeforeFill = true;
            // 
            // sP_Deliorder_Main_QueryTableAdapter
            // 
            this.sP_Deliorder_Main_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // sP_Deliorder_Sub_QueryTableAdapter
            // 
            this.sP_Deliorder_Sub_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1B07_DELI_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.panSearch);
            this.Controls.Add(this.panel1);
            this.Name = "P1B07_DELI_ORDER";
            this.Tag = "";
            this.Text = "P1B07_DELI_ORDER";
            this.Load += new System.EventHandler(this.P1B07_DELI_ORDER_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panSearch, 0);
            this.Controls.SetChildIndex(this.dataGridViewList, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDeliorderSubQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPZCommonIDBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDeliorderMainQueryBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panSearch;
        public System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.TextBox tbDeliInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNo;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDeliCar;
        private System.Windows.Forms.BindingSource sPZCommonIDBindingSource;
        private P1B.DataSetP1BTableAdapters.SP_Z_Common_IDTableAdapter sP_Z_Common_IDTableAdapter;
        public System.Windows.Forms.TextBox tbPlace;
        public System.Windows.Forms.TextBox tbCust;
        private P1B.DataSetP1B dataSetP1B;
        private System.Windows.Forms.BindingSource sPDeliorderMainQueryBindingSource;
        private P1B.DataSetP1BTableAdapters.SP_Deliorder_Main_QueryTableAdapter sP_Deliorder_Main_QueryTableAdapter;
        private P1B.DataSetP1BTableAdapters.SP_Deliorder_Sub_QueryTableAdapter sP_Deliorder_Sub_QueryTableAdapter;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbRorder;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.BindingSource sPDeliorderSubQueryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 지시번호DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 지시순번DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단위DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주번호DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주순번DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDel;
        public System.Windows.Forms.TextBox tbContents;
        private System.Windows.Forms.DataGridViewTextBoxColumn 지시번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 수주번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 출하지시일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 현장정보DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 배송수단DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 요청일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등록일시DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 등록자DataGridViewTextBoxColumn;
    }
}

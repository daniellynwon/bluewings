namespace SmartMES_Bluewings
{
    partial class P1ED01_QC_FINAL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.외관DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관벽두께1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관벽두께2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관벽두께3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.최소내벽1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.최소내벽2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.최소내벽3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.안지름1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.안지름2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.안지름3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.길이1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.길이2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.길이3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.판정DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPQcQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1E = new SmartMES_Bluewings.P1E.DataSetP1E();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCust = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpJobDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panSearch = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStd4 = new System.Windows.Forms.Label();
            this.lblStd3 = new System.Windows.Forms.Label();
            this.lblStd2 = new System.Windows.Forms.Label();
            this.lblStd1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cbQcMan = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.JobNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.생산일자 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비코드 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업조 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상태 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPQcFinalROderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPQcFinalQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_QcFinal_QueryTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_QcFinal_QueryTableAdapter();
            this.sP_QcFinal_ROderTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_QcFinal_ROderTableAdapter();
            this.sPQcFinalPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_QcFinal_PrintTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_QcFinal_PrintTableAdapter();
            this.sP_Qc_QueryTableAdapter = new SmartMES_Bluewings.P1E.DataSetP1ETableAdapters.SP_Qc_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).BeginInit();
            this.panel1.SuspendLayout();
            this.panSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalROderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalPrintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "검사결과등록";
            // 
            // pbPrint
            // 
            this.pbPrint.Enabled = true;
            this.pbPrint.Image = global::SmartMES_Bluewings.Properties.Resources.out_A;
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
            this.pbAdd.Image = global::SmartMES_Bluewings.Properties.Resources.add_A;
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
            this.jobNoDataGridViewTextBoxColumn,
            this.설비코드DataGridViewTextBoxColumn,
            this.설비명DataGridViewTextBoxColumn,
            this.품목코드DataGridViewTextBoxColumn1,
            this.품목명DataGridViewTextBoxColumn1,
            this.외관DataGridViewTextBoxColumn,
            this.관벽두께1DataGridViewTextBoxColumn,
            this.관벽두께2DataGridViewTextBoxColumn,
            this.관벽두께3DataGridViewTextBoxColumn,
            this.최소내벽1DataGridViewTextBoxColumn,
            this.최소내벽2DataGridViewTextBoxColumn,
            this.최소내벽3DataGridViewTextBoxColumn,
            this.안지름1DataGridViewTextBoxColumn,
            this.안지름2DataGridViewTextBoxColumn,
            this.안지름3DataGridViewTextBoxColumn,
            this.길이1DataGridViewTextBoxColumn,
            this.길이2DataGridViewTextBoxColumn,
            this.길이3DataGridViewTextBoxColumn,
            this.판정DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPQcQueryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(497, 394);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(824, 591);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // jobNoDataGridViewTextBoxColumn
            // 
            this.jobNoDataGridViewTextBoxColumn.DataPropertyName = "jobNo";
            this.jobNoDataGridViewTextBoxColumn.HeaderText = "jobNo";
            this.jobNoDataGridViewTextBoxColumn.Name = "jobNoDataGridViewTextBoxColumn";
            this.jobNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // 설비코드DataGridViewTextBoxColumn
            // 
            this.설비코드DataGridViewTextBoxColumn.DataPropertyName = "설비코드";
            this.설비코드DataGridViewTextBoxColumn.HeaderText = "설비코드";
            this.설비코드DataGridViewTextBoxColumn.Name = "설비코드DataGridViewTextBoxColumn";
            this.설비코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 설비명DataGridViewTextBoxColumn
            // 
            this.설비명DataGridViewTextBoxColumn.DataPropertyName = "설비명";
            this.설비명DataGridViewTextBoxColumn.HeaderText = "설비명";
            this.설비명DataGridViewTextBoxColumn.Name = "설비명DataGridViewTextBoxColumn";
            this.설비명DataGridViewTextBoxColumn.Visible = false;
            // 
            // 품목코드DataGridViewTextBoxColumn1
            // 
            this.품목코드DataGridViewTextBoxColumn1.DataPropertyName = "품목코드";
            this.품목코드DataGridViewTextBoxColumn1.HeaderText = "품목코드";
            this.품목코드DataGridViewTextBoxColumn1.Name = "품목코드DataGridViewTextBoxColumn1";
            this.품목코드DataGridViewTextBoxColumn1.Visible = false;
            // 
            // 품목명DataGridViewTextBoxColumn1
            // 
            this.품목명DataGridViewTextBoxColumn1.DataPropertyName = "품목명";
            this.품목명DataGridViewTextBoxColumn1.HeaderText = "품목명";
            this.품목명DataGridViewTextBoxColumn1.Name = "품목명DataGridViewTextBoxColumn1";
            this.품목명DataGridViewTextBoxColumn1.Visible = false;
            // 
            // 외관DataGridViewTextBoxColumn
            // 
            this.외관DataGridViewTextBoxColumn.DataPropertyName = "외관";
            this.외관DataGridViewTextBoxColumn.FillWeight = 50F;
            this.외관DataGridViewTextBoxColumn.HeaderText = "외관";
            this.외관DataGridViewTextBoxColumn.Name = "외관DataGridViewTextBoxColumn";
            this.외관DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 관벽두께1DataGridViewTextBoxColumn
            // 
            this.관벽두께1DataGridViewTextBoxColumn.DataPropertyName = "관벽두께1";
            this.관벽두께1DataGridViewTextBoxColumn.FillWeight = 50F;
            this.관벽두께1DataGridViewTextBoxColumn.HeaderText = "n1";
            this.관벽두께1DataGridViewTextBoxColumn.Name = "관벽두께1DataGridViewTextBoxColumn";
            // 
            // 관벽두께2DataGridViewTextBoxColumn
            // 
            this.관벽두께2DataGridViewTextBoxColumn.DataPropertyName = "관벽두께2";
            this.관벽두께2DataGridViewTextBoxColumn.FillWeight = 50F;
            this.관벽두께2DataGridViewTextBoxColumn.HeaderText = "n2";
            this.관벽두께2DataGridViewTextBoxColumn.Name = "관벽두께2DataGridViewTextBoxColumn";
            // 
            // 관벽두께3DataGridViewTextBoxColumn
            // 
            this.관벽두께3DataGridViewTextBoxColumn.DataPropertyName = "관벽두께3";
            this.관벽두께3DataGridViewTextBoxColumn.FillWeight = 50F;
            this.관벽두께3DataGridViewTextBoxColumn.HeaderText = "n3";
            this.관벽두께3DataGridViewTextBoxColumn.Name = "관벽두께3DataGridViewTextBoxColumn";
            // 
            // 최소내벽1DataGridViewTextBoxColumn
            // 
            this.최소내벽1DataGridViewTextBoxColumn.DataPropertyName = "최소내벽1";
            this.최소내벽1DataGridViewTextBoxColumn.FillWeight = 50F;
            this.최소내벽1DataGridViewTextBoxColumn.HeaderText = "n1";
            this.최소내벽1DataGridViewTextBoxColumn.Name = "최소내벽1DataGridViewTextBoxColumn";
            // 
            // 최소내벽2DataGridViewTextBoxColumn
            // 
            this.최소내벽2DataGridViewTextBoxColumn.DataPropertyName = "최소내벽2";
            this.최소내벽2DataGridViewTextBoxColumn.FillWeight = 50F;
            this.최소내벽2DataGridViewTextBoxColumn.HeaderText = "n2";
            this.최소내벽2DataGridViewTextBoxColumn.Name = "최소내벽2DataGridViewTextBoxColumn";
            // 
            // 최소내벽3DataGridViewTextBoxColumn
            // 
            this.최소내벽3DataGridViewTextBoxColumn.DataPropertyName = "최소내벽3";
            this.최소내벽3DataGridViewTextBoxColumn.FillWeight = 50F;
            this.최소내벽3DataGridViewTextBoxColumn.HeaderText = "n3";
            this.최소내벽3DataGridViewTextBoxColumn.Name = "최소내벽3DataGridViewTextBoxColumn";
            // 
            // 안지름1DataGridViewTextBoxColumn
            // 
            this.안지름1DataGridViewTextBoxColumn.DataPropertyName = "안지름1";
            this.안지름1DataGridViewTextBoxColumn.FillWeight = 50F;
            this.안지름1DataGridViewTextBoxColumn.HeaderText = "n1";
            this.안지름1DataGridViewTextBoxColumn.Name = "안지름1DataGridViewTextBoxColumn";
            // 
            // 안지름2DataGridViewTextBoxColumn
            // 
            this.안지름2DataGridViewTextBoxColumn.DataPropertyName = "안지름2";
            this.안지름2DataGridViewTextBoxColumn.FillWeight = 50F;
            this.안지름2DataGridViewTextBoxColumn.HeaderText = "n2";
            this.안지름2DataGridViewTextBoxColumn.Name = "안지름2DataGridViewTextBoxColumn";
            // 
            // 안지름3DataGridViewTextBoxColumn
            // 
            this.안지름3DataGridViewTextBoxColumn.DataPropertyName = "안지름3";
            this.안지름3DataGridViewTextBoxColumn.FillWeight = 50F;
            this.안지름3DataGridViewTextBoxColumn.HeaderText = "n3";
            this.안지름3DataGridViewTextBoxColumn.Name = "안지름3DataGridViewTextBoxColumn";
            // 
            // 길이1DataGridViewTextBoxColumn
            // 
            this.길이1DataGridViewTextBoxColumn.DataPropertyName = "길이1";
            this.길이1DataGridViewTextBoxColumn.FillWeight = 50F;
            this.길이1DataGridViewTextBoxColumn.HeaderText = "n1";
            this.길이1DataGridViewTextBoxColumn.Name = "길이1DataGridViewTextBoxColumn";
            // 
            // 길이2DataGridViewTextBoxColumn
            // 
            this.길이2DataGridViewTextBoxColumn.DataPropertyName = "길이2";
            this.길이2DataGridViewTextBoxColumn.FillWeight = 50F;
            this.길이2DataGridViewTextBoxColumn.HeaderText = "n2";
            this.길이2DataGridViewTextBoxColumn.Name = "길이2DataGridViewTextBoxColumn";
            // 
            // 길이3DataGridViewTextBoxColumn
            // 
            this.길이3DataGridViewTextBoxColumn.DataPropertyName = "길이3";
            this.길이3DataGridViewTextBoxColumn.FillWeight = 50F;
            this.길이3DataGridViewTextBoxColumn.HeaderText = "n3";
            this.길이3DataGridViewTextBoxColumn.Name = "길이3DataGridViewTextBoxColumn";
            // 
            // 판정DataGridViewTextBoxColumn
            // 
            this.판정DataGridViewTextBoxColumn.DataPropertyName = "판정";
            this.판정DataGridViewTextBoxColumn.FillWeight = 50F;
            this.판정DataGridViewTextBoxColumn.HeaderText = "판정";
            this.판정DataGridViewTextBoxColumn.Name = "판정DataGridViewTextBoxColumn";
            this.판정DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPQcQueryBindingSource
            // 
            this.sPQcQueryBindingSource.DataMember = "SP_Qc_Query";
            this.sPQcQueryBindingSource.DataSource = this.dataSetP1E;
            // 
            // dataSetP1E
            // 
            this.dataSetP1E.DataSetName = "DataSetP1E";
            this.dataSetP1E.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbProd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbCust);
            this.panel1.Controls.Add(this.dtpToDate);
            this.panel1.Controls.Add(this.dtpJobDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 105);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(24, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "거래처명";
            this.label5.Visible = false;
            // 
            // tbProd
            // 
            this.tbProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbProd.BackColor = System.Drawing.SystemColors.Window;
            this.tbProd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbProd.Location = new System.Drawing.Point(258, 67);
            this.tbProd.Name = "tbProd";
            this.tbProd.Size = new System.Drawing.Size(207, 29);
            this.tbProd.TabIndex = 4;
            this.tbProd.Visible = false;
            this.tbProd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(258, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "품목명";
            this.label6.Visible = false;
            // 
            // tbCust
            // 
            this.tbCust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCust.BackColor = System.Drawing.SystemColors.Window;
            this.tbCust.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbCust.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCust.Location = new System.Drawing.Point(24, 67);
            this.tbCust.Name = "tbCust";
            this.tbCust.Size = new System.Drawing.Size(207, 29);
            this.tbCust.TabIndex = 3;
            this.tbCust.Visible = false;
            this.tbCust.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpToDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpToDate.Location = new System.Drawing.Point(258, 14);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(207, 29);
            this.dtpToDate.TabIndex = 2;
            this.dtpToDate.Visible = false;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dtpJobDate
            // 
            this.dtpJobDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpJobDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpJobDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpJobDate.Location = new System.Drawing.Point(24, 14);
            this.dtpJobDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpJobDate.Name = "dtpJobDate";
            this.dtpJobDate.Size = new System.Drawing.Size(207, 29);
            this.dtpJobDate.TabIndex = 1;
            this.dtpJobDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(234, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "~";
            this.label3.Visible = false;
            // 
            // panSearch
            // 
            this.panSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSearch.AutoSize = true;
            this.panSearch.BackColor = System.Drawing.SystemColors.Info;
            this.panSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSearch.Controls.Add(this.groupBox1);
            this.panSearch.Controls.Add(this.lblMsg);
            this.panSearch.Controls.Add(this.cbQcMan);
            this.panSearch.Controls.Add(this.dtpDate);
            this.panSearch.Controls.Add(this.label7);
            this.panSearch.Controls.Add(this.tbContents);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Location = new System.Drawing.Point(497, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(824, 330);
            this.panSearch.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStd4);
            this.groupBox1.Controls.Add(this.lblStd3);
            this.groupBox1.Controls.Add(this.lblStd2);
            this.groupBox1.Controls.Add(this.lblStd1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(16, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 202);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기준값";
            // 
            // lblStd4
            // 
            this.lblStd4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStd4.AutoSize = true;
            this.lblStd4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStd4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStd4.Location = new System.Drawing.Point(146, 153);
            this.lblStd4.Name = "lblStd4";
            this.lblStd4.Size = new System.Drawing.Size(17, 21);
            this.lblStd4.TabIndex = 8;
            this.lblStd4.Text = "-";
            // 
            // lblStd3
            // 
            this.lblStd3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStd3.AutoSize = true;
            this.lblStd3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStd3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStd3.Location = new System.Drawing.Point(146, 113);
            this.lblStd3.Name = "lblStd3";
            this.lblStd3.Size = new System.Drawing.Size(17, 21);
            this.lblStd3.TabIndex = 7;
            this.lblStd3.Text = "-";
            // 
            // lblStd2
            // 
            this.lblStd2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStd2.AutoSize = true;
            this.lblStd2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStd2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStd2.Location = new System.Drawing.Point(146, 73);
            this.lblStd2.Name = "lblStd2";
            this.lblStd2.Size = new System.Drawing.Size(17, 21);
            this.lblStd2.TabIndex = 6;
            this.lblStd2.Text = "-";
            // 
            // lblStd1
            // 
            this.lblStd1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStd1.AutoSize = true;
            this.lblStd1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStd1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStd1.Location = new System.Drawing.Point(146, 34);
            this.lblStd1.Name = "lblStd1";
            this.lblStd1.Size = new System.Drawing.Size(17, 21);
            this.lblStd1.TabIndex = 5;
            this.lblStd1.Text = "-";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(17, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "제품길이";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(17, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "평균안지름";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(17, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "최소내벽두께";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "관벽두께";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(12, 81);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // cbQcMan
            // 
            this.cbQcMan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbQcMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQcMan.FormattingEnabled = true;
            this.cbQcMan.Location = new System.Drawing.Point(166, 56);
            this.cbQcMan.Name = "cbQcMan";
            this.cbQcMan.Size = new System.Drawing.Size(211, 29);
            this.cbQcMan.TabIndex = 12;
            this.cbQcMan.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDate.CalendarFont = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpDate.Location = new System.Drawing.Point(166, 10);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(211, 29);
            this.dtpDate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(88, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "검 사 원";
            // 
            // tbContents
            // 
            this.tbContents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbContents.Location = new System.Drawing.Point(480, 10);
            this.tbContents.Multiline = true;
            this.tbContents.Name = "tbContents";
            this.tbContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContents.Size = new System.Drawing.Size(231, 75);
            this.tbContents.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(425, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "의 견";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(88, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "검사일자";
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.AllowUserToAddRows = false;
            this.dataGridViewList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewList.AutoGenerateColumns = false;
            this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewList.ColumnHeadersHeight = 35;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobNo,
            this.생산일자,
            this.설비코드,
            this.설비명,
            this.작업조,
            this.품목코드DataGridViewTextBoxColumn,
            this.품목명DataGridViewTextBoxColumn,
            this.상태});
            this.dataGridViewList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridViewList.DataSource = this.sPQcFinalROderBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewList.EnableHeadersVisualStyles = false;
            this.dataGridViewList.Location = new System.Drawing.Point(2, 169);
            this.dataGridViewList.MultiSelect = false;
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewList.RowHeadersVisible = false;
            this.dataGridViewList.RowHeadersWidth = 35;
            this.dataGridViewList.RowTemplate.Height = 35;
            this.dataGridViewList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewList.Size = new System.Drawing.Size(489, 816);
            this.dataGridViewList.TabIndex = 10;
            this.dataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewList_CellClick);
            // 
            // JobNo
            // 
            this.JobNo.DataPropertyName = "JobNo";
            this.JobNo.HeaderText = "JobNo";
            this.JobNo.Name = "JobNo";
            this.JobNo.ReadOnly = true;
            // 
            // 생산일자
            // 
            this.생산일자.DataPropertyName = "생산일자";
            this.생산일자.HeaderText = "생산일자";
            this.생산일자.Name = "생산일자";
            this.생산일자.ReadOnly = true;
            this.생산일자.Visible = false;
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
            // 작업조
            // 
            this.작업조.DataPropertyName = "작업조";
            this.작업조.FillWeight = 50F;
            this.작업조.HeaderText = "작업조";
            this.작업조.Name = "작업조";
            this.작업조.ReadOnly = true;
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
            // 상태
            // 
            this.상태.DataPropertyName = "상태";
            this.상태.FillWeight = 40F;
            this.상태.HeaderText = "상태";
            this.상태.Name = "상태";
            this.상태.ReadOnly = true;
            // 
            // sPQcFinalROderBindingSource
            // 
            this.sPQcFinalROderBindingSource.DataMember = "SP_QcFinal_ROder";
            this.sPQcFinalROderBindingSource.DataSource = this.dataSetP1E;
            // 
            // sPQcFinalQueryBindingSource
            // 
            this.sPQcFinalQueryBindingSource.DataMember = "SP_QcFinal_Query";
            this.sPQcFinalQueryBindingSource.DataSource = this.dataSetP1E;
            // 
            // sP_QcFinal_QueryTableAdapter
            // 
            this.sP_QcFinal_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // sP_QcFinal_ROderTableAdapter
            // 
            this.sP_QcFinal_ROderTableAdapter.ClearBeforeFill = true;
            // 
            // sPQcFinalPrintBindingSource
            // 
            this.sPQcFinalPrintBindingSource.DataMember = "SP_QcFinal_Print";
            this.sPQcFinalPrintBindingSource.DataSource = this.dataSetP1E;
            // 
            // sP_QcFinal_PrintTableAdapter
            // 
            this.sP_QcFinal_PrintTableAdapter.ClearBeforeFill = true;
            // 
            // sP_Qc_QueryTableAdapter
            // 
            this.sP_Qc_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1ED01_QC_FINAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.panSearch);
            this.Controls.Add(this.panel1);
            this.Name = "P1ED01_QC_FINAL";
            this.Tag = "";
            this.Text = "P1ED01_QC_FINAL";
            this.Load += new System.EventHandler(this.P1ED01_QC_FINAL_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panSearch, 0);
            this.Controls.SetChildIndex(this.dataGridViewList, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1E)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalROderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQcFinalPrintBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panSearch;
        public System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbContents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.BindingSource sPQcFinalQueryBindingSource;
        private P1E.DataSetP1E dataSetP1E;
        private System.Windows.Forms.BindingSource sPQcFinalROderBindingSource;
        private P1E.DataSetP1ETableAdapters.SP_QcFinal_QueryTableAdapter sP_QcFinal_QueryTableAdapter;
        private P1E.DataSetP1ETableAdapters.SP_QcFinal_ROderTableAdapter sP_QcFinal_ROderTableAdapter;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpToDate;
        public System.Windows.Forms.DateTimePicker dtpJobDate;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbCust;
        public System.Windows.Forms.ComboBox cbQcMan;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.BindingSource sPQcFinalPrintBindingSource;
        private P1E.DataSetP1ETableAdapters.SP_QcFinal_PrintTableAdapter sP_QcFinal_PrintTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산일자;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비코드;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업조;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상태;
        private System.Windows.Forms.BindingSource sPQcQueryBindingSource;
        private P1E.DataSetP1ETableAdapters.SP_Qc_QueryTableAdapter sP_Qc_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목코드DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 외관DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관벽두께1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관벽두께2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관벽두께3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 최소내벽1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 최소내벽2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 최소내벽3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 안지름1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 안지름2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 안지름3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 길이1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 길이2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 길이3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 판정DataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStd4;
        private System.Windows.Forms.Label lblStd3;
        private System.Windows.Forms.Label lblStd2;
        private System.Windows.Forms.Label lblStd1;
    }
}

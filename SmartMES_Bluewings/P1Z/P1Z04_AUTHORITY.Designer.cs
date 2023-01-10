namespace SmartMES_Bluewings
{
    partial class P1Z04_AUTHORITY
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.사용자IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용자명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.담당업무DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPUserQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1Z = new SmartMES_Bluewings.P1Z.DataSetP1Z();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.사용DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.메뉴IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.메뉴명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPMenuAuthorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_User_QueryTableAdapter = new SmartMES_Bluewings.P1Z.DataSetP1ZTableAdapters.SP_User_QueryTableAdapter();
            this.sP_Menu_AuthorityTableAdapter = new SmartMES_Bluewings.P1Z.DataSetP1ZTableAdapters.SP_Menu_AuthorityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPUserQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1Z)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMenuAuthorityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "권한정보";
            // 
            // pbPrint
            // 
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
            this.panSearch.AutoSize = true;
            this.panSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(576, 71);
            this.panSearch.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(222, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(293, 29);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자명 / 담당업무";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.사용자IDDataGridViewTextBoxColumn,
            this.사용자명DataGridViewTextBoxColumn,
            this.담당업무DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPUserQueryBindingSource;
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
            this.dataGridView1.Size = new System.Drawing.Size(576, 852);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 사용자IDDataGridViewTextBoxColumn
            // 
            this.사용자IDDataGridViewTextBoxColumn.DataPropertyName = "사용자ID";
            this.사용자IDDataGridViewTextBoxColumn.HeaderText = "사용자ID";
            this.사용자IDDataGridViewTextBoxColumn.Name = "사용자IDDataGridViewTextBoxColumn";
            this.사용자IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.사용자IDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 사용자명DataGridViewTextBoxColumn
            // 
            this.사용자명DataGridViewTextBoxColumn.DataPropertyName = "사용자명";
            this.사용자명DataGridViewTextBoxColumn.HeaderText = "사용자명";
            this.사용자명DataGridViewTextBoxColumn.Name = "사용자명DataGridViewTextBoxColumn";
            this.사용자명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 담당업무DataGridViewTextBoxColumn
            // 
            this.담당업무DataGridViewTextBoxColumn.DataPropertyName = "담당업무";
            this.담당업무DataGridViewTextBoxColumn.FillWeight = 150F;
            this.담당업무DataGridViewTextBoxColumn.HeaderText = "담당업무";
            this.담당업무DataGridViewTextBoxColumn.Name = "담당업무DataGridViewTextBoxColumn";
            this.담당업무DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPUserQueryBindingSource
            // 
            this.sPUserQueryBindingSource.DataMember = "SP_User_Query";
            this.sPUserQueryBindingSource.DataSource = this.dataSetP1Z;
            // 
            // dataSetP1Z
            // 
            this.dataSetP1Z.DataSetName = "DataSetP1Z";
            this.dataSetP1Z.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAll);
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(584, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 71);
            this.panel1.TabIndex = 0;
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.BackColor = System.Drawing.Color.Transparent;
            this.lblAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAll.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAll.ForeColor = System.Drawing.Color.Blue;
            this.lblAll.Location = new System.Drawing.Point(2, 47);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(37, 21);
            this.lblAll.TabIndex = 0;
            this.lblAll.Text = "ALL";
            this.lblAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAll.Click += new System.EventHandler(this.lblAll_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(47, 46);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(148, 21);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "메시지 라벨입니다.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(387, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "사용자명 :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(106, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "사용자ID :";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(480, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(17, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "-";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(200, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(17, 21);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "-";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeight = 35;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.사용DataGridViewTextBoxColumn,
            this.메뉴IDDataGridViewTextBoxColumn,
            this.메뉴명DataGridViewTextBoxColumn,
            this.구분DataGridViewTextBoxColumn});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView2.DataSource = this.sPMenuAuthorityBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(584, 131);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 35;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(737, 852);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // 사용DataGridViewTextBoxColumn
            // 
            this.사용DataGridViewTextBoxColumn.DataPropertyName = "사용";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            this.사용DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.사용DataGridViewTextBoxColumn.FillWeight = 50F;
            this.사용DataGridViewTextBoxColumn.HeaderText = "사용";
            this.사용DataGridViewTextBoxColumn.Name = "사용DataGridViewTextBoxColumn";
            this.사용DataGridViewTextBoxColumn.ReadOnly = true;
            this.사용DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 메뉴IDDataGridViewTextBoxColumn
            // 
            this.메뉴IDDataGridViewTextBoxColumn.DataPropertyName = "메뉴ID";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.메뉴IDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.메뉴IDDataGridViewTextBoxColumn.HeaderText = "메뉴ID";
            this.메뉴IDDataGridViewTextBoxColumn.Name = "메뉴IDDataGridViewTextBoxColumn";
            this.메뉴IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.메뉴IDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.메뉴IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 메뉴명DataGridViewTextBoxColumn
            // 
            this.메뉴명DataGridViewTextBoxColumn.DataPropertyName = "메뉴명";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.메뉴명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.메뉴명DataGridViewTextBoxColumn.HeaderText = "메뉴명";
            this.메뉴명DataGridViewTextBoxColumn.Name = "메뉴명DataGridViewTextBoxColumn";
            this.메뉴명DataGridViewTextBoxColumn.ReadOnly = true;
            this.메뉴명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 구분DataGridViewTextBoxColumn
            // 
            this.구분DataGridViewTextBoxColumn.DataPropertyName = "구분";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.구분DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.구분DataGridViewTextBoxColumn.HeaderText = "구분";
            this.구분DataGridViewTextBoxColumn.Name = "구분DataGridViewTextBoxColumn";
            this.구분DataGridViewTextBoxColumn.ReadOnly = true;
            this.구분DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sPMenuAuthorityBindingSource
            // 
            this.sPMenuAuthorityBindingSource.DataMember = "SP_Menu_Authority";
            this.sPMenuAuthorityBindingSource.DataSource = this.dataSetP1Z;
            // 
            // sP_User_QueryTableAdapter
            // 
            this.sP_User_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // sP_Menu_AuthorityTableAdapter
            // 
            this.sP_Menu_AuthorityTableAdapter.ClearBeforeFill = true;
            // 
            // P1Z04_AUTHORITY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1Z04_AUTHORITY";
            this.Text = "P1Z04_AUTHORITY";
            this.Load += new System.EventHandler(this.P1Z04_AUTHORITY_Load);
            this.Controls.SetChildIndex(this.panSearch, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPUserQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1Z)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMenuAuthorityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sPUserQueryBindingSource;
        private P1Z.DataSetP1Z dataSetP1Z;
        private P1Z.DataSetP1ZTableAdapters.SP_User_QueryTableAdapter sP_User_QueryTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource sPMenuAuthorityBindingSource;
        private P1Z.DataSetP1ZTableAdapters.SP_Menu_AuthorityTableAdapter sP_Menu_AuthorityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용자IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용자명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 담당업무DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 메뉴IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 메뉴명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분DataGridViewTextBoxColumn;
    }
}

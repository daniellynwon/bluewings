namespace SmartMES_Bluewings
{
    partial class P1A02_PRODUCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1A02_PRODUCT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panSearch = new System.Windows.Forms.Panel();
            this.rbZ = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPProductQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1A = new SmartMES_Bluewings.P1A.DataSetP1A();
            this.sP_Product_QueryTableAdapter = new SmartMES_Bluewings.P1A.DataSetP1ATableAdapters.SP_Product_QueryTableAdapter();
            this.번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.분류코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.분류DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.품목명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모델명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.규격DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단위DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.단위1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조달단가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.민간단가 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.물품식별번호 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.재고대상DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.재고단가DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주압출기1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주압출기2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주압출기3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주압출기4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주압출기5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주압출기6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보조압출기1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보조압출기2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보조압출기3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보조압출기4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보조압출기5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.보조압출기6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.압출속도1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모터속도1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.압출속도2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.모터속도2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.냉각수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.인취속도 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.중량 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.관벽두께 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.최소내벽두께 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.평균안지름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.제품길이 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPProductQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "품목정보";
            // 
            // pbPrint
            // 
            this.pbPrint.Image = ((System.Drawing.Image)(resources.GetObject("pbPrint.Image")));
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            // 
            // pbSave
            // 
            this.pbSave.Image = ((System.Drawing.Image)(resources.GetObject("pbSave.Image")));
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
            this.panSearch.Controls.Add(this.rbZ);
            this.panSearch.Controls.Add(this.rbD);
            this.panSearch.Controls.Add(this.rbC);
            this.panSearch.Controls.Add(this.rbB);
            this.panSearch.Controls.Add(this.rbA);
            this.panSearch.Controls.Add(this.tbSearch);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Location = new System.Drawing.Point(2, 58);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(1319, 71);
            this.panSearch.TabIndex = 0;
            // 
            // rbZ
            // 
            this.rbZ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbZ.AutoSize = true;
            this.rbZ.ForeColor = System.Drawing.Color.Blue;
            this.rbZ.Location = new System.Drawing.Point(352, 21);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(60, 25);
            this.rbZ.TabIndex = 6;
            this.rbZ.Text = "기타";
            this.rbZ.UseVisualStyleBackColor = true;
            this.rbZ.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbD
            // 
            this.rbD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbD.AutoSize = true;
            this.rbD.ForeColor = System.Drawing.Color.Blue;
            this.rbD.Location = new System.Drawing.Point(525, 21);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(60, 25);
            this.rbD.TabIndex = 5;
            this.rbD.Text = "세트";
            this.rbD.UseVisualStyleBackColor = true;
            this.rbD.Visible = false;
            this.rbD.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbC
            // 
            this.rbC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbC.AutoSize = true;
            this.rbC.ForeColor = System.Drawing.Color.Blue;
            this.rbC.Location = new System.Drawing.Point(419, 21);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(76, 25);
            this.rbC.TabIndex = 4;
            this.rbC.Text = "반제품";
            this.rbC.UseVisualStyleBackColor = true;
            this.rbC.Visible = false;
            this.rbC.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbB.AutoSize = true;
            this.rbB.ForeColor = System.Drawing.Color.Blue;
            this.rbB.Location = new System.Drawing.Point(235, 21);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(98, 25);
            this.rbB.TabIndex = 3;
            this.rbB.Text = "원/부자재";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbA
            // 
            this.rbA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbA.AutoSize = true;
            this.rbA.Checked = true;
            this.rbA.ForeColor = System.Drawing.Color.Blue;
            this.rbA.Location = new System.Drawing.Point(158, 21);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(60, 25);
            this.rbA.TabIndex = 2;
            this.rbA.TabStop = true;
            this.rbA.Text = "제품";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(840, 19);
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
            this.label1.Location = new System.Drawing.Point(741, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "분류/품목명";
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
            this.번호,
            this.품목코드DataGridViewTextBoxColumn,
            this.분류코드DataGridViewTextBoxColumn,
            this.분류DataGridViewTextBoxColumn,
            this.품목명DataGridViewTextBoxColumn,
            this.모델명,
            this.규격DataGridViewTextBoxColumn,
            this.단위DataGridViewTextBoxColumn,
            this.단위1DataGridViewTextBoxColumn,
            this.조달단가,
            this.민간단가,
            this.물품식별번호,
            this.재고대상DataGridViewTextBoxColumn,
            this.재고단가DataGridViewTextBoxColumn,
            this.사용DataGridViewTextBoxColumn,
            this.주압출기1,
            this.주압출기2,
            this.주압출기3,
            this.주압출기4,
            this.주압출기5,
            this.주압출기6,
            this.보조압출기1,
            this.보조압출기2,
            this.보조압출기3,
            this.보조압출기4,
            this.보조압출기5,
            this.보조압출기6,
            this.압출속도1,
            this.모터속도1,
            this.압출속도2,
            this.모터속도2,
            this.냉각수,
            this.인취속도,
            this.중량,
            this.관벽두께,
            this.최소내벽두께,
            this.평균안지름,
            this.제품길이});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPProductQueryBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 131);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            // sPProductQueryBindingSource
            // 
            this.sPProductQueryBindingSource.DataMember = "SP_Product_Query";
            this.sPProductQueryBindingSource.DataSource = this.dataSetP1A;
            // 
            // dataSetP1A
            // 
            this.dataSetP1A.DataSetName = "DataSetP1A";
            this.dataSetP1A.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_Product_QueryTableAdapter
            // 
            this.sP_Product_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // 번호
            // 
            this.번호.DataPropertyName = "번호";
            this.번호.FillWeight = 20F;
            this.번호.HeaderText = "No.";
            this.번호.Name = "번호";
            this.번호.ReadOnly = true;
            this.번호.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 품목코드DataGridViewTextBoxColumn
            // 
            this.품목코드DataGridViewTextBoxColumn.DataPropertyName = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.FillWeight = 60F;
            this.품목코드DataGridViewTextBoxColumn.HeaderText = "품목코드";
            this.품목코드DataGridViewTextBoxColumn.Name = "품목코드DataGridViewTextBoxColumn";
            this.품목코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.품목코드DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.품목코드DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 분류코드DataGridViewTextBoxColumn
            // 
            this.분류코드DataGridViewTextBoxColumn.DataPropertyName = "분류코드";
            this.분류코드DataGridViewTextBoxColumn.HeaderText = "분류코드";
            this.분류코드DataGridViewTextBoxColumn.Name = "분류코드DataGridViewTextBoxColumn";
            this.분류코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.분류코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 분류DataGridViewTextBoxColumn
            // 
            this.분류DataGridViewTextBoxColumn.DataPropertyName = "분류";
            this.분류DataGridViewTextBoxColumn.FillWeight = 50F;
            this.분류DataGridViewTextBoxColumn.HeaderText = "분류";
            this.분류DataGridViewTextBoxColumn.Name = "분류DataGridViewTextBoxColumn";
            this.분류DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 품목명DataGridViewTextBoxColumn
            // 
            this.품목명DataGridViewTextBoxColumn.DataPropertyName = "품목명";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.품목명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.품목명DataGridViewTextBoxColumn.HeaderText = "품목명";
            this.품목명DataGridViewTextBoxColumn.Name = "품목명DataGridViewTextBoxColumn";
            this.품목명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 모델명
            // 
            this.모델명.DataPropertyName = "모델명";
            this.모델명.HeaderText = "모델명";
            this.모델명.Name = "모델명";
            this.모델명.ReadOnly = true;
            this.모델명.Visible = false;
            // 
            // 규격DataGridViewTextBoxColumn
            // 
            this.규격DataGridViewTextBoxColumn.DataPropertyName = "규격";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.규격DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.규격DataGridViewTextBoxColumn.HeaderText = "규격";
            this.규격DataGridViewTextBoxColumn.Name = "규격DataGridViewTextBoxColumn";
            this.규격DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 단위DataGridViewTextBoxColumn
            // 
            this.단위DataGridViewTextBoxColumn.DataPropertyName = "단위";
            this.단위DataGridViewTextBoxColumn.FillWeight = 30F;
            this.단위DataGridViewTextBoxColumn.HeaderText = "단위";
            this.단위DataGridViewTextBoxColumn.Name = "단위DataGridViewTextBoxColumn";
            this.단위DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 단위1DataGridViewTextBoxColumn
            // 
            this.단위1DataGridViewTextBoxColumn.DataPropertyName = "단위1";
            this.단위1DataGridViewTextBoxColumn.HeaderText = "단위1";
            this.단위1DataGridViewTextBoxColumn.Name = "단위1DataGridViewTextBoxColumn";
            this.단위1DataGridViewTextBoxColumn.ReadOnly = true;
            this.단위1DataGridViewTextBoxColumn.Visible = false;
            // 
            // 조달단가
            // 
            this.조달단가.DataPropertyName = "조달단가";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0";
            this.조달단가.DefaultCellStyle = dataGridViewCellStyle5;
            this.조달단가.FillWeight = 40F;
            this.조달단가.HeaderText = "조달단가";
            this.조달단가.Name = "조달단가";
            this.조달단가.ReadOnly = true;
            // 
            // 민간단가
            // 
            this.민간단가.DataPropertyName = "민간단가";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0";
            this.민간단가.DefaultCellStyle = dataGridViewCellStyle6;
            this.민간단가.FillWeight = 40F;
            this.민간단가.HeaderText = "민간단가";
            this.민간단가.Name = "민간단가";
            this.민간단가.ReadOnly = true;
            // 
            // 물품식별번호
            // 
            this.물품식별번호.DataPropertyName = "물품식별번호";
            this.물품식별번호.HeaderText = "식별번호";
            this.물품식별번호.Name = "물품식별번호";
            this.물품식별번호.ReadOnly = true;
            // 
            // 재고대상DataGridViewTextBoxColumn
            // 
            this.재고대상DataGridViewTextBoxColumn.DataPropertyName = "재고대상";
            this.재고대상DataGridViewTextBoxColumn.HeaderText = "재고대상";
            this.재고대상DataGridViewTextBoxColumn.Name = "재고대상DataGridViewTextBoxColumn";
            this.재고대상DataGridViewTextBoxColumn.ReadOnly = true;
            this.재고대상DataGridViewTextBoxColumn.Visible = false;
            // 
            // 재고단가DataGridViewTextBoxColumn
            // 
            this.재고단가DataGridViewTextBoxColumn.DataPropertyName = "재고단가";
            this.재고단가DataGridViewTextBoxColumn.HeaderText = "재고단가";
            this.재고단가DataGridViewTextBoxColumn.Name = "재고단가DataGridViewTextBoxColumn";
            this.재고단가DataGridViewTextBoxColumn.ReadOnly = true;
            this.재고단가DataGridViewTextBoxColumn.Visible = false;
            // 
            // 사용DataGridViewTextBoxColumn
            // 
            this.사용DataGridViewTextBoxColumn.DataPropertyName = "사용";
            this.사용DataGridViewTextBoxColumn.FillWeight = 30F;
            this.사용DataGridViewTextBoxColumn.HeaderText = "사용";
            this.사용DataGridViewTextBoxColumn.Name = "사용DataGridViewTextBoxColumn";
            this.사용DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 주압출기1
            // 
            this.주압출기1.DataPropertyName = "주압출기1";
            this.주압출기1.HeaderText = "주압출기1";
            this.주압출기1.Name = "주압출기1";
            this.주압출기1.ReadOnly = true;
            this.주압출기1.Visible = false;
            // 
            // 주압출기2
            // 
            this.주압출기2.DataPropertyName = "주압출기2";
            this.주압출기2.HeaderText = "주압출기2";
            this.주압출기2.Name = "주압출기2";
            this.주압출기2.ReadOnly = true;
            this.주압출기2.Visible = false;
            // 
            // 주압출기3
            // 
            this.주압출기3.DataPropertyName = "주압출기3";
            this.주압출기3.HeaderText = "주압출기3";
            this.주압출기3.Name = "주압출기3";
            this.주압출기3.ReadOnly = true;
            this.주압출기3.Visible = false;
            // 
            // 주압출기4
            // 
            this.주압출기4.DataPropertyName = "주압출기4";
            this.주압출기4.HeaderText = "주압출기4";
            this.주압출기4.Name = "주압출기4";
            this.주압출기4.ReadOnly = true;
            this.주압출기4.Visible = false;
            // 
            // 주압출기5
            // 
            this.주압출기5.DataPropertyName = "주압출기5";
            this.주압출기5.HeaderText = "주압출기5";
            this.주압출기5.Name = "주압출기5";
            this.주압출기5.ReadOnly = true;
            this.주압출기5.Visible = false;
            // 
            // 주압출기6
            // 
            this.주압출기6.DataPropertyName = "주압출기6";
            this.주압출기6.HeaderText = "주압출기6";
            this.주압출기6.Name = "주압출기6";
            this.주압출기6.ReadOnly = true;
            this.주압출기6.Visible = false;
            // 
            // 보조압출기1
            // 
            this.보조압출기1.DataPropertyName = "보조압출기1";
            this.보조압출기1.HeaderText = "보조압출기1";
            this.보조압출기1.Name = "보조압출기1";
            this.보조압출기1.ReadOnly = true;
            this.보조압출기1.Visible = false;
            // 
            // 보조압출기2
            // 
            this.보조압출기2.DataPropertyName = "보조압출기2";
            this.보조압출기2.HeaderText = "보조압출기2";
            this.보조압출기2.Name = "보조압출기2";
            this.보조압출기2.ReadOnly = true;
            this.보조압출기2.Visible = false;
            // 
            // 보조압출기3
            // 
            this.보조압출기3.DataPropertyName = "보조압출기3";
            this.보조압출기3.HeaderText = "보조압출기3";
            this.보조압출기3.Name = "보조압출기3";
            this.보조압출기3.ReadOnly = true;
            this.보조압출기3.Visible = false;
            // 
            // 보조압출기4
            // 
            this.보조압출기4.DataPropertyName = "보조압출기4";
            this.보조압출기4.HeaderText = "보조압출기4";
            this.보조압출기4.Name = "보조압출기4";
            this.보조압출기4.ReadOnly = true;
            this.보조압출기4.Visible = false;
            // 
            // 보조압출기5
            // 
            this.보조압출기5.DataPropertyName = "보조압출기5";
            this.보조압출기5.HeaderText = "보조압출기5";
            this.보조압출기5.Name = "보조압출기5";
            this.보조압출기5.ReadOnly = true;
            this.보조압출기5.Visible = false;
            // 
            // 보조압출기6
            // 
            this.보조압출기6.DataPropertyName = "보조압출기6";
            this.보조압출기6.HeaderText = "보조압출기6";
            this.보조압출기6.Name = "보조압출기6";
            this.보조압출기6.ReadOnly = true;
            this.보조압출기6.Visible = false;
            // 
            // 압출속도1
            // 
            this.압출속도1.DataPropertyName = "압출속도1";
            this.압출속도1.HeaderText = "압출속도1";
            this.압출속도1.Name = "압출속도1";
            this.압출속도1.ReadOnly = true;
            this.압출속도1.Visible = false;
            // 
            // 모터속도1
            // 
            this.모터속도1.DataPropertyName = "모터속도1";
            this.모터속도1.HeaderText = "모터속도1";
            this.모터속도1.Name = "모터속도1";
            this.모터속도1.ReadOnly = true;
            this.모터속도1.Visible = false;
            // 
            // 압출속도2
            // 
            this.압출속도2.DataPropertyName = "압출속도2";
            this.압출속도2.HeaderText = "압출속도2";
            this.압출속도2.Name = "압출속도2";
            this.압출속도2.ReadOnly = true;
            this.압출속도2.Visible = false;
            // 
            // 모터속도2
            // 
            this.모터속도2.DataPropertyName = "모터속도2";
            this.모터속도2.HeaderText = "모터속도2";
            this.모터속도2.Name = "모터속도2";
            this.모터속도2.ReadOnly = true;
            this.모터속도2.Visible = false;
            // 
            // 냉각수
            // 
            this.냉각수.DataPropertyName = "냉각수";
            this.냉각수.HeaderText = "냉각수";
            this.냉각수.Name = "냉각수";
            this.냉각수.ReadOnly = true;
            this.냉각수.Visible = false;
            // 
            // 인취속도
            // 
            this.인취속도.DataPropertyName = "인취속도";
            this.인취속도.HeaderText = "인취속도";
            this.인취속도.Name = "인취속도";
            this.인취속도.ReadOnly = true;
            this.인취속도.Visible = false;
            // 
            // 중량
            // 
            this.중량.DataPropertyName = "중량";
            this.중량.HeaderText = "중량";
            this.중량.Name = "중량";
            this.중량.ReadOnly = true;
            this.중량.Visible = false;
            // 
            // 관벽두께
            // 
            this.관벽두께.DataPropertyName = "관벽두께";
            this.관벽두께.HeaderText = "관벽두께";
            this.관벽두께.Name = "관벽두께";
            this.관벽두께.ReadOnly = true;
            this.관벽두께.Visible = false;
            // 
            // 최소내벽두께
            // 
            this.최소내벽두께.DataPropertyName = "최소내벽두께";
            this.최소내벽두께.HeaderText = "최소내벽두께";
            this.최소내벽두께.Name = "최소내벽두께";
            this.최소내벽두께.ReadOnly = true;
            this.최소내벽두께.Visible = false;
            // 
            // 평균안지름
            // 
            this.평균안지름.DataPropertyName = "평균안지름";
            this.평균안지름.HeaderText = "평균안지름";
            this.평균안지름.Name = "평균안지름";
            this.평균안지름.ReadOnly = true;
            this.평균안지름.Visible = false;
            // 
            // 제품길이
            // 
            this.제품길이.DataPropertyName = "제품길이";
            this.제품길이.HeaderText = "제품길이";
            this.제품길이.Name = "제품길이";
            this.제품길이.ReadOnly = true;
            this.제품길이.Visible = false;
            // 
            // P1A02_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1A02_PRODUCT";
            this.Text = "P1A02_PRODUCT";
            this.Load += new System.EventHandler(this.P1A02_PRODUCT_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPProductQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sPProductQueryBindingSource;
        private P1A.DataSetP1A dataSetP1A;
        private P1A.DataSetP1ATableAdapters.SP_Product_QueryTableAdapter sP_Product_QueryTableAdapter;
        public System.Windows.Forms.TextBox tbSearch;
        public System.Windows.Forms.RadioButton rbZ;
        public System.Windows.Forms.RadioButton rbD;
        public System.Windows.Forms.RadioButton rbC;
        public System.Windows.Forms.RadioButton rbB;
        public System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.DataGridViewTextBoxColumn 번호;
        private System.Windows.Forms.DataGridViewLinkColumn 품목코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분류코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 분류DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 품목명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 규격DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단위DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 단위1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조달단가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 민간단가;
        private System.Windows.Forms.DataGridViewTextBoxColumn 물품식별번호;
        private System.Windows.Forms.DataGridViewTextBoxColumn 재고대상DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 재고단가DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주압출기1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주압출기2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주압출기3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주압출기4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주압출기5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주압출기6;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보조압출기1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보조압출기2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보조압출기3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보조압출기4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보조압출기5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 보조압출기6;
        private System.Windows.Forms.DataGridViewTextBoxColumn 압출속도1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모터속도1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 압출속도2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모터속도2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 냉각수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 인취속도;
        private System.Windows.Forms.DataGridViewTextBoxColumn 중량;
        private System.Windows.Forms.DataGridViewTextBoxColumn 관벽두께;
        private System.Windows.Forms.DataGridViewTextBoxColumn 최소내벽두께;
        private System.Windows.Forms.DataGridViewTextBoxColumn 평균안지름;
        private System.Windows.Forms.DataGridViewTextBoxColumn 제품길이;
    }
}

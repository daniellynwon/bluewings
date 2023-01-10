namespace SmartMES_Bluewings
{
    partial class P1A01_CUSTOMER
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
            this.cbFlag = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처전명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래처명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.입출구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사업구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사업자번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대표자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.법인번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.업태DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.종목DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.우편번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.우편주소DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.상세주소DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주소DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전화번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.팩스번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.거래담당자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.담당자연락처DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.개업일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.영업관리자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPCustomerQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1A = new SmartMES_Bluewings.P1A.DataSetP1A();
            this.sP_Customer_QueryTableAdapter = new SmartMES_Bluewings.P1A.DataSetP1ATableAdapters.SP_Customer_QueryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCustomerQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "거래처정보";
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
            this.panSearch.Controls.Add(this.cbFlag);
            this.panSearch.Controls.Add(this.label3);
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
            this.tbSearch.Location = new System.Drawing.Point(335, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(328, 29);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // cbFlag
            // 
            this.cbFlag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFlag.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbFlag.FormattingEnabled = true;
            this.cbFlag.Items.AddRange(new object[] {
            "<전체>",
            "1.매출처",
            "2.매입처"});
            this.cbFlag.Location = new System.Drawing.Point(898, 19);
            this.cbFlag.Name = "cbFlag";
            this.cbFlag.Size = new System.Drawing.Size(146, 29);
            this.cbFlag.TabIndex = 2;
            this.cbFlag.SelectedIndexChanged += new System.EventHandler(this.cbFlag_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(777, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "매입/매출 구분";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(166, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "거래처명/대표자/주소";
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
            this.번호DataGridViewTextBoxColumn,
            this.거래처코드DataGridViewTextBoxColumn,
            this.거래처전명DataGridViewTextBoxColumn,
            this.거래처명DataGridViewTextBoxColumn,
            this.입출구분DataGridViewTextBoxColumn,
            this.사업구분DataGridViewTextBoxColumn,
            this.사업자번호DataGridViewTextBoxColumn,
            this.대표자DataGridViewTextBoxColumn,
            this.법인번호DataGridViewTextBoxColumn,
            this.업태DataGridViewTextBoxColumn,
            this.종목DataGridViewTextBoxColumn,
            this.우편번호DataGridViewTextBoxColumn,
            this.우편주소DataGridViewTextBoxColumn,
            this.상세주소DataGridViewTextBoxColumn,
            this.주소DataGridViewTextBoxColumn,
            this.전화번호DataGridViewTextBoxColumn,
            this.팩스번호DataGridViewTextBoxColumn,
            this.거래담당자DataGridViewTextBoxColumn,
            this.담당자연락처DataGridViewTextBoxColumn,
            this.개업일자DataGridViewTextBoxColumn,
            this.영업관리자DataGridViewTextBoxColumn,
            this.비고DataGridViewTextBoxColumn,
            this.사용DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPCustomerQueryBindingSource;
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
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // 번호DataGridViewTextBoxColumn
            // 
            this.번호DataGridViewTextBoxColumn.DataPropertyName = "번호";
            this.번호DataGridViewTextBoxColumn.FillWeight = 40F;
            this.번호DataGridViewTextBoxColumn.HeaderText = "No.";
            this.번호DataGridViewTextBoxColumn.Name = "번호DataGridViewTextBoxColumn";
            this.번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.번호DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 거래처코드DataGridViewTextBoxColumn
            // 
            this.거래처코드DataGridViewTextBoxColumn.DataPropertyName = "거래처코드";
            this.거래처코드DataGridViewTextBoxColumn.HeaderText = "거래처코드";
            this.거래처코드DataGridViewTextBoxColumn.Name = "거래처코드DataGridViewTextBoxColumn";
            this.거래처코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.거래처코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 거래처전명DataGridViewTextBoxColumn
            // 
            this.거래처전명DataGridViewTextBoxColumn.DataPropertyName = "거래처전명";
            this.거래처전명DataGridViewTextBoxColumn.HeaderText = "거래처전명";
            this.거래처전명DataGridViewTextBoxColumn.Name = "거래처전명DataGridViewTextBoxColumn";
            this.거래처전명DataGridViewTextBoxColumn.ReadOnly = true;
            this.거래처전명DataGridViewTextBoxColumn.Visible = false;
            // 
            // 거래처명DataGridViewTextBoxColumn
            // 
            this.거래처명DataGridViewTextBoxColumn.DataPropertyName = "거래처명";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.거래처명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.거래처명DataGridViewTextBoxColumn.FillWeight = 150F;
            this.거래처명DataGridViewTextBoxColumn.HeaderText = "거래처명";
            this.거래처명DataGridViewTextBoxColumn.Name = "거래처명DataGridViewTextBoxColumn";
            this.거래처명DataGridViewTextBoxColumn.ReadOnly = true;
            this.거래처명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.거래처명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 입출구분DataGridViewTextBoxColumn
            // 
            this.입출구분DataGridViewTextBoxColumn.DataPropertyName = "입출구분";
            this.입출구분DataGridViewTextBoxColumn.FillWeight = 70F;
            this.입출구분DataGridViewTextBoxColumn.HeaderText = "입출구분";
            this.입출구분DataGridViewTextBoxColumn.Name = "입출구분DataGridViewTextBoxColumn";
            this.입출구분DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 사업구분DataGridViewTextBoxColumn
            // 
            this.사업구분DataGridViewTextBoxColumn.DataPropertyName = "사업구분";
            this.사업구분DataGridViewTextBoxColumn.HeaderText = "사업구분";
            this.사업구분DataGridViewTextBoxColumn.Name = "사업구분DataGridViewTextBoxColumn";
            this.사업구분DataGridViewTextBoxColumn.ReadOnly = true;
            this.사업구분DataGridViewTextBoxColumn.Visible = false;
            // 
            // 사업자번호DataGridViewTextBoxColumn
            // 
            this.사업자번호DataGridViewTextBoxColumn.DataPropertyName = "사업자번호";
            this.사업자번호DataGridViewTextBoxColumn.HeaderText = "사업자번호";
            this.사업자번호DataGridViewTextBoxColumn.Name = "사업자번호DataGridViewTextBoxColumn";
            this.사업자번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.사업자번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 대표자DataGridViewTextBoxColumn
            // 
            this.대표자DataGridViewTextBoxColumn.DataPropertyName = "대표자";
            this.대표자DataGridViewTextBoxColumn.FillWeight = 70F;
            this.대표자DataGridViewTextBoxColumn.HeaderText = "대표자";
            this.대표자DataGridViewTextBoxColumn.Name = "대표자DataGridViewTextBoxColumn";
            this.대표자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 법인번호DataGridViewTextBoxColumn
            // 
            this.법인번호DataGridViewTextBoxColumn.DataPropertyName = "법인번호";
            this.법인번호DataGridViewTextBoxColumn.HeaderText = "법인번호";
            this.법인번호DataGridViewTextBoxColumn.Name = "법인번호DataGridViewTextBoxColumn";
            this.법인번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.법인번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 업태DataGridViewTextBoxColumn
            // 
            this.업태DataGridViewTextBoxColumn.DataPropertyName = "업태";
            this.업태DataGridViewTextBoxColumn.HeaderText = "업태";
            this.업태DataGridViewTextBoxColumn.Name = "업태DataGridViewTextBoxColumn";
            this.업태DataGridViewTextBoxColumn.ReadOnly = true;
            this.업태DataGridViewTextBoxColumn.Visible = false;
            // 
            // 종목DataGridViewTextBoxColumn
            // 
            this.종목DataGridViewTextBoxColumn.DataPropertyName = "종목";
            this.종목DataGridViewTextBoxColumn.HeaderText = "종목";
            this.종목DataGridViewTextBoxColumn.Name = "종목DataGridViewTextBoxColumn";
            this.종목DataGridViewTextBoxColumn.ReadOnly = true;
            this.종목DataGridViewTextBoxColumn.Visible = false;
            // 
            // 우편번호DataGridViewTextBoxColumn
            // 
            this.우편번호DataGridViewTextBoxColumn.DataPropertyName = "우편번호";
            this.우편번호DataGridViewTextBoxColumn.HeaderText = "우편번호";
            this.우편번호DataGridViewTextBoxColumn.Name = "우편번호DataGridViewTextBoxColumn";
            this.우편번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.우편번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 우편주소DataGridViewTextBoxColumn
            // 
            this.우편주소DataGridViewTextBoxColumn.DataPropertyName = "우편주소";
            this.우편주소DataGridViewTextBoxColumn.HeaderText = "우편주소";
            this.우편주소DataGridViewTextBoxColumn.Name = "우편주소DataGridViewTextBoxColumn";
            this.우편주소DataGridViewTextBoxColumn.ReadOnly = true;
            this.우편주소DataGridViewTextBoxColumn.Visible = false;
            // 
            // 상세주소DataGridViewTextBoxColumn
            // 
            this.상세주소DataGridViewTextBoxColumn.DataPropertyName = "상세주소";
            this.상세주소DataGridViewTextBoxColumn.HeaderText = "상세주소";
            this.상세주소DataGridViewTextBoxColumn.Name = "상세주소DataGridViewTextBoxColumn";
            this.상세주소DataGridViewTextBoxColumn.ReadOnly = true;
            this.상세주소DataGridViewTextBoxColumn.Visible = false;
            // 
            // 주소DataGridViewTextBoxColumn
            // 
            this.주소DataGridViewTextBoxColumn.DataPropertyName = "주소";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.주소DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.주소DataGridViewTextBoxColumn.FillWeight = 350F;
            this.주소DataGridViewTextBoxColumn.HeaderText = "주소";
            this.주소DataGridViewTextBoxColumn.Name = "주소DataGridViewTextBoxColumn";
            this.주소DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 전화번호DataGridViewTextBoxColumn
            // 
            this.전화번호DataGridViewTextBoxColumn.DataPropertyName = "전화번호";
            this.전화번호DataGridViewTextBoxColumn.HeaderText = "전화번호";
            this.전화번호DataGridViewTextBoxColumn.Name = "전화번호DataGridViewTextBoxColumn";
            this.전화번호DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 팩스번호DataGridViewTextBoxColumn
            // 
            this.팩스번호DataGridViewTextBoxColumn.DataPropertyName = "팩스번호";
            this.팩스번호DataGridViewTextBoxColumn.HeaderText = "팩스번호";
            this.팩스번호DataGridViewTextBoxColumn.Name = "팩스번호DataGridViewTextBoxColumn";
            this.팩스번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.팩스번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 거래담당자DataGridViewTextBoxColumn
            // 
            this.거래담당자DataGridViewTextBoxColumn.DataPropertyName = "거래담당자";
            this.거래담당자DataGridViewTextBoxColumn.HeaderText = "거래담당자";
            this.거래담당자DataGridViewTextBoxColumn.Name = "거래담당자DataGridViewTextBoxColumn";
            this.거래담당자DataGridViewTextBoxColumn.ReadOnly = true;
            this.거래담당자DataGridViewTextBoxColumn.Visible = false;
            // 
            // 담당자연락처DataGridViewTextBoxColumn
            // 
            this.담당자연락처DataGridViewTextBoxColumn.DataPropertyName = "담당자연락처";
            this.담당자연락처DataGridViewTextBoxColumn.HeaderText = "담당자연락처";
            this.담당자연락처DataGridViewTextBoxColumn.Name = "담당자연락처DataGridViewTextBoxColumn";
            this.담당자연락처DataGridViewTextBoxColumn.ReadOnly = true;
            this.담당자연락처DataGridViewTextBoxColumn.Visible = false;
            // 
            // 개업일자DataGridViewTextBoxColumn
            // 
            this.개업일자DataGridViewTextBoxColumn.DataPropertyName = "개업일자";
            this.개업일자DataGridViewTextBoxColumn.HeaderText = "개업일자";
            this.개업일자DataGridViewTextBoxColumn.Name = "개업일자DataGridViewTextBoxColumn";
            this.개업일자DataGridViewTextBoxColumn.ReadOnly = true;
            this.개업일자DataGridViewTextBoxColumn.Visible = false;
            // 
            // 영업관리자DataGridViewTextBoxColumn
            // 
            this.영업관리자DataGridViewTextBoxColumn.DataPropertyName = "영업관리자";
            this.영업관리자DataGridViewTextBoxColumn.FillWeight = 70F;
            this.영업관리자DataGridViewTextBoxColumn.HeaderText = "영업관리자";
            this.영업관리자DataGridViewTextBoxColumn.Name = "영업관리자DataGridViewTextBoxColumn";
            this.영업관리자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 비고DataGridViewTextBoxColumn
            // 
            this.비고DataGridViewTextBoxColumn.DataPropertyName = "비고";
            this.비고DataGridViewTextBoxColumn.HeaderText = "비고";
            this.비고DataGridViewTextBoxColumn.Name = "비고DataGridViewTextBoxColumn";
            this.비고DataGridViewTextBoxColumn.ReadOnly = true;
            this.비고DataGridViewTextBoxColumn.Visible = false;
            // 
            // 사용DataGridViewTextBoxColumn
            // 
            this.사용DataGridViewTextBoxColumn.DataPropertyName = "사용";
            this.사용DataGridViewTextBoxColumn.FillWeight = 35F;
            this.사용DataGridViewTextBoxColumn.HeaderText = "사용";
            this.사용DataGridViewTextBoxColumn.Name = "사용DataGridViewTextBoxColumn";
            this.사용DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPCustomerQueryBindingSource
            // 
            this.sPCustomerQueryBindingSource.DataMember = "SP_Customer_Query";
            this.sPCustomerQueryBindingSource.DataSource = this.dataSetP1A;
            // 
            // dataSetP1A
            // 
            this.dataSetP1A.DataSetName = "DataSetP1A";
            this.dataSetP1A.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_Customer_QueryTableAdapter
            // 
            this.sP_Customer_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1A01_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1A01_CUSTOMER";
            this.Text = "P1A01_CUSTOMER";
            this.Load += new System.EventHandler(this.P1A01_CUSTOMER_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPCustomerQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.TextBox tbSearch;
        public System.Windows.Forms.ComboBox cbFlag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처전명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 거래처명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 입출구분DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사업구분DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사업자번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대표자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 법인번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 업태DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종목DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 우편번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 우편주소DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 상세주소DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주소DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전화번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 팩스번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래담당자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 담당자연락처DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 개업일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 영업관리자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPCustomerQueryBindingSource;
        private P1A.DataSetP1A dataSetP1A;
        private P1A.DataSetP1ATableAdapters.SP_Customer_QueryTableAdapter sP_Customer_QueryTableAdapter;
    }
}

namespace SmartMES_Bluewings
{
    partial class P1Z02_USER
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
            this.panSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbFlag = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.사용자IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.사용자명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사업장코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.담당업무DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.연락처DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용등급DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.암호초기화 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.사용여부 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPUserQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1Z = new SmartMES_Bluewings.P1Z.DataSetP1Z();
            this.sP_User_QueryTableAdapter = new SmartMES_Bluewings.P1Z.DataSetP1ZTableAdapters.SP_User_QueryTableAdapter();
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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "사용자정보";
            // 
            // pbDel
            // 
            this.pbDel.Enabled = false;
            this.pbDel.Image = global::SmartMES_Bluewings.Properties.Resources.del_B;
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
            "1.사용자",
            "0.미사용자"});
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
            this.label3.Location = new System.Drawing.Point(820, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "사용여부";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(175, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자명 / 담당업무";
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
            this.사용자IDDataGridViewTextBoxColumn,
            this.사용자명DataGridViewTextBoxColumn,
            this.사업장코드DataGridViewTextBoxColumn,
            this.담당업무DataGridViewTextBoxColumn,
            this.연락처DataGridViewTextBoxColumn,
            this.사용등급DataGridViewTextBoxColumn,
            this.암호초기화,
            this.사용여부});
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
            this.dataGridView1.Size = new System.Drawing.Size(1319, 852);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // 사용자IDDataGridViewTextBoxColumn
            // 
            this.사용자IDDataGridViewTextBoxColumn.DataPropertyName = "사용자ID";
            this.사용자IDDataGridViewTextBoxColumn.HeaderText = "사용자ID";
            this.사용자IDDataGridViewTextBoxColumn.Name = "사용자IDDataGridViewTextBoxColumn";
            this.사용자IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.사용자IDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.사용자IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 사용자명DataGridViewTextBoxColumn
            // 
            this.사용자명DataGridViewTextBoxColumn.DataPropertyName = "사용자명";
            this.사용자명DataGridViewTextBoxColumn.HeaderText = "사용자명";
            this.사용자명DataGridViewTextBoxColumn.Name = "사용자명DataGridViewTextBoxColumn";
            this.사용자명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 사업장코드DataGridViewTextBoxColumn
            // 
            this.사업장코드DataGridViewTextBoxColumn.DataPropertyName = "사업장코드";
            this.사업장코드DataGridViewTextBoxColumn.HeaderText = "사업장코드";
            this.사업장코드DataGridViewTextBoxColumn.Name = "사업장코드DataGridViewTextBoxColumn";
            this.사업장코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.사업장코드DataGridViewTextBoxColumn.Visible = false;
            // 
            // 담당업무DataGridViewTextBoxColumn
            // 
            this.담당업무DataGridViewTextBoxColumn.DataPropertyName = "담당업무";
            this.담당업무DataGridViewTextBoxColumn.HeaderText = "담당업무";
            this.담당업무DataGridViewTextBoxColumn.Name = "담당업무DataGridViewTextBoxColumn";
            this.담당업무DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 연락처DataGridViewTextBoxColumn
            // 
            this.연락처DataGridViewTextBoxColumn.DataPropertyName = "연락처";
            this.연락처DataGridViewTextBoxColumn.HeaderText = "연락처";
            this.연락처DataGridViewTextBoxColumn.Name = "연락처DataGridViewTextBoxColumn";
            this.연락처DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 사용등급DataGridViewTextBoxColumn
            // 
            this.사용등급DataGridViewTextBoxColumn.DataPropertyName = "사용등급";
            this.사용등급DataGridViewTextBoxColumn.HeaderText = "사용등급";
            this.사용등급DataGridViewTextBoxColumn.Name = "사용등급DataGridViewTextBoxColumn";
            this.사용등급DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 암호초기화
            // 
            this.암호초기화.DataPropertyName = "암호초기화";
            this.암호초기화.HeaderText = "암호초기화";
            this.암호초기화.Name = "암호초기화";
            this.암호초기화.ReadOnly = true;
            this.암호초기화.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 사용여부
            // 
            this.사용여부.DataPropertyName = "사용여부";
            this.사용여부.HeaderText = "사용여부";
            this.사용여부.Name = "사용여부";
            this.사용여부.ReadOnly = true;
            this.사용여부.Visible = false;
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
            // sP_User_QueryTableAdapter
            // 
            this.sP_User_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // P1Z02_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1325, 990);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panSearch);
            this.Name = "P1Z02_USER";
            this.Text = "P1Z02_USER";
            this.Load += new System.EventHandler(this.P1Z02_USER_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.sPUserQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1Z)).EndInit();
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
        private System.Windows.Forms.BindingSource sPUserQueryBindingSource;
        private P1Z.DataSetP1Z dataSetP1Z;
        private P1Z.DataSetP1ZTableAdapters.SP_User_QueryTableAdapter sP_User_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewLinkColumn 사용자IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용자명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사업장코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 담당업무DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 연락처DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용등급DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 암호초기화;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용여부;
    }
}

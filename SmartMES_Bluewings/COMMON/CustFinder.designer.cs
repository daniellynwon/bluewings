namespace SmartMES_Bluewings
{
    partial class CustFinder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.거래처코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.거래처명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.영업관리자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPCustomerCommonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCOMMON = new SmartMES_Bluewings.COMMON.DataSetCOMMON();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sP_Customer_CommonTableAdapter = new SmartMES_Bluewings.COMMON.DataSetCOMMONTableAdapters.SP_Customer_CommonTableAdapter();
            this.lblGubun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCustomerCommonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCOMMON)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.거래처코드DataGridViewTextBoxColumn,
            this.거래처명DataGridViewTextBoxColumn,
            this.영업관리자DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPCustomerCommonBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 614);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // 거래처코드DataGridViewTextBoxColumn
            // 
            this.거래처코드DataGridViewTextBoxColumn.DataPropertyName = "거래처코드";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            this.거래처코드DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.거래처코드DataGridViewTextBoxColumn.HeaderText = "거래처코드";
            this.거래처코드DataGridViewTextBoxColumn.Name = "거래처코드DataGridViewTextBoxColumn";
            this.거래처코드DataGridViewTextBoxColumn.ReadOnly = true;
            this.거래처코드DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.거래처코드DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 거래처명DataGridViewTextBoxColumn
            // 
            this.거래처명DataGridViewTextBoxColumn.DataPropertyName = "거래처명";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.거래처명DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.거래처명DataGridViewTextBoxColumn.FillWeight = 250F;
            this.거래처명DataGridViewTextBoxColumn.HeaderText = "거래처명";
            this.거래처명DataGridViewTextBoxColumn.Name = "거래처명DataGridViewTextBoxColumn";
            this.거래처명DataGridViewTextBoxColumn.ReadOnly = true;
            this.거래처명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 영업관리자DataGridViewTextBoxColumn
            // 
            this.영업관리자DataGridViewTextBoxColumn.DataPropertyName = "영업관리자";
            this.영업관리자DataGridViewTextBoxColumn.FillWeight = 80F;
            this.영업관리자DataGridViewTextBoxColumn.HeaderText = "영업관리자";
            this.영업관리자DataGridViewTextBoxColumn.Name = "영업관리자DataGridViewTextBoxColumn";
            this.영업관리자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPCustomerCommonBindingSource
            // 
            this.sPCustomerCommonBindingSource.DataMember = "SP_Customer_Common";
            this.sPCustomerCommonBindingSource.DataSource = this.dataSetCOMMON;
            // 
            // dataSetCOMMON
            // 
            this.dataSetCOMMON.DataSetName = "DataSetCOMMON";
            this.dataSetCOMMON.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 64);
            this.panel1.TabIndex = 0;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbSearch.Image = global::SmartMES_Bluewings.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(481, 18);
            this.pbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(32, 26);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 4;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            this.pbSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSearch_MouseDown);
            this.pbSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSearch_MouseUp);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbSearch.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbSearch.Location = new System.Drawing.Point(200, 17);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(319, 29);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "거래처명/영업관리자";
            // 
            // sP_Customer_CommonTableAdapter
            // 
            this.sP_Customer_CommonTableAdapter.ClearBeforeFill = true;
            // 
            // lblGubun
            // 
            this.lblGubun.AutoSize = true;
            this.lblGubun.ForeColor = System.Drawing.Color.Blue;
            this.lblGubun.Location = new System.Drawing.Point(31, 14);
            this.lblGubun.Name = "lblGubun";
            this.lblGubun.Size = new System.Drawing.Size(134, 21);
            this.lblGubun.TabIndex = 3;
            this.lblGubun.Text = "매입/매출처 구분";
            // 
            // CustFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 737);
            this.Controls.Add(this.lblGubun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustFinder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "거래처 검색기";
            this.Load += new System.EventHandler(this.CustFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCustomerCommonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCOMMON)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource sPCustomerCommonBindingSource;
        private COMMON.DataSetCOMMON dataSetCOMMON;
        private COMMON.DataSetCOMMONTableAdapters.SP_Customer_CommonTableAdapter sP_Customer_CommonTableAdapter;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGubun;
        private System.Windows.Forms.DataGridViewLinkColumn 거래처코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 거래처명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 영업관리자DataGridViewTextBoxColumn;
    }
}
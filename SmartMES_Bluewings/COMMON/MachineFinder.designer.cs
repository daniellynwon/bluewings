namespace SmartMES_Bluewings
{
    partial class MachineFinder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.설비IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.호기DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.모델번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설비그룹 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPMachineCommonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCOMMON = new SmartMES_Bluewings.COMMON.DataSetCOMMON();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sP_Machine_CommonTableAdapter = new SmartMES_Bluewings.COMMON.DataSetCOMMONTableAdapters.SP_Machine_CommonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMachineCommonBindingSource)).BeginInit();
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
            this.설비IDDataGridViewTextBoxColumn,
            this.호기DataGridViewTextBoxColumn,
            this.설비명DataGridViewTextBoxColumn,
            this.모델번호DataGridViewTextBoxColumn,
            this.설비그룹});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPMachineCommonBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 614);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // 설비IDDataGridViewTextBoxColumn
            // 
            this.설비IDDataGridViewTextBoxColumn.DataPropertyName = "설비ID";
            this.설비IDDataGridViewTextBoxColumn.HeaderText = "설비ID";
            this.설비IDDataGridViewTextBoxColumn.Name = "설비IDDataGridViewTextBoxColumn";
            this.설비IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.설비IDDataGridViewTextBoxColumn.Visible = false;
            // 
            // 호기DataGridViewTextBoxColumn
            // 
            this.호기DataGridViewTextBoxColumn.DataPropertyName = "호기";
            this.호기DataGridViewTextBoxColumn.FillWeight = 50F;
            this.호기DataGridViewTextBoxColumn.HeaderText = "호기";
            this.호기DataGridViewTextBoxColumn.Name = "호기DataGridViewTextBoxColumn";
            this.호기DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 설비명DataGridViewTextBoxColumn
            // 
            this.설비명DataGridViewTextBoxColumn.DataPropertyName = "설비명";
            this.설비명DataGridViewTextBoxColumn.HeaderText = "설비명";
            this.설비명DataGridViewTextBoxColumn.Name = "설비명DataGridViewTextBoxColumn";
            this.설비명DataGridViewTextBoxColumn.ReadOnly = true;
            this.설비명DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.설비명DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 모델번호DataGridViewTextBoxColumn
            // 
            this.모델번호DataGridViewTextBoxColumn.DataPropertyName = "모델번호";
            this.모델번호DataGridViewTextBoxColumn.HeaderText = "모델번호";
            this.모델번호DataGridViewTextBoxColumn.Name = "모델번호DataGridViewTextBoxColumn";
            this.모델번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.모델번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 설비그룹
            // 
            this.설비그룹.DataPropertyName = "설비그룹";
            this.설비그룹.FillWeight = 50F;
            this.설비그룹.HeaderText = "설비그룹";
            this.설비그룹.Name = "설비그룹";
            this.설비그룹.ReadOnly = true;
            // 
            // sPMachineCommonBindingSource
            // 
            this.sPMachineCommonBindingSource.DataMember = "SP_Machine_Common";
            this.sPMachineCommonBindingSource.DataSource = this.dataSetCOMMON;
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
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 90);
            this.panel1.TabIndex = 0;
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.Transparent;
            this.pbSearch.Image = global::SmartMES_Bluewings.Properties.Resources.search;
            this.pbSearch.Location = new System.Drawing.Point(481, 31);
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
            this.tbSearch.Location = new System.Drawing.Point(200, 30);
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
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "호기/설비명/설비그룹";
            // 
            // sP_Machine_CommonTableAdapter
            // 
            this.sP_Machine_CommonTableAdapter.ClearBeforeFill = true;
            // 
            // MachineFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 737);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MachineFinder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "설비 검색기";
            this.Load += new System.EventHandler(this.MachineFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMachineCommonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCOMMON)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sPMachineCommonBindingSource;
        private COMMON.DataSetCOMMON dataSetCOMMON;
        private COMMON.DataSetCOMMONTableAdapters.SP_Machine_CommonTableAdapter sP_Machine_CommonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 호기DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn 설비명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 모델번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설비그룹;
    }
}
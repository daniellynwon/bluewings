namespace SmartMES_Bluewings
{
    partial class P1C01_PROD_ORDER_SUB1
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
            this.panTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPRecipeDetailQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1C = new SmartMES_Bluewings.P1C.DataSetP1C();
            this.sP_RecipeDetail_QueryTableAdapter = new SmartMES_Bluewings.P1C.DataSetP1CTableAdapters.SP_RecipeDetail_QueryTableAdapter();
            this.레시피번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.순번DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.로트번호DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.자재명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.비율DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRecipeDetailQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1C)).BeginInit();
            this.SuspendLayout();
            // 
            // panTitle
            // 
            this.panTitle.BackgroundImage = global::SmartMES_Bluewings.Properties.Resources.photo_background;
            this.panTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panTitle.Controls.Add(this.lblTitle);
            this.panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitle.Location = new System.Drawing.Point(0, 0);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(552, 54);
            this.panTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "레시피상세";
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
            this.레시피번호DataGridViewTextBoxColumn,
            this.순번DataGridViewTextBoxColumn,
            this.로트번호DataGridViewTextBoxColumn,
            this.자재명DataGridViewTextBoxColumn,
            this.비율DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPRecipeDetailQueryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
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
            this.dataGridView1.Size = new System.Drawing.Size(552, 343);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // sPRecipeDetailQueryBindingSource
            // 
            this.sPRecipeDetailQueryBindingSource.DataMember = "SP_RecipeDetail_Query";
            this.sPRecipeDetailQueryBindingSource.DataSource = this.dataSetP1C;
            // 
            // dataSetP1C
            // 
            this.dataSetP1C.DataSetName = "DataSetP1C";
            this.dataSetP1C.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_RecipeDetail_QueryTableAdapter
            // 
            this.sP_RecipeDetail_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // 레시피번호DataGridViewTextBoxColumn
            // 
            this.레시피번호DataGridViewTextBoxColumn.DataPropertyName = "레시피번호";
            this.레시피번호DataGridViewTextBoxColumn.HeaderText = "No";
            this.레시피번호DataGridViewTextBoxColumn.Name = "레시피번호DataGridViewTextBoxColumn";
            this.레시피번호DataGridViewTextBoxColumn.ReadOnly = true;
            this.레시피번호DataGridViewTextBoxColumn.Visible = false;
            // 
            // 순번DataGridViewTextBoxColumn
            // 
            this.순번DataGridViewTextBoxColumn.DataPropertyName = "순번";
            this.순번DataGridViewTextBoxColumn.FillWeight = 50F;
            this.순번DataGridViewTextBoxColumn.HeaderText = "순번";
            this.순번DataGridViewTextBoxColumn.Name = "순번DataGridViewTextBoxColumn";
            this.순번DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 로트번호DataGridViewTextBoxColumn
            // 
            this.로트번호DataGridViewTextBoxColumn.DataPropertyName = "로트번호";
            this.로트번호DataGridViewTextBoxColumn.HeaderText = "로트번호";
            this.로트번호DataGridViewTextBoxColumn.Name = "로트번호DataGridViewTextBoxColumn";
            this.로트번호DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 자재명DataGridViewTextBoxColumn
            // 
            this.자재명DataGridViewTextBoxColumn.DataPropertyName = "자재명";
            this.자재명DataGridViewTextBoxColumn.FillWeight = 130F;
            this.자재명DataGridViewTextBoxColumn.HeaderText = "자재명";
            this.자재명DataGridViewTextBoxColumn.Name = "자재명DataGridViewTextBoxColumn";
            this.자재명DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 비율DataGridViewTextBoxColumn
            // 
            this.비율DataGridViewTextBoxColumn.DataPropertyName = "비율";
            this.비율DataGridViewTextBoxColumn.FillWeight = 80F;
            this.비율DataGridViewTextBoxColumn.HeaderText = "비율(%)";
            this.비율DataGridViewTextBoxColumn.Name = "비율DataGridViewTextBoxColumn";
            this.비율DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // P1C01_PROD_ORDER_SUB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(552, 405);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panTitle);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1C01_PROD_ORDER_SUB1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Smart Factory MES";
            this.Load += new System.EventHandler(this.P1C01_PROD_ORDER_SUB1_Load);
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRecipeDetailQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1C)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitle;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sPRecipeDetailQueryBindingSource;
        private P1C.DataSetP1C dataSetP1C;
        private P1C.DataSetP1CTableAdapters.SP_RecipeDetail_QueryTableAdapter sP_RecipeDetail_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 레시피번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 순번DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 로트번호DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 자재명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 비율DataGridViewTextBoxColumn;
    }
}
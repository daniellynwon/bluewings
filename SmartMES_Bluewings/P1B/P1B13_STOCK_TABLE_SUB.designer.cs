namespace SmartMES_Bluewings
{
    partial class P1B13_STOCK_TABLE_SUB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sPStockTableDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetP1B = new SmartMES_Bluewings.P1B.DataSetP1B();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sP_StockTable_DayTableAdapter = new SmartMES_Bluewings.P1B.DataSetP1BTableAdapters.SP_StockTable_DayTableAdapter();
            this.일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.생산DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.매입DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.소모DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.출고DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.조정DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPStockTableDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1B)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.일자DataGridViewTextBoxColumn,
            this.생산DataGridViewTextBoxColumn,
            this.매입DataGridViewTextBoxColumn,
            this.소모DataGridViewTextBoxColumn,
            this.출고DataGridViewTextBoxColumn,
            this.조정DataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.sPStockTableDayBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(5, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(679, 470);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // sPStockTableDayBindingSource
            // 
            this.sPStockTableDayBindingSource.DataMember = "SP_StockTable_Day";
            this.sPStockTableDayBindingSource.DataSource = this.dataSetP1B;
            // 
            // dataSetP1B
            // 
            this.dataSetP1B.DataSetName = "DataSetP1B";
            this.dataSetP1B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbProd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 68);
            this.panel1.TabIndex = 0;
            // 
            // tbProd
            // 
            this.tbProd.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.tbProd.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tbProd.Location = new System.Drawing.Point(215, 19);
            this.tbProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbProd.Name = "tbProd";
            this.tbProd.ReadOnly = true;
            this.tbProd.Size = new System.Drawing.Size(319, 29);
            this.tbProd.TabIndex = 0;
            this.tbProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(154, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "품목명";
            // 
            // sP_StockTable_DayTableAdapter
            // 
            this.sP_StockTable_DayTableAdapter.ClearBeforeFill = true;
            // 
            // 일자DataGridViewTextBoxColumn
            // 
            this.일자DataGridViewTextBoxColumn.DataPropertyName = "일자";
            dataGridViewCellStyle3.Format = "MM\\/dd";
            this.일자DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.일자DataGridViewTextBoxColumn.HeaderText = "일자";
            this.일자DataGridViewTextBoxColumn.Name = "일자DataGridViewTextBoxColumn";
            this.일자DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 생산DataGridViewTextBoxColumn
            // 
            this.생산DataGridViewTextBoxColumn.DataPropertyName = "생산";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,##0";
            this.생산DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.생산DataGridViewTextBoxColumn.HeaderText = "생산";
            this.생산DataGridViewTextBoxColumn.Name = "생산DataGridViewTextBoxColumn";
            this.생산DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 매입DataGridViewTextBoxColumn
            // 
            this.매입DataGridViewTextBoxColumn.DataPropertyName = "매입";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0";
            this.매입DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.매입DataGridViewTextBoxColumn.HeaderText = "매입";
            this.매입DataGridViewTextBoxColumn.Name = "매입DataGridViewTextBoxColumn";
            this.매입DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 소모DataGridViewTextBoxColumn
            // 
            this.소모DataGridViewTextBoxColumn.DataPropertyName = "소모";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0";
            this.소모DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.소모DataGridViewTextBoxColumn.HeaderText = "소모";
            this.소모DataGridViewTextBoxColumn.Name = "소모DataGridViewTextBoxColumn";
            this.소모DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 출고DataGridViewTextBoxColumn
            // 
            this.출고DataGridViewTextBoxColumn.DataPropertyName = "출고";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "#,##0";
            this.출고DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.출고DataGridViewTextBoxColumn.HeaderText = "출고";
            this.출고DataGridViewTextBoxColumn.Name = "출고DataGridViewTextBoxColumn";
            this.출고DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 조정DataGridViewTextBoxColumn
            // 
            this.조정DataGridViewTextBoxColumn.DataPropertyName = "조정";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "#,##0";
            this.조정DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.조정DataGridViewTextBoxColumn.HeaderText = "조정";
            this.조정DataGridViewTextBoxColumn.Name = "조정DataGridViewTextBoxColumn";
            this.조정DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // P1B13_STOCK_TABLE_SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P1B13_STOCK_TABLE_SUB";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "재고집계표";
            this.Load += new System.EventHandler(this.P1B13_STOCK_TABLE_SUB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPStockTableDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetP1B)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sPStockTableDayBindingSource;
        private P1B.DataSetP1B dataSetP1B;
        private P1B.DataSetP1BTableAdapters.SP_StockTable_DayTableAdapter sP_StockTable_DayTableAdapter;
        public System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn 일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 생산DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 매입DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 소모DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 출고DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 조정DataGridViewTextBoxColumn;
    }
}
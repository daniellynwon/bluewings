
namespace SmartMES_Bluewings
{
    partial class P1C03_PROD_DONE_SUB1
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
            this.btncancel = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_COUNT = new System.Windows.Forms.NumericUpDown();
            this.m_SP = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_COUNT)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(166, 116);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(99, 36);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "취소";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(42, 116);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(99, 36);
            this.BtnPrint.TabIndex = 6;
            this.BtnPrint.Text = "인쇄";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "인쇄매수 :";
            // 
            // nud_COUNT
            // 
            this.nud_COUNT.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nud_COUNT.Location = new System.Drawing.Point(133, 40);
            this.nud_COUNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nud_COUNT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_COUNT.Name = "nud_COUNT";
            this.nud_COUNT.Size = new System.Drawing.Size(131, 26);
            this.nud_COUNT.TabIndex = 3;
            this.nud_COUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_COUNT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // P1C03_PROD_DONE_SUB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(303, 192);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_COUNT);
            this.Name = "P1C03_PROD_DONE_SUB1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "바코드 인쇄";
            ((System.ComponentModel.ISupportInitialize)(this.nud_COUNT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_COUNT;
        private System.IO.Ports.SerialPort m_SP;
    }
}
namespace SmartMES_Bluewings
{
    partial class P1D03_MAINTENANCE_SUB_DOC
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
            this.txtPath = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPath.ForeColor = System.Drawing.Color.Gray;
            this.txtPath.Location = new System.Drawing.Point(13, 10);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(799, 44);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "문서명";
            this.txtPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Image = global::SmartMES_Bluewings.Properties.Resources.minus;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(839, 486);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(227, 48);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "닫 기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Image = global::SmartMES_Bluewings.Properties.Resources.ico_No;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(837, 421);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(227, 48);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "삭 제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Image = global::SmartMES_Bluewings.Properties.Resources.saveng;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(837, 291);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 48);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "불러오기";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRun.Image = global::SmartMES_Bluewings.Properties.Resources.ico_Refresh;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(837, 356);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(227, 48);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "파일보기";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCamera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamera.Location = new System.Drawing.Point(837, 57);
            this.btnCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(227, 100);
            this.btnCamera.TabIndex = 3;
            this.btnCamera.Text = "카메라";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapture.Location = new System.Drawing.Point(837, 174);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(227, 100);
            this.btnCapture.TabIndex = 4;
            this.btnCapture.Text = "캡 쳐";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.BackColor = System.Drawing.Color.Teal;
            this.pictureBoxIpl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxIpl1.Location = new System.Drawing.Point(12, 57);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(800, 480);
            this.pictureBoxIpl1.TabIndex = 14;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // P1D03_MAINTENANCE_SUB_DOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 559);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtPath);
            this.Name = "P1D03_MAINTENANCE_SUB_DOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "자료관리";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.P1D03_MAINTENANCE_SUB_DOC_FormClosing);
            this.Load += new System.EventHandler(this.P1D03_MAINTENANCE_SUB_DOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label txtPath;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnRun;
        public System.Windows.Forms.Button btnCamera;
        public System.Windows.Forms.Button btnCapture;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Timer timer1;
    }
}
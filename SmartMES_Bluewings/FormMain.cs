using System;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void llbPwChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PwdChange().ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MDIForm parent = (MDIForm)this.MdiParent;
            if (checkBox1.Checked)
                parent.panel1.Visible = true;
            else
                parent.panel1.Visible = false;
        }
    }
}

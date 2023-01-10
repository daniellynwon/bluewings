using System;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class ViewReport_H : Form
    {
        public ViewReport_H()
        {
            InitializeComponent();
        }

        private void ViewReport_H_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}

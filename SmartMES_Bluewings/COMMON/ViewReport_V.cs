using System;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class ViewReport_V : Form
    {
        public ViewReport_V()
        {
            InitializeComponent();
        }

        private void ViewReport_V_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}

using Microsoft.Win32;//RegistryKey 사용
using System;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class FormNotify : Form
    {
        public FormNotify()
        {
            InitializeComponent();
        }

        private void FormNotify_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblSubject;
        }

        private void ckbToday_Click(object sender, EventArgs e)
        {
            WriteRegistry();
            this.DialogResult = DialogResult.OK;
        }

        public void WriteRegistry()
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey("SoftWare").CreateSubKey("notify");

            reg.SetValue("curDT", DateTime.Today.ToString("yyyy-MM-dd"));
        }
    }
}

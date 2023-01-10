using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class FormBasic : Form
    {
        public FormBasic()
        {
            InitializeComponent();
        }

        private void FormBasic_Load(object sender, EventArgs e)
        {
            AssemblyName name = Assembly.GetExecutingAssembly().GetName();
            lbVersion.Text = "Ver: " + name.Version.ToString();
            lblFormID.Text = this.Name;
            lblUser.Text = G.UserName + "님께서 접속 중 입니다.";

            //MariaCRUD m = new MariaCRUD();
            //m.TransLogCreate(G.Authority, G.UserID, "S", this.Name, lblTitle.Text, lblTitle.Text);

            if (!(G.Authority == "A" || G.Authority == "B" || G.Authority == "C"))
            {
                pbAdd.Image = global::SmartMES_Bluewings.Properties.Resources.add_B;
                pbDel.Image = global::SmartMES_Bluewings.Properties.Resources.del_B;
                pbSave.Image = global::SmartMES_Bluewings.Properties.Resources.save_B;
                pbPrint.Image = global::SmartMES_Bluewings.Properties.Resources.out_B;
                pbAdd.Enabled = false;
                pbDel.Enabled = false;
                pbSave.Enabled = false;
                pbPrint.Enabled = false;
            }
        }

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Location = new Point(pb.Location.X + 2, pb.Location.Y + 2);
        }

        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Location = new Point(pb.Location.X - 2, pb.Location.Y - 2);
        }

        private void pbPrint_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            MariaCRUD m = new MariaCRUD();
            m.TransLogCreate(G.Authority, G.UserID, "P", this.Name, lblTitle.Text, lblTitle.Text);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

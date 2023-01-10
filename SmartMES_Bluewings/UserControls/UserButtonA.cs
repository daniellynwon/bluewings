using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMES_Bluewings
{
    public partial class UserButtonA : UserControl
    {
        public int xPoint;
        public int yPoint;

        [Category("UserProperty"), Description("버튼의 이미지")]
        public Image buttonImage
        {
            get
            {
                return this.BackgroundImage;
            }
            set
            {
                this.BackgroundImage = value;
            }
        }

        public UserButtonA()
        {
            InitializeComponent();
        }

        private void UserButtonA_Load(object sender, EventArgs e)
        {
            xPoint = this.Location.X;
            yPoint = this.Location.Y;
        }

        private void UserButtonA_MouseDown(object sender, MouseEventArgs e)
        {
            this.Location = new Point(xPoint + 2, yPoint + 2);
        }

        private void UserButtonA_MouseUp(object sender, MouseEventArgs e)
        {
            this.Location = new Point(xPoint, yPoint);
        }
    }
}

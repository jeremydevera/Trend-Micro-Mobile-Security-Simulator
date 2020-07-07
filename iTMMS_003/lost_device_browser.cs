using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTMMS_003
{
    public partial class lost_device_browser : Form
    {
        public lost_device_browser()
        {
            InitializeComponent();

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            signin.Parent = pictureBox2;
            signin.BackColor = Color.Transparent;

            findnow.Parent = pictureBox2;
            findnow.BackColor = Color.Transparent;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            lost_device_protection frm = new lost_device_protection();
            this.Hide();
            frm.Show();
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            ldp_page frm = new ldp_page();
            this.Hide();
            frm.Show();
        }

        private void Findnow_Click(object sender, EventArgs e)
        {
            ldp_page frm = new ldp_page();
            this.Hide();
            frm.Show();
        }
    }
}

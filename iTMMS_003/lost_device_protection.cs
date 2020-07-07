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
    public partial class lost_device_protection : Form
    {
        public lost_device_protection()
        {
            InitializeComponent();


            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            lost_device_browser.Parent = pictureBox2;
            lost_device_browser.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Lost_device_browser_Click(object sender, EventArgs e)
        {
            lost_device_browser frm = new lost_device_browser();
            this.Hide();
            frm.Show();
        }
    }
}

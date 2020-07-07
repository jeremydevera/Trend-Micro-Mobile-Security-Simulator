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
    public partial class share : Form
    {
        private Timer tm;
        public share()
        {
            InitializeComponent();

            post.Parent = pictureBox2;
            post.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Post_Click(object sender, EventArgs e)
        {

            loading.Visible = true;
            tm = new Timer();
            tm.Interval = 10 * 380; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick);

          
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once

            lost_device_protection frm = new lost_device_protection();
            this.Hide();
            frm.Show();
        }
    }
}

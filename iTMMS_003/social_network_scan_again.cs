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
    public partial class social_network_scan_again : Form
    {
        private Timer tm;
        public social_network_scan_again()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            checkagain.Parent = pictureBox1;
            checkagain.BackColor = Color.Transparent;

            social_network_twitter.Parent = pictureBox1;
            social_network_twitter.BackColor = Color.Transparent;

            tm = new Timer();
            tm.Interval = 10 * 200; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once

            pictureBox1.Visible = true;
        }

        private void tm_Tick2(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once

            pictureBox1.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Checkagain_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void Checkagain_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            tm = new Timer();
            tm.Interval = 10 * 100; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick2);
        }

        private void Social_network_twitter_Click(object sender, EventArgs e)
        {
            social_network_twitter frm = new social_network_twitter();
            this.Hide();
            frm.Show();
        }
    }
}

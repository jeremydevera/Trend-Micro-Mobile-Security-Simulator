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
    public partial class social_network_facebook : Form
    {
        private Timer tm;
        public social_network_facebook()
        {
            InitializeComponent();


            tm = new Timer();
            tm.Interval = 10 * 300; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick);

            back.Parent = pictureBox3;
            back.BackColor = Color.Transparent;

            social_network_twitter.Parent = pictureBox3;
            social_network_twitter.BackColor = Color.Transparent;

            improve_now.Parent = pictureBox3;
            improve_now.BackColor = Color.Transparent;

            cancel.Parent= pictureBox4;
            cancel.BackColor = Color.Transparent;

            improve.Parent = pictureBox4;
            improve.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once

            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Improve_now_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Improve_Click(object sender, EventArgs e)
        {
            social_network_scan_again frm = new social_network_scan_again();
            this.Hide();
            frm.Show();
        }

        private void Social_network_twitter_Click(object sender, EventArgs e)
        {
            social_network_twitter frm = new social_network_twitter();
            this.Hide();
            frm.Show();
        }
    }
}

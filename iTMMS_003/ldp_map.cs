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
    public partial class ldp_map : Form
    {
        private Timer tm;
        public ldp_map()
        {
            InitializeComponent();

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            alarm.Parent = pictureBox2;
            alarm.BackColor = Color.Transparent;

            refresh.Parent = pictureBox2;
            refresh.BackColor = Color.Transparent;

            share.Parent = pictureBox2;
            share.BackColor = Color.Transparent;

        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once

            popup.Visible = false;
        }

        private void tm_Tick2(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once

            refreshpop.Visible = false;

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

        private void Alarm_Click(object sender, EventArgs e)
        {
            popup.Visible = true;

            tm = new Timer();
            tm.Interval = 10 * 480; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            refreshpop.Visible = true;

            tm = new Timer();
            tm.Interval = 10 * 480; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick2);
        }

        private void Share_Click(object sender, EventArgs e)
        {
            share frm = new share();
            this.Hide();
            frm.Show();
        }
    }
}

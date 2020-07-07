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
    public partial class camera_roll_scanning : Form
    {
        private Timer tm;
        public camera_roll_scanning()
        {
            InitializeComponent();

            back.Parent = scan_another;
            back.BackColor = Color.Transparent;

            scan.Parent = scan_another;
            scan.BackColor = Color.Transparent;

            fraud_buster_imessage.Parent = scan_another;
            fraud_buster_imessage.BackColor = Color.Transparent;

            tm = new Timer();
            tm.Interval = 10 * 180; // 10 seconds
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once

            pictureBox1.Visible = false;
            scan_another.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            camera_roll frm = new camera_roll();
            this.Hide();
            frm.Show();
        }

        private void Fraud_buster_imessage_Click(object sender, EventArgs e)
        {
            fraud_buster_imessage frm = new fraud_buster_imessage();
            this.Hide();
            frm.Show();
        }
    }
}

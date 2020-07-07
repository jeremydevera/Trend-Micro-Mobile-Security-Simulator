using System;
using System.Drawing;
using System.Windows.Forms;

namespace iTMMS_003
{
    public partial class web_guard : Form
    {
        public web_guard()
        {
            InitializeComponent();


            vpn_off.Visible = false;

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            vpn_settings.Parent = pictureBox2;
            vpn_settings.BackColor = Color.Transparent;

            web_guard_blocked.Parent = pictureBox2;
            web_guard_blocked.BackColor = Color.Transparent;

            web_guard_approved.Parent = pictureBox2;
            web_guard_approved.BackColor = Color.Transparent;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Security_report_Click(object sender, EventArgs e)
        {
            vpn_on.Visible = !vpn_on.Visible;
        }

        private void Vpn_on_Click(object sender, EventArgs e)
        {
            vpn_on.Visible = false;
            vpn_off.Visible = true;
        }

        private void Vpn_off_Click(object sender, EventArgs e)
        {
            vpn_on.Visible = true;
            vpn_off.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Vpn_settings_Click(object sender, EventArgs e)
        {
            vpn_settings frm = new vpn_settings();
            this.Hide();
            frm.Show();
        }

        private void Web_guard_blocked_Click(object sender, EventArgs e)
        {
            web_guard_blocked frm = new web_guard_blocked();
            this.Hide();
            frm.Show();
        }

        private void Web_guard_approved_Click(object sender, EventArgs e)
        {
            web_guard_approved frm = new web_guard_approved();
            this.Hide();
            frm.Show();
        }
    }
}

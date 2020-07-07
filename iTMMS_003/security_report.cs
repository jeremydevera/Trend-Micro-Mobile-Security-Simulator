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
    public partial class security_report : Form
    {
        public security_report()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            select.Parent = pictureBox1;
            select.BackColor = Color.Transparent;

            last_seven.Parent = days_dropdown;
            last_seven.BackColor = Color.Transparent;

            last_fourteen.Parent = days_dropdown;
            last_fourteen.BackColor = Color.Transparent;

            last_thirty.Parent = days_dropdown;
            last_thirty.BackColor = Color.Transparent;

            web_guard_browsing.Parent = pictureBox1;
            web_guard_browsing.BackColor = Color.Transparent;

            safe_surfing_activities.Parent = pictureBox1;
            safe_surfing_activities.BackColor = Color.Transparent;

            wifi_network_connections.Parent = pictureBox1;
            wifi_network_connections.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            days.Visible = !days.Visible;
        }

        private void Last_seven_Click(object sender, EventArgs e)
        {
            days.Visible = false;
            report_7.Visible = true;
            report_14.Visible = false;
            report_30.Visible = false;

            badge_seven.Visible = true;
            badge_thirty.Visible = false;
        }

        private void Last_fourteen_Click(object sender, EventArgs e)
        {
            days.Visible = false;
            report_7.Visible = false;
            report_14.Visible = true;
            report_30.Visible = false;

            badge_seven.Visible = false;
            badge_thirty.Visible = false;
        }

        private void Last_thirty_Click(object sender, EventArgs e)
        {
            days.Visible = false;
            report_7.Visible = false;
            report_14.Visible = false;
            report_30.Visible = true;

            badge_seven.Visible = false;
            badge_thirty.Visible = true;
        }

        private void Badge_seven_Click(object sender, EventArgs e)
        {
            days.Visible = !days.Visible;
        }

        private void Badge_thirty_Click(object sender, EventArgs e)
        {
            days.Visible = !days.Visible;
        }

        private void Badge_seven_Click_1(object sender, EventArgs e)
        {
            days.Visible = !days.Visible;
        }

        private void Web_guard_browsing_Click(object sender, EventArgs e)
        {
            web_guard_browsing frm = new web_guard_browsing();
            this.Hide();
            frm.Show();
        }

        private void Safe_surfing_activities_Click(object sender, EventArgs e)
        {
            safe_surfing_activities frm = new safe_surfing_activities();
            this.Hide();
            frm.Show();
        }

        private void Wifi_network_connections_Click(object sender, EventArgs e)
        {
            wifi_network_connections frm = new wifi_network_connections();
            this.Hide();
            frm.Show();
        }
    }
}

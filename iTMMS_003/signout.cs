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
    public partial class signout : Form
    {
        public signout()
        {
            InitializeComponent();

            features.Parent = pictureBox1;
            features.BackColor = Color.Transparent;

            how_webguard.Parent = pictureBox1;
            how_webguard.BackColor = Color.Transparent;

            how_wifi.Parent = pictureBox1;
            how_wifi.BackColor = Color.Transparent;

            webguard.Parent = pictureBox1;
            webguard.BackColor = Color.Transparent;

            safesurfing.Parent = pictureBox1;
            safesurfing.BackColor = Color.Transparent;

            fraudbuster.Parent = pictureBox1;
            fraudbuster.BackColor = Color.Transparent;

            social_network.Parent = pictureBox1;
            social_network.BackColor = Color.Transparent;

            data_usage.Parent = pictureBox1;
            data_usage.BackColor = Color.Transparent;

            ldp.Parent = pictureBox1;
            ldp.BackColor = Color.Transparent;

            wifi_checker.Parent = pictureBox1;
            wifi_checker.BackColor = Color.Transparent;

            device_access.Parent = pictureBox1;
            device_access.BackColor = Color.Transparent;

            settings.Parent = pictureBox1;
            settings.BackColor = Color.Transparent;

            scan.Parent = pictureBox1;
            scan.BackColor = Color.Transparent;

            security_report.Parent = pictureBox1;
            security_report.BackColor = Color.Transparent;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Features_Click(object sender, EventArgs e)
        {
            features frm = new features();
            this.Hide();
            frm.Show();
        }

        private void How_webguard_Click(object sender, EventArgs e)
        {
            how_webguard frm = new how_webguard();
            this.Hide();
            frm.Show();
        }

        private void How_wifi_Click(object sender, EventArgs e)
        {
            how_wifi frm = new how_wifi();
            this.Hide();
            frm.Show();
        }



        private void Buy_or_activate_Click_1(object sender, EventArgs e)
        {
            purchase frm = new purchase();
            this.Hide();
            frm.Show();
        }

        private void Webguard_Click(object sender, EventArgs e)
        {
            purchase frm = new purchase();
            this.Hide();
            frm.Show();
        }

        private void Safesurfing_Click(object sender, EventArgs e)
        {
            purchase frm = new purchase();
            this.Hide();
            frm.Show();
        }

        private void Fraudbuster_Click(object sender, EventArgs e)
        {
            purchase frm = new purchase();
            this.Hide();
            frm.Show();
        }

        private void Social_network_Click(object sender, EventArgs e)
        {
            purchase frm = new purchase();
            this.Hide();
            frm.Show();
        }

        private void Data_usage_Click(object sender, EventArgs e)
        {
            purchase frm = new purchase();
            this.Hide();
            frm.Show();
        }

        private void Ldp_Click(object sender, EventArgs e)
        {
            purchase frm = new purchase();
            this.Hide();
            frm.Show();
        }

        private void Wifi_checker_Click(object sender, EventArgs e)
        {
            wifi_checker frm = new wifi_checker();
            this.Hide();
            frm.Show();
        }

        private void Device_access_Click(object sender, EventArgs e)
        {
            device_access frm = new device_access();
            this.Hide();
            frm.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            signout_settings frm = new signout_settings();
            this.Hide();
            frm.Show();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            signout_scanning frm = new signout_scanning();
            this.Hide();
            frm.Show();
        }

        private void Security_report_Click(object sender, EventArgs e)
        {
            security_report frm = new security_report();
            this.Hide();
            frm.Show();
        }
    }
}

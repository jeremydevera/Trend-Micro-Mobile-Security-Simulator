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
    public partial class iPad : Form
    {
        public iPad()
        {
            InitializeComponent();


            scan.Parent = pictureBox1;
            scan.BackColor = Color.Transparent;

            security_report.Parent = pictureBox1;
            security_report.BackColor = Color.Transparent;

            qr.Parent = pictureBox2;
            qr.BackColor = Color.Transparent;

            web_guard.Parent = pictureBox1;
            web_guard.BackColor = Color.Transparent;

            safe_surfing.Parent = pictureBox1;
            safe_surfing.BackColor = Color.Transparent;

            wifi_checker.Parent = pictureBox1;
            wifi_checker.BackColor = Color.Transparent;

            fraud_buster.Parent = pictureBox1;
            fraud_buster.BackColor = Color.Transparent;

            data_usage.Parent = pictureBox1;
            data_usage.BackColor = Color.Transparent;

            settings.Parent = pictureBox1;
            settings.BackColor = Color.Transparent;

            lost_device_protection.Parent = pictureBox1;
            lost_device_protection.BackColor = Color.Transparent;

            device_access.Parent = pictureBox1;
            device_access.BackColor = Color.Transparent;

            features.Parent = pictureBox1;
            features.BackColor = Color.Transparent;

            social_network.Parent = pictureBox1;
            social_network.BackColor = Color.Transparent;

            how_webguard.Parent = pictureBox1;
            how_webguard.BackColor = Color.Transparent;

            how_wifi.Parent = pictureBox1;
            how_wifi.BackColor = Color.Transparent;
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            scanning frm = new scanning();
            this.Hide();
            frm.Show();
        }

        private void Security_report_Click(object sender, EventArgs e)
        {
            security_report frm = new security_report();
            this.Hide();
            frm.Show();
        }

        private void Qr_Click(object sender, EventArgs e)
        {
            QR frm = new QR();
            this.Hide();
            frm.Show();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {
            web_guard frm = new web_guard();
            this.Hide();
            frm.Show();

        }

        private void Safe_surfing_Click(object sender, EventArgs e)
        {
            safe_surfing frm = new safe_surfing();
            this.Hide();
            frm.Show();
        }

        private void Wifi_checker_Click(object sender, EventArgs e)
        {
            wifi_checker frm = new wifi_checker();
            this.Hide();
            frm.Show();
        }

        private void Fraud_buster_Click(object sender, EventArgs e)
        {
            fraud_buster frm = new fraud_buster();
            this.Hide();
            frm.Show();
        }

        private void Data_usage_Click(object sender, EventArgs e)
        {
            data_usage frm = new data_usage();
            this.Hide();
            frm.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            settings frm = new settings();
            this.Hide();
            frm.Show();
        }

        private void Lost_device_protection_Click(object sender, EventArgs e)
        {
            lost_device_protection frm = new lost_device_protection();
            this.Hide();
            frm.Show();
        }

        private void Device_access_Click(object sender, EventArgs e)
        {
            device_access frm = new device_access();
            this.Hide();
            frm.Show();
        }

        private void Features_Click(object sender, EventArgs e)
        {
            features frm = new features();
            this.Hide();
            frm.Show();
        }

        private void Social_network_Click(object sender, EventArgs e)
        {
            social_network frm = new social_network();
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

        private void More_tools_Click(object sender, EventArgs e)
        {
            more_tools frm = new more_tools();
            this.Hide();
            frm.Show();
        }
    }
}

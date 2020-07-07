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
    public partial class data_usage : Form
    {
        public data_usage()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            data_usage_cellular.Parent = pictureBox1;
            data_usage_cellular.BackColor = Color.Transparent;

            data_usage_wifi.Parent = pictureBox1;
            data_usage_wifi.BackColor = Color.Transparent;

            data_usage_settings.Parent = pictureBox1;
            data_usage_settings.BackColor = Color.Transparent;

            cellular_usage_history.Parent = pictureBox1;
            cellular_usage_history.BackColor = Color.Transparent;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Data_usage_cellular_Click(object sender, EventArgs e)
        {
            data_usage_cellular frm = new data_usage_cellular();
            this.Hide();
            frm.Show();
        }

        private void Data_usage_wifi_Click(object sender, EventArgs e)
        {
            data_usage_wifi frm = new data_usage_wifi();
            this.Hide();
            frm.Show();
        }

        private void Data_usage_settings_Click(object sender, EventArgs e)
        {
            data_usage_settings frm = new data_usage_settings();
            this.Hide();
            frm.Show();
        }

        private void Cellular_usage_history_Click(object sender, EventArgs e)
        {
            cellular_usage_history frm = new cellular_usage_history();
            this.Hide();
            frm.Show();
        }
    }
}

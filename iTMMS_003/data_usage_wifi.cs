﻿using System;
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
    public partial class data_usage_wifi : Form
    {
        public data_usage_wifi()
        {
            InitializeComponent();

            data_usage.Parent = pictureBox1;
            data_usage.BackColor = Color.Transparent;

            data_usage_cellular.Parent = pictureBox1;
            data_usage_cellular.BackColor = Color.Transparent;

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            data_usage_settings.Parent = pictureBox1;
            data_usage_settings.BackColor = Color.Transparent;

            cellular_usage_history.Parent = pictureBox1;
            cellular_usage_history.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Data_usage_Click(object sender, EventArgs e)
        {
            data_usage frm = new data_usage();
            this.Hide();
            frm.Show();
        }

        private void Data_usage_cellular_Click(object sender, EventArgs e)
        {
            data_usage_cellular frm = new data_usage_cellular();
            this.Hide();
            frm.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
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
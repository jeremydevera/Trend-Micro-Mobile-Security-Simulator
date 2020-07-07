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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();


            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            settings_renew_activate.Parent = pictureBox1;
            settings_renew_activate.BackColor = Color.Transparent;

            sign_out.Parent = pictureBox1;
            sign_out.BackColor = Color.Transparent;

            cancel.Parent = pictureBox3;
            cancel.BackColor = Color.Transparent;

            signout_btn.Parent = pictureBox3;
            signout_btn.BackColor = Color.Transparent;

            settings_filter.Parent = pictureBox1;
            sign_out.BackColor = Color.Transparent;

            cellular_data.Parent = pictureBox1;
            cellular_data.BackColor = Color.Transparent;

            roaming_data.Parent = pictureBox1;
            roaming_data.BackColor = Color.Transparent;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Settings_renew_activate_Click(object sender, EventArgs e)
        {
            settings_renew_activate frm = new settings_renew_activate();
            this.Hide();
            frm.Show();
        }

        private void Sign_out_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Settings_filter_Click(object sender, EventArgs e)
        {
            settings_filter frm = new settings_filter();
            this.Hide();
            frm.Show();
        }

        private void Tick_no_Click(object sender, EventArgs e)
        {
            tick_yes.Visible = true;
            tick_no.Visible = false;
        }

        private void Tick_yes_Click(object sender, EventArgs e)
        {
            tick_yes.Visible = false;
            tick_no.Visible = true;
        }

        private void Tick_yes_2_Click(object sender, EventArgs e)
        {
            tick_yes_2.Visible = false;
            tick_no_2.Visible = true;
        }

        private void Tick_no_2_Click(object sender, EventArgs e)
        {
            tick_yes_2.Visible = true;
            tick_no_2.Visible = false;
        }

        private void Tick_no_3_Click(object sender, EventArgs e)
        {
            tick_yes_3.Visible = true;
            tick_no_3.Visible = false;
        }

        private void Tick_yes_3_Click(object sender, EventArgs e)
        {
            tick_yes_3.Visible = false;
            tick_no_3.Visible = true;
        }

        private void Signout_btn_Click(object sender, EventArgs e)
        {
            signout frm = new signout();
            this.Hide();
            frm.Show();
        }

        private void Cellular_data_Click(object sender, EventArgs e)
        {
            cellular_data_settings frm = new cellular_data_settings();
            this.Hide();
            frm.Show();
        }

        private void Roaming_data_Click(object sender, EventArgs e)
        {
            roaming_data_settings frm = new roaming_data_settings();
            this.Hide();
            frm.Show();
        }
    }
}

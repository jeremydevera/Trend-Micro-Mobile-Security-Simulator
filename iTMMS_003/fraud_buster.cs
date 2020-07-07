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
    public partial class fraud_buster : Form
    {
        public fraud_buster()
        {
            InitializeComponent();


            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            imessage.Parent = pictureBox1;
            imessage.BackColor = Color.Transparent;

            camera_roll.Parent = pictureBox1;
            camera_roll.BackColor = Color.Transparent;

            www.Parent = pictureBox1;
            www.BackColor = Color.Transparent;

            cancel.Parent = pictureBox2;
            cancel.BackColor = Color.Transparent;

            scan.Parent = pictureBox2;
            scan.BackColor = Color.Transparent;

            screenshot_settings.Parent = pictureBox1;
            screenshot_settings.BackColor = Color.Transparent;

            close.Parent = pictureBox3;
            close.BackColor = Color.Transparent;

            new_scan.Parent = pictureBox3;
            new_scan.BackColor = Color.Transparent;
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

        private void Imessage_Click(object sender, EventArgs e)
        {
            fraud_buster_imessage frm = new fraud_buster_imessage();
            this.Hide();
            frm.Show();
        }

        private void Camera_roll_Click(object sender, EventArgs e)
        {
            camera_roll frm = new camera_roll();
            this.Hide();
            frm.Show();
        }

        private void Www_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void New_scan_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void Screenshot_settings_Click(object sender, EventArgs e)
        {
            screenshot_settings frm = new screenshot_settings();
            this.Hide();
            frm.Show();
        }

   
    }
}

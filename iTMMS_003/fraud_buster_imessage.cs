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
    public partial class fraud_buster_imessage : Form
    {
        public fraud_buster_imessage()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            fraud_buster_getstarted.Parent = pictureBox1;
            fraud_buster_getstarted.BackColor = Color.Transparent;

            camera_roll.Parent = pictureBox1;
            camera_roll.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Camera_roll_Click(object sender, EventArgs e)
        {
            fraud_buster frm = new fraud_buster();
            this.Hide();
            frm.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Fraud_buster_getstarted_Click(object sender, EventArgs e)
        {
            fraud_buster_getstarted frm = new fraud_buster_getstarted();
            this.Hide();
            frm.Show();
        }
    }
}

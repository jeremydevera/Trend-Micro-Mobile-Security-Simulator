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
    public partial class camera_roll : Form
    {
        public camera_roll()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            camera_roll_scanning.Parent = pictureBox1;
            camera_roll_scanning.BackColor = Color.Transparent;

            no1.Parent = pictureBox1;
            no1.BackColor = Color.Transparent;

            no2.Parent = pictureBox1;
            no2.BackColor = Color.Transparent;

            no3.Parent = pictureBox1;
            no3.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            fraud_buster frm = new fraud_buster();
            this.Hide();
            frm.Show();
        }

        private void Camera_roll_scanning_Click(object sender, EventArgs e)
        {
            camera_roll_scanning frm = new camera_roll_scanning();
            this.Hide();
            frm.Show();
        }
    }
}

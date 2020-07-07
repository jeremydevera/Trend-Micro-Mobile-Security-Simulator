using System;
using System.Drawing;
using System.Windows.Forms;

namespace iTMMS_003
{
    public partial class social_network : Form
    {
        public social_network()
        {
            InitializeComponent();


            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            signin_facebook.Parent = pictureBox1;
            signin_facebook.BackColor = Color.Transparent;

            twitter.Parent = pictureBox1;
            twitter.BackColor = Color.Transparent;
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

        private void Signin_facebook_Click(object sender, EventArgs e)
        {
            signin_facebook frm = new signin_facebook();
            this.Hide();
            frm.Show();
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            social_network_twitter frm = new social_network_twitter();
            this.Hide();
            frm.Show();
        }
    }
}

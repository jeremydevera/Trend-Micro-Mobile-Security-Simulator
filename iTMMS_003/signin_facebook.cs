using System;
using System.Drawing;
using System.Windows.Forms;

namespace iTMMS_003
{
    public partial class signin_facebook : Form
    {
        public signin_facebook()
        {
            InitializeComponent();

            login.Parent = pictureBox1;
            login.BackColor = Color.Transparent;

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            social_network frm = new social_network();
            this.Hide();
            frm.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            social_network_facebook frm = new social_network_facebook();
            this.Hide();
            frm.Show();
        }
    }
}

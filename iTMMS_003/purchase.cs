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
    public partial class purchase : Form
    {
        public purchase()
        {
            InitializeComponent();

            signin.Parent = pictureBox2;
            signin.BackColor = Color.Transparent;

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            activate frm = new activate();
            this.Hide();
            frm.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            signout frm = new signout();
            this.Hide();
            frm.Show();
        }
    }
}

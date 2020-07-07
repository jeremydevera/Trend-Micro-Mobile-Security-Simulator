using System;
using System.Drawing;
using System.Windows.Forms;

namespace iTMMS_003
{
    public partial class test_webguard : Form
    {
        public test_webguard()
        {
            InitializeComponent();


            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            back_2.Parent = pictureBox1;
            back_2.BackColor = Color.Transparent;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            how_webguard frm = new how_webguard();
            this.Hide();
            frm.Show();
        }

        private void Back_2_Click(object sender, EventArgs e)
        {
            how_webguard frm = new how_webguard();
            this.Hide();
            frm.Show();
        }
    }
}

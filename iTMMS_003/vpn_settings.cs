using System;
using System.Drawing;
using System.Windows.Forms;

namespace iTMMS_003
{
    public partial class vpn_settings : Form
    {
        public vpn_settings()
        {
            InitializeComponent();

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            parental_controls.Parent = pictureBox2;
            parental_controls.BackColor = Color.Transparent;

            web_safe.Parent = pictureBox2;
            web_safe.BackColor = Color.Transparent;

            select.Parent = pictureBox2;
            select.BackColor = Color.Transparent;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Back_Click(object sender, EventArgs e)
        {

            web_guard frm = new web_guard();
            this.Hide();
            frm.Show();
        }

        private void Parental_controls_Click(object sender, EventArgs e)
        {
            custom.Visible = true;
            check1.Visible = false;
            check2.Visible = true;
            uncheck2.Visible = false;
            uncheck1.Visible = true;
        }

        private void Web_safe_Click(object sender, EventArgs e)
        {
            custom.Visible = false;
            check1.Visible = true;
            check2.Visible = false;
            uncheck2.Visible = false;
            uncheck1.Visible = false;
        }

        private void Select_Click(object sender, EventArgs e)
        {
            parental_controls frm = new parental_controls();
            this.Hide();
            frm.Show();
        }
    }
}

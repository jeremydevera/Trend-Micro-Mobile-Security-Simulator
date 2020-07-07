using System;
using System.Drawing;
using System.Windows.Forms;

namespace iTMMS_003
{
    public partial class wifi_checker : Form
    {
        public wifi_checker()
        {
            InitializeComponent();


            test_popup.Visible = false;

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            settings.Parent = pictureBox1;
            settings.BackColor = Color.Transparent;

            turn_on.Parent = pictureBox1;
            turn_on.BackColor = Color.Transparent;

            question.Parent = pictureBox1;
            turn_on.BackColor = Color.Transparent;
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

        private void Turn_on_Click(object sender, EventArgs e)
        {
            no_risk_panel.Visible = true;
        }

        private void Question_Click(object sender, EventArgs e)
        {
            test_popup.Visible = !test_popup.Visible;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            settings frm = new settings();
            this.Hide();
            frm.Show();
        }

        private void Unsecure_wifi_Click(object sender, EventArgs e)
        {

        }

        private void Test_popup_Click(object sender, EventArgs e)
        {
            how_wifi frm = new how_wifi();
            this.Hide();
            frm.Show();
        }
    }
}

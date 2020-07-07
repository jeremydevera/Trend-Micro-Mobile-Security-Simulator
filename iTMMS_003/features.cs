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
    public partial class features : Form
    {
        public features()
        {
            InitializeComponent();

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            how_webguard.Parent = pictureBox1;
            how_webguard.BackColor = Color.Transparent;

            wifi_checker.Parent = pictureBox1;
            wifi_checker.BackColor = Color.Transparent;

            content_blocker.Parent = pictureBox1;
            content_blocker.BackColor = Color.Transparent;

            content_blocker2.Parent = pictureBox1;
            content_blocker2.BackColor = Color.Transparent;

            content_blocker3.Parent = pictureBox1;
            content_blocker3.BackColor = Color.Transparent;

            content_blocker4.Parent = pictureBox1;
            content_blocker4.BackColor = Color.Transparent;

            content_blocker5.Parent = pictureBox1;
            content_blocker5.BackColor = Color.Transparent;

            content_blocker6.Parent = pictureBox1;
            content_blocker6.BackColor = Color.Transparent;

            content_blocker7.Parent = pictureBox1;
            content_blocker7.BackColor = Color.Transparent;
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

        private void How_webguard_Click(object sender, EventArgs e)
        {
            how_webguard frm = new how_webguard();
            this.Hide();
            frm.Show();
        }

        private void Wifi_checker_Click(object sender, EventArgs e)
        {
            how_wifi frm = new how_wifi();
            this.Hide();
            frm.Show();
        }

        private void Content_blocker_Click(object sender, EventArgs e)
        {
            feature_content_blocker frm = new feature_content_blocker();
            this.Hide();
            frm.Show();
        }

        private void Content_blocker2_Click(object sender, EventArgs e)
        {
            feature_content_blocker2 frm = new feature_content_blocker2();
            this.Hide();
            frm.Show();
        }

        private void Content_blocker3_Click(object sender, EventArgs e)
        {
            feature_content_blocker3 frm = new feature_content_blocker3();
            this.Hide();
            frm.Show();
        }

        private void Content_blocker4_Click(object sender, EventArgs e)
        {
            feature_content_blocker4 frm = new feature_content_blocker4();
            this.Hide();
            frm.Show();
        }

        private void Content_blocker5_Click(object sender, EventArgs e)
        {
            feature_content_blocker5 frm = new feature_content_blocker5();
            this.Hide();
            frm.Show();
        }

        private void Content_blocker6_Click(object sender, EventArgs e)
        {
            feature_content_blocker6 frm = new feature_content_blocker6();
            this.Hide();
            frm.Show();
        }

        private void Content_blocker7_Click(object sender, EventArgs e)
        {
            feature_content_blocker7 frm = new feature_content_blocker7();
            this.Hide();
            frm.Show();
        }
    }
}

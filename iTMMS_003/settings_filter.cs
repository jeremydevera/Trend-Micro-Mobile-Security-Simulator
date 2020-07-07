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
    public partial class settings_filter : Form
    {
        public settings_filter()
        {
            InitializeComponent();


            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            level_1.Parent = pictureBox1;
            level_1.BackColor = Color.Transparent;

            level_2.Parent = pictureBox1;
            level_2.BackColor = Color.Transparent;

            level_3.Parent = pictureBox1;
            level_3.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            settings frm = new settings();
            this.Hide();
            frm.Show();
        }

        private void Level_1_Click(object sender, EventArgs e)
        {
            high.Visible = true;
            normal.Visible = false;
            low.Visible = false;

            check_1.Visible = true;
            check_2.Visible = false;
            check_3.Visible = false;
        }

        private void Level_2_Click(object sender, EventArgs e)
        {
            high.Visible = false;
            normal.Visible = true;
            low.Visible = false;

            check_2.Visible = true;
            check_1.Visible = false;
            check_3.Visible = false;
        }

        private void Level_3_Click(object sender, EventArgs e)
        {
            high.Visible = false;
            normal.Visible = false;
            low.Visible = true;

            check_3.Visible = true;
            check_1.Visible = false;
            check_2.Visible = false;
        }
    }
}

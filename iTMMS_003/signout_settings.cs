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
    public partial class signout_settings : Form
    {
        public signout_settings()
        {
            InitializeComponent();

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            settings_filter.Parent = pictureBox1;
            settings_filter.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            signout frm = new signout();
            this.Hide();
            frm.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
            activate frm = new activate();
            this.Hide();
            frm.Show();
        }

        private void Settings_filter_Click(object sender, EventArgs e)
        {
            purchase frm = new purchase();
            this.Hide();
            frm.Show();
        }
    }
}

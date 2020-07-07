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
    public partial class screenshot_settings : Form
    {
        public screenshot_settings()
        {
            InitializeComponent();
            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;
        }

        private void Tick_no_Click(object sender, EventArgs e)
        {
            tick_yes.Visible = true;
            tick_no.Visible = false;
        }

        private void Tick_yes_Click(object sender, EventArgs e)
        {
            tick_yes.Visible = false;
            tick_no.Visible = true;
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
    }
}

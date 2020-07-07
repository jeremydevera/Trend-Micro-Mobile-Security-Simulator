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
    public partial class data_plan : Form
    {
        public data_plan()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            cellular_data_settings frm = new cellular_data_settings();
            this.Hide();
            frm.Show();
        }

        private void Switch_on_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            switch_off.Visible = true;
        }

        private void Switch_off_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            switch_off.Visible = false;
        }
    }
}

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
    public partial class ldp_page : Form
    {
        public ldp_page()
        {
            InitializeComponent();

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            singin.Parent = pictureBox2;
            singin.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            lost_device_protection frm = new lost_device_protection();
            this.Hide();
            frm.Show();
        }

        private void Singin_Click(object sender, EventArgs e)
        {
            ldp_map frm = new ldp_map();
            this.Hide();
            frm.Show();
        }
    }
}

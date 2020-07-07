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
    public partial class password_manager : Form
    {
        public password_manager()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            back2.Parent = pictureBox1;
            back2.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            more_tools frm = new more_tools();
            this.Hide();
            frm.Show();
        }

        private void Back2_Click(object sender, EventArgs e)
        {
            more_tools frm = new more_tools();
            this.Hide();
            frm.Show();
        }
    }
}

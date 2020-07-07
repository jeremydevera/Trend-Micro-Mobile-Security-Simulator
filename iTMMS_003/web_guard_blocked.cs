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
    public partial class web_guard_blocked : Form
    {
        public web_guard_blocked()
        {
            InitializeComponent();

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;
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
    }
}

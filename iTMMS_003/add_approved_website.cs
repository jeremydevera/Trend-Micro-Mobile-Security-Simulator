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
    public partial class add_approved_website : Form
    {
        public add_approved_website()
        {
            InitializeComponent();

            cancel.Parent = pictureBox2;
            cancel.BackColor = Color.Transparent;

            add.Parent = pictureBox2;
            add.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            web_guard_approved frm = new web_guard_approved();
            this.Hide();
            frm.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            web_guard_approved frm = new web_guard_approved();
            this.Hide();
            frm.Show();
        }
    }
}

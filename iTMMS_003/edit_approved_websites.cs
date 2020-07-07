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
    public partial class edit_approved_websites : Form
    {
        public edit_approved_websites()
        {
            InitializeComponent();

            cancel.Parent = pictureBox2;
            cancel.BackColor = Color.Transparent;

            delete_all.Parent = pictureBox2;
            delete_all.BackColor = Color.Transparent;

            cancel_box.Parent = pictureBox1;
            cancel_box.BackColor = Color.Transparent;

            remove.Parent = pictureBox1;
            remove.BackColor = Color.Transparent;
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

        private void Delete_all_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Cancel_box_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            web_guard_approved frm = new web_guard_approved();
            this.Hide();
            frm.Show();
        }
    }
}

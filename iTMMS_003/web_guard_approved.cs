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
    public partial class web_guard_approved : Form
    {
        public web_guard_approved()
        {
            InitializeComponent();

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            add_website.Parent = pictureBox2;
            add_website.BackColor = Color.Transparent;

            cancel.Parent = prompt;
            cancel.BackColor = Color.Transparent;

            add_manually.Parent = prompt;
            add_manually.BackColor = Color.Transparent;

            edit.Parent = pictureBox2;
            edit.BackColor = Color.Transparent;
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

        private void Add_website_Click(object sender, EventArgs e)
        {
            prompt_panel.Visible = true;
        }

  

        private void Cancel_Click(object sender, EventArgs e)
        {
            prompt_panel.Visible = false;
        }

        private void Add_manually_Click(object sender, EventArgs e)
        {
            add_approved_website frm = new add_approved_website();
            this.Hide();
            frm.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            edit_approved_websites frm = new edit_approved_websites();
            this.Hide();
            frm.Show();
        }
    }
}

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
    public partial class cellular_usage_history : Form
    {
        public cellular_usage_history()
        {
            InitializeComponent();

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            year.Parent = monthly_img;
            year.BackColor = Color.Transparent;

            month.Parent = yearly_img;
            month.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            data_usage frm = new data_usage();
            this.Hide();
            frm.Show();
        }

        private void Year_Click(object sender, EventArgs e)
        {
            monthly_panel.Visible = false;
            yearly_panel.Visible = true;
        }

        private void Month_Click(object sender, EventArgs e)
        {
            yearly_panel.Visible = false;
            monthly_panel.Visible = true;
        }
    }
}

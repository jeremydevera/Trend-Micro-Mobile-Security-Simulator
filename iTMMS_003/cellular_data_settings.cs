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
    public partial class cellular_data_settings : Form
    {
        public cellular_data_settings()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            data_plan.Parent = pictureBox1;
            data_plan.BackColor = Color.Transparent;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            settings frm = new settings();
            this.Hide();
            frm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Data_plan_Click(object sender, EventArgs e)
        {
            data_plan frm = new data_plan();
            this.Hide();
            frm.Show();
        }
    }
}

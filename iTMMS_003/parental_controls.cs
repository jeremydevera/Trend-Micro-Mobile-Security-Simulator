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
    public partial class parental_controls : Form
    {
        public parental_controls()
        {
            InitializeComponent();

            back.Parent = pictureBox2;
            back.BackColor = Color.Transparent;

            select_1.Parent = pictureBox1;
            select_1.BackColor = Color.Transparent;

            seelct_2.Parent = pictureBox1;
            seelct_2.BackColor = Color.Transparent;

            select_3.Parent = pictureBox1;
            select_3.BackColor = Color.Transparent;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Select_1_Click(object sender, EventArgs e)
        {
            teen.Visible = true;
            preteen.Visible = false;
            child.Visible = false;
            custom.Visible = false;

            check_1.Visible = true;
            check_2.Visible = false;
            check_3.Visible = false;
            check_4.Visible = false;
        }

        private void Seelct_2_Click(object sender, EventArgs e)
        {
            uncheck_1.Visible = true;
            check_1.Visible = false;
            check_2.Visible = true;
            check_3.Visible = false;
            check_4.Visible = false;

            teen.Visible = false;
            preteen.Visible = true;
            child.Visible = false;
            custom.Visible = false;
        }

        private void Select_3_Click(object sender, EventArgs e)
        {
            uncheck_1.Visible = true;
            check_1.Visible = false;
            check_2.Visible = false;
            check_3.Visible = true;
            check_4.Visible = false;

            teen.Visible = false;
            preteen.Visible = false;
            child.Visible = true;
            custom.Visible = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            uncheck_1.Visible = true;
            check_1.Visible = false;
            check_2.Visible = false;
            check_3.Visible = false;
            check_4.Visible = true;

            teen.Visible = false;
            preteen.Visible = false;
            child.Visible = false;
            custom.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            vpn_settings frm = new vpn_settings();
            this.Hide();
            frm.Show();
        }
    }
}

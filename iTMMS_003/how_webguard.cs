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
    public partial class how_webguard : Form
    {
        public how_webguard()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            close.Parent = pictureBox1;
            close.BackColor = Color.Transparent;

            test_webguard.Parent = pictureBox1;
            test_webguard.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Test_webguard_Click(object sender, EventArgs e)
        {
            test_webguard frm = new test_webguard();
            this.Hide();
            frm.Show();
        }
    }
}

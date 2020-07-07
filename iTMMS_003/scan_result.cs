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
    public partial class scan_result : Form
    {
        public scan_result()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;

            scan_again.Parent = pictureBox1;
            scan_again.BackColor = Color.Transparent;
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

        private void Scan_again_Click(object sender, EventArgs e)
        {
            scanning frm = new scanning();
            this.Hide();
            frm.Show();
        }
    }
}

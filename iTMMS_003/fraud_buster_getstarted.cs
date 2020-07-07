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
    public partial class fraud_buster_getstarted : Form
    {
        public fraud_buster_getstarted()
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
            fraud_buster_imessage frm = new fraud_buster_imessage();
            this.Hide();
            frm.Show();
        }
    }
}

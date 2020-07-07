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
    public partial class how_wifi : Form
    {
        public how_wifi()
        {
            InitializeComponent();

            close.Parent = pictureBox1;
            close.BackColor = Color.Transparent;

            experience.Parent = pictureBox1;
            experience.BackColor = Color.Transparent;

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Close_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Experience_Click(object sender, EventArgs e)
        {
            experience_wifi frm = new experience_wifi();
            this.Hide();
            frm.Show();
        }
    }
}

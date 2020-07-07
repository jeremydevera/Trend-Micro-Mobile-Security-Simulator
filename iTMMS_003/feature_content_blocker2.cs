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
    public partial class feature_content_blocker2 : Form
    {
        public feature_content_blocker2()
        {
            InitializeComponent();

            back.Parent = pictureBox1;
            back.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            features frm = new features();
            this.Hide();
            frm.Show();
        }
    }
}

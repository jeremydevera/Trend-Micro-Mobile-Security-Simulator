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
    public partial class buy_or_activate : Form
    {
        public buy_or_activate()
        {
            InitializeComponent();

            activate.Parent = pictureBox1;
            activate.BackColor = Color.Transparent;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            activate frm = new activate();
            this.Hide();
            frm.Show();
        }
    }
}

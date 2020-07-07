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
    public partial class feature_content_blocker4 : Form
    {
        private Timer tm;
        public feature_content_blocker4()
        {
            InitializeComponent();

            tm = new Timer();
            tm.Interval = 10 * 350; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick);
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            features frm = new features();
            this.Hide();
            frm.Show();
        }
    }
}

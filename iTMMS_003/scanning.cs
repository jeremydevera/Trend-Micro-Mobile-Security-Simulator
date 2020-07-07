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
    public partial class scanning : Form
    {
        private Timer tm;

        public scanning()
        {
            InitializeComponent();

            tm = new Timer();
            tm.Interval = 10 * 180; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick);
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            tm.Stop();
            this.Hide();
            frm.Show();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once

            scan_result frm = new scan_result();
            frm.Show();
            this.Hide();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            tm.Stop();
            this.Hide();
            frm.Show();
        }
    }
}

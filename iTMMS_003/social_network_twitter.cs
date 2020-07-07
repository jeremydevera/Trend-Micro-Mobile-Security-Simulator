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
    public partial class social_network_twitter : Form
    {
        private Timer tm;
        public social_network_twitter()
        {
            InitializeComponent();

            back.Parent = pictureBox4;
            back.BackColor = Color.Transparent;

            improve_now.Parent = pictureBox4;
            improve_now.BackColor = Color.Transparent;

            label1.Parent = pictureBox4;
            label1.BackColor = Color.Transparent;

            tm = new Timer();
            tm.Interval = 10 * 100; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick);
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once
            pictureBox3.Visible = false;
            pictureBox1.Visible = true;
            tm = new Timer();
            tm.Interval = 10 * 100; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick2);
        }

        private void tm_Tick2(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once
            pictureBox1.Visible = false;
            pictureBox4.Visible = true;
        }

        private void tm_Tick3(object sender, EventArgs e)
        {
            tm.Stop(); // so that we only fire the timer message once
            pictureBox1.Visible = false;
            pictureBox4.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            iPad frm = new iPad();
            this.Hide();
            frm.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            social_network_facebook frm = new social_network_facebook();
            this.Hide();
            frm.Show();
        }

        private void Improve_now_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox1.Visible = true;
            tm = new Timer();
            tm.Interval = 10 * 100; // 10 seconds
            tm.Start();
            tm.Tick += new EventHandler(tm_Tick3);

           
        }
    }
}

namespace iTMMS_003
{
    partial class web_guard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(web_guard));
            this.vpn_on = new System.Windows.Forms.PictureBox();
            this.security_report = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vpn_off = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.vpn_settings = new System.Windows.Forms.Label();
            this.web_guard_blocked = new System.Windows.Forms.Label();
            this.web_guard_approved = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vpn_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpn_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vpn_on
            // 
            this.vpn_on.BackColor = System.Drawing.Color.Transparent;
            this.vpn_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vpn_on.Image = ((System.Drawing.Image)(resources.GetObject("vpn_on.Image")));
            this.vpn_on.Location = new System.Drawing.Point(259, 67);
            this.vpn_on.Name = "vpn_on";
            this.vpn_on.Size = new System.Drawing.Size(269, 267);
            this.vpn_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vpn_on.TabIndex = 0;
            this.vpn_on.TabStop = false;
            this.vpn_on.Click += new System.EventHandler(this.Vpn_on_Click);
            // 
            // security_report
            // 
            this.security_report.AutoSize = true;
            this.security_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.security_report.Location = new System.Drawing.Point(580, 100);
            this.security_report.Name = "security_report";
            this.security_report.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.security_report.Size = new System.Drawing.Size(20, 23);
            this.security_report.TabIndex = 6;
            this.security_report.Click += new System.EventHandler(this.Security_report_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 590);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // vpn_off
            // 
            this.vpn_off.BackColor = System.Drawing.Color.Transparent;
            this.vpn_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vpn_off.Image = ((System.Drawing.Image)(resources.GetObject("vpn_off.Image")));
            this.vpn_off.Location = new System.Drawing.Point(258, 66);
            this.vpn_off.Name = "vpn_off";
            this.vpn_off.Size = new System.Drawing.Size(269, 267);
            this.vpn_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vpn_off.TabIndex = 8;
            this.vpn_off.TabStop = false;
            this.vpn_off.Click += new System.EventHandler(this.Vpn_off_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 23);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(20, 23);
            this.back.TabIndex = 9;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // vpn_settings
            // 
            this.vpn_settings.AutoSize = true;
            this.vpn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vpn_settings.Location = new System.Drawing.Point(12, 370);
            this.vpn_settings.Name = "vpn_settings";
            this.vpn_settings.Padding = new System.Windows.Forms.Padding(750, 30, 0, 0);
            this.vpn_settings.Size = new System.Drawing.Size(750, 43);
            this.vpn_settings.TabIndex = 10;
            this.vpn_settings.Click += new System.EventHandler(this.Vpn_settings_Click);
            // 
            // web_guard_blocked
            // 
            this.web_guard_blocked.AutoSize = true;
            this.web_guard_blocked.Cursor = System.Windows.Forms.Cursors.Hand;
            this.web_guard_blocked.Location = new System.Drawing.Point(12, 426);
            this.web_guard_blocked.Name = "web_guard_blocked";
            this.web_guard_blocked.Padding = new System.Windows.Forms.Padding(750, 30, 0, 0);
            this.web_guard_blocked.Size = new System.Drawing.Size(750, 43);
            this.web_guard_blocked.TabIndex = 11;
            this.web_guard_blocked.Click += new System.EventHandler(this.Web_guard_blocked_Click);
            // 
            // web_guard_approved
            // 
            this.web_guard_approved.AutoSize = true;
            this.web_guard_approved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.web_guard_approved.Location = new System.Drawing.Point(12, 480);
            this.web_guard_approved.Name = "web_guard_approved";
            this.web_guard_approved.Padding = new System.Windows.Forms.Padding(750, 30, 0, 0);
            this.web_guard_approved.Size = new System.Drawing.Size(750, 43);
            this.web_guard_approved.TabIndex = 12;
            this.web_guard_approved.Click += new System.EventHandler(this.Web_guard_approved_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // web_guard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.web_guard_approved);
            this.Controls.Add(this.web_guard_blocked);
            this.Controls.Add(this.vpn_settings);
            this.Controls.Add(this.back);
            this.Controls.Add(this.vpn_off);
            this.Controls.Add(this.vpn_on);
            this.Controls.Add(this.security_report);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "web_guard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.vpn_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpn_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vpn_on;
        private System.Windows.Forms.Label security_report;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox vpn_off;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label vpn_settings;
        private System.Windows.Forms.Label web_guard_blocked;
        private System.Windows.Forms.Label web_guard_approved;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
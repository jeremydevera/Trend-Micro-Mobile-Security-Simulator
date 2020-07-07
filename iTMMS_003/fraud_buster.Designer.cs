namespace iTMMS_003
{
    partial class fraud_buster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fraud_buster));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.imessage = new System.Windows.Forms.Label();
            this.camera_roll = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.new_scan = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Label();
            this.www = new System.Windows.Forms.Label();
            this.screenshot_settings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 590);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 22);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(20, 23);
            this.back.TabIndex = 10;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // imessage
            // 
            this.imessage.AutoSize = true;
            this.imessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imessage.Location = new System.Drawing.Point(402, 56);
            this.imessage.Name = "imessage";
            this.imessage.Padding = new System.Windows.Forms.Padding(370, 25, 0, 0);
            this.imessage.Size = new System.Drawing.Size(370, 38);
            this.imessage.TabIndex = 13;
            this.imessage.Click += new System.EventHandler(this.Imessage_Click);
            // 
            // camera_roll
            // 
            this.camera_roll.AutoSize = true;
            this.camera_roll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.camera_roll.Location = new System.Drawing.Point(317, 143);
            this.camera_roll.Name = "camera_roll";
            this.camera_roll.Padding = new System.Windows.Forms.Padding(150, 120, 0, 0);
            this.camera_roll.Size = new System.Drawing.Size(150, 133);
            this.camera_roll.TabIndex = 14;
            this.camera_roll.Click += new System.EventHandler(this.Camera_roll_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 590);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scan);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 590);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // scan
            // 
            this.scan.AutoSize = true;
            this.scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scan.Location = new System.Drawing.Point(417, 208);
            this.scan.Name = "scan";
            this.scan.Padding = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.scan.Size = new System.Drawing.Size(50, 23);
            this.scan.TabIndex = 20;
            this.scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.new_scan);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 590);
            this.panel2.TabIndex = 19;
            this.panel2.Visible = false;
            // 
            // new_scan
            // 
            this.new_scan.AutoSize = true;
            this.new_scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_scan.Location = new System.Drawing.Point(402, 294);
            this.new_scan.Name = "new_scan";
            this.new_scan.Padding = new System.Windows.Forms.Padding(90, 10, 0, 0);
            this.new_scan.Size = new System.Drawing.Size(90, 23);
            this.new_scan.TabIndex = 19;
            this.new_scan.Click += new System.EventHandler(this.New_scan_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(295, 294);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(90, 10, 0, 0);
            this.close.Size = new System.Drawing.Size(90, 23);
            this.close.TabIndex = 18;
            this.close.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(785, 590);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Location = new System.Drawing.Point(315, 208);
            this.cancel.Name = "cancel";
            this.cancel.Padding = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.cancel.Size = new System.Drawing.Size(50, 23);
            this.cancel.TabIndex = 18;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // www
            // 
            this.www.AutoSize = true;
            this.www.Cursor = System.Windows.Forms.Cursors.Hand;
            this.www.Location = new System.Drawing.Point(743, 133);
            this.www.Name = "www";
            this.www.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.www.Size = new System.Drawing.Size(20, 23);
            this.www.TabIndex = 17;
            this.www.Click += new System.EventHandler(this.Www_Click);
            // 
            // screenshot_settings
            // 
            this.screenshot_settings.AutoSize = true;
            this.screenshot_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screenshot_settings.Location = new System.Drawing.Point(12, 399);
            this.screenshot_settings.Name = "screenshot_settings";
            this.screenshot_settings.Padding = new System.Windows.Forms.Padding(180, 20, 0, 0);
            this.screenshot_settings.Size = new System.Drawing.Size(180, 33);
            this.screenshot_settings.TabIndex = 18;
            this.screenshot_settings.Click += new System.EventHandler(this.Screenshot_settings_Click);
            // 
            // fraud_buster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.screenshot_settings);
            this.Controls.Add(this.www);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.camera_roll);
            this.Controls.Add(this.imessage);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fraud_buster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label imessage;
        private System.Windows.Forms.Label camera_roll;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label www;
        private System.Windows.Forms.Label cancel;
        private System.Windows.Forms.Label scan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label new_scan;
        private System.Windows.Forms.Label screenshot_settings;
    }
}
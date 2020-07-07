namespace iTMMS_003
{
    partial class lost_device_protection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lost_device_protection));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.lost_device_browser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 590);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
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
            // lost_device_browser
            // 
            this.lost_device_browser.AutoSize = true;
            this.lost_device_browser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lost_device_browser.Location = new System.Drawing.Point(236, 203);
            this.lost_device_browser.Name = "lost_device_browser";
            this.lost_device_browser.Padding = new System.Windows.Forms.Padding(155, 10, 0, 0);
            this.lost_device_browser.Size = new System.Drawing.Size(155, 23);
            this.lost_device_browser.TabIndex = 11;
            this.lost_device_browser.Click += new System.EventHandler(this.Lost_device_browser_Click);
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
            // lost_device_protection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lost_device_browser);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "lost_device_protection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label lost_device_browser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
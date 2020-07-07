namespace iTMMS_003
{
    partial class lost_device_browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lost_device_browser));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Label();
            this.findnow = new System.Windows.Forms.Label();
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
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(6, 1);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(100, 23);
            this.back.TabIndex = 11;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // signin
            // 
            this.signin.AutoSize = true;
            this.signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin.Location = new System.Drawing.Point(692, 80);
            this.signin.Name = "signin";
            this.signin.Padding = new System.Windows.Forms.Padding(70, 10, 0, 0);
            this.signin.Size = new System.Drawing.Size(70, 23);
            this.signin.TabIndex = 12;
            this.signin.Click += new System.EventHandler(this.Signin_Click);
            // 
            // findnow
            // 
            this.findnow.AutoSize = true;
            this.findnow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findnow.Location = new System.Drawing.Point(27, 346);
            this.findnow.Name = "findnow";
            this.findnow.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.findnow.Size = new System.Drawing.Size(100, 33);
            this.findnow.TabIndex = 13;
            this.findnow.Click += new System.EventHandler(this.Findnow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lost_device_browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.findnow);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "lost_device_browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label signin;
        private System.Windows.Forms.Label findnow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
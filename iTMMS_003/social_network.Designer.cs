namespace iTMMS_003
{
    partial class social_network
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(social_network));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.signin_facebook = new System.Windows.Forms.Label();
            this.twitter = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 590);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 23);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(20, 23);
            this.back.TabIndex = 12;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // signin_facebook
            // 
            this.signin_facebook.AutoSize = true;
            this.signin_facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_facebook.Location = new System.Drawing.Point(57, 471);
            this.signin_facebook.Name = "signin_facebook";
            this.signin_facebook.Padding = new System.Windows.Forms.Padding(680, 40, 0, 0);
            this.signin_facebook.Size = new System.Drawing.Size(680, 53);
            this.signin_facebook.TabIndex = 13;
            this.signin_facebook.Click += new System.EventHandler(this.Signin_facebook_Click);
            // 
            // twitter
            // 
            this.twitter.AutoSize = true;
            this.twitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twitter.Location = new System.Drawing.Point(395, 54);
            this.twitter.Name = "twitter";
            this.twitter.Padding = new System.Windows.Forms.Padding(390, 30, 0, 0);
            this.twitter.Size = new System.Drawing.Size(390, 43);
            this.twitter.TabIndex = 14;
            this.twitter.Click += new System.EventHandler(this.Twitter_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // social_network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.twitter);
            this.Controls.Add(this.signin_facebook);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "social_network";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label signin_facebook;
        private System.Windows.Forms.Label twitter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
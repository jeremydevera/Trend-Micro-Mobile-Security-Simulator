namespace iTMMS_003
{
    partial class how_wifi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(how_wifi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.experience = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(746, 29);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.close.Size = new System.Drawing.Size(20, 23);
            this.close.TabIndex = 15;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // experience
            // 
            this.experience.AutoSize = true;
            this.experience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.experience.Location = new System.Drawing.Point(17, 499);
            this.experience.Name = "experience";
            this.experience.Padding = new System.Windows.Forms.Padding(750, 40, 0, 0);
            this.experience.Size = new System.Drawing.Size(750, 53);
            this.experience.TabIndex = 16;
            this.experience.Click += new System.EventHandler(this.Experience_Click);
            // 
            // how_wifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.close);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "how_wifi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label experience;
    }
}
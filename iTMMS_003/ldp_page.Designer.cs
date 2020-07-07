namespace iTMMS_003
{
    partial class ldp_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ldp_page));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.singin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 590);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(4, -2);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(100, 23);
            this.back.TabIndex = 12;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // singin
            // 
            this.singin.AutoSize = true;
            this.singin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singin.Location = new System.Drawing.Point(243, 346);
            this.singin.Name = "singin";
            this.singin.Padding = new System.Windows.Forms.Padding(100, 20, 0, 0);
            this.singin.Size = new System.Drawing.Size(100, 33);
            this.singin.TabIndex = 13;
            this.singin.Click += new System.EventHandler(this.Singin_Click);
            // 
            // ldp_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.singin);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ldp_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label singin;
    }
}
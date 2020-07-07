namespace iTMMS_003
{
    partial class how_webguard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(how_webguard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.test_webguard = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(9, 22);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(20, 23);
            this.back.TabIndex = 13;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(752, 70);
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.close.Size = new System.Drawing.Size(20, 23);
            this.close.TabIndex = 14;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // test_webguard
            // 
            this.test_webguard.AutoSize = true;
            this.test_webguard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_webguard.Location = new System.Drawing.Point(22, 529);
            this.test_webguard.Name = "test_webguard";
            this.test_webguard.Padding = new System.Windows.Forms.Padding(740, 20, 0, 0);
            this.test_webguard.Size = new System.Drawing.Size(740, 33);
            this.test_webguard.TabIndex = 15;
            this.test_webguard.Click += new System.EventHandler(this.Test_webguard_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // how_webguard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.test_webguard);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "how_webguard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label test_webguard;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
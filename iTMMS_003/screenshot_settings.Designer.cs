namespace iTMMS_003
{
    partial class screenshot_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(screenshot_settings));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tick_no = new System.Windows.Forms.PictureBox();
            this.tick_yes = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tick_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tick_yes)).BeginInit();
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
            // tick_no
            // 
            this.tick_no.BackColor = System.Drawing.Color.Transparent;
            this.tick_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tick_no.Image = ((System.Drawing.Image)(resources.GetObject("tick_no.Image")));
            this.tick_no.Location = new System.Drawing.Point(708, 191);
            this.tick_no.Name = "tick_no";
            this.tick_no.Size = new System.Drawing.Size(35, 20);
            this.tick_no.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tick_no.TabIndex = 24;
            this.tick_no.TabStop = false;
            this.tick_no.Visible = false;
            this.tick_no.Click += new System.EventHandler(this.Tick_no_Click);
            // 
            // tick_yes
            // 
            this.tick_yes.BackColor = System.Drawing.Color.Transparent;
            this.tick_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tick_yes.Image = ((System.Drawing.Image)(resources.GetObject("tick_yes.Image")));
            this.tick_yes.Location = new System.Drawing.Point(708, 191);
            this.tick_yes.Name = "tick_yes";
            this.tick_yes.Size = new System.Drawing.Size(35, 20);
            this.tick_yes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tick_yes.TabIndex = 25;
            this.tick_yes.TabStop = false;
            this.tick_yes.Click += new System.EventHandler(this.Tick_yes_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 24);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(20, 23);
            this.back.TabIndex = 26;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // screenshot_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.tick_yes);
            this.Controls.Add(this.tick_no);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "screenshot_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tick_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tick_yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox tick_no;
        private System.Windows.Forms.PictureBox tick_yes;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
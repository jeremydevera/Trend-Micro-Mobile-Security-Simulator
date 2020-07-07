namespace iTMMS_003
{
    partial class more_tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(more_tools));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password_manager = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
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
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // password_manager
            // 
            this.password_manager.AutoSize = true;
            this.password_manager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password_manager.Location = new System.Drawing.Point(62, 158);
            this.password_manager.Name = "password_manager";
            this.password_manager.Padding = new System.Windows.Forms.Padding(70, 10, 0, 0);
            this.password_manager.Size = new System.Drawing.Size(70, 23);
            this.password_manager.TabIndex = 16;
            this.password_manager.Click += new System.EventHandler(this.Password_manager_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(6, -1);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(70, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(70, 23);
            this.back.TabIndex = 17;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // more_tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.back);
            this.Controls.Add(this.password_manager);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "more_tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label password_manager;
        private System.Windows.Forms.Label back;
    }
}
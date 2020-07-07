namespace iTMMS_003
{
    partial class add_approved_website
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_approved_website));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
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
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Location = new System.Drawing.Point(12, 24);
            this.cancel.Name = "cancel";
            this.cancel.Padding = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.cancel.Size = new System.Drawing.Size(50, 23);
            this.cancel.TabIndex = 11;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Location = new System.Drawing.Point(724, 24);
            this.add.Name = "add";
            this.add.Padding = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.add.Size = new System.Drawing.Size(50, 23);
            this.add.TabIndex = 12;
            this.add.Click += new System.EventHandler(this.Add_Click);
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
            // add_approved_website
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "add_approved_website";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label cancel;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
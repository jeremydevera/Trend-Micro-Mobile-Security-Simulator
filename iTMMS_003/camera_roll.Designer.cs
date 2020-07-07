namespace iTMMS_003
{
    partial class camera_roll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(camera_roll));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.no1 = new System.Windows.Forms.Label();
            this.no2 = new System.Windows.Forms.Label();
            this.no3 = new System.Windows.Forms.Label();
            this.camera_roll_scanning = new System.Windows.Forms.Label();
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
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 20);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(45, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(45, 23);
            this.back.TabIndex = 11;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // no1
            // 
            this.no1.AutoSize = true;
            this.no1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no1.Location = new System.Drawing.Point(176, 60);
            this.no1.Name = "no1";
            this.no1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.no1.Size = new System.Drawing.Size(15, 18);
            this.no1.TabIndex = 12;
            // 
            // no2
            // 
            this.no2.AutoSize = true;
            this.no2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no2.Location = new System.Drawing.Point(371, 60);
            this.no2.Name = "no2";
            this.no2.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.no2.Size = new System.Drawing.Size(15, 18);
            this.no2.TabIndex = 13;
            // 
            // no3
            // 
            this.no3.AutoSize = true;
            this.no3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no3.Location = new System.Drawing.Point(566, 60);
            this.no3.Name = "no3";
            this.no3.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.no3.Size = new System.Drawing.Size(15, 18);
            this.no3.TabIndex = 14;
            // 
            // camera_roll_scanning
            // 
            this.camera_roll_scanning.AutoSize = true;
            this.camera_roll_scanning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.camera_roll_scanning.Location = new System.Drawing.Point(727, 20);
            this.camera_roll_scanning.Name = "camera_roll_scanning";
            this.camera_roll_scanning.Padding = new System.Windows.Forms.Padding(45, 10, 0, 0);
            this.camera_roll_scanning.Size = new System.Drawing.Size(45, 23);
            this.camera_roll_scanning.TabIndex = 15;
            this.camera_roll_scanning.Click += new System.EventHandler(this.Camera_roll_scanning_Click);
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
            // camera_roll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.camera_roll_scanning);
            this.Controls.Add(this.no3);
            this.Controls.Add(this.no2);
            this.Controls.Add(this.no1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "camera_roll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label no1;
        private System.Windows.Forms.Label no2;
        private System.Windows.Forms.Label no3;
        private System.Windows.Forms.Label camera_roll_scanning;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
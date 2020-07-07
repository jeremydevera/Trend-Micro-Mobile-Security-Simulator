namespace iTMMS_003
{
    partial class fraud_buster_imessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fraud_buster_imessage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.camera_roll = new System.Windows.Forms.Label();
            this.fraud_buster_getstarted = new System.Windows.Forms.Label();
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
            this.back.Location = new System.Drawing.Point(12, 23);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(20, 23);
            this.back.TabIndex = 11;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // camera_roll
            // 
            this.camera_roll.AutoSize = true;
            this.camera_roll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.camera_roll.Location = new System.Drawing.Point(12, 56);
            this.camera_roll.Name = "camera_roll";
            this.camera_roll.Padding = new System.Windows.Forms.Padding(370, 25, 0, 0);
            this.camera_roll.Size = new System.Drawing.Size(370, 38);
            this.camera_roll.TabIndex = 12;
            this.camera_roll.Click += new System.EventHandler(this.Camera_roll_Click);
            // 
            // fraud_buster_getstarted
            // 
            this.fraud_buster_getstarted.AutoSize = true;
            this.fraud_buster_getstarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fraud_buster_getstarted.Location = new System.Drawing.Point(22, 481);
            this.fraud_buster_getstarted.Name = "fraud_buster_getstarted";
            this.fraud_buster_getstarted.Padding = new System.Windows.Forms.Padding(750, 40, 0, 0);
            this.fraud_buster_getstarted.Size = new System.Drawing.Size(750, 53);
            this.fraud_buster_getstarted.TabIndex = 13;
            this.fraud_buster_getstarted.Click += new System.EventHandler(this.Fraud_buster_getstarted_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // fraud_buster_imessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fraud_buster_getstarted);
            this.Controls.Add(this.camera_roll);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fraud_buster_imessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label camera_roll;
        private System.Windows.Forms.Label fraud_buster_getstarted;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
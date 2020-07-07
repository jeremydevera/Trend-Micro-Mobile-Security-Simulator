namespace iTMMS_003
{
    partial class data_plan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data_plan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.switch_on = new System.Windows.Forms.PictureBox();
            this.switch_off = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 474);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 22);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(20, 23);
            this.back.TabIndex = 12;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // switch_on
            // 
            this.switch_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch_on.Image = ((System.Drawing.Image)(resources.GetObject("switch_on.Image")));
            this.switch_on.Location = new System.Drawing.Point(735, 83);
            this.switch_on.Name = "switch_on";
            this.switch_on.Size = new System.Drawing.Size(35, 28);
            this.switch_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switch_on.TabIndex = 13;
            this.switch_on.TabStop = false;
            this.switch_on.Click += new System.EventHandler(this.Switch_on_Click);
            // 
            // switch_off
            // 
            this.switch_off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch_off.Image = ((System.Drawing.Image)(resources.GetObject("switch_off.Image")));
            this.switch_off.Location = new System.Drawing.Point(735, 83);
            this.switch_off.Name = "switch_off";
            this.switch_off.Size = new System.Drawing.Size(35, 28);
            this.switch_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switch_off.TabIndex = 14;
            this.switch_off.TabStop = false;
            this.switch_off.Visible = false;
            this.switch_off.Click += new System.EventHandler(this.Switch_off_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(785, 14);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // data_plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.switch_off);
            this.Controls.Add(this.switch_on);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "data_plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.PictureBox switch_on;
        private System.Windows.Forms.PictureBox switch_off;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
namespace iTMMS_003
{
    partial class cellular_usage_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cellular_usage_history));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.monthly_panel = new System.Windows.Forms.Panel();
            this.year = new System.Windows.Forms.Label();
            this.monthly_img = new System.Windows.Forms.PictureBox();
            this.yearly_panel = new System.Windows.Forms.Panel();
            this.month = new System.Windows.Forms.Label();
            this.yearly_img = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.monthly_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_img)).BeginInit();
            this.yearly_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearly_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(12, 26);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(20, 23);
            this.back.TabIndex = 12;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // monthly_panel
            // 
            this.monthly_panel.BackColor = System.Drawing.Color.White;
            this.monthly_panel.Controls.Add(this.year);
            this.monthly_panel.Controls.Add(this.monthly_img);
            this.monthly_panel.Location = new System.Drawing.Point(5, 62);
            this.monthly_panel.Name = "monthly_panel";
            this.monthly_panel.Size = new System.Drawing.Size(785, 534);
            this.monthly_panel.TabIndex = 13;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.year.Location = new System.Drawing.Point(398, 20);
            this.year.Name = "year";
            this.year.Padding = new System.Windows.Forms.Padding(150, 25, 0, 0);
            this.year.Size = new System.Drawing.Size(150, 38);
            this.year.TabIndex = 13;
            this.year.Click += new System.EventHandler(this.Year_Click);
            // 
            // monthly_img
            // 
            this.monthly_img.BackColor = System.Drawing.Color.White;
            this.monthly_img.Image = ((System.Drawing.Image)(resources.GetObject("monthly_img.Image")));
            this.monthly_img.Location = new System.Drawing.Point(0, 10);
            this.monthly_img.Name = "monthly_img";
            this.monthly_img.Size = new System.Drawing.Size(785, 513);
            this.monthly_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.monthly_img.TabIndex = 0;
            this.monthly_img.TabStop = false;
            // 
            // yearly_panel
            // 
            this.yearly_panel.BackColor = System.Drawing.Color.White;
            this.yearly_panel.Controls.Add(this.month);
            this.yearly_panel.Controls.Add(this.yearly_img);
            this.yearly_panel.Location = new System.Drawing.Point(0, 60);
            this.yearly_panel.Name = "yearly_panel";
            this.yearly_panel.Size = new System.Drawing.Size(805, 533);
            this.yearly_panel.TabIndex = 14;
            this.yearly_panel.Visible = false;
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Cursor = System.Windows.Forms.Cursors.Hand;
            this.month.Location = new System.Drawing.Point(232, 23);
            this.month.Name = "month";
            this.month.Padding = new System.Windows.Forms.Padding(160, 25, 0, 0);
            this.month.Size = new System.Drawing.Size(160, 38);
            this.month.TabIndex = 13;
            this.month.Click += new System.EventHandler(this.Month_Click);
            // 
            // yearly_img
            // 
            this.yearly_img.BackColor = System.Drawing.Color.White;
            this.yearly_img.Image = ((System.Drawing.Image)(resources.GetObject("yearly_img.Image")));
            this.yearly_img.Location = new System.Drawing.Point(0, 13);
            this.yearly_img.Name = "yearly_img";
            this.yearly_img.Size = new System.Drawing.Size(788, 539);
            this.yearly_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yearly_img.TabIndex = 0;
            this.yearly_img.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cellular_usage_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yearly_panel);
            this.Controls.Add(this.monthly_panel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cellular_usage_history";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.monthly_panel.ResumeLayout(false);
            this.monthly_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthly_img)).EndInit();
            this.yearly_panel.ResumeLayout(false);
            this.yearly_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearly_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Panel monthly_panel;
        private System.Windows.Forms.PictureBox monthly_img;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Panel yearly_panel;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.PictureBox yearly_img;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
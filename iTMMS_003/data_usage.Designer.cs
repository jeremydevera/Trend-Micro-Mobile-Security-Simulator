namespace iTMMS_003
{
    partial class data_usage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(data_usage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.data_usage_cellular = new System.Windows.Forms.Label();
            this.data_usage_wifi = new System.Windows.Forms.Label();
            this.data_usage_settings = new System.Windows.Forms.Label();
            this.cellular_usage_history = new System.Windows.Forms.Label();
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
            this.back.Location = new System.Drawing.Point(12, 25);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(20, 23);
            this.back.TabIndex = 11;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // data_usage_cellular
            // 
            this.data_usage_cellular.AutoSize = true;
            this.data_usage_cellular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_usage_cellular.Location = new System.Drawing.Point(234, 60);
            this.data_usage_cellular.Name = "data_usage_cellular";
            this.data_usage_cellular.Padding = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.data_usage_cellular.Size = new System.Drawing.Size(100, 23);
            this.data_usage_cellular.TabIndex = 12;
            this.data_usage_cellular.Click += new System.EventHandler(this.Data_usage_cellular_Click);
            // 
            // data_usage_wifi
            // 
            this.data_usage_wifi.AutoSize = true;
            this.data_usage_wifi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_usage_wifi.Location = new System.Drawing.Point(448, 60);
            this.data_usage_wifi.Name = "data_usage_wifi";
            this.data_usage_wifi.Padding = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.data_usage_wifi.Size = new System.Drawing.Size(100, 23);
            this.data_usage_wifi.TabIndex = 13;
            this.data_usage_wifi.Click += new System.EventHandler(this.Data_usage_wifi_Click);
            // 
            // data_usage_settings
            // 
            this.data_usage_settings.AutoSize = true;
            this.data_usage_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_usage_settings.Location = new System.Drawing.Point(735, 60);
            this.data_usage_settings.Name = "data_usage_settings";
            this.data_usage_settings.Padding = new System.Windows.Forms.Padding(40, 10, 0, 0);
            this.data_usage_settings.Size = new System.Drawing.Size(40, 23);
            this.data_usage_settings.TabIndex = 14;
            this.data_usage_settings.Click += new System.EventHandler(this.Data_usage_settings_Click);
            // 
            // cellular_usage_history
            // 
            this.cellular_usage_history.AutoSize = true;
            this.cellular_usage_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellular_usage_history.Location = new System.Drawing.Point(17, 60);
            this.cellular_usage_history.Name = "cellular_usage_history";
            this.cellular_usage_history.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.cellular_usage_history.Size = new System.Drawing.Size(20, 23);
            this.cellular_usage_history.TabIndex = 15;
            this.cellular_usage_history.Click += new System.EventHandler(this.Cellular_usage_history_Click);
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
            // data_usage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cellular_usage_history);
            this.Controls.Add(this.data_usage_settings);
            this.Controls.Add(this.data_usage_wifi);
            this.Controls.Add(this.data_usage_cellular);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "data_usage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label data_usage_cellular;
        private System.Windows.Forms.Label data_usage_wifi;
        private System.Windows.Forms.Label data_usage_settings;
        private System.Windows.Forms.Label cellular_usage_history;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
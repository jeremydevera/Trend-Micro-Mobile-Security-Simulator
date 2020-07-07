namespace iTMMS_003
{
    partial class ldp_map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ldp_map));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.popup = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.alarm = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Label();
            this.refreshpop = new System.Windows.Forms.PictureBox();
            this.share = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpop)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(785, 590);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // popup
            // 
            this.popup.BackColor = System.Drawing.Color.Transparent;
            this.popup.Image = ((System.Drawing.Image)(resources.GetObject("popup.Image")));
            this.popup.Location = new System.Drawing.Point(301, 155);
            this.popup.Name = "popup";
            this.popup.Size = new System.Drawing.Size(456, 74);
            this.popup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.popup.TabIndex = 12;
            this.popup.TabStop = false;
            this.popup.Visible = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Location = new System.Drawing.Point(-3, -2);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.back.Size = new System.Drawing.Size(100, 23);
            this.back.TabIndex = 13;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // alarm
            // 
            this.alarm.AutoSize = true;
            this.alarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alarm.Location = new System.Drawing.Point(479, 359);
            this.alarm.Name = "alarm";
            this.alarm.Padding = new System.Windows.Forms.Padding(50, 35, 0, 0);
            this.alarm.Size = new System.Drawing.Size(50, 48);
            this.alarm.TabIndex = 14;
            this.alarm.Click += new System.EventHandler(this.Alarm_Click);
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Location = new System.Drawing.Point(557, 359);
            this.refresh.Name = "refresh";
            this.refresh.Padding = new System.Windows.Forms.Padding(50, 35, 0, 0);
            this.refresh.Size = new System.Drawing.Size(50, 48);
            this.refresh.TabIndex = 15;
            this.refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // refreshpop
            // 
            this.refreshpop.BackColor = System.Drawing.Color.Transparent;
            this.refreshpop.Image = ((System.Drawing.Image)(resources.GetObject("refreshpop.Image")));
            this.refreshpop.Location = new System.Drawing.Point(301, 155);
            this.refreshpop.Name = "refreshpop";
            this.refreshpop.Size = new System.Drawing.Size(456, 74);
            this.refreshpop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshpop.TabIndex = 16;
            this.refreshpop.TabStop = false;
            this.refreshpop.Visible = false;
            // 
            // share
            // 
            this.share.AutoSize = true;
            this.share.Cursor = System.Windows.Forms.Cursors.Hand;
            this.share.Location = new System.Drawing.Point(402, 359);
            this.share.Name = "share";
            this.share.Padding = new System.Windows.Forms.Padding(50, 35, 0, 0);
            this.share.Size = new System.Drawing.Size(50, 48);
            this.share.TabIndex = 17;
            this.share.Click += new System.EventHandler(this.Share_Click);
            // 
            // ldp_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.share);
            this.Controls.Add(this.refreshpop);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.alarm);
            this.Controls.Add(this.back);
            this.Controls.Add(this.popup);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ldp_map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshpop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox popup;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label alarm;
        private System.Windows.Forms.Label refresh;
        private System.Windows.Forms.PictureBox refreshpop;
        private System.Windows.Forms.Label share;
    }
}
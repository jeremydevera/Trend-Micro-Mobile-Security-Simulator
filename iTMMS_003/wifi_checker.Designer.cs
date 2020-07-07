namespace iTMMS_003
{
    partial class wifi_checker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wifi_checker));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.no_risk_panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.turn_on = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.test_popup = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.no_risk_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_popup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.pictureBox1.TabIndex = 2;
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
            this.back.TabIndex = 9;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // no_risk_panel
            // 
            this.no_risk_panel.Controls.Add(this.pictureBox2);
            this.no_risk_panel.Location = new System.Drawing.Point(0, 53);
            this.no_risk_panel.Name = "no_risk_panel";
            this.no_risk_panel.Size = new System.Drawing.Size(785, 352);
            this.no_risk_panel.TabIndex = 10;
            this.no_risk_panel.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(782, 327);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // turn_on
            // 
            this.turn_on.AutoSize = true;
            this.turn_on.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turn_on.Location = new System.Drawing.Point(12, 390);
            this.turn_on.Name = "turn_on";
            this.turn_on.Padding = new System.Windows.Forms.Padding(150, 5, 0, 0);
            this.turn_on.Size = new System.Drawing.Size(150, 18);
            this.turn_on.TabIndex = 11;
            this.turn_on.Click += new System.EventHandler(this.Turn_on_Click);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Cursor = System.Windows.Forms.Cursors.Hand;
            this.question.Location = new System.Drawing.Point(723, 23);
            this.question.Name = "question";
            this.question.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.question.Size = new System.Drawing.Size(20, 23);
            this.question.TabIndex = 12;
            this.question.Click += new System.EventHandler(this.Question_Click);
            // 
            // test_popup
            // 
            this.test_popup.BackColor = System.Drawing.Color.Transparent;
            this.test_popup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_popup.Image = ((System.Drawing.Image)(resources.GetObject("test_popup.Image")));
            this.test_popup.Location = new System.Drawing.Point(15, 58);
            this.test_popup.Name = "test_popup";
            this.test_popup.Size = new System.Drawing.Size(761, 49);
            this.test_popup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.test_popup.TabIndex = 1;
            this.test_popup.TabStop = false;
            this.test_popup.Click += new System.EventHandler(this.Test_popup_Click);
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.Location = new System.Drawing.Point(749, 23);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.settings.Size = new System.Drawing.Size(20, 23);
            this.settings.TabIndex = 13;
            this.settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(785, 14);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // wifi_checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.test_popup);
            this.Controls.Add(this.question);
            this.Controls.Add(this.turn_on);
            this.Controls.Add(this.no_risk_panel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "wifi_checker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.no_risk_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_popup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Panel no_risk_panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label turn_on;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.PictureBox test_popup;
        private System.Windows.Forms.Label settings;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
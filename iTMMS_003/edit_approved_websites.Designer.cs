namespace iTMMS_003
{
    partial class edit_approved_websites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_approved_websites));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remove = new System.Windows.Forms.Label();
            this.cancel_box = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delete_all = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.cancel.Location = new System.Drawing.Point(722, 23);
            this.cancel.Name = "cancel";
            this.cancel.Padding = new System.Windows.Forms.Padding(50, 10, 0, 0);
            this.cancel.Size = new System.Drawing.Size(50, 23);
            this.cancel.TabIndex = 14;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.remove);
            this.panel1.Controls.Add(this.cancel_box);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(275, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 190);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // remove
            // 
            this.remove.AutoSize = true;
            this.remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove.Location = new System.Drawing.Point(21, 142);
            this.remove.Name = "remove";
            this.remove.Padding = new System.Windows.Forms.Padding(70, 10, 0, 0);
            this.remove.Size = new System.Drawing.Size(70, 23);
            this.remove.TabIndex = 18;
            this.remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // cancel_box
            // 
            this.cancel_box.AutoSize = true;
            this.cancel_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_box.Location = new System.Drawing.Point(135, 142);
            this.cancel_box.Name = "cancel_box";
            this.cancel_box.Padding = new System.Windows.Forms.Padding(70, 10, 0, 0);
            this.cancel_box.Size = new System.Drawing.Size(70, 23);
            this.cancel_box.TabIndex = 17;
            this.cancel_box.Click += new System.EventHandler(this.Cancel_box_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // delete_all
            // 
            this.delete_all.AutoSize = true;
            this.delete_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_all.Location = new System.Drawing.Point(701, 552);
            this.delete_all.Name = "delete_all";
            this.delete_all.Padding = new System.Windows.Forms.Padding(70, 10, 0, 0);
            this.delete_all.Size = new System.Drawing.Size(70, 23);
            this.delete_all.TabIndex = 16;
            this.delete_all.Click += new System.EventHandler(this.Delete_all_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(785, 14);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // edit_approved_websites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 586);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.delete_all);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edit_approved_websites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label delete_all;
        private System.Windows.Forms.Label cancel_box;
        private System.Windows.Forms.Label remove;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
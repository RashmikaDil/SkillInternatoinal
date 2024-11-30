namespace SkillInternatoinal
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.log_out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Reg_btn = new System.Windows.Forms.Button();
            this.Updae_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.log_out);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 424);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(35, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 117);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // log_out
            // 
            this.log_out.BackColor = System.Drawing.Color.Crimson;
            this.log_out.FlatAppearance.BorderSize = 0;
            this.log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_out.ForeColor = System.Drawing.Color.Transparent;
            this.log_out.Location = new System.Drawing.Point(35, 377);
            this.log_out.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(155, 35);
            this.log_out.TabIndex = 6;
            this.log_out.Text = "LOG OUT";
            this.log_out.UseVisualStyleBackColor = false;
            this.log_out.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(235, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";
            // 
            // Reg_btn
            // 
            this.Reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg_btn.Location = new System.Drawing.Point(239, 86);
            this.Reg_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Reg_btn.Name = "Reg_btn";
            this.Reg_btn.Size = new System.Drawing.Size(129, 55);
            this.Reg_btn.TabIndex = 4;
            this.Reg_btn.Text = "Student Registration";
            this.Reg_btn.UseVisualStyleBackColor = true;
            this.Reg_btn.Click += new System.EventHandler(this.Reg_btn_Click);
            // 
            // Updae_btn
            // 
            this.Updae_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updae_btn.Location = new System.Drawing.Point(372, 86);
            this.Updae_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Updae_btn.Name = "Updae_btn";
            this.Updae_btn.Size = new System.Drawing.Size(148, 55);
            this.Updae_btn.TabIndex = 5;
            this.Updae_btn.Text = "Update Student Data";
            this.Updae_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_btn
            // 
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Location = new System.Drawing.Point(524, 86);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(149, 55);
            this.Delete_btn.TabIndex = 6;
            this.Delete_btn.Text = "Delete Student";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Crimson;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(35, 334);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(155, 35);
            this.exit.TabIndex = 8;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Updae_btn);
            this.Controls.Add(this.Reg_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reg_btn;
        private System.Windows.Forms.Button Updae_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button exit;
    }
}
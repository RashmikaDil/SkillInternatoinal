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
            this.exit = new System.Windows.Forms.Button();
            this.log_out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Reg_btn = new System.Windows.Forms.Button();
            this.stu_data = new System.Windows.Forms.DataGridView();
            this.txtSearchRegNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Credit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.stu_c = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_data)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.log_out);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Credit);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 639);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(37, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 206);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Crimson;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Location = new System.Drawing.Point(47, 513);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(207, 43);
            this.exit.TabIndex = 8;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // log_out
            // 
            this.log_out.BackColor = System.Drawing.Color.Crimson;
            this.log_out.FlatAppearance.BorderSize = 0;
            this.log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_out.ForeColor = System.Drawing.Color.Transparent;
            this.log_out.Location = new System.Drawing.Point(47, 566);
            this.log_out.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(207, 43);
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
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";
            // 
            // Reg_btn
            // 
            this.Reg_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Reg_btn.FlatAppearance.BorderSize = 0;
            this.Reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Reg_btn.Location = new System.Drawing.Point(15, 101);
            this.Reg_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reg_btn.Name = "Reg_btn";
            this.Reg_btn.Size = new System.Drawing.Size(269, 42);
            this.Reg_btn.TabIndex = 4;
            this.Reg_btn.Text = "Student Registration / Delete\r\n";
            this.Reg_btn.UseVisualStyleBackColor = false;
            this.Reg_btn.Click += new System.EventHandler(this.Reg_btn_Click);
            // 
            // stu_data
            // 
            this.stu_data.BackgroundColor = System.Drawing.Color.White;
            this.stu_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stu_data.GridColor = System.Drawing.Color.White;
            this.stu_data.Location = new System.Drawing.Point(329, 513);
            this.stu_data.Name = "stu_data";
            this.stu_data.RowHeadersWidth = 51;
            this.stu_data.RowTemplate.Height = 24;
            this.stu_data.Size = new System.Drawing.Size(789, 75);
            this.stu_data.TabIndex = 5;
            // 
            // txtSearchRegNo
            // 
            this.txtSearchRegNo.BackColor = System.Drawing.Color.White;
            this.txtSearchRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchRegNo.ForeColor = System.Drawing.Color.Black;
            this.txtSearchRegNo.Location = new System.Drawing.Point(329, 480);
            this.txtSearchRegNo.MaxLength = 50;
            this.txtSearchRegNo.Name = "txtSearchRegNo";
            this.txtSearchRegNo.Size = new System.Drawing.Size(206, 22);
            this.txtSearchRegNo.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btnSearch.Location = new System.Drawing.Point(947, 472);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(171, 35);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.update_btn.Location = new System.Drawing.Point(16, 148);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(269, 42);
            this.update_btn.TabIndex = 9;
            this.update_btn.Text = "Update Student Data";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Credit
            // 
            this.Credit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Credit.FlatAppearance.BorderSize = 0;
            this.Credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Credit.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit.Location = new System.Drawing.Point(47, 458);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(207, 43);
            this.Credit.TabIndex = 12;
            this.Credit.Text = "Credit !";
            this.Credit.UseVisualStyleBackColor = false;
            this.Credit.Click += new System.EventHandler(this.Credit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 9, 9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search Student ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(313, 431);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(818, 173);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // stu_c
            // 
            this.stu_c.AutoSize = true;
            this.stu_c.BackColor = System.Drawing.Color.Transparent;
            this.stu_c.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stu_c.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.stu_c.Location = new System.Drawing.Point(446, 175);
            this.stu_c.Name = "stu_c";
            this.stu_c.Size = new System.Drawing.Size(89, 101);
            this.stu_c.TabIndex = 15;
            this.stu_c.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(526, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 52);
            this.label3.TabIndex = 16;
            this.label3.Text = "Student \r\nRegistered\r\n";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 636);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stu_c);
            this.Controls.Add(this.stu_data);
            this.Controls.Add(this.txtSearchRegNo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Reg_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_data)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reg_btn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView stu_data;
        private System.Windows.Forms.TextBox txtSearchRegNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Credit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label stu_c;
        private System.Windows.Forms.Label label3;
    }
}
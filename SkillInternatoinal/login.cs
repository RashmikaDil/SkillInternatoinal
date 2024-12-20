﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillInternatoinal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string password = this.password.Text;

            if (user == "Admin" && password == "Skills@123")
            {
                MessageBox.Show(
                    "Login sucess!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(
                    "Your login credentials do not match our records. Please recheck and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                 MessageBoxButtons.YesNo, 
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            username.Text = string.Empty;
            password.Text = string.Empty;
            username.Focus();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

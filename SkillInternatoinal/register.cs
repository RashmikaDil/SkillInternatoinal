using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Net.Mime.MediaTypeNames.Application;
using System.Data.SqlClient;

namespace SkillInternatoinal
{
    public partial class register : Form
    {
        string g;
        SqlConnection conn = null;
        public register()
        {
            conn = new SqlConnection("Data Source=DESKTOP-55L8O5D\\\\SQLEXPRESS;Initial Catalog=skill_international;Integrated Security=True;");
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                g = "Male";
            }
            else
            {
                g = "Female";
            }


            string constring = ("Data Source=DESKTOP-55L8O5D\\SQLEXPRESS;Initial Catalog=skill_international;Integrated Security=True;");
            string quary = "INSERT INTO registers (regNo,firstName,lastName , dateOfBirth, gender , address , email , mobilePhone , homePhone , parentName , nic , contactNo ) VALUES ('" + comboBox1.Text + "','" + textBox1.Text + "' , '" + textBox2.Text + "','" + dateTimePicker1.Value.Date + "','" + g + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
            SqlConnection conn;
            conn = new SqlConnection(constring);
            SqlCommand runQuary = new SqlCommand(quary, conn);

            conn.Open();
            runQuary.ExecuteNonQuery();
            MessageBox.Show("Student Registered Sucessfully ! ", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}

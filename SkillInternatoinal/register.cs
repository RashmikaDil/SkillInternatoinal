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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;

namespace SkillInternatoinal
{
    public partial class register : Form
    {


        string g;
        
        SqlConnection conn = null;
        public register()
        {
            conn = new SqlConnection("Data Source=DESKTOP-55L8O5D\\SQLEXPRESS;Initial Catalog=skill_international;Integrated Security=True;");
            InitializeComponent();
            LoadComboBoxData();
           

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
   
        }
        
        
       


        private void button2_Click(object sender, EventArgs e)
        {
            string del_query = "Delete from registers where regNo =" + regInput.SelectedItem + "";
            SqlCommand sqlCommand = new SqlCommand(del_query, conn);

            try
            {
                conn.Open();
                sqlCommand.ExecuteNonQuery();

                DialogResult result;
                result = MessageBox.Show("Are you sure , Do you real wnat to delete ...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Delete sucessfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }


            }
            catch
            {
                MessageBox.Show("Invalid Register Number, Try again!", "register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
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
            string quary = "INSERT INTO registers (regNo,firstName,lastName , dateOfBirth, gender , address , email , mobilePhone , homePhone , parentName , nic , contactNo ) VALUES ('" + regInput.Text + "','" + f_name.Text + "' , '" + l_name.Text + "','" + dob.Value.Date + "','" + g + "','" + address_input.Text + "','" + email_input.Text + "','" + mp.Text + "','" + hp.Text + "','" + p_name.Text + "','" + nic_no.Text + "','" + c_no.Text + "')";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            regInput.Text = " ";
            f_name.Clear();
            l_name.Clear();
            dob.Text = "";
            address_input.Clear();
            email_input.Clear();
            mp.Clear();
            hp.Clear();
            p_name.Clear();
            nic_no.Clear();
            c_no.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

       
        private void LoadComboBoxData()

        {
           
            string connectionString = ("Data Source=DESKTOP-55L8O5D\\SQLEXPRESS;Initial Catalog=skill_international;Integrated Security=True;");

           
            string query = "SELECT regNo FROM registers";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                   
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        regInput.Items.Add(reader["regNo"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}

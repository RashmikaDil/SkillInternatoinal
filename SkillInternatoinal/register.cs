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
    public partial class Registration : Form
    {
        private string connectionString = "Data Source=DESKTOP-55L8O5D\\SQLEXPRESS;Initial Catalog=skill_international;Integrated Security=True;";

        string g;
        
        SqlConnection conn = null;
        private object connection;

        public Registration()
        {
            conn = new SqlConnection(connectionString);
            
            InitializeComponent();
            LoadComboBoxData();
           

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

        private void delete_btn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(regInput.Text))
            {
                MessageBox.Show("Please enter a valid regNo to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    DeleteRecord(regInput.Text);  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteRecord(string regNo)
        {
            
            string query = "DELETE FROM registers WHERE regNo = @regNo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@regNo", regNo);

                    
                    int rowsAffected = command.ExecuteNonQuery();

                    
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with the provided regNo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }




        }

        private void regInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            if (string.IsNullOrWhiteSpace(regInput.Text))
            {
                MessageBox.Show("Please enter a registration number.");
                return;
            }
            string query = "SELECT [firstName], [lastName], [dateOfBirth], [gender], [address], [email], " +
                           "[mobilePhone], [homePhone], [parentName], [nic], [contactNo] " +
                           "FROM registers WHERE [regNo] = @regNo";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@regNo", regInput.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {


                            if (reader["dateOfBirth"] != DBNull.Value)
                            {
                                dob.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                            }
                            else
                            {
                                
                                dob.Value = DateTime.Today;
                            }
                            
                            string gender = reader["gender"].ToString();
                            if (gender == "Male")
                            {
                                radioButton1.Checked = true;
                                radioButton2.Checked = false;
                            }
                            else if (gender == "Female")
                            {
                                radioButton2.Checked = true;
                                radioButton1.Checked = false;
                            }
                            else
                            {
                                radioButton2.Checked = false;
                                radioButton1.Checked = false;
                            }

                            f_name.Text = reader["firstName"].ToString();
                                l_name.Text = reader["lastName"].ToString();
                              
                                address_input.Text = reader["address"].ToString();
                                email_input.Text = reader["email"].ToString();
                                mp.Text = reader["mobilePhone"].ToString();
                                hp.Text = reader["homePhone"].ToString();
                                p_name.Text = reader["parentName"].ToString();
                                nic_no.Text = reader["nic"].ToString();
                                nic_no.Text = reader["contactNo"].ToString();
                        
                        }
                        else
                        {
                            MessageBox.Show("No data found for the provided registration number.");
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                  
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


                }

        private void register_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                string checkQuery = "SELECT COUNT(*) FROM registers WHERE regNo = @regNo";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@regNo", regInput.Text);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Duplicate registration number detected. Please enter a unique regNo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }




            if (radioButton1.Checked == true)
            {
                g = "Male";
            }
            else
            {
                g = "Female";
            }


          string quary = "INSERT INTO registers (regNo,firstName,lastName , dateOfBirth, gender , address , email , mobilePhone , homePhone , parentName , nic , contactNo ) VALUES ('" + regInput.Text + "','" + f_name.Text + "' , '" + l_name.Text + "','" + dob.Value.Date + "','" + g + "','" + address_input.Text + "','" + email_input.Text + "','" + mp.Text + "','" + hp.Text + "','" + p_name.Text + "','" + nic_no.Text + "','" + c_no.Text + "')";
            SqlConnection conn;
            conn = new SqlConnection(connectionString);
            SqlCommand runQuary = new SqlCommand(quary, conn);

            conn.Open();
            runQuary.ExecuteNonQuery();
            MessageBox.Show("Student Registered Sucessfully ! ", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            this.Hide();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}

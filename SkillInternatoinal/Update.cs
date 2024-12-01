using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillInternatoinal
{
    public partial class Update : Form
    {
        string g;
        private string connectionString = "Data Source=DESKTOP-55L8O5D\\SQLEXPRESS;Initial Catalog=skill_international;Integrated Security=True;";
        public Update()
        {
            InitializeComponent();
            LoadComboBoxData();
           

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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {

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

        private void regInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {



            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                string checkQuery = "SELECT COUNT(*) FROM registers WHERE regNo = @regNo";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@regNo", regInput.Text);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Invalid Registration Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


          string quary = "update registers ('" + regInput.Text + "','" + f_name.Text + "' , '" + l_name.Text + "','" + dob.Value.Date + "','" + g + "','" + address_input.Text + "','" + email_input.Text + "','" + mp.Text + "','" + hp.Text + "','" + p_name.Text + "','" + nic_no.Text + "','" + c_no.Text + "')";
            SqlConnection conn;
            conn = new SqlConnection(connectionString);
            SqlCommand runQuary = new SqlCommand(quary, conn);

            conn.Open();
            runQuary.ExecuteNonQuery();
            MessageBox.Show("Student Detail Updated Sucessfully ! ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);










        }


    }
    } 


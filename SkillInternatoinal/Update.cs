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
using System.Windows.Input;

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
                                date_ob.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                            }
                            else
                            {

                                date_ob.Value = DateTime.Today;
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
            if (radioButton1.Checked == true)
            {
                g = "male";
            }
            else
            {
                g = "Female";
            }


            try
            {
                int id = int.Parse(regInput.Text);
                string fname = f_name.Text;
                string lname = l_name.Text;
                DateTime dob = date_ob.Value;


                string address = address_input.Text;
                string e_mail = email_input.Text;
                int phoneno = int.Parse(mp.Text);
                int homeno = int.Parse(hp.Text);
                int n_ic = int.Parse(nic_no.Text);
                string p_no = c_no.Text;
                string p_na = p_name.Text;


                string query = "UPDATE  registers SET regNo = @ID,  firstName = @fname , lastName = @lname ,dateOfBirth = @dob , gender = @gender,address = @address, email = @e_mail_a, mobilePhone = @phoneno, homePhone = @homeno, parentName = @pa_na , nic = @n_ic , contactNo = @p_na WHERE regNo = @ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@fname", fname);
                        command.Parameters.AddWithValue("@lname", lname);
                        command.Parameters.AddWithValue("@dob", dob);
                        command.Parameters.AddWithValue("@gender", g);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@e_mail_a", e_mail);
                        command.Parameters.AddWithValue("@phoneNo", phoneno );
                        command.Parameters.AddWithValue("@p_na", p_no);
                        command.Parameters.AddWithValue("@n_ic", n_ic);
                        command.Parameters.AddWithValue("@pa_na", p_na);
                        command.Parameters.AddWithValue("@homeno", homeno);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            }








        


    }
    


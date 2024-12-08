using System;
using System.Collections;
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
    public partial class Dashboard : Form

    {
        private object connection;
        private string connectionString = "Data Source=DESKTOP-55L8O5D\\SQLEXPRESS;Initial Catalog=skill_international;Integrated Security=True;";
        public Dashboard()
        {
            InitializeComponent();
            CountStudets();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reg_btn_Click(object sender, EventArgs e)
        {
            Registration NavReg = new Registration();
            NavReg.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchRegNo.Text))
            {
                MessageBox.Show("Please enter a regNo to search for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                SearchStudent(txtSearchRegNo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchStudent(string regNo)
        {

            string query = "SELECT regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo " +
                           "FROM registers WHERE regNo = @regNo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@regNo", regNo);


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();


                    dataAdapter.Fill(dataTable);


                    if (dataTable.Rows.Count > 0)
                    {

                        stu_data.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No student found with the provided regNo.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Credit_Click(object sender, EventArgs e)
        {
            credit credit = new credit();
            credit.Show();
        }

        private void CountStudets()
        {
            try
            {
                string query = "SELECT COUNT(*) AS regNo FROM registers";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        int totalRecords = (int)command.ExecuteScalar();
                        stu_c.Text = $"{totalRecords}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void stu_c_Click(object sender, EventArgs e)
        {

        }
    }
}

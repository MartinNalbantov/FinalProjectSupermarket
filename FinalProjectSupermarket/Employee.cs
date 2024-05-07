using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProjectSupermarket
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                // Create a new SQL connection
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAB109PC11\SQLEXPRESS; Initial Catalog=SupermarketManagement; Integrated Security=True;"))
                {
                    // SQL query to select data from the testdrive table
                    string query = "SELECT * FROM Employees";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void hire_bttn_Click(object sender, EventArgs e)
        {
            // Retrieve the entered information from the booking form
            string empName = employeeName.Text;
            string position = job.Text;
            string employee_wage = wage.Text;


            // Connection string to your SQL Server database
            string connectionString = @"Data Source=LAB109PC11\SQLEXPRESS; Initial Catalog=SupermarketManagement; Integrated Security=True;";

            // SQL query to insert data into the testdrive table
            string query = @"INSERT INTO Employees (name, position, wage) 
                         VALUES (@name, @position, @wage)";

            // Create a new SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SQL command
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@name", empName);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@wage", employee_wage);



                    try
                    {
                        // Open the database connection
                        connection.Open();

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted into Employees table.");
                        }
                        else
                        {
                            MessageBox.Show("Error: No rows inserted into the Employees table.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                LoadDataIntoDataGridView();

            }
        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            employeeName.Text = "";
            job.Text = "";
            wage.Text = "";

        }

        private void fire_bttn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int productId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["employee_id"].Value);

                string connectionString = @"Data Source=LAB109PC11\SQLEXPRESS; Initial Catalog=SupermarketManagement; Integrated Security=True;";

                string query = "DELETE FROM Employees WHERE employee_id = @EmployeeId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", productId);

                        try
                        {
                            connection.Open();

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                dataGridView1.Rows.RemoveAt(selectedRowIndex);
                                MessageBox.Show("Entry deleted from the Employees table.");
                            }
                            else
                            {
                                MessageBox.Show("Error: No rows deleted from the Employees table.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void employeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation();
            navigation.Show();
            this.Hide();
        }
    }
}

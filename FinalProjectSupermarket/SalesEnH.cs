using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.CodeDom;

namespace FinalProjectSupermarket
{
    public partial class SalesEnH : Form
    {
        public SalesEnH()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }





        private void SalesEnH_Load(object sender, EventArgs e)
        {
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                // Create a new SQL connection
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAB109PC11\SQLEXPRESS; Initial Catalog=SupermarketManagement; Integrated Security=True;"))
                {
                    // SQL query to select data from the testdrive table
                    string query = "SELECT * FROM Sales";

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

        private void addSale_bttn_Click(object sender, EventArgs e)
        {
            // Retrieve the entered information from the booking form
            string employee = emp.Text;
            string product = pr.Text;
            string qnt = quantity.Text;
            string dt = date.Text;

            // Connection string to your SQL Server database
            string connectionString = @"Data Source=LAB109PC11\SQLEXPRESS; Initial Catalog=SupermarketManagement; Integrated Security=True;";

            // SQL query to insert data into the testdrive table
            string query = @"INSERT INTO Sales (product_id, employee_id, quantity_sold, sale_date) 
                         VALUES (@product, @name, @quantity, @date)";

            // Create a new SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SQL command
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@product", product);
                    command.Parameters.AddWithValue("@name", employee);
                    command.Parameters.AddWithValue("@quantity", qnt);
                    command.Parameters.AddWithValue("@date", dt);


                    try
                    {
                        // Open the database connection
                        connection.Open();

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted into Sales table.");
                        }
                        else
                        {
                            MessageBox.Show("Error: No rows inserted into the Sales table.");
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
            emp.Text = string.Empty;
            quantity.Text = string.Empty;
            pr.Text = string.Empty;
            date.Text = string.Empty;
        }

        private void filter_bttn_Click(object sender, EventArgs e)
        {
            

            string textBox1Value = emp_sort.Text;
            string textBox2Value = pr_sort.Text;

            string connectionString = @"Data Source=LAB109PC11\SQLEXPRESS; Initial Catalog=SupermarketManagement; Integrated Security=True;";

            string query = @"
            SELECT * 
            FROM Sales
            WHERE employee_id = @TextBox1Value
            AND product_id =  @TextBox2Value";

            // Create a new SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SQL command
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   


                    // Add parameters to the command
                    command.Parameters.AddWithValue("@TextBox2Value", textBox2Value);
                    command.Parameters.AddWithValue("@TextBox1Value", textBox1Value);

                    

                    


                    try
                    {
                        // Open the database connection
                        connection.Open();

                        // Execute the SQL command
                        SqlDataReader reader = command.ExecuteReader();

                        // Create a new DataTable to hold the retrieved data
                        DataTable dataTable = new DataTable();

                        // Load the data into the DataTable
                        dataTable.Load(reader);

                        // Set the DataSource property of the DataGridView to the filtered DataTable
                        dataGridView1.DataSource = dataTable;

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Navigation navigation = new Navigation();
            navigation.Show();
            this.Hide();

        }
    }
}

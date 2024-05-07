using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProjectSupermarket
{
    public partial class ProductManagement : Form
    {

        public ProductManagement()
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
                    string query = "SELECT * FROM Products";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ProductManagement_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_bttn_Click(object sender, EventArgs e)
        {
            // Retrieve the entered information from the booking form
            string productName = name.Text;
            string productType = type.Text;
            string productPrice = price.Text;
            string pWeight = weight.Text;
            string pQuantity = quantity.Text;

            // Connection string to your SQL Server database
            string connectionString = @"Data Source=LAB109PC11\SQLEXPRESS; Initial Catalog=SupermarketManagement; Integrated Security=True;";

            // SQL query to insert data into the testdrive table
            string query = @"INSERT INTO Products (name, category, price, weight, stock_quantity) 
                         VALUES (@name, @type, @price, @weight, @quantity)";

            // Create a new SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SQL command
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@name", productName);
                    command.Parameters.AddWithValue("@type", productType);
                    command.Parameters.AddWithValue("@price", productPrice);
                    command.Parameters.AddWithValue("@weight", pWeight);
                    command.Parameters.AddWithValue("@quantity", pQuantity);


                    try
                    {
                        // Open the database connection
                        connection.Open();

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted into Products table.");
                        }
                        else
                        {
                            MessageBox.Show("Error: No rows inserted into the Products table.");
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
            name.Text = "";
            type.Text = "";
            price.Text = "";
            weight.Text = "";
            quantity.Text = "";
        }

        private void remove_bttn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Retrieve the ID or any unique identifier of the selected row
                int selectedRowIndex = dataGridView2.SelectedRows[0].Index;
                int productId = Convert.ToInt32(dataGridView2.Rows[selectedRowIndex].Cells["product_id"].Value); // Assuming the ID column is named "ProductId"

                // Connection string to your SQL Server database
                string connectionString = @"Data Source=LAB109PC11\SQLEXPRESS; Initial Catalog=SupermarketManagement; Integrated Security=True;";

                // SQL query to delete the selected entry from the Products table
                string query = "DELETE FROM Products WHERE product_id = @ProductId";

                // Create a new SQL connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create a SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter to the command
                        command.Parameters.AddWithValue("@ProductId", productId);

                        try
                        {
                            // Open the database connection
                            connection.Open();

                            // Execute the SQL command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Remove the selected row from the DataGridView
                                dataGridView2.Rows.RemoveAt(selectedRowIndex);
                                MessageBox.Show("Entry deleted from the Products table.");
                            }
                            else
                            {
                                MessageBox.Show("Error: No rows deleted from the Products table.");
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

        private void name_TextChanged(object sender, EventArgs e)
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

using FinalProjectSupermarket;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace FinalProjectSupermarket
{
    public partial class Login : Form
    {
        SqlConnection sqlCon;

        public Login()
        {
            InitializeComponent();
        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(@"Data Source=LAB109PC11\SQLEXPRESS; Initial Catalog=SupermarketManagement; Integrated Security=True;");
            sqlCon.Open(); // Open the connection
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                // Query the database to check if the provided credentials are valid
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserAccounts WHERE Username = @Username AND Password = @Password", sqlCon);
                cmd.Parameters.AddWithValue("@Username", userName.Text);
                cmd.Parameters.AddWithValue("@Password", passWord.Text);

                int count = (int)cmd.ExecuteScalar(); // Execute the query and get the count of matching rows

                if (count > 0)
                {
                    // Authentication successful
                    MessageBox.Show("Login successful!");
                    // You may navigate to the next form or perform any other action here
                    
                    this.Hide();
                    Navigation navigation = new Navigation();
                    navigation.Show();
                    this.Hide();
                }
                else
                {
                    // Authentication failed
                    MessageBox.Show("Invalid username or password.");
                    this.Close();
                }
            }
           

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form1back = new Form1();
            form1back.Show();
            Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlCon.Close(); // Close the database connection when the form is closed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

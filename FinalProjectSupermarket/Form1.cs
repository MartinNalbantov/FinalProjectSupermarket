using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;


namespace FinalProjectSupermarket
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=LAB109PC11\SQLEXPRESS; Initial Catalog=SupermarketManagement; Integrated Security=True;");
            cn.Open();

            if (passWord.Text != string.Empty || rePassword.Text != string.Empty)
            {
                if (passWord.Text == rePassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from UserAccounts where Username='" + userName.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into UserAccounts values(@Username, @Email, @Password)", cn);
                        cmd.Parameters.AddWithValue("Username", userName.Text);
                        cmd.Parameters.AddWithValue("Password", passWord.Text);
                        cmd.Parameters.AddWithValue("Email", eMail.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Your have successfuly signed up", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void userName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (userName.Text.Length < 5 && userName.Text.Length != 0)
            {
                MessageBox.Show("Username should be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userName.Focus();

                e.Cancel = true;
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            if (userName.Text.Length >= 1 && userName.Text.Length < 5)
            {
                usernameValid.ForeColor = Color.Red;
            }
            if (userName.Text.Length >= 5)
            {
                usernameValid.ForeColor = Color.Green;
            }
        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {
            if (!(passWord.Text.Length > 8 && passWord.Text.Any(char.IsUpper) && passWord.Text.Any(char.IsLower) && passWord.Text.Any(char.IsDigit)))
            {
                passwordValid.ForeColor = Color.Red;
            }
            else
            {
                passwordValid.ForeColor = Color.Green;
            }
        }

        private void passWord_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(passWord.Text.Length > 8 && passWord.Text.Any(char.IsUpper) && passWord.Text.Any(char.IsLower) && passWord.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more password criteria(s) hasn't been met", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passWord.SelectAll();
                e.Cancel = true;
            }
        }

        private void buttonGoLogin_Click(object sender, EventArgs e)
        {
            Login loginInstead = new Login();
            loginInstead.Show();
            Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
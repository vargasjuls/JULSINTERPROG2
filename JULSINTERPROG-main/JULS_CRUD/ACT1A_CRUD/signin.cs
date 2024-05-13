using MySql.Data.MySqlClient;
namespace ACT1A_CRUD
{
    public partial class signin : Form
    {
        //Declare MySqlConnection for handling database connection
        private MySqlConnection connection;
        public signin()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=eiramdb;username=root;password=;");
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");

            }

            try
            {
                connection.Open();
                string logininquiry = "SELECT COUNT(*) FROM yuser  WHERE username = @username AND password = @password";

                MySqlCommand command = new MySqlCommand(logininquiry, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    Admin adminpage = new Admin();
                    adminpage.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Username and Password");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void LinkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register signuppage = new register();
            signuppage.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

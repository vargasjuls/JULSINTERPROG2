using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ACT1A_CRUD
{
    public partial class register : Form
    {
        private MySqlConnection connection;
        public register()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=eiramdb;username=root;password=;");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            signin loginpage = new signin();
            loginpage.Show();
            this.Hide();

        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            //declare Variable for inputs
            string name = txtName.Text;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please Enter both Name, Username and Password");

            }

            try
            {
                connection.Open();
                string registerquery = "INSERT INTO yuser (name, username ,password) VALUES (@name, @username, @password)";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registered Succesfully");
                }
                else
                {
                    MessageBox.Show("Failed to Register");
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

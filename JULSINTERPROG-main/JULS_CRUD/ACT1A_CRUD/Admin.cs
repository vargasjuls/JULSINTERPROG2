using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
namespace ACT1A_CRUD
{
    public partial class Admin : Form
    {
        private MySqlConnection connection;
        public Admin()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=eiramdb;username=root;password=;");
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            try
            {
                connection.Open();
                string showallrecordquery = "SELECT id, username, name, role FROM yuser ORDER BY ID ASC";
                MySqlCommand command = new MySqlCommand(showallrecordquery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells["ID"].Value.ToString();
                txtname.Text = row.Cells["NAME"].Value.ToString();
                txtusername.Text = row.Cells["USERNAME"].Value.ToString();
                cbrole.Text = row.Cells["ROLE"].Value.ToString();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtsearch.Text;
                connection.Open();
                string showallrecordquery = "SELECT id, username, name, role FROM yuser WHERE Username LIKE CONCAT('%', @search, '%') OR Name LIKE CONCAT('%', @search, '%') OR Role LIKE CONCAT('%', @search, '%') ";
                MySqlCommand command = new MySqlCommand(showallrecordquery, connection);
                command.Parameters.AddWithValue("@search", search);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

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

        private void btnadd_Click(object sender, EventArgs e)
        {
            //declare Variable for inputs
            string name = txtname.Text;
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string role = cbrole.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(role))
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
                command.Parameters.AddWithValue("@role", role);

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
            loaddata();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string name = txtname.Text;
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string role = cbrole.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please Enter both Name, Username, Role and Password");

            }

            try
            {
                connection.Open();
                string updatequery = "UPDATE yuser SET name = @name, username = @username, password = @password, role = @role WHERE id = @id";
                MySqlCommand command = new MySqlCommand(updatequery, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated Succesfully");
                }
                else
                {
                    MessageBox.Show("Failed to Update");
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
            loaddata();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            signin signin = new signin ();
            signin.Show();
            this.Hide();
        }
    }
}

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
    public partial class Form3 : Form
    {
        private MySqlConnection connection;
        public Form3()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=yesyes;username=root;password=;");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void loaddata()
        {
            try
            {
                connection.Open();
                string showallrecordquery = "SELECT id, username, name, role FROM table1 ORDER BY id ASC";
                MySqlCommand command = new MySqlCommand(showallrecordquery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }

            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string showallrecordquery = "SELECT FROM yuser WHERE Username LIKE CONCAT('%', @search, '%') OR Name LIKE CONCAT('%', @search, '%') OR Role LIKE CONCAT('%', @search, '%') ";
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
    }
}

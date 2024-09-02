using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace CRUDPractice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            MySqlCommand comm;
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection(dbConnection.dbConn);

            try
            {

                dgvNames.Rows.Clear();
                conn.Open();

                comm = new MySqlCommand("SELECT * FROM tblnames", conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    dgvNames.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                }

                reader.Close();
                conn.Close();
                dgvNames.ClearSelection();
            }

            catch (Exception)
            {
                MessageBox.Show("Error Has Occured While Fetching The Data In Database");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MySqlCommand comm;
            MySqlConnection conn = new MySqlConnection(dbConnection.dbConn);

            try
            {
                conn.Open();

                comm = new MySqlCommand("INSERT INTO tblnames(firstName, middleName, lastName) VALUES(@firstName, @middleName, @lastName)", conn);
                comm.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                comm.Parameters.AddWithValue("@middleName", txtMiddleName.Text);
                comm.Parameters.AddWithValue("@lastName", txtLastName.Text);
                comm.ExecuteNonQuery();

                MessageBox.Show("New Information Has Been Added In Database");

                conn.Close();

                loadData();
            }

            catch (Exception)
            {
                MessageBox.Show("Error Has Occured While Adding New Information In Database");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dbConnection.dbConn);
            MySqlCommand comm;
            MySqlDataReader reader;

            try
            {
                dgvNames.Rows.Clear();
                conn.Open();

                comm = new MySqlCommand("SELECT * FROM tblnames WHERE firstName = '" + txtFirstName.Text + "'", conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    dgvNames.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                }

                reader.Close();
                conn.Close();
                dgvNames.ClearSelection();
            }

            catch (Exception)
            {
                MessageBox.Show("Error Has Occured While Searching Information In Database");
            }
        }

        private void dgvNames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string? currentID = dgvNames.Rows[dgvNames.CurrentCell.RowIndex].Cells[0].Value.ToString();

            MySqlConnection conn = new MySqlConnection(dbConnection.dbConn);
            MySqlCommand comm;
            MySqlDataReader reader;

            try
            {
                conn.Open();

                comm = new MySqlCommand($"SELECT * FROM tblnames WHERE ID = {currentID}", conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    txtFirstName.Text = reader[1].ToString();
                    txtMiddleName.Text = reader[2].ToString();
                    txtLastName.Text = reader[3].ToString();

                }

                reader.Close();
                conn.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Error Has Occured While Opening Update Function");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string? currentID = dgvNames.Rows[dgvNames.CurrentCell.RowIndex].Cells[0].Value.ToString();

            MySqlConnection conn = new MySqlConnection(dbConnection.dbConn);
            MySqlCommand comm;

            try
            {
                conn.Open();

                comm = new MySqlCommand($"UPDATE tblnames SET firstName = @firstName, middleName = @middleName, lastName = @lastName WHERE ID = {currentID}", conn);
                comm.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                comm.Parameters.AddWithValue("@middleName", txtMiddleName.Text);
                comm.Parameters.AddWithValue("@lastName", txtLastName.Text);
                comm.ExecuteNonQuery();

                MessageBox.Show("Information Has Been Updated");

                conn.Close();
                loadData();
            }

            catch (Exception)
            {
                MessageBox.Show("Error Has Occured While Updating The Information");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string? currentID = dgvNames.Rows[dgvNames.CurrentCell.RowIndex].Cells[0].Value.ToString();

            MySqlConnection conn = new MySqlConnection(dbConnection.dbConn);
            MySqlCommand comm;

            try
            {
                conn.Open();

                comm = new MySqlCommand($"DELETE FROM tblnames WHERE ID = {currentID}", conn);
                comm.ExecuteNonQuery();

                MessageBox.Show("Information Has Been Deleted");

                conn.Close();
                loadData();
            }

            catch (Exception)
            {
                MessageBox.Show("Error Has Occured While Deleting Information");
            }
        }
    }
}

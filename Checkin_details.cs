using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Checkin_details : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private int selectedRowId = -1;
        public Checkin_details()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM customer", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        MessageBox.Show("Data loaded successfully, rows: " + dataTable.Rows.Count);
                    }

                    // Ensure AutoGenerateColumns is true
                    dataGridView1.AutoGenerateColumns = true;

                    // Clear any previous columns
                    dataGridView1.Columns.Clear();

                    // Set the DataSource to display the data
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Handle row selection in DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells["Id"].Value != DBNull.Value)
                {
                    selectedRowId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                }
                else
                {
                    selectedRowId = -1; // Reset if ID is DBNull
                }
            }
        }
        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeRoom_Click(object sender, EventArgs e)
        {
            change_room change_Room = new change_room();
            change_Room.Show();
        }

        private void cusButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

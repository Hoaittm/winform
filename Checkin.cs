using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Checkin : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

        public Checkin()
        {
            InitializeComponent();
            LoadData(); // Load data on form initialization
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT id, name, cccd, type, datecheckin, datecheckout, price FROM booking", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.AutoGenerateColumns = true; // Automatically generate columns
                    dataGridView1.DataSource = dataTable; // Set DataSource

                    //if (dataTable.Rows.Count > 0)
                    //{
                    //    MessageBox.Show("Data loaded successfully, rows: " + dataTable.Rows.Count);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("No data found.");
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                // Ensure the ID is not DBNull before converting
                if (selectedRow.Cells["id"].Value != DBNull.Value)
                {
                    // Use the ID value as needed
                    int selectedRowId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    // You can use selectedRowId for further operations if required
                }
            }
        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_checkindetail_Click(object sender, EventArgs e)
        {
            Checkin_details checkinDetails = new Checkin_details();
            checkinDetails.Show();
        }

        private void cusButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(madatphong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đặt phòng để tìm kiếm!");
                return;
            }

            string bookingId = madatphong.Text; // Assuming booking ID is a string

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, name, cccd, type, datecheckin, datecheckout, price FROM booking WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", bookingId); // Pass the booking ID

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve customer information
                                madatphong.Text = reader["id"].ToString();
                                hovaten.Text = reader["name"].ToString();
                                cancuoccongdan.Text = reader["cccd"].ToString();
                                tenloaiphong.Text = reader["type"].ToString();
                                ngaynhan.Text = reader["datecheckin"].ToString();
                                ngaytra.Text = reader["datecheckout"].ToString();
                                gia.Text = reader["price"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy đặt phòng với mã này.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This event can be used for additional functionality when a cell is clicked
        }

        private void cusButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

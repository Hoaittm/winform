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
    public partial class roomType_manage : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

        public roomType_manage()
        {
            InitializeComponent();
            LoadTypeRoomData();
        }
        private void LoadTypeRoomData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT * FROM typeroom"; // Adjust the query as needed
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                System.Data.DataTable regulationsTable = new System.Data.DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(regulationsTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = regulationsTable; // Make sure your DataGridView is named regulationsDataGridView

                    dataGridView1.Columns["id"].HeaderText = "Mã";
                    dataGridView1.Columns["name"].HeaderText = "Tên loại phòng";
                    dataGridView1.Columns["quantityuser"].HeaderText = "Số lượng tối đa";
                    dataGridView1.Columns["price"].HeaderText = "Giá";


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error loading typeroom data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cusButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timkiemloaiphong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tenphongtimkiem.Text))
            {
                MessageBox.Show("Vui lòng nhập mã loại phòng để tìm kiếm!");
                return;
            }

            string id = tenphongtimkiem.Text; // Assuming booking ID is a string

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM typeroom WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id); // Pass the booking ID

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve customer information
                                maloaiphong.Text = reader["id"].ToString();
                                tenloaiphong.Text = reader["name"].ToString();
                                songuoitoida.Text = reader["quantityuser"].ToString();
                                giaphong.Text = reader["price"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy tên loại phòng này.");
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

        private void capnhatphong_Click(object sender, EventArgs e)
        {
            // Ensure that the regulation name textbox is not empty
            if (string.IsNullOrEmpty(tenloaiphong.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng để cập nhật!");
                return;
            }

            // Prepare your SQL update query
            string query = "UPDATE typeroom SET name = @name, quantityuser = @quantityuser,price=@price WHERE name = @name";

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@name", tenloaiphong.Text); // Regulation name to be updated
                        command.Parameters.AddWithValue("@quantityuser", songuoitoida.Text); // New value
                        command.Parameters.AddWithValue("@price", giaphong.Text); // New description

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật quy định thành công!");
                            LoadTypeRoomData(); // Reload the DataGridView to reflect changes
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công! Vui lòng kiểm tra lại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}

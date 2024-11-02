using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace HotelManagementSystem
{
    public partial class room_manage : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

        public room_manage()
        {
            InitializeComponent();
            LoadRoomData();

        }

        private void LoadRoomData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT * FROM room"; // Adjust the query as needed
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                System.Data.DataTable regulationsTable = new System.Data.DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(regulationsTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = regulationsTable; // Make sure your DataGridView is named regulationsDataGridView

                    dataGridView1.Columns["id"].HeaderText = "Mã";
                    dataGridView1.Columns["nameroom"].HeaderText = "Tên phòng";
                    dataGridView1.Columns["typeroom"].HeaderText = "Tên loại phòng";
                    dataGridView1.Columns["quantityuser"].HeaderText = "Số lượng tối đa";
                    dataGridView1.Columns["price"].HeaderText = "Giá";
                    dataGridView1.Columns["status"].HeaderText = "Trạng thái";


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error loading typeroom data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txt_editroom_Click(object sender, EventArgs e)
        {
            roomType_manage roomType_Manage = new roomType_manage();
            roomType_Manage.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cusButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timkiemphong_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(maphongtimkiem.Text))
            {
                MessageBox.Show("Vui lòng nhập mã loại phòng để tìm kiếm!");
                return;
            }

            string id = maphongtimkiem.Text; // Assuming booking ID is a string

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
                                maphong.Text = reader["id"].ToString();
                                loaiphong.Text = reader["name"].ToString();
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

        private void themphongmoi_Click(object sender, EventArgs e)
        {
            // Validate that all required fields are filled out
            if (string.IsNullOrEmpty(maphong.Text) ||
                string.IsNullOrEmpty(tenphongcuaphong.Text) ||
                string.IsNullOrEmpty(loaiphong.Text) ||
                string.IsNullOrEmpty(songuoitoida.Text) ||
                string.IsNullOrEmpty(giaphong.Text) ||
                string.IsNullOrEmpty(trangthaicuaphong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to convert quantity user and price to appropriate types
            if (!int.TryParse(songuoitoida.Text, out int quantityUser) || !decimal.TryParse(giaphong.Text, out decimal price))
            {
                MessageBox.Show("Giá phòng và số lượng tối đa phải là số hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open(); // Open connection once

                    // Check if the room with the given ID already exists
                    string checkQuery = "SELECT COUNT(*) FROM room WHERE nameroom = @nameroom";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@nameroom", tenphongcuaphong.Text);
                        int existingRooms = (int)checkCommand.ExecuteScalar();

                        if (existingRooms > 0)
                        {
                            MessageBox.Show("Phòng đã tồn tại trong cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Room already exists, exit the method
                        }
                    }

                    // Prepare the insert query
                    string query = "INSERT INTO room (nameroom, typeroom, quantityuser, price, status) VALUES ( @nameroom, @typeroom, @quantityuser, @price, @status)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adding parameters
                        //command.Parameters.AddWithValue("@id", maphong.Text); // Include the room ID
                        command.Parameters.AddWithValue("@nameroom", tenphongcuaphong.Text);
                        command.Parameters.AddWithValue("@typeroom", loaiphong.Text);
                        command.Parameters.AddWithValue("@quantityuser", quantityUser);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@status", trangthaicuaphong.Text);

                        // Execute the command
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm phòng mới thành công.");
                            LoadRoomData(); // Refresh the room data displayed in the application

                            // Optionally, clear the input fields
                            // maphong.Clear();
                            // tenphongcuaphong.Clear();
                            // loaiphong.Clear();
                            // songuoitoida.Clear();
                            // giaphong.Clear();
                            // trangthaicuaphong.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi thêm phòng.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void capnhatphong_Click(object sender, EventArgs e)
        {
            // Ensure that the room ID textbox is not empty
            if (string.IsNullOrEmpty(maphong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng để cập nhật!");
                return;
            }

            // Prepare your SQL update query
            string query = "UPDATE room SET nameroom = @nameroom, status = @status, typeroom = @typeroom, quantityuser = @quantityuser, price = @price WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@id", maphong.Text); // Room ID for the WHERE clause
                        command.Parameters.AddWithValue("@nameroom", tenphongcuaphong.Text);
                        command.Parameters.AddWithValue("@status", trangthaicuaphong.Text);
                        command.Parameters.AddWithValue("@typeroom", loaiphong.Text);
                        command.Parameters.AddWithValue("@quantityuser", songuoitoida.Text);
                        command.Parameters.AddWithValue("@price", giaphong.Text);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật phòng thành công!");
                            LoadRoomData(); // Reload the DataGridView to reflect changes
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate the input fields with the selected row data
                maphong.Text = row.Cells["id"].Value.ToString();
                tenphongcuaphong.Text = row.Cells["nameroom"].Value.ToString();
                loaiphong.Text = row.Cells["typeroom"].Value.ToString();
                songuoitoida.Text = row.Cells["quantityuser"].Value.ToString();
                giaphong.Text = row.Cells["price"].Value.ToString();
                trangthaicuaphong.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void export2Excel(DataGridView g, string duongdan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void xuấtFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export2Excel(dataGridView1, @"D:\C#", "quanlyphong" +
                "");
            MessageBox.Show("Xuất file thành công");
        }
    }
}

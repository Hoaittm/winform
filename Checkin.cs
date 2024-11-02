using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Checkin : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private int selectedRowId = -1;
        public Color RoomColor { get; set; }
        public Checkin()
        {
            InitializeComponent();
            LoadData(); // Load data on form initialization
            LoadRoomTypes();
        }
        public void UpdateRoomColor()
        {
            this.BackColor = RoomColor; // Cập nhật màu sắc cho form (hoặc bạn có thể áp dụng vào một control cụ thể)
        }
        private Dictionary<string, Color> roomTypeColors = new Dictionary<string, Color>
{
    { "Phòng Suite (SUT)", Color.DarkOrange },
    { "Phòng Deluxe (DLX)", Color.Violet },
    { "Phòng Superior (SUP)", Color.DeepSkyBlue },
      { "Phòng Standard (STD)", Color.LimeGreen },
        };
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM checkin", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.AutoGenerateColumns = true; // Automatically generate columns
                    dataGridView1.DataSource = dataTable; // Set DataSource
                    dataGridView1.Columns["id"].HeaderText = "Mã Nhận phòng";
                    dataGridView1.Columns["name"].HeaderText = "Họ và Tên";
                    dataGridView1.Columns["CCCD"].HeaderText = "Số CCCD";
                    dataGridView1.Columns["nameroom"].HeaderText = "Tên phòng";

                    dataGridView1.Columns["datecheckin"].HeaderText = "Ngày nhận";
                    dataGridView1.Columns["datecheckout"].HeaderText = "Ngày trả";

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
        private void LoadRoomTypes()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT DISTINCT typeroom FROM room"; // Lấy danh sách các loại phòng
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable typeTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(typeTable);

                    loaiphonglucnhanphong.DataSource = typeTable;
                    loaiphonglucnhanphong.DisplayMember = "typeroom"; // Hiển thị tên loại phòng
                    loaiphonglucnhanphong.ValueMember = "typeroom"; // Giá trị sử dụng cho loại phòng
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error loading room types: " + ex.Message);
                }
            }
        }
        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void cusButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nhanphong_Click(object sender, EventArgs e)
        {
            // Gather data from the form fields
            string id = madatphong.Text; // Booking ID
            string name = hovaten.Text; // Customer's name
            long cccd;
            if (!long.TryParse(cancuoccongdan.Text, out cccd)) // Assuming you have a textbox for CCCD
            {
                MessageBox.Show("CCCD không hợp lệ.");
                return;
            }
            string nameroom = phong.Text; // Room type
            DateTime datecheckin = DateTime.Parse(ngaynhan.Text); // Check-in date
            DateTime datecheckout = DateTime.Parse(ngaytra.Text); // Check-out date

            // Kiểm tra xem phòng đã được đặt chưa
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM checkin  WHERE nameroom = @nameroom ";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@nameroom", nameroom);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Phòng đã được chọn. Vui lòng chọn phòng khác.");
                        return; // Dừng lại nếu phòng đã được đặt
                    }
                }
            }

            // Nếu phòng chưa được đặt, thực hiện insert
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    // Insert booking into checkin table
                    string insertQuery = "INSERT INTO checkin (id, name, CCCD, nameroom, datecheckin, datecheckout) " +
                                         "VALUES (@id, @name, @CCCD, @nameroom, @datecheckin, @datecheckout)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@CCCD", cccd);
                        command.Parameters.AddWithValue("@nameroom", nameroom);
                        command.Parameters.AddWithValue("@datecheckin", datecheckin);
                        command.Parameters.AddWithValue("@datecheckout", datecheckout);

                        // Execute the insert command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Update the room status to indicate it's occupied
                            string updateQuery = "UPDATE room SET status = 'Co Nguoi' WHERE nameroom = @nameroom";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@nameroom", nameroom);
                                updateCommand.ExecuteNonQuery(); // Execute the update command
                            }

                            MessageBox.Show("Nhận phòng thành công!");
                            Checkout checkoutForm = new Checkout();
                            checkoutForm.RoomColor = roomTypeColors[loaiphonglucnhanphong.Text]; // Lấy màu sắc tương ứng với loại phòng
                            checkoutForm.UpdateRoomColor();
                            LoadData(); // Refresh the data

                        }
                        else
                        {
                            MessageBox.Show("Nhận phòng không thành công. Vui lòng thử lại.");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Lỗi định dạng dữ liệu: " + ex.Message);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Lỗi cơ sở dữ liệu: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void timkiemnhanphong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(madatphong.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đặt phòng để tìm kiếm!");
                return;
            }

            string bookingId = madatphong.Text; // Assuming booking ID is a string
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                string checkBookingQuery = "SELECT COUNT(*) FROM checkin WHERE id = @id";
                using (SqlCommand checkCommand = new SqlCommand(checkBookingQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", bookingId);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã đặt phòng này đã tồn tại. Vui lòng nhập mã khác.");
                        return; // Dừng lại nếu mã đã tồn tại
                    }
                }
            }
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, name, cccd, type, datecheckin, datecheckout, price,type,idroom FROM booking WHERE id = @id";
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
                                decimal price = reader.GetInt32(reader.GetOrdinal("price")); // Đảm bảo cột 'price' có kiểu dữ liệu decimal trong cơ sở dữ liệu

                                // Định dạng giá thành tiền tệ
                                gia.Text = price.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
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

        private void loaiphonglucnhanphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaiphonglucnhanphong.SelectedValue != null)
            {
                string selectedType = loaiphonglucnhanphong.SelectedValue.ToString();

                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    string query = "SELECT * FROM room WHERE typeroom = @typeroom"; // Lấy các phòng theo kiểu phòng
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@typeroom", selectedType);

                    DataTable roomTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(roomTable);

                        // Cập nhật ComboBox phong với danh sách phòng
                        phong.DataSource = roomTable;
                        phong.DisplayMember = "nameroom"; // Hiển thị tên phòng
                        phong.ValueMember = "id"; // Giá trị sử dụng cho ID phòng

                        phong.SelectedIndex = -1; // Bỏ chọn bất kỳ lựa chọn hiện tại
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error loading rooms: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room type.");
            }

        }
        private void phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (phong.SelectedIndex != -1)
            {
                DataRowView selectedRow = phong.SelectedItem as DataRowView;

                if (selectedRow != null) // Kiểm tra để tránh NullReferenceException
                {
                    // Lấy id và tên phòng
                    int roomId = (int)selectedRow["id"];
                    string tenPhong = (string)selectedRow["nameroom"];

                    // Cập nhật tên phòng vào ComboBox (hoặc Label nếu bạn sử dụng)
                    phong.Text = tenPhong; // Hoặc nếu bạn muốn sử dụng Label
                                           // labelTenPhong.Text = tenPhong; // Cập nhật vào Label nếu có
                }
            }
            else
            {
                phong.Text = ""; // Xóa text nếu không có phòng nào được chọn
            }
        }
        private void btn_dongnhanphong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xemchitietnhanphong_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy dữ liệu từ các cột phù hợp với tên cột từ cơ sở dữ liệu
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                //int idroom = Convert.ToInt32(selectedRow.Cells["idroom"].Value);
                //string name = selectedRow.Cells["name"].Value.ToString();
                //int price = Convert.ToInt32(selectedRow.Cells["idroom"].Value);
                string nameroom = selectedRow.Cells["nameroom"].Value.ToString();
                string datecheckin = selectedRow.Cells["datecheckin"].Value.ToString();
                string datecheckout = selectedRow.Cells["datecheckout"].Value.ToString();

                Checkin_details checkin_Details = new Checkin_details();
                checkin_Details.FormClosed += (s, args) => LoadData();
                // Truyền dữ liệu với đúng thứ tự tham số
                checkin_Details.SetCheckinDetails(id, datecheckin, datecheckout, nameroom);

                // Hiển thị form booking_details
                checkin_Details.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong danh sách trước.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

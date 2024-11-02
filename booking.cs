using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManagementSystem.booking;

namespace HotelManagementSystem
{
    public partial class booking : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private List<Booking> bookings = new List<Booking>();
        private int selectedRowId = -1;
        private object selectedRow;
      
        public booking()
        {
            InitializeComponent();
            LoadData();
            this.datecheckin.ValueChanged += new System.EventHandler(this.datecheckin_ValueChanged);
            this.datecheckout.ValueChanged += new System.EventHandler(this.datecheckout_ValueChanged);
        
            this.Refresh();
        }


        public void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM booking", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = dataTable;

                    // Tùy chỉnh các tiêu đề cột
                    dataGridView1.Columns["id"].HeaderText = "Mã đặt phòng";
                    dataGridView1.Columns["name"].HeaderText = "Tên";
                    dataGridView1.Columns["idroom"].HeaderText = "Mã phòng";
                    dataGridView1.Columns["quatityuser"].HeaderText = "Số Người";
                    dataGridView1.Columns["price"].HeaderText = "Giá phòng";
                    dataGridView1.Columns["type"].HeaderText = "Loại";
                    dataGridView1.Columns["night"].HeaderText = "Số Đêm";
                    dataGridView1.Columns["datecheckin"].HeaderText = "Ngày nhận";
                    dataGridView1.Columns["datecheckout"].HeaderText = "Ngày trả";
                    dataGridView1.Columns["cccd"].HeaderText = "Số CCCD";
                    dataGridView1.Columns["totalPrice"].HeaderText = "Tổng tiền";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }






        private void thongtinloaiphong_Enter(object sender, EventArgs e)
        {
            // Lấy loại phòng đã chọn từ ComboBox trong "Thông tin đăng ký"
            string selectedRoomType = loaiphong.SelectedItem?.ToString();

            // Nếu đã chọn loại phòng, lấy và hiển thị thông tin chi tiết
            if (!string.IsNullOrEmpty(selectedRoomType))
            {
                RoomType roomType = GetRoomTypeDetails(selectedRoomType);

                // Kiểm tra nếu thông tin loại phòng tồn tại
                if (roomType != null)
                {
                    // Hiển thị thông tin loại phòng

                    tenloaiphong.Text = roomType.TenLoai;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        public class RoomType
        {

            public int MaLoaiPhong { get; set; }
            public string TenLoai { get; set; }
            public int SoNguoiToiDa { get; set; }
            public int Gia { get; set; }

        }
        private RoomType GetRoomTypeDetails(string name)
        {
            RoomType roomType = null;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT id,name,quantityuser,price FROM typeroom WHERE name = @name";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                roomType = new RoomType
                                {

                                    MaLoaiPhong = reader.GetInt32(0), // Assuming it's an integer
                                    TenLoai = reader.GetString(1),
                                    SoNguoiToiDa = reader.GetInt32(2),
                                    Gia = reader.GetInt32(3)
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            return roomType; // Re
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy loại phòng đã chọn từ ComboBox
            string selectedRoomType = loaiphong.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedRoomType))
            {
                RoomType roomType = GetRoomTypeDetails(selectedRoomType);

                if (roomType != null)
                {
                    // Hiển thị tên loại phòng
                    tenloaiphong.Text = roomType.TenLoai;
                    maphong.Text = roomType.MaLoaiPhong.ToString();
                    quantityuser.Text = roomType.SoNguoiToiDa.ToString();
                    // Hiển thị giá trực tiếp mà không cần chuyển đổi
                    price.Text = roomType.Gia.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")); /// Định dạng giá trị với dấu phân cách hàng nghìn và ký tự "đ"
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }



        // Phương thức để lấy giá phòng
        private int GetRoomPrice(int id)
        {
            int price = 0; // Khai báo biến giá với kiểu int

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT price FROM typeroom WHERE id = @id"; // Thay điều kiện lọc bằng ID loại phòng
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id); // Truyền ID loại phòng

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar(); // Thực thi truy vấn

                        if (result != null)
                        {
                            price = Convert.ToInt32(result); // Chuyển đổi kết quả sang int
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

            return price; // Trả về giá
        }



        private void UpdateBookingList()
        {
            // Clear the DataGridView

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            LoadData();
            //dataGridView1.DataSource = bookings;

        }




        private void ClearInputs()
        {
            // Clear all input fields
            maphong.Clear();
            name.Clear();
            cmnd.Clear();
            loaiphong.SelectedIndex = -1; // Reset ComboBox
            datecheckin.Value = DateTime.Now; // Reset DateTimePicker
            datecheckout.Value = DateTime.Now; // Reset DateTimePicker
            quantityuser.Clear();
            maphong.Clear();
            price.Clear();
        }


        private void night_TextChanged(object sender, EventArgs e)
        {
            DateTime checkInDate = datecheckin.Value; // Giả sử datecheckin là một DateTimePicker
            DateTime checkOutDate = datecheckout.Value; // Giả sử datecheckout là một DateTimePicker

            // Kiểm tra xem ngày trả có phải sau ngày nhận hay không
            if (checkOutDate < checkInDate)
            {
                MessageBox.Show("Ngày trả phải sau ngày nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                night.Text = "0"; // Đặt số đêm về 1
                return;
            }

            // Tính toán số đêm
            int nights = CalculateNights(checkInDate, checkOutDate);
            night.Text = nights.ToString(); // Giả sử night là một TextBox để hiển thị số đêm
        }
        private void UpdateNights()
        {
            DateTime checkInDate = datecheckin.Value; // Ngày nhận
            DateTime checkOutDate = datecheckout.Value; // Ngày trả

            // Kiểm tra xem ngày trả có phải sau ngày nhận hay không
            if (checkOutDate < checkInDate)
            {
                MessageBox.Show("Ngày trả phải sau ngày nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                night.Text = "0"; // Đặt số đêm về 0 nếu không hợp lệ
                return;
            }

            // Tính toán số đêm
            int nights = CalculateNights(checkInDate, checkOutDate);
            night.Text = nights.ToString(); // Cập nhật số đêm vào TextBox
        }

        private int CalculateNights(DateTime checkIn, DateTime checkOut)
        {

            // Giả sử checkIn là vào lúc 14:00
            DateTime checkInAt14 = checkIn.Date.AddHours(14);

            // Giả sử checkOut là trước 12:00 của ngày trả
            DateTime checkOutBefore12 = checkOut.Date.AddHours(12);

            // Tính toán số đêm bằng TimeSpan
            TimeSpan duration = checkOutBefore12 - checkInAt14;

            // Kiểm tra duration và trả về số đêm
            if (duration.TotalDays < 0)
            {
                return 0; // Không tính đêm
            }
            else
            {
                return (int)duration.TotalDays + 1; // Tính cả ngày trả
            }
        }



        private void InsertBookingIntoDatabase(Booking booking)
        {
            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Make sure all fields are correct and present in the database
                string query = "INSERT INTO booking (name, cccd, type,quatityuser, datecheckin, datecheckout, price, night,idroom,totalPrice) " +
                               "VALUES (@name, @cccd, @type,@quatityuser, @datecheckin, @datecheckout, @price, @night,@idroom,@totalPrice)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ensure the parameter names match those used in the SQL statement

                    command.Parameters.AddWithValue("@name", booking.Ten);
                    command.Parameters.AddWithValue("@cccd", booking.Cccd);
                    command.Parameters.AddWithValue("@type", booking.LoaiPhong);
                    command.Parameters.AddWithValue("@quatityuser", booking.SoNguoi);
                    command.Parameters.AddWithValue("@datecheckin", booking.NgayNhan);
                    command.Parameters.AddWithValue("@datecheckout", booking.NgayTra);
                    command.Parameters.AddWithValue("@price", booking.Gia);
                    command.Parameters.AddWithValue("@night", booking.SoDem);
                    command.Parameters.AddWithValue("@idroom", booking.idroom);
                    decimal totalPrice = booking.Gia * booking.SoDem;
                    command.Parameters.AddWithValue("@totalPrice", totalPrice);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery(); // Execute the command
                        //MessageBox.Show("CCCD Value: " + booking.Cccd);

                    }
                    catch (SqlException sqlEx) // Catch SQL specific exceptions
                    {

                        MessageBox.Show("SQL Error: " + sqlEx.Message);
                    }
                    catch (Exception ex) // Catch general exceptions
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void txt_datphong_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(maphong.Text) ||
                string.IsNullOrEmpty(name.Text) ||
                string.IsNullOrEmpty(cmnd.Text) ||
                loaiphong.SelectedIndex == -1 ||
                string.IsNullOrEmpty(quantityuser.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            Booking booking = null; // Khai báo biến booking bên ngoài

            // Lấy giá phòng dựa trên loại phòng đã chọn
            RoomType roomType = GetRoomTypeDetails(loaiphong.SelectedItem.ToString());
            if (roomType == null)
            {
                MessageBox.Show("Không tìm thấy loại phòng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int giaValue = roomType.Gia; // Lấy giá từ RoomType
            if (!int.TryParse(quantityuser.Text, out int soNguoiValue) || soNguoiValue <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng người hợp lệ (số nguyên dương).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu giá hợp lệ, tạo booking

            booking = new Booking
            {

                idroom = int.TryParse(maphong.Text, out int soNguoi) ? soNguoi : 0,
                Ten = name.Text,
                Cccd = long.TryParse(cmnd.Text, out long cccdValue) ? cccdValue : 0,
                LoaiPhong = loaiphong.Text,
                NgayNhan = datecheckin.Text,
                NgayTra = datecheckout.Text,
                SoNguoi = soNguoiValue,
                Gia = giaValue, // Sử dụng giá phòng đã lấy
                SoDem = int.TryParse(night.Text, out int soDemValue) ? soDemValue : 0,
            };

            // Insert into database
            InsertBookingIntoDatabase(booking);
            LoadData();
            // Update the booking list
            bookings.Add(booking);
            UpdateBookingList();
            ClearInputs();

        }

        private void txt_xemchitietdatphong_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy dữ liệu từ các cột phù hợp với tên cột từ cơ sở dữ liệu
                //int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                int idroom = Convert.ToInt32(selectedRow.Cells["idroom"].Value);
                //string name = selectedRow.Cells["name"].Value.ToString();
                //int price = Convert.ToInt32(selectedRow.Cells["idroom"].Value);
                string type = selectedRow.Cells["type"].Value.ToString();
                string datecheckin = selectedRow.Cells["datecheckin"].Value.ToString();
                string datecheckout = selectedRow.Cells["datecheckout"].Value.ToString();
                long cccd;
                if (!long.TryParse(selectedRow.Cells["cccd"].Value.ToString(), out cccd))
                {
                    MessageBox.Show("CCCD không hợp lệ.");
                    return; // Ngừng thực hiện nếu cccd không hợp lệ
                }
                int night = Convert.ToInt32(selectedRow.Cells["night"].Value);
                string customerName = "";
                string customerLoaiKhachHang = "";
                string customerGioiTinh = "";
                int customerDienThoai = 0;
                string customerQuocTich = "";
                string customerNgaySinh = "";
                string customerDiaChi = "";
                string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name,dob, address,type,phone,gender, country FROM customer WHERE cccd = @cccd";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cccd", cccd);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                customerName = reader["name"].ToString();
                                customerNgaySinh = reader["dob"].ToString();
                                customerDiaChi = reader["address"].ToString();
                                customerLoaiKhachHang = reader["type"].ToString();
                                customerDienThoai = Convert.ToInt32(reader["phone"]);
                                customerGioiTinh = reader["gender"].ToString();
                                customerQuocTich = reader["country"].ToString();
                            }
                        }
                    }
                }
                // Khởi tạo form booking_details và truyền dữ liệu vào form này
                booking_details booking_Details = new booking_details();

                // Truyền dữ liệu với đúng thứ tự tham số
                booking_Details.SetBookingDetails(datecheckin, datecheckout, customerName, type, cccd, idroom, night, customerNgaySinh, customerDiaChi, customerLoaiKhachHang, customerDienThoai, customerGioiTinh, customerQuocTich);

                // Hiển thị form booking_details
                booking_Details.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong danh sách trước.");
            }
        }

        private void timkiemdatphong_Click(object sender, EventArgs e)
        {
            string CCCD = txt_cccd.Text;

            if (string.IsNullOrEmpty(CCCD))
            {
                MessageBox.Show("Vui lòng nhập số cccd để tìm kiếm!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT name,dob,cccd, address,type,phone,gender, country FROM customer WHERE cccd = @cccd";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cccd", CCCD);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy thông tin khách hàng
                                //string customerId = reader["id"].ToString();
                                string customerName = reader["name"].ToString();
                                string customerDob = reader["dob"].ToString();
                                string customerCccd = reader["cccd"].ToString();
                                string customerAddress = reader["address"].ToString();
                                string customerType = reader["type"].ToString();
                                string customerPhone = reader["phone"].ToString();
                                string customerGender = reader["gender"].ToString();
                                string customerCountry = reader["country"].ToString();

                                // Hiển thị thông tin khách hàng lên các điều khiển trong GroupBox\
                                //maphong.Text = customerId;
                                name.Text = customerName;
                                dob.Text = customerDob;
                                cmnd.Text = customerCccd;
                                address.Text = customerAddress;
                                type.Text = customerType;
                                phone.Text = customerPhone;
                                gender.Text = customerGender;
                                country.Text = customerCountry;

                                name.Enabled = false;
                                dob.Enabled = false;
                                cmnd.Enabled = false;
                                address.Enabled = false;
                                type.Enabled = false;
                                phone.Enabled = false;
                                gender.Enabled = false;
                                country.Enabled = false;


                                // Nếu cần hiển thị thêm điều khiển, có thể thêm vào như trong ví dụ trên
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Không tìm thấy khách hàng với CCCD này. Bạn có muốn thêm mới khách hàng không?", "Thông báo", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    customer_manage customerManage = new customer_manage();
                                    // Mở trang thêm khách hàng
                                    add_user addUserForm = new add_user(customerManage);
                                    addUserForm.ShowDialog();
                                }

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

        private void datecheckin_ValueChanged(object sender, EventArgs e)
        {
            UpdateNights();
        }

        private void dongPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datecheckout_ValueChanged(object sender, EventArgs e)
        {
            UpdateNights();
        }
    }
}
    public class Booking
    {
       
        public int id { get; set; }
        public string Ten { get; set; }
        public int SoNguoi {  get; set; }
        public long Cccd { get; set; }
        public string LoaiPhong { get; set; }

        public string NgayNhan { get; set; }
        public string NgayTra { get; set; }
      public int idroom {  get; set; }
        public int Gia { get; set; }
        public int SoDem { get; set; }
    }



using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class booking : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private List<Booking> bookings = new List<Booking>();
        private int selectedRowId = -1;
        public booking()
        {
            InitializeComponent();

        }






        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_bookingdetail_Click(object sender, EventArgs e)
        {
            booking_details booking_Details = new booking_details();
            booking_Details.Show();
        }


        //private void InitializeDataGridViewColumns()
        //{
        //    dataGridView1.Columns.Add("id", "ID");
        //    dataGridView1.Columns.Add("name", "Name");
        //    dataGridView1.Columns.Add("cccd", "CCCD");
        //    dataGridView1.Columns.Add("type", "Type");
        //    dataGridView1.Columns.Add("datecheckin", "Check-In Date");
        //    dataGridView1.Columns.Add("datecheckout", "Check-Out Date");
        //    dataGridView1.Columns.Add("price", "Price");
        //    dataGridView1.Columns.Add("night", "Nights");
        //}

        private void btn_search_Click(object sender, EventArgs e)
        {
            string CCCD = txt_cccd.Text;

            if (string.IsNullOrEmpty(CCCD))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại để tìm kiếm!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id,name,dob,cccd, address,type,phone,gender, country FROM customer WHERE cccd = @cccd";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cccd", CCCD);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy thông tin khách hàng
                                string customerId = reader["id"].ToString();
                                string customerName = reader["name"].ToString();
                                string customerDob = reader["dob"].ToString();
                                string customerCccd = reader["cccd"].ToString();
                                string customerAddress = reader["address"].ToString();
                                string customerType = reader["type"].ToString();
                                string customerPhone = reader["phone"].ToString();
                                string customerGender = reader["gender"].ToString();
                                string customerCountry = reader["country"].ToString();

                                // Hiển thị thông tin khách hàng lên các điều khiển trong GroupBox\
                                maphong.Text = customerId;
                                name.Text = customerName;
                                dob.Text = customerDob;
                                cmnd.Text = customerCccd;
                                address.Text = customerAddress;
                                type.Text = customerType;
                                phone.Text = customerPhone;
                                gender.Text = customerGender;
                                country.Text = customerCountry;

                                // Nếu cần hiển thị thêm điều khiển, có thể thêm vào như trong ví dụ trên
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này.");
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

        private void thongtindangky_Enter(object sender, EventArgs e)
        {

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

            public string TenLoai { get; set; }
            public string Gia { get; set; }

        }
        private RoomType GetRoomTypeDetails(string roomTypeName)
        {
            // Danh sách các loại phòng với thông tin chi tiết
            List<RoomType> roomTypes = new List<RoomType>
    {
        new RoomType { TenLoai = "Phòng Deluxe (DLX)", Gia = "1.950.000đ" },
        new RoomType { TenLoai = "Phòng Suite (SUT)", Gia = "1.000.000đ" },
        new RoomType { TenLoai = "Phòng Superior (SUP)", Gia = "1.300.000đ" },
        new RoomType { TenLoai = "Phòng Standard (STD)", Gia = "700.000đ" }
    };

            // Tìm loại phòng theo tên và trả về thông tin chi tiết
            return roomTypes.FirstOrDefault(rt => rt.TenLoai == roomTypeName);
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loaiphong_SelectedIndexChanged(object sender, EventArgs e)
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
                    // Hiển thị thông tin loại phòng ở phần "Thông tin loại phòng"
                    tenloaiphong.Text = roomType.TenLoai;
                    price.Text = roomType.Gia.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tenloaiphong_TextChanged(object sender, EventArgs e)
        {

        }
        private void cusButton1_Click(object sender, EventArgs e)
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

            // Continue with booking creation
            var booking = new Booking
            {
                MaDatPhong = maphong.Text,
                Ten = name.Text,
                Cccd = cmnd.Text,
                LoaiPhong = loaiphong.Text,
                NgayNhan = datecheckin.Text,
                NgayTra = datecheckout.Text,
                //SoLuong = quantityuser.Text,
                Gia = price.Text,
                SoDem = night.Text,
            };

            // Insert into database
            InsertBookingIntoDatabase(booking);

            // Update the booking list
            bookings.Add(booking);
            UpdateBookingList();
            ClearInputs();
        }


        private void UpdateBookingList()
        {
            // Clear the DataGridView

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();


            dataGridView1.DataSource = bookings;
            // Add each booking to the DataGridView
            //foreach (var booking in bookings)
            //{
            //    // Create a new row and get its index
            //    int rowIndex = dataGridView1.Rows.Add();

            //    // Access the newly created row using the row index
            //    DataGridViewRow row = dataGridView1.Rows[rowIndex];

            //    //// Assign values to cells in the new row
            //    //row.Cells["id"].Value = booking.MaDatPhong; // Column for Room Booking ID
            //    //row.Cells["name"].Value = booking.Ten;               // Column for Customer Name
            //    //row.Cells["cccd"].Value = booking.Cccd;             // Column for ID Card Number
            //    //row.Cells["type"].Value = booking.LoaiPhong;   // Column for Room Type
            //    //row.Cells["datecheckin"].Value = booking.NgayNhan;     // Column for Check-in Date
            //    //row.Cells["datecheckout"].Value = booking.NgayTra;       // Column for Check-out Date
            //    ///* row.Cells["SoLuong"].Value = booking.SoLuong; */  // Uncomment if needed
            //    //row.Cells["price"].Value = booking.Gia;               // Column for PriceF
            //    //row.Cells["night"].Value = booking.SoDem;           // Column for Number of Nights
            //    InitializeDataGridViewColumns();
            //}
        }


        private void InsertBookingIntoDatabase(Booking booking)
        {
            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Make sure all fields are correct and present in the database
                string query = "INSERT INTO booking (name, cccd, type, datecheckin, datecheckout, price, night) " +
                               "VALUES (@name, @cccd, @type, @datecheckin, @datecheckout, @price, @night)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ensure the parameter names match those used in the SQL statement
                    command.Parameters.AddWithValue("@name", booking.Ten);
                    command.Parameters.AddWithValue("@cccd", booking.Cccd);
                    command.Parameters.AddWithValue("@type", booking.LoaiPhong);
                    command.Parameters.AddWithValue("@datecheckin", booking.NgayNhan);
                    command.Parameters.AddWithValue("@datecheckout", booking.NgayTra);
                    command.Parameters.AddWithValue("@price", booking.Gia);
                    command.Parameters.AddWithValue("@night", booking.SoDem);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery(); // Execute the command
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


        private void ClearInputs()
        {
            // Clear all input fields
            maphong.Clear();
            name.Clear();
            cmnd.Clear();
            loaiphong.SelectedIndex = -1; // Reset ComboBox
            datecheckin.Value = DateTime.Now; // Reset DateTimePicker
            datecheckout.Value = DateTime.Now; // Reset DateTimePicker
            //quantityuser.Clear();
            price.Clear();
        }

        private void datecheckin_ValueChanged(object sender, EventArgs e)
        {

        }
        private int CalculateNights(DateTime checkin, DateTime checkout)
        {
            return (checkout - checkin).Days;
        }

        private void night_TextChanged(object sender, EventArgs e)
        {
            DateTime checkInDate = datecheckin.Value; // Giả sử datecheckin là một DateTimePicker
            DateTime checkOutDate = datecheckout.Value; // Giả sử datecheckout là một DateTimePicker

            // Kiểm tra xem ngày trả có phải sau ngày nhận hay không
            if (checkOutDate < checkInDate)
            {
                MessageBox.Show("Ngày trả phải sau ngày nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                night.Text = "1"; // Đặt số đêm về 0
                return;
            }

            // Tính toán số đêm và cập nhật trường 'night'
            int nights = CalculateNights(checkInDate, checkOutDate);
            night.Text = nights.ToString(); // Giả sử night là một TextBox để hiển thị số đêm
        }

        private void txt_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Booking
    {
        public string MaDatPhong { get; set; }
        public string Ten { get; set; }

        public string Cccd { get; set; }
        public string LoaiPhong { get; set; }

        public string NgayNhan { get; set; }
        public string NgayTra { get; set; }
      
        public string Gia { get; set; }
        public string SoDem { get; set; }
    }
}


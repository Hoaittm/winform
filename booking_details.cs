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
    public partial class booking_details : Form
    {

        public booking_details()
        {
            InitializeComponent();



        }
        public void SetBookingDetails(string datecheckin, string datecheckout, string customerName, string type, long cccd, int idroom, int night, string customerNgaySinh, string customerDiaChi, string customerLoaiKhachHang, int customerDienThoai, string customerGioiTinh, string customerQuocTich)
        {

            hoten.Text = customerName;
            ngaynhan.Text = datecheckin;
            ngaytra.Text = datecheckout;
            tenphong.Text = type;
            cmnd.Text = cccd.ToString();
            maphong.Text = idroom.ToString();
            this.night.Text = night.ToString();
            ngaysinh.Text = customerNgaySinh;
            diachi.Text = customerDiaChi;
            loaikhachhang.Text = customerLoaiKhachHang;
            gioitinh.Text = customerGioiTinh;
            dienthoai.Text = customerDienThoai.ToString();
            quoctich.Text = customerQuocTich;

            hoten.Enabled = false;
            ngaynhan.Enabled = false;
            ngaytra.Enabled = false;
            tenphong.Enabled = false;
            cmnd.Enabled = false;
            maphong.Enabled = false;
            this.night.Enabled = false;
            ngaysinh.Enabled = false;
            diachi.Enabled = false;
            loaikhachhang.Enabled = false;
            gioitinh.Enabled = false;
            dienthoai.Enabled = false;
            quoctich.Enabled = false;

        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void booking_details_Load(object sender, EventArgs e)
        {

        }

        private void capnhatkhachhangdatphong_Click(object sender, EventArgs e)
        {
            // Giả sử các điều khiển trên form booking_details là TextBox
            string customerName = hoten.Text;
            string customerNgaySinh = ngaysinh.Text;
            string customerDiaChi = diachi.Text;
            string customerLoaiKhachHang = loaikhachhang.Text;
            int customerDienThoai = Convert.ToInt32(dienthoai.Text);
            string customerGioiTinh = gioitinh.Text;
            string customerQuocTich = quoctich.Text;
            int cccd = Convert.ToInt32(cmnd.Text);
            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
            // Kết nối cơ sở dữ liệu để cập nhật
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE customer 
                             SET name = @name, dob = @dob, address = @address, 
                                 type = @type, phone = @phone, gender = @gender, country = @country 
                             WHERE cccd = @cccd";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", customerName);
                        command.Parameters.AddWithValue("@dob", customerNgaySinh);
                        command.Parameters.AddWithValue("@address", customerDiaChi);
                        command.Parameters.AddWithValue("@type", customerLoaiKhachHang);
                        command.Parameters.AddWithValue("@phone", customerDienThoai);
                        command.Parameters.AddWithValue("@gender", customerGioiTinh);
                        command.Parameters.AddWithValue("@country", customerQuocTich);
                        command.Parameters.AddWithValue("@cccd", cccd);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin khách hàng thành công.");

                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng để cập nhật.");
                        }
                    }
                    string updateBookingQuery = @"UPDATE booking 
                                           SET name = @name 
                                           WHERE cccd = @cccd "; // Giả sử bạn có cccd và idroom để xác định booking

                    using (SqlCommand command = new SqlCommand(updateBookingQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", customerName); // Giả sử bạn muốn cập nhật trường name trong booking
                        command.Parameters.AddWithValue("@cccd", cccd);


                        int bookingRowsAffected = command.ExecuteNonQuery();
                        if (bookingRowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin booking thành công.");
                            // Tải lại dữ liệu nếu cần
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy booking để cập nhật.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
                }


            }
        }

        private void luuchitietdatphong_Click(object sender, EventArgs e)
        {

        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

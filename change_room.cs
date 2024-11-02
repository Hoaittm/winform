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
    public partial class change_room : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private int id;
        private Checkin_details checkinDetail;
        public change_room(int id, Checkin_details checkinDetail)
        {
            InitializeComponent();
            this.id = id;
            LoadBookingAndCheckinData();
            this.checkinDetail = checkinDetail;
            LoadRoomTypes();
        }
        private void LoadBookingAndCheckinData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT b.id, b.quatityuser, b.price, b.type, c.nameroom
                 FROM Booking b
                 JOIN Checkin c ON b.id = c.id
                 WHERE b.id = @id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);

                DataTable bookingCheckinTable = new DataTable();
                adapter.Fill(bookingCheckinTable);

                if (bookingCheckinTable.Rows.Count > 0)
                {
                    // Ví dụ hiển thị dữ liệu vào các TextBox trên form change_room
                    DataRow row = bookingCheckinTable.Rows[0];
                    loaiphongtrongdoiphong.Text = row["type"].ToString();
                    phongtrongdoiphong.Text = row["nameroom"].ToString();
                    tenloaiphongtrongdoiphong.Text = row["type"].ToString();
                    tenphongtrongdoiphong.Text = row["nameroom"].ToString();
                    soluongnguoitoida.Text = row["quatityuser"].ToString();
                    giatrongdoiphong.Text = row["price"].ToString();
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

                    loaiphongtrongdoiphong.DataSource = typeTable;
                    loaiphongtrongdoiphong.DisplayMember = "typeroom"; // Hiển thị tên loại phòng
                    loaiphongtrongdoiphong.ValueMember = "typeroom"; // Giá trị sử dụng cho loại phòng
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

        private void dongdoiphong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void luudoiphong_Click(object sender, EventArgs e)
        {
            // Lấy tên phòng mới từ ComboBox
            string newRoomName = phongtrongdoiphong.Text;

            // Kiểm tra xem phòng mới có đang được đặt hay không
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                // Truy vấn để kiểm tra phòng
                string checkRoomQuery = "SELECT COUNT(*) FROM checkin WHERE nameroom = @nameroom";
                using (SqlCommand checkRoomCmd = new SqlCommand(checkRoomQuery, connection))
                {
                    checkRoomCmd.Parameters.AddWithValue("@nameroom", newRoomName);
                    int count = (int)checkRoomCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // Nếu phòng đã được đặt, thông báo cho người dùng
                        MessageBox.Show("Phòng này đã được đặt. Vui lòng chọn phòng khác.");
                        return; // Dừng lại không thực hiện cập nhật
                    }
                }
            }

            // Nếu phòng chưa được đặt, thực hiện cập nhật
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateCheckinQuery = @"UPDATE checkin SET nameroom = @nameroom WHERE id = @id";
                        using (SqlCommand updateCheckinCmd = new SqlCommand(updateCheckinQuery, connection, transaction))
                        {
                            updateCheckinCmd.Parameters.AddWithValue("@nameroom", newRoomName);
                            updateCheckinCmd.Parameters.AddWithValue("@id", this.id);
                            updateCheckinCmd.ExecuteNonQuery();
                        }
                        transaction.Commit();

                        // Gọi RefreshData để cập nhật trên Checkin_details
                        checkinDetail.RefreshData();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
        }

        private void phongtrongdoiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (phongtrongdoiphong.SelectedIndex != -1)
            {
                DataRowView selectedRow = phongtrongdoiphong.SelectedItem as DataRowView;

                if (selectedRow != null) // Kiểm tra để tránh NullReferenceException
                {
                    // Lấy id và tên phòng
                    int roomId = (int)selectedRow["id"];
                    string tenPhong = (string)selectedRow["nameroom"];

                    // Cập nhật tên phòng vào ComboBox (hoặc Label nếu bạn sử dụng)
                    phongtrongdoiphong.Text = tenPhong; // Hoặc nếu bạn muốn sử dụng Label
                                                        // labelTenPhong.Text = tenPhong; // Cập nhật vào Label nếu có
                }
            }
            else
            {
                phongtrongdoiphong.Text = ""; // Xóa text nếu không có phòng nào được chọn
            }
        }

        private void loaiphongtrongdoiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaiphongtrongdoiphong.SelectedValue != null)
            {
                string selectedType = loaiphongtrongdoiphong.SelectedValue.ToString();

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
                        phongtrongdoiphong.DataSource = roomTable;
                        phongtrongdoiphong.DisplayMember = "nameroom"; // Hiển thị tên phòng
                        phongtrongdoiphong.ValueMember = "id"; // Giá trị sử dụng cho ID phòng

                        phongtrongdoiphong.SelectedIndex = -1; // Bỏ chọn bất kỳ lựa chọn hiện tại
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error loading rooms: " + ex.Message);
                    }
                }
            }
            else
            {
                //MessageBox.Show("Please select a room type.");
            }

        }

        private void tenphongtrongdoiphong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 
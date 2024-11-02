using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Information : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private SqlConnection connection;
        private int employeeId;

        public Information(int employeeId)
        {
            InitializeComponent();
            connection = new SqlConnection(connectString);
            this.employeeId = employeeId;
            LoadEmployeeData();
            matkhaumoi.PasswordChar = '*';
            matkhaucu.PasswordChar = '*';
            xacnhanmatkhaumoi.PasswordChar = '*';
        }

        private void LoadEmployeeData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM employee WHERE id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", employeeId); // Sử dụng employeeId từ constructor

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    cccd.Text = reader["cccd"].ToString();
                    address.Text = reader["address"].ToString();
                    username.Text = reader["username"].ToString();
                    loainhanvien.Text = reader["type"].ToString();
                    name.Text = reader["name"].ToString();
                    phone.Text = reader["phone"].ToString();
                    gender.Text = reader["gender"].ToString();
                    dob.Value = Convert.ToDateTime(reader["dob"]);
                    ngayvaolam.Text = reader["startingDate"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void cusButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdatePassword(string oldPassword, string newPassword)
        {
            // Mã hóa mật khẩu mới trước khi lưu
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

            // Kết nối cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();

                    // Kiểm tra mật khẩu cũ có đúng không
                    string checkQuery = "SELECT password FROM employee WHERE id = @id";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@id", employeeId); // employeeId là ID của người dùng hiện tại

                    // Lấy mật khẩu mã hóa từ cơ sở dữ liệu
                    var encryptedOldPassword = checkCommand.ExecuteScalar() as string;

                    // Xác thực mật khẩu cũ
                    if (encryptedOldPassword == null || !BCrypt.Net.BCrypt.Verify(oldPassword, encryptedOldPassword))
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Truy vấn cập nhật mật khẩu
                    string query = "UPDATE employee SET password = @password WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.Parameters.AddWithValue("@id", employeeId);

                    // Thực hiện cập nhật
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void luumatkhau_Click(object sender, EventArgs e)
        {
            // Kiểm tra mật khẩu cũ không trống
            if (string.IsNullOrWhiteSpace(matkhaucu.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu mới không trống
            if (string.IsNullOrWhiteSpace(matkhaumoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xác nhận mật khẩu mới không trống
            if (string.IsNullOrWhiteSpace(xacnhanmatkhaumoi.Text))
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu mới và xác nhận mật khẩu mới có khớp nhau không
            if (matkhaumoi.Text != xacnhanmatkhaumoi.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu tất cả các kiểm tra đều ổn, thực hiện cập nhật mật khẩu ở đây
            UpdatePassword(matkhaucu.Text, matkhaumoi.Text);
        }
    }
}

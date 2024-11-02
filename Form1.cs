using Microsoft.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";


        private int employeeId;
        public Form1()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string tentk = txt_username.Text.Trim();
            string mk = txt_password.Text.Trim();

            if (tentk == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mk == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Gọi hàm ValidateLogin để kiểm tra thông tin đăng nhập
                int employeeId = ValidateLogin(tentk, mk);
                if (employeeId != -1) // Kiểm tra xem có tìm thấy employeeId không
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển đến form chính (AdminMainForm) nếu đăng nhập thành công
                    AdminMainForm ds = new AdminMainForm(employeeId); // Truyền employeeId
                    ds.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_username_BorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void check_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show_pass.Checked)
            {
                txt_password.PasswordChar = '\0'; // Hiện mật khẩu
            }
            else
            {
                txt_password.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }
        private int ValidateLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    // Truy vấn lấy mật khẩu và ID người dùng
                    SqlCommand command = new SqlCommand("SELECT id, password FROM [employee] WHERE username=@username", connection);
                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var encryptedPassword = reader["password"] as string;
                            // Kiểm tra mật khẩu
                            if (BCrypt.Net.BCrypt.Verify(password, encryptedPassword))
                            {
                                // Trả về employeeId
                                return (int)reader["id"];
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return -1; // Trả về -1 nếu không tìm thấy
        }


    }
}
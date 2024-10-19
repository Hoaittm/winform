using Microsoft.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";


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
                if (ValidateLogin(tentk, mk))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển đến form chính (AdminMainForm) nếu đăng nhập thành công
                    AdminMainForm ds = new AdminMainForm();
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
        private bool ValidateLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM [user] WHERE username=@username AND password=@password", connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password); // Mật khẩu không được mã hóa
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 1;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


    }
}
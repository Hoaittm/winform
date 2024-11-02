using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelManagementSystem
{
    public partial class add_employee : Form
    {
        private employee_customer employeeemployee;
        public add_employee(employee_customer form)
        {
            InitializeComponent();
            employeeemployee = form;
        }

        private void add_employee_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cusButton1_Click(object sender, EventArgs e)
        {
            
            var employee = new Employee
            {
                Username = username.Text,
                Ten = name.Text,
                Ngaysinh = dob.Text,
                Cccd = cccd.Text,
                DiaChi = address.Text,
                LoaiNhanvien = type.Text,
                Ngayvaolam = ngayvaolam.Text,
                DienThoai = phone.Text,
                GioiTinh = gender.Text,
            };

          
            InsertemployeeIntoDatabase(employee);

           
            employeeemployee.AddEmployee(employee);

            ClearInputs();
        }

        private void InsertemployeeIntoDatabase(Employee employee)
        {
            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

          
            string defaultPassword = "123456";
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(defaultPassword);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

               
                string checkCccdQuery = "SELECT COUNT(*) FROM employee WHERE cccd = @cccd";
                using (SqlCommand checkCccdCommand = new SqlCommand(checkCccdQuery, connection))
                {
                    checkCccdCommand.Parameters.AddWithValue("@cccd", employee.Cccd);
                    int cccdCount = (int)checkCccdCommand.ExecuteScalar();

                    if (cccdCount > 0)
                    {
                        MessageBox.Show("Số CCCD đã tồn tại. Vui lòng kiểm tra lại.");
                        return;
                    }
                }

                string checkPhoneQuery = "SELECT COUNT(*) FROM employee WHERE phone = @phone";
                using (SqlCommand checkPhoneCommand = new SqlCommand(checkPhoneQuery, connection))
                {
                    checkPhoneCommand.Parameters.AddWithValue("@phone", employee.DienThoai);
                    int phoneCount = (int)checkPhoneCommand.ExecuteScalar();

                    if (phoneCount > 0)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng kiểm tra lại.");
                        return; 
                    }
                }

             
                string query = "INSERT INTO employee (name, dob, cccd, phone, type, gender, address, username, startingDate, password) " +
                               "VALUES (@name, @dob, @cccd, @phone, @type, @gender, @address, @username, @startingDate, @password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", employee.Ten);
                    command.Parameters.AddWithValue("@dob", employee.Ngaysinh);
                    command.Parameters.AddWithValue("@cccd", employee.Cccd);
                    command.Parameters.AddWithValue("@phone", employee.DienThoai);
                    command.Parameters.AddWithValue("@type", employee.LoaiNhanvien);
                    command.Parameters.AddWithValue("@address", employee.DiaChi);
                    command.Parameters.AddWithValue("@gender", employee.GioiTinh);
                    command.Parameters.AddWithValue("@startingDate", employee.Ngayvaolam);
                    command.Parameters.AddWithValue("@username", employee.Username);
                    command.Parameters.AddWithValue("@password", hashedPassword); 

                    try
                    {
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Thêm thành công với mật khẩu mặc định là: 123456");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên không thành công.");
                           
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }


        private void ClearInputs()
        {
            

            name.Clear();
            cccd.Clear();
            type.Items.Clear();
            phone.Clear();
            address.Clear();
            gender.Items.Clear();
            username.Clear();
        }

        private void cusButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    public class Employee
    {

        public string Username { get; set; }
        public string Ten { get; set; }
        public string Cccd { get; set; }
        public string LoaiNhanvien { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
      
        public string Ngaysinh { get; set; }
        public string Ngayvaolam { get; set; }
    }

}


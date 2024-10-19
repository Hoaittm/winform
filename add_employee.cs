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
            // Create a new employee instance with the input data
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

            // Insert employee into the database
            InsertemployeeIntoDatabase(employee);

            // Add the employee to the employee_Manage form
            employeeemployee.AddEmployee(employee); // Update employee list in parent form

            ClearInputs(); // Clear input fields after adding
        }

        private void InsertemployeeIntoDatabase(Employee employee)
        {
            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO employee (name, dob, cccd, phone, type, gender, address, username, startingDate) " +
                               "VALUES (@name, @dob, @cccd, @phone, @type, @gender, @address, @username, @startingDate)";

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

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Employee added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void ClearInputs()
        {
            // Clear the input fields

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


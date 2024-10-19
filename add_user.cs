using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using static HotelManagementSystem.add_user;
using Microsoft.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class add_user : Form
    {
        private customer_manage customerManage;

        // Constructor that accepts a customer_manage form instance
        public add_user(customer_manage form)
        {
            InitializeComponent();
            customerManage = form;
        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cusButton1_Click(object sender, EventArgs e)
        {
            // Create a new Customer instance with the input data
            var customer = new Customer
            {

                Ten = name.Text,
                Ngaysinh = dateTime.Text,
                Cccd = cccd.Text,
                DiaChi = address.Text,
                LoaiPhong = type_user.Text,
                DienThoai = phone.Text,


                GioiTinh = gender.Text,
                QuocTich = country.Text,
            };

            // Insert customer into the database
            InsertCustomerIntoDatabase(customer);

            // Add the customer to the Customer_Manage form
            customerManage.AddCustomer(customer);
            ClearInputs();
        }

        private void InsertCustomerIntoDatabase(Customer customer)
        {
            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO customer ( name, dob, cccd, address,type,phone,gender,country) " +
                               "VALUES ( @name, @dob, @cccd, @address, @type, @phone,@gender, @country)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@name", customer.Ten);
                    command.Parameters.AddWithValue("@dob", customer.Ngaysinh);
                    command.Parameters.AddWithValue("@cccd", customer.Cccd);
                    command.Parameters.AddWithValue("@address", customer.DiaChi);
                    command.Parameters.AddWithValue("@type", customer.LoaiPhong);
                    command.Parameters.AddWithValue("@phone", customer.DienThoai);

                    command.Parameters.AddWithValue("@gender", customer.GioiTinh);

                    command.Parameters.AddWithValue("@country", customer.QuocTich);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check if insert was successful
                        //if (result > 0)
                        //{
                        //    MessageBox.Show("Customer added successfully!");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Failed to add customer.");
                        //}
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
            type_user.Items.Clear();
            phone.Clear();
            address.Clear();
            gender.Items.Clear();
            country.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Customer
    {
     
        public string Ten { get; set; }
        public string Ngaysinh { get; set; }
        public string Cccd { get; set; }
        public string LoaiPhong { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string QuocTich { get; set; }
    }
    }


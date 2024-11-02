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

           
            InsertCustomerIntoDatabase(customer);

            
            customerManage.AddCustomer(customer);
          
            ClearInputs();
        }

        private void InsertCustomerIntoDatabase(Customer customer)
        {
            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string checkCccdQuery = "SELECT COUNT(*) FROM customer WHERE cccd = @cccd";
                using (SqlCommand checkCccdCommand = new SqlCommand(checkCccdQuery, connection))
                {
                    checkCccdCommand.Parameters.AddWithValue("@cccd", customer.Cccd);

                    try
                    {
                        connection.Open();
                        int cccdCount = (int)checkCccdCommand.ExecuteScalar(); 

                        if (cccdCount > 0)
                        {
                            MessageBox.Show("Số CCCD đã tồn tại. Vui lòng kiểm tra lại.");
                            return; 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi kiểm tra số CCCD: " + ex.Message);
                        return; 
                    }
                }

     
                string checkPhoneQuery = "SELECT COUNT(*) FROM customer WHERE phone = @phone";
                using (SqlCommand checkPhoneCommand = new SqlCommand(checkPhoneQuery, connection))
                {
                    checkPhoneCommand.Parameters.AddWithValue("@phone", customer.DienThoai);

                    try
                    {
                        int phoneCount = (int)checkPhoneCommand.ExecuteScalar(); 

                        if (phoneCount > 0)
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng kiểm tra lại.");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi kiểm tra số điện thoại: " + ex.Message);
                        return; 
                    }
                }

              
                string query = "INSERT INTO customer (name, dob, cccd, address, type, phone, gender, country) " +
                               "VALUES (@name, @dob, @cccd, @address, @type, @phone, @gender, @country)";

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
                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Khách hàng đã được thêm thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
                    }
                }
            }
        }

        private void ClearInputs()
        {
           

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

        private void name_TextChanged(object sender, EventArgs e)
        {

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


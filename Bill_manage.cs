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
    public partial class Bill_manage : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
       
        private string nameroom;
        private int selectedBillId =-1; 

        public Bill_manage()
        {
            InitializeComponent();
            LoadBillServiceData();
        }
        private void LoadBillServiceData()
        {


            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT * FROM bill "; 
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable serviceTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(serviceTable);

                  
                    dataGridView1.DataSource = serviceTable; 

                    dataGridView1.Columns["id"].HeaderText = "Mã hóa đơn";
                    dataGridView1.Columns["nameroom"].HeaderText = "Tên phòng";
                    dataGridView1.Columns["namecustomer"].HeaderText = "Tên khách hàng";
                    dataGridView1.Columns["datecreate"].HeaderText = "Ngày tạo";
                    dataGridView1.Columns["status"].HeaderText = "Ngày tạo";
                    //dataGridView1.Columns["price"].HeaderText = "Đơn giá";
                    dataGridView1.Columns["totalprice"].HeaderText = "Thành tiền";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error loading service data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_printbill_Click(object sender, EventArgs e)
        {

            if (selectedBillId != -1) 
            {
                PrintBill printBill = new PrintBill(selectedBillId);    
                printBill.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để in!");
            }

        }

        private void cusButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timkiemhoadon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(timkiemmahoadon.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn để tìm kiếm!");
                return;
            }

            // Chuyển đổi từ string sang int
            if (int.TryParse(timkiemmahoadon.Text, out int billId))
            {
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT * FROM bill WHERE id = @id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", billId); // Pass the booking ID

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Retrieve customer information
                                    mahoadon.Text = reader["id"].ToString();
                                    tenphong.Text = reader["nameroom"].ToString();
                                    tenkhachhang.Text = reader["namecustomer"].ToString();
                                    ngaytaohoadon.Text = reader["datecreate"].ToString();
                                    trangthai.Text = reader["status"].ToString();
                                    thanhtien.Text = reader["totalprice"].ToString();

                                    // Vô hiệu hóa các trường nhập
                                    mahoadon.Enabled = false;
                                    tenphong.Enabled = false;
                                    tenkhachhang.Enabled = false;
                                    ngaytaohoadon.Enabled = false;
                                    trangthai.Enabled = false;
                                    thanhtien.Enabled = false;

                                    // Cập nhật ID hóa đơn đã chọn
                                    selectedBillId = billId;
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy mã hóa đơn này.");
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
            else
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ. Vui lòng nhập lại!");
            }
        }
    }


      
    }


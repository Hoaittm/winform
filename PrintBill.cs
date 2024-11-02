using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HotelManagementSystem
{
    public partial class PrintBill : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private int currentEmployeeId; // Lưu ID của nhân viên đang đăng nhập
        private string roomName;
        private int billId;
        private PrintDocument printDocument;
        public PrintBill(int id)
        {
            InitializeComponent();
            LoadEmployeeNames();
            billId = id;
            LoadBillDetails(id);
            LoadServiceData(roomName);
        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadBillDetails(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {

                try
                {
                    connection.Open();
                    string query =
                                    @"
                                        SELECT
                                            bi.id , 
                                            bi.namecustomer, 
                                            c.cccd, 
                                            c.phone, 
                                            c.address, 
                                            c.country,
                                            c.type AS usertype,
                                            b.type AS bookingType, 
                                            bi.nameroom,
                                            b.price,
                                            ch.datecheckin,
                                            b.night,
                                            b.quatityuser,

                                            bi.datecreate,
                                            b.totalPrice AS billtotal,
                                                 bs.totalprice AS billservice,
                                            bi.totalprice AS total
                                        FROM customer c
                                       JOIN booking b ON c.cccd = b.cccd
                                         JOIN checkin ch ON b.id = ch.id
                                       JOIN bill bi ON ch.nameroom = bi.nameroom
                                        JOIN billservice bs ON bi.nameroom = bs.nameroom
                                        WHERE bi.id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id); // Truyền id vào câu truy vấn

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy thông tin từ database và hiển thị lên Label
                                mahoadon.Text = reader["id"].ToString(); // Hiển thị mã hóa đơn
                                tenphong.Text = reader["nameroom"].ToString(); // Hiển thị tên phòng
                                tenkhachhang.Text = reader["namecustomer"].ToString(); // Hiển thị tên khách hàng
                                ngaylaphoadonnn.Text = reader["datecreate"].ToString();
                                cccd.Text = reader["cccd"].ToString();
                                dienthoai.Text = reader["phone"].ToString();
                                label8.Text = reader["usertype"].ToString();
                                diachi.Text = reader["address"].ToString();
                                quoctich.Text = reader["country"].ToString();
                                loaiphong.Text = reader["bookingType"].ToString();
                                if (decimal.TryParse(reader["price"].ToString(), out decimal roomPrice))
                                {
                                    giaphong.Text = roomPrice.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")); // Format as VND
                                }
                                ngayden.Text = reader["datecheckin"].ToString();
                                sodem.Text = reader["night"].ToString();
                                songuoi.Text = reader["quatityuser"].ToString();
                                if (decimal.TryParse(reader["price"].ToString(), out decimal roomprice))
                                {
                                    tienphong.Text = roomPrice.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")); // Format as VND
                                }
                                //tiendichvu.Text = reader["billservice"].ToString();
                                if (decimal.TryParse(reader["total"].ToString(), out decimal totalPrice))
                                {
                                    thanhtien.Text = totalPrice.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")); // Format as VND
                                }

                                // Định dạng số tiền
                                if (decimal.TryParse(reader["billtotal"].ToString(), out decimal billTotal))
                                {
                                    tongtien.Text = billTotal.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")); // Format as VND
                                }
                                else
                                {
                                    tongtien.Text = reader["billtotal"].ToString(); // Nếu không chuyển đổi được, hiển thị dưới dạng chuỗi
                                }


                                string roomName = reader["nameroom"].ToString();

                                // Gọi phương thức LoadServiceData với tên phòng
                                LoadServiceData(roomName);

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
        private void LoadServiceData(string roomName)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT id, nameservice, price, quantityuser, totalprice FROM billservice WHERE nameroom = @nameroom";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@nameroom", roomName);

                DataTable serviceTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(serviceTable);

                    // Hiển thị dữ liệu dịch vụ lên DataGridView
                    dataGridView1.DataSource = serviceTable;
                    dataGridView1.Columns["id"].HeaderText = "Mã";
                    dataGridView1.Columns["nameservice"].HeaderText = "Tên dịch vụ";
                    dataGridView1.Columns["price"].HeaderText = "Giá";
                    dataGridView1.Columns["quantityuser"].HeaderText = "Số lượng";
                    dataGridView1.Columns["totalprice"].HeaderText = "Tổng giá";

                    // Tính tổng tiền dịch vụ
                    double totalServicePrice = serviceTable.AsEnumerable()
                        .Sum(row => row.Field<double>("totalprice"));

                    // Hiển thị tổng tiền dịch vụ
                    tiendichvu.Text = totalServicePrice.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
                }
                catch (SqlException ex)
                {
                    //MessageBox.Show("Error loading service data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadEmployeeNames()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                // Truy vấn để lấy tên nhân viên theo ID
                string query = "SELECT name FROM employee "; // Giả định bảng employee có cột id và name

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                // Thêm tham số ID

                DataTable employeeTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(employeeTable);

                    // Hiển thị tên nhân viên
                    if (employeeTable.Rows.Count > 0)
                    {
                        // Lấy tên nhân viên từ DataTable
                        string employeeName = employeeTable.Rows[0]["name"].ToString(); // Thay đổi 'name' nếu tên cột khác
                        tennhanvien.Text = employeeName; // Hiển thị tên trong TextBox hoặc Label
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên với ID đã cho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi tải tên nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tennhanvien_Click(object sender, EventArgs e)
        {
            LoadEmployeeNames();
        }

        private void tenkhachhang_Click(object sender, EventArgs e)
        {

        }

        private void cusButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loaikhachhang_Click(object sender, EventArgs e)
        {

        }

        private void nutinhoadon_Click(object sender, EventArgs e)
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Vẽ bitmap lên trang in
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}

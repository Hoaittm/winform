using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace HotelManagementSystem
{
    public partial class customer_manage : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private int selectedRowId = -1;
        private List<Customer> customers = new List<Customer>();
        public customer_manage()
        {
            InitializeComponent();
            LoadData();
        }

        // Load data from the database into the DataGridView
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT id,name,dob,cccd,address,type,phone,gender,country FROM customer", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();

                    adapter.Fill(dataTable);

                    //if (dataTable.Rows.Count > 0)
                    //{
                    //    MessageBox.Show("Data loaded successfully, rows: " + dataTable.Rows.Count);
                    //}

                    // Ensure AutoGenerateColumns is true
                    dataGridView1.AutoGenerateColumns = true;

                    // Clear any previous columns
                    dataGridView1.Columns.Clear();

                    // Set the DataSource to display the data
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["id"].HeaderText = "Mã KH";
                    dataGridView1.Columns["name"].HeaderText = "Họ và Tên";
                    dataGridView1.Columns["dob"].HeaderText = "Ngày sinh";
                    dataGridView1.Columns["cccd"].HeaderText = "Số CCCD";
                    dataGridView1.Columns["address"].HeaderText = "Địa chỉ";

                    dataGridView1.Columns["type"].HeaderText = "Loại KH";
                    dataGridView1.Columns["phone"].HeaderText = "Điện thoại";
                    dataGridView1.Columns["gender"].HeaderText = "Giới tính";
                    dataGridView1.Columns["country"].HeaderText = "Quốc tịch";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Handle row selection in DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells["Id"].Value != DBNull.Value)
                {
                    selectedRowId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                }
                else
                {
                    selectedRowId = -1; // Reset if ID is DBNull
                }
            }
        }

        // Open the Add User form to add a new customer
        private void txt_add_Click(object sender, EventArgs e)
        {
            add_user addUserForm = new add_user(this);
            addUserForm.Show();
        }

        // Add a new customer to the list and refresh the display
        public void AddCustomer(Customer customer)
        {
            // Add the customer to the list and update the display
            customers.Add(customer);
            UpdateCustomerList();
            LoadData();
        }

        private void UpdateCustomerList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();


            dataGridView1.DataSource = customers;
        }


        // Close the form when the label is clicked
        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // No need to reset DataSource in CellContentClick
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any specific cell click events here if needed
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string phoneNumber = txt_phone.Text;

            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập số CCCD để tìm kiếm!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id,name,dob,cccd, address,type,phone,gender, country FROM customer WHERE cccd = @cccd";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cccd", phoneNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy thông tin khách hàng
                                string customerId = reader["id"].ToString();
                                string customerName = reader["name"].ToString();
                                string customerDob = reader["dob"].ToString();
                                string customerCccd = reader["cccd"].ToString();
                                string customerAddress = reader["address"].ToString();
                                string customerType = reader["type"].ToString();
                                string customerPhone = reader["phone"].ToString();
                                string customerGender = reader["gender"].ToString();
                                string customerCountry = reader["country"].ToString();

                                // Hiển thị thông tin khách hàng lên các điều khiển trong GroupBox\
                                id.Text = customerId;
                                name.Text = customerName;
                                dob.Text = customerDob;
                                cccd.Text = customerCccd;
                                address.Text = customerAddress;
                                type.Text = customerType;
                                phone.Text = customerPhone;
                                gender.Text = customerGender;
                                country.Text = customerCountry;

                                id.Enabled = false;
                                // Nếu cần hiển thị thêm điều khiển, có thể thêm vào như trong ví dụ trên
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy CCCD với số điện thoại này.");
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


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_update_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có thông tin khách hàng nào đang được hiển thị để cập nhật không
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                MessageBox.Show("Vui lòng tìm kiếm một khách hàng trước khi cập nhật!");
                return;
            }

            // Lấy dữ liệu cập nhật từ các TextBox
            string customerId = id.Text; // Giả sử bạn có một TextBox tên là 'id'
            string customerName = name.Text;
            string customerDob = dob.Text;
            string customerCccd = cccd.Text;
            string customerAddress = address.Text;
            string customerType = type.Text;
            string customerPhone = phone.Text;
            string customerGender = gender.Text;
            string customerCountry = country.Text;

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }

            // Kiểm tra CCCD
            if (!IsValidCccd(customerCccd))
            {
                MessageBox.Show("Số CCCD phải có 12 chữ số và không được chứa ký tự khác.");
                return;
            }

            // Kiểm tra số điện thoại
            if (!IsValidPhone(customerPhone))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số.");
                return;
            }

            // Chuyển đổi sang int và đảm bảo kiểm tra
            int customerCccdValue;
            int customerPhoneValue;

            if (!int.TryParse(customerCccd, out customerCccdValue))
            {
                MessageBox.Show("Không thể chuyển đổi CCCD thành số. Vui lòng kiểm tra lại.");
                return;
            }

            if (!int.TryParse(customerPhone, out customerPhoneValue))
            {
                MessageBox.Show("Không thể chuyển đổi số điện thoại thành số. Vui lòng kiểm tra lại.");
                return;
            }

            // Cập nhật thông tin khách hàng trong cơ sở dữ liệu
            string query = "UPDATE customer SET name = @name, dob = @dob, cccd = @cccd, address = @address, type = @type, phone = @phone, gender = @gender, country = @country WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số để ngăn chặn SQL injection
                        command.Parameters.AddWithValue("@id", customerId);
                        command.Parameters.AddWithValue("@name", customerName);
                        command.Parameters.AddWithValue("@dob", customerDob);
                        command.Parameters.AddWithValue("@cccd", customerCccdValue);
                        command.Parameters.AddWithValue("@address", customerAddress);
                        command.Parameters.AddWithValue("@type", customerType);
                        command.Parameters.AddWithValue("@phone", customerPhoneValue);
                        command.Parameters.AddWithValue("@gender", customerGender);
                        command.Parameters.AddWithValue("@country", customerCountry);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                            LoadData(); // Tải lại DataGridView để phản ánh các thay đổi
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công! Vui lòng kiểm tra lại.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private bool IsValidCccd(string cccd)
        {
            // Kiểm tra nếu độ dài là 12 và chỉ chứa ký tự số
            return cccd.Length == 12 && cccd.All(char.IsDigit);
        }

        // Phương thức kiểm tra tính hợp lệ của số điện thoại
        private bool IsValidPhone(string phone)
        {
            // Kiểm tra nếu độ dài là 10 và chỉ chứa ký tự số
            return phone.Length == 10 && phone.All(char.IsDigit);
        }
        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void export2Excel(DataGridView g, string duongdan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void xuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export2Excel(dataGridView1, @"D:\", "xuatfileexcel");
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void xoakhachhang_Click(object sender, EventArgs e)
        {
            string CCCD = cccd.Text.Trim(); // Loại bỏ khoảng trắng

            if (string.IsNullOrEmpty(CCCD))
            {
                MessageBox.Show("Vui lòng nhập số CCCD để tìm kiếm!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Chỉ định câu lệnh DELETE đúng cách
                    string query = "DELETE FROM customer WHERE cccd = @cccd";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cccd", CCCD);

                        // Thực thi câu lệnh và lấy số dòng bị ảnh hưởng
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bản ghi nào bị xóa không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Khách hàng đã được xóa thành công.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}

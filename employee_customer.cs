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
    public partial class employee_customer : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private int selectedRowId = -1;
        private List<Employee> customers = new List<Employee>();
        public employee_customer()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM employee", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void add_employee_Click(object sender, EventArgs e)
        {
            add_employee add_Employee = new add_employee(this); // Pass the current instance
            add_Employee.Show();
        }

        public void AddEmployee(Employee employee)
        {
            // Add the customer to the list and update the display
            customers.Add(employee);
            UpdateCustomerList();
            LoadData();
        }

        private void UpdateCustomerList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();


            dataGridView1.DataSource = customers;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authorities_Click(object sender, EventArgs e)
        {
            add_access add_Access = new add_access();
            add_Access.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cccdNumber = txt_input.Text;

            if (string.IsNullOrEmpty(cccdNumber))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại để tìm kiếm!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id,name,dob,cccd, address,type,phone,gender,username,startingDate FROM employee WHERE cccd = @cccd";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cccd", cccdNumber);

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
                                string customerUsername = reader["username"].ToString();
                                string customerStartingDate = reader["startingDate"].ToString();

                                // Hiển thị thông tin khách hàng lên các điều khiển trong GroupBox\
                                id.Text = customerId;
                                name.Text = customerName;
                                dob.Text = customerDob;
                                cccd.Text = customerCccd;
                                address.Text = customerAddress;
                                type.Text = customerType;
                                phone.Text = customerPhone;
                                gender.Text = customerGender;
                                username.Text = customerUsername;
                                ngayvaolam.Text = customerStartingDate;

                                // Nếu cần hiển thị thêm điều khiển, có thể thêm vào như trong ví dụ trên
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này.");
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

        private void txt_update_Click(object sender, EventArgs e)
        {
            // Check if any customer information is displayed for updating
            if (string.IsNullOrWhiteSpace(id.Text))
            {
                MessageBox.Show("Vui lòng tìm kiếm một khách hàng trước khi cập nhật!");
                return;
            }

            // Retrieve updated customer data from the TextBoxes
            string customerId = id.Text; // Assuming you have a TextBox named 'id'
            string customerName = name.Text;
            string customerDob = dob.Text;
            string customerCccd = cccd.Text;
            string customerAddress = address.Text;
            string customerType = type.Text;
            string customerPhone = phone.Text;
            string customerGender = gender.Text;
            string customerUsername = username.Text;
            string customerStartingDate = ngayvaolam.Text;

            // Validate the input
            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }

            // Update the customer information in the database
            UpdateEmployee(customerId, customerName, customerDob, customerCccd, customerAddress, customerType, customerPhone, customerGender, customerUsername, customerStartingDate);
        }

        private void UpdateEmployee(string customerId, string customerName, string customerDob, string customerCccd, string customerAddress, string customerType, string customerPhone, string customerGender, string customerUsername, string customerStartingDate)
        {
            string query = "UPDATE employee SET name = @name, dob = @dob, cccd = @cccd, address = @address, type = @type, phone = @phone, gender = @gender, username = @username, startingDate = @startingDate WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@id", customerId);
                        command.Parameters.AddWithValue("@name", customerName);
                        command.Parameters.AddWithValue("@dob", customerDob);
                        command.Parameters.AddWithValue("@cccd", customerCccd);
                        command.Parameters.AddWithValue("@address", customerAddress);
                        command.Parameters.AddWithValue("@type", customerType);
                        command.Parameters.AddWithValue("@phone", customerPhone);
                        command.Parameters.AddWithValue("@gender", customerGender);
                        command.Parameters.AddWithValue("@username", customerUsername);
                        command.Parameters.AddWithValue("@startingDate", customerStartingDate);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                            LoadData(); // Reload the DataGridView to reflect changes
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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}

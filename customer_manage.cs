using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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
                    SqlCommand command = new SqlCommand("SELECT * FROM customer", connection);
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
                MessageBox.Show("Vui lòng nhập số điện thoại để tìm kiếm!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id,name,dob,cccd, address,type,phone,gender, country FROM customer WHERE phone = @phone";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Phone", phoneNumber);

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


        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
            string customerCountry = country.Text;

            // Validate the input
            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }

            // Update the customer information in the database
            string query = "UPDATE customer SET name = @name, dob = @dob, cccd = @cccd, address = @address, type = @type, phone = @phone, gender = @gender, country = @country WHERE id = @id";

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
                        command.Parameters.AddWithValue("@country", customerCountry);

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

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}

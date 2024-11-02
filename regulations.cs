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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace HotelManagementSystem
{
    public partial class regulations : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        public regulations()
        {
            InitializeComponent();
            LoadRegulationsData();
        }
        private void LoadRegulationsData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT name,value,description FROM regulations"; // Adjust the query as needed
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                System.Data.DataTable regulationsTable = new System.Data.DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(regulationsTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = regulationsTable; // Make sure your DataGridView is named regulationsDataGridView

                    dataGridView1.Columns["name"].HeaderText = "Tên";
                    dataGridView1.Columns["value"].HeaderText = "Giá trị";
                    dataGridView1.Columns["description"].HeaderText = "Mô tả";


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error loading regulations data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cusButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timkiemtenquydinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tenquydinhcuatimkiem.Text))
            {
                MessageBox.Show("Vui lòng nhập tên quy định để tìm kiếm!");
                return;
            }

            string name = tenquydinhcuatimkiem.Text; // Assuming booking ID is a string

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM regulations WHERE name = @name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name); // Pass the booking ID

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve customer information
                                tenquydinh.Text = reader["name"].ToString();
                                giatriquydinh.Text = reader["value"].ToString();
                                mieutaquydinh.Text = reader["description"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy tên quy định với mã này.");
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

        private void capnhatquydinh_Click(object sender, EventArgs e)
        {
            // Ensure that the regulation name textbox is not empty
            if (string.IsNullOrEmpty(tenquydinh.Text))
            {
                MessageBox.Show("Vui lòng nhập tên quy định để cập nhật!");
                return;
            }

            // Prepare your SQL update query
            string query = "UPDATE regulations SET value = @value, description = @description WHERE name = @name";

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@name", tenquydinh.Text); // Regulation name to be updated
                        command.Parameters.AddWithValue("@value", giatriquydinh.Text); // New value
                        command.Parameters.AddWithValue("@description", mieutaquydinh.Text); // New description

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật quy định thành công!");
                            LoadRegulationsData(); // Reload the DataGridView to reflect changes
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
        private void xuấtFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export2Excel(dataGridView1, @"D:\", "quydinhHotel" +
                "");
            MessageBox.Show("Xuất file thành công");
        }
    }
}

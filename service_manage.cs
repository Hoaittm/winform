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
    public partial class service_manage : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        public service_manage()
        {
            InitializeComponent();
            LoadServiceData();


        }
        private void LoadServiceData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT * FROM service"; // Adjust the query as needed
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                System.Data.DataTable regulationsTable = new System.Data.DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(regulationsTable);

                    
                    dataGridView1.DataSource = regulationsTable; 
                    dataGridView1.Columns["id"].HeaderText = "Mã";
                    dataGridView1.Columns["name"].HeaderText = "Tên";
                    dataGridView1.Columns["price"].HeaderText = "Giá";
                    dataGridView1.Columns["typeservice"].HeaderText = "Loại dịch vụ";


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error loading service data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void service_manage_Load(object sender, EventArgs e)
        {

        }

        private void cusButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timkiemdichvu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tendichvutimkiem.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ để tìm kiếm!");
                return;
            }

            string name = tendichvutimkiem.Text;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM service WHERE name = @name";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name); 

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                madichvu.Text = reader["id"].ToString();
                                tendichvu.Text = reader["name"].ToString();
                                loaidichvu.Text = reader["typeservice"].ToString();
                                giadichvu.Text = reader["price"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy tên dịch vụ với mã này.");
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

        private void capnhatdichvu_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(tendichvu.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ để cập nhật!");
                return;
            }

            
            string query = "UPDATE service SET name = @name, price = @price,typeservice =@typeservice WHERE name = @name";

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@name", tendichvu.Text);
                        command.Parameters.AddWithValue("@price", giadichvu.Text); 
                        command.Parameters.AddWithValue("@typeservice", loaidichvu.Text); 


                       
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật dịch vụ thành công!");
                            LoadServiceData(); 
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

        private void themdichvu_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tendichvu.Text) || string.IsNullOrEmpty(giadichvu.Text) || string.IsNullOrEmpty(loaidichvu.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            string query = "INSERT INTO service (name, price, typeservice) VALUES (@name, @price, @typeservice)";

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@name", tendichvu.Text); 
                        command.Parameters.AddWithValue("@price", decimal.Parse(giadichvu.Text)); 
                        command.Parameters.AddWithValue("@typeservice", loaidichvu.Text); 

                        
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadServiceData();
                            
                            tendichvu.Clear();
                            giadichvu.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Thêm dịch vụ không thành công! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            export2Excel(dataGridView1, @"D:\", "quanlydichvu" +
                "");
            MessageBox.Show("Xuất file thành công");
        }
    }
}

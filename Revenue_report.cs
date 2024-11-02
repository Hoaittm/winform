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
    public partial class Revenue_report : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";

        private int selectedMonth;
        private int selectedYear;
        public Revenue_report()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cusButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Revenue_report_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị cho ComboBox tháng
            for (int i = 1; i <= 12; i++)
            {
                thang.Items.Add(i.ToString());
            }

            // Thiết lập giá trị cho NumericUpDown năm
            nam.Minimum = 2020; // Bạn có thể thay đổi giá trị tối thiểu tùy theo yêu cầu
            nam.Maximum = DateTime.Now.Year; // Năm hiện tại
            nam.Value = DateTime.Now.Year; // Thiết lập năm mặc định là năm hiện tại
        }
        private void xemketquatimkiem_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem tháng và năm đã được chọn hay chưa
            if (selectedMonth == 0 || selectedYear == 0)
            {
                MessageBox.Show("Vui lòng chọn tháng và năm trước khi tìm kiếm.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();

                // Truy vấn danh sách đặt phòng trong tháng và năm đã chọn
                string query = @"
        SELECT * 
        FROM booking 
        WHERE TRY_CONVERT(DATETIME, datecheckout, 103) IS NOT NULL
        AND MONTH(TRY_CONVERT(DATETIME, datecheckout, 103)) = @SelectedMonth 
        AND YEAR(TRY_CONVERT(DATETIME, datecheckout, 103)) = @SelectedYear;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Gán giá trị tháng và năm đã chọn vào các tham số truy vấn
                    command.Parameters.AddWithValue("@SelectedMonth", selectedMonth);
                    command.Parameters.AddWithValue("@SelectedYear", selectedYear);

                    // Thực thi truy vấn và lấy kết quả
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0) // Kiểm tra nếu có kết quả
                        {
                            dataGridView1.DataSource = dt; // Gán dữ liệu cho DataGridView
                            dataGridView1.Columns["id"].HeaderText = "Mã đặt phòng";
                            dataGridView1.Columns["name"].HeaderText = "Tên";
                            dataGridView1.Columns["idroom"].HeaderText = "Mã phòng";
                            dataGridView1.Columns["quatityuser"].HeaderText = "Số Người";
                            dataGridView1.Columns["price"].HeaderText = "Giá phòng";
                            dataGridView1.Columns["type"].HeaderText = "Loại";
                            dataGridView1.Columns["night"].HeaderText = "Số Đêm";
                            dataGridView1.Columns["datecheckin"].HeaderText = "Ngày nhận";
                            dataGridView1.Columns["datecheckout"].HeaderText = "Ngày trả";
                            dataGridView1.Columns["cccd"].HeaderText = "Số CCCD";
                            dataGridView1.Columns["totalPrice"].HeaderText = "Tổng tiền";
                        }

                        else
                        {
                            MessageBox.Show("Không có dữ liệu cho tháng và năm đã chọn.");
                            dataGridView1.DataSource = null; // Xóa dữ liệu trong DataGridView
                        }
                    }
                }
            }
        }

        private void thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMonth = int.Parse(thang.SelectedItem.ToString());


        }

        private void nam_ValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị năm đã chọn từ NumericUpDown và chuyển thành chuỗi
            selectedYear = (int)nam.Value;

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
            export2Excel(dataGridView1, @"D:\C#", "baocaodanhthu" +
                "");
            MessageBox.Show("Xuất file thành công");
        }
    }
}

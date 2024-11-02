using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManagementSystem.booking;

namespace HotelManagementSystem
{
    public partial class Checkout : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private string selectedRoomName;

        private string customerName;
        public Color RoomColor { get; set; }
        public Checkout()
        {
            InitializeComponent();
            LoadCheckedInRooms();


            loaidichvu.SelectedIndexChanged += loaidichvu_SelectedIndexChanged;
            LoadLoaiDichVu();

            // Thêm sự kiện cho các DataGridView
            dataGridView1.CellValueChanged += DataGridView_CellValueChanged;
            dataGridView3.CellValueChanged += DataGridView_CellValueChanged;

            // Thêm sự kiện để cập nhật tổng tiền khi dữ liệu được thay đổi
            dataGridView1.SelectionChanged += DataGridView_SelectionChanged;
            dataGridView3.SelectionChanged += DataGridView_SelectionChanged;

        }
        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Tính lại tổng tiền mỗi khi giá trị của DataGridView thay đổi
            TinhTongTien();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Tính lại tổng tiền mỗi khi có sự thay đổi trong lựa chọn của DataGridView
            TinhTongTien();
        }

        private decimal TinhTongTien()
        {
            // Khởi tạo biến tổng tiền
            decimal totalRoomPrice = 0;
            decimal totalServicePrice = 0;

            // Tính tổng giá trị từ DataGridView1 (giá phòng)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["totalPrice"].Value != null &&
                    decimal.TryParse(row.Cells["totalPrice"].Value.ToString(), out decimal price))
                {
                    totalRoomPrice += price;
                }
            }

            // Tính tổng giá trị từ DataGridView3 (dịch vụ)
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells["totalprice"].Value != null &&
                    decimal.TryParse(row.Cells["totalprice"].Value.ToString(), out decimal servicePrice))
                {
                    totalServicePrice += servicePrice;
                }
            }

            // Cộng tổng giá trị từ hai DataGridView
            decimal grandTotal = totalRoomPrice + totalServicePrice;

            // Hiển thị tổng tiền vào textbox tongtien
            tongtien.Text = grandTotal.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")); // Định dạng số với dấu phẩy
            return grandTotal; // Trả về tổng tiền
        }


        private Dictionary<string, Color> roomTypeColors = new Dictionary<string, Color>
            {
                { "Phòng Suite (SUT)", Color.DarkOrange },
                { "Phòng Deluxe (DLX)", Color.Violet },
                { "Phòng Superior (SUP)", Color.DeepSkyBlue },
                  { "Phòng Standard (STD)", Color.LimeGreen },
                // Thêm các loại phòng khác và màu sắc tương ứng
            };
        private Dictionary<string, Button> roomButtons = new Dictionary<string, Button>();
        public void UpdateRoomColor()
        {
            // Giả sử bạn có một label để hiển thị màu sắc
            this.BackColor = RoomColor;  // Cập nhật màu sắc cho một label
                                         // Hoặc bạn có thể áp dụng màu sắc này cho một panel hay các control khác
        }

        private void LoadBillRoomData(string roomName)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                // Thêm điều kiện WHERE để chỉ lấy thông tin cho phòng cụ thể
                string query = @"
            SELECT c.nameroom, b.price,c.name, b.datecheckin, b.datecheckout,b.night,b.totalPrice
            FROM checkin c
            JOIN booking b ON c.id = b.id
            WHERE c.nameroom = @nameroom"; // Sử dụng tham số để lọc theo tên phòng

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@nameroom", roomName); // Thêm tham số cho câu truy vấn

                DataTable regulationsTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(regulationsTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = regulationsTable; // Đảm bảo DataGridView được đặt tên đúng

                    // Đặt lại tiêu đề cột
                    dataGridView1.Columns["nameroom"].HeaderText = "Tên Phòng";
                    dataGridView1.Columns["name"].HeaderText = "Tên KH";
                    dataGridView1.Columns["price"].HeaderText = "Đơn giá";
                    dataGridView1.Columns["datecheckin"].HeaderText = "Ngày nhận";
                    dataGridView1.Columns["datecheckout"].HeaderText = "Ngày trả";
                    dataGridView1.Columns["night"].HeaderText = "Số đêm";
                   
                    dataGridView1.Columns["totalPrice"].HeaderText = "Tổng tiền";
                    if (regulationsTable.Rows.Count > 0)
                    {
                        customerName = regulationsTable.Rows[0]["name"].ToString(); // Lấy tên khách hàng từ hàng đầu tiên
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error loading bill data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadBillServiceData()
        {


            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT * FROM billservice WHERE nameroom = @nameroom"; // Sử dụng tên phòng đã chọn
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@nameroom", selectedRoomName); // Thêm tham số cho câu truy vấn

                DataTable serviceTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(serviceTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView3.DataSource = serviceTable; // Đảm bảo DataGridView được đặt tên đúng

                    dataGridView3.Columns["id"].HeaderText = "STT";
                    dataGridView3.Columns["nameservice"].HeaderText = "Tên dịch vụ";
                    dataGridView3.Columns["price"].HeaderText = "Đơn giá";
                    dataGridView3.Columns["quantityuser"].HeaderText = "Số lượng";
                    dataGridView3.Columns["totalprice"].HeaderText = "Thành tiền";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error loading service data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCheckedInRooms()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT c.nameroom, b.type " +
                               "FROM checkin c " +
                               "INNER JOIN booking b ON c.id = b.id";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable checkedInRooms = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(checkedInRooms);
                    int buttonWidth = 250; // Chiều rộng của button
                    int buttonHeight = 70; // Chiều cao của button
                    int horizontalSpacing = 15; // Khoảng cách giữa các button
                    int xOffset = 10; // Khoảng cách từ đầu panel đến nút đầu tiên
                    int yOffset = 10; // Vị trí Y cố định cho hàng

                    // Xóa các nút cũ trước khi tải lại
                    panel1.Controls.Clear();
                    roomButtons.Clear();

                    foreach (DataRow row in checkedInRooms.Rows)
                    {
                        string roomName = row["nameroom"].ToString();
                        string roomType = row["type"].ToString();

                        // Kiểm tra xem phòng đã được thanh toán chưa
                        if (IsRoomPaid(roomName))
                        {
                            continue; // Nếu đã thanh toán, bỏ qua việc tạo nút cho phòng này
                        }

                        // Lấy màu sắc dựa trên loại phòng
                        if (roomTypeColors.ContainsKey(roomType))
                        {
                            Color roomColor = roomTypeColors[roomType];

                            // Tạo button cho mỗi phòng
                            Button roomButton = new Button
                            {
                                Text = roomName,
                                BackColor = roomColor,
                                Size = new Size(buttonWidth, buttonHeight), // Kích thước của button
                                Location = new Point(xOffset, yOffset)  // Thêm một khoảng cách giữa các button
                            };

                            if (xOffset + buttonWidth > panel1.Width - 10) // 10 là khoảng cách dự phòng
                            {
                                xOffset = 10; // Đặt lại xOffset về giá trị bắt đầu
                                yOffset += buttonHeight + horizontalSpacing; // Di chuyển xuống hàng tiếp theo
                            }

                            xOffset += buttonWidth + horizontalSpacing;
                            roomButtons[roomName] = roomButton;

                            // Thêm sự kiện Click cho button
                            roomButton.Click += (s, e) =>
                            {
                                selectedRoomName = roomName;
                                LoadBillRoomData(roomName); // Gọi LoadBillRoomData khi nhấn vào nút
                                LoadBillServiceData();
                            };

                            // Thêm button vào panel
                            panel1.Controls.Add(roomButton); // Giả sử bạn có một panel tên là panel1
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error loading checked-in rooms: " + ex.Message);
                }
            }
        }
        private bool IsRoomPaid(string roomName)
        {
            // Logic kiểm tra trong hóa đơn để xác định xem phòng đã được thanh toán chưa
            // Trả về true nếu đã thanh toán, false nếu chưa thanh toán
            // Ví dụ:
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT COUNT(*) FROM bill WHERE nameroom = @nameroom ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nameroom", roomName);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0; // Nếu có bản ghi, phòng đã được thanh toán
            }
        }
        private void LoadLoaiDichVu()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = "SELECT DISTINCT typeservice FROM service"; // Câu truy vấn lấy loại dịch vụ
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable typeTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(typeTable);
                    loaidichvu.DataSource = typeTable;
                    loaidichvu.DisplayMember = "typeservice"; // Hiển thị loại dịch vụ
                    loaidichvu.ValueMember = "typeservice"; // Giá trị cho ID loại dịch vụ
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error loading service types: " + ex.Message);
                }
            }
        }



        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cusButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void loaidichvu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (loaidichvu.SelectedValue != null)
            {
                string selectedType = loaidichvu.SelectedValue.ToString();
                // Kiểm tra giá trị được chọn

                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    string query = "SELECT * FROM service WHERE typeservice = @typeservice";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@typeservice", selectedType);

                    DataTable serviceTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(serviceTable);

                        dichvu.DataSource = serviceTable;
                        dichvu.DisplayMember = "name";
                        dichvu.ValueMember = "id";
                        dichvu.SelectedIndex = -1; // Bỏ chọn
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error loading services: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a service type.");
            }
        }

        private void dichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dichvu.SelectedIndex != -1)
            {
                DataRowView selectedRow = dichvu.SelectedItem as DataRowView;

                if (selectedRow != null) // Kiểm tra để tránh NullReferenceException
                {
                    // Lấy id và tên dịch vụ
                    int serviceId = (int)selectedRow["id"];
                    string tenDichVu = (string)selectedRow["name"];
                    int price = (int)selectedRow["price"]; // Lấy giá dịch vụ từ cột "price"

                    // Cập nhật tên dịch vụ vào ComboBox (hoặc Label nếu bạn sử dụng)
                    dichvu.Text = tenDichVu; // Hoặc nếu bạn muốn sử dụng Label
                                             // labelTenDichVu.Text = tenDichVu; // Cập nhật vào Label nếu có

                    // Hiển thị giá dịch vụ trong một TextBox hoặc Label
                    gia.Text = price.ToString("C0", CultureInfo.GetCultureInfo("vi-VN")); // Giả sử gia là TextBox để hiển thị giá
                                                                                          // Hoặc nếu sử dụng Label:
                                                                                          // labelGia.Text = price.ToString("C");
                }
            }
            else
            {
                dichvu.Text = ""; // Xóa text nếu không có dịch vụ nào được chọn
                gia.Text = ""; // Xóa giá nếu không có dịch vụ nào được chọn
            }
        }

        private void gia_TextChanged(object sender, EventArgs e)
        {

        }

        private void themdichvu_Click(object sender, EventArgs e)
        {
            if (dichvu.SelectedItem != null)
            {
                DataRowView selectedRow = dichvu.SelectedItem as DataRowView;

                // Lấy thông tin từ dịch vụ đã chọn
                int serviceId = (int)selectedRow["id"];
                string tenDichVu = (string)selectedRow["name"];
                int price = (int)selectedRow["price"]; // Lấy giá dịch vụ từ cột "price"

                // Lấy số lượng từ NumericUpDown
                int quantityuser = (int)soluong.Value; // Lấy giá trị từ NumericUpDown

                if (quantityuser > 0) // Kiểm tra số lượng phải lớn hơn 0
                {
                    // Tính tổng giá trị
                    float totalprice = quantityuser * price;

                    using (SqlConnection connection = new SqlConnection(connectString))
                    {
                        // Câu lệnh INSERT
                        string query = "INSERT INTO billservice (nameservice, price, quantityuser, totalprice, nameroom) VALUES (@nameservice, @price, @quantityuser, @totalprice, @nameroom)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm các tham số
                            command.Parameters.AddWithValue("@nameservice", tenDichVu);
                            command.Parameters.AddWithValue("@price", price);
                            command.Parameters.AddWithValue("@quantityuser", quantityuser);
                            command.Parameters.AddWithValue("@totalprice", totalprice);
                            command.Parameters.AddWithValue("@nameroom", selectedRoomName); // Thêm tên phòng

                            try
                            {
                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Dịch vụ đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadBillServiceData();
                                }
                                else
                                {
                                    MessageBox.Show("Không có dịch vụ nào được thêm vào bảng billservice.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Lỗi khi thêm dịch vụ vào bảng billservice: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ trước khi thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tongtien_TextChanged(object sender, EventArgs e)
        {

            TinhTongTien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void giamgia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void thanhtoan_Click(object sender, EventArgs e)
        {
            string roomName = selectedRoomName;  // Tên phòng được chọn
            /* string customerName = "MINH HOAI";*/  // Thay bằng tên thực tế từ form
            DateTime dateCreate = DateTime.Now;  // Ngày tạo hóa đơn
            string status = "Đã thanh toán";  // Trạng thái mặc định là "Đã thanh toán"
            decimal Price = TinhTongTien();
            //float PhuThu=gia
        
            //decimal totalPrice = TinhTongTien()+;




            // Kết nối đến cơ sở dữ liệu và chèn dữ liệu vào bảng `bill`
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"
            INSERT INTO bill (nameroom, namecustomer, datecreate, status, totalprice)
            VALUES (@nameroom,@namecustomer, @datecreate,@status,  @totalprice)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Gán giá trị cho các tham số
                    command.Parameters.AddWithValue("@nameroom", roomName);
                    command.Parameters.AddWithValue("@namecustomer", customerName);
                    command.Parameters.AddWithValue("@datecreate", dateCreate);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@totalprice", Price);
                    //command.Parameters.AddWithValue("@totalprice", totalPrice);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thanh toán và lưu hóa đơn thành công!");
                            Button buttonToRemove = roomButtons[roomName];
                            panel1.Controls.Remove(buttonToRemove);
                            roomButtons.Remove(roomName);
                            Bill_manage bill_manage = new Bill_manage();
                            bill_manage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán không thành công.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nutthemdichvu_Click(object sender, EventArgs e)
        {
            if (dichvu.SelectedItem != null)
            {
                DataRowView selectedRow = dichvu.SelectedItem as DataRowView;

                // Lấy thông tin từ dịch vụ đã chọn
                int serviceId = (int)selectedRow["id"];
                string tenDichVu = (string)selectedRow["name"];
                int price = (int)selectedRow["price"]; // Lấy giá dịch vụ từ cột "price"

                // Lấy số lượng từ NumericUpDown
                int quantityuser = (int)soluong.Value; // Lấy giá trị từ NumericUpDown

                if (quantityuser > 0) // Kiểm tra số lượng phải lớn hơn 0
                {
                    // Tính tổng giá trị
                    float totalprice = quantityuser * price;

                    using (SqlConnection connection = new SqlConnection(connectString))
                    {
                        // Câu lệnh INSERT
                        string query = "INSERT INTO billservice (nameservice, price, quantityuser, totalprice, nameroom) VALUES (@nameservice, @price, @quantityuser, @totalprice, @nameroom)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm các tham số
                            command.Parameters.AddWithValue("@nameservice", tenDichVu);
                            command.Parameters.AddWithValue("@price", price);
                            command.Parameters.AddWithValue("@quantityuser", quantityuser);
                            command.Parameters.AddWithValue("@totalprice", totalprice);
                            command.Parameters.AddWithValue("@nameroom", selectedRoomName); // Thêm tên phòng

                            try
                            {
                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Dịch vụ đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadBillServiceData();
                                }
                                else
                                {
                                    MessageBox.Show("Không có dịch vụ nào được thêm vào bảng billservice.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Lỗi khi thêm dịch vụ vào bảng billservice: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ trước khi thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

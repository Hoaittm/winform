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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem
{
    public partial class Checkin_details : Form
    {
        private string connectString = "Data Source=DESKTOP-QSUMM6P\\SQLEXPRESS;Initial Catalog=TranThiMinhHoai_winform;Integrated Security=True;TrustServerCertificate=True;";
        private int selectedRowId = -1;
        private int customerId;
        private int id;
        public event Action DataUpdated;
        public Checkin_details()
        {
            InitializeComponent();
            LoadCustomersByCheckinId(id);
         

        }
        public void RefreshData()
        {
            Console.WriteLine("RefreshData called.");
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT nameroom FROM Checkin WHERE id = @id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id", this.id);

                DataTable checkinTable = new DataTable();
                adapter.Fill(checkinTable);

                if (checkinTable.Rows.Count > 0)
                {
                    tenphonglucnhanphong.Text = checkinTable.Rows[0]["nameroom"].ToString();
                    Console.WriteLine("Updated nameroom: " + tenphonglucnhanphong.Text);
                }
            }
        }
        public void SetCheckinDetails(int id, string datecheckin, string datecheckout, string nameroom)
        {
            this.id = id;

            madatphongcuachitietnhanphong.Text = id.ToString();
            ngaynhan.Text = datecheckin;
            ngaytra.Text = datecheckout;
            tenphonglucnhanphong.Text = nameroom;
            LoadCustomersByCheckinId(id);
        }

        private void LoadCustomersByCheckinId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT Customer.id,Customer.name,Customer.dob,Customer.cccd,Customer.address,Customer.type,Customer.phone,Customer.gender,Customer.country FROM Customer 
                                 JOIN Checkin ON Customer.cccd = Checkin.CCCD 
                                 WHERE Checkin.id = @id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);

                DataTable customerTable = new DataTable();
                adapter.Fill(customerTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = customerTable;
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
        }
        private void doiphonglucnhanphong_Click(object sender, EventArgs e)
        {
           
                change_room ChangeRoom = new change_room(id, this);
                ChangeRoom.Show();
           

        }
        // Handle row selection in DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void cusButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Checkin_details_Load(object sender, EventArgs e)
        {

        }


        private void txt_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dongkhachhangchitietnhanphong_Click(object sender, EventArgs e)
        {
            DataUpdated?.Invoke();
            this.Close();
        }

       
    }
}

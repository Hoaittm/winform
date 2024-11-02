using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HotelManagementSystem
{
    public partial class AdminMainForm : Form
    {
        private int employeeId;
        public AdminMainForm(int employeeId)
        {
            InitializeComponent();
            //addRoom.Click += addRoom_Click;
            this.employeeId = employeeId;

        }
        public static int CurrentEmployeeId { get; private set; }

    private void add_room_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            booking book = new booking(); // Create a new instance of the booking form
            book.Show(); // Show the booking form
            /*this.Hide();*/ // Optionally hide the current AdminMainForm if needed
        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkin_Click(object sender, EventArgs e)
        {
            Checkin checkin = new Checkin();
            checkin.Show();

        }

        private void revenue_Click(object sender, EventArgs e)
        {
            Revenue_report revenue = new Revenue_report();
            revenue.Show();
        }

        private void room_manage_Click(object sender, EventArgs e)
        {
            room_manage room_manage = new room_manage();
            room_manage.Show();
        }

        private void employee_manage_Click(object sender, EventArgs e)
        {
            employee_customer employee_Customer = new employee_customer();
            employee_Customer.Show();
        }

        private void bill_manage_Click(object sender, EventArgs e)
        {
            Bill_manage bill_Manage = new Bill_manage();
            bill_Manage.Show();
        }

        private void service_manage_Click(object sender, EventArgs e)
        {
            service_manage service_manage = new service_manage();
            service_manage.Show();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
        }

        private void customer_manage_Click(object sender, EventArgs e)
        {
            customer_manage customer_manage = new customer_manage();
            customer_manage.Show();
        }

        private void regulations_Click(object sender, EventArgs e)
        {
            regulations regulations = new regulations();
            regulations.Show();
        }

        private void information_Click(object sender, EventArgs e)
        {

           /* MessageBox.Show("Employee ID: " + employeeId);*/ // Hiển thị giá trị ID
            Information information = new Information(employeeId);
            information.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Dashboard_Load_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void txt_checkout_Click(object sender, EventArgs e)
        {
            PrintBill printBill = new PrintBill();
            printBill.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cusButton3_Click(object sender, EventArgs e)
        {
            this.Close();        }
    }
}

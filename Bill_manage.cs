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
    public partial class Bill_manage : Form
    {
        public Bill_manage()
        {
            InitializeComponent();
        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_printbill_Click(object sender, EventArgs e)
        {
            PrintBill printBill = new PrintBill();
            printBill.Show();
        }

        private void cusButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

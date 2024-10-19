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
    public partial class room_manage : Form
    {
        public room_manage()
        {
            InitializeComponent();
        }

        private void txt_addroom_Click(object sender, EventArgs e)
        {

        }

        private void txt_editroom_Click(object sender, EventArgs e)
        {
            roomType_manage roomType_Manage = new roomType_manage();
            roomType_Manage.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cusButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class add_access : Form
    {
        public add_access()
        {
            InitializeComponent();
        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTo_Click(object sender, EventArgs e)
        {
            foreach (var item in listQuyen.SelectedItems)
            {
                if (!Quyenconlai.Items.Contains(item))
                {
                    Quyenconlai.Items.Add(item);
                }
            }
        }

        private void removeForm_Click(object sender, EventArgs e)
        {
            while (Quyenconlai.SelectedItems.Count > 0)
            {
                Quyenconlai.Items.Remove(Quyenconlai.SelectedItems[0]);
            }
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            Quyenconlai.Items.Clear();
        }

        private void addAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listQuyen.Items)
            {
                if (!Quyenconlai.Items.Contains(item))
                {
                    Quyenconlai.Items.Add(item);
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

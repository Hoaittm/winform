namespace HotelManagementSystem
{
    partial class customer_manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txt_phone = new TextBox();
            btn_search = new Button();
            label2 = new Label();
            groupBox2 = new GroupBox();
            address = new TextBox();
            phone = new TextBox();
            dob = new DateTimePicker();
            country = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            gender = new ComboBox();
            label7 = new Label();
            type = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            cccd = new TextBox();
            label4 = new Label();
            id = new ComboBox();
            name = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            txt_Exit = new HotelManage.Assets.CusButton();
            txt_add = new HotelManage.Assets.CusButton();
            txt_update = new HotelManage.Assets.CusButton();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(422, 50);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÍ KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(txt_phone);
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(23, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(857, 219);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 11F);
            txt_phone.Location = new Point(318, 50);
            txt_phone.Name = "txt_phone";
            txt_phone.PlaceholderText = "Số điện thoại";
            txt_phone.Size = new Size(456, 47);
            txt_phone.TabIndex = 4;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_search.Location = new Point(148, 128);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(507, 49);
            btn_search.TabIndex = 3;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(15, 53);
            label2.Name = "label2";
            label2.Size = new Size(215, 41);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm theo:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(address);
            groupBox2.Controls.Add(phone);
            groupBox2.Controls.Add(dob);
            groupBox2.Controls.Add(country);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(gender);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(type);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cccd);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(id);
            groupBox2.Controls.Add(name);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(23, 340);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(857, 782);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // address
            // 
            address.Font = new Font("Segoe UI", 11F);
            address.Location = new Point(437, 418);
            address.Name = "address";
            address.Size = new Size(358, 47);
            address.TabIndex = 23;
            // 
            // phone
            // 
            phone.Font = new Font("Segoe UI", 11F);
            phone.Location = new Point(439, 269);
            phone.Name = "phone";
            phone.Size = new Size(358, 47);
            phone.TabIndex = 22;
            // 
            // dob
            // 
            dob.CalendarFont = new Font("Segoe UI", 11F);
            dob.CustomFormat = "dd/mm/yyyy";
            dob.Font = new Font("Segoe UI", 10F);
            dob.Format = DateTimePickerFormat.Short;
            dob.Location = new Point(439, 122);
            dob.Name = "dob";
            dob.Size = new Size(356, 43);
            dob.TabIndex = 21;
            // 
            // country
            // 
            country.FormattingEnabled = true;
            country.Location = new Point(439, 549);
            country.Name = "country";
            country.Size = new Size(356, 53);
            country.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(439, 494);
            label11.Name = "label11";
            label11.Size = new Size(153, 41);
            label11.TabIndex = 19;
            label11.Text = "Quốc tịch:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(439, 359);
            label10.Name = "label10";
            label10.Size = new Size(114, 41);
            label10.TabIndex = 17;
            label10.Text = "Địa chỉ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(439, 210);
            label9.Name = "label9";
            label9.Size = new Size(200, 41);
            label9.TabIndex = 15;
            label9.Text = "Số điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(439, 64);
            label8.Name = "label8";
            label8.Size = new Size(157, 41);
            label8.TabIndex = 13;
            label8.Text = "Ngày sinh:";
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Nam ", "Nữ" });
            gender.Location = new Point(15, 689);
            gender.Name = "gender";
            gender.Size = new Size(356, 53);
            gender.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(15, 634);
            label7.Name = "label7";
            label7.Size = new Size(137, 41);
            label7.TabIndex = 11;
            label7.Text = "Giới tính:";
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.Items.AddRange(new object[] { "Khách vãng lai", "Khách du lịch", "Khách địa phương", "Khách đi qua các tổ chức trung gian" });
            type.Location = new Point(15, 549);
            type.Name = "type";
            type.Size = new Size(356, 53);
            type.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(15, 494);
            label6.Name = "label6";
            label6.Size = new Size(240, 41);
            label6.TabIndex = 9;
            label6.Text = "Loại khách hàng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(15, 359);
            label5.Name = "label5";
            label5.Size = new Size(156, 41);
            label5.TabIndex = 8;
            label5.Text = "Số CMND:";
            // 
            // cccd
            // 
            cccd.Font = new Font("Segoe UI", 11F);
            cccd.Location = new Point(15, 418);
            cccd.Name = "cccd";
            cccd.Size = new Size(358, 47);
            cccd.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(15, 210);
            label4.Name = "label4";
            label4.Size = new Size(160, 41);
            label4.TabIndex = 6;
            label4.Text = "Họ và tên: ";
            // 
            // id
            // 
            id.FormattingEnabled = true;
            id.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            id.Location = new Point(15, 119);
            id.Name = "id";
            id.Size = new Size(356, 53);
            id.TabIndex = 5;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 11F);
            name.Location = new Point(15, 269);
            name.Name = "name";
            name.Size = new Size(358, 47);
            name.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(15, 64);
            label3.Name = "label3";
            label3.Size = new Size(228, 41);
            label3.TabIndex = 0;
            label3.Text = "Mã khách hàng:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(txt_Exit);
            groupBox3.Controls.Add(txt_add);
            groupBox3.Controls.Add(txt_update);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(23, 1147);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(857, 258);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // txt_Exit
            // 
            txt_Exit.BackColor = SystemColors.ButtonHighlight;
            txt_Exit.BackgroundColor = SystemColors.ButtonHighlight;
            txt_Exit.BorderColor = SystemColors.HotTrack;
            txt_Exit.BorderRadius = 35;
            txt_Exit.BorderSize = 1;
            txt_Exit.FlatAppearance.BorderSize = 0;
            txt_Exit.FlatStyle = FlatStyle.Flat;
            txt_Exit.ForeColor = SystemColors.HotTrack;
            txt_Exit.Location = new Point(15, 158);
            txt_Exit.Name = "txt_Exit";
            txt_Exit.Size = new Size(366, 77);
            txt_Exit.TabIndex = 36;
            txt_Exit.Text = "Đóng";
            txt_Exit.TextColor = SystemColors.HotTrack;
            txt_Exit.UseVisualStyleBackColor = false;
            txt_Exit.Click += txt_Exit_Click;
            // 
            // txt_add
            // 
            txt_add.BackColor = SystemColors.ButtonHighlight;
            txt_add.BackgroundColor = SystemColors.ButtonHighlight;
            txt_add.BorderColor = SystemColors.HotTrack;
            txt_add.BorderRadius = 35;
            txt_add.BorderSize = 1;
            txt_add.FlatAppearance.BorderSize = 0;
            txt_add.FlatStyle = FlatStyle.Flat;
            txt_add.ForeColor = SystemColors.HotTrack;
            txt_add.Location = new Point(437, 56);
            txt_add.Name = "txt_add";
            txt_add.Size = new Size(366, 77);
            txt_add.TabIndex = 35;
            txt_add.Text = "Thêm";
            txt_add.TextColor = SystemColors.HotTrack;
            txt_add.UseVisualStyleBackColor = false;
            txt_add.Click += txt_add_Click;
            // 
            // txt_update
            // 
            txt_update.BackColor = SystemColors.ButtonHighlight;
            txt_update.BackgroundColor = SystemColors.ButtonHighlight;
            txt_update.BorderColor = SystemColors.HotTrack;
            txt_update.BorderRadius = 35;
            txt_update.BorderSize = 1;
            txt_update.FlatAppearance.BorderSize = 0;
            txt_update.FlatStyle = FlatStyle.Flat;
            txt_update.ForeColor = SystemColors.HotTrack;
            txt_update.Location = new Point(15, 56);
            txt_update.Name = "txt_update";
            txt_update.Size = new Size(366, 77);
            txt_update.TabIndex = 34;
            txt_update.Text = "Cập nhật";
            txt_update.TextColor = SystemColors.HotTrack;
            txt_update.UseVisualStyleBackColor = false;
            txt_update.Click += txt_update_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(button5);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.ForeColor = SystemColors.HotTrack;
            groupBox4.Location = new Point(895, 93);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1522, 1312);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách khách hàng";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1486, 727);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(1195, 36);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 0;
            button5.Text = "Xuất";
            button5.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(2356, 24);
            label12.Name = "label12";
            label12.Size = new Size(41, 45);
            label12.TabIndex = 7;
            label12.Text = "X";
            label12.Click += label12_Click;
            // 
            // customer_manage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2410, 1429);
            Controls.Add(label12);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "customer_manage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "customer_manage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txt_phone;
        private Button btn_search;
        private GroupBox groupBox2;
        private Label label4;
        private ComboBox id;
        private TextBox name;
        private Label label3;
        private TextBox address;
        private TextBox phone;
        private DateTimePicker dob;
        private ComboBox country;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox gender;
        private Label label7;
        private ComboBox type;
        private Label label6;
        private Label label5;
        private TextBox cccd;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button button5;
        private Label label12;
        private HotelManage.Assets.CusButton txt_Exit;
        private HotelManage.Assets.CusButton txt_add;
        private HotelManage.Assets.CusButton txt_update;
    }
}
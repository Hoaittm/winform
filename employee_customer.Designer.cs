namespace HotelManagementSystem
{
    partial class employee_customer
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
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            id = new TextBox();
            address = new TextBox();
            phone = new TextBox();
            dob = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            gender = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            cccd = new TextBox();
            label4 = new Label();
            name = new TextBox();
            groupBox1 = new GroupBox();
            txt_input = new TextBox();
            btn_search = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            authorities = new HotelManage.Assets.CusButton();
            Exit = new HotelManage.Assets.CusButton();
            add_employee = new HotelManage.Assets.CusButton();
            txt_update = new HotelManage.Assets.CusButton();
            cusButton2 = new HotelManage.Assets.CusButton();
            groupBox5 = new GroupBox();
            ngayvaolam = new DateTimePicker();
            label14 = new Label();
            type = new ComboBox();
            label13 = new Label();
            username = new TextBox();
            label12 = new Label();
            label15 = new Label();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(button5);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.ForeColor = SystemColors.HotTrack;
            groupBox4.Location = new Point(1086, 78);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1206, 1319);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách nhân viên";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1149, 727);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(1027, 49);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 0;
            button5.Text = "Xuất";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(id);
            groupBox2.Controls.Add(address);
            groupBox2.Controls.Add(phone);
            groupBox2.Controls.Add(dob);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(gender);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cccd);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(name);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(587, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(479, 935);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(38, 66);
            label3.Name = "label3";
            label3.Size = new Size(203, 41);
            label3.TabIndex = 25;
            label3.Text = "Mã nhân viên:";
            // 
            // id
            // 
            id.Font = new Font("Segoe UI", 11F);
            id.Location = new Point(38, 125);
            id.Name = "id";
            id.Size = new Size(386, 47);
            id.TabIndex = 24;
            // 
            // address
            // 
            address.Font = new Font("Segoe UI", 11F);
            address.Location = new Point(32, 838);
            address.Name = "address";
            address.Size = new Size(388, 47);
            address.TabIndex = 23;
            // 
            // phone
            // 
            phone.Font = new Font("Segoe UI", 11F);
            phone.Location = new Point(34, 735);
            phone.Name = "phone";
            phone.Size = new Size(386, 47);
            phone.TabIndex = 22;
            // 
            // dob
            // 
            dob.CalendarFont = new Font("Segoe UI", 11F);
            dob.Font = new Font("Segoe UI", 10F);
            dob.Format = DateTimePickerFormat.Short;
            dob.Location = new Point(38, 610);
            dob.Name = "dob";
            dob.Size = new Size(384, 43);
            dob.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(34, 794);
            label10.Name = "label10";
            label10.Size = new Size(114, 41);
            label10.TabIndex = 17;
            label10.Text = "Địa chỉ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(32, 671);
            label9.Name = "label9";
            label9.Size = new Size(200, 41);
            label9.TabIndex = 15;
            label9.Text = "Số điện thoại:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(34, 555);
            label8.Name = "label8";
            label8.Size = new Size(157, 41);
            label8.TabIndex = 13;
            label8.Text = "Ngày sinh:";
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Nam ", "Nữ" });
            gender.Location = new Point(38, 498);
            gender.Name = "gender";
            gender.Size = new Size(386, 53);
            gender.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(38, 443);
            label7.Name = "label7";
            label7.Size = new Size(137, 41);
            label7.TabIndex = 11;
            label7.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(38, 326);
            label5.Name = "label5";
            label5.Size = new Size(156, 41);
            label5.TabIndex = 8;
            label5.Text = "Số CMND:";
            // 
            // cccd
            // 
            cccd.Font = new Font("Segoe UI", 11F);
            cccd.Location = new Point(38, 385);
            cccd.Name = "cccd";
            cccd.Size = new Size(386, 47);
            cccd.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(38, 198);
            label4.Name = "label4";
            label4.Size = new Size(71, 41);
            label4.TabIndex = 6;
            label4.Text = "Tên:";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 11F);
            name.Location = new Point(38, 257);
            name.Name = "name";
            name.Size = new Size(386, 47);
            name.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(txt_input);
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(27, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 390);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txt_input
            // 
            txt_input.Font = new Font("Segoe UI", 11F);
            txt_input.Location = new Point(41, 171);
            txt_input.Multiline = true;
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(430, 68);
            txt_input.TabIndex = 4;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_search.Location = new Point(41, 270);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(430, 78);
            btn_search.TabIndex = 3;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(26, 66);
            label2.Name = "label2";
            label2.Size = new Size(213, 82);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản/Tên/\r\nCMND/SĐT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(382, 50);
            label1.TabIndex = 7;
            label1.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(authorities);
            groupBox3.Controls.Add(Exit);
            groupBox3.Controls.Add(add_employee);
            groupBox3.Controls.Add(txt_update);
            groupBox3.Controls.Add(cusButton2);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(27, 1028);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1039, 369);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // authorities
            // 
            authorities.BackColor = SystemColors.ButtonHighlight;
            authorities.BackgroundColor = SystemColors.ButtonHighlight;
            authorities.BorderColor = SystemColors.HotTrack;
            authorities.BorderRadius = 35;
            authorities.BorderSize = 1;
            authorities.FlatAppearance.BorderSize = 0;
            authorities.FlatStyle = FlatStyle.Flat;
            authorities.ForeColor = SystemColors.HotTrack;
            authorities.Location = new Point(563, 177);
            authorities.Name = "authorities";
            authorities.Size = new Size(417, 77);
            authorities.TabIndex = 38;
            authorities.Text = "Quyền truy cập";
            authorities.TextColor = SystemColors.HotTrack;
            authorities.UseVisualStyleBackColor = false;
            authorities.Click += authorities_Click;
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.ButtonHighlight;
            Exit.BackgroundColor = SystemColors.ButtonHighlight;
            Exit.BorderColor = SystemColors.HotTrack;
            Exit.BorderRadius = 35;
            Exit.BorderSize = 1;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.ForeColor = SystemColors.HotTrack;
            Exit.Location = new Point(26, 270);
            Exit.Name = "Exit";
            Exit.Size = new Size(417, 77);
            Exit.TabIndex = 39;
            Exit.Text = "Đóng";
            Exit.TextColor = SystemColors.HotTrack;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // add_employee
            // 
            add_employee.BackColor = SystemColors.ButtonHighlight;
            add_employee.BackgroundColor = SystemColors.ButtonHighlight;
            add_employee.BorderColor = SystemColors.HotTrack;
            add_employee.BorderRadius = 35;
            add_employee.BorderSize = 1;
            add_employee.FlatAppearance.BorderSize = 0;
            add_employee.FlatStyle = FlatStyle.Flat;
            add_employee.ForeColor = SystemColors.HotTrack;
            add_employee.Location = new Point(563, 78);
            add_employee.Name = "add_employee";
            add_employee.Size = new Size(417, 77);
            add_employee.TabIndex = 37;
            add_employee.Text = "Thêm nhân viên";
            add_employee.TextColor = SystemColors.HotTrack;
            add_employee.UseVisualStyleBackColor = false;
            add_employee.Click += add_employee_Click;
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
            txt_update.Location = new Point(26, 78);
            txt_update.Name = "txt_update";
            txt_update.Size = new Size(417, 77);
            txt_update.TabIndex = 35;
            txt_update.Text = "Cập nhật nhân viên";
            txt_update.TextColor = SystemColors.HotTrack;
            txt_update.UseVisualStyleBackColor = false;
            txt_update.Click += txt_update_Click;
            // 
            // cusButton2
            // 
            cusButton2.BackColor = SystemColors.ButtonHighlight;
            cusButton2.BackgroundColor = SystemColors.ButtonHighlight;
            cusButton2.BorderColor = SystemColors.HotTrack;
            cusButton2.BorderRadius = 35;
            cusButton2.BorderSize = 1;
            cusButton2.FlatAppearance.BorderSize = 0;
            cusButton2.FlatStyle = FlatStyle.Flat;
            cusButton2.ForeColor = SystemColors.HotTrack;
            cusButton2.Location = new Point(26, 177);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(417, 77);
            cusButton2.TabIndex = 36;
            cusButton2.Text = "Đặt lại mật khẩu";
            cusButton2.TextColor = SystemColors.HotTrack;
            cusButton2.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ButtonHighlight;
            groupBox5.Controls.Add(ngayvaolam);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(type);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(username);
            groupBox5.Controls.Add(label12);
            groupBox5.Font = new Font("Segoe UI", 12F);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(27, 485);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(537, 528);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tài khoản nhân viên";
            // 
            // ngayvaolam
            // 
            ngayvaolam.CalendarFont = new Font("Segoe UI", 11F);
            ngayvaolam.CustomFormat = "dd/mm/yyyy";
            ngayvaolam.Font = new Font("Segoe UI", 10F);
            ngayvaolam.Format = DateTimePickerFormat.Short;
            ngayvaolam.Location = new Point(41, 428);
            ngayvaolam.Name = "ngayvaolam";
            ngayvaolam.Size = new Size(356, 43);
            ngayvaolam.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F);
            label14.Location = new Point(41, 370);
            label14.Name = "label14";
            label14.Size = new Size(206, 41);
            label14.TabIndex = 22;
            label14.Text = "Ngày vào làm:";
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.Items.AddRange(new object[] { "Quản lý", "Lễ tân" });
            type.Location = new Point(42, 285);
            type.Name = "type";
            type.Size = new Size(444, 53);
            type.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F);
            label13.Location = new Point(26, 222);
            label13.Name = "label13";
            label13.Size = new Size(215, 41);
            label13.TabIndex = 11;
            label13.Text = "Loại nhân viên:";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 11F);
            username.Location = new Point(42, 121);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(444, 68);
            username.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(26, 66);
            label12.Name = "label12";
            label12.Size = new Size(222, 41);
            label12.TabIndex = 0;
            label12.Text = "Tên đăng nhập:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(2244, 9);
            label15.Name = "label15";
            label15.Size = new Size(38, 41);
            label15.TabIndex = 19;
            label15.Text = "X";
            label15.Click += label15_Click;
            // 
            // employee_customer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2294, 1429);
            Controls.Add(label15);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "employee_customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "employee_customer";
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button button5;
        private GroupBox groupBox2;
        private TextBox address;
        private TextBox phone;
        private DateTimePicker dob;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox gender;
        private Label label7;
        private Label label5;
        private TextBox cccd;
        private Label label4;
        private TextBox name;
        private GroupBox groupBox1;
        private TextBox txt_input;
        private Button btn_search;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button button4;
        private GroupBox groupBox5;
        private TextBox username;
        private Label label12;
        private ComboBox type;
        private Label label13;
        private DateTimePicker ngayvaolam;
        private Label label14;
        private Button button7;
        private Button button6;
        private Button button3;
        private Button button2;
        private Label label15;
        private HotelManage.Assets.CusButton authorities;
        private HotelManage.Assets.CusButton Exit;
        private HotelManage.Assets.CusButton cusButton3;
        private HotelManage.Assets.CusButton txt_update;
        private HotelManage.Assets.CusButton cusButton2;
        private HotelManage.Assets.CusButton add_employee;
        private Label label3;
        private TextBox id;
    }
}
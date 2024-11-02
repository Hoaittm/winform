namespace HotelManagementSystem
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            label6 = new Label();
            panel1 = new Panel();
            cusButton4 = new HotelManage.Assets.CusButton();
            groupBox3 = new GroupBox();
            gender = new ComboBox();
            username = new TextBox();
            ngayvaolam = new TextBox();
            label4 = new Label();
            label15 = new Label();
            label14 = new Label();
            dob = new DateTimePicker();
            label13 = new Label();
            cccd = new TextBox();
            phone = new TextBox();
            label10 = new Label();
            address = new TextBox();
            label11 = new Label();
            label12 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            matkhaumoi = new TextBox();
            label8 = new Label();
            label9 = new Label();
            name = new Label();
            loainhanvien = new Label();
            pictureBox1 = new PictureBox();
            matkhaucu = new TextBox();
            xacnhanmatkhaumoi = new TextBox();
            luumatkhau = new HotelManage.Assets.CusButton();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(2, 9);
            label6.Name = "label6";
            label6.Size = new Size(467, 71);
            label6.TabIndex = 30;
            label6.Text = "Thông tin cá nhân";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(cusButton4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(name);
            panel1.Controls.Add(loainhanvien);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(1475, 1094);
            panel1.TabIndex = 31;
            // 
            // cusButton4
            // 
            cusButton4.BackColor = SystemColors.ButtonHighlight;
            cusButton4.BackgroundColor = SystemColors.ButtonHighlight;
            cusButton4.BorderColor = SystemColors.HotTrack;
            cusButton4.BorderRadius = 35;
            cusButton4.BorderSize = 1;
            cusButton4.FlatAppearance.BorderSize = 0;
            cusButton4.FlatStyle = FlatStyle.Flat;
            cusButton4.ForeColor = SystemColors.HotTrack;
            cusButton4.Location = new Point(1019, 1000);
            cusButton4.Name = "cusButton4";
            cusButton4.Size = new Size(402, 62);
            cusButton4.TabIndex = 55;
            cusButton4.Text = "Đóng";
            cusButton4.TextColor = SystemColors.HotTrack;
            cusButton4.UseVisualStyleBackColor = false;
            cusButton4.Click += cusButton4_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(gender);
            groupBox3.Controls.Add(username);
            groupBox3.Controls.Add(ngayvaolam);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(dob);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(cccd);
            groupBox3.Controls.Add(phone);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(address);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(28, 557);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1420, 408);
            groupBox3.TabIndex = 48;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin cơ bản";
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            gender.Location = new Point(991, 92);
            gender.Name = "gender";
            gender.Size = new Size(402, 48);
            gender.TabIndex = 54;
            // 
            // username
            // 
            username.Location = new Point(31, 324);
            username.Name = "username";
            username.Size = new Size(400, 46);
            username.TabIndex = 43;
            // 
            // ngayvaolam
            // 
            ngayvaolam.Location = new Point(991, 209);
            ngayvaolam.Name = "ngayvaolam";
            ngayvaolam.Size = new Size(400, 46);
            ngayvaolam.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 284);
            label4.Name = "label4";
            label4.Size = new Size(198, 37);
            label4.TabIndex = 42;
            label4.Text = "Tên đăng nhập:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(991, 169);
            label15.Name = "label15";
            label15.Size = new Size(187, 37);
            label15.TabIndex = 52;
            label15.Text = "Ngày vào làm:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(991, 54);
            label14.Name = "label14";
            label14.Size = new Size(125, 37);
            label14.TabIndex = 50;
            label14.Text = "Giới tính:";
            // 
            // dob
            // 
            dob.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dob.Format = DateTimePickerFormat.Short;
            dob.Location = new Point(499, 209);
            dob.Name = "dob";
            dob.Size = new Size(400, 39);
            dob.TabIndex = 49;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(499, 169);
            label13.Name = "label13";
            label13.Size = new Size(141, 37);
            label13.TabIndex = 48;
            label13.Text = "Ngày sinh:";
            // 
            // cccd
            // 
            cccd.Location = new Point(31, 94);
            cccd.Name = "cccd";
            cccd.Size = new Size(400, 46);
            cccd.TabIndex = 47;
            // 
            // phone
            // 
            phone.Location = new Point(499, 94);
            phone.Name = "phone";
            phone.Size = new Size(400, 46);
            phone.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(499, 54);
            label10.Name = "label10";
            label10.Size = new Size(180, 37);
            label10.TabIndex = 44;
            label10.Text = "Số điện thoại:";
            // 
            // address
            // 
            address.Location = new Point(31, 209);
            address.Name = "address";
            address.Size = new Size(400, 46);
            address.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(31, 169);
            label11.Name = "label11";
            label11.Size = new Size(104, 37);
            label11.TabIndex = 42;
            label11.Text = "Địa chỉ:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(31, 54);
            label12.Name = "label12";
            label12.Size = new Size(268, 37);
            label12.TabIndex = 0;
            label12.Text = "Thẻ căn cước/CMND:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(luumatkhau);
            groupBox2.Controls.Add(xacnhanmatkhaumoi);
            groupBox2.Controls.Add(matkhaucu);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(matkhaumoi);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(937, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 490);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bảo mật";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 280);
            label7.Name = "label7";
            label7.Size = new Size(301, 37);
            label7.TabIndex = 44;
            label7.Text = "Xác nhận mật khẩu mới:";
            // 
            // matkhaumoi
            // 
            matkhaumoi.Location = new Point(31, 209);
            matkhaumoi.Name = "matkhaumoi";
            matkhaumoi.Size = new Size(400, 46);
            matkhaumoi.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 169);
            label8.Name = "label8";
            label8.Size = new Size(187, 37);
            label8.TabIndex = 42;
            label8.Text = "Mật khẩu mới:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 54);
            label9.Name = "label9";
            label9.Size = new Size(134, 37);
            label9.TabIndex = 0;
            label9.Text = "Mật khẩu:";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 11F);
            name.ForeColor = SystemColors.HotTrack;
            name.Location = new Point(292, 418);
            name.Name = "name";
            name.Size = new Size(207, 41);
            name.TabIndex = 2;
            name.Text = "Nguyễn Văn A";
            // 
            // loainhanvien
            // 
            loainhanvien.AutoSize = true;
            loainhanvien.Font = new Font("Segoe UI", 11F);
            loainhanvien.ForeColor = SystemColors.HotTrack;
            loainhanvien.Location = new Point(333, 351);
            loainhanvien.Name = "loainhanvien";
            loainhanvien.Size = new Size(138, 41);
            loainhanvien.TabIndex = 1;
            loainhanvien.Text = "nhanvien";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 265);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // matkhaucu
            // 
            matkhaucu.Location = new Point(31, 103);
            matkhaucu.Name = "matkhaucu";
            matkhaucu.Size = new Size(400, 46);
            matkhaucu.TabIndex = 45;
            // 
            // xacnhanmatkhaumoi
            // 
            xacnhanmatkhaumoi.Location = new Point(31, 352);
            xacnhanmatkhaumoi.Name = "xacnhanmatkhaumoi";
            xacnhanmatkhaumoi.Size = new Size(400, 46);
            xacnhanmatkhaumoi.TabIndex = 46;
            // 
            // luumatkhau
            // 
            luumatkhau.BackColor = SystemColors.ButtonHighlight;
            luumatkhau.BackgroundColor = SystemColors.ButtonHighlight;
            luumatkhau.BorderColor = SystemColors.HotTrack;
            luumatkhau.BorderRadius = 35;
            luumatkhau.BorderSize = 1;
            luumatkhau.FlatAppearance.BorderSize = 0;
            luumatkhau.FlatStyle = FlatStyle.Flat;
            luumatkhau.ForeColor = SystemColors.HotTrack;
            luumatkhau.Location = new Point(31, 422);
            luumatkhau.Name = "luumatkhau";
            luumatkhau.Size = new Size(402, 62);
            luumatkhau.TabIndex = 56;
            luumatkhau.Text = "Lưu thay đổi";
            luumatkhau.TextColor = SystemColors.HotTrack;
            luumatkhau.UseVisualStyleBackColor = false;
            luumatkhau.Click += luumatkhau_Click;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 1191);
            Controls.Add(panel1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Information";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label name;
        private Label loainhanvien;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label3;
        private TextBox username;
        private Label label4;
        private Label label5;
        private GroupBox groupBox3;
        private TextBox cccd;
        private TextBox phone;
        private Label label10;
        private TextBox address;
        private Label label11;
        private Label label12;
        private GroupBox groupBox2;
        private TextBox password;
        private HotelManage.Assets.CusButton cusButton1;
        private TextBox textBox2;
        private Label label7;
        private TextBox matkhaumoi;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private HotelManage.Assets.CusButton cusButton2;
        private HotelManage.Assets.CusButton cusButton4;
        private ComboBox gender;
        private TextBox ngayvaolam;
        private Label label15;
        private Label label14;
        private DateTimePicker dob;
        private Label label13;
        private HotelManage.Assets.CusButton luumatkhau;
        private TextBox xacnhanmatkhaumoi;
        private TextBox matkhaucu;
    }
}
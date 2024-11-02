namespace HotelManagementSystem
{
    partial class booking_details
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
            label6 = new Label();
            groupBox1 = new GroupBox();
            night = new TextBox();
            label5 = new Label();
            ngaytra = new DateTimePicker();
            label4 = new Label();
            ngaynhan = new DateTimePicker();
            label3 = new Label();
            maphong = new TextBox();
            label2 = new Label();
            tenphong = new ComboBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            dong = new HotelManage.Assets.CusButton();
            diachi = new TextBox();
            gioitinh = new TextBox();
            quoctich = new TextBox();
            label14 = new Label();
            label13 = new Label();
            dienthoai = new TextBox();
            label7 = new Label();
            label12 = new Label();
            cmnd = new TextBox();
            label11 = new Label();
            ngaysinh = new DateTimePicker();
            label8 = new Label();
            hoten = new TextBox();
            label9 = new Label();
            loaikhachhang = new ComboBox();
            label10 = new Label();
            txt_Exit = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(465, 71);
            label6.TabIndex = 14;
            label6.Text = "Chi tiết đặt phòng";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(night);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ngaytra);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ngaynhan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(maphong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tenphong);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 757);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhận phòng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // night
            // 
            night.Location = new Point(24, 614);
            night.Name = "night";
            night.Size = new Size(370, 46);
            night.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 565);
            label5.Name = "label5";
            label5.Size = new Size(113, 37);
            label5.TabIndex = 8;
            label5.Text = "Số đêm:";
            // 
            // ngaytra
            // 
            ngaytra.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaytra.Format = DateTimePickerFormat.Short;
            ngaytra.Location = new Point(25, 483);
            ngaytra.Name = "ngaytra";
            ngaytra.Size = new Size(369, 43);
            ngaytra.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 430);
            label4.Name = "label4";
            label4.Size = new Size(132, 37);
            label4.TabIndex = 6;
            label4.Text = "Ngày trả: ";
            // 
            // ngaynhan
            // 
            ngaynhan.CalendarMonthBackground = SystemColors.ActiveCaption;
            ngaynhan.CalendarTrailingForeColor = SystemColors.GradientInactiveCaption;
            ngaynhan.Enabled = false;
            ngaynhan.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaynhan.Format = DateTimePickerFormat.Short;
            ngaynhan.ImeMode = ImeMode.On;
            ngaynhan.Location = new Point(25, 369);
            ngaynhan.Name = "ngaynhan";
            ngaynhan.Size = new Size(369, 43);
            ngaynhan.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 316);
            label3.Name = "label3";
            label3.Size = new Size(159, 37);
            label3.TabIndex = 4;
            label3.Text = "Ngày nhận: ";
            // 
            // maphong
            // 
            maphong.Location = new Point(28, 108);
            maphong.Name = "maphong";
            maphong.Size = new Size(370, 46);
            maphong.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 177);
            label2.Name = "label2";
            label2.Size = new Size(199, 37);
            label2.TabIndex = 2;
            label2.Text = "Tên loại phòng:";
            // 
            // tenphong
            // 
            tenphong.FormattingEnabled = true;
            tenphong.Items.AddRange(new object[] { "Phòng Deluxe (DLX)", "Phòng Suite (SUT)", "Phòng Superior (SUP)", "Phòng Standard (STD)" });
            tenphong.Location = new Point(25, 233);
            tenphong.Name = "tenphong";
            tenphong.Size = new Size(369, 48);
            tenphong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 54);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 0;
            label1.Text = "Mã đặt phòng:";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(dong);
            groupBox4.Controls.Add(diachi);
            groupBox4.Controls.Add(gioitinh);
            groupBox4.Controls.Add(quoctich);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(dienthoai);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(cmnd);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(ngaysinh);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(hoten);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(loaikhachhang);
            groupBox4.Controls.Add(label10);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.HotTrack;
            groupBox4.Location = new Point(491, 93);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(893, 757);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin khách hàng";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // dong
            // 
            dong.BackColor = SystemColors.ButtonHighlight;
            dong.BackgroundColor = SystemColors.ButtonHighlight;
            dong.BorderColor = SystemColors.HotTrack;
            dong.BorderRadius = 35;
            dong.BorderSize = 1;
            dong.FlatAppearance.BorderSize = 0;
            dong.FlatStyle = FlatStyle.Flat;
            dong.ForeColor = SystemColors.HotTrack;
            dong.Location = new Point(455, 659);
            dong.Name = "dong";
            dong.Size = new Size(366, 77);
            dong.TabIndex = 38;
            dong.Text = "Đóng";
            dong.TextColor = SystemColors.HotTrack;
            dong.UseVisualStyleBackColor = false;
            dong.Click += dong_Click;
            // 
            // diachi
            // 
            diachi.Location = new Point(460, 258);
            diachi.Name = "diachi";
            diachi.Size = new Size(370, 50);
            diachi.TabIndex = 35;
            // 
            // gioitinh
            // 
            gioitinh.Location = new Point(460, 403);
            gioitinh.Name = "gioitinh";
            gioitinh.Size = new Size(370, 50);
            gioitinh.TabIndex = 34;
            // 
            // quoctich
            // 
            quoctich.Location = new Point(460, 550);
            quoctich.Name = "quoctich";
            quoctich.Size = new Size(370, 50);
            quoctich.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(460, 499);
            label14.Name = "label14";
            label14.Size = new Size(136, 37);
            label14.TabIndex = 16;
            label14.Text = "Quốc tịch:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(455, 349);
            label13.Name = "label13";
            label13.Size = new Size(125, 37);
            label13.TabIndex = 14;
            label13.Text = "GIới tính:";
            // 
            // dienthoai
            // 
            dienthoai.Location = new Point(35, 550);
            dienthoai.Name = "dienthoai";
            dienthoai.Size = new Size(370, 50);
            dienthoai.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(455, 207);
            label7.Name = "label7";
            label7.Size = new Size(104, 37);
            label7.TabIndex = 12;
            label7.Text = "Địa chỉ:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(35, 499);
            label12.Name = "label12";
            label12.Size = new Size(180, 37);
            label12.TabIndex = 12;
            label12.Text = "Số điện thoại:";
            // 
            // cmnd
            // 
            cmnd.Location = new Point(26, 258);
            cmnd.Name = "cmnd";
            cmnd.Size = new Size(370, 50);
            cmnd.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(26, 207);
            label11.Name = "label11";
            label11.Size = new Size(275, 37);
            label11.TabIndex = 10;
            label11.Text = "Thẻ căn cước /CMND:";
            // 
            // ngaysinh
            // 
            ngaysinh.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaysinh.Format = DateTimePickerFormat.Short;
            ngaysinh.Location = new Point(455, 131);
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Size = new Size(374, 43);
            ngaysinh.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(455, 72);
            label8.Name = "label8";
            label8.Size = new Size(141, 37);
            label8.TabIndex = 4;
            label8.Text = "Ngày sinh:";
            // 
            // hoten
            // 
            hoten.Location = new Point(26, 124);
            hoten.Name = "hoten";
            hoten.Size = new Size(370, 50);
            hoten.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(26, 72);
            label9.Name = "label9";
            label9.Size = new Size(137, 37);
            label9.TabIndex = 2;
            label9.Text = "Họ và tên:";
            // 
            // loaikhachhang
            // 
            loaikhachhang.FormattingEnabled = true;
            loaikhachhang.Items.AddRange(new object[] { "Khách vãng lai", "Khách du lịch", "Khách địa phương", "Khách đi qua các tổ chức trung gian" });
            loaikhachhang.Location = new Point(35, 403);
            loaikhachhang.Name = "loaikhachhang";
            loaikhachhang.Size = new Size(369, 53);
            loaikhachhang.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(35, 349);
            label10.Name = "label10";
            label10.Size = new Size(216, 37);
            label10.TabIndex = 0;
            label10.Text = "Loại khách hàng:";
            // 
            // txt_Exit
            // 
            txt_Exit.AutoSize = true;
            txt_Exit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Exit.ForeColor = Color.Red;
            txt_Exit.Location = new Point(1343, 18);
            txt_Exit.Name = "txt_Exit";
            txt_Exit.Size = new Size(38, 41);
            txt_Exit.TabIndex = 18;
            txt_Exit.Text = "X";
            txt_Exit.Click += txt_Exit_Click;
            // 
            // booking_details
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 864);
            Controls.Add(txt_Exit);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "booking_details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "booking_details";
            Load += booking_details_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private GroupBox groupBox1;
        private DateTimePicker ngaytra;
        private Label label4;
        private DateTimePicker ngaynhan;
        private Label label3;
        private TextBox maphong;
        private Label label2;
        private ComboBox tenphong;
        private Label label1;
        private TextBox night;
        private Label label5;
        private HotelManage.Assets.CusButton cusButton2;
        private GroupBox groupBox4;
        private HotelManage.Assets.CusButton cusButton3;
        private HotelManage.Assets.CusButton cusButton1;
        private ComboBox comboBox4;
        private Label label14;
        private ComboBox comboBox3;
        private Label label13;
        private TextBox textBox6;
        private TextBox dienthoai;
        private Label label7;
        private Label label12;
        private TextBox cmnd;
        private Label label11;
        private DateTimePicker ngaysinh;
        private Label label8;
        private TextBox hoten;
        private Label label9;
        private ComboBox loaikhachhang;
        private Label label10;
        private Label txt_Exit;
        private TextBox quoctich;
        private TextBox diachi;
        private TextBox gioitinh;
        private HotelManage.Assets.CusButton luuchitietdatphong;
        private HotelManage.Assets.CusButton dong;
        private HotelManage.Assets.CusButton capnhatkhachhangdatphong;
    }
}
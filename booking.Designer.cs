﻿namespace HotelManagementSystem
{
    partial class booking
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox5 = new GroupBox();
            txt_Dong = new HotelManage.Assets.CusButton();
            cusButton3 = new HotelManage.Assets.CusButton();
            cusButton1 = new HotelManage.Assets.CusButton();
            checkBox1 = new CheckBox();
            groupBox4 = new GroupBox();
            country = new TextBox();
            label14 = new Label();
            gender = new ComboBox();
            label13 = new Label();
            address = new TextBox();
            phone = new TextBox();
            label5 = new Label();
            label12 = new Label();
            cmnd = new TextBox();
            label11 = new Label();
            dob = new DateTimePicker();
            label7 = new Label();
            name = new TextBox();
            label8 = new Label();
            type = new ComboBox();
            label9 = new Label();
            thongtinloaiphong = new GroupBox();
            price = new TextBox();
            label18 = new Label();
            quantityuser = new TextBox();
            label17 = new Label();
            tenloaiphong = new TextBox();
            label16 = new Label();
            maphong = new TextBox();
            label15 = new Label();
            thongtindangky = new GroupBox();
            datecheckout = new DateTimePicker();
            label4 = new Label();
            datecheckin = new DateTimePicker();
            label3 = new Label();
            night = new TextBox();
            label2 = new Label();
            loaiphong = new ComboBox();
            label1 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            txt_bookingdetail = new HotelManage.Assets.CusButton();
            dataGridView1 = new DataGridView();
            groupBox6 = new GroupBox();
            btn_search = new HotelManage.Assets.CusButton();
            txt_cccd = new TextBox();
            label21 = new Label();
            txt_Exit = new Label();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            thongtinloaiphong.SuspendLayout();
            thongtindangky.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ButtonHighlight;
            groupBox5.Controls.Add(txt_Dong);
            groupBox5.Controls.Add(cusButton3);
            groupBox5.Controls.Add(cusButton1);
            groupBox5.Controls.Add(checkBox1);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(928, 678);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(518, 636);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // txt_Dong
            // 
            txt_Dong.BackColor = SystemColors.ButtonHighlight;
            txt_Dong.BackgroundColor = SystemColors.ButtonHighlight;
            txt_Dong.BorderColor = SystemColors.HotTrack;
            txt_Dong.BorderRadius = 35;
            txt_Dong.BorderSize = 1;
            txt_Dong.FlatAppearance.BorderSize = 0;
            txt_Dong.FlatStyle = FlatStyle.Flat;
            txt_Dong.ForeColor = SystemColors.HotTrack;
            txt_Dong.Location = new Point(30, 459);
            txt_Dong.Name = "txt_Dong";
            txt_Dong.Size = new Size(443, 87);
            txt_Dong.TabIndex = 32;
            txt_Dong.Text = "Đóng";
            txt_Dong.TextColor = SystemColors.HotTrack;
            txt_Dong.UseVisualStyleBackColor = false;
            txt_Dong.Click += txt_Dong_Click;
            // 
            // cusButton3
            // 
            cusButton3.BackColor = SystemColors.ButtonHighlight;
            cusButton3.BackgroundColor = SystemColors.ButtonHighlight;
            cusButton3.BorderColor = SystemColors.HotTrack;
            cusButton3.BorderRadius = 35;
            cusButton3.BorderSize = 1;
            cusButton3.FlatAppearance.BorderSize = 0;
            cusButton3.FlatStyle = FlatStyle.Flat;
            cusButton3.ForeColor = SystemColors.HotTrack;
            cusButton3.Location = new Point(30, 322);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(443, 87);
            cusButton3.TabIndex = 31;
            cusButton3.Text = "Hủy";
            cusButton3.TextColor = SystemColors.HotTrack;
            cusButton3.UseVisualStyleBackColor = false;
            // 
            // cusButton1
            // 
            cusButton1.BackColor = SystemColors.ButtonHighlight;
            cusButton1.BackgroundColor = SystemColors.ButtonHighlight;
            cusButton1.BorderColor = SystemColors.HotTrack;
            cusButton1.BorderRadius = 35;
            cusButton1.BorderSize = 1;
            cusButton1.FlatAppearance.BorderSize = 0;
            cusButton1.FlatStyle = FlatStyle.Flat;
            cusButton1.ForeColor = SystemColors.HotTrack;
            cusButton1.Location = new Point(30, 180);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(443, 87);
            cusButton1.TabIndex = 30;
            cusButton1.Text = "Đặt phòng";
            cusButton1.TextColor = SystemColors.HotTrack;
            cusButton1.UseVisualStyleBackColor = false;
            cusButton1.Click += cusButton1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(57, 100);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(362, 44);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Chuyển đến nhận phòng";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(country);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(gender);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(address);
            groupBox4.Controls.Add(phone);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(cmnd);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(dob);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(name);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(type);
            groupBox4.Controls.Add(label9);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.HotTrack;
            groupBox4.Location = new Point(25, 678);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(879, 636);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin khách hàng";
            // 
            // country
            // 
            country.Location = new Point(455, 560);
            country.Name = "country";
            country.Size = new Size(370, 43);
            country.TabIndex = 17;
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
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Nam ", "Nữ" });
            gender.Location = new Point(455, 403);
            gender.Name = "gender";
            gender.Size = new Size(369, 45);
            gender.TabIndex = 15;
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
            // address
            // 
            address.Location = new Point(455, 258);
            address.Name = "address";
            address.Size = new Size(370, 43);
            address.TabIndex = 13;
            // 
            // phone
            // 
            phone.Location = new Point(35, 550);
            phone.Name = "phone";
            phone.Size = new Size(370, 43);
            phone.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(455, 207);
            label5.Name = "label5";
            label5.Size = new Size(104, 37);
            label5.TabIndex = 12;
            label5.Text = "Địa chỉ:";
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
            label12.Click += label12_Click;
            // 
            // cmnd
            // 
            cmnd.Location = new Point(26, 258);
            cmnd.Name = "cmnd";
            cmnd.Size = new Size(370, 43);
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
            // dob
            // 
            dob.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dob.Format = DateTimePickerFormat.Short;
            dob.Location = new Point(455, 131);
            dob.Name = "dob";
            dob.Size = new Size(400, 43);
            dob.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(455, 72);
            label7.Name = "label7";
            label7.Size = new Size(141, 37);
            label7.TabIndex = 4;
            label7.Text = "Ngày sinh:";
            // 
            // name
            // 
            name.Location = new Point(26, 124);
            name.Name = "name";
            name.Size = new Size(370, 43);
            name.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 72);
            label8.Name = "label8";
            label8.Size = new Size(137, 37);
            label8.TabIndex = 2;
            label8.Text = "Họ và tên:";
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.Items.AddRange(new object[] { "Khách vãng lai", "Khách du lịch", "Khách địa phương", "Khách đi qua các tổ chức trung gian" });
            type.Location = new Point(35, 403);
            type.Name = "type";
            type.Size = new Size(369, 45);
            type.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 349);
            label9.Name = "label9";
            label9.Size = new Size(216, 37);
            label9.TabIndex = 0;
            label9.Text = "Loại khách hàng:";
            // 
            // thongtinloaiphong
            // 
            thongtinloaiphong.BackColor = SystemColors.ButtonHighlight;
            thongtinloaiphong.Controls.Add(price);
            thongtinloaiphong.Controls.Add(label18);
            thongtinloaiphong.Controls.Add(quantityuser);
            thongtinloaiphong.Controls.Add(label17);
            thongtinloaiphong.Controls.Add(tenloaiphong);
            thongtinloaiphong.Controls.Add(label16);
            thongtinloaiphong.Controls.Add(maphong);
            thongtinloaiphong.Controls.Add(label15);
            thongtinloaiphong.FlatStyle = FlatStyle.Flat;
            thongtinloaiphong.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thongtinloaiphong.ForeColor = SystemColors.HotTrack;
            thongtinloaiphong.Location = new Point(928, 98);
            thongtinloaiphong.Name = "thongtinloaiphong";
            thongtinloaiphong.Size = new Size(518, 558);
            thongtinloaiphong.TabIndex = 15;
            thongtinloaiphong.TabStop = false;
            thongtinloaiphong.Text = "Thông tin loại phòng";
            thongtinloaiphong.Enter += thongtinloaiphong_Enter;
            // 
            // price
            // 
            price.Location = new Point(22, 469);
            price.Name = "price";
            price.Size = new Size(451, 43);
            price.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(22, 429);
            label18.Name = "label18";
            label18.Size = new Size(70, 37);
            label18.TabIndex = 10;
            label18.Text = "Giá: ";
            // 
            // quantityuser
            // 
            quantityuser.Location = new Point(22, 356);
            quantityuser.Name = "quantityuser";
            quantityuser.Size = new Size(451, 43);
            quantityuser.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(22, 307);
            label17.Name = "label17";
            label17.Size = new Size(290, 37);
            label17.TabIndex = 8;
            label17.Text = "Số lượng người tối đa: ";
            // 
            // tenloaiphong
            // 
            tenloaiphong.Location = new Point(22, 234);
            tenloaiphong.Name = "tenloaiphong";
            tenloaiphong.Size = new Size(451, 43);
            tenloaiphong.TabIndex = 7;
            tenloaiphong.TextChanged += tenloaiphong_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(22, 184);
            label16.Name = "label16";
            label16.Size = new Size(213, 37);
            label16.TabIndex = 6;
            label16.Text = "Tên loại  phòng: ";
            // 
            // maphong
            // 
            maphong.Location = new Point(22, 109);
            maphong.Name = "maphong";
            maphong.Size = new Size(451, 43);
            maphong.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(22, 59);
            label15.Name = "label15";
            label15.Size = new Size(197, 37);
            label15.TabIndex = 4;
            label15.Text = "Mã loại phòng:";
            // 
            // thongtindangky
            // 
            thongtindangky.BackColor = SystemColors.ButtonHighlight;
            thongtindangky.Controls.Add(datecheckout);
            thongtindangky.Controls.Add(label4);
            thongtindangky.Controls.Add(datecheckin);
            thongtindangky.Controls.Add(label3);
            thongtindangky.Controls.Add(night);
            thongtindangky.Controls.Add(label2);
            thongtindangky.Controls.Add(loaiphong);
            thongtindangky.Controls.Add(label1);
            thongtindangky.FlatStyle = FlatStyle.Flat;
            thongtindangky.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thongtindangky.ForeColor = SystemColors.HotTrack;
            thongtindangky.Location = new Point(25, 98);
            thongtindangky.Name = "thongtindangky";
            thongtindangky.Size = new Size(879, 333);
            thongtindangky.TabIndex = 14;
            thongtindangky.TabStop = false;
            thongtindangky.Text = "Thông tin đăng ký";
            thongtindangky.Enter += thongtindangky_Enter;
            // 
            // datecheckout
            // 
            datecheckout.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datecheckout.Format = DateTimePickerFormat.Short;
            datecheckout.Location = new Point(440, 222);
            datecheckout.Name = "datecheckout";
            datecheckout.Size = new Size(400, 43);
            datecheckout.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(440, 168);
            label4.Name = "label4";
            label4.Size = new Size(132, 37);
            label4.TabIndex = 6;
            label4.Text = "Ngày trả: ";
            // 
            // datecheckin
            // 
            datecheckin.CalendarMonthBackground = SystemColors.ActiveCaption;
            datecheckin.CalendarTrailingForeColor = SystemColors.GradientInactiveCaption;
            datecheckin.Enabled = false;
            datecheckin.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datecheckin.Format = DateTimePickerFormat.Short;
            datecheckin.ImeMode = ImeMode.On;
            datecheckin.Location = new Point(440, 99);
            datecheckin.Name = "datecheckin";
            datecheckin.Size = new Size(400, 43);
            datecheckin.TabIndex = 5;
            datecheckin.ValueChanged += datecheckin_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(440, 56);
            label3.Name = "label3";
            label3.Size = new Size(159, 37);
            label3.TabIndex = 4;
            label3.Text = "Ngày nhận: ";
            label3.Click += label3_Click;
            // 
            // night
            // 
            night.Location = new Point(14, 219);
            night.Name = "night";
            night.Size = new Size(370, 46);
            night.TabIndex = 3;
            night.TextChanged += night_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 168);
            label2.Name = "label2";
            label2.Size = new Size(113, 37);
            label2.TabIndex = 2;
            label2.Text = "Số đêm:";
            // 
            // loaiphong
            // 
            loaiphong.FormattingEnabled = true;
            loaiphong.Items.AddRange(new object[] { "Phòng Deluxe (DLX)", "Phòng Suite (SUT)", "Phòng Superior (SUP)", "Phòng Standard (STD)" });
            loaiphong.Location = new Point(14, 99);
            loaiphong.Name = "loaiphong";
            loaiphong.Size = new Size(369, 48);
            loaiphong.TabIndex = 1;
            loaiphong.SelectedIndexChanged += loaiphong_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 56);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 0;
            label1.Text = "Loại phòng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(284, 71);
            label6.TabIndex = 13;
            label6.Text = "Đặt phòng";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(txt_bookingdetail);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(1477, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1307, 1216);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách đặt phòng trong ngày";
            // 
            // txt_bookingdetail
            // 
            txt_bookingdetail.BackColor = SystemColors.ButtonHighlight;
            txt_bookingdetail.BackgroundColor = SystemColors.ButtonHighlight;
            txt_bookingdetail.BorderColor = SystemColors.HotTrack;
            txt_bookingdetail.BorderRadius = 35;
            txt_bookingdetail.BorderSize = 1;
            txt_bookingdetail.FlatAppearance.BorderSize = 0;
            txt_bookingdetail.FlatStyle = FlatStyle.Flat;
            txt_bookingdetail.ForeColor = SystemColors.HotTrack;
            txt_bookingdetail.Location = new Point(840, 1093);
            txt_bookingdetail.Name = "txt_bookingdetail";
            txt_bookingdetail.Size = new Size(443, 87);
            txt_bookingdetail.TabIndex = 33;
            txt_bookingdetail.Text = "Xem chi tiết";
            txt_bookingdetail.TextColor = SystemColors.HotTrack;
            txt_bookingdetail.UseVisualStyleBackColor = false;
            txt_bookingdetail.Click += txt_bookingdetail_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(19, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1282, 604);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.ButtonHighlight;
            groupBox6.Controls.Add(btn_search);
            groupBox6.Controls.Add(txt_cccd);
            groupBox6.Controls.Add(label21);
            groupBox6.FlatStyle = FlatStyle.Flat;
            groupBox6.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox6.ForeColor = SystemColors.HotTrack;
            groupBox6.Location = new Point(25, 454);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(879, 202);
            groupBox6.TabIndex = 15;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tìm kiếm khách hàng";
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ButtonHighlight;
            btn_search.BackgroundColor = SystemColors.ButtonHighlight;
            btn_search.BorderColor = SystemColors.HotTrack;
            btn_search.BorderRadius = 35;
            btn_search.BorderSize = 1;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.ForeColor = SystemColors.HotTrack;
            btn_search.Location = new Point(452, 87);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(362, 68);
            btn_search.TabIndex = 29;
            btn_search.Text = "Tìm kiếm";
            btn_search.TextColor = SystemColors.HotTrack;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // txt_cccd
            // 
            txt_cccd.Location = new Point(14, 113);
            txt_cccd.Name = "txt_cccd";
            txt_cccd.Size = new Size(370, 46);
            txt_cccd.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(14, 62);
            label21.Name = "label21";
            label21.Size = new Size(282, 37);
            label21.TabIndex = 2;
            label21.Text = "Thẻ căn cước / CMND:";
            // 
            // txt_Exit
            // 
            txt_Exit.AutoSize = true;
            txt_Exit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Exit.ForeColor = Color.Red;
            txt_Exit.Location = new Point(2737, 19);
            txt_Exit.Name = "txt_Exit";
            txt_Exit.Size = new Size(38, 41);
            txt_Exit.TabIndex = 19;
            txt_Exit.Text = "X";
            txt_Exit.Click += label10_Click;
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2787, 1358);
            Controls.Add(txt_Exit);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(thongtinloaiphong);
            Controls.Add(thongtindangky);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "booking";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            thongtinloaiphong.ResumeLayout(false);
            thongtinloaiphong.PerformLayout();
            thongtindangky.ResumeLayout(false);
            thongtindangky.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox5;
        private CheckBox checkBox1;
        private GroupBox groupBox4;
        private Label label14;
        private ComboBox gender;
        private Label label13;
        private TextBox address;
        private TextBox phone;
        private Label label5;
        private Label label12;
        private TextBox cmnd;
        private Label label11;
        private DateTimePicker dob;
        private Label label7;
        private TextBox name;
        private Label label8;
        private ComboBox type;
        private Label label9;
        private GroupBox thongtinloaiphong;
        private TextBox price;
        private Label label18;
        private TextBox quantityuser;
        private Label label17;
        private TextBox tenloaiphong;
        private Label label16;
        private TextBox maphong;
        private Label label15;
        private GroupBox thongtindangky;
        private DateTimePicker datecheckout;
        private Label label4;
        private DateTimePicker datecheckin;
        private Label label3;
        private TextBox night;
        private Label label2;
        private ComboBox loaiphong;
        private Label label1;
        private Label label6;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox6;
        private TextBox txt_cccd;
        private Label label21;
        private HotelManage.Assets.CusButton btn_search;
        private HotelManage.Assets.CusButton txt_Dong;
        private HotelManage.Assets.CusButton cusButton3;
        private HotelManage.Assets.CusButton cusButton1;
        private HotelManage.Assets.CusButton txt_bookingdetail;
        private Label txt_Exit;
        private TextBox country;
    }
}
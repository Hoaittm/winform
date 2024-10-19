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
            cusButton2 = new HotelManage.Assets.CusButton();
            night = new TextBox();
            label5 = new Label();
            datecheckout = new DateTimePicker();
            label4 = new Label();
            datecheckin = new DateTimePicker();
            label3 = new Label();
            id = new TextBox();
            label2 = new Label();
            type = new ComboBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            cusButton3 = new HotelManage.Assets.CusButton();
            cusButton1 = new HotelManage.Assets.CusButton();
            label14 = new Label();
         
            label13 = new Label();
        
            phone = new TextBox();
            label7 = new Label();
            label12 = new Label();
            cccd = new TextBox();
            label11 = new Label();
            dob = new DateTimePicker();
            label8 = new Label();
            name = new TextBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label10 = new Label();
            txt_Exit = new Label();
            country = new TextBox();
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
            groupBox1.Controls.Add(cusButton2);
            groupBox1.Controls.Add(night);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(datecheckout);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(datecheckin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(type);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 797);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhận phòng";
            groupBox1.Enter += groupBox1_Enter;
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
            cusButton2.Location = new Point(25, 693);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(362, 68);
            cusButton2.TabIndex = 30;
            cusButton2.Text = "Lưu thay đổi";
            cusButton2.TextColor = SystemColors.HotTrack;
            cusButton2.UseVisualStyleBackColor = false;
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
            // datecheckout
            // 
            datecheckout.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datecheckout.Format = DateTimePickerFormat.Short;
            datecheckout.Location = new Point(25, 483);
            datecheckout.Name = "datecheckout";
            datecheckout.Size = new Size(369, 43);
            datecheckout.TabIndex = 7;
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
            // datecheckin
            // 
            datecheckin.CalendarMonthBackground = SystemColors.ActiveCaption;
            datecheckin.CalendarTrailingForeColor = SystemColors.GradientInactiveCaption;
            datecheckin.Enabled = false;
            datecheckin.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datecheckin.Format = DateTimePickerFormat.Short;
            datecheckin.ImeMode = ImeMode.On;
            datecheckin.Location = new Point(25, 369);
            datecheckin.Name = "datecheckin";
            datecheckin.Size = new Size(369, 43);
            datecheckin.TabIndex = 5;
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
            // id
            // 
            id.Location = new Point(28, 108);
            id.Name = "id";
            id.Size = new Size(370, 46);
            id.TabIndex = 3;
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
            // type
            // 
            type.FormattingEnabled = true;
            type.Items.AddRange(new object[] { "Phòng Deluxe (DLX)", "Phòng Suite (SUT)", "Phòng Superior (SUP)", "Phòng Standard (STD)" });
            type.Location = new Point(25, 233);
            type.Name = "type";
            type.Size = new Size(369, 48);
            type.TabIndex = 1;
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
            groupBox4.Controls.Add(country);
            groupBox4.Controls.Add(cusButton3);
            groupBox4.Controls.Add(cusButton1);
            groupBox4.Controls.Add(label14);
           
            groupBox4.Controls.Add(label13);
         
            groupBox4.Controls.Add(phone);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(cccd);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(dob);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(name);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Controls.Add(label10);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.HotTrack;
            groupBox4.Location = new Point(491, 93);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(893, 797);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin khách hàng";
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
            cusButton3.Location = new Point(460, 691);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(369, 68);
            cusButton3.TabIndex = 32;
            cusButton3.Text = "Xóa khách hàng";
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
            cusButton1.Location = new Point(35, 691);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(369, 68);
            cusButton1.TabIndex = 31;
            cusButton1.Text = "Cập nhật khách hàng";
            cusButton1.TextColor = SystemColors.HotTrack;
            cusButton1.UseVisualStyleBackColor = false;
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
          
            // 
            // phone
            // 
            phone.Location = new Point(35, 550);
            phone.Name = "phone";
            phone.Size = new Size(370, 50);
            phone.TabIndex = 13;
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
            // cccd
            // 
            cccd.Location = new Point(26, 258);
            cccd.Name = "cccd";
            cccd.Size = new Size(370, 50);
            cccd.TabIndex = 11;
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
            dob.Size = new Size(374, 43);
            dob.TabIndex = 5;
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
            // name
            // 
            name.Location = new Point(26, 124);
            name.Name = "name";
            name.Size = new Size(370, 50);
            name.TabIndex = 3;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Khách vãng lai", "Khách du lịch", "Khách địa phương", "Khách đi qua các tổ chức trung gian" });
            comboBox2.Location = new Point(35, 403);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(369, 53);
            comboBox2.TabIndex = 1;
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
            // country
            // 
            country.Location = new Point(460, 539);
            country.Name = "country";
            country.Size = new Size(370, 50);
            country.TabIndex = 33;
            // 
            // booking_details
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 914);
            Controls.Add(txt_Exit);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "booking_details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "booking_details";
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
        private DateTimePicker datecheckout;
        private Label label4;
        private DateTimePicker datecheckin;
        private Label label3;
        private TextBox id;
        private Label label2;
        private ComboBox type;
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
        private TextBox phone;
        private Label label7;
        private Label label12;
        private TextBox cccd;
        private Label label11;
        private DateTimePicker dob;
        private Label label8;
        private TextBox name;
        private Label label9;
        private ComboBox comboBox2;
        private Label label10;
        private Label txt_Exit;
        private TextBox country;
    }
}
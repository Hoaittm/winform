namespace HotelManagementSystem
{
    partial class add_user
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            dateTime = new DateTimePicker();
            gender = new ComboBox();
            type_user = new ComboBox();
            label9 = new Label();
            country = new TextBox();
            label8 = new Label();
            phone = new TextBox();
            label7 = new Label();
            address = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            cccd = new TextBox();
            label4 = new Label();
            name = new TextBox();
            groupBox2 = new GroupBox();
            btn_Exit = new HotelManage.Assets.CusButton();
            cusButton1 = new HotelManage.Assets.CusButton();
            comboBox3 = new ComboBox();
            label10 = new Label();
            textBox2 = new TextBox();
            label14 = new Label();
            txt_Exit = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(319, 50);
            label1.TabIndex = 0;
            label1.Text = "Thêm khách hàng";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(dateTime);
            groupBox1.Controls.Add(gender);
            groupBox1.Controls.Add(type_user);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(country);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(phone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(address);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cccd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(name);
            groupBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(22, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 709);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTime
            // 
            dateTime.CustomFormat = "dd/mm/yyyy";
            dateTime.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTime.Format = DateTimePickerFormat.Short;
            dateTime.Location = new Point(463, 151);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(355, 46);
            dateTime.TabIndex = 25;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Nam ", "Nữ" });
            gender.Location = new Point(39, 550);
            gender.Name = "gender";
            gender.Size = new Size(349, 48);
            gender.TabIndex = 24;
            // 
            // type_user
            // 
            type_user.FormattingEnabled = true;
            type_user.Items.AddRange(new object[] { "Khách vãng lai", "Khách du lịch", "Khách địa phương", "Khách đi qua các tổ chức trung gian" });
            type_user.Location = new Point(39, 410);
            type_user.Name = "type_user";
            type_user.Size = new Size(349, 48);
            type_user.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(460, 492);
            label9.Name = "label9";
            label9.Size = new Size(153, 41);
            label9.TabIndex = 22;
            label9.Text = "Quốc tịch:";
            // 
            // country
            // 
            country.Font = new Font("Segoe UI", 11F);
            country.Location = new Point(460, 551);
            country.Name = "country";
            country.Size = new Size(358, 47);
            country.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(460, 347);
            label8.Name = "label8";
            label8.Size = new Size(200, 41);
            label8.TabIndex = 20;
            label8.Text = "Số điện thoại:";
            // 
            // phone
            // 
            phone.Font = new Font("Segoe UI", 11F);
            phone.Location = new Point(460, 406);
            phone.Name = "phone";
            phone.Size = new Size(358, 47);
            phone.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(460, 212);
            label7.Name = "label7";
            label7.Size = new Size(114, 41);
            label7.TabIndex = 18;
            label7.Text = "Địa chỉ:";
            // 
            // address
            // 
            address.Font = new Font("Segoe UI", 11F);
            address.Location = new Point(460, 271);
            address.Name = "address";
            address.Size = new Size(358, 47);
            address.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(460, 83);
            label6.Name = "label6";
            label6.Size = new Size(157, 41);
            label6.TabIndex = 16;
            label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(30, 492);
            label5.Name = "label5";
            label5.Size = new Size(137, 41);
            label5.TabIndex = 14;
            label5.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(30, 347);
            label3.Name = "label3";
            label3.Size = new Size(240, 41);
            label3.TabIndex = 12;
            label3.Text = "Loại khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(30, 212);
            label2.Name = "label2";
            label2.Size = new Size(301, 41);
            label2.TabIndex = 10;
            label2.Text = "Thẻ căn cước/CMND:";
            // 
            // cccd
            // 
            cccd.Font = new Font("Segoe UI", 11F);
            cccd.Location = new Point(30, 271);
            cccd.Name = "cccd";
            cccd.Size = new Size(358, 47);
            cccd.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(30, 83);
            label4.Name = "label4";
            label4.Size = new Size(160, 41);
            label4.TabIndex = 8;
            label4.Text = "Họ và tên: ";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 11F);
            name.Location = new Point(30, 142);
            name.Name = "name";
            name.Size = new Size(358, 47);
            name.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(btn_Exit);
            groupBox2.Controls.Add(cusButton1);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label14);
            groupBox2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(22, 840);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(884, 204);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = SystemColors.ButtonHighlight;
            btn_Exit.BackgroundColor = SystemColors.ButtonHighlight;
            btn_Exit.BorderColor = SystemColors.HotTrack;
            btn_Exit.BorderRadius = 35;
            btn_Exit.BorderSize = 1;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.ForeColor = SystemColors.HotTrack;
            btn_Exit.Location = new Point(467, 86);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(383, 80);
            btn_Exit.TabIndex = 29;
            btn_Exit.Text = "Đóng";
            btn_Exit.TextColor = SystemColors.HotTrack;
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
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
            cusButton1.Location = new Point(30, 86);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(383, 80);
            cusButton1.TabIndex = 28;
            cusButton1.Text = "Thêm khách hàng";
            cusButton1.TextColor = SystemColors.HotTrack;
            cusButton1.UseVisualStyleBackColor = false;
            cusButton1.Click += cusButton1_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Nam ", "Nữ" });
            comboBox3.Location = new Point(30, 536);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(349, 48);
            comboBox3.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(464, 478);
            label10.Name = "label10";
            label10.Size = new Size(153, 41);
            label10.TabIndex = 22;
            label10.Text = "Quốc tịch:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(464, 537);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(358, 47);
            textBox2.TabIndex = 21;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F);
            label14.Location = new Point(21, 478);
            label14.Name = "label14";
            label14.Size = new Size(137, 41);
            label14.TabIndex = 14;
            label14.Text = "Giới tính:";
            // 
            // txt_Exit
            // 
            txt_Exit.AutoSize = true;
            txt_Exit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Exit.ForeColor = Color.Red;
            txt_Exit.Location = new Point(880, 9);
            txt_Exit.Name = "txt_Exit";
            txt_Exit.Size = new Size(38, 41);
            txt_Exit.TabIndex = 27;
            txt_Exit.Text = "X";
            txt_Exit.Click += txt_Exit_Click;
            // 
            // add_user
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 1062);
            Controls.Add(txt_Exit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "add_user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_user";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dateTime;
        private ComboBox gender;
        private ComboBox type_user;
        private Label label9;
        private TextBox country;
        private Label label8;
        private TextBox phone;
        private Label label7;
        private TextBox address;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox cccd;
        private Label label4;
        private TextBox name;
        private GroupBox groupBox2;
        private ComboBox comboBox3;
        private Label label10;
        private TextBox textBox2;
        private Label label14;
        private HotelManage.Assets.CusButton btn_Exit;
        private HotelManage.Assets.CusButton cusButton1;
        private Label txt_Exit;
    }
}
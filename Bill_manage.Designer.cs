namespace HotelManagementSystem
{
    partial class Bill_manage
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
            groupBox2 = new GroupBox();
            timkiemmahoadon = new TextBox();
            timkiemhoadon = new HotelManage.Assets.CusButton();
            label9 = new Label();
            groupBox1 = new GroupBox();
            ngaytaohoadon = new DateTimePicker();
            tenkhachhang = new TextBox();
            label2 = new Label();
            mahoadon = new TextBox();
            trangthai = new TextBox();
            thanhtien = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label5 = new Label();
            tenphong = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            txt_printbill = new HotelManage.Assets.CusButton();
            cusButton3 = new HotelManage.Assets.CusButton();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            txt_Exit = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(12, 18);
            label6.Name = "label6";
            label6.Size = new Size(431, 71);
            label6.TabIndex = 27;
            label6.Text = "Quản lý hóa đơn";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(timkiemmahoadon);
            groupBox2.Controls.Add(timkiemhoadon);
            groupBox2.Controls.Add(label9);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(12, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(851, 260);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // timkiemmahoadon
            // 
            timkiemmahoadon.Location = new Point(328, 58);
            timkiemmahoadon.Name = "timkiemmahoadon";
            timkiemmahoadon.Size = new Size(344, 46);
            timkiemmahoadon.TabIndex = 40;
            // 
            // timkiemhoadon
            // 
            timkiemhoadon.BackColor = SystemColors.ButtonHighlight;
            timkiemhoadon.BackgroundColor = SystemColors.ButtonHighlight;
            timkiemhoadon.BorderColor = SystemColors.HotTrack;
            timkiemhoadon.BorderRadius = 35;
            timkiemhoadon.BorderSize = 1;
            timkiemhoadon.FlatAppearance.BorderSize = 0;
            timkiemhoadon.FlatStyle = FlatStyle.Flat;
            timkiemhoadon.ForeColor = SystemColors.HotTrack;
            timkiemhoadon.Location = new Point(215, 161);
            timkiemhoadon.Name = "timkiemhoadon";
            timkiemhoadon.Size = new Size(350, 62);
            timkiemhoadon.TabIndex = 39;
            timkiemhoadon.Text = "Tìm kiếm";
            timkiemhoadon.TextColor = SystemColors.HotTrack;
            timkiemhoadon.UseVisualStyleBackColor = false;
            timkiemhoadon.Click += timkiemhoadon_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(59, 63);
            label9.Name = "label9";
            label9.Size = new Size(192, 37);
            label9.TabIndex = 0;
            label9.Text = "Tìm kiếm theo:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(ngaytaohoadon);
            groupBox1.Controls.Add(tenkhachhang);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(mahoadon);
            groupBox1.Controls.Add(trangthai);
            groupBox1.Controls.Add(thanhtien);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tenphong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 384);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(851, 458);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // ngaytaohoadon
            // 
            ngaytaohoadon.CustomFormat = "hh:mm:ss dd/MM/yyyy";
            ngaytaohoadon.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaytaohoadon.Format = DateTimePickerFormat.Custom;
            ngaytaohoadon.Location = new Point(488, 109);
            ngaytaohoadon.Name = "ngaytaohoadon";
            ngaytaohoadon.Size = new Size(326, 43);
            ngaytaohoadon.TabIndex = 62;
            // 
            // tenkhachhang
            // 
            tenkhachhang.ForeColor = Color.Black;
            tenkhachhang.Location = new Point(25, 375);
            tenkhachhang.Name = "tenkhachhang";
            tenkhachhang.Size = new Size(338, 46);
            tenkhachhang.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 322);
            label2.Name = "label2";
            label2.Size = new Size(200, 37);
            label2.TabIndex = 60;
            label2.Text = "Tên khách hàng";
            // 
            // mahoadon
            // 
            mahoadon.ForeColor = Color.Black;
            mahoadon.Location = new Point(25, 109);
            mahoadon.Name = "mahoadon";
            mahoadon.Size = new Size(338, 46);
            mahoadon.TabIndex = 59;
            // 
            // trangthai
            // 
            trangthai.ForeColor = Color.Black;
            trangthai.Location = new Point(476, 231);
            trangthai.Name = "trangthai";
            trangthai.Size = new Size(338, 46);
            trangthai.TabIndex = 58;
          
            // 
            // thanhtien
            // 
            thanhtien.ForeColor = Color.Black;
            thanhtien.Location = new Point(476, 375);
            thanhtien.Name = "thanhtien";
            thanhtien.Size = new Size(338, 46);
            thanhtien.TabIndex = 57;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(476, 322);
            label10.Name = "label10";
            label10.Size = new Size(148, 37);
            label10.TabIndex = 56;
            label10.Text = "Thành tiền:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(476, 54);
            label8.Name = "label8";
            label8.Size = new Size(126, 37);
            label8.TabIndex = 52;
            label8.Text = "Ngày tạo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(476, 164);
            label5.Name = "label5";
            label5.Size = new Size(141, 37);
            label5.TabIndex = 46;
            label5.Text = "Trạng thái:";
            // 
            // tenphong
            // 
            tenphong.ForeColor = Color.Black;
            tenphong.Location = new Point(25, 231);
            tenphong.Name = "tenphong";
            tenphong.Size = new Size(338, 46);
            tenphong.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 178);
            label3.Name = "label3";
            label3.Size = new Size(148, 37);
            label3.TabIndex = 42;
            label3.Text = "Tên phòng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 54);
            label1.Name = "label1";
            label1.Size = new Size(167, 37);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ButtonHighlight;
            groupBox5.Controls.Add(txt_printbill);
            groupBox5.Controls.Add(cusButton3);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(12, 857);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(851, 189);
            groupBox5.TabIndex = 38;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // txt_printbill
            // 
            txt_printbill.BackColor = SystemColors.ButtonHighlight;
            txt_printbill.BackgroundColor = SystemColors.ButtonHighlight;
            txt_printbill.BorderColor = SystemColors.HotTrack;
            txt_printbill.BorderRadius = 35;
            txt_printbill.BorderSize = 1;
            txt_printbill.FlatAppearance.BorderSize = 0;
            txt_printbill.FlatStyle = FlatStyle.Flat;
            txt_printbill.ForeColor = SystemColors.HotTrack;
            txt_printbill.Location = new Point(25, 85);
            txt_printbill.Name = "txt_printbill";
            txt_printbill.Size = new Size(338, 63);
            txt_printbill.TabIndex = 33;
            txt_printbill.Text = "Chi tiết hóa đơn";
            txt_printbill.TextColor = SystemColors.HotTrack;
            txt_printbill.UseVisualStyleBackColor = false;
            txt_printbill.Click += txt_printbill_Click;
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
            cusButton3.Location = new Point(476, 85);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(338, 63);
            cusButton3.TabIndex = 31;
            cusButton3.Text = "Đóng";
            cusButton3.TextColor = SystemColors.HotTrack;
            cusButton3.UseVisualStyleBackColor = false;
            cusButton3.Click += cusButton3_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(880, 104);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1216, 942);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách hóa đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1184, 876);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txt_Exit
            // 
            txt_Exit.AutoSize = true;
            txt_Exit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Exit.ForeColor = Color.Red;
            txt_Exit.Location = new Point(2058, 9);
            txt_Exit.Name = "txt_Exit";
            txt_Exit.Size = new Size(38, 41);
            txt_Exit.TabIndex = 40;
            txt_Exit.Text = "X";
            txt_Exit.Click += txt_Exit_Click;
            // 
            // Bill_manage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2107, 1062);
            Controls.Add(txt_Exit);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bill_manage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill_manage";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private GroupBox groupBox2;
        private TextBox timkiemmahoadon;
        private HotelManage.Assets.CusButton timkiemhoadon;
        private Label label9;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private Label label5;
        private TextBox tenphong;
        private Label label3;
        private Label label1;
        private TextBox trangthai;
        private TextBox thanhtien;
        private Label label10;
        private GroupBox groupBox5;
        private HotelManage.Assets.CusButton txt_printbill;
        private HotelManage.Assets.CusButton cusButton3;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label txt_Exit;
        private TextBox mahoadon;
        private TextBox tenkhachhang;
        private Label label2;
        private DateTimePicker ngaytaohoadon;
    }
}
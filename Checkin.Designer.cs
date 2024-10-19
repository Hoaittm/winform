namespace HotelManagementSystem
{
    partial class Checkin
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
            txt_Exit = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            cusButton2 = new HotelManage.Assets.CusButton();
            madatphong = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            gia = new TextBox();
            label7 = new Label();
            ngaytra = new DateTimePicker();
            label5 = new Label();
            tenloaiphong = new TextBox();
            label4 = new Label();
            cancuoccongdan = new TextBox();
            label11 = new Label();
            ngaynhan = new DateTimePicker();
            label8 = new Label();
            hovaten = new TextBox();
            label9 = new Label();
            groupBox5 = new GroupBox();
            cusButton5 = new HotelManage.Assets.CusButton();
            cusButton1 = new HotelManage.Assets.CusButton();
            cusButton4 = new HotelManage.Assets.CusButton();
            cusButton3 = new HotelManage.Assets.CusButton();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            txt_checkindetail = new HotelManage.Assets.CusButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_Exit
            // 
            txt_Exit.AutoSize = true;
            txt_Exit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Exit.ForeColor = Color.Red;
            txt_Exit.Location = new Point(2289, 21);
            txt_Exit.Name = "txt_Exit";
            txt_Exit.Size = new Size(38, 41);
            txt_Exit.TabIndex = 19;
            txt_Exit.Text = "X";
            txt_Exit.Click += txt_Exit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(329, 71);
            label6.TabIndex = 20;
            label6.Text = "Nhận phòng\r\n";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(cusButton2);
            groupBox1.Controls.Add(madatphong);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 318);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
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
            cusButton2.Location = new Point(25, 189);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(373, 68);
            cusButton2.TabIndex = 30;
            cusButton2.Text = "Tìm kiếm";
            cusButton2.TextColor = SystemColors.HotTrack;
            cusButton2.UseVisualStyleBackColor = false;
            cusButton2.Click += cusButton2_Click;
            // 
            // madatphong
            // 
            madatphong.Location = new Point(28, 108);
            madatphong.Name = "madatphong";
            madatphong.Size = new Size(370, 46);
            madatphong.TabIndex = 3;
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
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label2);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(503, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(474, 318);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng trống";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "P01", "P02", "P03", "P04" });
            comboBox1.Location = new Point(29, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(369, 48);
            comboBox1.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 176);
            label3.Name = "label3";
            label3.Size = new Size(94, 37);
            label3.TabIndex = 32;
            label3.Text = "Phòng";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Phòng Deluxe (DLX)", "Phòng Suite (SUT)", "Phòng Superior (SUP)", "Phòng Standard (STD)" });
            comboBox3.Location = new Point(29, 108);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(369, 48);
            comboBox3.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 54);
            label2.Name = "label2";
            label2.Size = new Size(158, 37);
            label2.TabIndex = 0;
            label2.Text = "Loại phòng:";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(gia);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(ngaytra);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(tenloaiphong);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(cancuoccongdan);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(ngaynhan);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(hovaten);
            groupBox4.Controls.Add(label9);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.HotTrack;
            groupBox4.Location = new Point(12, 441);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(965, 489);
            groupBox4.TabIndex = 32;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nhận phòng";
            // 
            // gia
            // 
            gia.Location = new Point(529, 406);
            gia.Name = "gia";
            gia.Size = new Size(370, 50);
            gia.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(520, 349);
            label7.Name = "label7";
            label7.Size = new Size(63, 37);
            label7.TabIndex = 40;
            label7.Text = "Giá:\r\n";
            // 
            // ngaytra
            // 
            ngaytra.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaytra.Format = DateTimePickerFormat.Short;
            ngaytra.Location = new Point(521, 258);
            ngaytra.Name = "ngaytra";
            ngaytra.Size = new Size(374, 43);
            ngaytra.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(516, 207);
            label5.Name = "label5";
            label5.Size = new Size(125, 37);
            label5.TabIndex = 37;
            label5.Text = "Ngày trả:";
            // 
            // tenloaiphong
            // 
            tenloaiphong.Location = new Point(21, 409);
            tenloaiphong.Name = "tenloaiphong";
            tenloaiphong.Size = new Size(370, 50);
            tenloaiphong.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 349);
            label4.Name = "label4";
            label4.Size = new Size(199, 37);
            label4.TabIndex = 33;
            label4.Text = "Tên loại phòng:";
            // 
            // cancuoccongdan
            // 
            cancuoccongdan.Location = new Point(26, 258);
            cancuoccongdan.Name = "cancuoccongdan";
            cancuoccongdan.Size = new Size(370, 50);
            cancuoccongdan.TabIndex = 11;
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
            // ngaynhan
            // 
            ngaynhan.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaynhan.Format = DateTimePickerFormat.Short;
            ngaynhan.Location = new Point(521, 124);
            ngaynhan.Name = "ngaynhan";
            ngaynhan.Size = new Size(374, 43);
            ngaynhan.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(516, 72);
            label8.Name = "label8";
            label8.Size = new Size(152, 37);
            label8.TabIndex = 4;
            label8.Text = "Ngày nhận:";
            // 
            // hovaten
            // 
            hovaten.Location = new Point(26, 124);
            hovaten.Name = "hovaten";
            hovaten.Size = new Size(370, 50);
            hovaten.TabIndex = 3;
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
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ButtonHighlight;
            groupBox5.Controls.Add(cusButton5);
            groupBox5.Controls.Add(cusButton1);
            groupBox5.Controls.Add(cusButton4);
            groupBox5.Controls.Add(cusButton3);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(12, 943);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(965, 371);
            groupBox5.TabIndex = 33;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // cusButton5
            // 
            cusButton5.BackColor = SystemColors.ButtonHighlight;
            cusButton5.BackgroundColor = SystemColors.ButtonHighlight;
            cusButton5.BorderColor = SystemColors.HotTrack;
            cusButton5.BorderRadius = 35;
            cusButton5.BorderSize = 1;
            cusButton5.FlatAppearance.BorderSize = 0;
            cusButton5.FlatStyle = FlatStyle.Flat;
            cusButton5.ForeColor = SystemColors.HotTrack;
            cusButton5.Location = new Point(482, 85);
            cusButton5.Name = "cusButton5";
            cusButton5.Size = new Size(443, 87);
            cusButton5.TabIndex = 34;
            cusButton5.Text = "Nhận phòng";
            cusButton5.TextColor = SystemColors.HotTrack;
            cusButton5.UseVisualStyleBackColor = false;
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
            cusButton1.Location = new Point(6, 85);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(443, 87);
            cusButton1.TabIndex = 33;
            cusButton1.Text = "Thêm khách hàng";
            cusButton1.TextColor = SystemColors.HotTrack;
            cusButton1.UseVisualStyleBackColor = false;
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
            cusButton4.Location = new Point(6, 226);
            cusButton4.Name = "cusButton4";
            cusButton4.Size = new Size(443, 87);
            cusButton4.TabIndex = 32;
            cusButton4.Text = "Đóng";
            cusButton4.TextColor = SystemColors.HotTrack;
            cusButton4.UseVisualStyleBackColor = false;
            cusButton4.Click += cusButton4_Click;
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
            cusButton3.Location = new Point(482, 226);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(443, 87);
            cusButton3.TabIndex = 31;
            cusButton3.Text = "Hủy";
            cusButton3.TextColor = SystemColors.HotTrack;
            cusButton3.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(txt_checkindetail);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(1016, 101);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1311, 1213);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách đặt phòng trong ngày";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(23, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1282, 604);
            dataGridView1.TabIndex = 34;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txt_checkindetail
            // 
            txt_checkindetail.BackColor = SystemColors.ButtonHighlight;
            txt_checkindetail.BackgroundColor = SystemColors.ButtonHighlight;
            txt_checkindetail.BorderColor = SystemColors.HotTrack;
            txt_checkindetail.BorderRadius = 35;
            txt_checkindetail.BorderSize = 1;
            txt_checkindetail.FlatAppearance.BorderSize = 0;
            txt_checkindetail.FlatStyle = FlatStyle.Flat;
            txt_checkindetail.ForeColor = SystemColors.HotTrack;
            txt_checkindetail.Location = new Point(766, 1068);
            txt_checkindetail.Name = "txt_checkindetail";
            txt_checkindetail.Size = new Size(443, 87);
            txt_checkindetail.TabIndex = 33;
            txt_checkindetail.Text = "Xem chi tiết";
            txt_checkindetail.TextColor = SystemColors.HotTrack;
            txt_checkindetail.UseVisualStyleBackColor = false;
            txt_checkindetail.Click += txt_checkindetail_Click;
            // 
            // Checkin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2339, 1340);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(txt_Exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Checkin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txt_Exit;
        private Label label6;
        private GroupBox groupBox1;
        private HotelManage.Assets.CusButton cusButton2;
        private TextBox madatphong;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox3;
        private GroupBox groupBox4;
        private TextBox gia;
        private Label label7;
        private DateTimePicker ngaytra;
        private Label label5;
        private TextBox tenloaiphong;
        private Label label4;
        private TextBox cancuoccongdan;
        private Label label11;
        private DateTimePicker ngaynhan;
        private Label label8;
        private TextBox hovaten;
        private Label label9;
        private GroupBox groupBox5;
        private HotelManage.Assets.CusButton cusButton4;
        private HotelManage.Assets.CusButton cusButton3;
        private HotelManage.Assets.CusButton cusButton5;
        private HotelManage.Assets.CusButton cusButton1;
        private GroupBox groupBox3;
        private HotelManage.Assets.CusButton txt_checkindetail;
        private DataGridView dataGridView1;
    }
}
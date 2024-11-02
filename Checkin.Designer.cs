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
            timkiemnhanphong = new HotelManage.Assets.CusButton();
            madatphong = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            phong = new ComboBox();
            label3 = new Label();
            loaiphonglucnhanphong = new ComboBox();
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
            btn_dongnhanphong = new HotelManage.Assets.CusButton();
            btn_nhanphong = new HotelManage.Assets.CusButton();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            btn_xemchitietnhanphong = new HotelManage.Assets.CusButton();
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
            groupBox1.Controls.Add(timkiemnhanphong);
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
            // timkiemnhanphong
            // 
            timkiemnhanphong.BackColor = SystemColors.ButtonHighlight;
            timkiemnhanphong.BackgroundColor = SystemColors.ButtonHighlight;
            timkiemnhanphong.BorderColor = SystemColors.HotTrack;
            timkiemnhanphong.BorderRadius = 35;
            timkiemnhanphong.BorderSize = 1;
            timkiemnhanphong.FlatAppearance.BorderSize = 0;
            timkiemnhanphong.FlatStyle = FlatStyle.Flat;
            timkiemnhanphong.ForeColor = SystemColors.HotTrack;
            timkiemnhanphong.Location = new Point(25, 189);
            timkiemnhanphong.Name = "timkiemnhanphong";
            timkiemnhanphong.Size = new Size(373, 68);
            timkiemnhanphong.TabIndex = 30;
            timkiemnhanphong.Text = "Tìm kiếm";
            timkiemnhanphong.TextColor = SystemColors.HotTrack;
            timkiemnhanphong.UseVisualStyleBackColor = false;
            timkiemnhanphong.Click += timkiemnhanphong_Click;
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
            groupBox2.Controls.Add(phong);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(loaiphonglucnhanphong);
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
            groupBox2.Enter += groupBox2_Enter;
            // 
            // phong
            // 
            phong.FormattingEnabled = true;
            phong.Location = new Point(29, 230);
            phong.Name = "phong";
            phong.Size = new Size(369, 48);
            phong.TabIndex = 33;
            phong.SelectedIndexChanged += phong_SelectedIndexChanged;
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
            // loaiphonglucnhanphong
            // 
            loaiphonglucnhanphong.FormattingEnabled = true;
            loaiphonglucnhanphong.Items.AddRange(new object[] { "Phòng Suite (SUT)", "Phòng Deluxe (DLX)", "Phòng Superior (SUP)", "Phòng Standard (STD)" });
            loaiphonglucnhanphong.Location = new Point(29, 108);
            loaiphonglucnhanphong.Name = "loaiphonglucnhanphong";
            loaiphonglucnhanphong.Size = new Size(369, 48);
            loaiphonglucnhanphong.TabIndex = 31;
            loaiphonglucnhanphong.SelectedIndexChanged += loaiphonglucnhanphong_SelectedIndexChanged;
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
            ngaytra.CustomFormat = "hh:mm:ss dd/MM/yyyy";
            ngaytra.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaytra.Format = DateTimePickerFormat.Custom;
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
            ngaynhan.CustomFormat = "hh:mm:ss dd/MM/yyyy";
            ngaynhan.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaynhan.Format = DateTimePickerFormat.Custom;
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
            groupBox5.Controls.Add(btn_dongnhanphong);
            groupBox5.Controls.Add(btn_nhanphong);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(12, 943);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(965, 240);
            groupBox5.TabIndex = 33;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // btn_dongnhanphong
            // 
            btn_dongnhanphong.BackColor = SystemColors.ButtonHighlight;
            btn_dongnhanphong.BackgroundColor = SystemColors.ButtonHighlight;
            btn_dongnhanphong.BorderColor = SystemColors.HotTrack;
            btn_dongnhanphong.BorderRadius = 35;
            btn_dongnhanphong.BorderSize = 1;
            btn_dongnhanphong.FlatAppearance.BorderSize = 0;
            btn_dongnhanphong.FlatStyle = FlatStyle.Flat;
            btn_dongnhanphong.ForeColor = SystemColors.HotTrack;
            btn_dongnhanphong.Location = new Point(520, 99);
            btn_dongnhanphong.Name = "btn_dongnhanphong";
            btn_dongnhanphong.Size = new Size(376, 87);
            btn_dongnhanphong.TabIndex = 35;
            btn_dongnhanphong.Text = "Đóng";
            btn_dongnhanphong.TextColor = SystemColors.HotTrack;
            btn_dongnhanphong.UseVisualStyleBackColor = false;
            btn_dongnhanphong.Click += btn_dongnhanphong_Click;
            // 
            // btn_nhanphong
            // 
            btn_nhanphong.BackColor = SystemColors.ButtonHighlight;
            btn_nhanphong.BackgroundColor = SystemColors.ButtonHighlight;
            btn_nhanphong.BorderColor = SystemColors.HotTrack;
            btn_nhanphong.BorderRadius = 35;
            btn_nhanphong.BorderSize = 1;
            btn_nhanphong.FlatAppearance.BorderSize = 0;
            btn_nhanphong.FlatStyle = FlatStyle.Flat;
            btn_nhanphong.ForeColor = SystemColors.HotTrack;
            btn_nhanphong.Location = new Point(22, 99);
            btn_nhanphong.Name = "btn_nhanphong";
            btn_nhanphong.Size = new Size(376, 87);
            btn_nhanphong.TabIndex = 34;
            btn_nhanphong.Text = "Nhận phòng";
            btn_nhanphong.TextColor = SystemColors.HotTrack;
            btn_nhanphong.UseVisualStyleBackColor = false;
            btn_nhanphong.Click += btn_nhanphong_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(btn_xemchitietnhanphong);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(1016, 101);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1311, 1082);
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
            // btn_xemchitietnhanphong
            // 
            btn_xemchitietnhanphong.BackColor = SystemColors.ButtonHighlight;
            btn_xemchitietnhanphong.BackgroundColor = SystemColors.ButtonHighlight;
            btn_xemchitietnhanphong.BorderColor = SystemColors.HotTrack;
            btn_xemchitietnhanphong.BorderRadius = 35;
            btn_xemchitietnhanphong.BorderSize = 1;
            btn_xemchitietnhanphong.FlatAppearance.BorderSize = 0;
            btn_xemchitietnhanphong.FlatStyle = FlatStyle.Flat;
            btn_xemchitietnhanphong.ForeColor = SystemColors.HotTrack;
            btn_xemchitietnhanphong.Location = new Point(800, 924);
            btn_xemchitietnhanphong.Name = "btn_xemchitietnhanphong";
            btn_xemchitietnhanphong.Size = new Size(443, 87);
            btn_xemchitietnhanphong.TabIndex = 33;
            btn_xemchitietnhanphong.Text = "Xem chi tiết";
            btn_xemchitietnhanphong.TextColor = SystemColors.HotTrack;
            btn_xemchitietnhanphong.UseVisualStyleBackColor = false;
            btn_xemchitietnhanphong.Click += btn_xemchitietnhanphong_Click;
            // 
            // Checkin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2339, 1201);
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
        private HotelManage.Assets.CusButton timkiemnhanphong;
        private TextBox madatphong;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private ComboBox phong;
        private Label label3;
        private ComboBox loaiphonglucnhanphong;
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
        private HotelManage.Assets.CusButton btn_xemchitietnhanphong;
        private DataGridView dataGridView1;
        private HotelManage.Assets.CusButton btn_dongnhanphong;
        private HotelManage.Assets.CusButton btn_nhanphong;
    }
}
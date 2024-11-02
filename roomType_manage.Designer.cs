namespace HotelManagementSystem
{
    partial class roomType_manage
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
            tenphongtimkiem = new TextBox();
            timkiemloaiphong = new HotelManage.Assets.CusButton();
            label9 = new Label();
            groupBox1 = new GroupBox();
            songuoitoida = new TextBox();
            label7 = new Label();
            giaphong = new TextBox();
            label5 = new Label();
            tenloaiphong = new TextBox();
            label3 = new Label();
            maloaiphong = new ComboBox();
            label1 = new Label();
            groupBox5 = new GroupBox();
            capnhatphong = new HotelManage.Assets.CusButton();
            cusButton3 = new HotelManage.Assets.CusButton();
            groupBox3 = new GroupBox();
            button1 = new Button();
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
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(489, 71);
            label6.TabIndex = 26;
            label6.Text = "Quản lý loại phòng";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(tenphongtimkiem);
            groupBox2.Controls.Add(timkiemloaiphong);
            groupBox2.Controls.Add(label9);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(12, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 320);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // tenphongtimkiem
            // 
            tenphongtimkiem.Location = new Point(25, 107);
            tenphongtimkiem.Name = "tenphongtimkiem";
            tenphongtimkiem.Size = new Size(406, 46);
            tenphongtimkiem.TabIndex = 40;
            // 
            // timkiemloaiphong
            // 
            timkiemloaiphong.BackColor = SystemColors.ButtonHighlight;
            timkiemloaiphong.BackgroundColor = SystemColors.ButtonHighlight;
            timkiemloaiphong.BorderColor = SystemColors.HotTrack;
            timkiemloaiphong.BorderRadius = 35;
            timkiemloaiphong.BorderSize = 1;
            timkiemloaiphong.FlatAppearance.BorderSize = 0;
            timkiemloaiphong.FlatStyle = FlatStyle.Flat;
            timkiemloaiphong.ForeColor = SystemColors.HotTrack;
            timkiemloaiphong.Location = new Point(25, 183);
            timkiemloaiphong.Name = "timkiemloaiphong";
            timkiemloaiphong.Size = new Size(411, 74);
            timkiemloaiphong.TabIndex = 39;
            timkiemloaiphong.Text = "Tìm kiếm";
            timkiemloaiphong.TextColor = SystemColors.HotTrack;
            timkiemloaiphong.UseVisualStyleBackColor = false;
            timkiemloaiphong.Click += timkiemloaiphong_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 54);
            label9.Name = "label9";
            label9.Size = new Size(61, 37);
            label9.TabIndex = 0;
            label9.Text = "Mã:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(songuoitoida);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(giaphong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tenloaiphong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(maloaiphong);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 431);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 563);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng";
            // 
            // songuoitoida
            // 
            songuoitoida.Location = new Point(25, 359);
            songuoitoida.Name = "songuoitoida";
            songuoitoida.Size = new Size(406, 46);
            songuoitoida.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 306);
            label7.Name = "label7";
            label7.Size = new Size(206, 37);
            label7.TabIndex = 48;
            label7.Text = "Số người tối đa:";
            // 
            // giaphong
            // 
            giaphong.Location = new Point(25, 487);
            giaphong.Name = "giaphong";
            giaphong.Size = new Size(406, 46);
            giaphong.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 434);
            label5.Name = "label5";
            label5.Size = new Size(148, 37);
            label5.TabIndex = 46;
            label5.Text = "Giá phòng:";
            // 
            // tenloaiphong
            // 
            tenloaiphong.Location = new Point(25, 231);
            tenloaiphong.Name = "tenloaiphong";
            tenloaiphong.Size = new Size(406, 46);
            tenloaiphong.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 178);
            label3.Name = "label3";
            label3.Size = new Size(199, 37);
            label3.TabIndex = 42;
            label3.Text = "Tên loại phòng:";
            // 
            // maloaiphong
            // 
            maloaiphong.FormattingEnabled = true;
            maloaiphong.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            maloaiphong.Location = new Point(25, 107);
            maloaiphong.Name = "maloaiphong";
            maloaiphong.Size = new Size(406, 48);
            maloaiphong.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 54);
            label1.Name = "label1";
            label1.Size = new Size(146, 37);
            label1.TabIndex = 0;
            label1.Text = "Mã phòng:";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ButtonHighlight;
            groupBox5.Controls.Add(capnhatphong);
            groupBox5.Controls.Add(cusButton3);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(12, 1011);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(480, 340);
            groupBox5.TabIndex = 37;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // capnhatphong
            // 
            capnhatphong.BackColor = SystemColors.ButtonHighlight;
            capnhatphong.BackgroundColor = SystemColors.ButtonHighlight;
            capnhatphong.BorderColor = SystemColors.HotTrack;
            capnhatphong.BorderRadius = 35;
            capnhatphong.BorderSize = 1;
            capnhatphong.FlatAppearance.BorderSize = 0;
            capnhatphong.FlatStyle = FlatStyle.Flat;
            capnhatphong.ForeColor = SystemColors.HotTrack;
            capnhatphong.Location = new Point(15, 70);
            capnhatphong.Name = "capnhatphong";
            capnhatphong.Size = new Size(443, 87);
            capnhatphong.TabIndex = 32;
            capnhatphong.Text = "Cập nhật phòng";
            capnhatphong.TextColor = SystemColors.HotTrack;
            capnhatphong.UseVisualStyleBackColor = false;
            capnhatphong.Click += capnhatphong_Click;
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
            cusButton3.Location = new Point(15, 210);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(443, 87);
            cusButton3.TabIndex = 31;
            cusButton3.Text = "Đóng";
            cusButton3.TextColor = SystemColors.HotTrack;
            cusButton3.UseVisualStyleBackColor = false;
            cusButton3.Click += cusButton3_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(518, 90);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1424, 1261);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách loại phòng";
            // 
            // button1
            // 
            button1.Location = new Point(1245, 25);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "Xuất";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1386, 953);
            dataGridView1.TabIndex = 0;
            // 
            // txt_Exit
            // 
            txt_Exit.AutoSize = true;
            txt_Exit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Exit.ForeColor = Color.Red;
            txt_Exit.Location = new Point(1904, 9);
            txt_Exit.Name = "txt_Exit";
            txt_Exit.Size = new Size(38, 41);
            txt_Exit.TabIndex = 39;
            txt_Exit.Text = "X";
            txt_Exit.Click += txt_Exit_Click;
            // 
            // roomType_manage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1953, 1374);
            Controls.Add(txt_Exit);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "roomType_manage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "roomType_manage";
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
        private TextBox tenphongtimkiem;
        private HotelManage.Assets.CusButton timkiemloaiphong;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox songuoitoida;
        private Label label7;
        private TextBox giaphong;
        private Label label5;
        private TextBox tenloaiphong;
        private Label label3;
        private ComboBox maloaiphong;
        private Label label1;
        private GroupBox groupBox5;
        private HotelManage.Assets.CusButton capnhatphong;
        private HotelManage.Assets.CusButton cusButton3;
        private GroupBox groupBox3;
        private Button button1;
        private DataGridView dataGridView1;
        private Label txt_Exit;
    }
}
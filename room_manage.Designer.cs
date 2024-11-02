namespace HotelManagementSystem
{
    partial class room_manage
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
            maphongtimkiem = new TextBox();
            timkiemphong = new HotelManage.Assets.CusButton();
            label9 = new Label();
            groupBox1 = new GroupBox();
            trangthaicuaphong = new ComboBox();
            tenphongcuaphong = new ComboBox();
            songuoitoida = new TextBox();
            label7 = new Label();
            giaphong = new TextBox();
            label5 = new Label();
            loaiphong = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            maphong = new ComboBox();
            label1 = new Label();
            groupBox5 = new GroupBox();
            themphongmoi = new HotelManage.Assets.CusButton();
            txt_editroom = new HotelManage.Assets.CusButton();
            capnhatphong = new HotelManage.Assets.CusButton();
            cusButton3 = new HotelManage.Assets.CusButton();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            label15 = new Label();
            menuStrip1 = new MenuStrip();
            xuấtFileToolStripMenuItem = new ToolStripMenuItem();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(385, 71);
            label6.TabIndex = 25;
            label6.Text = "Quản lý phòng";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(maphongtimkiem);
            groupBox2.Controls.Add(timkiemphong);
            groupBox2.Controls.Add(label9);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(12, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(954, 213);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // maphongtimkiem
            // 
            maphongtimkiem.Location = new Point(25, 107);
            maphongtimkiem.Name = "maphongtimkiem";
            maphongtimkiem.Size = new Size(406, 46);
            maphongtimkiem.TabIndex = 40;
            // 
            // timkiemphong
            // 
            timkiemphong.BackColor = SystemColors.ButtonHighlight;
            timkiemphong.BackgroundColor = SystemColors.ButtonHighlight;
            timkiemphong.BorderColor = SystemColors.HotTrack;
            timkiemphong.BorderRadius = 35;
            timkiemphong.BorderSize = 1;
            timkiemphong.FlatAppearance.BorderSize = 0;
            timkiemphong.FlatStyle = FlatStyle.Flat;
            timkiemphong.ForeColor = SystemColors.HotTrack;
            timkiemphong.Location = new Point(507, 93);
            timkiemphong.Name = "timkiemphong";
            timkiemphong.Size = new Size(411, 74);
            timkiemphong.TabIndex = 39;
            timkiemphong.Text = "Tìm kiếm";
            timkiemphong.TextColor = SystemColors.HotTrack;
            timkiemphong.UseVisualStyleBackColor = false;
            timkiemphong.Click += timkiemphong_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 54);
            label9.Name = "label9";
            label9.Size = new Size(204, 37);
            label9.TabIndex = 0;
            label9.Text = "Mã/ Tên phòng:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(trangthaicuaphong);
            groupBox1.Controls.Add(tenphongcuaphong);
            groupBox1.Controls.Add(songuoitoida);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(giaphong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(loaiphong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maphong);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 332);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(954, 441);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng";
            // 
            // trangthaicuaphong
            // 
            trangthaicuaphong.FormattingEnabled = true;
            trangthaicuaphong.Items.AddRange(new object[] { "Trống", "Có người" });
            trangthaicuaphong.Location = new Point(25, 356);
            trangthaicuaphong.Name = "trangthaicuaphong";
            trangthaicuaphong.Size = new Size(406, 48);
            trangthaicuaphong.TabIndex = 51;
            // 
            // tenphongcuaphong
            // 
            tenphongcuaphong.FormattingEnabled = true;
            tenphongcuaphong.Items.AddRange(new object[] { "Phòng 1", "Phòng 2", "Phòng 3", "Phòng 5", "Phòng 6", "Phòng 7", "Phòng 8", "Phòng 9", "Phòng 10", "Phòng 11", "Phòng 12", "Phòng 13", "Phòng 14", "Phòng 15", "Phòng 16" });
            tenphongcuaphong.Location = new Point(25, 229);
            tenphongcuaphong.Name = "tenphongcuaphong";
            tenphongcuaphong.Size = new Size(406, 48);
            tenphongcuaphong.TabIndex = 50;
            // 
            // songuoitoida
            // 
            songuoitoida.Location = new Point(505, 356);
            songuoitoida.Name = "songuoitoida";
            songuoitoida.Size = new Size(406, 46);
            songuoitoida.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(505, 303);
            label7.Name = "label7";
            label7.Size = new Size(206, 37);
            label7.TabIndex = 48;
            label7.Text = "Số người tối đa:";
            // 
            // giaphong
            // 
            giaphong.Location = new Point(507, 231);
            giaphong.Name = "giaphong";
            giaphong.Size = new Size(406, 46);
            giaphong.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(507, 178);
            label5.Name = "label5";
            label5.Size = new Size(148, 37);
            label5.TabIndex = 46;
            label5.Text = "Giá phòng:";
            // 
            // loaiphong
            // 
            loaiphong.FormattingEnabled = true;
            loaiphong.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            loaiphong.Location = new Point(507, 107);
            loaiphong.Name = "loaiphong";
            loaiphong.Size = new Size(406, 48);
            loaiphong.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(507, 54);
            label4.Name = "label4";
            label4.Size = new Size(158, 37);
            label4.TabIndex = 44;
            label4.Text = "Loại phòng:";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 303);
            label2.Name = "label2";
            label2.Size = new Size(141, 37);
            label2.TabIndex = 40;
            label2.Text = "Trạng thái:";
            // 
            // maphong
            // 
            maphong.FormattingEnabled = true;
            maphong.Items.AddRange(new object[] { "1", "2", "3", "4" });
            maphong.Location = new Point(25, 107);
            maphong.Name = "maphong";
            maphong.Size = new Size(406, 48);
            maphong.TabIndex = 33;
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
            groupBox5.Controls.Add(themphongmoi);
            groupBox5.Controls.Add(txt_editroom);
            groupBox5.Controls.Add(capnhatphong);
            groupBox5.Controls.Add(cusButton3);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(12, 789);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(954, 371);
            groupBox5.TabIndex = 36;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // themphongmoi
            // 
            themphongmoi.BackColor = SystemColors.ButtonHighlight;
            themphongmoi.BackgroundColor = SystemColors.ButtonHighlight;
            themphongmoi.BorderColor = SystemColors.HotTrack;
            themphongmoi.BorderRadius = 35;
            themphongmoi.BorderSize = 1;
            themphongmoi.FlatAppearance.BorderSize = 0;
            themphongmoi.FlatStyle = FlatStyle.Flat;
            themphongmoi.ForeColor = SystemColors.HotTrack;
            themphongmoi.Location = new Point(6, 85);
            themphongmoi.Name = "themphongmoi";
            themphongmoi.Size = new Size(443, 87);
            themphongmoi.TabIndex = 35;
            themphongmoi.Text = "Thêm";
            themphongmoi.TextColor = SystemColors.HotTrack;
            themphongmoi.UseVisualStyleBackColor = false;
            themphongmoi.Click += themphongmoi_Click;
            // 
            // txt_editroom
            // 
            txt_editroom.BackColor = SystemColors.ButtonHighlight;
            txt_editroom.BackgroundColor = SystemColors.ButtonHighlight;
            txt_editroom.BorderColor = SystemColors.HotTrack;
            txt_editroom.BorderRadius = 35;
            txt_editroom.BorderSize = 1;
            txt_editroom.FlatAppearance.BorderSize = 0;
            txt_editroom.FlatStyle = FlatStyle.Flat;
            txt_editroom.ForeColor = SystemColors.HotTrack;
            txt_editroom.Location = new Point(482, 85);
            txt_editroom.Name = "txt_editroom";
            txt_editroom.Size = new Size(443, 87);
            txt_editroom.TabIndex = 34;
            txt_editroom.Text = "Sửa lại phòng";
            txt_editroom.TextColor = SystemColors.HotTrack;
            txt_editroom.UseVisualStyleBackColor = false;
            txt_editroom.Click += txt_editroom_Click;
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
            capnhatphong.Location = new Point(6, 226);
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
            cusButton3.Location = new Point(482, 226);
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
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(menuStrip1);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(1000, 94);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1115, 1066);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách phòng";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1074, 953);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(2077, 9);
            label15.Name = "label15";
            label15.Size = new Size(38, 41);
            label15.TabIndex = 38;
            label15.Text = "X";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { xuấtFileToolStripMenuItem });
            menuStrip1.Location = new Point(3, 42);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1109, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // xuấtFileToolStripMenuItem
            // 
            xuấtFileToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            xuấtFileToolStripMenuItem.Name = "xuấtFileToolStripMenuItem";
            xuấtFileToolStripMenuItem.Size = new Size(122, 38);
            xuấtFileToolStripMenuItem.Text = "Xuất file";
            xuấtFileToolStripMenuItem.Click += xuấtFileToolStripMenuItem_Click;
            // 
            // room_manage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2124, 1169);
            Controls.Add(label15);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "room_manage";
            Text = "room_manage";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private GroupBox groupBox2;
        private HotelManage.Assets.CusButton timkiemphong;
        private Label label9;
        private GroupBox groupBox1;
        private ComboBox maphong;
        private Label label1;
        private TextBox maphongtimkiem;
        private TextBox tenphong;
        private Label label3;
        private ComboBox comboBox3;
        private Label label2;
        private TextBox songuoitoida;
        private Label label7;
        private TextBox giaphong;
        private Label label5;
        private ComboBox loaiphong;
        private Label label4;
        private GroupBox groupBox5;
        private HotelManage.Assets.CusButton txt_editroom;
        private HotelManage.Assets.CusButton txt_addroom;
        private HotelManage.Assets.CusButton capnhatphong;
        private HotelManage.Assets.CusButton cusButton3;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label15;
        private ComboBox trangthaicuaphong;
        private ComboBox tenphongcuaphong;
        private HotelManage.Assets.CusButton themphongmoi;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem xuấtFileToolStripMenuItem;
    }
}
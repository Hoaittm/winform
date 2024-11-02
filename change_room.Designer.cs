namespace HotelManagementSystem
{
    partial class change_room
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
            phongtrongdoiphong = new ComboBox();
            label2 = new Label();
            loaiphongtrongdoiphong = new ComboBox();
            label1 = new Label();
            groupBox5 = new GroupBox();
            dongdoiphong = new HotelManage.Assets.CusButton();
            luudoiphong = new HotelManage.Assets.CusButton();
            groupBox2 = new GroupBox();
            giatrongdoiphong = new TextBox();
            label3 = new Label();
            soluongnguoitoida = new TextBox();
            label4 = new Label();
            tenloaiphongtrongdoiphong = new TextBox();
            label5 = new Label();
            tenphongtrongdoiphong = new TextBox();
            label7 = new Label();
            txt_Exit = new Label();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(279, 71);
            label6.TabIndex = 22;
            label6.Text = "Đổi phòng\r\n";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(phongtrongdoiphong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(loaiphongtrongdoiphong);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 306);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phòng trống";
            // 
            // phongtrongdoiphong
            // 
            phongtrongdoiphong.FormattingEnabled = true;
            phongtrongdoiphong.Location = new Point(25, 218);
            phongtrongdoiphong.Name = "phongtrongdoiphong";
            phongtrongdoiphong.Size = new Size(471, 53);
            phongtrongdoiphong.TabIndex = 3;
            phongtrongdoiphong.SelectedIndexChanged += phongtrongdoiphong_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 178);
            label2.Name = "label2";
            label2.Size = new Size(100, 37);
            label2.TabIndex = 2;
            label2.Text = "Phòng:";
            // 
            // loaiphongtrongdoiphong
            // 
            loaiphongtrongdoiphong.FormattingEnabled = true;
            loaiphongtrongdoiphong.Items.AddRange(new object[] { "Phòng Suite (SUT)", "Phòng Deluxe (DLX)", "Phòng Superior (SUP)", "Phòng Standard (STD)" });
            loaiphongtrongdoiphong.Location = new Point(25, 94);
            loaiphongtrongdoiphong.Name = "loaiphongtrongdoiphong";
            loaiphongtrongdoiphong.Size = new Size(471, 53);
            loaiphongtrongdoiphong.TabIndex = 1;
            loaiphongtrongdoiphong.SelectedIndexChanged += loaiphongtrongdoiphong_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 54);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 0;
            label1.Text = "Loại phòng:";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ButtonHighlight;
            groupBox5.Controls.Add(dongdoiphong);
            groupBox5.Controls.Add(luudoiphong);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(12, 421);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(537, 330);
            groupBox5.TabIndex = 35;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // dongdoiphong
            // 
            dongdoiphong.BackColor = SystemColors.ButtonHighlight;
            dongdoiphong.BackgroundColor = SystemColors.ButtonHighlight;
            dongdoiphong.BorderColor = SystemColors.HotTrack;
            dongdoiphong.BorderRadius = 35;
            dongdoiphong.BorderSize = 1;
            dongdoiphong.FlatAppearance.BorderSize = 0;
            dongdoiphong.FlatStyle = FlatStyle.Flat;
            dongdoiphong.ForeColor = SystemColors.HotTrack;
            dongdoiphong.Location = new Point(28, 203);
            dongdoiphong.Name = "dongdoiphong";
            dongdoiphong.Size = new Size(468, 78);
            dongdoiphong.TabIndex = 34;
            dongdoiphong.Text = "Đóng";
            dongdoiphong.TextColor = SystemColors.HotTrack;
            dongdoiphong.UseVisualStyleBackColor = false;
            dongdoiphong.Click += dongdoiphong_Click;
            // 
            // luudoiphong
            // 
            luudoiphong.BackColor = SystemColors.ButtonHighlight;
            luudoiphong.BackgroundColor = SystemColors.ButtonHighlight;
            luudoiphong.BorderColor = SystemColors.HotTrack;
            luudoiphong.BorderRadius = 35;
            luudoiphong.BorderSize = 1;
            luudoiphong.FlatAppearance.BorderSize = 0;
            luudoiphong.FlatStyle = FlatStyle.Flat;
            luudoiphong.ForeColor = SystemColors.HotTrack;
            luudoiphong.Location = new Point(28, 85);
            luudoiphong.Name = "luudoiphong";
            luudoiphong.Size = new Size(468, 78);
            luudoiphong.TabIndex = 33;
            luudoiphong.Text = "Lưu thay đổi";
            luudoiphong.TextColor = SystemColors.HotTrack;
            luudoiphong.UseVisualStyleBackColor = false;
            luudoiphong.Click += luudoiphong_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(giatrongdoiphong);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(soluongnguoitoida);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tenloaiphongtrongdoiphong);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tenphongtrongdoiphong);
            groupBox2.Controls.Add(label7);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(582, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(570, 656);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin nhận phòng";
            // 
            // giatrongdoiphong
            // 
            giatrongdoiphong.Location = new Point(27, 504);
            giatrongdoiphong.Name = "giatrongdoiphong";
            giatrongdoiphong.Size = new Size(468, 50);
            giatrongdoiphong.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 461);
            label3.Name = "label3";
            label3.Size = new Size(63, 37);
            label3.TabIndex = 12;
            label3.Text = "Giá:";
            // 
            // soluongnguoitoida
            // 
            soluongnguoitoida.Location = new Point(30, 377);
            soluongnguoitoida.Name = "soluongnguoitoida";
            soluongnguoitoida.Size = new Size(468, 50);
            soluongnguoitoida.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 323);
            label4.Name = "label4";
            label4.Size = new Size(283, 37);
            label4.TabIndex = 10;
            label4.Text = "Số lượng người tối đa:";
            // 
            // tenloaiphongtrongdoiphong
            // 
            tenloaiphongtrongdoiphong.Location = new Point(30, 243);
            tenloaiphongtrongdoiphong.Name = "tenloaiphongtrongdoiphong";
            tenloaiphongtrongdoiphong.Size = new Size(468, 50);
            tenloaiphongtrongdoiphong.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 200);
            label5.Name = "label5";
            label5.Size = new Size(199, 37);
            label5.TabIndex = 8;
            label5.Text = "Tên loại phòng:";
            // 
            // tenphongtrongdoiphong
            // 
            tenphongtrongdoiphong.Location = new Point(27, 117);
            tenphongtrongdoiphong.Name = "tenphongtrongdoiphong";
            tenphongtrongdoiphong.Size = new Size(468, 50);
            tenphongtrongdoiphong.TabIndex = 3;
            tenphongtrongdoiphong.TextChanged += tenphongtrongdoiphong_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 63);
            label7.Name = "label7";
            label7.Size = new Size(148, 37);
            label7.TabIndex = 0;
            label7.Text = "Tên phòng:";
            // 
            // txt_Exit
            // 
            txt_Exit.AutoSize = true;
            txt_Exit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Exit.ForeColor = Color.Red;
            txt_Exit.Location = new Point(1129, 9);
            txt_Exit.Name = "txt_Exit";
            txt_Exit.Size = new Size(38, 41);
            txt_Exit.TabIndex = 37;
            txt_Exit.Text = "X";
            txt_Exit.Click += txt_Exit_Click;
            // 
            // change_room
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 782);
            Controls.Add(txt_Exit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "change_room";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "change_room";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private GroupBox groupBox1;
        private ComboBox phongtrongdoiphong;
        private Label label2;
        private ComboBox loaiphongtrongdoiphong;
        private Label label1;
        private GroupBox groupBox5;
        private HotelManage.Assets.CusButton luudoiphong;
        private GroupBox groupBox2;
        private TextBox tenloaiphongtrongdoiphong;
        private Label label5;
        private TextBox tenphongtrongdoiphong;
        private Label label7;
        private TextBox giatrongdoiphong;
        private Label label3;
        private TextBox soluongnguoitoida;
        private Label label4;
        private Label label15;
        private Label txt_Exit;
        private HotelManage.Assets.CusButton dongdoiphong;
    }
}
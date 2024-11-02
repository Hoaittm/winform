namespace HotelManagementSystem
{
    partial class Checkin_details
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
            ngaytra = new DateTimePicker();
            label4 = new Label();
            ngaynhan = new DateTimePicker();
            label3 = new Label();
            madatphongcuachitietnhanphong = new TextBox();
            label2 = new Label();
            tenphonglucnhanphong = new ComboBox();
            label1 = new Label();
            groupBox5 = new GroupBox();
            groupBox3 = new GroupBox();
            dongkhachhangchitietnhanphong = new HotelManage.Assets.CusButton();
            dataGridView1 = new DataGridView();
            txt_Exit = new Label();
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
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(509, 71);
            label6.TabIndex = 21;
            label6.Text = "Chi tiết nhận phòng";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(ngaytra);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ngaynhan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(madatphongcuachitietnhanphong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tenphonglucnhanphong);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(25, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 572);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhận phòng";
            // 
            // ngaytra
            // 
            ngaytra.CustomFormat = "hh:mm:ss dd/MM/yyyy";
            ngaytra.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaytra.Format = DateTimePickerFormat.Custom;
            ngaytra.Location = new Point(25, 483);
            ngaytra.Name = "ngaytra";
            ngaytra.Size = new Size(471, 43);
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
            ngaynhan.CustomFormat = "hh:mm:ss dd/MM/yyyy";
            ngaynhan.Enabled = false;
            ngaynhan.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaynhan.Format = DateTimePickerFormat.Custom;
            ngaynhan.ImeMode = ImeMode.On;
            ngaynhan.Location = new Point(24, 362);
            ngaynhan.Name = "ngaynhan";
            ngaynhan.Size = new Size(472, 43);
            ngaynhan.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 309);
            label3.Name = "label3";
            label3.Size = new Size(159, 37);
            label3.TabIndex = 4;
            label3.Text = "Ngày nhận: ";
            // 
            // madatphongcuachitietnhanphong
            // 
            madatphongcuachitietnhanphong.Location = new Point(28, 108);
            madatphongcuachitietnhanphong.Name = "madatphongcuachitietnhanphong";
            madatphongcuachitietnhanphong.Size = new Size(468, 50);
            madatphongcuachitietnhanphong.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 177);
            label2.Name = "label2";
            label2.Size = new Size(148, 37);
            label2.TabIndex = 2;
            label2.Text = "Tên phòng:";
            // 
            // tenphonglucnhanphong
            // 
            tenphonglucnhanphong.FormattingEnabled = true;
            tenphonglucnhanphong.Location = new Point(25, 233);
            tenphonglucnhanphong.Name = "tenphonglucnhanphong";
            tenphonglucnhanphong.Size = new Size(471, 53);
            tenphonglucnhanphong.TabIndex = 1;
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
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ButtonHighlight;
            groupBox5.Controls.Add(dongkhachhangchitietnhanphong);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(25, 677);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(571, 220);
            groupBox5.TabIndex = 34;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(616, 99);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1036, 798);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách khách hàng";
            // 
            // dongkhachhangchitietnhanphong
            // 
            dongkhachhangchitietnhanphong.BackColor = SystemColors.ButtonHighlight;
            dongkhachhangchitietnhanphong.BackgroundColor = SystemColors.ButtonHighlight;
            dongkhachhangchitietnhanphong.BorderColor = SystemColors.HotTrack;
            dongkhachhangchitietnhanphong.BorderRadius = 35;
            dongkhachhangchitietnhanphong.BorderSize = 1;
            dongkhachhangchitietnhanphong.FlatAppearance.BorderSize = 0;
            dongkhachhangchitietnhanphong.FlatStyle = FlatStyle.Flat;
            dongkhachhangchitietnhanphong.ForeColor = SystemColors.HotTrack;
            dongkhachhangchitietnhanphong.Location = new Point(52, 109);
            dongkhachhangchitietnhanphong.Name = "dongkhachhangchitietnhanphong";
            dongkhachhangchitietnhanphong.Size = new Size(462, 78);
            dongkhachhangchitietnhanphong.TabIndex = 36;
            dongkhachhangchitietnhanphong.Text = "Đóng";
            dongkhachhangchitietnhanphong.TextColor = SystemColors.HotTrack;
            dongkhachhangchitietnhanphong.UseVisualStyleBackColor = false;
            dongkhachhangchitietnhanphong.Click += dongkhachhangchitietnhanphong_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(979, 690);
            dataGridView1.TabIndex = 0;
            // 
            // txt_Exit
            // 
            txt_Exit.AutoSize = true;
            txt_Exit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Exit.ForeColor = Color.Red;
            txt_Exit.Location = new Point(1614, 9);
            txt_Exit.Name = "txt_Exit";
            txt_Exit.Size = new Size(38, 41);
            txt_Exit.TabIndex = 36;
            txt_Exit.Text = "X";
            txt_Exit.Click += txt_Exit_Click_1;
            // 
            // Checkin_details
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1665, 916);
            Controls.Add(txt_Exit);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Checkin_details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkin_details";
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
        private GroupBox groupBox1;
        private DateTimePicker ngaytra;
        private Label label4;
        private DateTimePicker ngaynhan;
        private Label label3;
        private TextBox madatphongcuachitietnhanphong;
        private Label label2;
        private ComboBox tenphonglucnhanphong;
        private Label label1;
        private GroupBox groupBox5;
        private HotelManage.Assets.CusButton cusButton1;
        private GroupBox groupBox3;
        private HotelManage.Assets.CusButton dongkhachhangchitietnhanphong;
        private DataGridView dataGridView1;
        private Label label15;
        private Label txt_Exit;
    }
}
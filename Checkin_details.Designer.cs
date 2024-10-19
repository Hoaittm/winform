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
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox5 = new GroupBox();
            cusButton2 = new HotelManage.Assets.CusButton();
            changeRoom = new HotelManage.Assets.CusButton();
            groupBox3 = new GroupBox();
            cusButton5 = new HotelManage.Assets.CusButton();
            cusButton4 = new HotelManage.Assets.CusButton();
            cusButton3 = new HotelManage.Assets.CusButton();
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
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
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
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(25, 483);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(471, 43);
            dateTimePicker2.TabIndex = 7;
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
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.ActiveCaption;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.GradientInactiveCaption;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.On;
            dateTimePicker1.Location = new Point(24, 362);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(472, 43);
            dateTimePicker1.TabIndex = 5;
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
            // textBox1
            // 
            textBox1.Location = new Point(28, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(468, 50);
            textBox1.TabIndex = 3;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 233);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(471, 53);
            comboBox1.TabIndex = 1;
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
            groupBox5.Controls.Add(cusButton2);
            groupBox5.Controls.Add(changeRoom);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.HotTrack;
            groupBox5.Location = new Point(25, 701);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(571, 330);
            groupBox5.TabIndex = 34;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
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
            cusButton2.Location = new Point(28, 201);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(468, 78);
            cusButton2.TabIndex = 34;
            cusButton2.Text = "Đóng";
            cusButton2.TextColor = SystemColors.HotTrack;
            cusButton2.UseVisualStyleBackColor = false;
            // 
            // changeRoom
            // 
            changeRoom.BackColor = SystemColors.ButtonHighlight;
            changeRoom.BackgroundColor = SystemColors.ButtonHighlight;
            changeRoom.BorderColor = SystemColors.HotTrack;
            changeRoom.BorderRadius = 35;
            changeRoom.BorderSize = 1;
            changeRoom.FlatAppearance.BorderSize = 0;
            changeRoom.FlatStyle = FlatStyle.Flat;
            changeRoom.ForeColor = SystemColors.HotTrack;
            changeRoom.Location = new Point(28, 85);
            changeRoom.Name = "changeRoom";
            changeRoom.Size = new Size(468, 78);
            changeRoom.TabIndex = 33;
            changeRoom.Text = "Đổi phòng";
            changeRoom.TextColor = SystemColors.HotTrack;
            changeRoom.UseVisualStyleBackColor = false;
            changeRoom.Click += changeRoom_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(cusButton5);
            groupBox3.Controls.Add(cusButton4);
            groupBox3.Controls.Add(cusButton3);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(616, 99);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1141, 932);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách khách hàng";
            groupBox3.Enter += groupBox3_Enter;
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
            cusButton5.Location = new Point(770, 803);
            cusButton5.Name = "cusButton5";
            cusButton5.Size = new Size(335, 78);
            cusButton5.TabIndex = 36;
            cusButton5.Text = "Đóng";
            cusButton5.TextColor = SystemColors.HotTrack;
            cusButton5.UseVisualStyleBackColor = false;
            cusButton5.Click += cusButton5_Click;
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
            cusButton4.Location = new Point(387, 803);
            cusButton4.Name = "cusButton4";
            cusButton4.Size = new Size(323, 78);
            cusButton4.TabIndex = 35;
            cusButton4.Text = "Xóa khách hàng";
            cusButton4.TextColor = SystemColors.HotTrack;
            cusButton4.UseVisualStyleBackColor = false;
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
            cusButton3.Location = new Point(21, 803);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(334, 78);
            cusButton3.TabIndex = 34;
            cusButton3.Text = "Thêm khách hàng";
            cusButton3.TextColor = SystemColors.HotTrack;
            cusButton3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1084, 451);
            dataGridView1.TabIndex = 0;
            // 
            // txt_Exit
            // 
            txt_Exit.AutoSize = true;
            txt_Exit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Exit.ForeColor = Color.Red;
            txt_Exit.Location = new Point(1719, 9);
            txt_Exit.Name = "txt_Exit";
            txt_Exit.Size = new Size(38, 41);
            txt_Exit.TabIndex = 36;
            txt_Exit.Text = "X";
            txt_Exit.Click += txt_Exit_Click;
            // 
            // Checkin_details
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 1045);
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
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox5;
        private HotelManage.Assets.CusButton cusButton2;
        private HotelManage.Assets.CusButton cusButton1;
        private GroupBox groupBox3;
        private HotelManage.Assets.CusButton cusButton5;
        private HotelManage.Assets.CusButton cusButton4;
        private HotelManage.Assets.CusButton cusButton3;
        private DataGridView dataGridView1;
        private Label label15;
        private Label txt_Exit;
        private HotelManage.Assets.CusButton changeRoom;
    }
}
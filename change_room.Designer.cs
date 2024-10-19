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
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox5 = new GroupBox();
            cusButton2 = new HotelManage.Assets.CusButton();
            cusButton1 = new HotelManage.Assets.CusButton();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
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
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Phòng Suite (SUT)", "Phòng Deluxe (DLX)", "Phòng Superior (SUP)", "Phòng Standard (STD)" });
            comboBox2.Location = new Point(25, 218);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(471, 53);
            comboBox2.TabIndex = 3;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Phòng Suite (SUT)", "Phòng Deluxe (DLX)", "Phòng Superior (SUP)", "Phòng Standard (STD)" });
            comboBox1.Location = new Point(25, 94);
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
            label1.Size = new Size(158, 37);
            label1.TabIndex = 0;
            label1.Text = "Loại phòng:";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ButtonHighlight;
            groupBox5.Controls.Add(cusButton2);
            groupBox5.Controls.Add(cusButton1);
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
            cusButton2.Click += cusButton2_Click;
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
            cusButton1.Location = new Point(28, 85);
            cusButton1.Name = "cusButton1";
            cusButton1.Size = new Size(468, 78);
            cusButton1.TabIndex = 33;
            cusButton1.Text = "Lưu thay đổi";
            cusButton1.TextColor = SystemColors.HotTrack;
            cusButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox1);
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
            // textBox3
            // 
            textBox3.Location = new Point(27, 504);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(468, 50);
            textBox3.TabIndex = 13;
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
            // textBox4
            // 
            textBox4.Location = new Point(30, 377);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(468, 50);
            textBox4.TabIndex = 11;
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
            // textBox2
            // 
            textBox2.Location = new Point(30, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(468, 50);
            textBox2.TabIndex = 9;
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
            // textBox1
            // 
            textBox1.Location = new Point(27, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(468, 50);
            textBox1.TabIndex = 3;
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
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox5;
        private HotelManage.Assets.CusButton cusButton2;
        private HotelManage.Assets.CusButton cusButton1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label15;
        private Label txt_Exit;
    }
}
namespace HotelManagementSystem
{
    partial class service_manage
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
            tendichvutimkiem = new TextBox();
            timkiemdichvu = new HotelManage.Assets.CusButton();
            label9 = new Label();
            groupBox1 = new GroupBox();
            loaidichvu = new ComboBox();
            label7 = new Label();
            giadichvu = new TextBox();
            label5 = new Label();
            tendichvu = new TextBox();
            label3 = new Label();
            madichvu = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            cusButton5 = new HotelManage.Assets.CusButton();
            capnhatdichvu = new HotelManage.Assets.CusButton();
            themdichvu = new HotelManage.Assets.CusButton();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            label15 = new Label();
            menuStrip1 = new MenuStrip();
            xuấtFileToolStripMenuItem = new ToolStripMenuItem();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            label6.Size = new Size(407, 71);
            label6.TabIndex = 28;
            label6.Text = "Quản lý dịch vụ";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(tendichvutimkiem);
            groupBox2.Controls.Add(timkiemdichvu);
            groupBox2.Controls.Add(label9);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(12, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(975, 217);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // tendichvutimkiem
            // 
            tendichvutimkiem.Location = new Point(31, 106);
            tendichvutimkiem.Name = "tendichvutimkiem";
            tendichvutimkiem.Size = new Size(400, 46);
            tendichvutimkiem.TabIndex = 40;
            // 
            // timkiemdichvu
            // 
            timkiemdichvu.BackColor = SystemColors.ButtonHighlight;
            timkiemdichvu.BackgroundColor = SystemColors.ButtonHighlight;
            timkiemdichvu.BorderColor = SystemColors.HotTrack;
            timkiemdichvu.BorderRadius = 35;
            timkiemdichvu.BorderSize = 1;
            timkiemdichvu.FlatAppearance.BorderSize = 0;
            timkiemdichvu.FlatStyle = FlatStyle.Flat;
            timkiemdichvu.ForeColor = SystemColors.HotTrack;
            timkiemdichvu.Location = new Point(539, 90);
            timkiemdichvu.Name = "timkiemdichvu";
            timkiemdichvu.Size = new Size(402, 62);
            timkiemdichvu.TabIndex = 39;
            timkiemdichvu.Text = "Tìm kiếm";
            timkiemdichvu.TextColor = SystemColors.HotTrack;
            timkiemdichvu.UseVisualStyleBackColor = false;
            timkiemdichvu.Click += timkiemdichvu_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 54);
            label9.Name = "label9";
            label9.Size = new Size(155, 37);
            label9.TabIndex = 0;
            label9.Text = "Tên dịch vụ:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(loaidichvu);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(giadichvu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tendichvu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(madichvu);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 337);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 563);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dịch vụ";
            // 
            // loaidichvu
            // 
            loaidichvu.FormattingEnabled = true;
            loaidichvu.Items.AddRange(new object[] { "Giải trí", "Tiện ích", "Ăn uống" });
            loaidichvu.Location = new Point(25, 359);
            loaidichvu.Name = "loaidichvu";
            loaidichvu.Size = new Size(406, 48);
            loaidichvu.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 306);
            label7.Name = "label7";
            label7.Size = new Size(165, 37);
            label7.TabIndex = 48;
            label7.Text = "Loại dịch vụ:";
            // 
            // giadichvu
            // 
            giadichvu.Location = new Point(25, 487);
            giadichvu.Name = "giadichvu";
            giadichvu.Size = new Size(406, 46);
            giadichvu.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 434);
            label5.Name = "label5";
            label5.Size = new Size(63, 37);
            label5.TabIndex = 46;
            label5.Text = "Giá:";
            // 
            // tendichvu
            // 
            tendichvu.Location = new Point(25, 231);
            tendichvu.Name = "tendichvu";
            tendichvu.Size = new Size(406, 46);
            tendichvu.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 178);
            label3.Name = "label3";
            label3.Size = new Size(155, 37);
            label3.TabIndex = 42;
            label3.Text = "Tên dịch vụ:";
            // 
            // madichvu
            // 
            madichvu.FormattingEnabled = true;
            madichvu.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            madichvu.Location = new Point(25, 107);
            madichvu.Name = "madichvu";
            madichvu.Size = new Size(406, 48);
            madichvu.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 54);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 0;
            label1.Text = "Mã dịch vụ:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(cusButton5);
            groupBox3.Controls.Add(capnhatdichvu);
            groupBox3.Controls.Add(themdichvu);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(507, 337);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(480, 563);
            groupBox3.TabIndex = 50;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
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
            cusButton5.Location = new Point(44, 434);
            cusButton5.Name = "cusButton5";
            cusButton5.Size = new Size(402, 99);
            cusButton5.TabIndex = 43;
            cusButton5.Text = "Đóng";
            cusButton5.TextColor = SystemColors.HotTrack;
            cusButton5.UseVisualStyleBackColor = false;
            cusButton5.Click += cusButton5_Click;
            // 
            // capnhatdichvu
            // 
            capnhatdichvu.BackColor = SystemColors.ButtonHighlight;
            capnhatdichvu.BackgroundColor = SystemColors.ButtonHighlight;
            capnhatdichvu.BorderColor = SystemColors.HotTrack;
            capnhatdichvu.BorderRadius = 35;
            capnhatdichvu.BorderSize = 1;
            capnhatdichvu.FlatAppearance.BorderSize = 0;
            capnhatdichvu.FlatStyle = FlatStyle.Flat;
            capnhatdichvu.ForeColor = SystemColors.HotTrack;
            capnhatdichvu.Location = new Point(44, 251);
            capnhatdichvu.Name = "capnhatdichvu";
            capnhatdichvu.Size = new Size(402, 109);
            capnhatdichvu.TabIndex = 41;
            capnhatdichvu.Text = "Cập nhật";
            capnhatdichvu.TextColor = SystemColors.HotTrack;
            capnhatdichvu.UseVisualStyleBackColor = false;
            capnhatdichvu.Click += capnhatdichvu_Click;
            // 
            // themdichvu
            // 
            themdichvu.BackColor = SystemColors.ButtonHighlight;
            themdichvu.BackgroundColor = SystemColors.ButtonHighlight;
            themdichvu.BorderColor = SystemColors.HotTrack;
            themdichvu.BorderRadius = 35;
            themdichvu.BorderSize = 1;
            themdichvu.FlatAppearance.BorderSize = 0;
            themdichvu.FlatStyle = FlatStyle.Flat;
            themdichvu.ForeColor = SystemColors.HotTrack;
            themdichvu.Location = new Point(44, 83);
            themdichvu.Name = "themdichvu";
            themdichvu.Size = new Size(402, 107);
            themdichvu.TabIndex = 40;
            themdichvu.Text = "Thêm";
            themdichvu.TextColor = SystemColors.HotTrack;
            themdichvu.UseVisualStyleBackColor = false;
            themdichvu.Click += themdichvu_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(menuStrip1);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.HotTrack;
            groupBox4.Location = new Point(1011, 104);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(987, 796);
            groupBox4.TabIndex = 51;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách dịch vụ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(952, 676);
            dataGridView1.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(1960, 21);
            label15.Name = "label15";
            label15.Size = new Size(38, 41);
            label15.TabIndex = 41;
            label15.Text = "X";
            label15.Click += label15_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { xuấtFileToolStripMenuItem });
            menuStrip1.Location = new Point(3, 42);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(981, 42);
            menuStrip1.TabIndex = 2;
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
            // service_manage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2009, 912);
            Controls.Add(label15);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "service_manage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "service_manage";
            Load += service_manage_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private GroupBox groupBox2;
        private TextBox tendichvutimkiem;
        private HotelManage.Assets.CusButton timkiemdichvu;
        private Label label9;
        private GroupBox groupBox1;
        private TextBox giadichvu;
        private Label label5;
        private TextBox tendichvu;
        private Label label3;
        private ComboBox madichvu;
        private Label label1;
        private GroupBox groupBox3;
        private ComboBox loaidichvu;
        private Label label7;
        private HotelManage.Assets.CusButton cusButton5;
        private HotelManage.Assets.CusButton cusButton4;
        private HotelManage.Assets.CusButton capnhatdichvu;
        private HotelManage.Assets.CusButton themdichvu;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Label label15;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem xuấtFileToolStripMenuItem;
    }
}
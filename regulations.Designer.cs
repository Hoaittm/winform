namespace HotelManagementSystem
{
    partial class regulations
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
            tenquydinhcuatimkiem = new TextBox();
            timkiemtenquydinh = new HotelManage.Assets.CusButton();
            label9 = new Label();
            groupBox1 = new GroupBox();
            mieutaquydinh = new TextBox();
            label3 = new Label();
            giatriquydinh = new TextBox();
            label2 = new Label();
            tenquydinh = new ComboBox();
            label1 = new Label();
            capnhatquydinh = new HotelManage.Assets.CusButton();
            groupBox3 = new GroupBox();
            cusButton3 = new HotelManage.Assets.CusButton();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            label15 = new Label();
            xuatfile = new MenuStrip();
            xuấtFileToolStripMenuItem = new ToolStripMenuItem();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            xuatfile.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(-1, -1);
            label6.Name = "label6";
            label6.Size = new Size(250, 71);
            label6.TabIndex = 29;
            label6.Text = "Quy định";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(tenquydinhcuatimkiem);
            groupBox2.Controls.Add(timkiemtenquydinh);
            groupBox2.Controls.Add(label9);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(12, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 292);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // tenquydinhcuatimkiem
            // 
            tenquydinhcuatimkiem.Location = new Point(31, 106);
            tenquydinhcuatimkiem.Name = "tenquydinhcuatimkiem";
            tenquydinhcuatimkiem.Size = new Size(400, 46);
            tenquydinhcuatimkiem.TabIndex = 40;
            // 
            // timkiemtenquydinh
            // 
            timkiemtenquydinh.BackColor = SystemColors.ButtonHighlight;
            timkiemtenquydinh.BackgroundColor = SystemColors.ButtonHighlight;
            timkiemtenquydinh.BorderColor = SystemColors.HotTrack;
            timkiemtenquydinh.BorderRadius = 35;
            timkiemtenquydinh.BorderSize = 1;
            timkiemtenquydinh.FlatAppearance.BorderSize = 0;
            timkiemtenquydinh.FlatStyle = FlatStyle.Flat;
            timkiemtenquydinh.ForeColor = SystemColors.HotTrack;
            timkiemtenquydinh.Location = new Point(29, 192);
            timkiemtenquydinh.Name = "timkiemtenquydinh";
            timkiemtenquydinh.Size = new Size(402, 62);
            timkiemtenquydinh.TabIndex = 39;
            timkiemtenquydinh.Text = "Tìm kiếm";
            timkiemtenquydinh.TextColor = SystemColors.HotTrack;
            timkiemtenquydinh.UseVisualStyleBackColor = false;
            timkiemtenquydinh.Click += timkiemtenquydinh_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 54);
            label9.Name = "label9";
            label9.Size = new Size(63, 37);
            label9.TabIndex = 0;
            label9.Text = "Tên:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(mieutaquydinh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(giatriquydinh);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tenquydinh);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 397);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 410);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin quy định";
            // 
            // mieutaquydinh
            // 
            mieutaquydinh.Location = new Point(31, 320);
            mieutaquydinh.Name = "mieutaquydinh";
            mieutaquydinh.Size = new Size(400, 46);
            mieutaquydinh.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 280);
            label3.Name = "label3";
            label3.Size = new Size(113, 37);
            label3.TabIndex = 44;
            label3.Text = "Miêu tả:";
            // 
            // giatriquydinh
            // 
            giatriquydinh.Location = new Point(31, 209);
            giatriquydinh.Name = "giatriquydinh";
            giatriquydinh.Size = new Size(400, 46);
            giatriquydinh.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 169);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 42;
            label2.Text = "Giá trị:";
            // 
            // tenquydinh
            // 
            tenquydinh.FormattingEnabled = true;
            tenquydinh.Location = new Point(31, 94);
            tenquydinh.Name = "tenquydinh";
            tenquydinh.Size = new Size(400, 48);
            tenquydinh.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 54);
            label1.Name = "label1";
            label1.Size = new Size(63, 37);
            label1.TabIndex = 0;
            label1.Text = "Tên:";
            // 
            // capnhatquydinh
            // 
            capnhatquydinh.BackColor = SystemColors.ButtonHighlight;
            capnhatquydinh.BackgroundColor = SystemColors.ButtonHighlight;
            capnhatquydinh.BorderColor = SystemColors.HotTrack;
            capnhatquydinh.BorderRadius = 35;
            capnhatquydinh.BorderSize = 1;
            capnhatquydinh.FlatAppearance.BorderSize = 0;
            capnhatquydinh.FlatStyle = FlatStyle.Flat;
            capnhatquydinh.ForeColor = SystemColors.HotTrack;
            capnhatquydinh.Location = new Point(29, 81);
            capnhatquydinh.Name = "capnhatquydinh";
            capnhatquydinh.Size = new Size(402, 62);
            capnhatquydinh.TabIndex = 39;
            capnhatquydinh.Text = "Cập nhật";
            capnhatquydinh.TextColor = SystemColors.HotTrack;
            capnhatquydinh.UseVisualStyleBackColor = false;
            capnhatquydinh.Click += capnhatquydinh_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(cusButton3);
            groupBox3.Controls.Add(capnhatquydinh);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(12, 826);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(460, 278);
            groupBox3.TabIndex = 40;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
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
            cusButton3.Location = new Point(29, 192);
            cusButton3.Name = "cusButton3";
            cusButton3.Size = new Size(402, 62);
            cusButton3.TabIndex = 39;
            cusButton3.Text = "Đóng";
            cusButton3.TextColor = SystemColors.HotTrack;
            cusButton3.UseVisualStyleBackColor = false;
            cusButton3.Click += cusButton3_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(xuatfile);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.HotTrack;
            groupBox4.Location = new Point(490, 86);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1066, 1018);
            groupBox4.TabIndex = 41;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách quy định";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1031, 880);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(1518, 9);
            label15.Name = "label15";
            label15.Size = new Size(38, 41);
            label15.TabIndex = 42;
            label15.Text = "X";
            label15.Click += label15_Click;
            // 
            // xuatfile
            // 
            xuatfile.BackColor = SystemColors.ControlLightLight;
            xuatfile.ImageScalingSize = new Size(32, 32);
            xuatfile.Items.AddRange(new ToolStripItem[] { xuấtFileToolStripMenuItem });
            xuatfile.Location = new Point(3, 42);
            xuatfile.Name = "xuatfile";
            xuatfile.Size = new Size(1060, 42);
            xuatfile.TabIndex = 2;
            // 
            // xuấtFileToolStripMenuItem
            // 
            xuấtFileToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            xuấtFileToolStripMenuItem.Name = "xuấtFileToolStripMenuItem";
            xuấtFileToolStripMenuItem.Size = new Size(122, 38);
            xuấtFileToolStripMenuItem.Text = "Xuất file";
            xuấtFileToolStripMenuItem.Click += xuấtFileToolStripMenuItem_Click;
            // 
            // regulations
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 1125);
            Controls.Add(label15);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = xuatfile;
            Name = "regulations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "regulations";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            xuatfile.ResumeLayout(false);
            xuatfile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private GroupBox groupBox2;
        private TextBox tenquydinhcuatimkiem;
        private HotelManage.Assets.CusButton timkiemtenquydinh;
        private Label label9;
        private GroupBox groupBox1;
        private HotelManage.Assets.CusButton capnhatquydinh;
        private Label label1;
        private TextBox mieutaquydinh;
        private Label label3;
        private TextBox giatriquydinh;
        private Label label2;
        private ComboBox tenquydinh;
        private GroupBox groupBox3;
        private HotelManage.Assets.CusButton cusButton3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Label label15;
        private MenuStrip xuatfile;
        private ToolStripMenuItem xuấtFileToolStripMenuItem;
    }
}
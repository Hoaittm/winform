namespace HotelManagementSystem
{
    partial class Revenue_report
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
            nam = new NumericUpDown();
            label1 = new Label();
            xemketquatimkiem = new HotelManage.Assets.CusButton();
            thang = new ComboBox();
            label9 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            cusButton2 = new HotelManage.Assets.CusButton();
            dataGridView1 = new DataGridView();
            label15 = new Label();
            menuStrip1 = new MenuStrip();
            xuấtFileToolStripMenuItem = new ToolStripMenuItem();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nam).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(481, 71);
            label6.TabIndex = 24;
            label6.Text = "Báo cáo doanh thu";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(nam);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(xemketquatimkiem);
            groupBox2.Controls.Add(thang);
            groupBox2.Controls.Add(label9);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(12, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1776, 177);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // nam
            // 
            nam.Increment = new decimal(new int[] { 2000, 0, 0, 0 });
            nam.Location = new Point(666, 62);
            nam.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            nam.Name = "nam";
            nam.Size = new Size(406, 46);
            nam.TabIndex = 41;
            nam.TextAlign = HorizontalAlignment.Center;
            nam.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            nam.ValueChanged += nam_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(580, 62);
            label1.Name = "label1";
            label1.Size = new Size(80, 37);
            label1.TabIndex = 40;
            label1.Text = "Năm:";
            // 
            // xemketquatimkiem
            // 
            xemketquatimkiem.BackColor = SystemColors.ButtonHighlight;
            xemketquatimkiem.BackgroundColor = SystemColors.ButtonHighlight;
            xemketquatimkiem.BorderColor = SystemColors.HotTrack;
            xemketquatimkiem.BorderRadius = 35;
            xemketquatimkiem.BorderSize = 1;
            xemketquatimkiem.FlatAppearance.BorderSize = 0;
            xemketquatimkiem.FlatStyle = FlatStyle.Flat;
            xemketquatimkiem.ForeColor = SystemColors.HotTrack;
            xemketquatimkiem.Location = new Point(1222, 43);
            xemketquatimkiem.Name = "xemketquatimkiem";
            xemketquatimkiem.Size = new Size(486, 74);
            xemketquatimkiem.TabIndex = 39;
            xemketquatimkiem.Text = "Xem kết quả";
            xemketquatimkiem.TextColor = SystemColors.HotTrack;
            xemketquatimkiem.UseVisualStyleBackColor = false;
            xemketquatimkiem.Click += xemketquatimkiem_Click;
            // 
            // thang
            // 
            thang.FormattingEnabled = true;
            thang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            thang.Location = new Point(119, 62);
            thang.Name = "thang";
            thang.Size = new Size(406, 48);
            thang.TabIndex = 33;
            thang.SelectedIndexChanged += thang_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 54);
            label9.Name = "label9";
            label9.Size = new Size(97, 37);
            label9.TabIndex = 0;
            label9.Text = "Tháng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 72);
            label2.Name = "label2";
            label2.Size = new Size(398, 37);
            label2.TabIndex = 41;
            label2.Text = "Tỉ lệ doanh thu theo loại phòng:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(cusButton2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(menuStrip1);
            panel1.ForeColor = SystemColors.HotTrack;
            panel1.Location = new Point(12, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(1776, 1047);
            panel1.TabIndex = 42;
            // 
            // button5
            // 
            button5.BackColor = Color.SeaGreen;
            button5.Location = new Point(494, 271);
            button5.Name = "button5";
            button5.Size = new Size(92, 30);
            button5.TabIndex = 48;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.Location = new Point(494, 235);
            button4.Name = "button4";
            button4.Size = new Size(92, 30);
            button4.TabIndex = 47;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Violet;
            button3.Location = new Point(494, 189);
            button3.Name = "button3";
            button3.Size = new Size(92, 30);
            button3.TabIndex = 46;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Location = new Point(494, 144);
            button2.Name = "button2";
            button2.Size = new Size(92, 30);
            button2.TabIndex = 45;
            button2.UseVisualStyleBackColor = false;
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
            cusButton2.Location = new Point(1420, 905);
            cusButton2.Name = "cusButton2";
            cusButton2.Size = new Size(304, 74);
            cusButton2.TabIndex = 44;
            cusButton2.Text = "Đóng";
            cusButton2.TextColor = SystemColors.HotTrack;
            cusButton2.UseVisualStyleBackColor = false;
            cusButton2.Click += cusButton2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(666, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1103, 785);
            dataGridView1.TabIndex = 42;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(1750, 9);
            label15.Name = "label15";
            label15.Size = new Size(38, 41);
            label15.TabIndex = 43;
            label15.Text = "X";
            label15.Click += label15_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { xuấtFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1776, 42);
            menuStrip1.TabIndex = 49;
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
            // Revenue_report
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1805, 1397);
            Controls.Add(label15);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Revenue_report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Revenue_report";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nam).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private GroupBox groupBox2;
        private Label label1;
        private HotelManage.Assets.CusButton xemketquatimkiem;
        private ComboBox thang;
        private Label label9;
        private NumericUpDown nam;
        private Label label2;
        private Panel panel1;
        private Button button2;
        private HotelManage.Assets.CusButton cusButton2;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label15;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem xuấtFileToolStripMenuItem;
    }
}
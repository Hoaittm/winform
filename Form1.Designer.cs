namespace HotelManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btn_Exit = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            btn_Login = new Button();
            txt_password = new TextBox();
            label4 = new Label();
            check_show_pass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(717, 1014);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 510);
            label5.Name = "label5";
            label5.Size = new Size(496, 65);
            label5.TabIndex = 10;
            label5.Text = "The Sheraton Saigon";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 258);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            btn_Exit.AutoSize = true;
            btn_Exit.ForeColor = SystemColors.ControlText;
            btn_Exit.Location = new Point(1436, 9);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(29, 32);
            btn_Exit.TabIndex = 1;
            btn_Exit.Text = "X";
            btn_Exit.Click += btn_Exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(765, 144);
            label2.Name = "label2";
            label2.Size = new Size(461, 55);
            label2.TabIndex = 2;
            label2.Text = "Sheraton, xin chào";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(765, 264);
            label3.Name = "label3";
            label3.Size = new Size(223, 34);
            label3.TabIndex = 3;
            label3.Text = "Tên đăng nhập";
            label3.Click += label3_Click;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(765, 311);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(627, 78);
            txt_username.TabIndex = 4;
            txt_username.TabStop = false;
            txt_username.BorderStyleChanged += txt_username_BorderStyleChanged;
            txt_username.TextChanged += textBox1_TextChanged;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.GradientActiveCaption;
            btn_Login.Location = new Point(907, 669);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(351, 76);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(765, 476);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '.';
            txt_password.Size = new Size(627, 78);
            txt_password.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(765, 430);
            label4.Name = "label4";
            label4.Size = new Size(142, 34);
            label4.TabIndex = 8;
            label4.Text = "Mật khẩu";
            // 
            // check_show_pass
            // 
            check_show_pass.AutoSize = true;
            check_show_pass.Location = new Point(765, 573);
            check_show_pass.Name = "check_show_pass";
            check_show_pass.Size = new Size(208, 36);
            check_show_pass.TabIndex = 10;
            check_show_pass.Text = "Hiện mật khẩu";
            check_show_pass.UseVisualStyleBackColor = true;
            check_show_pass.CheckedChanged += check_show_pass_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1479, 1014);
            Controls.Add(check_show_pass);
            Controls.Add(txt_password);
            Controls.Add(label4);
            Controls.Add(btn_Login);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Exit);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label btn_Exit;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private Button btn_Login;
        private TextBox txt_password;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private CheckBox check_show_pass;
    }
}

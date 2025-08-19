namespace DoAn_QLSV.Forms
{
    partial class frmDangNhap
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
            label1 = new Label();
            btnDangNhap = new Button();
            label2 = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ckbHienMatKhau = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(132, 63);
            label1.Name = "label1";
            label1.Size = new Size(268, 54);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.MediumAquamarine;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderColor = Color.Teal;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            btnDangNhap.ForeColor = SystemColors.Control;
            btnDangNhap.Location = new Point(150, 401);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(232, 59);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(0, 143);
            label2.Name = "label2";
            label2.Size = new Size(254, 45);
            label2.TabIndex = 4;
            label2.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.Teal;
            txtTenDangNhap.BorderStyle = BorderStyle.None;
            txtTenDangNhap.Font = new Font("Segoe UI", 16F);
            txtTenDangNhap.ForeColor = SystemColors.Control;
            txtTenDangNhap.Location = new Point(12, 193);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(509, 43);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.Teal;
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 16F);
            txtMatKhau.ForeColor = SystemColors.Control;
            txtMatKhau.Location = new Point(12, 301);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(509, 43);
            txtMatKhau.TabIndex = 7;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(0, 251);
            label3.Name = "label3";
            label3.Size = new Size(172, 45);
            label3.TabIndex = 6;
            label3.Text = "Mật khẩu:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(12, 344);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 1);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.ForeColor = SystemColors.Control;
            panel2.Location = new Point(12, 236);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 1);
            panel2.TabIndex = 9;
            // 
            // ckbHienMatKhau
            // 
            ckbHienMatKhau.AutoSize = true;
            ckbHienMatKhau.Font = new Font("Segoe UI", 12F);
            ckbHienMatKhau.ForeColor = SystemColors.Control;
            ckbHienMatKhau.Location = new Point(12, 350);
            ckbHienMatKhau.Name = "ckbHienMatKhau";
            ckbHienMatKhau.Size = new Size(197, 36);
            ckbHienMatKhau.TabIndex = 10;
            ckbHienMatKhau.Text = "Hiện mật khẩu";
            ckbHienMatKhau.UseVisualStyleBackColor = true;
            ckbHienMatKhau.CheckedChanged += ckbHienMatKhau_CheckedChanged;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(533, 554);
            Controls.Add(ckbHienMatKhau);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtMatKhau);
            Controls.Add(label3);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label2);
            Controls.Add(btnDangNhap);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDangNhap;
        private Label label2;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private CheckBox ckbHienMatKhau;
    }
}
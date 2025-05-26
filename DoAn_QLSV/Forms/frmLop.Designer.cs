namespace DoAn_QLSV.Forms
{
    partial class frmLop
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
            dataGridView1 = new DataGridView();
            MaLop = new DataGridViewTextBoxColumn();
            TenLop = new DataGridViewTextBoxColumn();
            TenKhoa = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel3 = new Panel();
            btn123123 = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtTenKhoa = new TextBox();
            label1 = new Label();
            txtTenLop = new TextBox();
            txtMaLop = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            btnLuu = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 58;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaLop, TenLop, TenKhoa });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1029, 268);
            dataGridView1.TabIndex = 0;
            // 
            // MaLop
            // 
            MaLop.DataPropertyName = "maLop";
            MaLop.HeaderText = "Mã lớp";
            MaLop.MinimumWidth = 8;
            MaLop.Name = "MaLop";
            MaLop.ReadOnly = true;
            // 
            // TenLop
            // 
            TenLop.DataPropertyName = "tenLop";
            TenLop.HeaderText = "Tên lớp";
            TenLop.MinimumWidth = 8;
            TenLop.Name = "TenLop";
            TenLop.ReadOnly = true;
            // 
            // TenKhoa
            // 
            TenKhoa.DataPropertyName = "tenKhoa";
            TenKhoa.HeaderText = "Tên khoa";
            TenKhoa.MinimumWidth = 8;
            TenKhoa.Name = "TenKhoa";
            TenKhoa.ReadOnly = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(1691, 22);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Hủy bỏ";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(1029, 268);
            panel3.TabIndex = 7;
            // 
            // btn123123
            // 
            btn123123.Anchor = AnchorStyles.Top;
            btn123123.Location = new Point(2030, 22);
            btn123123.Name = "btn123123";
            btn123123.Size = new Size(112, 34);
            btn123123.TabIndex = 2;
            btn123123.Text = "Hủy bỏ";
            btn123123.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 150);
            panel2.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenKhoa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenLop);
            groupBox1.Controls.Add(txtMaLop);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khoa";
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(163, 105);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(213, 31);
            txtTenKhoa.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(7, 103);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 66;
            label1.Text = "Tên khoa:";
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(163, 68);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(213, 31);
            txtTenLop.TabIndex = 65;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(163, 30);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(213, 31);
            txtMaLop.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(7, 66);
            label7.Name = "label7";
            label7.Size = new Size(79, 28);
            label7.TabIndex = 63;
            label7.Text = "Tên lớp:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(7, 27);
            label8.Name = "label8";
            label8.Size = new Size(78, 28);
            label8.TabIndex = 62;
            label8.Text = "Mã lớp:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn123123);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 78);
            panel1.TabIndex = 5;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(594, 22);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(322, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.Location = new Point(730, 22);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 34);
            btnHuyBo.TabIndex = 16;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(458, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(186, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // frmLop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 496);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmLop";
            Text = "frmLop";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button1;
        private Panel panel3;
        private Button btn123123;
        private Panel panel2;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtTenKhoa;
        private Label label1;
        private TextBox txtTenLop;
        private TextBox txtMaLop;
        private Label label7;
        private Label label8;
        private Button btnLuu;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThem;
        private DataGridViewTextBoxColumn MaLop;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn TenKhoa;
    }
}
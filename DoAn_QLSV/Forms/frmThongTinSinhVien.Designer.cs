namespace DoAn_QLSV.Forms
{
    partial class frmThongTinSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinSinhVien));
            panel1 = new Panel();
            btnLuu = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btn92399213 = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            cboTenKhoa = new ComboBox();
            cboTenLop = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label6 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            panelGioiTinh = new Panel();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            txtSoDienThoai = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtHoTen = new TextBox();
            label5 = new Label();
            txtMaSoSinhVien = new TextBox();
            label1 = new Label();
            picHinhAnh = new PictureBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            MaSoSinhVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            TenLop = new DataGridViewTextBoxColumn();
            TenKhoa = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapExcel = new ToolStripButton();
            btnXuatExcel = new ToolStripButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panelGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btn92399213);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 525);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 78);
            panel1.TabIndex = 1;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(709, 22);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(437, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.Location = new Point(845, 22);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 34);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += button1_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(573, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(301, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btn92399213
            // 
            btn92399213.Anchor = AnchorStyles.Top;
            btn92399213.Location = new Point(1184, 22);
            btn92399213.Name = "btn92399213";
            btn92399213.Size = new Size(112, 34);
            btn92399213.TabIndex = 2;
            btn92399213.Text = "Hủy bỏ";
            btn92399213.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1165, 242);
            panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTenKhoa);
            groupBox1.Controls.Add(cboTenLop);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(panelGioiTinh);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMaSoSinhVien);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1165, 242);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // cboTenKhoa
            // 
            cboTenKhoa.FormattingEnabled = true;
            cboTenKhoa.Location = new Point(722, 160);
            cboTenKhoa.Name = "cboTenKhoa";
            cboTenKhoa.Size = new Size(215, 33);
            cboTenKhoa.TabIndex = 61;
            // 
            // cboTenLop
            // 
            cboTenLop.FormattingEnabled = true;
            cboTenLop.Location = new Point(722, 119);
            cboTenLop.Name = "cboTenLop";
            cboTenLop.Size = new Size(215, 33);
            cboTenLop.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(568, 160);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 59;
            label7.Text = "Tên khoa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(568, 121);
            label8.Name = "label8";
            label8.Size = new Size(79, 28);
            label8.TabIndex = 58;
            label8.Text = "Tên lớp:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(722, 76);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(143, 31);
            dtpNgaySinh.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(566, 76);
            label6.Name = "label6";
            label6.Size = new Size(103, 28);
            label6.TabIndex = 56;
            label6.Text = "Ngày sinh:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(722, 30);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(215, 31);
            txtDiaChi.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(566, 30);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 54;
            label4.Text = "Địa chỉ:";
            // 
            // panelGioiTinh
            // 
            panelGioiTinh.Controls.Add(rdbNam);
            panelGioiTinh.Controls.Add(rdbNu);
            panelGioiTinh.Location = new Point(167, 124);
            panelGioiTinh.Name = "panelGioiTinh";
            panelGioiTinh.Size = new Size(232, 38);
            panelGioiTinh.TabIndex = 53;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(23, 3);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(75, 29);
            rdbNam.TabIndex = 34;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(132, 2);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(61, 29);
            rdbNu.TabIndex = 35;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(167, 172);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(232, 31);
            txtSoDienThoai.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(11, 172);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 43;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(11, 124);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 42;
            label2.Text = "Giới tính:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(167, 78);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(232, 31);
            txtHoTen.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(11, 78);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 40;
            label5.Text = "Họ và tên:";
            // 
            // txtMaSoSinhVien
            // 
            txtMaSoSinhVien.Location = new Point(167, 30);
            txtMaSoSinhVien.Name = "txtMaSoSinhVien";
            txtMaSoSinhVien.Size = new Size(232, 31);
            txtMaSoSinhVien.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 38;
            label1.Text = "Mã số sinh viên:";
            // 
            // picHinhAnh
            // 
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Cursor = Cursors.Hand;
            picHinhAnh.Location = new Point(405, 30);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(150, 173);
            picHinhAnh.TabIndex = 37;
            picHinhAnh.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(toolStrip1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 242);
            panel3.Name = "panel3";
            panel3.Size = new Size(1165, 283);
            panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSoSinhVien, HoTen, GioiTinh, SoDienThoai, DiaChi, NgaySinh, TenLop, TenKhoa, HinhAnh });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1165, 249);
            dataGridView1.TabIndex = 0;
            // 
            // MaSoSinhVien
            // 
            MaSoSinhVien.DataPropertyName = "MSSV";
            MaSoSinhVien.HeaderText = "MSSV";
            MaSoSinhVien.MinimumWidth = 8;
            MaSoSinhVien.Name = "MaSoSinhVien";
            MaSoSinhVien.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "hoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 8;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "gioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 8;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "soDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 8;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "diaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "ngaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 8;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
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
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "hinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 8;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripTextBox1, btnTimKiem, toolStripSeparator1, btnNhapExcel, btnXuatExcel });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1165, 34);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(88, 29);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(150, 34);
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(69, 29);
            btnTimKiem.Text = "Tìm";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // btnNhapExcel
            // 
            btnNhapExcel.Image = (Image)resources.GetObject("btnNhapExcel.Image");
            btnNhapExcel.ImageTransparentColor = Color.Magenta;
            btnNhapExcel.Name = "btnNhapExcel";
            btnNhapExcel.Size = new Size(126, 29);
            btnNhapExcel.Text = "Nhập Excel";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Image = (Image)resources.GetObject("btnXuatExcel.Image");
            btnXuatExcel.ImageTransparentColor = Color.Magenta;
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(119, 29);
            btnXuatExcel.Text = "Xuất Excel";
            // 
            // frmThongTinSinhVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 603);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmThongTinSinhVien";
            Text = "frmThongTinSinhVien";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelGioiTinh.ResumeLayout(false);
            panelGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn92399213;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
        private Panel panel3;
        private Button btnLuu;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Panel panelGioiTinh;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private TextBox txtSoDienThoai;
        private Label label3;
        private Label label2;
        private TextBox txtHoTen;
        private Label label5;
        private TextBox txtMaSoSinhVien;
        private Label label1;
        private PictureBox picHinhAnh;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpNgaySinh;
        private Label label6;
        private TextBox txtDiaChi;
        private Label label4;
        private DataGridViewTextBoxColumn MaSoSinhVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn TenKhoa;
        private DataGridViewTextBoxColumn HinhAnh;
        private ComboBox cboTenKhoa;
        private ComboBox cboTenLop;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapExcel;
        private ToolStripButton btnXuatExcel;
    }
}
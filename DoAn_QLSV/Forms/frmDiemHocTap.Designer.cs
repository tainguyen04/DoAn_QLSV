namespace DoAn_QLSV.Forms
{
    partial class frmDiemHocTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemHocTap));
            panel1 = new Panel();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnHuyBo = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            cboMaSoSinhVien = new ComboBox();
            cboHocKy = new ComboBox();
            txtDrl = new TextBox();
            txtDht = new TextBox();
            cboXepLoai = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label8 = new Label();
            txtHoTen = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapExcel = new ToolStripButton();
            btnXuatExcel = new ToolStripButton();
            txtMonHoc = new TextBox();
            label2 = new Label();
            Id = new DataGridViewTextBoxColumn();
            MaSoSinhVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            tenHocKy = new DataGridViewTextBoxColumn();
            tenMonHoc = new DataGridViewTextBoxColumn();
            DiemHocTap = new DataGridViewTextBoxColumn();
            DiemHe4 = new DataGridViewTextBoxColumn();
            xepLoaiHocTap = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnHuyBo);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 78);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(619, 20);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(483, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(347, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(211, 21);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.Location = new Point(755, 20);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 34);
            btnHuyBo.TabIndex = 11;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1067, 210);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMonHoc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboMaSoSinhVien);
            groupBox1.Controls.Add(cboHocKy);
            groupBox1.Controls.Add(txtDrl);
            groupBox1.Controls.Add(txtDht);
            groupBox1.Controls.Add(cboXepLoai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1067, 210);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin điểm học tập";
            // 
            // cboMaSoSinhVien
            // 
            cboMaSoSinhVien.FormattingEnabled = true;
            cboMaSoSinhVien.Location = new Point(168, 24);
            cboMaSoSinhVien.Name = "cboMaSoSinhVien";
            cboMaSoSinhVien.Size = new Size(230, 33);
            cboMaSoSinhVien.TabIndex = 41;
            // 
            // cboHocKy
            // 
            cboHocKy.FormattingEnabled = true;
            cboHocKy.Location = new Point(168, 108);
            cboHocKy.Name = "cboHocKy";
            cboHocKy.Size = new Size(230, 33);
            cboHocKy.TabIndex = 40;
            // 
            // txtDrl
            // 
            txtDrl.Location = new Point(567, 105);
            txtDrl.Name = "txtDrl";
            txtDrl.Size = new Size(230, 31);
            txtDrl.TabIndex = 39;
            // 
            // txtDht
            // 
            txtDht.Location = new Point(567, 63);
            txtDht.Name = "txtDht";
            txtDht.Size = new Size(230, 31);
            txtDht.TabIndex = 38;
            // 
            // cboXepLoai
            // 
            cboXepLoai.FormattingEnabled = true;
            cboXepLoai.Location = new Point(168, 146);
            cboXepLoai.Name = "cboXepLoai";
            cboXepLoai.Size = new Size(230, 33);
            cboXepLoai.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 69);
            label5.Name = "label5";
            label5.Size = new Size(100, 28);
            label5.TabIndex = 25;
            label5.Text = "Họ và tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 21;
            label1.Text = "Mã số sinh viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 108);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 24;
            label4.Text = "Học kỳ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(12, 146);
            label8.Name = "label8";
            label8.Size = new Size(87, 28);
            label8.TabIndex = 31;
            label8.Text = "Xếp loại:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(168, 66);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.ReadOnly = true;
            txtHoTen.Size = new Size(230, 31);
            txtHoTen.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(428, 67);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 27;
            label6.Text = "Điểm học tập:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(428, 105);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 29;
            label7.Text = "Điểm hệ 4:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(toolStrip1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(1067, 291);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, MaSoSinhVien, HoTen, tenHocKy, tenMonHoc, DiemHocTap, DiemHe4, xepLoaiHocTap });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1067, 257);
            dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripTextBox1, btnTimKiem, toolStripSeparator1, btnNhapExcel, btnXuatExcel });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1067, 34);
            toolStrip1.TabIndex = 1;
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
            // txtMonHoc
            // 
            txtMonHoc.Location = new Point(567, 24);
            txtMonHoc.Name = "txtMonHoc";
            txtMonHoc.Size = new Size(230, 31);
            txtMonHoc.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(428, 28);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 42;
            label2.Text = "Môn học:";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
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
            // tenHocKy
            // 
            tenHocKy.DataPropertyName = "tenHocKy";
            tenHocKy.HeaderText = "Học Kỳ";
            tenHocKy.MinimumWidth = 8;
            tenHocKy.Name = "tenHocKy";
            tenHocKy.ReadOnly = true;
            // 
            // tenMonHoc
            // 
            tenMonHoc.DataPropertyName = "tenMonHoc";
            tenMonHoc.HeaderText = "Môn học";
            tenMonHoc.MinimumWidth = 8;
            tenMonHoc.Name = "tenMonHoc";
            tenMonHoc.ReadOnly = true;
            // 
            // DiemHocTap
            // 
            DiemHocTap.DataPropertyName = "diemHocTap";
            DiemHocTap.HeaderText = "Điểm học tập";
            DiemHocTap.MinimumWidth = 8;
            DiemHocTap.Name = "DiemHocTap";
            DiemHocTap.ReadOnly = true;
            // 
            // DiemHe4
            // 
            DiemHe4.DataPropertyName = "diemHe4";
            DiemHe4.HeaderText = "Điểm hệ 4";
            DiemHe4.MinimumWidth = 8;
            DiemHe4.Name = "DiemHe4";
            DiemHe4.ReadOnly = true;
            // 
            // xepLoaiHocTap
            // 
            xepLoaiHocTap.DataPropertyName = "xepLoaiHocTap";
            xepLoaiHocTap.HeaderText = "Xếp loại";
            xepLoaiHocTap.MinimumWidth = 8;
            xepLoaiHocTap.Name = "xepLoaiHocTap";
            xepLoaiHocTap.ReadOnly = true;
            // 
            // frmDiemHocTap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 579);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDiemHocTap";
            Text = "Điểm học tập";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnHuyBo;
        private GroupBox groupBox1;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label8;
        private TextBox txtHoTen;
        private Label label6;
        private Label label7;
        private ComboBox cboXepLoai;
        private TextBox txtDrl;
        private TextBox txtDht;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapExcel;
        private ToolStripButton btnXuatExcel;
        private ComboBox cboMaSoSinhVien;
        private ComboBox cboHocKy;
        private TextBox txtMonHoc;
        private Label label2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MaSoSinhVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn tenHocKy;
        private DataGridViewTextBoxColumn tenMonHoc;
        private DataGridViewTextBoxColumn DiemHocTap;
        private DataGridViewTextBoxColumn DiemHe4;
        private DataGridViewTextBoxColumn xepLoaiHocTap;
    }
}
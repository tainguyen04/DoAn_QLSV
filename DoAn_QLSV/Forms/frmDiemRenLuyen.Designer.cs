namespace DoAn_QLSV.Forms
{
    partial class frmDiemRenLuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemRenLuyen));
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            MaSoSinhVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            tenHocKy = new DataGridViewTextBoxColumn();
            DiemRenLuyen = new DataGridViewTextBoxColumn();
            xepLoaiRenLuyen = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapExcel = new ToolStripButton();
            btnXuatExcel = new ToolStripButton();
            txtHocKy = new TextBox();
            label5 = new Label();
            label1 = new Label();
            txtMaSoSinhVien = new TextBox();
            label4 = new Label();
            txtHoTen = new TextBox();
            groupBox1 = new GroupBox();
            cboXepLoai = new ComboBox();
            label8 = new Label();
            txtDrl = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            btnLuu = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 58;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, MaSoSinhVien, HoTen, tenHocKy, DiemRenLuyen, xepLoaiRenLuyen });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1053, 308);
            dataGridView1.TabIndex = 0;
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
            // DiemRenLuyen
            // 
            DiemRenLuyen.DataPropertyName = "diemRenLuyen";
            DiemRenLuyen.HeaderText = "Điểm rèn luyện";
            DiemRenLuyen.MinimumWidth = 8;
            DiemRenLuyen.Name = "DiemRenLuyen";
            DiemRenLuyen.ReadOnly = true;
            // 
            // xepLoaiRenLuyen
            // 
            xepLoaiRenLuyen.DataPropertyName = "xepLoaiRenLuyen";
            xepLoaiRenLuyen.HeaderText = "Xếp loại";
            xepLoaiRenLuyen.MinimumWidth = 8;
            xepLoaiRenLuyen.Name = "xepLoaiRenLuyen";
            xepLoaiRenLuyen.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(toolStrip1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(1053, 342);
            panel3.TabIndex = 5;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripTextBox1, btnTimKiem, toolStripSeparator1, btnNhapExcel, btnXuatExcel });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1053, 34);
            toolStrip1.TabIndex = 2;
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
            // txtHocKy
            // 
            txtHocKy.Location = new Point(168, 110);
            txtHocKy.Name = "txtHocKy";
            txtHocKy.Size = new Size(230, 31);
            txtHocKy.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 66);
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
            // txtMaSoSinhVien
            // 
            txtMaSoSinhVien.Location = new Point(168, 27);
            txtMaSoSinhVien.Name = "txtMaSoSinhVien";
            txtMaSoSinhVien.Size = new Size(230, 31);
            txtMaSoSinhVien.TabIndex = 33;
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
            // txtHoTen
            // 
            txtHoTen.Location = new Point(168, 66);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(230, 31);
            txtHoTen.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboXepLoai);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtDrl);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtHocKy);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaSoSinhVien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1053, 210);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin điểm rèn luyện";
            // 
            // cboXepLoai
            // 
            cboXepLoai.FormattingEnabled = true;
            cboXepLoai.Location = new Point(563, 66);
            cboXepLoai.Name = "cboXepLoai";
            cboXepLoai.Size = new Size(230, 33);
            cboXepLoai.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(413, 66);
            label8.Name = "label8";
            label8.Size = new Size(87, 28);
            label8.TabIndex = 41;
            label8.Text = "Xếp loại:";
            // 
            // txtDrl
            // 
            txtDrl.Location = new Point(563, 24);
            txtDrl.Name = "txtDrl";
            txtDrl.Size = new Size(230, 31);
            txtDrl.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(410, 28);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 39;
            label6.Text = "Điểm rèn luyện:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1053, 210);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 552);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 78);
            panel1.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(606, 22);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(334, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.Location = new Point(742, 22);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 34);
            btnHuyBo.TabIndex = 11;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(470, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(198, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // frmDiemRenLuyen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 630);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDiemRenLuyen";
            Text = "frmDiemRenLuyen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel3;
        private TextBox txtHocKy;
        private Label label5;
        private Label label1;
        private TextBox txtMaSoSinhVien;
        private Label label4;
        private TextBox txtHoTen;
        private GroupBox groupBox1;
        private Panel panel2;
        private Panel panel1;
        private Button btnLuu;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtDrl;
        private Label label6;
        private ComboBox cboXepLoai;
        private Label label8;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapExcel;
        private ToolStripButton btnXuatExcel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MaSoSinhVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn tenHocKy;
        private DataGridViewTextBoxColumn DiemRenLuyen;
        private DataGridViewTextBoxColumn xepLoaiRenLuyen;
    }
}
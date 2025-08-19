namespace DoAn_QLSV.Forms
{
    partial class frmHocKy
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
            panel1 = new Panel();
            btnLuu = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            button1 = new Button();
            btn123 = new Button();
            txtNamHoc = new TextBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtTenHocKy = new TextBox();
            txtMaHocKy = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            MaHocKy = new DataGridViewTextBoxColumn();
            TenHocKy = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapExcel = new ToolStripButton();
            btnXuatExcel = new ToolStripButton();
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
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn123);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 458);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 78);
            panel1.TabIndex = 8;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(525, 22);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(253, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.Location = new Point(661, 22);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 34);
            btnHuyBo.TabIndex = 16;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(389, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(117, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(2036, 22);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Hủy bỏ";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn123
            // 
            btn123.Anchor = AnchorStyles.Top;
            btn123.Location = new Point(2375, 22);
            btn123.Name = "btn123";
            btn123.Size = new Size(112, 34);
            btn123.TabIndex = 2;
            btn123.Text = "Hủy bỏ";
            btn123.UseVisualStyleBackColor = true;
            // 
            // txtNamHoc
            // 
            txtNamHoc.Location = new Point(163, 105);
            txtNamHoc.Name = "txtNamHoc";
            txtNamHoc.Size = new Size(213, 31);
            txtNamHoc.TabIndex = 67;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(890, 150);
            panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNamHoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTenHocKy);
            groupBox1.Controls.Add(txtMaHocKy);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(890, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin học kỳ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(7, 103);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 66;
            label1.Text = "Năm học:";
            // 
            // txtTenHocKy
            // 
            txtTenHocKy.Location = new Point(163, 68);
            txtTenHocKy.Name = "txtTenHocKy";
            txtTenHocKy.Size = new Size(213, 31);
            txtTenHocKy.TabIndex = 65;
            // 
            // txtMaHocKy
            // 
            txtMaHocKy.Location = new Point(163, 30);
            txtMaHocKy.Name = "txtMaHocKy";
            txtMaHocKy.Size = new Size(213, 31);
            txtMaHocKy.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(7, 66);
            label7.Name = "label7";
            label7.Size = new Size(107, 28);
            label7.TabIndex = 63;
            label7.Text = "Tên học kỳ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(7, 27);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 62;
            label8.Text = "Mã học kỳ:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(toolStrip1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(890, 308);
            panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 58;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaHocKy, TenHocKy, NamHoc });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(890, 274);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // MaHocKy
            // 
            MaHocKy.DataPropertyName = "maHocKy";
            MaHocKy.HeaderText = "Mã học kỳ";
            MaHocKy.MinimumWidth = 8;
            MaHocKy.Name = "MaHocKy";
            MaHocKy.ReadOnly = true;
            // 
            // TenHocKy
            // 
            TenHocKy.DataPropertyName = "tenHocKy";
            TenHocKy.HeaderText = "Tên học kỳ";
            TenHocKy.MinimumWidth = 8;
            TenHocKy.Name = "TenHocKy";
            TenHocKy.ReadOnly = true;
            // 
            // NamHoc
            // 
            NamHoc.DataPropertyName = "namHoc";
            NamHoc.HeaderText = "Năm học";
            NamHoc.MinimumWidth = 8;
            NamHoc.Name = "NamHoc";
            NamHoc.ReadOnly = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhapExcel, btnXuatExcel });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(890, 34);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(88, 29);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(150, 34);
            txtTuKhoa.KeyDown += txtTuKhoa_KeyDown;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources.view;
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(69, 29);
            btnTimKiem.Text = "Tìm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // btnNhapExcel
            // 
            btnNhapExcel.Image = Properties.Resources.import1;
            btnNhapExcel.ImageTransparentColor = Color.Magenta;
            btnNhapExcel.Name = "btnNhapExcel";
            btnNhapExcel.Size = new Size(126, 29);
            btnNhapExcel.Text = "Nhập Excel";
            btnNhapExcel.Click += btnNhapExcel_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Image = Properties.Resources.export1;
            btnXuatExcel.ImageTransparentColor = Color.Magenta;
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(119, 29);
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // frmHocKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 536);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmHocKy";
            Text = "frmHocKy";
            Load += frmHocKy_Load;
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
        private Button button1;
        private Button btn123;
        private TextBox txtNamHoc;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtTenHocKy;
        private TextBox txtMaHocKy;
        private Label label7;
        private Label label8;
        private Button btnLuu;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaHocKy;
        private DataGridViewTextBoxColumn TenHocKy;
        private DataGridViewTextBoxColumn NamHoc;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapExcel;
        private ToolStripButton btnXuatExcel;
    }
}
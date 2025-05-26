namespace DoAn_QLSV.Forms
{
    partial class frmMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonHoc));
            panel1 = new Panel();
            btnLuu = new Button();
            btnSua = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            txtMaMonHoc = new TextBox();
            label1 = new Label();
            txtTenMonHoc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numSoTinChi = new NumericUpDown();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhapExcel = new ToolStripButton();
            btnXuatExcel = new ToolStripButton();
            dataGridView1 = new DataGridView();
            maMonHoc = new DataGridViewTextBoxColumn();
            tenMonHoc = new DataGridViewTextBoxColumn();
            soTinChi = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTinChi).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 495);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 88);
            panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(554, 27);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(282, 27);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 22;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.Location = new Point(690, 27);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 34);
            btnHuyBo.TabIndex = 21;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(418, 27);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(146, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 192);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(toolStrip1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(949, 303);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numSoTinChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenMonHoc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaMonHoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(949, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin môn học";
            // 
            // txtMaMonHoc
            // 
            txtMaMonHoc.Location = new Point(146, 30);
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(175, 31);
            txtMaMonHoc.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 2;
            label1.Text = "Mã môn học:";
            // 
            // txtTenMonHoc
            // 
            txtTenMonHoc.Location = new Point(146, 77);
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(175, 31);
            txtTenMonHoc.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(15, 77);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 4;
            label2.Text = "Tên môn học:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(15, 127);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 6;
            label3.Text = "Số tín chỉ:";
            // 
            // numSoTinChi
            // 
            numSoTinChi.Location = new Point(146, 127);
            numSoTinChi.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numSoTinChi.Name = "numSoTinChi";
            numSoTinChi.Size = new Size(175, 31);
            numSoTinChi.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripTextBox1, btnTimKiem, toolStripSeparator1, btnNhapExcel, btnXuatExcel });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(949, 34);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 58;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maMonHoc, tenMonHoc, soTinChi });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(949, 269);
            dataGridView1.TabIndex = 3;
            // 
            // maMonHoc
            // 
            maMonHoc.HeaderText = "Mã môn học";
            maMonHoc.MinimumWidth = 8;
            maMonHoc.Name = "maMonHoc";
            maMonHoc.ReadOnly = true;
            // 
            // tenMonHoc
            // 
            tenMonHoc.HeaderText = "Tên môn học";
            tenMonHoc.MinimumWidth = 8;
            tenMonHoc.Name = "tenMonHoc";
            tenMonHoc.ReadOnly = true;
            // 
            // soTinChi
            // 
            soTinChi.HeaderText = "Số tín chỉ";
            soTinChi.MinimumWidth = 8;
            soTinChi.Name = "soTinChi";
            soTinChi.ReadOnly = true;
            // 
            // frmMonHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 583);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMonHoc";
            Text = "frmMonHoc";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTinChi).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLuu;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox txtTenMonHoc;
        private Label label2;
        private TextBox txtMaMonHoc;
        private Label label1;
        private NumericUpDown numSoTinChi;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn maMonHoc;
        private DataGridViewTextBoxColumn tenMonHoc;
        private DataGridViewTextBoxColumn soTinChi;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhapExcel;
        private ToolStripButton btnXuatExcel;
    }
}
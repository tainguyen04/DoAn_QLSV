namespace DoAn_QLSV.Forms
{
    partial class frmKhoa
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
            btnHuyBo1vvvvvvvv = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtTenKhoa = new TextBox();
            txtMaKhoa = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            MaKhoa = new DataGridViewTextBoxColumn();
            TenKhoa = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Controls.Add(btnHuyBo1vvvvvvvv);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 495);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 78);
            panel1.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Location = new Point(612, 22);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Location = new Point(340, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.Location = new Point(748, 22);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 34);
            btnHuyBo.TabIndex = 11;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Location = new Point(476, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.Location = new Point(204, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(1277, 22);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Hủy bỏ";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo1vvvvvvvv
            // 
            btnHuyBo1vvvvvvvv.Anchor = AnchorStyles.Top;
            btnHuyBo1vvvvvvvv.BackColor = Color.IndianRed;
            btnHuyBo1vvvvvvvv.Location = new Point(1616, 22);
            btnHuyBo1vvvvvvvv.Name = "btnHuyBo1vvvvvvvv";
            btnHuyBo1vvvvvvvv.Size = new Size(112, 34);
            btnHuyBo1vvvvvvvv.TabIndex = 2;
            btnHuyBo1vvvvvvvv.Text = "Hủy bỏ";
            btnHuyBo1vvvvvvvv.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1065, 135);
            panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenKhoa);
            groupBox1.Controls.Add(txtMaKhoa);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1065, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khoa";
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(163, 68);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(213, 31);
            txtTenKhoa.TabIndex = 65;
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(163, 30);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(213, 31);
            txtMaKhoa.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(7, 66);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 63;
            label7.Text = "Tên khoa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(7, 27);
            label8.Name = "label8";
            label8.Size = new Size(92, 28);
            label8.TabIndex = 62;
            label8.Text = "Mã khoa:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(1065, 360);
            panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 58;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaKhoa, TenKhoa });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1065, 360);
            dataGridView1.TabIndex = 0;
            // 
            // MaKhoa
            // 
            MaKhoa.DataPropertyName = "maKhoa";
            MaKhoa.HeaderText = "Mã khoa";
            MaKhoa.MinimumWidth = 8;
            MaKhoa.Name = "MaKhoa";
            MaKhoa.ReadOnly = true;
            // 
            // TenKhoa
            // 
            TenKhoa.DataPropertyName = "tenKhoa";
            TenKhoa.HeaderText = "Tên khoa";
            TenKhoa.MinimumWidth = 8;
            TenKhoa.Name = "TenKhoa";
            TenKhoa.ReadOnly = true;
            // 
            // frmKhoa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 573);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmKhoa";
            Text = "frmKhoa";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnHuyBo1vvvvvvvv;
        private Button btnLuu;
        private Button btnSua;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox txtTenKhoa;
        private TextBox txtMaKhoa;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaKhoa;
        private DataGridViewTextBoxColumn TenKhoa;
    }
}
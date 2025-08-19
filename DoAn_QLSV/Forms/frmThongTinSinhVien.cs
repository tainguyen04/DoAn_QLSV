using DoAn_QLSV.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlugGenerator;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
namespace DoAn_QLSV.Forms
{
    public partial class frmThongTinSinhVien : Form
    {
        QLSVDbContext context = new QLSVDbContext();
        string ma;
        BindingSource bsSV = new BindingSource();
        string imageName = "no-image.jpg";
        string imageFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Images");

        public frmThongTinSinhVien()
        {
            InitializeComponent();
        }
        private void LayKhoaVaoComboBox()
        {
            cboTenKhoa.DataSource = context.Khoa.ToList();
            cboTenKhoa.DisplayMember = "tenKhoa";
            cboTenKhoa.ValueMember = "maKhoa";
        }
        public void BindGioiTinh(BindingSource sv, RadioButton rdbNam, RadioButton rdbNu)
        {
            // rdbNam - giới tính "Nam"
            rdbNam.DataBindings.Clear();
            var bindingNam = new Binding("Checked", sv, "gioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            bindingNam.Format += (s, e) =>
            {
                e.Value = (e.Value != null && e.Value.ToString() == "Nam");
            };
            bindingNam.Parse += (s, e) =>
            {
                if ((bool)e.Value == true) e.Value = "Nam";
            };
            rdbNam.DataBindings.Add(bindingNam);

            // rdbNu - giới tính "Nữ"
            rdbNu.DataBindings.Clear();
            var bindingNu = new Binding("Checked", sv, "gioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);
            bindingNu.Format += (s, e) =>
            {
                e.Value = (e.Value != null && e.Value.ToString() == "Nữ");
            };
            bindingNu.Parse += (s, e) =>
            {
                if ((bool)e.Value == true) e.Value = "Nữ";
            };
            rdbNu.DataBindings.Add(bindingNu);
        }

        private void frmThongTinSinhVien_Load(object sender, EventArgs e)
        {
            LayKhoaVaoComboBox();
            dataGridView1.AutoGenerateColumns = false;
            var sv = context.ThongTinSinhVien.Select(r => new
            {
                r.MSSV,
                r.hoTen,
                r.gioiTinh,
                r.soDienThoai,
                r.diaChi,
                r.ngaySinh,
                r.Lop.tenLop,
                r.lopID,
                r.Lop.Khoa.tenKhoa,
                r.Lop.Khoa.maKhoa,
                r.hinhAnh
            }).ToList();
            bsSV.DataSource = sv;
            dataGridView1.DataSource = bsSV;

            txtMaSoSinhVien.DataBindings.Clear();
            txtMaSoSinhVien.DataBindings.Add("Text", bsSV, "MSSV", false, DataSourceUpdateMode.Never);

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", bsSV, "hoTen", false, DataSourceUpdateMode.Never);

            BindGioiTinh(bsSV, rdbNam, rdbNu);

            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", bsSV, "soDienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bsSV, "diaChi", false, DataSourceUpdateMode.Never);

            cboTenLop.DataBindings.Clear();
            cboTenLop.DataBindings.Add("SelectedValue", bsSV, "lopID", false, DataSourceUpdateMode.Never);

            cboTenKhoa.DataBindings.Clear();
            cboTenKhoa.DataBindings.Add("SelectedValue", bsSV, "maKhoa", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bsSV, "hinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ma = "";
            txtMaSoSinhVien.Text = "";
            txtHoTen.Text = "";
            rdbNam.Text = "";
            rdbNu.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cboTenLop.Text = "";
            cboTenKhoa.Text = "";
            txtMaSoSinhVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                txtMaSoSinhVien.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa sinh viên " + txtHoTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                    ThongTinSinhVien sv = context.ThongTinSinhVien.Find(ma)!;
                    context.ThongTinSinhVien.Remove(sv);
                    context.SaveChanges();
                    frmThongTinSinhVien_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSoSinhVien.Text))
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                MessageBox.Show("Vui lòng nhập tên sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!rdbNam.Checked && !rdbNu.Checked)
                MessageBox.Show("Vui lòng chọn giới tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboTenLop.SelectedValue == null)
                MessageBox.Show("Vui lòng chọn lớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboTenKhoa.SelectedValue == null)
                MessageBox.Show("Vui lòng chọn khoa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dtpNgaySinh.Value > DateTime.Now)
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ma == "")
            {
                ThongTinSinhVien sv = new ThongTinSinhVien();
                sv.MSSV = txtMaSoSinhVien.Text;
                sv.hoTen = txtHoTen.Text;
                sv.gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                sv.soDienThoai = txtSoDienThoai.Text;
                sv.diaChi = txtDiaChi.Text;
                sv.ngaySinh = dtpNgaySinh.Value;
                sv.lopID = cboTenLop.SelectedValue?.ToString()!;
                context.ThongTinSinhVien.Add(sv);
                context.SaveChanges();
            }
            else
            {
                ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                ThongTinSinhVien sv = context.ThongTinSinhVien.Find(ma)!;
                sv.MSSV = txtMaSoSinhVien.Text;
                sv.hoTen = txtHoTen.Text;
                sv.gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
                sv.soDienThoai = txtSoDienThoai.Text;
                sv.diaChi = txtDiaChi.Text;
                sv.ngaySinh = dtpNgaySinh.Value;
                sv.lopID = cboTenLop.SelectedValue?.ToString()!;
                context.ThongTinSinhVien.Update(sv);
                context.SaveChanges();
            }
            frmThongTinSinhVien_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmThongTinSinhVien_Load(sender, e);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "hinhAnh")
            {
                string imagePath = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    image = new Bitmap(image, 24, 24);
                    e.Value = image;
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sinh viên";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);

                // Lưu tên file hình vào biến toàn cục 
                imageName = fileName.GenerateSlug() + ext;

                // Sao chép file hình vào thư mục Images 
                string fileSavePath = Path.Combine(imageFolder, imageName);
                File.Copy(openFileDialog.FileName, fileSavePath, true);

                // Hiện hình ảnh đã chọn lên PictureBox 
                picHinhAnh.Image = Image.FromFile(fileSavePath);
            }
        }

        private void cboTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoa = cboTenKhoa.SelectedValue?.ToString()!;

            var dsLop = context.Lop.Where(r => r.maKhoa == maKhoa).ToList();

            cboTenLop.DataSource = dsLop;
            cboTenLop.DisplayMember = "tenLop";
            cboTenLop.ValueMember = "maLop";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var sv = context.ThongTinSinhVien.Select(r => new
            {
                r.MSSV,
                r.hoTen,
                r.gioiTinh,
                r.soDienThoai,
                r.diaChi,
                r.ngaySinh,
                r.Lop.tenLop,
                r.lopID,
                r.Lop.Khoa.tenKhoa,
                r.Lop.Khoa.maKhoa,
                r.hinhAnh
            })
            .Where(r => r.MSSV.Contains(txtTuKhoa.Text) ||
                        r.hoTen.Contains(txtTuKhoa.Text) ||
                        r.soDienThoai.Contains(txtTuKhoa.Text) ||
                        r.tenLop.Contains(txtTuKhoa.Text) ||
                        r.tenKhoa.Contains(txtTuKhoa.Text)
            )
            .ToList();
            dataGridView1.DataSource = sv;
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        DataTable table = new DataTable();

                        //Đọc sheet1 và lưu dữ liệu vào datatable tạm
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            //đọc dòng tiêu đề
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Columns.Add(cell.Value.ToString());
                                    firstRow = false;
                                }
                            }
                            else// đọc các dòng nội dung
                            {
                                table.Rows.Add();
                                int cellindex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellindex] = cell.Value.ToString();
                                    cellindex++;
                                }
                            }
                        }
                        //đọc dữ liệu datatable vào CSDL
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                ThongTinSinhVien sv = new ThongTinSinhVien();
                                sv.MSSV = r["MSSV"].ToString() ?? "N/A";
                                sv.hoTen = r["hoTen"].ToString() ?? "N/A";
                                sv.gioiTinh = r["gioiTinh"].ToString() ?? "N/A";
                                sv.soDienThoai = r["soDienThoai"].ToString() ?? "N/A";
                                sv.diaChi = r["diaChi"].ToString() ?? "N/A";
                                sv.ngaySinh = DateTime.Parse( r["ngaySinh"].ToString() ?? "N/A");
                                sv.hinhAnh = r["hinhAnh"].ToString() ?? "N/A";

                                sv.lopID = r["maKhoa"].ToString() ?? "N/A";
                                context.ThongTinSinhVien.Add(sv);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmThongTinSinhVien_Load(sender, e);
                        }
                        if (firstRow)
                        {
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel |*.xls;*.xlsx";
            saveFileDialog.FileName = "ThongTinSinhVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[11]
                    {
                        new DataColumn("MSSV",typeof(string)),
                        new DataColumn("hoTen",typeof(string)),
                        new DataColumn("gioiTinh",typeof(string)),
                        new DataColumn("soDienThoai",typeof(string)),
                        new DataColumn("diaChi",typeof(string)),
                        new DataColumn("ngaySinh",typeof(DateTime)),
                        new DataColumn("maLop",typeof(string)),
                        new DataColumn("tenLop",typeof(string)),
                        new DataColumn("maKhoa",typeof(string)),
                        new DataColumn("tenKhoa",typeof(string)),
                        new DataColumn("hinhAnh",typeof(string)),
                    });

                    var sv = context.ThongTinSinhVien
                                    .Include( r=> r.Lop)
                                        .ThenInclude( r=> r.Khoa)
                                    .ToList();
                    if (sv != null)
                    {
                        foreach (var p in sv)
                            table.Rows.Add(p.MSSV,
                                           p.hoTen,
                                           p.gioiTinh,
                                           p.soDienThoai,
                                           p.diaChi,
                                           p.ngaySinh,
                                           p.lopID,
                                           p.Lop.tenLop,
                                           p.Lop.Khoa.maKhoa,
                                           p.Lop.Khoa.tenKhoa,
                                           p.hinhAnh
                                           );
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "ThongTinSinhVien");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTimKiem_Click(sender, e);
        }
    }
}

using ClosedXML.Excel;
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

namespace DoAn_QLSV.Forms
{
    public partial class frmDiemHocTap : Form
    {
        QLSVDbContext context = new QLSVDbContext();
        int ma;
        public frmDiemHocTap()
        {
            InitializeComponent();

        }
        public void LayNamHocVaoComboBox()
        {
            var dsNamHoc = context.HocKy.Select(r => r.namHoc).Distinct().ToList();
            cboNamHoc.DataSource = dsNamHoc;
        }
        public void LaySinhVienVaoComboBox()
        {
            cboMaSoSinhVien.DataSource = context.ThongTinSinhVien.ToList();
            cboMaSoSinhVien.DisplayMember = "MSSV";
            cboMaSoSinhVien.ValueMember = "MSSV";
        }
        public void LayMonHocVaoComboBox()
        {
            cboMonHoc.DataSource = context.MonHoc.ToList();
            cboMonHoc.DisplayMember = "tenMonHoc";
            cboMonHoc.ValueMember = "maMonHoc";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDiemHocTap_Load(object sender, EventArgs e)
        {
            LaySinhVienVaoComboBox();
            LayMonHocVaoComboBox();
            LayNamHocVaoComboBox();
            dataGridView1.AutoGenerateColumns = false;
            var dht = context.DiemHocTap.Select(r => new
            {
                r.id,
                r.MSSV,
                hoTen = r.SinhVien.hoTen,
                r.HocKy.tenHocKy,
                r.maHocKy,
                r.HocKy.namHoc,
                r.MonHoc.tenMonHoc,
                r.maMonHoc,
                r.diemHocTap,
                r.diemHe4,
                r.xepLoaiHocTap
            }).ToList();
            dataGridView1.DataSource = dht;

            cboMaSoSinhVien.DataBindings.Clear();
            cboMaSoSinhVien.DataBindings.Add("SelectedValue", dht, "MSSV", false, DataSourceUpdateMode.Never);

            cboHocKy.DataBindings.Clear();
            cboHocKy.DataBindings.Add("SelectedValue", dht, "maHocKy", false, DataSourceUpdateMode.Never);
            //thay đổi họ tên theo MSSV
            cboMaSoSinhVien.SelectedIndexChanged += cboMaSoSinhVien_SelectedIndexChanged;

            cboNamHoc.DataBindings.Clear();
            cboNamHoc.DataBindings.Add("SelectedItem", dht, "namHoc", false, DataSourceUpdateMode.Never);

            cboMonHoc.DataBindings.Clear();
            cboMonHoc.DataBindings.Add("SelectedValue", dht, "maMonHoc", false, DataSourceUpdateMode.Never);

            numDiemHocTap.DataBindings.Clear();
            numDiemHocTap.DataBindings.Add("Value", dht, "diemHocTap", false, DataSourceUpdateMode.Never);

            numDiemHe4.DataBindings.Clear();
            numDiemHe4.DataBindings.Add("Value", dht, "diemHe4", false, DataSourceUpdateMode.Never);

            cboXepLoai.DataBindings.Clear();
            cboXepLoai.DataBindings.Add("SelectedItem", dht, "xepLoaiHocTap", false, DataSourceUpdateMode.Never);

        }

        private void cboMaSoSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSoSinhVien.SelectedValue != null)
            {
                String mssv = cboMaSoSinhVien.SelectedValue.ToString()!;
                var sv = context.ThongTinSinhVien.FirstOrDefault(r => r.MSSV == mssv);
                if (sv != null)
                {
                    txtHoTen.Text = sv.hoTen;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ma = 0;
            cboMaSoSinhVien.Text = "";
            txtHoTen.Text = "";
            cboHocKy.Text = "";
            cboMonHoc.Text = "";
            numDiemHocTap.Value = 0;
            numDiemHe4.Value = 0;
            cboNamHoc.Text = "";
            numDiemHocTap.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ma = Convert.ToInt32(dataGridView1.CurrentRow?.Cells[0].Value?.ToString())!;
                numDiemHocTap.Focus();
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
                if (MessageBox.Show("Xác nhận xóa điểm môn " + cboMonHoc.Text + "của " + txtHoTen.Text + " ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ma = Convert.ToInt32(dataGridView1.CurrentRow?.Cells[0].Value?.ToString())!;
                    DiemHocTap dht = context.DiemHocTap.Find(ma)!;
                    context.DiemHocTap.Remove(dht);
                    context.SaveChanges();
                    frmDiemHocTap_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboMaSoSinhVien.Text))
                MessageBox.Show("Vui lòng chọn mã sinh viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHocKy.Text))
                MessageBox.Show("Vui lòng chọn học kỳ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboMonHoc.Text))
                MessageBox.Show("Vui lòng chọn môn học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDiemHocTap.Value < 0 || numDiemHocTap.Value > 11)
                MessageBox.Show("Vui lòng đúng điểm(gh:1->10).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDiemHe4.Value < 0 || numDiemHe4.Value > 5)
                MessageBox.Show("Vui lòng đúng điểm(gh:1->4).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboNamHoc.Text))
                MessageBox.Show("Vui lòng chọn loại học lực.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var mssv = cboMaSoSinhVien.SelectedValue?.ToString();
            var maHocKy = cboHocKy.SelectedValue?.ToString();
            var maMonHoc = cboMonHoc.SelectedValue?.ToString();
            var namHoc = cboNamHoc.SelectedItem?.ToString();

            if (ma == 0)
            {
                var ktTonTai = context.DiemHocTap.FirstOrDefault(r => r.MSSV == mssv && r.maHocKy == maHocKy && r.maMonHoc == maMonHoc && r.HocKy.namHoc == namHoc);
                if (ktTonTai == null)
                {
                    DiemHocTap dht = new DiemHocTap();
                    dht.MSSV = cboMaSoSinhVien.SelectedValue?.ToString()!;
                    dht.maHocKy = cboHocKy.SelectedValue?.ToString()!;
                    dht.maMonHoc = cboMonHoc.SelectedValue?.ToString()!;
                    dht.diemHocTap = (float)numDiemHocTap.Value;
                    dht.diemHe4 = (float)numDiemHe4.Value;
                    dht.xepLoaiHocTap = cboXepLoai.SelectedItem?.ToString()!;
                    context.DiemHocTap.Add(dht);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Sinh viên này đã có điểm học tập của môn học " + cboMonHoc.Text + "cho " + cboHocKy.Text + " năm học " + cboNamHoc.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DiemHocTap dht = context.DiemHocTap.Find(ma)!;
                dht.MSSV = cboMaSoSinhVien.SelectedValue?.ToString()!;
                dht.maHocKy = cboHocKy.SelectedValue?.ToString()!;
                dht.maMonHoc = cboMonHoc.SelectedValue?.ToString()!;
                dht.diemHocTap = (float)numDiemHocTap.Value;
                dht.diemHe4 = (float)numDiemHe4.Value;
                dht.xepLoaiHocTap = cboXepLoai.SelectedItem?.ToString()!;
                context.DiemHocTap.Update(dht);
                context.SaveChanges();
            }
            frmDiemHocTap_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmDiemHocTap_Load(sender, e);
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string namHoc = cboNamHoc.SelectedValue?.ToString()!;

            var dsHocKy = context.HocKy.Where(hk => hk.namHoc == namHoc).ToList();

            cboHocKy.DataSource = dsHocKy;
            cboHocKy.DisplayMember = "tenHocKy";
            cboHocKy.ValueMember = "maHocKy";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var dht = context.DiemHocTap.Select(r => new
            {
                r.id,
                r.MSSV,
                hoTen = r.SinhVien.hoTen,
                r.HocKy.tenHocKy,
                r.maHocKy,
                r.HocKy.namHoc,
                r.MonHoc.tenMonHoc,
                r.maMonHoc,
                r.diemHocTap,
                r.diemHe4,
                r.xepLoaiHocTap
            })
            .Where(r => r.MSSV.Contains(txtTuKhoa.Text) ||
                        r.tenMonHoc.Contains(txtTuKhoa.Text) ||
                        r.tenHocKy.Contains(txtTuKhoa.Text)
            )
            .ToList();
            dataGridView1.DataSource = dht;
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
                                DiemHocTap dht = new DiemHocTap();
                                dht.MSSV =r["MSSV"].ToString() ?? "N/A";
                                
                                dht.maHocKy = r["maHocKy"].ToString() ?? "N/A";
                                dht.maMonHoc = r["maMonHoc"].ToString() ?? "N/A";
                                dht.diemHocTap = float.Parse(r["diemHocTap"].ToString()!);
                                dht.diemHe4 = float.Parse(r["diemHe4"].ToString()!);
                                dht.xepLoaiHocTap = r["xepLoaiHocTap"].ToString() ?? "N/A";
                                context.DiemHocTap.Add(dht);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDiemHocTap_Load(sender, e);
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
            saveFileDialog.FileName = "DiemHocTap_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[11]
                    {
                        new DataColumn("id",typeof(int)),
                        new DataColumn("MSSV",typeof(string)),
                        new DataColumn("hoTen",typeof(string)),
                        new DataColumn("maHocKy",typeof(string)),
                        new DataColumn("tenHocKy",typeof(string)),
                        new DataColumn("namHoc",typeof(string)),
                        new DataColumn("maMonHoc",typeof(string)),
                        new DataColumn("tenMonHoc",typeof(string)),
                        new DataColumn("diemHocTap",typeof(float)),
                        new DataColumn("diemHe4",typeof(float)),
                        new DataColumn("xepLoaiHocTap",typeof(string))
                    });

                    var dht = context.DiemHocTap.ToList();
                    if (dht != null)
                    {
                        foreach (var p in dht)
                            table.Rows.Add(p.id, 
                                           p.MSSV,
                                           p.SinhVien.hoTen,
                                           p.maHocKy,
                                           p.HocKy.tenHocKy,
                                           p.HocKy.namHoc,
                                           p.maMonHoc,
                                           p.MonHoc.tenMonHoc,
                                           p.diemHocTap,
                                           p.diemHe4,
                                           p.xepLoaiHocTap
                                           );
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "DiemHocTap");
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

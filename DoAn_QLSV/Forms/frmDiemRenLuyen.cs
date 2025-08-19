using ClosedXML.Excel;
using DoAn_QLSV.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmDiemRenLuyen : Form
    {
        QLSVDbContext context = new QLSVDbContext();
        int ma;
        public frmDiemRenLuyen()
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
        private void frmDiemRenLuyen_Load(object sender, EventArgs e)
        {
            LayNamHocVaoComboBox();
            LaySinhVienVaoComboBox();
            dataGridView1.AutoGenerateColumns = false;
            var drl = context.DiemRenLuyen.Select(r => new
            {
                r.id,
                r.MSSV,
                r.SinhVien.hoTen,
                r.maHocKy,
                r.HocKy.tenHocKy,
                r.HocKy.namHoc,
                r.diemRenLuyen,
                r.xepLoaiRenLuyen
            }).ToList();
            dataGridView1.DataSource = drl;

            cboMaSoSinhVien.DataBindings.Clear();
            cboMaSoSinhVien.DataBindings.Add("SelectedValue", drl, "MSSV", false, DataSourceUpdateMode.Never);

            //thay đổi họ tên theo MSSV
            cboMaSoSinhVien.SelectedIndexChanged += cboMaSoSinhVien_SelectedIndexChanged!;

            cboHocKy.DataBindings.Clear();
            cboHocKy.DataBindings.Add("SelectedValue", drl, "maHocKy", false, DataSourceUpdateMode.Never);

            cboNamHoc.DataBindings.Clear();
            cboNamHoc.DataBindings.Add("SelectedItem", drl, "namHoc", false, DataSourceUpdateMode.Never);

            numDiemRenLuyen.DataBindings.Clear();
            numDiemRenLuyen.DataBindings.Add("Value", drl, "diemRenLuyen", false, DataSourceUpdateMode.Never);

            cboXepLoai.DataBindings.Clear();
            cboXepLoai.DataBindings.Add("SelectedItem", drl, "xepLoaiRenLuyen", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ma = 0;
            cboMaSoSinhVien.Text = "";
            txtHoTen.Text = "";
            cboHocKy.Text = "";
            numDiemRenLuyen.Value = 0;
            cboXepLoai.Text = "";
            numDiemRenLuyen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ma = Convert.ToInt32(dataGridView1.CurrentRow?.Cells[0].Value?.ToString())!;
                numDiemRenLuyen.Focus();
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
                if (MessageBox.Show("Xác nhận xóa điểm rèn luyện của " + txtHoTen.Text + " ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ma = Convert.ToInt32(dataGridView1.CurrentRow?.Cells[0].Value?.ToString())!;
                    DiemRenLuyen drl = context.DiemRenLuyen.Find(ma)!;
                    context.DiemRenLuyen.Remove(drl);
                    context.SaveChanges();
                    frmDiemRenLuyen_Load(sender, e);
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

            else if (numDiemRenLuyen.Value <= 0 || numDiemRenLuyen.Value > 101)
                MessageBox.Show("Vui lòng đúng điểm(gh:1->100).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrWhiteSpace(cboXepLoai.Text))
                MessageBox.Show("Vui lòng chọn loại rèn luyện.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var mssv = cboMaSoSinhVien.SelectedValue?.ToString();
            var maHocKy = cboHocKy.SelectedValue?.ToString();
            var namHoc = cboNamHoc.SelectedItem?.ToString();

            if (ma == 0)
            {
                var ktTonTai = context.DiemRenLuyen.FirstOrDefault(r => r.MSSV == mssv && r.maHocKy == maHocKy && r.HocKy.namHoc == namHoc);
                if (ktTonTai == null)
                {
                    DiemRenLuyen drl = new DiemRenLuyen();
                    drl.MSSV = mssv;
                    drl.maHocKy = maHocKy;
                    drl.diemRenLuyen = (float)numDiemRenLuyen.Value;
                    drl.xepLoaiRenLuyen = cboXepLoai.SelectedItem?.ToString()!;
                    context.DiemRenLuyen.Add(drl);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Sinh viên này đã có điểm rèn luyện cho " + cboHocKy.Text + " năm học " + cboNamHoc.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                ma = Convert.ToInt32(dataGridView1.CurrentRow?.Cells[0].Value?.ToString())!;
                var ktTonTai = context.DiemRenLuyen.FirstOrDefault(r => r.MSSV == mssv && r.maHocKy == maHocKy && r.id != ma);
                if (ktTonTai == null)
                {
                    DiemRenLuyen drl = context.DiemRenLuyen.Find(ma)!;
                    drl.MSSV = mssv;
                    drl.maHocKy = maHocKy;
                    drl.diemRenLuyen = (float)numDiemRenLuyen.Value;
                    drl.xepLoaiRenLuyen = cboXepLoai.SelectedItem?.ToString()!;
                    context.DiemRenLuyen.Update(drl);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Sinh viên này đã có điểm rèn luyện cho học kỳ đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            frmDiemRenLuyen_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmDiemRenLuyen_Load(sender, e);
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
            var drl = context.DiemRenLuyen.Select(r => new
            {
                r.id,
                r.MSSV,
                hoTen = r.SinhVien.hoTen,
                r.maHocKy,
                r.HocKy.tenHocKy,
                r.HocKy.namHoc,
                r.diemRenLuyen,
                r.xepLoaiRenLuyen
            })
            .Where(r => r.MSSV.Contains(txtTuKhoa.Text) ||
                        r.hoTen.Contains(txtTuKhoa.Text) ||
                        r.tenHocKy.Contains(txtTuKhoa.Text) ||
                        r.namHoc.Contains(txtTuKhoa.Text)
            )
            .ToList();
            dataGridView1.DataSource = drl;
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
                                DiemRenLuyen drl = new DiemRenLuyen();
                                drl.MSSV = r["MSSV"].ToString() ?? "N/A";

                                drl.maHocKy = r["maHocKy"].ToString() ?? "N/A";
                                
                                drl.diemRenLuyen = float.Parse(r["diemRenLuyen"].ToString()!);
                                
                                drl.xepLoaiRenLuyen = r["xepLoaiRenLuyen"].ToString() ?? "N/A";
                                context.DiemRenLuyen.Add(drl);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDiemRenLuyen_Load(sender, e);
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
            saveFileDialog.FileName = "DiemRenLuyen_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[8]
                    {
                        new DataColumn("id",typeof(int)),
                        new DataColumn("MSSV",typeof(string)),
                        new DataColumn("hoTen",typeof(string)),
                        new DataColumn("maHocKy",typeof(string)),
                        new DataColumn("tenHocKy",typeof(string)),
                        new DataColumn("namHoc",typeof(string)),
                        new DataColumn("diemRenLuyen",typeof(float)),
                        new DataColumn("xepLoaiRenLuyen",typeof(string))
                    });

                    var drl = context.DiemRenLuyen
                                     .Include(r => r.HocKy)
                                     .Include( r=> r.SinhVien)
                                     .ToList();
                    if (drl != null)
                    {
                        foreach (var p in drl)
                            table.Rows.Add(p.id,
                                           p.MSSV,
                                           p.SinhVien.hoTen,
                                           p.maHocKy,
                                           p.HocKy.tenHocKy,
                                           p.HocKy.namHoc,
                                           p.diemRenLuyen,
                                           p.xepLoaiRenLuyen
                                           );
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "DiemRenLuyen");
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

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
    public partial class frmHocKy : Form
    {
        QLSVDbContext context = new QLSVDbContext();
        string ma;
        public frmHocKy()
        {
            InitializeComponent();
        }

        private void frmHocKy_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            var hk = context.HocKy.Select(r => new
            {
                r.maHocKy,
                r.tenHocKy,
                r.namHoc,
            }).ToList();
            dataGridView1.DataSource = hk;

            txtMaHocKy.DataBindings.Clear();
            txtMaHocKy.DataBindings.Add("Text", hk, "maHocKy", false, DataSourceUpdateMode.Never);

            txtTenHocKy.DataBindings.Clear();
            txtTenHocKy.DataBindings.Add("Text", hk, "tenHocKy", false, DataSourceUpdateMode.Never);

            txtNamHoc.DataBindings.Clear();
            txtNamHoc.DataBindings.Add("Text", hk, "namHoc", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ma = "";
            txtMaHocKy.Text = "";
            txtTenHocKy.Text = "";
            txtNamHoc.Text = "";
            txtMaHocKy.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                txtMaHocKy.Enabled = false;
                txtTenHocKy.Focus();
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
                if (MessageBox.Show("Xác nhận xóa học kỳ " + txtTenHocKy.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                    HocKy hk = context.HocKy.Find(ma)!;
                    context.HocKy.Remove(hk);
                    context.SaveChanges();
                    frmHocKy_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHocKy.Text))
                MessageBox.Show("Vui lòng nhập mã học kỳ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenHocKy.Text))
                MessageBox.Show("Vui lòng nhập tên học kỳ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtNamHoc.Text))
                MessageBox.Show("Vui lòng nhập năm học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ma == "")
            {
                HocKy hk = new HocKy();
                hk.maHocKy = txtMaHocKy.Text;
                hk.tenHocKy = txtTenHocKy.Text;
                hk.namHoc = txtNamHoc.Text;
                context.HocKy.Add(hk);
                context.SaveChanges();
            }
            else
            {
                ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                HocKy hk = context.HocKy.Find(ma)!;
                hk.maHocKy = txtMaHocKy.Text;
                hk.tenHocKy = txtTenHocKy.Text;
                hk.namHoc = txtNamHoc.Text;
                context.HocKy.Update(hk);
                context.SaveChanges();
            }
            frmHocKy_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHocKy_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var hk = context.HocKy
            .Where(r => r.maHocKy.Contains(txtTuKhoa.Text) ||
                        r.tenHocKy.Contains(txtTuKhoa.Text) ||
                        r.namHoc.Contains(txtTuKhoa.Text)
            )
            .ToList();
            dataGridView1.DataSource = hk;
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
                                HocKy hk = new HocKy();
                                hk.maHocKy = r["maHocKy"].ToString() ?? "N/A";

                                hk.tenHocKy = r["tenHocKy"].ToString() ?? "N/A";

                                hk.namHoc = r["namHoc"].ToString() ?? "N/A";
                                context.HocKy.Add(hk);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHocKy_Load(sender, e);
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
            saveFileDialog.FileName = "HocKy_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[3]
                    {
                        new DataColumn("maHocKy",typeof(string)),
                        new DataColumn("tenHocKy",typeof(string)),
                        new DataColumn("namHoc",typeof(string)),
                    });

                    var hk = context.HocKy.ToList();
                    if (hk != null)
                    {
                        foreach (var p in hk)
                            table.Rows.Add(p.maHocKy,
                                           p.tenHocKy,
                                           p.namHoc
                                           );
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "HocKy");
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

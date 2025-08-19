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
    public partial class frmLop : Form
    {
        QLSVDbContext context = new QLSVDbContext();
        string ma;
        public frmLop()
        {
            InitializeComponent();
        }
        private void LayTenKhoaVaoComboBox()
        {
            cboTenKhoa.DataSource = context.Khoa.ToList();
            cboTenKhoa.DisplayMember = "tenKhoa";
            cboTenKhoa.ValueMember = "maKhoa";
        }
        private void frmLop_Load(object sender, EventArgs e)
        {
            LayTenKhoaVaoComboBox();
            dataGridView1.AutoGenerateColumns = false;
            var lop = context.Lop.Select(r => new
            {
                r.maLop,
                r.tenLop,
                r.maKhoa,
                tenKhoa = r.Khoa.tenKhoa
            }).ToList();
            dataGridView1.DataSource = lop;

            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", lop, "maLop", false, DataSourceUpdateMode.Never);

            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", lop, "tenLop", false, DataSourceUpdateMode.Never);

            cboTenKhoa.DataBindings.Clear();
            cboTenKhoa.DataBindings.Add("SelectedValue", lop, "maKhoa", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ma = "";
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboTenKhoa.Text = "";
            txtMaLop.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                txtMaLop.Enabled = false;
                txtTenLop.Focus();
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
                if (MessageBox.Show("Xác nhận xóa lớp " + txtTenLop.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                    Lop l = context.Lop.Find(ma)!;
                    context.Lop.Remove(l);
                    context.SaveChanges();
                    frmLop_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
                MessageBox.Show("Vui lòng nhập mã lớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenLop.Text))
                MessageBox.Show("Vui lòng nhập tên lớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboTenKhoa.Text))
                MessageBox.Show("Vui lòng chọn tên khoa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ma == "")
            {
                Lop l = new Lop();
                l.maLop = txtMaLop.Text;
                l.tenLop = txtTenLop.Text;
                l.maKhoa = cboTenKhoa.SelectedValue?.ToString()!;
                context.Lop.Add(l);
                context.SaveChanges();
            }
            else
            {
                Lop l = context.Lop.Find(ma)!;
                l.maLop = txtMaLop.Text;
                l.tenLop = txtTenLop.Text;
                l.maKhoa = cboTenKhoa.SelectedValue?.ToString()!;
                context.Lop.Update(l);
                context.SaveChanges();
            }
            frmLop_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLop_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var lop = context.Lop
            .Where(r => r.maLop.Contains(txtTuKhoa.Text) ||
                        r.tenLop.Contains(txtTuKhoa.Text) ||
                        r.maKhoa.Contains(txtTuKhoa.Text)
            )
            .ToList();
            dataGridView1.DataSource = lop;
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
                                Lop lop = new Lop();
                                lop.maLop = r["maLop"].ToString() ?? "N/A";

                                lop.tenLop = r["tenLop"].ToString() ?? "N/A";

                                lop.maKhoa = r["maKhoa"].ToString() ?? "N/A";
                                context.Lop.Add(lop);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmLop_Load(sender, e);
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
            saveFileDialog.FileName = "Lop_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[4]
                    {
                        new DataColumn("maLop",typeof(string)),
                        new DataColumn("tenLop",typeof(string)),
                        new DataColumn("maKhoa",typeof(string)),
                        new DataColumn("tenKhoa",typeof(string))
                    });

                    var lop = context.Lop.ToList();
                    if (lop != null)
                    {
                        foreach (var p in lop)
                            table.Rows.Add(p.maLop,
                                           p.tenLop,
                                           p.maKhoa,
                                           p.Khoa.tenKhoa
                                           );
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Lop");
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

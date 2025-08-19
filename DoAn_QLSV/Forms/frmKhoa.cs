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
    public partial class frmKhoa : Form
    {
        QLSVDbContext context = new QLSVDbContext();
        string ma;
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            var khoa = context.Khoa.ToList();
            dataGridView1.DataSource = khoa;

            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", khoa, "maKhoa", false, DataSourceUpdateMode.Never);

            txtTenKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Add("Text", khoa, "tenKhoa", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ma = "";
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtMaKhoa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                txtMaKhoa.Enabled = false;
                txtTenKhoa.Focus();
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
                if (MessageBox.Show("Xác nhận xóa khoa " + txtTenKhoa.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                    Khoa khoa = context.Khoa.Find(ma)!;
                    context.Khoa.Remove(khoa);
                    context.SaveChanges();
                    frmKhoa_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
                MessageBox.Show("Vui lòng nhập mã khoa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenKhoa.Text))
                MessageBox.Show("Vui lòng nhập tên khoa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ma == "")
            {
                Khoa khoa = new Khoa();
                khoa.maKhoa = txtMaKhoa.Text;
                khoa.tenKhoa = txtTenKhoa.Text;
                context.Khoa.Add(khoa);
                context.SaveChanges();
            }
            else
            {
                Khoa khoa = context.Khoa.Find(ma)!;
                khoa.maKhoa = txtMaKhoa.Text;
                khoa.tenKhoa = txtTenKhoa.Text;
                context.Khoa.Update(khoa);
                context.SaveChanges();
            }
            frmKhoa_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhoa_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var kh = context.Khoa
            .Where(r => r.maKhoa.Contains(txtTuKhoa.Text) ||
                        r.tenKhoa.Contains(txtTuKhoa.Text)
            )
            .ToList();
            dataGridView1.DataSource = kh;
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
                                Khoa kh = new Khoa();
                                kh.maKhoa = r["maKhoa"].ToString() ?? "N/A";

                                kh.tenKhoa = r["tenKhoa"].ToString() ?? "N/A";

                                context.Khoa.Add(kh);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmKhoa_Load(sender, e);
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
            saveFileDialog.FileName = "Khoa_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[2]
                    {
                        new DataColumn("maKhoa",typeof(string)),
                        new DataColumn("tenKhoa",typeof(string)),
                    });

                    var kh = context.Khoa.ToList();
                    if (kh != null)
                    {
                        foreach (var p in kh)
                            table.Rows.Add(p.maKhoa,
                                           p.tenKhoa
                                           );
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Khoa");
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

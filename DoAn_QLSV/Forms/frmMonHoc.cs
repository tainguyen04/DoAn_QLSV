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
    public partial class frmMonHoc : Form
    {
        QLSVDbContext context = new QLSVDbContext();
        string ma;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            var mh = context.MonHoc.ToList();
            dataGridView1.DataSource = mh;

            txtMaMonHoc.DataBindings.Clear();
            txtMaMonHoc.DataBindings.Add("Text", mh, "maMonHoc", false, DataSourceUpdateMode.Never);

            txtTenMonHoc.DataBindings.Clear();
            txtTenMonHoc.DataBindings.Add("Text", mh, "tenMonHoc", false, DataSourceUpdateMode.Never);

            numSoTinChi.DataBindings.Clear();
            numSoTinChi.DataBindings.Add("Value", mh, "soTinChi", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ma = "";
            txtMaMonHoc.Text = "";
            txtTenMonHoc.Text = "";
            numSoTinChi.Value = 0;
            txtMaMonHoc.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                txtMaMonHoc.Enabled = false;
                txtTenMonHoc.Focus();
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
                if (MessageBox.Show("Xác nhận xóa môn học " + txtTenMonHoc.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                    MonHoc mh = context.MonHoc.Find(ma)!;
                    context.MonHoc.Remove(mh);
                    context.SaveChanges();
                    frmMonHoc_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMonHoc.Text))
                MessageBox.Show("Vui lòng nhập mã môn học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text))
                MessageBox.Show("Vui lòng nhập tên môn học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoTinChi.Value < 0 && numSoTinChi.Value > 5)
                MessageBox.Show("Vui lòng nhập số tín chỉ phù hợp(1-4tc).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ma == "")
            {
                MonHoc mh = new MonHoc();
                mh.maMonHoc = txtMaMonHoc.Text;
                mh.tenMonHoc = txtTenMonHoc.Text;
                mh.soTinChi = Convert.ToInt32(numSoTinChi.Value);
                context.MonHoc.Add(mh);
                context.SaveChanges();
            }
            else
            {
                ma = dataGridView1.CurrentRow?.Cells[0].Value?.ToString()!;
                MonHoc mh = context.MonHoc.Find(ma)!;
                mh.maMonHoc = txtMaMonHoc.Text;
                mh.tenMonHoc = txtTenMonHoc.Text;
                mh.soTinChi = Convert.ToInt32(numSoTinChi.Value);
                context.MonHoc.Update(mh);
                context.SaveChanges();
            }
            frmMonHoc_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmMonHoc_Load(sender, e);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var mh = context.MonHoc
            .Where(r => r.maMonHoc.Contains(txtTuKhoa.Text) ||
                        r.tenMonHoc.Contains(txtTuKhoa.Text)
            )
            .ToList();
            dataGridView1.DataSource = mh;
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
                                MonHoc mh = new MonHoc();
                                mh.maMonHoc = r["maMonHoc"].ToString() ?? "N/A";

                                mh.tenMonHoc = r["tenMonHoc"].ToString() ?? "N/A";

                                mh.soTinChi = Convert.ToInt32(r["soTinChi"].ToString());
                                context.MonHoc.Add(mh);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmMonHoc_Load(sender, e);
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
            saveFileDialog.FileName = "MonHoc_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[3]
                    {
                        new DataColumn("maMonHoc",typeof(string)),
                        new DataColumn("tenMonHoc",typeof(string)),
                        new DataColumn("soTinChi",typeof(int)),
                    });

                    var mh = context.MonHoc.ToList();
                    if (mh != null)
                    {
                        foreach (var p in mh)
                            table.Rows.Add(p.maMonHoc,
                                           p.tenMonHoc,
                                           p.soTinChi
                                           );
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "MonHoc");
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

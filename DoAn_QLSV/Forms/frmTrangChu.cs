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
    public partial class frmTrangChu : Form
    {
        frmDiemHocTap frmDiemHocTap = null!;
        frmThongTinSinhVien frmThongTin = null!;
        frmDiemRenLuyen frmDiemRenLuyen = null!;
        frmKhoa frmKhoa = null!;
        frmLop frmLop = null!;
        frmHocKy frmHocKy = null!;
        frmMonHoc frmMonHoc = null!;
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void btnMnuDht_Click(object sender, EventArgs e)
        {
            if (frmDiemHocTap == null || frmDiemHocTap.IsDisposed)
            {
                frmDiemHocTap = new frmDiemHocTap();
                frmDiemHocTap.TopLevel = false; // Form con không có thanh tiêu đề
                frmDiemHocTap.FormBorderStyle = FormBorderStyle.None; // Không có viền
                frmDiemHocTap.Dock = DockStyle.Fill; // Lấp đầy panel


            }
            panelMain.Controls.Clear(); // Xóa control cũ nếu có
            panelMain.Controls.Add(frmDiemHocTap); // Thêm form vào panel
            frmDiemHocTap.Show();
        }

        private void btnMnuSinhVien_Click(object sender, EventArgs e)
        {
            if (frmThongTin == null || frmThongTin.IsDisposed)
            {
                frmThongTin = new frmThongTinSinhVien();
                frmThongTin.TopLevel = false; // Form con không có thanh tiêu đề
                frmThongTin.FormBorderStyle = FormBorderStyle.None; // Không có viền
                frmThongTin.Dock = DockStyle.Fill; // Lấp đầy panel


            }
            panelMain.Controls.Clear(); // Xóa control cũ nếu có
            panelMain.Controls.Add(frmThongTin); // Thêm form vào panel
            frmThongTin.Show();
        }

        private void btnMnuDrl_Click(object sender, EventArgs e)
        {
            if (frmDiemRenLuyen == null || frmDiemRenLuyen.IsDisposed)
            {
                frmDiemRenLuyen = new frmDiemRenLuyen();
                frmDiemRenLuyen.TopLevel = false; // Form con không có thanh tiêu đề
                frmDiemRenLuyen.FormBorderStyle = FormBorderStyle.None; // Không có viền
                frmDiemRenLuyen.Dock = DockStyle.Fill; // Lấp đầy panel


            }
            panelMain.Controls.Clear(); // Xóa control cũ nếu có
            panelMain.Controls.Add(frmDiemRenLuyen); // Thêm form vào panel
            frmDiemRenLuyen.Show();
        }

        private void btnMnuKhoa_Click(object sender, EventArgs e)
        {
            if (frmKhoa == null || frmKhoa.IsDisposed)
            {
                frmKhoa = new frmKhoa();
                frmKhoa.TopLevel = false; // Form con không có thanh tiêu đề
                frmKhoa.FormBorderStyle = FormBorderStyle.None; // Không có viền
                frmKhoa.Dock = DockStyle.Fill; // Lấp đầy panel


            }
            panelMain.Controls.Clear(); // Xóa control cũ nếu có
            panelMain.Controls.Add(frmKhoa); // Thêm form vào panel
            frmKhoa.Show();
        }

        private void btnMnuHocKy_Click(object sender, EventArgs e)
        {
            if (frmHocKy == null || frmHocKy.IsDisposed)
            {
                frmHocKy = new frmHocKy();
                frmHocKy.TopLevel = false; // Form con không có thanh tiêu đề
                frmHocKy.FormBorderStyle = FormBorderStyle.None; // Không có viền
                frmHocKy.Dock = DockStyle.Fill; // Lấp đầy panel


            }
            panelMain.Controls.Clear(); // Xóa control cũ nếu có
            panelMain.Controls.Add(frmHocKy); // Thêm form vào panel
            frmHocKy.Show();
        }

        private void btnMnuLop_Click(object sender, EventArgs e)
        {
            if (frmLop == null || frmLop.IsDisposed)
            {
                frmLop = new frmLop();
                frmLop.TopLevel = false; // Form con không có thanh tiêu đề
                frmLop.FormBorderStyle = FormBorderStyle.None; // Không có viền
                frmLop.Dock = DockStyle.Fill; // Lấp đầy panel


            }
            panelMain.Controls.Clear(); // Xóa control cũ nếu có
            panelMain.Controls.Add(frmLop); // Thêm form vào panel
            frmLop.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.Show();
                this.Close();
            }
        }

        private void BtnMnuMonHoc_Click(object sender, EventArgs e)
        {
            if (frmMonHoc == null || frmMonHoc.IsDisposed)
            {
                frmMonHoc = new frmMonHoc();
                frmMonHoc.TopLevel = false; // Form con không có thanh tiêu đề
                frmMonHoc.FormBorderStyle = FormBorderStyle.None; // Không có viền
                frmMonHoc.Dock = DockStyle.Fill; // Lấp đầy panel


            }
            panelMain.Controls.Clear(); // Xóa control cũ nếu có
            panelMain.Controls.Add(frmMonHoc); // Thêm form vào panel
            frmMonHoc.Show();
        }
    }
}

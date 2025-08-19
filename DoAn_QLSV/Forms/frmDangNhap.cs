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
using BC = BCrypt.Net;
namespace DoAn_QLSV.Forms
{
    public partial class frmDangNhap : Form
    {
        QLSVDbContext context = new QLSVDbContext();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            var tenDangNhap = txtTenDangNhap.Text.Trim();
            var matKhau = txtMatKhau.Text.Trim();
            var tk = context.TaiKhoan.FirstOrDefault(r => r.tenDangNhap == tenDangNhap);
            
            if (tk != null && BC.BCrypt.Verify(matKhau,tk.matKhau))
            {
                this.Hide();
                frmTrangChu frmTrangChu = new frmTrangChu(tk.MSSV,tk.phanQuyen);
                frmTrangChu.ShowDialog();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ckbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !ckbHienMatKhau.Checked;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender,e);
        }
    }
}

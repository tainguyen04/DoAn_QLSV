using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn_QLSV.Data
{
    public class TaiKhoan
    {
        [Key]
        public string tenDangNhap { get; set; } = null!;
        public string matKhau { get; set; } = null!;
        public string phanQuyen { get; set; } = null!;
        
        public string MSSV { get; set; } = null!;
        [ForeignKey(nameof(MSSV))]
        public virtual ThongTinSinhVien SinhVien { get; set; } = null!;

    }
}

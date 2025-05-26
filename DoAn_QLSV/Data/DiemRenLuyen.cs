using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn_QLSV.Data
{
    public class DiemRenLuyen
    {
        [Key]
        public int id { get; set; }  // Khóa chính

        public string MSSV { get; set; } = null!;     // FK sinh viên
        public string maHocKy { get; set; } = null!;  // FK học kỳ

        public float diemRenLuyen { get; set; }
        public string xepLoaiRenLuyen { get; set; } = null!;

        [ForeignKey(nameof(MSSV))]
        public virtual ThongTinSinhVien SinhVien { get; set; } = null!;

        [ForeignKey(nameof(maHocKy))]
        public virtual HocKy HocKy { get; set; } = null!;
    }
}

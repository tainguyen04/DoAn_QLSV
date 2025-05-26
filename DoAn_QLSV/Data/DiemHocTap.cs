using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn_QLSV.Data
{
   public class DiemHocTap
    {
        [Key]
        public int id { get; set; }  // Khóa chính

        public string MSSV { get; set; } = null!;     // FK sinh viên
        public string maHocKy { get; set; } = null!;  // FK học kỳ
        public string maMonHoc { get; set; } = null!; // FK môn học

        public float diemHocTap { get; set; }
        public float diemHe4 { get; set; }
        public string xepLoaiHocTap { get; set; } = null!;

        [ForeignKey(nameof(MSSV))]
        public virtual ThongTinSinhVien SinhVien { get; set; } = null!;

        [ForeignKey(nameof(maHocKy))]
        public virtual HocKy HocKy { get; set; } = null!;

        [ForeignKey(nameof(maMonHoc))]
        public virtual MonHoc MonHoc { get; set; } = null!;
    }
}

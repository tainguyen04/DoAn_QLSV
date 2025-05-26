using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DoAn_QLSV.Data
{
    public class Khoa
    {
        [Key]
        public string maKhoa { get; set; } = null!;
        public string tenKhoa { get; set; } = null!;

        public virtual ICollection<Lop> Lop { get; set; } = new List<Lop>();
        public virtual ICollection<ThongTinSinhVien> SinhVien { get; set; } = new List<ThongTinSinhVien>();
    }
}

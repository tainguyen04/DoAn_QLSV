using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn_QLSV.Data
{
    public class Lop
    {
        [Key]
        public string maLop { get; set; } = null!;   

        public string tenLop { get; set; } = null!;

        public string maKhoa { get; set; } = null!;  

        [ForeignKey(nameof(maKhoa))]
        public virtual Khoa Khoa { get; set; } = null!;

        public virtual ICollection<ThongTinSinhVien> SinhVien { get; set; } = new List<ThongTinSinhVien>();
    }
}


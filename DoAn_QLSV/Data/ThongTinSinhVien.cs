using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DoAn_QLSV.Data
{
   public class ThongTinSinhVien
    {
        [Key]
        public string MSSV { get; set; } = null!;
        public string hoTen { get; set; } = null!;
        public string gioiTinh { get; set; } = null!;
        public string soDienThoai { get; set; } = null!;
        public string diaChi { get; set; } = null!;
        public DateTime ngaySinh { get; set; }
        public string hinhAnh { get; set; } = null!;

        public string lopID { get; set; } = null!;

        public virtual Lop Lop { get; set; } = null!;


        public virtual ICollection<DiemHocTap> DiemHocTap { get; set; } = new List<DiemHocTap>();
        public virtual ICollection<DiemRenLuyen> DiemRenLuyen { get; set; } = new List<DiemRenLuyen>();
        
    }
}


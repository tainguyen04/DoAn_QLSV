using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DoAn_QLSV.Data
{
    public class HocKy
    {
        [Key]
        public string maHocKy { get; set; } = null!;
        public string tenHocKy { get; set; } = null!;
        public string namHoc { get; set; } = null!;

        public virtual ICollection<DiemHocTap> DiemHocTap { get; set; } = new List<DiemHocTap>();
        public virtual ICollection<DiemRenLuyen> DiemRenLuyen { get; set; } = new List<DiemRenLuyen>();
        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLSV.Data
{
    public class MonHoc
    {
        [Key]
        public string maMonHoc { get; set; } = null!;
        public string tenMonHoc { get; set; } = null!;
        public int soTinChi { get; set; }

        public virtual ICollection<DiemHocTap> DiemHocTap { get; set; } = new List<DiemHocTap>();
    }
}


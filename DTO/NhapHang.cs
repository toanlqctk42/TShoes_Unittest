using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DTO
{
    [Table("NhapHang")]
    public class NhapHang
    {
        [Key]
        public int NhapHangID { get; set; }

        public DateTime ngaynhap { get; set; }

        public string NguonHang { get; set; }

        public double Tienhang { get; set; }

        public double? Phivanchuyen { get; set; }

        public double? Thue { get; set; }

        public double? ChiPhiKhac { get; set; }

        public double Thanhtien { get; set; }

        public string Ghichu { get; set; }

        public virtual ICollection<ChitietNhapHang> ChitietNhapHangs { get; set; }
    }
}

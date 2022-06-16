using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DTO
{
    [Table("ChiTietSanPham")]
    public class ChiTietSanPham
    {
        [Key]
        public int ChitietSPID { get; set; }

        public int? SanPham_ID { get; set; }

        public string MaSP { get; set; }

        public string TenSP { get; set; }

        public string Mau { get; set; }

        public int Sizes { get; set; }

        public int Soluong { get; set; }

        public int Kinhdoanh { get; set; }

        public string ImgURL { get; set; }

        [ForeignKey("SanPham_ID")]
        public SanPham SanPhams { get; set; }

        public virtual ICollection<ChitietNhapHang> ChitietNhapHangs { get; set; }
        public virtual ICollection<BillDetails> BillDetails { get; set; }
    }
}

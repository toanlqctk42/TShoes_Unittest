using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DTO
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        public int SanPhamID { get; set; }

        [StringLength(100)]
        [Required]
        public string MaSanPham { get; set; }

        [StringLength(1000)]
        [Required]
        public string TenSanPham { get; set; }

        public int NhomSP_ID { get; set; }
        public virtual NhomSP NhomSP { get; set; }

        public DateTime Ngaynhap { get; set; }

        public int GiaNhap { get; set; }

        public int Giaban { get; set; }

        public virtual ICollection<ChiTietSanPham> ChiTietSanPham { get; set; }
    }
}

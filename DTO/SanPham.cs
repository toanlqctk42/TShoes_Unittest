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

        public int ThuongHieu_ID { get; set; }

        public DateTime Ngaynhap { get; set; }

        public int GiaNhap { get; set; }

        public int Giaban { get; set; }

        public int Soluong { get; set; }

        [ForeignKey("NhomSP_ID")]
        public NhomSP NhomSP { get; set; }

        [ForeignKey("ThuongHieu_ID")]
        public ThuongHieu ThuongHieu { get; set; }

        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }

    }
}

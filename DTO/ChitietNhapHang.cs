using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DTO
{
    [Table("ChitietNhapHang")]
    public class ChitietNhapHang
    {
        [Key]
        public int ChitietNhaphangID { get; set; }

        public int? NhapHang_ID { get; set; }

        public int? ChitietsanPham_ID { get; set; }

        public double DonGia { get; set; }

        public int SoLuongNhap { get; set; }

        public double Total { get { return SoLuongNhap * DonGia; } }

        [ForeignKey("NhapHang_ID")]
        public NhapHang nhapHang { get; set; }

        [ForeignKey("ChitietsanPham_ID")]
        public ChiTietSanPham chiTietSanPham { get; set; }
    }
}

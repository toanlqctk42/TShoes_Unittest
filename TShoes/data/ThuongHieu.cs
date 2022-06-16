using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DTO
{
    [Table("ThuongHieu")]
    public class ThuongHieu
    {
        [Key]
        public int ThuongHieuID { get; set; }

        [StringLength(100)]
        [Required]
        public string TenThuongHieu { get; set; }

        public virtual ICollection<ChiTietSanPham> ChiTietSanPham { get; set; }
    }
}

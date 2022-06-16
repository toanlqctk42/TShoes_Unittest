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
        public int ChiTietSanPhamID { get; set; }

        public int SanPham_ID { get; set; }
        

        public int ThuongHieuID { get; set; }
        

        public int size { get; set; }

        public int Soluong { get; set; }

        public string ImageURL { get; set; }
        public virtual ICollection<SanPham> SanPham { get; set; }
        public virtual ICollection<ThuongHieu> ThuongHieu { get; set; }
        public virtual BillDetails BillDetails { get; set; }
    }
}

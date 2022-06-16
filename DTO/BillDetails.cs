using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DTO
{
    [Table("BillDetails")]
    public class BillDetails
    {
        [Key]
        public int BillDetailID { get; set; }

        public int ChitietSP_ID { get; set; }

        [StringLength(1000)]
        public string TenSP { get; set; }

        public int? Bills_ID { get; set; }

        public string Mau { get; set; }

        public int Sizes { get; set; }

        public int Soluong { get; set; }

        public int Giaban { get; set; }

        public double Total { get { return Giaban * Soluong; } }

        [ForeignKey("ChitietSP_ID")]
        public virtual ChiTietSanPham ChiTietSanPham { get; set; }

        [ForeignKey("Bills_ID")]
        public virtual Bills Bills { get; set; }

    }
}

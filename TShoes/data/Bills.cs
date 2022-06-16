using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DTO
{
    [Table("Bills")]
    public class Bills
    {

        [Key]
        public int ID { get; set; }

        [StringLength(100)]
        [Required]
        public string TenNhanVien { get; set; }

        public DateTime NgaylapBill { get; set; }

        [StringLength(200)]
        [Required]
        public string TenKhachHang { get; set; }

        [StringLength(100)]
        public string SDTKhachHang { get; set; }

        public float Discount { get; set; }

        public int ToTal { get; set; }

        public virtual ICollection<BillDetails> BillDetails { get; set; }

    }
}

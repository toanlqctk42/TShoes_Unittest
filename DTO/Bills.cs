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
        public int BillID { get; set; }

        [StringLength(100)]
        [Required]
        public string TenNhanVien { get; set; }

        public DateTime NgaylapBill { get; set; }

        [StringLength(200)]
        [Required]
        public string TenKhachHang { get; set; }

        [StringLength(100)]
        public string SDTKhachHang { get; set; }

        public double TienHang { get; set; }

        public double Discount { get; set; }

        public double ToTal { get; set; }

        public int Active { get; set; }

        public virtual ICollection<BillDetails> BillDetails { get; set; }

    }
}

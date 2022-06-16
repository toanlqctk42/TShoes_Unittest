using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DTO
{
    [Table("NhomSP")]
    public class NhomSP
    {
        [Key]
        public int NhomspID { get; set; }

        [StringLength(100)]
        [Required]
        public string TenNhomSP { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}

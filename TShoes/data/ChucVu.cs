using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DTO
{
    [Table("ChucVu")]
    public class ChucVu
    {
        [Key]
        public string ChucVuID { get; set; }

        [StringLength(100)]
        [Required]
        public string TenChucVu { get; set; }

        public virtual ICollection<NguoiDungDTO> NguoiDungDTOs { get; set; }
    }
}

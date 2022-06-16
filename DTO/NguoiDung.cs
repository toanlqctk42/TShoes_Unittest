using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DTO
{
    [Table("Account")]
    public class NguoiDung
    {
        [Key]
        [StringLength(100)]
        public string TenTK { get; set; }

        [StringLength(1000)]
        [Required]
        public string Fullname { get; set; }


        public DateTime Ngaykhoitao { get; set; }

        [StringLength(100)]
        [Required]
        public string MatKhau { get; set; }

        public int Chucvu_ID { get; set; }

        public int Active { get; set; }

        [ForeignKey("Chucvu_ID")]
        public virtual ChucVu ChucVu { get; set; }

    }
}

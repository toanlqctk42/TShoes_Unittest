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
        [Column(Order = 1)]
        public int Bill_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Chitietsanpham_ID { get; set; }

        public int Soluong { get; set; }

        public int GiaBan { get; set; }

    }
}

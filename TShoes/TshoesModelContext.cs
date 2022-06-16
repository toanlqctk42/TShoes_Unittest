using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DTO;

namespace TShoes
{
    public class TshoesModelContext : DbContext
    {
        //public TshoesModelContext() : base("name = TShoes")
        //{

        //}
        public DbSet<BillDetails> billDetails { get; set; }
        public DbSet<Bills> bills { get; set; }
        public DbSet<ChitietNhapHang> chitietNhapHangs { get; set; }
        public DbSet<ChiTietSanPham> chiTietSanPhams { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }
        public DbSet<NguoiDung> nguoiDungs { get; set; }
        public DbSet<NhapHang> nhapHangs { get; set; }
        public DbSet<NhomSP> nhomSPs { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<ThuongHieu> thuongHieus { get; set; }
    }
}

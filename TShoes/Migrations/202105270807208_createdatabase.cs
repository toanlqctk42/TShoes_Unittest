namespace TShoes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BillDetails",
                c => new
                    {
                        BillDetailID = c.Int(nullable: false, identity: true),
                        ChitietSP_ID = c.Int(nullable: false),
                        TenSP = c.String(maxLength: 1000),
                        Bills_ID = c.Int(),
                        Mau = c.String(),
                        Sizes = c.Int(nullable: false),
                        Soluong = c.Int(nullable: false),
                        Giaban = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BillDetailID)
                .ForeignKey("dbo.Bills", t => t.Bills_ID)
                .ForeignKey("dbo.ChiTietSanPham", t => t.ChitietSP_ID, cascadeDelete: true)
                .Index(t => t.ChitietSP_ID)
                .Index(t => t.Bills_ID);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillID = c.Int(nullable: false, identity: true),
                        TenNhanVien = c.String(nullable: false, maxLength: 100),
                        NgaylapBill = c.DateTime(nullable: false),
                        TenKhachHang = c.String(nullable: false, maxLength: 200),
                        SDTKhachHang = c.String(maxLength: 100),
                        TienHang = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        ToTal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BillID);
            
            CreateTable(
                "dbo.ChiTietSanPham",
                c => new
                    {
                        ChitietSPID = c.Int(nullable: false, identity: true),
                        SanPham_ID = c.Int(),
                        MaSP = c.String(),
                        TenSP = c.String(),
                        Mau = c.String(),
                        Sizes = c.Int(nullable: false),
                        Soluong = c.Int(nullable: false),
                        Kinhdoanh = c.Int(nullable: false),
                        ImgURL = c.String(),
                    })
                .PrimaryKey(t => t.ChitietSPID)
                .ForeignKey("dbo.SanPham", t => t.SanPham_ID)
                .Index(t => t.SanPham_ID);
            
            CreateTable(
                "dbo.ChitietNhapHang",
                c => new
                    {
                        ChitietNhaphangID = c.Int(nullable: false, identity: true),
                        NhapHang_ID = c.Int(),
                        ChitietsanPham_ID = c.Int(),
                        DonGia = c.Double(nullable: false),
                        SoLuongNhap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChitietNhaphangID)
                .ForeignKey("dbo.ChiTietSanPham", t => t.ChitietsanPham_ID)
                .ForeignKey("dbo.NhapHang", t => t.NhapHang_ID)
                .Index(t => t.NhapHang_ID)
                .Index(t => t.ChitietsanPham_ID);
            
            CreateTable(
                "dbo.NhapHang",
                c => new
                    {
                        NhapHangID = c.Int(nullable: false, identity: true),
                        ngaynhap = c.DateTime(nullable: false),
                        NguonHang = c.String(),
                        Tienhang = c.Double(nullable: false),
                        Phivanchuyen = c.Double(),
                        Thue = c.Double(),
                        ChiPhiKhac = c.Double(),
                        Thanhtien = c.Double(nullable: false),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.NhapHangID);
            
            CreateTable(
                "dbo.SanPham",
                c => new
                    {
                        SanPhamID = c.Int(nullable: false, identity: true),
                        MaSanPham = c.String(nullable: false, maxLength: 100),
                        TenSanPham = c.String(nullable: false, maxLength: 1000),
                        NhomSP_ID = c.Int(nullable: false),
                        ThuongHieu_ID = c.Int(nullable: false),
                        Ngaynhap = c.DateTime(nullable: false),
                        GiaNhap = c.Int(nullable: false),
                        Giaban = c.Int(nullable: false),
                        Soluong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SanPhamID)
                .ForeignKey("dbo.NhomSP", t => t.NhomSP_ID, cascadeDelete: true)
                .ForeignKey("dbo.ThuongHieu", t => t.ThuongHieu_ID, cascadeDelete: true)
                .Index(t => t.NhomSP_ID)
                .Index(t => t.ThuongHieu_ID);
            
            CreateTable(
                "dbo.NhomSP",
                c => new
                    {
                        NhomspID = c.Int(nullable: false, identity: true),
                        TenNhomSP = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.NhomspID);
            
            CreateTable(
                "dbo.ThuongHieu",
                c => new
                    {
                        ThuongHieuID = c.Int(nullable: false, identity: true),
                        TenThuongHieu = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ThuongHieuID);
            
            CreateTable(
                "dbo.ChucVu",
                c => new
                    {
                        ChucVuID = c.Int(nullable: false, identity: true),
                        TenChucVu = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ChucVuID);
            
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        TenTK = c.String(nullable: false, maxLength: 100),
                        Fullname = c.String(nullable: false, maxLength: 1000),
                        Ngaykhoitao = c.DateTime(nullable: false),
                        MatKhau = c.String(nullable: false, maxLength: 100),
                        Chucvu_ID = c.Int(nullable: false),
                        Active = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TenTK)
                .ForeignKey("dbo.ChucVu", t => t.Chucvu_ID, cascadeDelete: true)
                .Index(t => t.Chucvu_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Account", "Chucvu_ID", "dbo.ChucVu");
            DropForeignKey("dbo.SanPham", "ThuongHieu_ID", "dbo.ThuongHieu");
            DropForeignKey("dbo.SanPham", "NhomSP_ID", "dbo.NhomSP");
            DropForeignKey("dbo.ChiTietSanPham", "SanPham_ID", "dbo.SanPham");
            DropForeignKey("dbo.ChitietNhapHang", "NhapHang_ID", "dbo.NhapHang");
            DropForeignKey("dbo.ChitietNhapHang", "ChitietsanPham_ID", "dbo.ChiTietSanPham");
            DropForeignKey("dbo.BillDetails", "ChitietSP_ID", "dbo.ChiTietSanPham");
            DropForeignKey("dbo.BillDetails", "Bills_ID", "dbo.Bills");
            DropIndex("dbo.Account", new[] { "Chucvu_ID" });
            DropIndex("dbo.SanPham", new[] { "ThuongHieu_ID" });
            DropIndex("dbo.SanPham", new[] { "NhomSP_ID" });
            DropIndex("dbo.ChitietNhapHang", new[] { "ChitietsanPham_ID" });
            DropIndex("dbo.ChitietNhapHang", new[] { "NhapHang_ID" });
            DropIndex("dbo.ChiTietSanPham", new[] { "SanPham_ID" });
            DropIndex("dbo.BillDetails", new[] { "Bills_ID" });
            DropIndex("dbo.BillDetails", new[] { "ChitietSP_ID" });
            DropTable("dbo.Account");
            DropTable("dbo.ChucVu");
            DropTable("dbo.ThuongHieu");
            DropTable("dbo.NhomSP");
            DropTable("dbo.SanPham");
            DropTable("dbo.NhapHang");
            DropTable("dbo.ChitietNhapHang");
            DropTable("dbo.ChiTietSanPham");
            DropTable("dbo.Bills");
            DropTable("dbo.BillDetails");
        }
    }
}

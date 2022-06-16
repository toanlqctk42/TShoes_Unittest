using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using DTO;

namespace TShoes
{
    public class DBConTExt
    {
        #region Sự Kiện cập nhật những thay đổi trên Database
        static event Action<List<SanPham>> sp;
        public event Action<List<SanPham>> Sp
        {
            add
            {
                sp += value;
            }
            remove
            {
                sp -= value;
            }
        }

        static event Action<List<ChiTietSanPham>> ctsp;
        public event Action<List<ChiTietSanPham>> CTSP
        {
            add
            {
                ctsp += value;
            }
            remove
            {
                ctsp -= value;
            }
        }

        static event Action<List<NhapHang>> nhaphang;
        public event Action<List<NhapHang>> NhapHang
        {
            add
            {
                nhaphang += value;
            }
            remove
            {
                nhaphang -= value;
            }
        }

        static event Action<List<ChitietNhapHang>> ctnhaphang;
        public event Action<List<ChitietNhapHang>> CTNhapHang
        {
            add
            {
                ctnhaphang += value;
            }
            remove
            {
                ctnhaphang -= value;
            }
        }

        static event Action<List<ChiTietSanPham>> spbanchay;
        public event Action<List<ChiTietSanPham>> SpBanChay
        {
            add
            {
                spbanchay += value;
            }
            remove
            {
                spbanchay -= value;
            }
        }

        static event Action<List<Bills>> bill;
        public event Action<List<Bills>> Bill
        {
            add
            {
                bill += value;
            }
            remove
            {
                bill -= value;
            }
        }

        static event Action<List<BillDetails>> billdetail;
        public event Action<List<BillDetails>> Billdetail
        {
            add
            {
                billdetail += value;
            }
            remove
            {
                billdetail -= value;
            }
        }
        #endregion

        #region return List
        //Account
        //Lấy danh sách tài khoản
        public static List<NguoiDung> GetAllAccount()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.nguoiDungs.ToList();
            }
        }
        
        //Lấy số tài khoản có trong database
        public static int NumberAccount()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.nguoiDungs.Count();
            }
        }

        //Lọc Danh sách người dùng theo Tên
        public static List<NguoiDung> GetNguoiDungDTOs_TheoTenNV()
        {
            List<NguoiDung> user = GetAllAccount();
            for (int i = 0; i < user.Count - 1; i++)
            {
                for (int j = i + 1; j < user.Count; j++)
                {
                    if (user[i].Fullname == user[j].Fullname)
                    {
                        user.RemoveAt(j);
                    }
                }
            }
            return user;
        }

        //lấy Danh sách chức vụ
        public static List<ChucVu> GetAllChucvu()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.chucVus.ToList();
            }
        }

        //Lấy danh sách thương Hiệu
        public static List<ThuongHieu> GetAllThuongHieu()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.thuongHieus.ToList();
            }
        }

        //lấy Danh sách Hoá đơn
        public static List<Bills> GetAllBills()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.bills.ToList();
            }
        }

        //lấy Danh sách chi tiết hoá đơn
        public static List<BillDetails> GetAllBillDetails()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.billDetails.ToList();
            }
        }

        //Lấy danh sách chi tiết hoá đơn theo hoá đơn ID
        public static List<BillDetails> GetAllBillDetail_TheoIDBIlls(int id)
        {
            List<BillDetails> billDetails = new List<BillDetails>();
            foreach (BillDetails item in GetAllBillDetails())
            {
                if(item.Bills_ID.Value == id)
                {
                    billDetails.Add(item);
                }
            }
            return billDetails;
        }

        //Lấy dánh sách nhóm sản phẩm
        public static List<NhomSP> GetAllNhomSP()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.nhomSPs.ToList();
            }
        }

        //Lấy danh sách sản phẩm
        public static List<SanPham> GetAllSP()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.sanPhams.ToList();
            }
        }
        
        //lấy danh sách chi tiết sản phẩm
        public static List<ChiTietSanPham> GetAll_ChitietSP()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.chiTietSanPhams.ToList();
            }
        }

        //Lấy danh sách chi tiết sản phẩm theo ID Sản phẩm
        public static List<ChiTietSanPham> GetAll_ChitietSP_TheoID(int idsanpham)
        {
            List<ChiTietSanPham> chiTietSanPhams = new List<ChiTietSanPham>();

            foreach (ChiTietSanPham item in GetAll_ChitietSP())
            {
                if(item.SanPham_ID == idsanpham)
                {
                    chiTietSanPhams.Add(item);
                }
            }
            return chiTietSanPhams;
        }

        //Lấy danh sách chi tiết sản phẩm theo ID Nhập Hàng
        public static List<ChiTietSanPham> GetAll_chitietSP_TheoNhapHang(int id)
        {
            List<ChiTietSanPham> chiTietSanPhams = new List<ChiTietSanPham>();
            foreach (ChitietNhapHang item in GetAll_ChiTietNhapHang())
            {
                foreach (ChiTietSanPham chiTietSanPham in GetAll_ChitietSP())
                {
                    if (item.ChitietsanPham_ID == chiTietSanPham.ChitietSPID && item.NhapHang_ID == id)
                    {
                        chiTietSanPham.Soluong = item.SoLuongNhap;
                        chiTietSanPhams.Add(chiTietSanPham);
                    }
                }
            }
            return chiTietSanPhams;
        }

        //Lấy danh sách chi tiết sản phẩm từ Danh sách Bills
        public static List<ChiTietSanPham> getAll_ChitietSP_TheoListBills(List<Bills> bills)
        {
            List<ChiTietSanPham> chiTietSanPhams = new List<ChiTietSanPham>();
            foreach (Bills item in bills)
            {
                foreach (BillDetails details in GetAllBillDetail_TheoIDBIlls(item.BillID))
                {
                    if (item.BillID == details.Bills_ID)
                    {
                        foreach (ChiTietSanPham chiTietSanPham in DBConTExt.GetAll_ChitietSP())
                        {
                            if(chiTietSanPham.ChitietSPID ==  details.ChitietSP_ID)
                            {
                                if(chiTietSanPhams.Count == 0)
                                {
                                    chiTietSanPham.Soluong = details.Soluong;
                                    chiTietSanPhams.Add(chiTietSanPham);
                                }
                                else
                                {
                                    bool i = false;
                                    foreach (ChiTietSanPham chiTiet in chiTietSanPhams)
                                    {
                                        if(chiTiet.ChitietSPID == chiTietSanPham.ChitietSPID)
                                        {
                                            chiTiet.Soluong += details.Soluong;
                                            i = true;
                                        }
                                    }

                                    if(i == false)
                                    {
                                        chiTietSanPham.Soluong = details.Soluong;
                                        chiTietSanPhams.Add(chiTietSanPham);
                                    }
                                }
                                break;
                            }

                        }
                    }
                }
            }

            for (int i = 0; i < chiTietSanPhams.Count - 1; i++)
            {
                for (int j = i + 1; j < chiTietSanPhams.Count; j++)
                {
                    if (chiTietSanPhams[i].Soluong < chiTietSanPhams[j].Soluong)
                    {
                        ChiTietSanPham temp = chiTietSanPhams[i];
                        chiTietSanPhams[i] = chiTietSanPhams[j];
                        chiTietSanPhams[j] = temp;
                    }
                }
            }

            return chiTietSanPhams;
        }

        //Lấy danh sách chi tiết nhập hàng
        public static List<ChitietNhapHang> GetAll_ChiTietNhapHang()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.chitietNhapHangs.ToList();
            }
        }

        //Lấy danh sách chi tiết nhập hàng theo Id Nhập Hàng
        public static List<ChitietNhapHang> GetAll_ChiTietNhapHang_TheoIDNhapHang(int id)
        {
            List<ChitietNhapHang> chitietNhapHangs = new List<ChitietNhapHang>();
            foreach (ChitietNhapHang item in GetAll_ChiTietNhapHang())
            {
                if(item.NhapHang_ID == id)
                {
                    chitietNhapHangs.Add(item);
                }
            }
            return chitietNhapHangs;
        }

        //Lấy danh sách nhập hàng
        public static List<NhapHang> GetAll_NhapHang()
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                return db.nhapHangs.ToList();
            }
        }

        //Lấy danh sách nhập hàng theo thời gian
        public static List<NhapHang> GetAll_NhapHang_TheoKhoangThoiGian(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            List<NhapHang> nhapHangs = new List<NhapHang>();

            foreach (NhapHang item in GetAll_NhapHang())
            {
                if (ngaybatdau.Year == ngayketthuc.Year && ngaybatdau.Month == ngayketthuc.Month)
                {
                    if (item.ngaynhap.Date >= ngaybatdau.Date && item.ngaynhap.Date <= ngayketthuc.Date)
                    {
                        nhapHangs.Add(item);
                    }
                }
                else if(ngaybatdau.Year == ngayketthuc.Year)
                {
                    if(item.ngaynhap.Month > ngaybatdau.Month && item.ngaynhap.Month < ngayketthuc.Month)
                    {
                        nhapHangs.Add(item);
                    }
                    else if (item.ngaynhap.Month == ngaybatdau.Month || item.ngaynhap.Month == ngayketthuc.Month)
                    {
                        if (item.ngaynhap.Date >= ngaybatdau.Date && item.ngaynhap.Date <= ngayketthuc.Date)
                        {
                            nhapHangs.Add(item);
                        }
                    }
                }
            }

            return nhapHangs;
        }

        //Lấy danh sách nhập hàng theo Nguồn Hàng
        public static List<NhapHang> GetAll_NhapHang_TheoNguon(List<NhapHang> nhapHangs ,string TenTimKiem)
        {
            List<NhapHang> NhapHangs = new List<NhapHang>();
            if(nhapHangs.Count == 0)
            {
                NhapHangs = nhapHangs;
                return NhapHangs;
            }

            foreach (NhapHang item in nhapHangs)
            {
                if (item.NguonHang != null || item.NguonHang != "")
                {
                    string[] tensanpham = item.NguonHang.Split(' ');
                    foreach (string chuoitimkiem in tensanpham)
                    {
                        if (chuoitimkiem.Length >= TenTimKiem.Length)
                        {
                            if (chuoitimkiem.Substring(0, TenTimKiem.Length).ToLower() == TenTimKiem.ToLower())
                            {
                                NhapHangs.Add(item);
                                break;
                            }
                        }
                        else
                        {
                            if (item.NguonHang.Length >= TenTimKiem.Length && item.NguonHang.Substring(0, TenTimKiem.Length).ToLower() == TenTimKiem.ToLower())
                            {
                                NhapHangs.Add(item);
                                break;
                            }
                        }

                    }
                }
            }
            return NhapHangs;
        }

        //Lấy danh sách sản phẩm theo Tên sản Phẩm
        public static List<SanPham> GetAllSP_TheoTen(string tentimkiem)
        {
            List<SanPham> sp = new List<SanPham>();
            foreach (SanPham item in GetAllSP())
            {
                string[] tensanpham = item.TenSanPham.Split(' ');
                foreach (string chuoitimkiem in tensanpham)
                {
                    if(chuoitimkiem.Length >= tentimkiem.Length)
                    {
                        if (chuoitimkiem.Substring(0,tentimkiem.Length).ToLower() == tentimkiem.ToLower())
                        {
                            sp.Add(item);
                            break;
                        }
                    }
                    else
                    {
                        if (item.TenSanPham.Length >= tentimkiem.Length && item.TenSanPham.Substring(0,tentimkiem.Length).ToLower() == tentimkiem.ToLower())
                        {
                            sp.Add(item);
                            break;
                        }
                    }

                }    
            }
            return sp;
        }

        //Lấy danh sách sản phẩm theo mã
        public static List<SanPham> GetAllSP_TheoMA(string matimkiem)
        {
            List<SanPham> sp = new List<SanPham>();
            foreach (SanPham item in GetAllSP())
            {
                if (item.MaSanPham.Length >= matimkiem.Length && item.MaSanPham.Substring(0, matimkiem.Length).ToLower() == matimkiem.ToLower())
                {
                    sp.Add(item);
                }
            }
            return sp;
        }

        //Lấy danh sách chi tiết sản phẩm theo tên 
        public static List<ChiTietSanPham> GetAllCTSP_TheoTen(string tentimkiem)
        {
            List<ChiTietSanPham> ctsp = new List<ChiTietSanPham>();
            foreach (ChiTietSanPham item in GetAll_ChitietSP())
            {
                string[] tensanpham = item.TenSP.Split(' ');
                foreach (string chuoitimkiem in tensanpham)
                {
                    if (chuoitimkiem.Length >= tentimkiem.Length)
                    {
                        if (chuoitimkiem.Substring(0, tentimkiem.Length).ToLower() == tentimkiem.ToLower())
                        {
                            ctsp.Add(item);
                            break;
                        }
                    }
                    else
                    {
                        if (item.TenSP.Length >= tentimkiem.Length && item.TenSP.Substring(0, tentimkiem.Length).ToLower() == tentimkiem.ToLower())
                        {
                            ctsp.Add(item);
                            break;
                        }
                    }

                }
            }
            return ctsp;
        }

        //Lấy danh sách chi tiết sản phẩm theo mã
        public static List<ChiTietSanPham> GetAllCTSP_TheoMA(string matimkiem)
        {
            List<ChiTietSanPham> ctsp = new List<ChiTietSanPham>();
            foreach (ChiTietSanPham item in GetAll_ChitietSP())
            {
                if (item.MaSP.Length >= matimkiem.Length && item.MaSP.Substring(0, matimkiem.Length).ToLower() == matimkiem.ToLower())
                {
                    ctsp.Add(item);
                }
            }
            return ctsp;
        }

        //Lấy danh sách sản phẩm bán chạy
        public static List<ChiTietSanPham> GetSPBanChay()
        {
            List<ChiTietSanPham> sp = new List<ChiTietSanPham>();
            foreach (ChiTietSanPham sps in GetAll_ChitietSP())
            {
                sps.Soluong = 0;
                foreach (BillDetails item in GetAllBillDetails())
                {
                    if (sps.ChitietSPID == item.ChitietSP_ID)
                    {
                        sps.Soluong += item.Soluong;
                    }
                }

                if (sps.Soluong > 0)
                {
                    sp.Add(sps);
                }
            }

            for (int i = 0; i < sp.Count - 1; i++)
            {
                for (int j = i + 1; j < sp.Count; j++)
                {
                    if (sp[i].Soluong < sp[j].Soluong)
                    {
                        ChiTietSanPham temp = sp[i];
                        sp[i] = sp[j];
                        sp[j] = temp;
                    }
                }
            }

            return sp;
        }

        //Lấy danh sách sản phẩm bán chạy theo thời gian
        public static List<ChiTietSanPham> Get5SPBanChay_TuDo(DateTime ngaybatdau , DateTime ngayketthuc , int sosanpham)
        {
            //Lấy danh sách billdetail trong khoan thời gian 
            List<BillDetails> billDetails = new List<BillDetails>();
            foreach (Bills item in GetAllBills())
            {
                foreach (BillDetails details in GetAllBillDetails())
                {
                    if(item.BillID == details.Bills_ID)
                    {
                        if (ngaybatdau.Year == ngayketthuc.Year && ngaybatdau.Month == ngayketthuc.Month)
                        {
                            if (item.NgaylapBill.Date >= ngaybatdau.Date && item.NgaylapBill.Date <= ngayketthuc.Date)
                            {
                                billDetails.Add(details);
                            }
                        }
                        else if (ngaybatdau.Year == ngayketthuc.Year)
                        {
                            if (item.NgaylapBill.Month > ngaybatdau.Month && item.NgaylapBill.Month < ngayketthuc.Month)
                            {
                                billDetails.Add(details);
                            }
                            else if (item.NgaylapBill.Month == ngaybatdau.Month || item.NgaylapBill.Month == ngayketthuc.Month)
                            {
                                if (item.NgaylapBill.Date >= ngaybatdau.Date && item.NgaylapBill.Date <= ngayketthuc.Date)
                                {
                                    billDetails.Add(details);
                                }
                            }
                        }
                    }    
                }
            }
            //Lấy danh sách các sản phẩm đã bán và số lượng bán
            List<ChiTietSanPham> sps = new List<ChiTietSanPham>();
            foreach (ChiTietSanPham sp in GetAll_ChitietSP())
            {
                sp.Soluong = 0;
                foreach (BillDetails item in billDetails)
                {
                    if (sp.ChitietSPID == item.ChitietSP_ID)
                    {
                        sp.Soluong += item.Soluong;
                    }
                }

                if (sp.Soluong > 0)
                {
                    sps.Add(sp);
                }
            }
            //Sắp xếp lại sanh sách theo tứ tự giảm dần
            for (int i = 0; i < sps.Count - 1; i++)
            {
                for (int j = i + 1; j < sps.Count; j++)
                {
                    if (sps[i].Soluong < sps[j].Soluong)
                    {
                        ChiTietSanPham temp = sps[i];
                        sps[i] = sps[j];
                        sps[j] = temp;
                    }
                }
            }
            //Lọc ra số lượng người dùng muốn thống kê 
            //ví dụ : top 5 sản phẩm bán chạy hoặc .....
            for (int i = 0; i < sps.Count; i++)
            {
                if (sosanpham <= 0)
                {
                    return null;
                }

                if (i >= sosanpham)
                {
                    sps.RemoveAt(i);
                }
            }

            return sps;
        }

        //Lấy danh sách sản phẩm tồn nhiều nhất
        public static List<ChiTietSanPham> GetAll_SP_TonNhieuNhat(int soluongthongke)
        {
            List<ChiTietSanPham> sps = GetAll_ChitietSP();
            for (int i = 0; i < sps.Count - 1; i++)
            {
                for (int j = i + 1; j < sps.Count; j++)
                {
                    if (sps[i].Soluong < sps[j].Soluong)
                    {
                        ChiTietSanPham temp = sps[i];
                        sps[i] = sps[j];
                        sps[j] = temp;
                    }
                }
            }

            for (int i = 0; i < sps.Count; i++)
            {
                if (i >= soluongthongke)
                {
                    sps.RemoveAt(i);
                    i--;
                }
            }
            return sps;
        }

        //Lấy danh sách sản phẩm tồn ít nhất
        public static List<ChiTietSanPham> GetAll_SP_TonItNhat(int soluongthongke)
        {
            List<ChiTietSanPham> sps = GetAll_ChitietSP();
            for (int i = 0; i < sps.Count - 1; i++)
            {
                for (int j = i + 1; j < sps.Count; j++)
                {
                    if (sps[i].Soluong > sps[j].Soluong)
                    {
                        ChiTietSanPham temp = sps[i];
                        sps[i] = sps[j];
                        sps[j] = temp;
                    }
                }
            }

            for (int i = 0; i < sps.Count; i++)
            {
                if (i >= soluongthongke)
                {
                    sps.RemoveAt(i);
                    i--;
                }
            }
            return sps;
        }

        //Lấy danh sách bills theo tên nhân viên bán 
        public static List<Bills> GetBills_TheoTenNV(string tenNV)
        {
            List<Bills> billss = new List<Bills>();
            foreach (Bills item in GetAllBills())
            {
                if(item.TenNhanVien == tenNV)
                {
                    billss.Add(item);
                }
            }
            return billss;
        }

        // Lấy danh sách bills đã thanh toán
        public static List<Bills> GetAllBills_Active()
        {
            List<Bills> bills = new List<Bills>();
            foreach (Bills item in GetAllBills())
            {
                if(item.Active == 1)
                {
                    bills.Add(item);
                }
            }
            return bills;
        }

        //Lấy danh sách bills đã xoá
        public static List<Bills> GetAllBills_InActive()
        {
            List<Bills> bills = new List<Bills>();
            foreach (Bills item in GetAllBills())
            {
                if (item.Active == 0)
                {
                    bills.Add(item);
                }
            }
            return bills;
        }

        #endregion

        #region return bool
        //Lưu sản phẩm
        public static int SaveSP(SanPham obj)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                if (obj != null)
                {
                    if (db.Entry<SanPham>(obj).State == EntityState.Detached)
                        db.Set<SanPham>().Attach(obj);

                    if (obj.SanPhamID == 0)
                        db.Entry<SanPham>(obj).State = EntityState.Added;
                    else
                        db.Entry<SanPham>(obj).State = EntityState.Modified;

                    if (GetAll_ChitietSP() != null)
                    {
                        obj.Soluong = 0;
                        foreach (ChiTietSanPham item in GetAll_ChitietSP())
                        {
                            if (obj.SanPhamID == item.SanPham_ID)
                            {
                                obj.Soluong += item.Soluong;
                            }
                        }
                    }

                    db.SaveChanges();

                    if (sp != null)
                        sp(GetAllSP());

                    return obj.SanPhamID;
                }
                return 0;
            }
        }

        //lưu chi tiết sản phẩm
        public static bool SaveChitietSP(ChiTietSanPham chiTietSanPham)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                if (chiTietSanPham != null)
                {
                    if (db.Entry<ChiTietSanPham>(chiTietSanPham).State == EntityState.Detached)
                        db.Set<ChiTietSanPham>().Attach(chiTietSanPham);

                    if (chiTietSanPham.ChitietSPID == 0)
                        db.Entry<ChiTietSanPham>(chiTietSanPham).State = EntityState.Added;
                    else
                        db.Entry<ChiTietSanPham>(chiTietSanPham).State = EntityState.Modified;

                    db.SaveChanges();

                    if (ctsp != null)
                        ctsp(GetAll_ChitietSP());

                    return true;
                }
                return false;
            }
        }

        //Lưu tài khoản
        public static bool SaveAccount(NguoiDung obj)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                bool ok = true;
                if (obj != null)
                {
                    if (db.Entry<NguoiDung>(obj).State == EntityState.Detached)
                        db.Set<NguoiDung>().Attach(obj);
                    foreach (NguoiDung item in GetAllAccount())
                    {
                        if (obj.TenTK == item.TenTK)
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok)
                        db.Entry<NguoiDung>(obj).State = EntityState.Added;
                    else
                        db.Entry<NguoiDung>(obj).State = EntityState.Modified;

                    db.SaveChanges();

                    return true;
                }
                return false;
            }
        }

        //Xoá đối tượng trên database , Thực hiện không phân biệt là đối tượng nào
        public static bool Delete(object obj)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                if (obj != null)
                {
                    if (db.Entry<object>(obj).State == EntityState.Modified)
                        db.Set<object>().Attach(obj);
                    db.Entry<object>(obj).State = EntityState.Deleted;

                    db.SaveChanges();

                    if (sp != null)
                        sp(GetAllSP());

                    if (ctsp != null)
                        ctsp(GetAll_ChitietSP());

                    if (bill != null)
                        bill(GetAllBills());

                    if (billdetail != null)
                        billdetail(GetAllBillDetails());

                    if (spbanchay != null)
                        spbanchay(GetSPBanChay());


                    return true;
                }
                else return false;
            }
        }

        //Lưu Nhóm Sản Phẩm
        public static bool SaveNhomSP(NhomSP obj)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                if (obj != null)
                {
                    if (db.Entry<NhomSP>(obj).State == EntityState.Detached)
                        db.Set<NhomSP>().Attach(obj);

                    if (obj.NhomspID == 0)
                        db.Entry<NhomSP>(obj).State = EntityState.Added;
                    else
                        db.Entry<NhomSP>(obj).State = EntityState.Modified;


                    db.SaveChanges();

                    return true;
                }
                return false;
            }
        }

        //Lưu Thương Hiệu
        public static bool SaveThuongHieu(ThuongHieu obj)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                if (obj != null)
                {
                    if (db.Entry<ThuongHieu>(obj).State == EntityState.Detached)
                        db.Set<ThuongHieu>().Attach(obj);

                    if (obj.ThuongHieuID == 0)
                        db.Entry<ThuongHieu>(obj).State = EntityState.Added;
                    else
                        db.Entry<ThuongHieu>(obj).State = EntityState.Modified;


                    db.SaveChanges();

                    return true;
                }
                return false;
            }
        }

        //Lưu Chức Vụ
        public static bool SaveChucVU(ChucVu obj)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                if (obj != null)
                {
                    if (db.Entry<ChucVu>(obj).State == EntityState.Detached)
                        db.Set<ChucVu>().Attach(obj);

                    if (obj.ChucVuID == 0)
                        db.Entry<ChucVu>(obj).State = EntityState.Added;
                    else
                        db.Entry<ChucVu>(obj).State = EntityState.Modified;


                    db.SaveChanges();

                    return true;
                }
                return false;
            }
        }

        //Lưu Hoá đơn
        public static int SaveBills(Bills bills)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                if (bills != null)
                {
                    if (db.Entry<Bills>(bills).State == EntityState.Detached)
                        db.Set<Bills>().Attach(bills);

                    if (bills.BillID == 0)
                        db.Entry<Bills>(bills).State = EntityState.Added;
                    else
                        db.Entry<Bills>(bills).State = EntityState.Modified;

                    db.SaveChanges();

                    if (bill != null)
                        bill(GetAllBills());

                    return bills.BillID;
                }
                return 0;
            }
        }

        //Đặt lại mật khẩu
        public static bool ResetPassword(NguoiDung account)
        {
            account.MatKhau = Encodepass("123");
            if (SaveAccount(account)) 
            {
                return true;
            }
            return false;
        }

        //Lưu chi tiết hoá đơn
        public static bool SaveBillDetails(BillDetails billDetails)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                if (billDetails != null)
                {
                    if (db.Entry<BillDetails>(billDetails).State == EntityState.Detached)
                        db.Set<BillDetails>().Attach(billDetails);

                    if (billDetails.BillDetailID == 0)
                        db.Entry<BillDetails>(billDetails).State = EntityState.Added;
                    else
                        db.Entry<BillDetails>(billDetails).State = EntityState.Modified;

                    db.SaveChanges();

                    if (billdetail != null)
                        billdetail(GetAllBillDetails());


                    if (spbanchay != null)
                        spbanchay(GetSPBanChay());

                    return true;
                }
                return false;
            }
        }

        //Kiểm tra số điện thoại hợp lệ
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }

        //Lưu nhập hàng
        public static int SaveNhapHang(NhapHang obj)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                if (obj != null)
                {
                    if (db.Entry<NhapHang>(obj).State == EntityState.Detached)
                        db.Set<NhapHang>().Attach(obj);

                    if (obj.NhapHangID == 0)
                        db.Entry<NhapHang>(obj).State = EntityState.Added;
                    else
                        db.Entry<NhapHang>(obj).State = EntityState.Modified;


                    db.SaveChanges();

                    if (sp != null)
                        sp(GetAllSP());

                    if (nhaphang != null)
                        nhaphang(GetAll_NhapHang());

                    return obj.NhapHangID;
                }
                return 0;
            }
        }

        //Lưu chi tiết phiếu nhập
        public static bool SaveCTNhapHang(ChitietNhapHang obj)
        {
            using (TshoesModelContext db = new TshoesModelContext())
            {
                if (obj != null)
                {
                    if (db.Entry<ChitietNhapHang>(obj).State == EntityState.Detached)
                        db.Set<ChitietNhapHang>().Attach(obj);

                    if (obj.ChitietNhaphangID == 0)
                        db.Entry<ChitietNhapHang>(obj).State = EntityState.Added;
                    else
                        db.Entry<ChitietNhapHang>(obj).State = EntityState.Modified;


                    db.SaveChanges();

                    if (sp != null)
                        sp(GetAllSP());

                    if (ctsp != null)
                        ctsp(GetAll_ChitietSP());

                    if (ctnhaphang != null)
                        ctnhaphang(GetAll_ChiTietNhapHang());



                    return true;
                }
                return false;
            }
        }
        #endregion


        #region return object
        //Tìm sản phẩm theo mã sản phẩm
        public static SanPham Tim_SP_TheoMA(string MaSP)
        {
            foreach (SanPham item in GetAllSP())
            {
                if(item.MaSanPham == MaSP)
                {
                    return item;
                }
            }
            return null;
        }

        //tìm sản phẩm theo ID sản phẩm
        public static SanPham Tim_SP_TheoID(int id)
        {
            foreach (SanPham item in GetAllSP())
            {
                if (item.SanPhamID == id)
                {
                    return item;
                }
            }
            return null;
        }

        //Tìm sản phẩm theo tên sản phẩm
        public static SanPham Tim_SP_TheoTenSP(string TenSP)
        {
            foreach (SanPham item in GetAllSP())
            {
                if (item.TenSanPham == TenSP)
                {
                    return item;
                }
            }
            return null;
        }
        
        //Tìm chi tiết sản phẩm theo ID
        public static ChiTietSanPham Tim_CTSP_TheoID(int id)
        {
            foreach (ChiTietSanPham item in GetAll_ChitietSP())
            {
                if (item.ChitietSPID == id)
                {
                    return item;
                }
            }
            return null;
        }

        //Tìm tài khoản theo Tên nhân viên
        public static NguoiDung Tim_Account_TheoTenTK(string Tennhanvien)
        {
            foreach (NguoiDung item in GetAllAccount())
            {
                if (item.Fullname == Tennhanvien)
                {
                    return item;
                }
            }
            return null;
        }
        //Tìm chức vụ theo tên
        public static ChucVu Tim_chucVu_theoTen(string TenChucVu)
        {
            foreach (var item in GetAllChucvu())
            {
                if (item.TenChucVu == TenChucVu)
                {
                    return item;
                }
            }
            return null;
        }
        //tìm nhóm sản phẩm theo tên
        public static NhomSP timNhomSP_theoten(string tennhomsp)
        {
            foreach (var item in DBConTExt.GetAllNhomSP())
            {
                if(item.TenNhomSP == tennhomsp)
                {
                    return item;
                }
            }
            return null;
        }
        //tìm thương hiệu theo tên
        public static ThuongHieu timthuonghieu_theoten(string tenthuonghieu)
        {
            foreach (var item in DBConTExt.GetAllThuongHieu())
            {
                if (item.TenThuongHieu == tenthuonghieu)
                {
                    return item;
                }
            }
            return null;
        }
        #endregion



        #region return string
        //Mã hoá mật khẩu Mã hoá chuẩn base64
        public static string Encodepass(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        //Giải Mã mất khẩu 
        public static string Decodepass(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        //Tìm tên thương hiệu từ ID 
        public static string GetTenThuongHieu(int thuonghieuid)
        {
            foreach (ThuongHieu item in GetAllThuongHieu())
            {
                if (item.ThuongHieuID == thuonghieuid)
                {
                    return item.TenThuongHieu;
                }
            }
            return null;
        }

        //tìm tên chức vụ từ id
        public static string GetTenChucVu(int chucvuid)
        {
            foreach (ChucVu item in GetAllChucvu())
            {
                if (item.ChucVuID == chucvuid)
                {
                    return item.TenChucVu;
                }
            }
            return null;
        }

        //tìm tên nhóm sản phẩm từ id
        public static string GetTenNhomSP(int nhomspid)
        {
            foreach (NhomSP item in GetAllNhomSP())
            {
                if (item.NhomspID == nhomspid)
                {
                    return item.TenNhomSP;
                }
            }
            return null;
        }
        #endregion

        #region return int
        //Tìm ID nhóm sản phẩm từ Tên nhóm sp
        public static int FindID_NhomSP(string TenNhomSP)
        {
            foreach (NhomSP item in GetAllNhomSP())
            {
                if(item.TenNhomSP == TenNhomSP)
                {
                    return item.NhomspID;
                }
            }
            return 0;
        }

        //tìm id thương hiệu từ tên thương hiệu
        public static int FindID_ThuongHieu(string TenThuongHieu)
        {
            foreach (ThuongHieu item in GetAllThuongHieu())
            {
                if (item.TenThuongHieu == TenThuongHieu)
                {
                    return item.ThuongHieuID;
                }
            }
            return 0;
        }
        
        //Tính tổng tiền nhập hàng 
        public static double TongTienNhapHang(List<ChiTietSanPham> chiTietSanPhams)
        {
            double Total = 0;
            foreach (ChiTietSanPham item in chiTietSanPhams)
            {
                SanPham sanPham = Tim_SP_TheoMA(item.MaSP);
                Total += item.Soluong * sanPham.GiaNhap;
            }
            return Total;
        }

        #endregion
    }
}

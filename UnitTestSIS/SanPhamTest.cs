using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DTO;
using TShoes;

namespace UnitTestSIS
{
    [TestClass]
    public class SanPhamTest
    {
        [TestMethod]
        public void SanPham_isNull()
        {
            var result = DBConTExt.GetAllSP();
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void ThemSP_test()
        {
            var result = DBConTExt.SaveSP(new SanPham()
            {
                MaSanPham = "SP01",
                TenSanPham = "Nike sport",
                NhomSP_ID = 1,
                ThuongHieu_ID = 2,
                GiaNhap = 500000,
                Giaban = 700000,
                Ngaynhap = DateTime.Now,
                Soluong = 0
            });
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DeleteSP_test()
        {
            var sanpham = DBConTExt.Tim_SP_TheoMA("SP01");
            var result = DBConTExt.Delete(sanpham);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Tim_SP_TheoMA_test()
        {
            var result = DBConTExt.GetAllSP_TheoMA("CTK42");
            Assert.IsNotNull(result);
        }
    }
}

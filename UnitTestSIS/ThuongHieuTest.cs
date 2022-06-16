using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DTO;
using TShoes;

namespace UnitTestSIS
{
    [TestClass]
    public class ThuongHieuTest
    {
        [TestMethod]
        public void ThuongHieu_isnull_test()
        {
            var result = DBConTExt.GetAllThuongHieu();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void them_ThuongHieu_test()
        {
            var result = DBConTExt.SaveThuongHieu(new ThuongHieu()
            {
                TenThuongHieu = "Cubit"
            });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void xoa_thuonghieu_test()
        {
            var thuonghieu = DBConTExt.timthuonghieu_theoten("Cubit");
            var result = DBConTExt.Delete(thuonghieu);
            Assert.IsTrue(result);
        }
    }
}

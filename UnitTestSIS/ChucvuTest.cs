using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TShoes;

namespace UnitTestSIS
{
    [TestClass]
    public class ChucvuTest
    {

        [TestMethod]
        public void ChucVu_isNull_Test()
        {
            var result = DBConTExt.GetAllChucvu();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Add_chucVu_test()
        {
            bool result = DBConTExt.SaveChucVU(new ChucVu
            {
                TenChucVu = "User"
            });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void tim_chucVu_test()
        {
            string tenChucVu = "User";
            var result = DBConTExt.Tim_chucVu_theoTen(tenChucVu);
            Assert.AreEqual(result.TenChucVu, tenChucVu);
        }

        [TestMethod]
        public void delete_chucVu_test()
        {
            string tenChucVu = "User";
            var chucvu = DBConTExt.Tim_chucVu_theoTen(tenChucVu);
            var result = DBConTExt.Delete(chucvu);
            Assert.IsTrue(result);
        }
    }
}

using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TShoes;

namespace UnitTestSIS
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void Account_isnull_test()
        {
            var result = DBConTExt.GetAllAccount();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Add_account_test()
        {
            var result = DBConTExt.SaveAccount(new NguoiDung
            {
                TenTK = "coder",
                MatKhau = DBConTExt.Encodepass("123"),
                Fullname = "Toan Coder",
                Chucvu_ID = 1,
                Active = 1,
                Ngaykhoitao = DateTime.Now
            });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void get_account_test()
        {
            string TenTK = "Quốc Toàn";
            var result = DBConTExt.Tim_Account_TheoTenTK(TenTK);
            Assert.AreEqual(TenTK, result.Fullname);
        }

        [TestMethod]
        public void delete_account_test()
        {
            string TenTK = "Toan Coder";
            var nv = DBConTExt.Tim_Account_TheoTenTK(TenTK);
            var result = DBConTExt.Delete(nv);
            Assert.IsTrue(result);
        }
    }
}

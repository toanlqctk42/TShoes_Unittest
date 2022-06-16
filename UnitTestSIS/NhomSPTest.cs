using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DTO;
using TShoes;

namespace UnitTestSIS
{
    [TestClass]
    public class NhomSPTest
    {
        [TestMethod]
        public void NhomSP_isnull_test()
        {
            var result = DBConTExt.GetAllNhomSP();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void them_NhomSP_test()
        {
            var result = DBConTExt.SaveNhomSP(new NhomSP()
            {
                TenNhomSP = "Giày cho người lớn tuổi"
            });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void xoa_nhomSP_test()
        {
            var nhomsp = DBConTExt.timNhomSP_theoten("Giày cho người lớn tuổi");
            var result = DBConTExt.Delete(nhomsp);
            Assert.IsTrue(result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DTO;
using TShoes;

namespace UnitTestSIS
{
    [TestClass]
    public class CTSPTest
    {
        [TestMethod]
        public void CTSP_isNull_test()
        {
            var result = DBConTExt.GetAll_ChitietSP();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void getDS_ctsp_theomaSP_test()
        {
            var result = DBConTExt.GetAllCTSP_TheoMA("SP01");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void getDS_ctsp_theotenSP_test()
        {
            var result = DBConTExt.GetAllCTSP_TheoTen("Rambo");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void getDS_ctsp_theoSP_id_test()
        {
            var result = DBConTExt.GetAll_ChitietSP_TheoID(1);
            Assert.IsNotNull(result);
        }
    }
}

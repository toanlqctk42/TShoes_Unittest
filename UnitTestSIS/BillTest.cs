using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DTO;
using TShoes;

namespace UnitTestSIS
{
    [TestClass]
    public class BillTest
    {
        [TestMethod]
        public void bill_isnull_test()
        {
            var result = DBConTExt.GetAllBills();
            Assert.IsNotNull(result);
        }

        
        [TestMethod]
        public void get_bill_theotenNV_test()
        {
            var result = DBConTExt.GetBills_TheoTenNV("Quốc Toàn");
            Assert.IsNotNull(result);
        }
    }
}

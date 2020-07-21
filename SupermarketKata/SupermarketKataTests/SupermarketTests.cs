using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http.Headers;
using SupermarketKata;

namespace SupermarketKataTests
{
    [TestClass]
    public class SalesTests
    {
        Supermarket sm = Supermarket.GetInstance();

        [TestMethod]
        public void TestStandardPriceItems()
        {
            Assert.AreEqual(3.25, sm.PriceSale("Tin of Beans", 5, "single"));
        }

        [TestMethod]
        public void TestThreeProductsOnThreeForAPound()
        {
            Assert.AreEqual(1, sm.PriceSale("Crisps", 3, "single"));
        }

        [TestMethod]
        public void TestFiveProductsOnTheeForAPound()
        {
            Assert.AreEqual(1.8, sm.PriceSale("Crisps", 5, "single"));
        }

        [TestMethod]
        public void TestBuyTwoGetOneFree()
        {
            Assert.AreEqual(5, sm.PriceSale("Soap", 3, "single"));
        }

        [TestMethod]
        public void TestPurchaseByWeight()
        {
            Assert.AreEqual(7, sm.PriceSale("Beef", 3.5, "kg"));
        }
    }
}

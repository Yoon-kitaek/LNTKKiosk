using LNTKKiosk.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.UnitTest
{
    [TestClass]
    public class EventProductDataTest
    {
        [TestMethod]
        public void Get()
        {
            EventProduct eventProduct = DataRepository.EventProduct.Get(1,1);

            Assert.AreEqual(10, eventProduct.DiscountRate);
        }
        [TestMethod]
        public void GetByProduct()
        {
            List<EventProduct> eventProducts = DataRepository.EventProduct.GetByProduct(3);

            Assert.AreEqual(2, eventProducts.Count);
        }

    }
}

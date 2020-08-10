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
    public class OrderDataTest
    {
        [TestMethod]
        public void Get()
        {
            Order order = DataRepository.Order.Get(1);

            Assert.AreEqual(true, order.IsCompleted);
        }

        [TestMethod]
        public void GetwithCompleted()
        {
            var order = DataRepository.Order.GetwithCompleted();

            Assert.IsNotNull(order);
        }

        [TestMethod]
        public void GetwithNonCompleted()
        {
            var order = DataRepository.Order.GetwithNonCompleted();

            Assert.IsNotNull(order);
        }
    }
}

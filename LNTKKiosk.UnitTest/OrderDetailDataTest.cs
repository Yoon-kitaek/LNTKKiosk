using LNTKKiosk.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.UnitTest
{
    [TestClass]
    public class OrderDetailDataTest
    {
        [TestMethod]
        public void Get()
        {
            OrderDetail orderDetail = DataRepository.OrderDetail.Get(1);

            Assert.AreEqual(1, orderDetail.ProductId);
        }

        [TestMethod]
        public void GetAllWithProperties()
        {
            List<OrderDetail> orderDetails = DataRepository.OrderDetail.GetAllWithProperties();

            Assert.IsTrue(orderDetails.Count > 0);
        }

        [TestMethod]
        public void GetCountByOrder()
        {
            int count = DataRepository.OrderDetail.GetCountByOrder(1);

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void GetByOrderWithProduct()
        {
            List<OrderDetail> orderDetails = DataRepository.OrderDetail.GetByOrderWithProduct(1);

            Assert.AreEqual(2, orderDetails.Count);
        }

        [TestMethod]
        public void GetwithNonCompletedOrderDetail()
        {
            var order = DataRepository.OrderDetail.GetwithNonCompletedOrderDetail();

            Assert.IsNotNull(order);
        }
    }
}

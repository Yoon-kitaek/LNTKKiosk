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
    }
}

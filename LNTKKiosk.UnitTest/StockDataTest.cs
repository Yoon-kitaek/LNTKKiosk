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
    public class StockDataTest
    {
        [TestMethod]
        public void Get()
        {
            Stock stock = DataRepository.Stock.Get(1);

            Assert.AreEqual(800, stock.Price);
        }
    }
}

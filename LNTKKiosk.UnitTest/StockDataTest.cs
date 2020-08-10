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

        [TestMethod]
        public void GetByGroceryId()
        {
            List<Stock> stocks = DataRepository.Stock.GetByGroceryId(2);

            Assert.AreEqual(2, stocks.Count);
        }

        [TestMethod]
        public void GetAllWithProperties()
        {
            List<Stock> stocks = DataRepository.Stock.GetAllWithProperties();

            Assert.IsTrue(stocks.Count > 0);
        }
    }
}

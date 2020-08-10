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
    public class ProductDataTest
    {
        [TestMethod]
        public void Get()
        {
            Product product = DataRepository.Product.Get(1);

            Assert.AreEqual("치킨불고기버거", product.Name);
        }

        [TestMethod]
        public void FilterbyCatergory()
        {
            List<Product> products = DataRepository.Product.FilterbyCatergory(10);

            Assert.IsTrue(products.Count > 0);
        }

        [TestMethod]
        public void GetByName()
        {
            Product product = DataRepository.Product.GetByName("치킨불고기버거");

            Assert.AreEqual(product.Name, "치킨불고기버거");
        }

        [TestMethod]
        public void GetDiscountRate()
        {
            Product product = DataRepository.Product.Get(1);

            int discountRate = DataRepository.Product.GetDiscountRate(product);

            Assert.AreEqual(10, discountRate);
        }

        [TestMethod]
        public void SearchByCategoryId()
        {
            List<ProductPartial> productPartials = DataRepository.Product.SearchByCategoryId(10);

            Assert.IsTrue(productPartials.Count > 0);
        }

        [TestMethod]
        public void GetAllPartial()
        {
            List<ProductPartial> productPartials = DataRepository.Product.GetAllPartial();

            Assert.IsTrue(productPartials.Count > 0);
        }

    }
}

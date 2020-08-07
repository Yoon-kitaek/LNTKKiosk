using System;
using System.Collections.Generic;
using System.Linq;
using LNTKKiosk.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LNTKKiosk.DataLNTK.UnitTest.Data
{
    [TestClass]
    public class EntityDataTests
    {
        public class EntityDataTest<T> where T : class
        {
            [TestMethod()]
            public void CreateContext()
            {
                LNTKEntities context = new LNTKEntities();
                context.Configuration.ProxyCreationEnabled = false;

                Assert.IsTrue(context.Products.Count() > 0);
            }
            public void GetAll()
            {
                List<Product> products = DataRepository.Product.GetAll();

                Assert.IsTrue(products.Count > 0);
            }

            public void GetCount()
            {
                int count = DataRepository.Product.GetCount();

                Assert.IsTrue(count > 0);
            }

            public void Insert()
            {
                int oldCount = DataRepository.Product.GetCount();

                Product product = new Product();
                product.Name = DateTime.Now.ToString();
                product.Description = "Test용입니다.";
                product.Price = 1;
                product.CodeCategoryId = 1;

                DataRepository.Product.Insert(product);

                int newCount = DataRepository.Product.GetCount();

                Assert.AreEqual(oldCount + 1, newCount);
            }

            public void Update()
            {
                Product product = DataRepository.Product.Get(28);
                string oldName = product.Name;

                product.Name = DateTime.Now.ToString();

                DataRepository.Product.Update(product);

                product = DataRepository.Product.Get(28);

                Assert.AreNotEqual(oldName, product.Name);
            }

            public void Delete()
            {
                Product product = new Product();
                product.Name = DateTime.Now.ToString();
                product.Description = "Test용입니다.";
                product.Price = 1;
                product.CodeCategoryId = 1;

                DataRepository.Product.Delete(product);

                int oldCount = DataRepository.Product.GetCount();

                int maxProductId = DataRepository.Product.GetMaxId();
                DataRepository.Product.Delete(maxProductId);

                int newCount = DataRepository.Product.GetCount();

                Assert.AreEqual(oldCount - 1, newCount);
            }
        }
    }
}

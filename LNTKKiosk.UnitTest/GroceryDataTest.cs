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
    public class GroceryDataTest
    {
        [TestMethod]
        public void Get()
        {
            Grocery grocery = DataRepository.Grocery.Get(1);

            Assert.AreEqual("소고기패티", grocery.Item);
        }

    }
}

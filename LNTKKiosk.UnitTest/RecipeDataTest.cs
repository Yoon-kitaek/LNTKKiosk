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
    public class RecipeDataTest
    {
        [TestMethod]
        public void Get()
        {
            Recipe recipe = DataRepository.Recipe.Get(1, 1);

            Assert.AreEqual(1, recipe.Amount);
        }
    }
}

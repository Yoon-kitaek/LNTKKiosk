﻿using LNTKKiosk.Data;
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
            Recipe recipe = DataRepository.Recipe.Get(1, 2);

            Assert.AreEqual(1, recipe.Amount);
        }

        [TestMethod]
        public void GetByProduct()
        {
            List<Recipe> recipes = DataRepository.Recipe.GetByProduct(1);

            Assert.IsTrue(recipes.Count > 0);
        }

        [TestMethod]
        public void GetAllWithProperties()
        {
            List<Recipe> recipes = DataRepository.Recipe.GetAllWithProperties();

            Assert.IsTrue(recipes.Count > 0);
        }
    }
}

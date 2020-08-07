using System;
using System.Collections.Generic;
using LNTKKiosk.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LNTKKiosk.UnitTest
{
    [TestClass]
    public class CodeCategoryDataTest
    {
        [TestMethod]
        public void Get()
        {
            CodeCategory codeCategory = DataRepository.CodeCategory.Get(1);

            Assert.AreEqual("패티", codeCategory.Item);
        }

        [TestMethod]
        public void GetMenuCategory()
        {
            List<CodeCategory> codeCategories = new List<CodeCategory>();

            codeCategories.Add(DataRepository.CodeCategory.Get(10));
            codeCategories.Add(DataRepository.CodeCategory.Get(11));
            codeCategories.Add(DataRepository.CodeCategory.Get(12));

            Assert.AreEqual(3, codeCategories.Count);
        }
    }
}

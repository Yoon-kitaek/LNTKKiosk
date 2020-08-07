using Microsoft.VisualStudio.TestTools.UnitTesting;
using LNTKKiosk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data.Tests
{
    [TestClass()]
    public class CodeCategoryDataTests
    {
        [TestMethod()]
        public void Get()
        {
            CodeCategory codeCategory = DataRepository.CodeCategory.Get(1);

            Assert.AreEqual("패티", codeCategory.Item);
        }

        [TestMethod()]
        public void GetMenuCategory()
        {
            List<CodeCategory> codeCategories = new List<CodeCategory>();

            codeCategories.Add(DataRepository.CodeCategory.Get(10));
            codeCategories.Add(DataRepository.CodeCategory.Get(11));
            codeCategories.Add(DataRepository.CodeCategory.Get(12));

            Assert.IsTrue(3 == codeCategories.Count());
        }
    }
}
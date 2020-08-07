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
    public class EventDataTest
    {
        [TestMethod]
        public void Get()
        {
            Event @event = DataRepository.Event.Get(1);

            Assert.AreEqual("킹올데이", @event.Name);
        }
    }
}

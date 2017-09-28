using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweHorwath.Ralph.HelloService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwath.Ralph.HelloService.Controllers.Tests
{
    [TestClass()]
    public class HelloControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            HelloController c = new HelloController();
            Assert.AreEqual("Hello World", c.Get());
        }

        [TestMethod()]
        public void GetTestName()
        {
            HelloController c = new HelloController();
            Assert.AreEqual("Hello Ralph", c.Get("Ralph"));
        }
    }
}
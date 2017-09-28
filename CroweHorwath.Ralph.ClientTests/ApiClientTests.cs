using Microsoft.VisualStudio.TestTools.UnitTesting;
using CroweHorwath.Ralph.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwath.Ralph.Client.Tests
{
    [TestClass()]
    public class ApiClientTests
    {
        [TestMethod()]
        public void GetAsyncTest()
        {
            ApiClient client = new ApiClient("http://localhost:51262/api/hello");
            Assert.AreEqual("\"Hello World\"", client.GetAsync().Result);
            
        }

        [TestMethod()]
        [ExpectedException(typeof(System.AggregateException))]
        public void BrokenClientTest()
        {
            ApiClient client = new ApiClient("http://localhost:55555/api/hello");
            string throwException = client.GetAsync().Result;

        }
    }
}
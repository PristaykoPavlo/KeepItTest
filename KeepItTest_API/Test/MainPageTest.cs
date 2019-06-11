using KeepItTest_API.RestSharpHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItTest_API.Test
{
    [TestClass]
    public class MainPageTest
    {
        private KeepItEndpoints _endpoints;

        public MainPageTest()
        {
            _endpoints = new KeepItEndpoints("https://ws-test.keepit.com/");
        }

        [TestMethod]
        public void GetUser_API_Test()
        {
            var resp = _endpoints.GetUser();
            Assert.IsNotNull(resp);
           
        }
    }
}

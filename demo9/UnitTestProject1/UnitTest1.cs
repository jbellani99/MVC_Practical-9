using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using demo9.Controllers;
using System.Runtime.InteropServices;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test3Controller hc = new Test3Controller();

            ViewResult result = hc.Index() as ViewResult;



            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello world", result.ViewBag.message);
        }
    }
}

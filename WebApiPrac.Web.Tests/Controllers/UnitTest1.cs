using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiPrac.Web.Controllers;
using WebApiPrac.Web.Adapters.MockDataAdapters;

namespace WebApiPrac.Web.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        apiJobsController _controller;
        [TestInitialize]
        public void Init()
        {
            _controller = new apiJobsController(new JobMockAdapter());

        }
        [TestMethod]
        public void TestMethod1()

        {
            //Act
            
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiPrac.Web.Controllers;
using WebApiPrac.Web.Adapters.MockDataAdapters;
using System.Collections.Generic;
using System.Web.Http.Results;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Tests.Controllers
{
    [TestClass]
    public class apiJobControllerTest
    {
        apiJobsController _controller;
        [TestInitialize]
        public void Init()
        {
            _controller = new apiJobsController(new JobMockAdapter());
            
        }
        [TestMethod]
        public void GetJobsTestMethod()
        {
            //Act
            var result = _controller.Get(); 
            
            //Assert
            var response = result as OkNegotiatedContentResult<List<Job>>;
            Assert.IsNotNull(response);

            var jobs = response.Content;
            Assert.AreEqual(3, jobs.Count);

        }
        [TestMethod]
        public void PostNewJobMethod()
        {
            //Arrange
            var controller = new apiJobsController();

            //Act
            var ActionResult = _controller.Post(new Job { JobTitle = "new Title", JobDescription = "New Description" });

            //Assert
            var response = ActionResult as CreatedAtRouteNegotiatedContentResult<Job>;

            Assert.IsNotNull(response);
            Assert.AreEqual(response.Content.Id, response.RouteValues["Id"]);

        }
    }
}

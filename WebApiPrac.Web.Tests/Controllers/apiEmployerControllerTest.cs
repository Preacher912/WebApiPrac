using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using WebApiPrac.Web.Adapters.MockDataAdapters;
using WebApiPrac.Web.Controllers;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Tests.Controllers
{
    [TestClass]
    class apiEmployerControllerTest
    {
        apiEmployerController _controller;
        [TestInitialize]
        public void Init()
        {
            _controller = new apiEmployerController(new EmployerMockAdapter());
        }
        [TestMethod]
        public void GetEmployersTestMethod()
        {
            //Act
            var result = _controller.Get();

            //Assert
            var response = result as OkNegotiatedContentResult<List<Employer>>;
            Assert.IsNotNull(response);

            var employers = response.Content;
            Assert.AreEqual(3, employers.Count);
        }



    }
}

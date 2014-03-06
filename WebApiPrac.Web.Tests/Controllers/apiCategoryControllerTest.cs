using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiPrac.Web.Controllers;
using System.Collections.Generic;
using WebApiPracDataModels;
using WebApiPrac.Web.Adapters.MockDataAdapters;
using System.Web.Http.Results;

namespace WebApiPrac.Web.Tests.Controllers
{
    [TestClass]
    public class apiCategoryControllerTest
    {
        apiCategoriesController _controller;
        [TestInitialize]
        public void Init()
        {
            _controller = new apiCategoriesController(new CategoryMockAdapter());

        }
        [TestMethod]
        public void GetCategoriesTestMethod()
        {
            //Act
            var result = _controller.Get();

            //Assert
            var response = result as OkNegotiatedContentResult<List<Category>>;
            Assert.IsNotNull(response);

            var categories = response.Content;
            Assert.AreEqual(1, categories.Count);

        }
        [TestMethod]
        public void PostNewCategoryMethod()
        {
            //Arrange
            var controller = new apiCategoriesController();

            //Act
            var ActionResult = _controller.Post(new Category { CategoryName="CODYWASHERE" });

            //Assert
            var response = ActionResult as CreatedAtRouteNegotiatedContentResult<Category>;

            Assert.IsNotNull(response);
            Assert.AreEqual(response.Content.Id, response.RouteValues["Id"]);

        }
    }
}

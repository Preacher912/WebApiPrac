using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPrac.Web.Adapters.Interfaces;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Adapters.MockDataAdapters
{
    public class CategoryMockAdapter : ICategoryAdapter
    {

        public List<WebApiPracDataModels.Category> GetCategories()
        {
            List<Category> Categories = new List<Category>()
            {
                new Category { Id=1, CategoryName="Administrator" }
            };
            return Categories;
        }
        public List<Category> GetCategory(int id)
        {
            List<Category> model = new List<Category>()
            {
                new Category { Id=1, CategoryName="Administrator"}
            };

            return model;
        }


        public List<Category> PostNewCategory(Category newCategory)
        {
            List<Category> Categories = new List<Category>()
            {
                new Category { Id=1, CategoryName="Administrator" }
            };
            Category category = new Category();
            category.Id = newCategory.Id;
            category.CategoryName = newCategory.CategoryName;
            Categories.Add(category);

            return Categories;
        }
    }
}
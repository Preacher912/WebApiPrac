using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPrac.Web.Adapters.Interfaces;
using WebApiPracData;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Adapters.JobDataAdapters
{
    public class CategoryDataAdapter : ICategoryAdapter
    {
        public List<WebApiPracDataModels.Category> GetCategories()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Category> categories = new List<Category>();
            categories = db.Categories.ToList();
            return categories;
        }


        public List<Category> GetCategory(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Category> categories = new List<Category>();
            categories = db.Categories.Where(i => i.Id == id).ToList();
            return categories;
        }


        public List<Category> PostNewCategory(Category newCategory)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Category category = new Category();
            category.CategoryName = newCategory.CategoryName;
            

            db.Categories.Add(category);
            db.SaveChanges();

            return db.Categories.ToList();
        }
    }
}
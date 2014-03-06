using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Adapters.Interfaces
{
    public interface ICategoryAdapter
    {
        List<Category> GetCategories();
        List<Category> GetCategory(int id);
        List<Category> PostNewCategory(Category newCategory);
    }
}

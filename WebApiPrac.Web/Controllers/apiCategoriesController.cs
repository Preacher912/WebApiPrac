using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPrac.Web.Adapters.Interfaces;
using WebApiPrac.Web.Adapters.JobDataAdapters;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Controllers
{

    public class apiCategoriesController : ApiController
    {
        ICategoryAdapter _adapter;
        public apiCategoriesController()
        {
            _adapter = new CategoryDataAdapter();
        }
        public apiCategoriesController(ICategoryAdapter adapter)
        {
            _adapter = adapter;
        }

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var category = _adapter.GetCategories();
            return Ok(category);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            List<Category> categories = new List<Category>();
            categories = _adapter.GetCategory(id);
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Category newCategory)
        {
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }
            var model = _adapter.PostNewCategory(newCategory);
            return CreatedAtRoute("apiCategories", new { newCategory.Id }, newCategory);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
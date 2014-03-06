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
    public class apiEmployerController : ApiController
    {
        IEmployerInterface _adapter;
        public apiEmployerController()
        {
            _adapter = new EmployerDataAdapter();
        }
        public apiEmployerController(IEmployerInterface adapter)
        {
            _adapter = adapter;
        }

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var employers = _adapter.GetEmployers();
            return Ok(employers);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            Employer employer = new Employer();
            employer = _adapter.GetEmployer(id);
            if (employer == null)
            {
                return NotFound();
            }
            return Ok(employer);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
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
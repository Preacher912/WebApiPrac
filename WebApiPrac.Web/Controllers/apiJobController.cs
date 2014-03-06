using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPrac.Web.Adapters.Interfaces;
using WebApiPrac.Web.Adapters.JobDataAdapters;
using WebApiPracData;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Controllers
{
    public class apiJobController : ApiController
    {
        IJobInterface _adapter;
        public apiJobController()
        {
            _adapter = new JobDataAdapter();
        }

        public apiJobController(IJobInterface adapter)
        {
            _adapter = adapter;
        }
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Job> jobs = new List<Job>();
            jobs = db.Jobs.ToList();
            return Ok(jobs);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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
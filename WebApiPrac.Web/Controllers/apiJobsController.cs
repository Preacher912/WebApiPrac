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
    public class apiJobsController : ApiController
    {
        IJobInterface _adapter;
        public apiJobsController()
        {
            _adapter = new JobDataAdapter();
        }
        public apiJobsController(IJobInterface adapter)
        {
            _adapter = adapter;
        }

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var jobs = _adapter.GetJobs();
            return Ok(jobs);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            List<Job> jobs = new List<Job>();
            jobs = _adapter.GetJob(id);
            if (jobs == null)
            {
                return NotFound();
            }
            return Ok(jobs);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Job newJob)
        {
            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState); 
            }
            var model = _adapter.PostNewJob(newJob);
            return CreatedAtRoute("apiJobs", new { newJob.Id }, newJob);
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
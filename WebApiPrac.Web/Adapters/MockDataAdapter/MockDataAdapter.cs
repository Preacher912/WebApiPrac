using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPrac.Web.Adapters.Interfaces;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Adapters.MockDataAdapter
{
    public class MockDataAdapter : IJobInterface
    {
        public List<WebApiPracDataModels.Job> GetJobs()
        {
            List<Job> Jobs = new List<Job>()
            {
              new Job { Id=1, JobTitle="Title1", JobDescription="Description1", EmployerId=1, CategoryId=1 },
              new Job { Id=2, JobTitle="Title1", JobDescription="Description1", EmployerId=2, CategoryId=1 },
              new Job { Id=3, JobTitle="Title1", JobDescription="Description1", EmployerId=3, CategoryId=1 }
            };
            return Jobs;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPrac.Web.Adapters.Interfaces;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Adapters.MockDataAdapters
{
    public class JobMockAdapter : IJobInterface
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
        public List<Job> GetJob(int id)
        {
            List<Job> model = new List<Job>()
            {
                new Job { Id=1, JobTitle="Title1", JobDescription="Description1", EmployerId=1, CategoryId=1 }
            };
            
            return model;
        }


        public List<Job> PostNewJob(Job newJob)
        {
            List<Job> Jobs = new List<Job>()
            {
                new Job { Id=1, JobTitle="Title1", JobDescription="Description1", EmployerId=1, CategoryId=1 },
                new Job { Id=2, JobTitle="Title1", JobDescription="Description1", EmployerId=2, CategoryId=1 },
                new Job { Id=3, JobTitle="Title1", JobDescription="Description1", EmployerId=3, CategoryId=1 }
            };
            Job job = new Job();
            job.Id = newJob.Id;
            job.JobTitle = newJob.JobTitle;
            job.JobDescription = newJob.JobDescription;
            Jobs.Add(job);

            return Jobs;
        }
    }
}
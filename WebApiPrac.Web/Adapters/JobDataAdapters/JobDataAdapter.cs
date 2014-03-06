using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPrac.Web.Adapters.Interfaces;
using WebApiPracData;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Adapters.JobDataAdapters
{
    public class JobDataAdapter : IJobInterface
    {
        public List<WebApiPracDataModels.Job> GetJobs()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Job> jobs = new List<Job>();
            jobs = db.Jobs.ToList();
            return jobs;
        }


        public List<Job> GetJob(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Job> jobs = new List<Job>();
            jobs = db.Jobs.Where(i => i.Id == id).ToList();
            return jobs;
        }


        public List<Job> PostNewJob(Job newJob)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Job job = new Job();
            job.JobTitle = newJob.JobTitle;
            job.JobDescription = newJob.JobDescription;

            db.Jobs.Add(job);
            db.SaveChanges();

            return db.Jobs.ToList();
        }
    }
}
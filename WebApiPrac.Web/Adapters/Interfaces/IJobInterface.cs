using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Adapters.Interfaces
{
   public interface IJobInterface
    {
       List<Job> GetJobs();
       List<Job> GetJob(int id);
       List<Job> PostNewJob(Job newJob);
    }
}

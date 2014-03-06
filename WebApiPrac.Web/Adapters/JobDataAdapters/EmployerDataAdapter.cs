using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPrac.Web.Adapters.Interfaces;
using WebApiPracData;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Adapters.JobDataAdapters
{
    public class EmployerDataAdapter : IEmployerInterface

    {
        public List<Employer> GetEmployers()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Employer> employers = new List<Employer>();
            employers = db.Employers.ToList();
            return employers;
        }

        public Employer GetEmployer(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Employer employer = new Employer();
            employer = db.Employers.Find(id);
              
            return employer;
        }

        public List<Employer> AddNewEmployer(Employer newEmployer)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Employer employer = new Employer();
            employer.EmployerName = newEmployer.EmployerName;
            employer.EmployerAddress = newEmployer.EmployerAddress;
            employer.EmployerPhoneNumber = newEmployer.EmployerPhoneNumber;
            employer.EmployerEmail = newEmployer.EmployerEmail;
            db.Employers.Add(employer);
            db.SaveChanges();
            
            // ????
            return db.Employers.ToList();
        }




       
    }
}
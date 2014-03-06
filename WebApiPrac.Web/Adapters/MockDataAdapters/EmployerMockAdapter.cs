using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiPrac.Web.Adapters.Interfaces;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Adapters.MockDataAdapters
{
    public class EmployerMockAdapter : IEmployerInterface
    {
        public List<Employer> GetEmployers()
        {
            List<Employer> Employers = new List<Employer>()
            {
              new Employer { Id=1, EmployerName="Boss1", EmployerAddress="1234 Street Ave Houston, Texas1", EmployerPhoneNumber="123-456-7891", EmployerEmail="email1@email.com" },
              new Employer { Id = 2, EmployerName = "Boss2", EmployerAddress = "5678 Street Ave Houston, Texas2", EmployerPhoneNumber = "123-456-7892", EmployerEmail = "email2@email.com" },
              new Employer { Id=3, EmployerName="Boss3", EmployerAddress="9012 Street Ave Houston, Texas3", EmployerPhoneNumber="123-456-7893", EmployerEmail="email3@email.com" }
            };
            return Employers;
        }

        public Employer GetEmployer(int id)
        {
            Employer employer = new Employer()
            {
                 Id=1, EmployerName="Boss1", EmployerAddress="1234 Street Ave Houston, Texas1", EmployerPhoneNumber="123-456-7891", EmployerEmail="email1@email.com"
            };
            return employer;
        }

        public List<Employer> AddNewEmployer(Employer newEmployer)
        {
            List<Employer> mockdb = new List<Employer>()
            {
              new Employer { Id=1, EmployerName="Boss1", EmployerAddress="1234 Street Ave Houston, Texas1", EmployerPhoneNumber="123-456-7891", EmployerEmail="email1@email.com" },
              new Employer { Id = 2, EmployerName = "Boss2", EmployerAddress = "5678 Street Ave Houston, Texas2", EmployerPhoneNumber = "123-456-7892", EmployerEmail = "email2@email.com" },
              new Employer { Id=3, EmployerName="Boss3", EmployerAddress="9012 Street Ave Houston, Texas3", EmployerPhoneNumber="123-456-7893", EmployerEmail="email3@email.com" }
            };

            Employer employer = new Employer();
            employer.Id = newEmployer.Id;
            employer.EmployerName = newEmployer.EmployerName;
            employer.EmployerAddress = newEmployer.EmployerAddress;
            employer.EmployerPhoneNumber = newEmployer.EmployerPhoneNumber;
            employer.EmployerEmail = newEmployer.EmployerEmail;
            mockdb.Add(employer);

      
            return mockdb;

            
        }


      
    }
}
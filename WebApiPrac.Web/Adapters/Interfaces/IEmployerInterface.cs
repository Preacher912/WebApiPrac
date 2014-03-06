using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiPracDataModels;

namespace WebApiPrac.Web.Adapters.Interfaces
{
    public interface IEmployerInterface
    {
        List<Employer> GetEmployers();
        Employer GetEmployer(int id);
       List<Employer> AddNewEmployer(Employer newEmployer);
    }
}

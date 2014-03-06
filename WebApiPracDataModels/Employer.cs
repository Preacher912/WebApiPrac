using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiPracDataModels
{
    public class Employer
    {
        public int Id { get; set; }
        public string EmployerName { get; set; }
        public string EmployerAddress { get; set; }
        public string EmployerPhoneNumber {get;set;}
        public string EmployerEmail { get; set; }

        public virtual List<Job> Jobs {get;set;}
    }
}

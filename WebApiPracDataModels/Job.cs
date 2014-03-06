using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiPracDataModels
{
    public class Job 
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }

        //Foreign key
        public int EmployerId { get; set; }
        public int CategoryId { get; set; }
    }
}

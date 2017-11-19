using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInterfaces
{
   public interface ICreateJob
    {
         int jobId { get; set; }
         string jobName { get; set; }
         string jobType { get; set; }
         string JobDescription { get; set; }
        string contactEmail { get; set; }
        string contactNum { get; set; }
        int salary { get; set; }
        string address { get; set; }

        bool CreateNewJob(ICreateJob obj);
    }
}

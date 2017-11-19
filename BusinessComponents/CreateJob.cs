using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessInterfaces;
using DataAccessLayer;
using System.Data;

namespace BusinessComponents
{
   public class CreateJob: ICreateJob
    {
        public int jobId { get; set; }
        public string jobName { get; set; }
        public string jobType { get; set; }
        public string JobDescription { get; set; }
        public string contactEmail { get; set; }
        public string contactNum { get; set; }
        public int salary { get; set; }
        public string address { get; set; }

        public bool CreateNewJob(ICreateJob obj)
        {
            Job objJob = new Job();
            objJob.createNewJob(obj);
            return true;
        }        
    }
}

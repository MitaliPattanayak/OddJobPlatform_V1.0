using BusinessInterfaces;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessComponents
{
   public class ApplyJob: IApplyJob
    {
        public int ApplicationId { get; set; }
        public int JobSeekerId { get; set; }
        public int JobID { get; set; }
        public int Status { get; set; }            

        public bool ApplyJobs(IApplyJob obj)
        {
            Job objJob = new Job();
            objJob.ApplyJob(obj);
            return true;
        }
    }
}

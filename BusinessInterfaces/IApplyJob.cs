using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInterfaces
{
   public interface IApplyJob
    {
         int ApplicationId { get; set; }
         int JobSeekerId { get; set; }
         int JobID { get; set; }
         int Status { get; set; }

        bool ApplyJobs(IApplyJob obj);
       
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessInterfaces
{
   public interface IJobSeeker
    {
         int jsId { get; set; }
         string userName { get; set; }
         string password { get; set; }
         string jsName { get; set; }
         string dob { get; set; }
         string address { get; set; }
         string email { get; set; }
         string resume { get; set; }
         string gender { get; set; }
         int contactNum { get; set; }

         DataTable ViewAllJobs();
    }
}

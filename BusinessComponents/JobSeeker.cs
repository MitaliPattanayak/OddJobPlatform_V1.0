using BusinessInterfaces;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessComponents
{
  public class JobSeeker: IJobSeeker
    {
        public int jsId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string jsName { get; set; }
        public string dob { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string resume { get; set; }
        public string gender { get; set; }
        public int contactNum { get; set; }

        public DataTable ViewAllJobs()
        {
            Job objJob = new Job();
            DataTable dt = objJob.ViewJobs();
            return dt;
        }
    }

}

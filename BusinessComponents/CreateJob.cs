using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessInterfaces;
using DataAccessLayer;
using System.Data;
using System.Text.RegularExpressions;

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

        public bool checkRequiredFields(CreateJob job)
        {
            if (String.IsNullOrEmpty(this.jobName) || String.IsNullOrEmpty(this.jobType) || String.IsNullOrEmpty(this.contactEmail) || String.IsNullOrEmpty(this.contactNum))
            return false;
            else
            return true;
        }

        public bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public DataTable ViewAllJobs()
        {
           Job objJob = new Job();
           DataTable dt = objJob.ViewJobs();
           return dt;
        }
    }
}

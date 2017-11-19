using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BusinessInterfaces;

namespace DataAccessLayer
{
   public class Validators
    {
        public bool checkRequiredFields(ICreateJob job)
        {
            if (String.IsNullOrEmpty(job.jobName) || String.IsNullOrEmpty(job.jobType) || String.IsNullOrEmpty(job.contactEmail) || String.IsNullOrEmpty(job.contactNum))
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
    }
}

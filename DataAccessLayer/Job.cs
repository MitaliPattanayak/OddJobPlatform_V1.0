using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessInterfaces;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
   public class Job
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public bool createNewJob(ICreateJob objCJ)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("uspCreateJob", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Address", objCJ.address);
            cmd.Parameters.AddWithValue("@contactEmail", objCJ.contactEmail);
            cmd.Parameters.AddWithValue("@contactNum", objCJ.contactNum);
            cmd.Parameters.AddWithValue("@JobDescription", objCJ.JobDescription);
            cmd.Parameters.AddWithValue("@jobName", objCJ.jobName);
            cmd.Parameters.AddWithValue("@jobType", objCJ.jobType);
            cmd.Parameters.AddWithValue("@salary", objCJ.salary);

            int result = 0;
            result = cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public DataTable ViewJobs()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("uspViewJobs", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt;
        }

        public bool ApplyJob(IApplyJob obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("uspApplyJob", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@JobID", obj.JobID);
            cmd.Parameters.AddWithValue("@JobSeekerID", obj.JobSeekerId);
            cmd.Parameters.AddWithValue("@Status", obj.Status);
            
            int result = 0;
            result = cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public int CheckIfApplied(int JSId, int JId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("uspCheckIfJobApplied", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("JSId", JSId);
            cmd.Parameters.AddWithValue("JId", JId);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            return dt.Rows.Count;
        }
    }
}

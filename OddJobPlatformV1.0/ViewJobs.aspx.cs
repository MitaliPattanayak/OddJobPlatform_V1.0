using BusinessComponents;
using BusinessInterfaces;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OddJobPlatformV1._0
{
    public partial class ViewJobs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["JobseekerID"] = 1;
            if (!IsPostBack)
            {
                GetAllJobs();
            }
        }
    public void GetAllJobs()
    {
            JobSeeker objJs = new JobSeeker();
            DataTable dt = objJs.ViewAllJobs();
            grdJobs.DataSource = dt;
            grdJobs.DataBind();
    }

        protected void grdJobs_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblSerial = (Label)e.Row.FindControl("lblSerial");
                lblSerial.Text = ((grdJobs.PageIndex * grdJobs.PageSize) + e.Row.RowIndex + 1).ToString();
           
                Button apply = (Button)e.Row.FindControl("Apply");
             int JID=   Convert.ToInt32(grdJobs.DataKeys[e.Row.RowIndex]["JobID"].ToString());
                int JSId = Convert.ToInt32(Session["JobseekerID"].ToString());
                int count = CheckIfJobApplied(JSId, JID);
                if (count > 0)
                {
                    apply.Text = "Applied";
                    apply.Enabled = false;
                    apply.ForeColor = System.Drawing.Color.DarkBlue;
                }
            }
        }
        protected void grdJobs_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ApplyJob")
            {
                int JobID = Convert.ToInt32(e.CommandArgument.ToString());
                ApplyJob job = new ApplyJob();
                job.JobID = JobID;
                job.JobSeekerId = Convert.ToInt32(Session["JobseekerID"].ToString());
                job.Status = 1;

                job.ApplyJobs(job);
                GetAllJobs();
            }            
        }

        public int CheckIfJobApplied(int JSId, int JId)
        {
            Job objJob = new Job();
            int result= objJob.CheckIfApplied(JSId, JId);
            return result;
        }
    }   
}
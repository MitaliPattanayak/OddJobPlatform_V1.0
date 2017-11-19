using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OddJobPlatformV1._0
{
    public partial class CreateJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Create_Click(object sender, EventArgs e)
        {
            BusinessComponents.CreateJob obj = new BusinessComponents.CreateJob();
            obj.address = txtAddress.Text.ToString();
            obj.contactEmail = txtEmail.Text.ToString();
            obj.contactNum = txtContactNo.Text.ToString();
            obj.JobDescription = txtJobDesc.Text.ToString();
            obj.jobName = txtJobName.Text.ToString();
            obj.jobType = ddlJobType.SelectedValue.ToString();
            obj.salary =Convert.ToInt32(txtSalary.Text);

            obj.CreateNewJob(obj);
            ClearFields();
        }

        public bool ClearFields()
        {
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtEmail.Text = "";
            txtJobDesc.Text = "";
            txtJobName.Text = "";
            txtSalary.Text = "";
            ddlJobType.SelectedValue = "0";
            return true;
        }
    }
}
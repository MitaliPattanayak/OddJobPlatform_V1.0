using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OddJobPlatformV1;
using System.Configuration;
using NUnit.Framework;
using Moq;
using System.IO;
using DataAccessLayer;

namespace OddJobPlatformV1._0.Tests
{
    [TestClass]
    public class OddJobPlatformTest
    {
        [TestMethod] //Check if database exists
        public void TestDatabaseExists()
        {
            NUnit.Framework.Assert.IsNotNull(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        }




        [TestMethod] // Check Job Name is not null or empty in 'Create Job' page.
        public void Invalid_When_JobName_Is_Null()
        {
            DataAccessLayer.Validators objVal = new DataAccessLayer.Validators(); 
            BusinessComponents.CreateJob obj = new BusinessComponents.CreateJob();
            obj.jobType = "Part-time";
            obj.contactEmail = "test@jk.kil";
            obj.contactNum = "07897889009";
            obj.jobName = "";
            NUnit.Framework.Assert.AreEqual(objVal.checkRequiredFields(obj), false);
        }

        [TestMethod] // Check Job Type is not null or empty in 'Create Job' page.
        public void Invalid_When_JobType_Is_Null()
        {
            Validators objVal = new Validators();
            BusinessComponents.CreateJob obj = new BusinessComponents.CreateJob();
            obj.jobName = "Cleaning";
            obj.contactEmail = "test@jk.kil";
            obj.contactNum = "07897889009";
            NUnit.Framework.Assert.AreEqual(objVal.checkRequiredFields(obj), false);
        }
        
        [TestMethod] // Check Contact Email is not null or empty in 'Create Job' page.
        public void Invalid_When_contactEmail_Is_Null()
        {
            Validators objVal = new Validators();
            BusinessComponents.CreateJob obj = new BusinessComponents.CreateJob();
            obj.jobName = "Cleaning";
            obj.jobType = "Part-time";
            obj.contactNum = "07897889009";
            NUnit.Framework.Assert.AreEqual(objVal.checkRequiredFields(obj), false);
        }

        [TestMethod] // Check Contact Number is not null or empty in 'Create Job' page.
        public void Invalid_When_contactNum_Is_Null()
        {
            Validators objVal = new Validators();
            BusinessComponents.CreateJob obj = new BusinessComponents.CreateJob();
            obj.jobName = "Cleaning";
            obj.jobType = "Part-time";
            obj.contactEmail = "test@jk.kil";
            NUnit.Framework.Assert.AreEqual(objVal.checkRequiredFields(obj), false);
        }

        [TestMethod] //Check if no required field is empty or null
        public void Valid_When_Nofield_Is_NotNull()
        {
            Validators objVal = new Validators();
            BusinessComponents.CreateJob obj = new BusinessComponents.CreateJob();
            obj.jobName = "Cleaning";
            obj.jobType = "Part-time";
            obj.contactEmail = "test@jk.kil";
            obj.contactNum = "23457890";
            NUnit.Framework.Assert.AreEqual(objVal.checkRequiredFields(obj), true);
        }


        [TestMethod] // Check if Email is in correct format
        public void Check_ValidEmail()
        {
            Validators objVal = new Validators();
            BusinessComponents.CreateJob obj = new BusinessComponents.CreateJob();
            string email = "test@jk.kil";
           NUnit.Framework.Assert.AreEqual(objVal.emailIsValid(email), true);
        }

        [TestMethod] //Check if job details get saved to the database
        public void CreateJobTest() 
        {
            bool expected = true;
            DataAccessLayer.Job objCJ = new DataAccessLayer.Job();
            BusinessInterfaces.ICreateJob obj = new BusinessComponents.CreateJob();
            obj.address = "test";
            obj.contactEmail = "rwser";
            obj.contactNum = "0787566767";
            obj.JobDescription = "test desc";
            obj.jobName = "Cleaning";
            obj.jobType = "Permanent";
            obj.salary = 123;
            bool result = objCJ.createNewJob(obj);
            NUnit.Framework.Assert.AreEqual(expected, result);
        }
    }
}

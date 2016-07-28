using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class InterviewController : ApiController
    {
        Interview[] interviews = new Interview[] 
        { 
            new Interview {ApplicantName ="Uncle John", JobTitle ="Analytics",Interviewer ="Gilbert", Department ="Testing", DateApplied ="21/02/15",TimeApplied ="13.05"},
            new Interview {ApplicantName ="Mary Jane", JobTitle ="Front End Developer",Interviewer ="Gerald", Department ="Web Development", DateApplied ="08/05/15",TimeApplied ="14.30"},
            new Interview {ApplicantName ="Gerrard", JobTitle ="Back End Developer",Interviewer ="Jaishnee", Department ="Web Development", DateApplied ="09/06/15",TimeApplied ="15.00"},
        };

        public IEnumerable<Interview> GetAllJobApply()
        {
            return interviews;
        }

        public IHttpActionResult GetJobApply(String JobTitle)
        {
            var interview = interviews.FirstOrDefault((q) => q.JobTitle == JobTitle);
            if (interview == null)
            {
                return NotFound();
            }
            return Ok(interview);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ApplicantController : ApiController
    {
          Applicant[] _applicants = new Applicant[] 
        { 
            new Applicant { FName = "Bonie", LName = "Coder", Nic="C0209123456789", DateApplied = "3/9/2008", Email = "bonie.coder@gmail.com", HomeNum = 4679870, Interview = "Good", JobTitle = "Front-end developer", Nationality = "Mauritian"}, 
            new Applicant { FName = "Doushant", LName = "Goolab", Nic="C0209123456789", DateApplied = "3/9/2008", Email = "doushant.goolab@gmail.com", HomeNum = 4659571, Interview = "Good", JobTitle = "Back-end developer", Nationality = "Mauritian"}, 
            new Applicant { FName = "Umar", LName = "Peerbocus", Nic="C0209123456789", DateApplied = "3/9/2008", Email = "umar.peerbocus@gmail.com", HomeNum = 4879855, Interview = "Good", JobTitle = "Back-end developer", Nationality = "Mauritian"} 

        };

        public IEnumerable<Applicant> GetAllApplicants()
        {
            return _applicants;
        }

        public IHttpActionResult GetApplicant(string id)
        {
            var applicant = _applicants.FirstOrDefault((p) => p.JobTitle == id);
            if (applicant == null)
            {
                return NotFound();
            }
            return Ok(applicant);
        }
    
    }
}

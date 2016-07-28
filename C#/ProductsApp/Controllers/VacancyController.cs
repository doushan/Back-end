using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class VacancyController : ApiController
    {
        Vacancy[] _vacancies = new Vacancy[]
        {
            new Vacancy{DateFrom = "12/02/2016", DateTo = "15/04/2016", Position = "Developer", Description = "Working", Skills = "Full Stack Developer", Department = "Front End"},
            new Vacancy{DateFrom = "12/02/2016", DateTo = "15/04/2016", Position = "Developer", Description = "Working", Skills = "Full Stack Developer", Department = "Front End"}
        
        };

        public IEnumerable<Vacancy> GetAllVacancy()
        {
            return _vacancies;
        }

        public IHttpActionResult GetVancancy(int id)
        {
            var vacancy = _vacancies.FirstOrDefault((p) => p.Id == id);
            if (vacancy == null)
            {
                return NotFound();
            }
            return Ok(vacancy);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWebApi.Models
{
    public class Vacancy
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public string Department { get; set; }
    }
    public class VacancyEntities : DbContext
    {
        public DbSet<Vacancy> Vacancies { get; set; }
    }
}
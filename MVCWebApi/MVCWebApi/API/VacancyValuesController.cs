using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApi.Controllers
{
    public class VacancyValuesController : ApiController
    {
        VacancyEntities db = new VacancyEntities();
        // GET api/values
        public List<Vacancy> Get()
        {
            return db.Vacancies.ToList();
            //return new string[] { "value1", "value2" };
        }
        // GET api/values/5
        public Vacancy Get(int id)
        {
            return db.Vacancies.Find(id);
            //return "value";
        }
        // POST api/values
        public void Post(List<string> val)//(Person obj )
        {
            try
            {
                Vacancy obj = new Vacancy();
                obj.DateFrom = Convert.ToDateTime(val[0]);
                obj.DateTo = Convert.ToDateTime(val[1]);
                obj.Position = val[2];
                obj.Description = val[3];
                obj.Skills = val[4];
                obj.Department = val[5];
                db.Vacancies.Add(obj);
                db.SaveChanges();
            }
            catch (Exception) { }
        }
        // PUT api/values/5
        public void Put(int id, Vacancy obj)//(int id, [FromBody]string value)
        {
            try
            {
                db.Entry(obj).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception) { }
        }
        //This method for update through Json
        public void Put(List<string> val)
        {
            try
            {
                int id = Convert.ToInt32(val[3]);
                Vacancy obj = db.Vacancies.Find(id);
                obj.DateFrom = Convert.ToDateTime(val[0]);
                obj.DateTo = Convert.ToDateTime(val[1]);
                obj.Position = val[2];
                obj.Description = val[3];
                obj.Skills = val[4];
                obj.Department = val[5];
                db.Vacancies.Add(obj);
                db.Entry(obj).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception) { }
        }
        // DELETE api/values/5
        public void Delete(int id)
        {
            Vacancy obj = db.Vacancies.Find(id);
            db.Vacancies.Remove(obj);
            db.SaveChanges();
        }
    }
}
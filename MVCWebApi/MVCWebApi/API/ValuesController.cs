using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        PersonEntities db = new PersonEntities();

        VacancyEntities db1 = new VacancyEntities();

        // GET api/values
        public IEnumerable<Person> Get()
        {
            return db.Persons.ToList();
            //return new string[] { "value1", "value2" };
        }
        // GET api/values/5
        public Person Get(int id)
        {
            return db.Persons.Find(id);
            //return "value";
        }
        // POST api/values
        public void Post(List<string> val)//(Person obj )
        {
            try
            {
                Person obj = new Person();
                obj.Name = val[0];
                obj.Address = val[1];
                obj.DOB = Convert.ToDateTime(val[2]);
                db.Persons.Add(obj);
                db.SaveChanges();
            }
            catch (Exception) { }
        }
        // PUT api/values/5
        public void Put(int id, Person obj)//(int id, [FromBody]string value)
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
                Person obj = db.Persons.Find(id);
                obj.Name = val[0];
                obj.Address = val[1];
                obj.DOB = Convert.ToDateTime(val[2]);
                db.Persons.Add(obj);
                db.Entry(obj).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception) { }
        }
        // DELETE api/values/5
        public void Delete(int id)
        {
            Person obj = db.Persons.Find(id);
            db.Persons.Remove(obj);
            db.SaveChanges();
        }
    }
}
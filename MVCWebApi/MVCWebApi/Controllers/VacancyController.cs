using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApi.Controllers
{
    public class VacancyController : Controller
    {
        ValuesController db = new ValuesController();
        public ActionResult Index()
        {
            var list = db.Get(); //Getting List of records from web API
            return View(list);
        }
        public ActionResult Index2()
        {
               return View();
        }
        public ActionResult Details(int id)
        {
            Vacancy vacancy = db.Get(id);
            return View(vacancy);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Person obj)
        {
            try
            {
                List<string> person = new List<string>();
                Vacancy.Add(obj.Name);
                person.Add(obj.Address);
                person.Add(obj.DOB.ToString());
                db.Post(person);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            Person person = db.Get(id);
            return View(person);
        }
        [HttpPost]// POST: /Person/Edit/5 
        public ActionResult Edit(int id, Person obj)
        {
            try
            {
                db.Put(id, obj);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Person/Delete/5 
        public ActionResult Delete(int id)
        {
            Person person = db.Get(id);
            return View(person);
        }


        [HttpPost]// POST: /Person/Delete/5 
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                db.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

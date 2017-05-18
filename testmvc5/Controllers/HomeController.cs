using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testmvc5.Models;

namespace testmvc5.Controllers
{
    public class HomeController : Controller
    {
        SearchDbContext db = new SearchDbContext();

        public ActionResult Index()
        {
            IEnumerable<Person> persons = db.Persons;
            ViewBag.Persons = persons;
            return View();
        }

        [HttpGet]
        public ActionResult Person(int id)
        {
            ViewBag.PersonId = id;
            var personItem = (from item in db.Persons where item.PersonId == id select item).SingleOrDefault();
            ViewBag.Family = personItem.Family;
            ViewBag.Name = personItem.Name;
            return View();
        }

        [HttpPost]
        public string Person(Person person)
        {
            var personRecord = db.Persons.Where(s => s.PersonId == person.PersonId).FirstOrDefault<Person>();
            personRecord.Family = person.Family;
            personRecord.Name = person.Name;
            db.Entry(personRecord).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "updated!";
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public string Add(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
            return "added!";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ProgramacionAvanzada.Web.Models;

namespace ProgramacionAvanzada.Web.Controllers
{
    public class PersonController : Controller
    {
        private static List<Person> people = new List<Person>
        {
            new Person { Id = "1", Name = "Alice", Description = "Developer", DateCreated = DateTime.Now },
            new Person { Id = "2", Name = "Bob", Description = "Designer", DateCreated = DateTime.Now },
            new Person { Id = "3", Name = "Charlie", Description = "Manager", DateCreated = DateTime.Now },
            new Person { Id = "4", Name = "Diana", Description = "Tester", DateCreated = DateTime.Now },
            new Person { Id = "5", Name = "Edward", Description = "Analyst", DateCreated = DateTime.Now },
            new Person { Id = "6", Name = "Fiona", Description = "Support", DateCreated = DateTime.Now },
            new Person { Id = "7", Name = "George", Description = "Architect", DateCreated = DateTime.Now },
            new Person { Id = "8", Name = "Hannah", Description = "DevOps", DateCreated = DateTime.Now },
            new Person { Id = "9", Name = "Ian", Description = "Product Owner", DateCreated = DateTime.Now },
            new Person { Id = "10", Name = "Julia", Description = "Scrum Master", DateCreated = DateTime.Now }
        };

        public ActionResult Index()
        {
            return View(people);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                people.Add(person);
                return RedirectToAction("Index");
            }
            return View(person);
        }
    }
}







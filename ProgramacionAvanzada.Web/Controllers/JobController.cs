using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ProgramacionAvanzada.Web.Models;

namespace ProgramacionAvanzada.Web.Controllers
{
    public class JobController : Controller
    {
        private static List<Job> jobs = new List<Job>
        {
            new Job { Id = "1", Name = "Software Engineer", Description = "Develops software", DateCreated = DateTime.Now },
            new Job { Id = "2", Name = "Product Manager", Description = "Manages product lifecycle", DateCreated = DateTime.Now },
            new Job { Id = "3", Name = "Data Scientist", Description = "Analyzes data", DateCreated = DateTime.Now },
            new Job { Id = "4", Name = "UX Designer", Description = "Designs user experience", DateCreated = DateTime.Now },
            new Job { Id = "5", Name = "Network Administrator", Description = "Manages network", DateCreated = DateTime.Now },
            new Job { Id = "6", Name = "DevOps Engineer", Description = "Integrates development and operations", DateCreated = DateTime.Now },
            new Job { Id = "7", Name = "Database Administrator", Description = "Manages databases", DateCreated = DateTime.Now },
            new Job { Id = "8", Name = "Marketing Specialist", Description = "Handles marketing", DateCreated = DateTime.Now },
            new Job { Id = "9", Name = "Technical Writer", Description = "Writes documentation", DateCreated = DateTime.Now },
            new Job { Id = "10", Name = "Quality Assurance", Description = "Ensures product quality", DateCreated = DateTime.Now }
        };

        public ActionResult Index()
        {
            return View(jobs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Job job)
        {
            if (ModelState.IsValid)
            {
                jobs.Add(job);
                return RedirectToAction("Index");
            }
            return View(job);
        }
    }
}

//prueba de commit

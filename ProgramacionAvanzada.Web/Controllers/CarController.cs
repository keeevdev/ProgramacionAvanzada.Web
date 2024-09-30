using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ProgramacionAvanzada.Web.Models;

namespace ProgramacionAvanzada.Web.Controllers
{
    public class CarController : Controller
    {
        private static List<Car> cars = new List<Car>
        {
            new Car { Id = "1", Name = "Honda Civic", Description = "Compact Car", DateCreated = DateTime.Now },
            new Car { Id = "2", Name = "Ford Mustang", Description = "Sports Car", DateCreated = DateTime.Now },
            new Car { Id = "3", Name = "Tesla Model S", Description = "Electric Sedan", DateCreated = DateTime.Now },
            new Car { Id = "4", Name = "Toyota Corolla", Description = "Sedan", DateCreated = DateTime.Now },
            new Car { Id = "5", Name = "Chevrolet Silverado", Description = "Truck", DateCreated = DateTime.Now },
            new Car { Id = "6", Name = "Volkswagen Golf", Description = "Hatchback", DateCreated = DateTime.Now },
            new Car { Id = "7", Name = "Subaru Outback", Description = "SUV", DateCreated = DateTime.Now },
            new Car { Id = "8", Name = "Nissan Altima", Description = "Sedan", DateCreated = DateTime.Now },
            new Car { Id = "9", Name = "Kia Soul", Description = "Compact SUV", DateCreated = DateTime.Now },
            new Car { Id = "10", Name = "BMW 3 Series", Description = "Luxury Sedan", DateCreated = DateTime.Now }
        };

        public ActionResult Index()
        {
            return View(cars);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                cars.Add(car);
                return RedirectToAction("Index");
            }
            return View(car);
        }
    }
}




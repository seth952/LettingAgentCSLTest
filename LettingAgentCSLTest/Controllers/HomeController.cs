using LettingAgentCSLTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.Logic.CustomerProcessor;
using static DataLibrary.Logic.HouseProcessor;


namespace LettingAgentCSLTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewCustomers()
        {
            ViewBag.Message = "Customer List";

            var data = LoadCustomers();
            List<Customer> customers = new List<Customer>();


            foreach (var row in data)
            {
                customers.Add(new Customer
                {
                    FirstName = row.FirstName,
                    LasttName = row.LastName,
                    EmailAddress = row.EmailAddress
                });
            }

            return View(customers);
        }

        public ActionResult ViewHouses()
        {
            ViewBag.Message = "House List";

            var data = LoadHouses();
            List<House> houses = new List<House>();


            foreach (var row in data)
            {
                houses.Add(new House
                {
                    Address = row.Address,
                    Type = row.Type,
                    Price = row.Price,
                    IsAvailable = row.IsAvailable
                });
            }

            return View(houses);
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Customer Sign Up";

            return View();
        }
     /*   [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(House model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateHouse(model.Address, model.Type, model.Price, model.IsAvailable);
                return RedirectToAction("Index");
            }
            return View();
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(Customer model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateCustomer(model.FirstName, model.LasttName, model.EmailAddress);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
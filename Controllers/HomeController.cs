using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        private const string V = "shenpal@gmail.com";

        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            DIS_MOdels people = new DIS_MOdels();
            people.Firstname = "John";
            people.Lastname = "Doe";
            return View(people);
        }

        //public IActionResult ISM6225()
        //{
        //    return View();
        //}



        // Naming Action method (can name anything)
        //[HttpGet]
        public IActionResult Contact()
        {
            // Creating instance of contact object
            GuestContact contact = new GuestContact();
            contact.Name = "Shiva";
            contact.Email = "shenpal@gmail.com";
            contact.Phone = "8063922694";

            // Using overloaded method, can take any object as argumaent.  
            return View(contact);
        }


        //[HttpGet]
        public ViewResult ISM6225()
        {
            return View();
        }


        [HttpPost]
        // Takes GuestContact Object contact as an argument
        // model binding --> Framework populates value of all properties of model in the argument of action method. 
        public IActionResult Contact(GuestContact contact)
        {
            //Repository.AddResponse(contact);
            //return View(Repository.responses);
            return View(contact);
        }
    }
}
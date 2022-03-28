using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TempleTourGenius.Models;

namespace TempleTourGenius.Controllers
{
    public class HomeController : Controller
    {
        private SignupDBContext _slots { get; set; }

        public HomeController(SignupDBContext someName)
        {
            _slots = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Signup()
        {

            var slots = _slots.Timeslots
                .Where(x => x.Available == true)
                .OrderBy(x => x.Time)
                .ToList();

            return View(slots);
        }
        [HttpGet]
        public IActionResult Form(int Timeid)
        {
            ViewBag.TimeSlots = _slots.Timeslots.ToList();
            var appId = _slots.Timeslots.SingleOrDefault(x => x.TimeId == Timeid);
            //var appointment = _slots.Timeslots.SingleOrDefault(x => x.Time == selectedTime);
            //do i need to have "Form", appointment if it's in the same view?
            return View(appId);
            //return View();
        }

        [HttpPost]
        public IActionResult Form(Tour tr)
        {
            if (ModelState.IsValid)
            {
                //code reference to code that saves to database
                //_slots.Add(tr); 
                //_slots.Update() would I update the tour info or the timeid

                //_slots.SaveChanges();
                return RedirectToPage("/Index");
            }
            else
            {
                //add time list
                return View("Form");
            }
        }
                public IActionResult AppointmentList()
        {
            var timeslots = _slots.Timeslots
                .ToList();
            return View(timeslots);
        }
    }
}


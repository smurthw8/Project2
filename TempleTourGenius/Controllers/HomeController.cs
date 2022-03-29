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
        public IActionResult Form(int time)
        {
            ViewBag.TimeSlots = _slots.Timeslots.Where(x => x.TimeId == time).ToList();
        
            return View();
        }

        [HttpPost]
        public IActionResult Form(Tour tr)
        {
            if (ModelState.IsValid)
            {
                //code reference to code that saves to database
                Timeslots ts = _slots.Timeslots.Where(x => x.TimeId == tr.TimeId).FirstOrDefault();

                ts.Available = false;

                _slots.Add(tr);

                _slots.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                //add time list
                return View("Form");
            }
        }
        public IActionResult AppointmentList()
        {
            var tour = _slots.TourInfo
                .ToList();
            return View(tour);

        }
    }
}


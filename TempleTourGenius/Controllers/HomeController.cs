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

            int max = _slots.Timeslots.Max(p => p.TimeId);
            //DateTime last = _slots.Timeslots.Max(x => x.Time);
            DateTime today = DateTime.Now.AddDays(-1).Date;
            for (int i = 0; i < 10; i++)
            {
                today = today.AddDays(1);
                if (_slots.Timeslots.Where(c => c.Time.Date == today).Count() == 0)
                {
                    for (int j = 8; j < 21; j++)
                    {
                        max = max + 1;
                        Timeslots t = new Timeslots { TimeId = max, Time = today.AddHours(j), Available = true };
                        _slots.Add(t);
                        _slots.SaveChanges();
                    }
                }

            }
            DateTime now = DateTime.Now.Date;
            var slots = _slots.Timeslots
                .Where(x => x.Time >= now)
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

        //[HttpGet]
        //public IActionResult Edit (int tourid)
        //{
        //    ViewBag.TimeSlots = _slots.TourInfo.ToList();

        //    var tourInfo = _slots
        //}

        [HttpGet]
        public IActionResult Confirm_Delete (int tourid)
        {
            var appointment = _slots.TourInfo.Single(x => x.TourId == tourid);

            return View(appointment);
        }

        [HttpPost]
        public IActionResult Confirm_Delete(Tour tr)
        {
            Timeslots ts = _slots.Timeslots.Where(x => x.TimeId == tr.TimeId).FirstOrDefault();

            ts.Available = true;

            _slots.TourInfo.Remove(tr);
            _slots.SaveChanges();

            return RedirectToAction("AppointmentList");
        }
    }
}


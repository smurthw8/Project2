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

        public IActionResult AppointmentList()
        {
            var timeslots = _slots.Timeslots
                .ToList();
            return View(timeslots);
        }

    }
}

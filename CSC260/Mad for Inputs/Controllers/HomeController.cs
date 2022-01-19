using Mad_for_Inputs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mad_for_Inputs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Result(string one, string two, string three, string four, string five,
            string six, string seven, string eight, string nine, string ten )
        {
            ViewBag.one = one;
            ViewBag.two = two;
            ViewBag.three = three;
            ViewBag.four = four;
            ViewBag.five = five;
            ViewBag.six = six;
            ViewBag.seven = seven;
            ViewBag.eight = eight;
            ViewBag.nine = nine;
            ViewBag.ten = ten;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using CSC2603pm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CSC2603pm.Controllers
{
    
    public class HomeController : Controller
    {
        private static int count = 0;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[Route("Home/Index")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Home Page - Controller";
            DateTime d = DateTime.Now;

            return View();
        }

        public IActionResult MooStuff(int moo, string bah)
        {
            return Content($"The cow {moo} moos at you {bah} times.");
        }

        public IActionResult Test(int? id)
        {
            //int id = 0;

            //if (Request.RouteValues["id"] != null)
            //{
            //    var idparam = Request.RouteValues["id"];
            //    id = int.Parse(idparam.ToString());
            // }

            //return Content("id: " + id);
            return Content($"id = {id?.ToString() ?? "VERY NULL"}");
        }

        public IActionResult Colors(string colors)
        {
            //string strAllColors = "";
            //foreach (string s in colorList)
            //    strAllColors = strAllColors + " " + s;
            var colorList = colors.Split('/');
            return Content(string.Join(",", colorList));
            //return Content(colors);

        }

        [Route("evil")]
        public IActionResult TopSecret()
        {
            //return Content("Secret");
            return Redirect("http://www.google.com");
        }



        public IActionResult Privacy(string pizza)
        {
            ViewBag.Pizza = pizza;
            return View();
        }

        public IActionResult Future()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Form()
        {
            ViewBag.thecount = ++count;
            return View();
        }

        [HttpPost]
        public IActionResult Result(string FirstName)
        {
            //ViewBag.FirstName = Request.Form["FirstName"];
            ViewBag.FirstName = FirstName;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

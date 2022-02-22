using MovieLoader.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InClass.Controllers
{
    public class HomeController : Controller
    {
        private static int count = 0;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime d = DateTime.Now;

            return View();
        }

        public IActionResult Test(int? id)
        {
            /*int id = 0;

            if (Request.RouteValues["id"] != null)
            {
                var idparam = Request.RouteValues["id"];
                id = int.Parse(idparam.ToString());
            }*/

            return Content($"id: {id?.ToString() ?? "Null"}");
        }

        public IActionResult Colors(string colors)
        {
            var colorList = colors.Split('/');
            return Content(string.Join(',', colorList));

            //return Content(colors);
        }

        public IActionResult Privacy(string pizza)
        {
            ViewBag.Pizza = pizza;
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Form()
        {
            ViewBag.Count = ++count;
            return View();
        }

        public IActionResult Result(string FirstName)
        {
            //ViewBag.FirstName = Request.Form["FirstName"];
            ViewBag.FirstName = FirstName;
            return View();
        }

        [Route("rick")]
        public IActionResult TopSecret()
        {
            return Redirect("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
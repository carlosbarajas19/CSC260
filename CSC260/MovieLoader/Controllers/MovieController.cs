using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieLoader.Models;
using MovieLoader.Interfaces;
using MovieLoader.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MovieLoader.Controllers
{

    [Authorize]
    public class MovieController : Controller
    {

        //IDataAccessLayer dal = new MovieListDAL();

        //------------ Dependancy injection ----------//
        IDataAccessLayer dal;
        public MovieController(IDataAccessLayer indal)
        {
            dal = indal;
        }
        //--------------------------------------------//
        public IActionResult MovieIndex()
        {
            //return View();
            //return View(dal.GetMovies());
            return View(dal.GetMovies().OrderBy(m => m.ReleaseDate).ToList());
        }

        public IActionResult MovieForm()
        {
            return View();
        }

        public IActionResult DisplayMovie()
        {
            string userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string email = User.FindFirstValue(ClaimTypes.Email); //also .Name
            //Movie m = new Movie("Iron Man", 2008, 5.0f),
            //return View(m);

            return View();
        }

        public IActionResult ReturnMovie(string title)
        {
            
            var mv = dal.GetMovies().ToList().Find(x => x.Title == title);
            mv.ReturnMovie();
            return View("MovieIndex", dal.GetMovies().ToList());
        }
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if(ModelState.IsValid)
            {
                //dal.AddMovie(movie);
                ViewBag.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                return Redirect("/Movie/MovieIndex");
            }

            return View("MovieForm", movie);
        }

        public IActionResult EditMovie(int id)
        {
            Movie m;
            m = dal.GetMovie(User.FindFirstValue(ClaimTypes.NameIdentifier), id);
            ViewBag.mode = "Edit";
            ViewBag.ID = id;

            return View("MovieForm", m);
        }

        //saves an existing record
        public IActionResult UpdateMovie(Movie movie)
        {
            if(ModelState.IsValid)
            {
                dal.UpdateMovie(User.FindFirstValue(ClaimTypes.NameIdentifier), movie);
                return Redirect("/Movie/MovieIndex");
            }

            return View("MovieForm", movie);
        }

        public IActionResult DeleteMovie(int? id)
        {
            dal.RemoveMovie(User.FindFirstValue(ClaimTypes.NameIdentifier), id);
            return View("MovieIndex", dal.GetMovies());
        }
    }
}
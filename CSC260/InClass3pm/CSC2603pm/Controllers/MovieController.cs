using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC2603pm.Models;
using CSC2603pm.Interfaces;
using CSC2603pm.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InClass.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {
        //IDataAccessLayer dal = new MovieListDAL();
        IDataAccessLayer dal;

        public MovieController(IDataAccessLayer indal)
        {
            dal = indal;
        }

        public IActionResult Index()
        {
            //return View();
            //return View(MovieList);
            //return View(dal.GetMovies(User.FindFirstValue(ClaimTypes.NameIdentifier))
            //    .OrderBy(m => m.ReleaseDate).ToList());

            var viewModel = new MoviePage(
                dal.GetMovies(User.FindFirstValue(ClaimTypes.NameIdentifier))
                .OrderBy(m => m.ReleaseDate).ToList(),
                new SelectList(dal.GetGenres(), "Id", "Title")
               );

            return View(viewModel);

        }


        [HttpGet]
        public IActionResult AddMovie()
        {
            //Movie m = new Movie("Spider-man", 2002, 4.99f);
            //return View("MovieForm", m);
            //ViewBag.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var genreList = dal.GetGenres();
            ViewBag.Genres = new SelectList(genreList, "Id", "Title");

            return View("MovieForm");

        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            
            if (ModelState.IsValid)
            {

                movie.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                dal.AddMovie(movie);
                return Redirect("/Movie/Index");
            }

            return View("MovieForm", movie);

        }
        //prepares the MovieForm for Editing a movie
        public IActionResult EditMovie(int id)
        {
            Movie m;
            m = dal.GetMovie(User.FindFirstValue(ClaimTypes.NameIdentifier),id);
            ViewBag.Mode = "Edit";
            ViewBag.ID = id;

            var genreList = dal.GetGenres();
            ViewBag.Genres = new SelectList(genreList, "Id", "Title");

            return View("MovieForm", m);
        }

        //does the save of an existing record
        public IActionResult UpdateMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                dal.UpdateMovie(User.FindFirstValue(ClaimTypes.NameIdentifier),movie);
                return Redirect("/Movie/Index");
            }

            return View("MovieForm", movie);
        }

        public IActionResult DeleteMovie(int? id)
        {
            dal.RemoveMovie(User.FindFirstValue(ClaimTypes.NameIdentifier), id);
            return View("Index", dal.GetMovies(User.FindFirstValue(ClaimTypes.NameIdentifier)));
        }


        public IActionResult MovieForm()
        {
            return View();
        }

        public IActionResult Search(string SearchTerm)
        {
            return View();
        }



        public IActionResult DisplayMovie()
        {

            string userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string email = User.FindFirstValue(ClaimTypes.Email);  //also .Name



            Movie m = new Movie("Iron Man", 2008, 5.0f);
            return View(m);
            //return View();
        }
    }
}

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
using Microsoft.AspNetCore.Mvc.Rendering;

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

            var genreList = dal.GetGenres();
            ViewBag.Genres = new SelectList(genreList, "Id", "Title");
            //ViewBag.ID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                //dal.AddMovie(movie);
                //ViewBag.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                movie.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                dal.AddMovie(movie);
                return Redirect("/Movie/MovieIndex");


                //var genreList = dal.GetGenres();
                //ViewBag.Genres = new SelectList(genreList, "Id", "Title");
            }

            return View("MovieForm", movie);
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
            
            var mv = dal.GetMovies(User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList().Find(x => x.Title == title);
            mv.ReturnMovie();
            return View("MovieIndex", dal.GetMovies(User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList());
        }

        public IActionResult EditMovie(int id)
        {
            Movie m;
            m = dal.GetMovie(User.FindFirstValue(ClaimTypes.NameIdentifier), id);
            ViewBag.mode = "Edit";
            ViewBag.ID = id;

            var genreList = dal.GetGenres();
            ViewBag.Genres = new SelectList(genreList, "Id", "Title");

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
            return View("MovieIndex", dal.GetMovies(User.FindFirstValue(ClaimTypes.NameIdentifier)));
        }
    }
}
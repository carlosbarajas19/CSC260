using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieLoader.Models;
using MovieLoader.Interfaces;
using MovieLoader.Data;

namespace MovieLoader.Controllers
{
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

        public IActionResult DisplayMovie()
        {
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
                dal.RemoveMovie(movie.ID);
                dal.AddMovie(movie);
                return Redirect("/Movie/MovieIndex");
            }

            return View("MovieForm", movie);
        }

        public IActionResult EditMovie(int id)
        {
            Movie m;
            m = dal.GetMovie(id);
            dal.RemoveMovie(id);

            return View("MovieForm", m);
        }

        public IActionResult DeleteMovie(int? id)
        {
            dal.RemoveMovie(id);
            return View("MoviesIndex", dal.GetMovies());
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieLoader.Models;

namespace MovieLoader.Controllers
{
    public class MovieController : Controller
    {

        private static List<Movie> MovieList = new List<Movie>()
        {
             new Movie("Iron Man", 2008, 4.5f),
             new Movie("Star Wars", 1977, 5.0f),
             new Movie("The Truman Show", 1998, 4.3f),
             new Movie("The Princess Bride", 1987, 4.9f)

        };

        public IActionResult Index()
        {
            //return View();
            return View(MovieList);
        }

        public IActionResult DisplayMovie()
        {
            //Movie m = new Movie("Iron Man", 2008, 5.0f),
            //return View(m);
            return View();
        }

        public IActionResult ReturnMovie(string title)
        {
            var mv = MovieList.Find(x => x.Title == title);
            mv.ReturnMovie();
            return View("MovieIndex", MovieList);
        }
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            
            if(ModelState.IsValid)
            {
                MovieList.Add(movie);
                return Redirect("/Movie/MovieIndex");
            }

            return View();
        }
    }
}
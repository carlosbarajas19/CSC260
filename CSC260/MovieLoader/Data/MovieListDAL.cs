using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieLoader.Models;
using MovieLoader.Interfaces;

namespace MovieLoader.Data
{
    public class MovieListDAL : IDataAccessLayer
    {
        private static List<Movie> MovieList = new List<Movie>()
        {
             new Movie("Iron Man", 2008, 4.5f),
             new Movie("Star Wars", 1977, 5.0f),
             new Movie("The Truman Show", 1998, 4.3f),
             new Movie("The Princess Bride", 1987, 4.9f)

        };

        public void AddMovie(Movie movie)
        {
            MovieList.Add(movie);
        }

        public Movie GetMovie(int? id)
        {
            Movie foundMovie = null;
            if(id != null)
            {
                MovieList.ForEach(m =>
                {
                    if (m.ID == id)
                    {
                        foundMovie = m;
                    }
                });
            }
            return foundMovie;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return MovieList;
        }

        public void RemoveMovie(int? id)
        {
            if (id == null || id == 0) return;

            var foundMovie = GetMovie(id);
            if(foundMovie != null)
            {
                MovieList.Remove(foundMovie);
            }
        }

        public IEnumerable<Movie> Search(string strSearchTerm)
        {
            //string.IsNullOrEmpty(strTitle);
            List<Movie> tmpMovies = new List<Movie>();

            /*foreach(var m in MovieList)
            {
                if (m.Title.ToUpper().Contains(strSearchTerm.ToUpper()))
                {
                    tmpMovies.Add(m);
                }
            }

            return tmpMovies;*/

            return tmpMovies.Where(m => m.Title.Contains(strSearchTerm)).ToList();
        }

    }
}

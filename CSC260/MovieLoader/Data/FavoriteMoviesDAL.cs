using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieLoader.Models;
using MovieLoader.Interfaces;

namespace MovieLoader.Data
{

    public class FavoriteMoviesDAL //: IDataAccessLayer
    {
        private static List<Movie> MovieList = new List<Movie>()
        {
             new Movie("Spider-Man", 2002, 4.5f),
             new Movie("John Wick", 2010, 5.0f),
             new Movie("Tangled", 2010, 4.5f),
             new Movie("Spaceballs", 1987, 4.9f)

        };

        public void AddMovie(Movie movie)
        {
            MovieList.Add(movie);
        }

        public Movie GetMovie(int? id)
        {
            Movie foundMovie = null;
            if (id != null)
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
            if (foundMovie != null)
            {
                MovieList.Remove(foundMovie);
            }
        }

        public void UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}


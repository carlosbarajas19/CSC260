using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieLoader.Models;
using MovieLoader.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MovieLoader.Data
{
    public class MovieListDAL : IDataAccessLayer
    {
        //private static List<Movie> MovieList = new List<Movie>()
        //{
        //     new Movie("Iron Man", 2008, 4.5f),
        //     new Movie("Star Wars", 1977, 5.0f),
        //     new Movie("The Truman Show", 1998, 4.3f),
        //     new Movie("The Princess Bride", 1987, 4.9f)

        //};

        private MovieContext db;

        public MovieListDAL(MovieContext indb)
        {
            this.db = indb;
        }

        public void AddMovie(Movie movie)
        {
            //movie.ID = 0;
            db.Add(movie);
            db.SaveChanges();
            //MovieList.Remove(movie);
            //MovieList.Add(movie);
        }

        public Movie GetMovie(string userId, int? id)
        {
            return db.Movies
                .Where(m => m.ID == id && m.UserId == userId).Include(m => m.genre)
                .FirstOrDefault();
        }

        public IEnumerable<Movie> GetMovies(string userId)
        {
            return db.Movies.Where(m => m.UserId == userId).Include(m => m.genre).ToList();
        }

        public void RemoveMovie(string userId, int? id)
        {
            Movie foundMovie = GetMovie(userId, id);
            if(foundMovie != null)
            {
                db.Movies.Remove(foundMovie);
                db.SaveChanges();
            }

            /*var foundMovie = GetMovie(id);
            if(foundMovie != null)
            {
                MovieList.Remove(foundMovie);
            }*/
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

        public void UpdateMovie(String userId, Movie movie)
        {
            movie.UserId = userId;
            db.Update(movie);
            db.SaveChanges();
        }

        public List<Genre> GetGenres()
        {
            return db.Genres.ToList();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC2603pm.Models;
using CSC2603pm.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CSC2603pm.Data
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
            //return db.Movies.FirstOrDefault(m => m.ID == id);

            return db.Movies
                .Where(m => m.ID == id && m.UserId == userId).Include(m => m.Genre)
                .FirstOrDefault();
        }
            
        public IEnumerable<Movie> GetMovies(string userId)
        {
            //return MovieList;
            return db.Movies.Where(m => m.UserId == userId).Include(m => m.Genre).ToList();
        }

        public void RemoveMovie(string userId, int? id)
        {
            Movie foundMovie = GetMovie(userId, id);
            if (foundMovie != null)
            {
                db.Movies.Remove(foundMovie);
               db.SaveChanges();
            }

            //if (id > 0)
            //{
            //    db.Movies.Remove(db.Movies.Find(id));
            //    db.SaveChanges();
            //}

            //var foundMovie = GetMovie(id);
            //if (foundMovie != null)
            //{
            //    MovieList.Remove(foundMovie);
            // }
        }

        public void UpdateMovie(string userId, Movie movie)
        {
            movie.UserId = userId;
            db.Update(movie);
            db.SaveChanges();
        }

        public List<Genre> GetGenres()
        {
            return db.Genre.ToList();
        }



        //public IEnumerable<Movie> Search(string strSearchTerm)
        //{
        //string.IsNullOrEmpty(strTitle)

        //List<Game> tmpGames = new List<Game>();

        //foreach (var g in lstAllGames)
        //{
        //    if (g.Title.ToUpper().Contains(strSearchTerm.ToUpper()))
        //    {
        //        tmpGames.Add(g);
        //    }
        //}

        //return tmpGames;

        //return lstAllGames.Contains(g => g.Title.ToUpper().
        //Contains(strSearchTerm.ToUpper())).ToList();
        //return lstAllGames.FindAll(g => g.Title.Contains(strSearch)).ToList();

        //}
    }
}

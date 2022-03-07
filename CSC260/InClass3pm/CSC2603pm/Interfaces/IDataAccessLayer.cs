using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC2603pm.Models;


namespace CSC2603pm.Interfaces
{
    public interface IDataAccessLayer
    {
        IEnumerable<Movie> GetMovies(string userid);
        void AddMovie(Movie movie);
        void RemoveMovie(string userid, int? id);
        Movie GetMovie(string userid, int? id);
        void UpdateMovie(string userid, Movie movie);
        public List<Genre> GetGenres();

    }
}

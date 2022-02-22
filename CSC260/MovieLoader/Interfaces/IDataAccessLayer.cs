using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieLoader.Models;

namespace MovieLoader.Interfaces
{
    public interface IDataAccessLayer
    {
        IEnumerable<Movie> GetMovies();

        void AddMovie(Movie movie);

        void RemoveMovie(string userId, int? id);

        Movie GetMovie(string userId, int? id);

        void UpdateMovie(string userId, Movie movie);
    }
}

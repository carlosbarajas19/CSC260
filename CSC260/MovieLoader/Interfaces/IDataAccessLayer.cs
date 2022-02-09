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

        void RemoveMovie(int? id);

        Movie GetMovie(int? id);
    }
}

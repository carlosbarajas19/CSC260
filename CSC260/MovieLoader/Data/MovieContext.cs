using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieLoader.Models;

namespace MovieLoader.Data
{
    public class MovieContext : DbContext
    {

        public MovieContext(DbContextOptions options) : base(options)
        {

        }

        //will create the movies table in the DB using Movie.cs model
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }


    }
}

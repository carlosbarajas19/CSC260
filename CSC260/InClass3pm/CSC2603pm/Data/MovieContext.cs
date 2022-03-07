using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC2603pm.Models;

namespace CSC2603pm.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions options) : base(options)
        {

        }

        //Will create the Movies table in the DB using Movie.cs model
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genre { get; set; }

    }
}

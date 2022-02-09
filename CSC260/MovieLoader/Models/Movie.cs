﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MovieLoader.Validators;

namespace MovieLoader.Models
{
    [NinetysMovieRating]
    public class Movie
    {
        public static int nextID = 0;

        private int id = nextID++;

        public int? ID { get { return id; } }

        //[Required (ErrorMessage = "Hello??? As you can see, the Title is required... please don't leave it empty ")] 
        public string Title { get; set; }
        //[Range (2000, 2022, ErrorMessage = "Year must be between 2000 and 2022")]
        public int Year { get; set; }

        public float Rating { get; set; }

        public DateTime ReleaseDate;

        //public string LoanedTo { get; set; }
        
        //public DateTime? LoanedDate { get; set; }

        public Movie()
        {

        }

        public Movie(string title, int year, float rating)
        {
            this.Title = title;
            this.Year = year;
            this.Rating = rating;
        }

        public override string ToString()
        {
            return $"{Title} - {Year} - {Rating} stars";
        }

        public void ReturnMovie()
        {

        }

    }
}
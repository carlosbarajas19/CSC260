using CSC2603pm.Validators;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSC2603pm.Models
{
    //[NinetysMovieRating]
    
    public class Movie
    {
        //public static int nextId = 0;

        //private int id = nextId++;
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(450)]
        public string UserId { get; set; }

        //[Required(ErrorMessage = "Hey Dummy the Title is Required")]
        [Column(TypeName = "varchar(500)")]
        public string Title { get; set; }

        //[Range(2000, 2010, ErrorMessage ="Year must be between 2000 and 2010")]
        public int Year { get; set; }
        public float Rating { get; set; }
        //public List<string> Platform { get; set; }
        public DateTime ReleaseDate;

        public int GenreId { get; set; }

        public Genre Genre { get; set; }


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

    }
}

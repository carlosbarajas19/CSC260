using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameLibrary.Models
{
    public class Game
    {
        public string Title { get; set; }

        public Platform Platform { get; set; }

        public string Genre { get; set; }

        public string Rating { get; set; }
        public int Year { get; set; }
        public string LoanedTo { get; set; } = null;
        public string ImagePath { get; set; } = null;
        public DateTime? LoanedDate;

        public int ID { get; set; }

        public Game()
        {

        }

        public Game(string title, Platform platform, string genre, string rating, int year, string imagePath, int ID)
        {
            this.Title = title;
            this.Platform = platform;
            this.Genre = genre;
            this.Rating = rating;
            this.Year = year;
            this.ImagePath = imagePath;
            this.ID = ID;
        }

        public void Return()
        {
            LoanedTo = null;
            LoanedDate = null;

        }

        public void Rent(string loanedTo)
        {
            LoanedTo = loanedTo;
            LoanedDate = DateTime.Now;
        }
    }
}

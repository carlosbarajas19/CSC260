using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameLibrary.Models
{
    public class Game
    {
        public string Title { get; set; }

        public Platform genre { get; set; }

        public int Year { get; set; }
        public float Rating { get; set; }
        public DateTime ReleaseDate;
    }
}

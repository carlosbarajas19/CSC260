using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieLoader.Data;
using MovieLoader.Models;

namespace MovieLoader.Pages
{
    public class TestModel : PageModel
    {

        MovieContext movieContext;

        public Movie movie { get; set; }

        public TestModel (MovieContext context)
        {
            this.movieContext = context;
        }

        public IActionResult OnGet()
        {
            if(!ModelState.IsValid)
            {

            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {

            }
            return Page();
        }
    }
}

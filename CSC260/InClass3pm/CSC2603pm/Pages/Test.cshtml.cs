using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC2603pm.Data;
using CSC2603pm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSC2603pm.Pages
{
    public class TestModel : PageModel
    {
        MovieContext _movieContext;

        public Movie Movie { get; set; }

        public TestModel(MovieContext context)
        {
            this._movieContext = context;
        }

        public IActionResult OnGet(int? id)
        {
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

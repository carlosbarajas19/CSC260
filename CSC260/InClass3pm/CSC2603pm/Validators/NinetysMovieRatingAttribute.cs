using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CSC2603pm.Models;

namespace CSC2603pm.Validators
{
    public class NinetysMovieRatingAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.Year >= 1990 &&
                movie.Year < 2000 &&
                movie.Rating < 2.5f)
            {
                return new ValidationResult("Movies cannot be bad in the 90s");
            }

            return ValidationResult.Success;

        }
    }

}

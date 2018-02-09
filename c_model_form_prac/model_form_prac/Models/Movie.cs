using System;
using System.ComponentModel.DataAnnotations;

// Manually created Validators class with custom validator for datetime
using model_form_prac.Validators;

namespace model_form_prac.Models
{
    public class Movie
    {
        [Required]
        public string Title {get;set;}
        
        [Required]
        [MinLength(3, ErrorMessage="Must be at least 3 characters")]
        public string Director {get;set;}
        

        // Using [PastDate] validator with or without an argument
        [Required]
        // [PastDate]      // Without arguement
        [PastDate("1/24/2010")]    // With string arguement.
        public DateTime ReleaseDate {get;set;}

    }
}

// Creating basic model to work with in code
// No default attribute for datetime validation so we get to create one!!!
// Created custom validation that extended built in IsValid method so that we could return IActionResult that is a view or Json.....created two contructors for attribute with one taking an arugement (_date_limit) and the other constructor taking no arguemen and defaulting to DateTime.Now.
//
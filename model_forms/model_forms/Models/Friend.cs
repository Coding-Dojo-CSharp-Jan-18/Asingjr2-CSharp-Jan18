using System;
using System.Collections.Generic;
// Required to add valdations and display attributes
using System.ComponentModel.DataAnnotations;

namespace model_forms.Models
{
    public class Friend
    {
        // Display changes rendered name for form
        [Display(Name = "manual name change")]
        // Can take additional argument for errormessge
        [Required]
        [MinLength(9, ErrorMessage="Need 9 somethings dude!")]
        public string Name {get; set;}
        
        [Required]
        [MinLength(3)]
        public string Color {get; set;}


        [Required]
        [EmailAddress]
         public string Email { get; set; }
        public static List<Friend> GetFriends()
        {
            return new List<Friend>()
            {
                new Friend()
                {
                    Name = "Joe",
                    Color = "Red",
                    Email = "j1@j.com",
                },
                 new Friend()
                {
                    Name = "Suh",
                    Color = "Black",
                    Email = "j2@j.com",
                },
                 new Friend()
                {
                    Name = "Mary",
                    Color = "Brown",
                    Email = "j3@j.com",
                }
            };
        }
    }
}
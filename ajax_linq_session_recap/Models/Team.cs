using System;
using System.ComponentModel.DataAnnotations;

namespace ajax_linq_session_recap.Models
{
    public class Team
    {
        [Required]
        [MinLength(3)]
        public string city {get; set;}

        [Required]
        [StringLength(8)]
        public string name {get;set;}

        [Required]
        [Display(Name="Superbowls")]
        public int superbowls {get;set;}

        // Custom method that returns the instance of the class and displays pertinent information about it
        public Team Info()
    {
        System.Console.WriteLine($"city, name, sb : {this.city}, {this.name}, {this.superbowls}.");
        return this;
    }

    }
}
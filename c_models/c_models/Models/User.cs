using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System;


namespace  c_models.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(6)]
        public string Name {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [MinLength(3)]
        public string Password {get; set;}
        
    }    

    public class TestModel
    {
        public string word {get; set;}
        public int nums {get;set;}

    }
}
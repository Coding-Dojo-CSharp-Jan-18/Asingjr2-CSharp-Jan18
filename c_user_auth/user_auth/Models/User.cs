using System;
using System.ComponentModel.DataAnnotations;

namespace user_auth.Models
{
    public class User
    {
        [Required]
        public string first { get; set; }

        [Required]
        public string last { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string confirm { get; set; }
    }

    public class LogUser
    {
        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }
}
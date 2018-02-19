using System;
using System.ComponentModel.DataAnnotations;

namespace cwall1.Models
{
    public class User
    {
    [Required]
    public string first {get;set;}
    
    [Required]
    public string last { get; set; }

    [Required]
    public string email { get; set; }
    
    [Required]
    public string password { get; set; }

    [Required]
    public DateTime created_at { get; set; }

    [Required]
    public DateTime updated_at {get; set;}
    }

    public class LogUser
    {
        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }
}

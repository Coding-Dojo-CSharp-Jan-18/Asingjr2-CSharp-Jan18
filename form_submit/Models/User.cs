using System.ComponentModel.DataAnnotations;
namespace form_submit
{
    public class User
    {
        [Required]
        [MinLength(5)]
        public string fn {get;set;}
        [Required]
        public string ln {get;set;}
        [Required]
        [Range(15,35)]
        public int age {get;set;}
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        public User(string f, string l, int a, string e, string p)
        {
            fn = f; 
            ln = l; 
            age = a; 
            email = e; 
            password = p;
        }
    }
}
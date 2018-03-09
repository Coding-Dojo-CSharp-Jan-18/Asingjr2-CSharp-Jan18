using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace testBelt.Models
{
    public class User 
    {
        [Key]
        public int userID { get; set; }

        [Required]
        public string userName { get; set; }

        [Required]
        public string userPW { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace testBelt.Models
{
    public class User 
    {
        public int userID { get; set; }

        [Required]
        public string userName { get; set; }

        [Required]
        public string userPW { get; set; }
        public List<Game> userGames {get; set;}
        public User()
        {
            userGames = new List<Game>();
        }


    }
}

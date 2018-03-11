using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace testBelt.Models
{
   
    public class Game 
    {
        [Key]
        public int gameID { get; set; }

        [Required]
        public string gameName { get; set; }

        [Required]
        public DateTime createdAt { get; set; }

        [Required]
        public int userID { get; set; }
        public User owner {get; set;}
        public List<GameCharacter> heroChoices {get; set;}
        public Game()
        {
            heroChoices = new List<GameCharacter>();
        }


    }
}

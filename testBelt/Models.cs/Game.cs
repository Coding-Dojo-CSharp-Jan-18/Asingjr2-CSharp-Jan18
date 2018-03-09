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
        public string usersID { get; set; }
        public List<GameCharacter> heroChoices {get; set;}


    }
}

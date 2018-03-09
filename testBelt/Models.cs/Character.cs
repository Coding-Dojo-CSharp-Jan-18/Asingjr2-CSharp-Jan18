using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace testBelt.Models
{

    public class Character
    {
        [Key]
        public int characterID { get; set; }

        [Required]
        public string superHero { get; set; }

        [Required]
        public List<GameCharacter> heroGames { get; set; }
        public Character()
        {
            heroGames = new List<GameCharacter>();
        }
        

    }
}

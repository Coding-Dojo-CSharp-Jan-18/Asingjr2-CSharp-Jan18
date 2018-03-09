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
        public int gamesID { get; set; }
        public Game SeenIn {get;set;}
        public List<GameCharacter> heroGames { get; set; }
        

    }
}

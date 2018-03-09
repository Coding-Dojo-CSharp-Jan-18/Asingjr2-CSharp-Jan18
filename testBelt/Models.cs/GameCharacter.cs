using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace testBelt.Models
{
    public abstract class BaseEntity { }
    public class GameCharacter : BaseEntity
    {
        [Key]
        public int gameCharactersID { get; set; }

        [Required]
        public int gamesID { get; set; }

        [Required]
        public int charactersID { get; set; }
        public Game coolGame {get; set;}
        public Character coolCharacter {get;set;}

    }
}


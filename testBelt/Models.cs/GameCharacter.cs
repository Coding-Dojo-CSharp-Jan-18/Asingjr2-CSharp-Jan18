using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace testBelt.Models
{
    public abstract class BaseEntity { }
    public class GameCharacter : BaseEntity
    {
        [Key]
        public int gameCharacterID { get; set; }

        [Required]
        public int gameID { get; set; }

        [Required]
        public int characterID { get; set; }
        public Game coolGame {get; set;}
        public Character coolCharacter {get;set;}

    }
}


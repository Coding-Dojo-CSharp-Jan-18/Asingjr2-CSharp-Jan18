using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace album.Models
{
    public class Artist
    {
        [Key]
        public int artistID { get; set; }
        public string artistName { get; set; }
        
        // Adding many list of objects type
        public List<Album> albums {get; set;}
    }
}
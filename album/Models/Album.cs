using System;
using System.ComponentModel.DataAnnotations;

namespace album.Models
{
    public class Album
    {
        [Key]
        public int albumID { get; set; }
        public string albumName { get; set; }
        public DateTime albumReleaseDate {get; set;}
        public int artistsID {get; set;}
        // Adding Object
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace cwall1.Models
{
    public class Message
    {
        [Required]
        public int user_id { get; set; }

        [Required]
        public string message { get; set; }

        [Required]
        public DateTime created_at { get; set; }

        [Required]
        public DateTime updated_at { get; set; }
    }
}
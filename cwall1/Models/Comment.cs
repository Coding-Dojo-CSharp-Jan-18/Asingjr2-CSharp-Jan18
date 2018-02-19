using System;
using System.ComponentModel.DataAnnotations;

namespace cwall1.Models
{
    public class Comment
    {
        [Required]
        public int message_id { get; set; }

        [Required]
        public int user_id { get; set; }

        [Required]
        public string comment { get; set; }

        [Required]
        public DateTime created_at { get; set; }

        [Required]
        public DateTime updated_at { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace lost_woods.Models
{
    public class Trail {
        [Required]
        public string name {get; set;}
        [Required]
        public string desc { get; set; }
        [Required]
        // [Numeric]
        public decimal len { get; set; }
        [Required]
        // [Numeric]
        public int elevation { get; set; }
        [Required] 
        public decimal longg { get; set; }
        [Required]
        public decimal lat { get; set; }
    }
}
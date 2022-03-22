using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTourGenius.Models
{
    public class Timeslots
    {
        [Key]
        [Required]
        public int AppoitmentId { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public bool Available { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTourGenius.Models
{
    public class Timeslots
    {
        [Key]
        [Required]
        public DateTime Time { get; set; }

        [Required]
        public bool Available { get; set; }

    }
}

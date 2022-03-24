using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TempleTourGenius.Models
{
    public partial class Tour
    {
        [Key]
        [BindNever]
        public int TourId { get; set; }
        [Required(ErrorMessage = "Please enter a group name")]
        public string GroupName { get; set; }
        [Required(ErrorMessage = "Please enter a group size of 15 or lower")]
        public int GroupSize { get; set; } 
        [Required(ErrorMessage = "Please enter an email address")]
        public string Email { get; set; } 
        public int Phone { get; set; }

        //foriegn key relationship
        //time slot field

        public int TimeId { get; set; }
        [BindNever]
        public Timeslots TimeSlot { get; set; }
        
    }
}

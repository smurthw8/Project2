using System;
using Microsoft.EntityFrameworkCore;

namespace TempleTourGenius.Models
{
    public class SignupDBContext : DbContext
    {
        public SignupDBContext(DbContextOptions<SignupDBContext> options) : base(options)
        {
            //leave blank for now
        }


        //set up actual dataset (model) > pull set of data from database
        public DbSet<Timeslots> Timeslots { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            DateTime date = DateTime.Now.Date;
            mb.Entity<Timeslots>().HasData(
                new Timeslots { Time = date.AddHours(8), Available = true },
                new Timeslots { Time = date.AddHours(9), Available = true },
                new Timeslots { Time = date.AddHours(10), Available = true },
                new Timeslots { Time = date.AddHours(11), Available = true },
                new Timeslots { Time = date.AddHours(12), Available = true },
                new Timeslots { Time = date.AddHours(13), Available = true },
                new Timeslots { Time = date.AddHours(14), Available = true },
                new Timeslots { Time = date.AddHours(15), Available = true },
                new Timeslots { Time = date.AddHours(16), Available = true },
                new Timeslots { Time = date.AddHours(17), Available = true },
                new Timeslots { Time = date.AddHours(18), Available = true },
                new Timeslots { Time = date.AddHours(19), Available = true },
                new Timeslots { Time = date.AddHours(20), Available = true },

                new Timeslots { Time = date.AddDays(1).AddHours(8), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(9), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(10), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(11), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(12), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(13), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(14), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(15), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(16), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(17), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(18), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(19), Available = true },
                new Timeslots { Time = date.AddDays(1).AddHours(20), Available = true },


                new Timeslots { Time = date.AddDays(2).AddHours(8), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(9), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(10), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(11), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(12), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(13), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(14), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(15), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(16), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(17), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(18), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(19), Available = true },
                new Timeslots { Time = date.AddDays(2).AddHours(20), Available = true },


                new Timeslots { Time = date.AddDays(3).AddHours(8), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(9), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(10), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(11), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(12), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(13), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(14), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(15), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(16), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(17), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(18), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(19), Available = true },
                new Timeslots { Time = date.AddDays(3).AddHours(20), Available = true },


                new Timeslots { Time = date.AddDays(4).AddHours(8), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(9), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(10), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(11), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(12), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(13), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(14), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(15), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(16), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(17), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(18), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(19), Available = true },
                new Timeslots { Time = date.AddDays(4).AddHours(20), Available = true },


                new Timeslots { Time = date.AddDays(5).AddHours(8), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(9), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(10), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(11), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(12), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(13), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(14), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(15), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(16), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(17), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(18), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(19), Available = true },
                new Timeslots { Time = date.AddDays(5).AddHours(20), Available = true },


                new Timeslots { Time = date.AddDays(6).AddHours(8), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(9), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(10), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(11), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(12), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(13), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(14), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(15), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(16), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(17), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(18), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(19), Available = true },
                new Timeslots { Time = date.AddDays(6).AddHours(20), Available = true }
            );
        }
    }

}


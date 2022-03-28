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
        public DbSet<Tour> TourInfo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            DateTime date = DateTime.Now.Date;
            mb.Entity<Timeslots>().HasData(
                new Timeslots { TimeId = 1, Time = date.AddHours(8), Available = true },
                new Timeslots { TimeId = 2, Time = date.AddHours(9), Available = true },
                new Timeslots { TimeId = 3, Time = date.AddHours(10), Available = true },
                new Timeslots { TimeId = 4, Time = date.AddHours(11), Available = true },
                new Timeslots { TimeId = 5, Time = date.AddHours(12), Available = true },
                new Timeslots { TimeId = 6, Time = date.AddHours(13), Available = true },
                new Timeslots { TimeId = 7, Time = date.AddHours(14), Available = true },
                new Timeslots { TimeId = 8, Time = date.AddHours(15), Available = true },
                new Timeslots { TimeId = 9, Time = date.AddHours(16), Available = true },
                new Timeslots { TimeId = 10, Time = date.AddHours(17), Available = true },
                new Timeslots { TimeId = 11, Time = date.AddHours(18), Available = true },
                new Timeslots { TimeId = 12, Time = date.AddHours(19), Available = true },
                new Timeslots { TimeId = 13, Time = date.AddHours(20), Available = true },

                new Timeslots { TimeId = 14, Time = date.AddDays(1).AddHours(8), Available = true },
                new Timeslots { TimeId = 15, Time = date.AddDays(1).AddHours(9), Available = true },
                new Timeslots { TimeId = 16, Time = date.AddDays(1).AddHours(10), Available = true },
                new Timeslots { TimeId = 17, Time = date.AddDays(1).AddHours(11), Available = true },
                new Timeslots { TimeId = 18, Time = date.AddDays(1).AddHours(12), Available = true },
                new Timeslots { TimeId = 19, Time = date.AddDays(1).AddHours(13), Available = true },
                new Timeslots { TimeId = 20, Time = date.AddDays(1).AddHours(14), Available = true },
                new Timeslots { TimeId = 21, Time = date.AddDays(1).AddHours(15), Available = true },
                new Timeslots { TimeId = 22, Time = date.AddDays(1).AddHours(16), Available = true },
                new Timeslots { TimeId = 23, Time = date.AddDays(1).AddHours(17), Available = true },
                new Timeslots { TimeId = 24, Time = date.AddDays(1).AddHours(18), Available = true },
                new Timeslots { TimeId = 25, Time = date.AddDays(1).AddHours(19), Available = true },
                new Timeslots { TimeId = 26, Time = date.AddDays(1).AddHours(20), Available = true },


                new Timeslots { TimeId = 27, Time = date.AddDays(2).AddHours(8), Available = true },
                new Timeslots { TimeId = 28, Time = date.AddDays(2).AddHours(9), Available = true },
                new Timeslots { TimeId = 29, Time = date.AddDays(2).AddHours(10), Available = true },
                new Timeslots { TimeId = 30, Time = date.AddDays(2).AddHours(11), Available = true },
                new Timeslots { TimeId = 31, Time = date.AddDays(2).AddHours(12), Available = true },
                new Timeslots { TimeId = 32, Time = date.AddDays(2).AddHours(13), Available = true },
                new Timeslots { TimeId = 33, Time = date.AddDays(2).AddHours(14), Available = true },
                new Timeslots { TimeId = 34, Time = date.AddDays(2).AddHours(15), Available = true },
                new Timeslots { TimeId = 35, Time = date.AddDays(2).AddHours(16), Available = true },
                new Timeslots { TimeId = 36, Time = date.AddDays(2).AddHours(17), Available = true },
                new Timeslots { TimeId = 37, Time = date.AddDays(2).AddHours(18), Available = true },
                new Timeslots { TimeId = 38, Time = date.AddDays(2).AddHours(19), Available = true },
                new Timeslots { TimeId = 39, Time = date.AddDays(2).AddHours(20), Available = true },


                new Timeslots { TimeId = 40, Time = date.AddDays(3).AddHours(8), Available = true },
                new Timeslots { TimeId = 41, Time = date.AddDays(3).AddHours(9), Available = true },
                new Timeslots { TimeId = 42, Time = date.AddDays(3).AddHours(10), Available = true },
                new Timeslots { TimeId = 43, Time = date.AddDays(3).AddHours(11), Available = true },
                new Timeslots { TimeId = 44, Time = date.AddDays(3).AddHours(12), Available = true },
                new Timeslots { TimeId = 45, Time = date.AddDays(3).AddHours(13), Available = true },
                new Timeslots { TimeId = 46, Time = date.AddDays(3).AddHours(14), Available = true },
                new Timeslots { TimeId = 47, Time = date.AddDays(3).AddHours(15), Available = true },
                new Timeslots { TimeId = 48, Time = date.AddDays(3).AddHours(16), Available = true },
                new Timeslots { TimeId = 49, Time = date.AddDays(3).AddHours(17), Available = true },
                new Timeslots { TimeId = 50, Time = date.AddDays(3).AddHours(18), Available = true },
                new Timeslots { TimeId = 51, Time = date.AddDays(3).AddHours(19), Available = true },
                new Timeslots { TimeId = 52, Time = date.AddDays(3).AddHours(20), Available = true },


                new Timeslots { TimeId = 53, Time = date.AddDays(4).AddHours(8), Available = true },
                new Timeslots { TimeId = 54, Time = date.AddDays(4).AddHours(9), Available = true },
                new Timeslots { TimeId = 55, Time = date.AddDays(4).AddHours(10), Available = true },
                new Timeslots { TimeId = 56, Time = date.AddDays(4).AddHours(11), Available = true },
                new Timeslots { TimeId = 57, Time = date.AddDays(4).AddHours(12), Available = true },
                new Timeslots { TimeId = 58, Time = date.AddDays(4).AddHours(14), Available = true },
                new Timeslots { TimeId = 59, Time = date.AddDays(4).AddHours(15), Available = true },
                new Timeslots { TimeId = 60, Time = date.AddDays(4).AddHours(16), Available = true },
                new Timeslots { TimeId = 61, Time = date.AddDays(4).AddHours(17), Available = true },
                new Timeslots { TimeId = 62, Time = date.AddDays(4).AddHours(18), Available = true },
                new Timeslots { TimeId = 63, Time = date.AddDays(4).AddHours(19), Available = true },
                new Timeslots { TimeId = 64, Time = date.AddDays(4).AddHours(20), Available = true },
               

                new Timeslots { TimeId = 65, Time = date.AddDays(5).AddHours(8), Available = true },
                new Timeslots { TimeId = 66, Time = date.AddDays(5).AddHours(9), Available = true },
                new Timeslots { TimeId = 67, Time = date.AddDays(5).AddHours(10), Available = true },
                new Timeslots { TimeId = 68, Time = date.AddDays(5).AddHours(11), Available = true },
                new Timeslots { TimeId = 69, Time = date.AddDays(5).AddHours(12), Available = true },
                new Timeslots { TimeId = 70, Time = date.AddDays(5).AddHours(13), Available = true },
                new Timeslots { TimeId = 71, Time = date.AddDays(5).AddHours(14), Available = true },
                new Timeslots { TimeId = 72, Time = date.AddDays(5).AddHours(15), Available = true },
                new Timeslots { TimeId = 73, Time = date.AddDays(5).AddHours(16), Available = true },
                new Timeslots { TimeId = 74, Time = date.AddDays(5).AddHours(17), Available = true },
                new Timeslots { TimeId = 75, Time = date.AddDays(5).AddHours(18), Available = true },
                new Timeslots { TimeId = 76, Time = date.AddDays(5).AddHours(19), Available = true },
                new Timeslots { TimeId = 77, Time = date.AddDays(5).AddHours(20), Available = true },


                new Timeslots { TimeId = 78, Time = date.AddDays(6).AddHours(8), Available = true },
                new Timeslots { TimeId = 79, Time = date.AddDays(6).AddHours(9), Available = true },
                new Timeslots { TimeId = 80, Time = date.AddDays(6).AddHours(10), Available = true },
                new Timeslots { TimeId = 81, Time = date.AddDays(6).AddHours(11), Available = true },
                new Timeslots { TimeId = 82, Time = date.AddDays(6).AddHours(12), Available = true },
                new Timeslots { TimeId = 83, Time = date.AddDays(6).AddHours(13), Available = true },
                new Timeslots { TimeId = 84, Time = date.AddDays(6).AddHours(14), Available = true },
                new Timeslots { TimeId = 85, Time = date.AddDays(6).AddHours(15), Available = true },
                new Timeslots { TimeId = 86, Time = date.AddDays(6).AddHours(16), Available = true },
                new Timeslots { TimeId = 87, Time = date.AddDays(6).AddHours(17), Available = true },
                new Timeslots { TimeId = 88, Time = date.AddDays(6).AddHours(18), Available = true },
                new Timeslots { TimeId = 89, Time = date.AddDays(6).AddHours(19), Available = true },
                new Timeslots { TimeId = 90, Time = date.AddDays(6).AddHours(20), Available = true }
            );

            mb.Entity<Tour>().HasData(
                new Tour { 
                    TourId = 1, 
                    GroupName = "Andersons",
                    GroupSize = 5,
                    Email = "testnderson@test.com",
                    Phone = 8015551234,
                    TimeId = 1,
                }
            );
        }
    }

}


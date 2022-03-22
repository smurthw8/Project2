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
    }

}

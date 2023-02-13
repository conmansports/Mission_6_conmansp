using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6_conmansp.Models
{
    public class MovieEntryContext : DbContext
    {
        public MovieEntryContext(DbContextOptions<MovieEntryContext> options) : base(options)
        {
            //leave blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                    
                    new ApplicationResponse
                    {
                        FormID = 1,
                        Category = "Action/Adventure",
                        Title = "The Avengers",
                        Year = 2012,
                        Director = "Joss Whedon",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = ""
                    },

                    new ApplicationResponse
                    {
                        FormID = 2,
                        Category = "Action/Adventure",
                        Title = "Batman",
                        Year = 1989,
                        Director = "Tim Burton",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = ""
                    },

                    new ApplicationResponse
                    {
                        FormID = 3,
                        Category = "Action/Adventure",
                        Title = "Batman Begins",
                        Year = 2005,
                        Director = "Christopher Nolan",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = ""
                    }
                );
        }
    }
}

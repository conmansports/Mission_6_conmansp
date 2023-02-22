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
        public DbSet<Category> categories { get; set; }

        //Seed Data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Romantic Comedy" },
                new Category { CategoryId = 3, CategoryName = "Thriller" },
                new Category { CategoryId = 4, CategoryName = "Comedy" },
                new Category { CategoryId = 5, CategoryName = "Documentary" },
                new Category { CategoryId = 6, CategoryName = "Other" }
            );

            mb.Entity<ApplicationResponse>().HasData(
                    
                    new ApplicationResponse
                    {
                        FormID = 1,
                        CategoryId = 1,
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
                        CategoryId = 1,
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
                        CategoryId = 1,
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

using System;
using System.Linq;
using hastowork.Models.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace hastowork.Models 
{
    public static class DbInitializer
    {
        public static void Initialize(MyDbContext context) //3. we do not have a SchoolContext, but a MyDbContext
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            var movies = new Movie[]
            {
                // 4. change properties so they fit with what we have i Student.cs
            
            new Movie{MovieItemID = 1, MovieTitle = "First task", YearPublished = 1999, Genre ="Horror",
             Director ="The Stupid Idiot", MovieLength = "1 hour 00 minutes", MoviePlot ="some looooooooong text", Rating = 5 },
            new Movie{MovieItemID = 3, MovieTitle = "Second task", YearPublished = 2017, Genre ="Fiction",
             Director ="The Other Stupid Idiot", MovieLength = "1 hour 55 minutes", MoviePlot ="some looooooooong text", Rating = 1 },
            new Movie{MovieItemID = 4, MovieTitle = "Third task", YearPublished = 2007, Genre ="Romance",
             Director ="The Stupidest Idiot", MovieLength = "3 hour 09 minutes", MoviePlot ="some looooooooong text", Rating = 3 },
            };
            foreach (Movie m in movies)
            {
                context.Movies.Add(m);
            }
            context.SaveChanges();
        }
    }
}

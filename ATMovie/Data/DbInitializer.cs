using ATMovie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;

namespace ATMovie.Data
{
    public static class DbInitializer
    {
        
        public static void Seed(ATMovieContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Movie.Add(new Movie("One piece", "hej", "hejhejhej", "1,5", 150));
            context.SaveChanges();

        }
    }
}

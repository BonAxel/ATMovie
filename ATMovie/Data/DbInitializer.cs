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
            context.Movie.Add(new Movie("One piece", "Adventure", "One Piece is a Japanese manga and anime series created by Eiichiro Oda. It follows the adventures of " +
                "Monkey D. Luffy, a young pirate with the ability to stretch his body like rubber after consuming a " +
                "Devil Fruit. Luffy and his diverse crew set sail in search of the legendary One Piece treasure, encountering " +
                "powerful foes, forming alliances, and exploring a vast, fantastical world filled with unique characters and mysteries.", "2,45", 150, "https://m.media-amazon.com/images/M/MV5BODcwNWE3OTMtMDc3MS00NDFjLWE1OTAtNDU3NjgxODMxY2UyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg"));
            context.SaveChanges();

        }
    }
}

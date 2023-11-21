using ATMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace ATMovie.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Movie>().HasData(
                    new Movie()
                    {
                        MovieID = 1,
                        Title = "Lord of the Rings", 
                        Genre = "Fantasy",
                        Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                        Runtime = "120",
                        Price = 120,
                    });
        }
    }
}

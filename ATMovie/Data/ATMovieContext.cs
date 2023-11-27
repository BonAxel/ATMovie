using Microsoft.EntityFrameworkCore;
using ATMovie.Models;

namespace ATMovie.Data
{
    public class ATMovieContext : DbContext
    {
       
        public ATMovieContext(DbContextOptions<ATMovieContext> options)
            : base(options)
        {
            Seed();
        }

        public DbSet<ATMovie.Models.Movie> Movie { get; set; } = default!;
        public DbSet<ATMovie.Models.Show> Show { get; set; } = default!;

        public DbSet<ATMovie.Models.Salon> Salong { get; set; } = default!;

        public DbSet<ATMovie.Models.Booking> Booking { get; set; } = default!;


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //base.OnModelCreating(modelBuilder);
        //    //new DbInitializer(modelBuilder).Seed();
           
        //}

        private void Seed()
        {
            Movie.Add(new Movie("One piece", "hej", "hejhejhej", "1,5", 150));

        }
        // Db sets
    }
}

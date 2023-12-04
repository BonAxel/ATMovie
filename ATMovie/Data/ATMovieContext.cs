using Microsoft.EntityFrameworkCore;
using ATMovie.Models;

namespace ATMovie.Data
{
    public class ATMovieContext : DbContext
    {
       
        public ATMovieContext(DbContextOptions<ATMovieContext> options)
            : base(options)
        {
          
        }
        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<Show> Show { get; set; } = default!;
        public DbSet<Booking> Booking { get; set; } = default!;
        public DbSet<Salon> Salon { get; set; } = default!;
        public DbSet<Seat> Seat { get; set; } = default!;
        public DbSet<Row> Row { get; set; } = default!;
        public DbSet<Junction> Junctions { get; set; } = default!;
        public DbSet<SalonRows> SalonRows { get; set; } = default!;



    }
}

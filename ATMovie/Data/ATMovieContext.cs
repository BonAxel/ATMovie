using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ATMovie.Models;

namespace ATMovie.Data
{
    public class ATMovieContext : DbContext
    {
        public ATMovieContext (DbContextOptions<ATMovieContext> options)
            : base(options)
        {
        }

        public DbSet<ATMovie.Models.Movie> Movie { get; set; } = default!;

        public DbSet<ATMovie.Models.Show> Show { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                new DbInitializer(modelBuilder).Seed();
            }

            // Db sets
    }
}

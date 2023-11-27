using ATMovie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

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
            #region MOVIE
            modelBuilder.Entity<Movie>().HasData(
                    new Movie()
                    {
                        MovieID = 1,
                        Title = "Lord of the Rings",
                        Genre = "Fantasy",
                        Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                        Runtime = "2h32m",
                        Price = 120,
                    },
                    new Movie()
                    {
                        MovieID = 2,
                        Title = "The Witch",
                        Genre = "Horror",
                        Description = "A family in 1630s New England is torn apart by the forces of witchcraft, black magic and possession.",
                        Runtime = "1h32m",
                        Price = 120,
                    });
            #endregion

            #region SALON
            modelBuilder.Entity<Salon>().HasData(
            new Salon()
            {
                SalonID = 1,
                SalonName = "Tobias Hembio",
                NumberOfChairs = 300,
                Rows = null
            });
            #endregion

            #region ROW

            modelBuilder.Entity<Row>().HasData(
            new Row()
            {
                RowId = 1,
                RowNumber = 1,
                SalonId = 1,
            });

            #endregion

            //#region SHOW
            //modelBuilder.Entity<Show>().HasData(
            //    new Show()
            //    {
            //        ShowID = "S1",
            //        ShowDateTime = DateTime.Now,
            //        MovieID = 1,
            //        SalonID = 1,
            //    });
            

            

        }
    }
}

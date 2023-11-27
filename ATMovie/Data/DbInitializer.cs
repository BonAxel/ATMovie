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
            int id = 0;
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Movie.Add(new Movie("One Piece Film Red", "Animation", "For the first time ever, Uta - the most beloved singer in the world - will reveal herself to the world at a live concert. The voice that the whole world has been waiting for is about to resound.", "1h 55m", 150));
            context.Movie.Add(new Movie("Leo", "Animation", "A 74-year-old lizard named Leo and his turtle friend decide to escape from the terrarium of a Florida school classroom where they have been living for decades.", "1h 42m", 150));
            context.Movie.Add(new Movie("Scot Pilgrim Takes Off", "Animation", "A 20-something Toronto indie rocker's adventures in getting and keeping jobs, avoiding being kicked out of his apartment, and surviving encounters with the seven evil exes of the new girl in town on whom he has a crush.", "1h 35m", 150));
            context.Movie.Add(new Movie("Trolls 3", "Animation", "Poppy discovers that Branch was once part of the boy band 'BroZone' with his brothers, Floyd, John Dory, Spruce and Clay. When Floyd is kidnapped, Branch and Poppy embark on a journey to reunite his two other brothers and rescue Floyd.", "1h 31m", 150));


            context.Movie.Add(new Movie("Napoleon", "Action", "An epic that details the checkered rise and fall of French Emperor Napoleon Bonaparte and his relentless journey to power through the prism of his addictive, volatile relationship with his wife, Josephine.", "2h 38m", 150));
            context.Movie.Add(new Movie("Monarch: Legacy of Monsters", "Action", "Set after the battle between Godzilla and the Titans, revealing that monsters are real, follows one family's journey to uncover its buried secrets and a legacy linking them to Monarch.", "2h 40pm", 150));
            context.Movie.Add(new Movie("The Killer", "Action", "After a fateful near-miss, an assassin battles his employers and himself, on an international manhunt he insists isn't personal.", "1h 58m", 150));


            context.Movie.Add(new Movie("The Killer", "Horror", "After a Black Friday riot ends in tragedy, a mysterious Thanksgiving-inspired killer terrorizes Plymouth, Massachusetts - the birthplace of the infamous holiday.", "1h 46m", 150));
            context.Movie.Add(new Movie("Five Nights at Freddys", "Horror", "A troubled security guard begins working at Freddy Fazbear's Pizza. During his first night on the job, he realizes that the night shift won't be so easy to get through. Pretty soon he will unveil what actually happened at Freddy's.", "1h 49m", 150));
            context.Movie.Add(new Movie("Mord i Venedig", "Horror", "In post-World War II Venice, Poirot, now retired and living in his own exile, reluctantly attends a seance. But when one of the guests is murdered, it is up to the former detective to once again uncover the killer.", "1h 43", 150));

            context.Salon.Add(new Salon("Salon 1", 300, null));
            context.Salon.Add(new Salon("Salon 2", 400, null));
            context.Salon.Add(new Salon("Salon 3", 500, null));

            context.Show.Add(new Show(DateTime.Now, context.Movie.FirstOrDefault(m => m.MovieID.Equals(1)), context.Salon.FirstOrDefault(s => s.SalonID.Equals(1))));
            context.Show.Add(new Show(DateTime.Now, context.Movie.FirstOrDefault(m => m.MovieID.Equals("1")), context.Salon.FirstOrDefault(s => s.SalonID.Equals("2"))));
            context.Show.Add(new Show(DateTime.Now, context.Movie.FirstOrDefault(m => m.MovieID.Equals("1")), context.Salon.FirstOrDefault(s => s.SalonID.Equals("3"))));
            context.Show.Add(new Show(DateTime.Now, context.Movie.FirstOrDefault(m => m.MovieID.Equals("4")), context.Salon.FirstOrDefault(s => s.SalonID.Equals("1"))));

            context.SaveChanges();

        }
    }
}

using ATMovie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Net.NetworkInformation;

namespace ATMovie.Data
{
    public static class DbInitializer
    {

        public static void Seed(ATMovieContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.Movie.Add(new Movie("One Piece Film Red", "Animation", "For the first time ever," +
                " Uta - the most beloved singer in the world - will reveal herself to the world at a live concert." +
                " The voice that the whole world has been waiting for is about to resound.", "1h 55m",
                150, "https://m.media-amazon.com/images/M/MV5BODcwNWE3OTMtMDc3MS00NDFjLWE1OTAtNDU3NjgxODMxY2UyXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg"));
            context.Movie.Add(new Movie("Leo", "Animation", "A 74-year-old lizard named " +
                "Leo and his turtle friend decide to escape from the terrarium of a Florida " +
                "school classroom where they have been living for decades.", "1h 42m", 150, "https://m.media-amazon.com/images/M/MV5BZDNiZWI3ZmItMjY4OS00Mjk5LThlNjktMmMwZDM1OTEwOGVmXkEyXkFqcGdeQXVyMDc5ODIzMw@@._V1_.jpg"));
            context.Movie.Add(new Movie("Scot Pilgrim Takes Off", "Animation", "A 20-something " +
                "Toronto indie rocker's adventures in getting and keeping jobs, avoiding being kicked" +
                " out of his apartment, and surviving encounters with the seven evil exes of the new" +
                " girl in town on whom he has a crush.", "1h 35m", 150, "https://i.pinimg.com/236x/2f/29/a8/2f29a8fbfee460dccca9bc0f0c2041e0.jpg"));
            context.Movie.Add(new Movie("Trolls 3", "Animation", "Poppy discovers that Branch was once " +
                "part of the boy band 'BroZone' with his brothers, Floyd, John Dory, Spruce and Clay. When " +
                "Floyd is kidnapped, Branch and Poppy embark on a journey to reunite his two other brothers and rescue Floyd.", "1h 31m", 150, "https://imusic.b-cdn.net/images/item/original/520/9781408370520.jpg?2023-official-trolls-band-together-story-of-the-movie-trolls-3-pocketbok&class=scaled&v=1692548218"));
            context.Movie.Add(new Movie("Napoleon", "Action", "An epic that details the checkered " +
                "rise and fall of French Emperor Napoleon Bonaparte and his relentless journey to " +
                "power through the prism of his addictive, volatile relationship with his wife, Josephine.", "2h 38m", 150, "https://resizing.flixster.com/IV_6IDxEbgc14nQNEUo1jiUFbD8=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzLzU2NzUxMTgyLTFkMDgtNDhjYi05MTU4LWFlYWRmNmM5ZjYxNC5qcGc="));
            context.Movie.Add(new Movie("The Hunger Games: The Ballad of Songbird & Snakes", "Action", "Coriolanus Snow" +
                " mentors and develops feelings for the female District 12 tribute during the 10th Hunger Games.", "2h 37m", 150, "https://statiskt.filmbladet.se/bilder/bc2/70a20d35a27f94d3bb6dfcb47625572d37130787.webp"));
            context.Movie.Add(new Movie("Monarch: Legacy of Monsters", "Action", "Set after the " +
                "battle between Godzilla and the Titans, revealing that monsters are real, follows" +
                " one family's journey to uncover its buried secrets and a legacy linking them to Monarch.", "2h 40pm", 150, "https://m.media-amazon.com/images/M/MV5BNDk5MzYzZmYtOTFiZi00YmE2LWFjOGUtNjMyODgxNjZiYzRjXkEyXkFqcGdeQXVyMTEyMjM2NDc2._V1_FMjpg_UX1000_.jpg"));
            context.Movie.Add(new Movie("The Killer", "Action", "After a fateful near-miss," +
                " an assassin battles his employers and himself, on an international manhunt he insists isn't personal.", "1h 58m", 150, "https://m.media-amazon.com/images/M/MV5BZGJkMDUwZWQtYTMzMS00NTg5LWE1ZTYtOTVhMDI4NGI1YjMyXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_FMjpg_UX1000_.jpg"));
            context.Movie.Add(new Movie("Five Nights at Freddys", "Horror", "A troubled security" +
                " guard begins working at Freddy Fazbear's Pizza. During his first night on the job," +
                " he realizes that the night shift won't be so easy to get through. Pretty soon he will unveil what actually happened at Freddy's.", "1h 49m", 150, "https://resizing.flixster.com/-VIYEEAwdsv2m3Hsbs6OKHgPXK8=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzL2YxMTg4MTI4LTc3MmUtNDVkMC1iZTg2LTM4ZmEwMWE2ZWE3NS5qcGc="));
            context.Movie.Add(new Movie("Mord i Venedig", "Horror", "In post-World War II Venice," +
                " Poirot, now retired and living in his own exile, reluctantly attends a seance. " +
                "But when one of the guests is murdered, it is up to the former detective to once again uncover the killer.", "1h 43", 150, "https://img-cdn.sfanytime.com/COVERM/COVERM_24002253-2c8d-49e4-bd0c-4fcfdb942524_sv.jpg?w=375&ar=0.692&fit=crop&fm=pjpg&s=9d204ca5fe7f72fe336ca00e547207db"));

            for (int i = 0; i < 300; i++) context.Seat.Add(new Seat(false));

  
            for (int i = 0; i >= 5; i++)
            {
                List<Seat> seats = new List<Seat>();
                foreach (Seat item in context.Seat)
                {
                    seats.Add(item);
                }
                Row row = new Row(seats);
                context.Row.Add(row);
            }

            //context.Salon.Add(new Salon("Salon 1", 150, salong1Rows));
            //context.Salon.Add(new Salon("Salon 2", 200, salong2Rows));
            //context.Salon.Add(new Salon("Salon 3", 300, salong3Rows));

            //List<Row> salong1Rows = new List<Row>();
            //foreach (var item in context.Row)
            //{
            //    List<Row> row = new List<Row>();
            //    foreach (var test in context.Seat)
            //    {

            //    }
            //}
            //    for (int i = 0; i <= 2; i++) 
            //    salong1Rows.Add(item);




            //List<Row> salong2Rows = new List<Row>();
            //foreach (var item in context.Seat) for (int i = 0; i <= 4; i++) salong1Rows.Add(item);

            //List<Row> salong3Rows = new List<Row>();
            //List<Seat> salong3Seats = new List<Seat>();
            //foreach (var item in context.Seat)
            //{
            //    for (int i = 0; i <= 5; i++)
            //    {
            //        salong3Seats.Add(item);
            //    }
            //    //salong3Rows = new Row(salong3Seats);
            //}

            context.SaveChanges();

            context.Salon.Add(new Salon("Salon 1", 150, null));
            context.Salon.Add(new Salon("Salon 2", 200, null));
            context.Salon.Add(new Salon("Salon 3", 300, null));

            context.SaveChanges();

            context.Show.Add(new Show(DateTime.Now, context.Movie.FirstOrDefault(m => m.MovieID.Equals(1)), context.Salon.FirstOrDefault(s => s.SalonID.Equals(1))));
            context.Show.Add(new Show(DateTime.Now, context.Movie.FirstOrDefault(m => m.MovieID.Equals(1)), context.Salon.FirstOrDefault(s => s.SalonID.Equals(2))));
            context.Show.Add(new Show(DateTime.Now, context.Movie.FirstOrDefault(m => m.MovieID.Equals(1)), context.Salon.FirstOrDefault(s => s.SalonID.Equals(3))));
            context.Show.Add(new Show(DateTime.Now, context.Movie.FirstOrDefault(m => m.MovieID.Equals(4)), context.Salon.FirstOrDefault(s => s.SalonID.Equals(1))));

            context.SaveChanges();

        }
    }
}

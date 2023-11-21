namespace ATMovie.Models
{
    public class Movie
    {

        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; } 
        public string Runtime { get; set; }
        public int Price { get; set; }

        public Movie(int movieID, string title, string genre, string description, string runtime, int price)
        {
            MovieID = movieID;
            Title = title;
            Genre = genre;
            Description = description;
            Runtime = runtime;
            Price = price;
        }

    }
}

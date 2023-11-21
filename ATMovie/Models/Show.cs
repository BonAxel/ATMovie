namespace ATMovie.Models
{
    public class Show
    {
        public DateTime ShowDateTime { get; set; }
        public Movie Movie { get; set; }
        public Salon Salon { get; set; }
        public Show(DateTime showDateTime, Movie movie, Salon salon)
        {
            ShowDateTime = showDateTime;
            Movie = movie;
            Salon = salon;
        }
    }
}

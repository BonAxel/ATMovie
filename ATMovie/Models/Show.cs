namespace ATMovie.Models
{
    public class Show
    {
        public DateTime ShowDate { get; set; }
        public Movie Movie { get; set; }
        public Salon Salon { get; set; }
    }
}

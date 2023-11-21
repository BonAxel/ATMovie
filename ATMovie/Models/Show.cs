namespace ATMovie.Models
{
    public class Föreställning
    {
        public DateTime ShowDate { get; set; }
        public Movie Movie { get; set; }
        public Salon Salon { get; set; }
    }
}

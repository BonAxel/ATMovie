namespace ATMovie.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string Kundnamn  { get; set; }
        public string Epost { get; set; }
        public Show Show { get; set; }
        public Seat Seat { get; set; }

    }
}

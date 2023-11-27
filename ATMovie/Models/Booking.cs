namespace ATMovie.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string Kundnamn { get; set; }
        public string Epost { get; set; }
        public Show Show { get; set; }
        public Seat Seat { get; set; }

        public Booking(int bookingID, string kundnamn, string epost, Show show, Seat seat)
        {
            BookingID = bookingID;
            Kundnamn = kundnamn;
            Epost = epost;
            Show = show;
            Seat = seat;
        }
    }
}

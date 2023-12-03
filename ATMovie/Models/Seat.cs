using Microsoft.EntityFrameworkCore.Update.Internal;

namespace ATMovie.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public bool IsBooked { get; set; }

        public Seat(bool isBooked)
        {
            IsBooked = isBooked;
        }


        public Seat()
        {

        }
    }
}

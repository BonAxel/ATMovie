using Microsoft.EntityFrameworkCore.Update.Internal;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ATMovie.Models
{
    //public class Seat
    //{
    //    public int SeatId { get; set; }
    //    public bool IsBooked { get; set; }

    //    Row Row { get; set; }

    //    public Seat(bool isBooked)
    //    {
    //        IsBooked = isBooked;
    //    }


    //    public Seat()
    //    {

    //    }
    //}
    public class Seat
    {
        public int SeatId { get; set; }
        public bool IsBooked { get; set; }

        // Foreign key property
        public ICollection<Junction>? Seats { get; set; }

        public Seat(bool isBooked)
        {
            IsBooked = isBooked;
        }

        public Seat()
        {

        }
    }
}

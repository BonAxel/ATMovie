using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace ATMovie.Models
{
    public class Row
    {
        public int Id { get; set; }
        public int AmountOfChairs { get; set; }
        public List<Seat> Seats { get; set; }

        public Row(List<Seat> seats)
        {
            Seats = seats;
        }

        public Row()
        {

        }

    }
}

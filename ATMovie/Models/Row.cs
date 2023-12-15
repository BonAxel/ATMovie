using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace ATMovie.Models
{

    public class Row
    {
        public int Id { get; set; }
        public ICollection<RowSeat>? Seats { get; set; }

        public Row()
        {
                
        }

        public Row(ICollection<RowSeat>? seats)
        {
            Seats = seats;
        }
    }

}

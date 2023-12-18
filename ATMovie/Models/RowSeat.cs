using System.ComponentModel.DataAnnotations;

namespace ATMovie.Models
{
    public class RowSeat
    {

        [Display(Name = "Seat")]
        public int RowSeatId { get; set; }

        [Display(Name = "Row")]
        public int RowID { get; set; }
        public Row Row { get; set; }

        public int SeatID { get; set; }
        public Seat Seat { get; set; }


        public RowSeat()
        {
                
        }
    }
}

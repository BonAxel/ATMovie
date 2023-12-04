namespace ATMovie.Models
{
    public class RowSeat
    {

        public int RowSeatId { get; set; }

        public int RowID { get; set; }
        public Row Row { get; set; }

        public int SeatID { get; set; }
        public Seat Seat { get; set; }

    }
}

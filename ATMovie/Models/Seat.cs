namespace ATMovie.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int SeatNumber { get; set; }
        public int RowId { get; set; }
        public int SalonId { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }

        public Seat(int seatId, int seatNumber, int rowId, int salonId, string status, decimal price)
        {
            SeatId = seatId;
            SeatNumber = seatNumber;
            RowId = rowId;
            SalonId = salonId;
            Status = status;
            Price = price;
        }
    }
}

namespace ATMovie.Models
{
    public class Row
    {
        public int RowId { get; set; }
        public int RowNumber { get; set; }
        
        public int SalonId { get; set; }
        public List<Seat> Seats { get; set; }

        public Row(int rowId, int rowNumber, int salonId)
        {
            RowId = rowId;
            RowNumber = rowNumber;
            SalonId = salonId;
        }
        public Row()
        {
                
        }
    }
}

namespace ATMovie.Models
{
    public class SalonRows
    {

        public int Id { get; set; }

        public int SalonID { get; set; }
        public Salon Salon { get; set; }

        public int RowID { get; set; }
        public Row Row { get; set; }

        public SalonRows(Salon salon, Row row)
        {
            Salon = salon;
            Row = row;
        }
        public SalonRows()
        {
                
        }

        public SalonRows(int id, int salonID, Salon salon, int rowID, Row row)
        {
            Id = id;
            SalonID = salonID;
            Salon = salon;
            RowID = rowID;
            Row = row;
        }
    }
}

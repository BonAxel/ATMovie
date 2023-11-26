namespace ATMovie.Models
{
    public class Salon
    {
        public int SalonID { get; set; }
        public string SalonName { get; set; }
        public int NumberOfChairs { get; set; }
        public List<Row> Rows { get; set; }
        public Salon(int salonID, string salonName, int numberOfChairs, List<Row> rows)
        {
            SalonID = salonID;
            SalonName = salonName;
            NumberOfChairs = numberOfChairs;
            Rows = rows;
        }
        public Salon()
        {
                
        }
    }
}

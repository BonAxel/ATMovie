using System.ComponentModel.DataAnnotations.Schema;

namespace ATMovie.Models
{
    public class Salon
    {
        public int SalonID { get; set; }
        public string SalonName { get; set; }
        
        public int NumberOfChairs { get; set; }

        public int NumberOfBookedChairs { get { return NumberOfChairs - NumberOfBookedChairs; } }

        public string NumberOfAvaliableChairs { get { return NumberOfBookedChairs + "/" + NumberOfChairs; } }

        
        public ICollection<Row>? Rows { get; set; }

        public Salon(int salonID, string salonName, int numberOfChairs, ICollection<Row> rows)
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

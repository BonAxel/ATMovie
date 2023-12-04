using System.ComponentModel.DataAnnotations.Schema;

namespace ATMovie.Models
{
    public class Salon
    {
        public int SalonID { get; set; }
        public string SalonName { get; set; }

        public int NumberOfChairs { get; set; }

        public List<SalonRows>? SalonRows { get; set; }

        public Salon(string salonName, int numberOfChairs, List<SalonRows> salonRows)
        {
            SalonName = salonName;
            NumberOfChairs = numberOfChairs;
            SalonRows = salonRows;
        }
        public Salon() 
        {

        }



    }
}

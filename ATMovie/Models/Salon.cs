using System.ComponentModel.DataAnnotations.Schema;

namespace ATMovie.Models
{
    public class Salon
    {
        public int SalonID { get; set; }
        public string SalonName { get; set; }

        public int NumberOfChairs { get; set; }

        //public int NumberOfBookedChairs { get { return NumberOfChairs - NumberOfBookedChairs; } }

        //public string NumberOfAvaliableChairs { get { return NumberOfBookedChairs + "/" + NumberOfChairs; } }


        public List<Row>? Rows { get; set; }

        public Salon(string salonName, int numberOfChairs, List<Row> rows)
        {
            SalonName = salonName;
            NumberOfChairs = numberOfChairs;
            Rows = rows;
        }
        public Salon() 
        {

        }



    }
}

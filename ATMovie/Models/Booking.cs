using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATMovie.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        [Display(Name = "Customer Name")]
        public string Kundnamn { get; set; }
        [Display(Name = "E-mail")]
        public string Epost { get; set; }

        public Show? Show { get; set; }
       
        public RowSeat? RowSeat { get; set; }

        public Salon? Salon { get; set; }


        public Booking(int bookingID, string kundnamn, string epost, Show show, RowSeat rowSeat, Salon salon)
        {
            BookingID = bookingID;
            Kundnamn = kundnamn;
            Epost = epost;
            Show = show;
            RowSeat = rowSeat;
            Salon = salon;
        }
        public Booking()
        {
            
        }

    }
}

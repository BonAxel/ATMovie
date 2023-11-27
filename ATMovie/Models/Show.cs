using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATMovie.Models
{
    public class Show
    {
        public int ShowID { get; set; }
        public DateTime ShowDateTime { get; set; }
        public string ShowHour { get { return ShowDateTime.ToShortTimeString(); } }
        public Movie? Movie { get; set; }
        public Salon? Salon { get; set; }

        public Show(DateTime showDateTime, Movie movie, Salon salon)
        {
            ShowDateTime = showDateTime;
            Movie = movie;
            Salon = salon;
        }

        public Show()
        {

        }
    }
}

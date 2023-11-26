using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATMovie.Models
{
    public class Show
    {
        public DateTime ShowDateTime { get; set; }

        [ForeignKey("MovieID")]
        public Movie Movie { get; set; }

        [ForeignKey("SalonID")]
        public Salon Salon { get; set; }
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

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace kursovaya.Data.Entities
{
    public class Screening
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int AuditoriumId { get; set; }
        public string Quality { get; set; }
        public decimal Cost { get; set; }
        public DateTime Screening_start { get; set; }
        [JsonIgnore]
        public virtual Auditorium? Auditorium { get; set; }
        [JsonIgnore]
        public virtual Movie? Movie { get; set; }
        [JsonIgnore]
        public List<Reserved_seat>? Reserved_seats { get; set; }
        [JsonIgnore]
        public List<Booking>? Bookings { get; set; }
        [JsonIgnore]
        public virtual Poster? Poster { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace volzshki.Models
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }
        public int AuditoriumId { get; set; }
        public int Row { get; set; }
        public int Number { get; set; }
        [JsonIgnore]
        public virtual Auditorium? Auditorium { get; set; }
        [JsonIgnore]
        public List<Reserved_seat>? Reserved_seats { get; set; }
    }
}

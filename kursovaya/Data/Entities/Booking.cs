using System.Text.Json.Serialization;

namespace kursovaya.Data.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int ScreeningId { get; set; }
        public int ClientId { get; set; }
        public DateTime Date_Time { get; set; }
        public int Amount_Seat { get; set; }
        public decimal Cost { get; set; }
        [JsonIgnore]
        public virtual Client? Client { get; set; }
        [JsonIgnore]
        public List<Reserved_seat>? Reserved_seats { get; set; }
        [JsonIgnore]
        public virtual Screening? Screening { get; set; }
    }
}

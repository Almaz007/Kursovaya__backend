using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace kursovaya.Data.Entities
{
    public class Reserved_seat
    {
        [Key]
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int SeatId { get; set; }
        public int ScreeningId { get; set; }
        [JsonIgnore]
        public virtual Seat? Seat { get; set; }
        [JsonIgnore]
        public virtual Screening? Screening { get; set; }
        [JsonIgnore]
        public virtual Booking? Booking { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace volzshki.Models
{
    public class Auditorium
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Seat_Capacity { get; set; }
        public List<Seat>? Seats { get; set; }
        public List<Screening>? Screenings { get; set; }
    }
}

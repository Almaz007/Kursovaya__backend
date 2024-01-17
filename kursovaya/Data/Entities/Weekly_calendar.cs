using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace kursovaya.Data.Entities
{
    public class Weekly_calendar
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string DayWeek { get; set; }
        [JsonIgnore]
        public List<Poster>? Posters { get; set; }
    }
}

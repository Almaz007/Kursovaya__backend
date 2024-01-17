using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace kursovaya.Data.Entities
{
    public class Poster
    {
        [Key]
        public int Id { get; set; }

        public int WeeklyDayId { get; set; }

        public int ScreeningId { get; set; }
        [JsonIgnore]
        public virtual Screening? Screening { get; set; }
        [JsonIgnore]
        public virtual Weekly_calendar? WeeklyDay { get; set; }

    }
}

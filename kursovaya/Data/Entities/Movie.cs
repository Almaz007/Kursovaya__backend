using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace kursovaya.Data.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Duration { get; set; }
        public DateTime Release_Date { get; set; }
        public string? Country { get; set; }
        public string? Directore { get; set; }
        public string? Screenwriters { get; set; }
        public string? Rating { get; set; }
        public string? Description { get; set; }
        public string? Poster_Link { get; set; }
        [JsonIgnore]
        public List<Movie_genre>? Movie_genres { get; set; }
        [JsonIgnore]
        public List<Screening>? Screenings { get; set; }
    }
}

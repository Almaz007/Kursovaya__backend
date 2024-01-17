using System.ComponentModel.DataAnnotations;

namespace kursovaya.Data.Entities
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<Movie_genre>? Movie_genres { get; set; }
    }
}

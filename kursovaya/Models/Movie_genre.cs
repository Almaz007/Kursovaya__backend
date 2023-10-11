﻿using System.ComponentModel.DataAnnotations;

namespace volzshki.Models
{
    public class Movie_genre
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public virtual Movie? Movie { get; set; }
        public virtual Genre? Genre { get; set; }
    }
}

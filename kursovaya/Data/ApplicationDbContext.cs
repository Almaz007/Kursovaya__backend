using Microsoft.EntityFrameworkCore;
using volzshki.Models;

namespace kursovaya.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie_genre> Movies_genres { get; set; }
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Reserved_seat> Reserved_seats { get; set; } 

        public DbSet<Weekly_calendar> Weekly_calendar { get; set; }
        public DbSet<Poster> Poster { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Movie_genre>().HasIndex(elem => new { elem.MovieId, elem.GenreId }).IsUnique();
            builder.Entity<Poster>().HasIndex(elem => new { elem.ScreeningId }).IsUnique();
            builder.Entity<Weekly_calendar>().HasIndex(elem => new { elem.Date, elem.DayWeek }).IsUnique();
            builder.Entity<Screening>().HasIndex(elem => new { elem.AuditoriumId, elem.Screening_start }).IsUnique();
            builder.Entity<Reserved_seat>().HasIndex(elem => new { elem.SeatId, elem.ScreeningId }).IsUnique();

            builder.Entity<Booking>().Property(u => u.Cost).HasColumnType("decimal(10, 2)");
            builder.Entity<Screening>().Property(u => u.Cost).HasColumnType("decimal(10, 2)");
            /*   builder.Entity<Reserved_seat>().HasIndex(elem => new { elem.BookingId }).IsUnique();*/
            //builder.Entity<Reserved_seat>().HasIndex(elem => new { elem.MovieId, elem.GenreId }).IsUnique();


            builder.Entity<Screening>()
           .HasOne(rs => rs.Auditorium)
           .WithMany(s => s.Screenings)
           .HasForeignKey(rs => rs.AuditoriumId)
           .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Screening>()
           .HasOne(rs => rs.Movie)
           .WithMany(s => s.Screenings)
           .HasForeignKey(rs => rs.MovieId)
           .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Seat>()
           .HasOne(rs => rs.Auditorium)
           .WithMany(s => s.Seats)
           .HasForeignKey(rs => rs.AuditoriumId)
           .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Booking>()
            .HasOne(rs => rs.Screening)
            .WithMany(s => s.Bookings)
            .HasForeignKey(rs => rs.ScreeningId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Booking>()
            .HasOne(rs => rs.Client)
            .WithMany(s => s.Bookings)
            .HasForeignKey(rs => rs.ClientId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Reserved_seat>()
            .HasOne(rs => rs.Seat)
            .WithMany(s => s.Reserved_seats)
            .HasForeignKey(rs => rs.SeatId)
            .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Reserved_seat>()
            .HasOne(rs => rs.Screening)
            .WithMany(s => s.Reserved_seats)
            .HasForeignKey(rs => rs.ScreeningId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Reserved_seat>()
            .HasOne(rs => rs.Booking)
            .WithMany(s => s.Reserved_seats)
            .HasForeignKey(rs => rs.BookingId)
            .OnDelete(DeleteBehavior.Restrict);


            //builder.Entity<Reserved_seat>().HasReyquired(x => x.Seat).WithMany(e => e.Reserved_seats);


            base.OnModelCreating(builder);
        }
        public DbSet<volzshki.Models.Booking> Booking { get; set; } = default!;
    }
}

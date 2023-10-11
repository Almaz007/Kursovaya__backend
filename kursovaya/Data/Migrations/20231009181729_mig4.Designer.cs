﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kursovaya.Data;

#nullable disable

namespace kursovaya.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231009181729_mig4")]
    partial class mig4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("volzshki.Models.Auditorium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seat_Capacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Auditoriums");
                });

            modelBuilder.Entity("volzshki.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount_Seat")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<DateTime>("Date_Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ScreeningId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("volzshki.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("volzshki.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("volzshki.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Directore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Poster_Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Screenwriters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("volzshki.Models.Movie_genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("MovieId", "GenreId")
                        .IsUnique();

                    b.ToTable("Movies_genres");
                });

            modelBuilder.Entity("volzshki.Models.Poster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ScreeningId")
                        .HasColumnType("int");

                    b.Property<int>("WeeklyDayId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScreeningId")
                        .IsUnique();

                    b.HasIndex("WeeklyDayId");

                    b.ToTable("Poster");
                });

            modelBuilder.Entity("volzshki.Models.Reserved_seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("ScreeningId");

                    b.HasIndex("SeatId", "ScreeningId")
                        .IsUnique();

                    b.ToTable("Reserved_seats");
                });

            modelBuilder.Entity("volzshki.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuditoriumId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Quality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Screening_start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("AuditoriumId", "Screening_start")
                        .IsUnique();

                    b.ToTable("Screenings");
                });

            modelBuilder.Entity("volzshki.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuditoriumId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuditoriumId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("volzshki.Models.Weekly_calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DayWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Date", "DayWeek")
                        .IsUnique();

                    b.ToTable("Weekly_calendar");
                });

            modelBuilder.Entity("volzshki.Models.Booking", b =>
                {
                    b.HasOne("volzshki.Models.Client", "Client")
                        .WithMany("Bookings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("volzshki.Models.Screening", "Screening")
                        .WithMany("Bookings")
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Screening");
                });

            modelBuilder.Entity("volzshki.Models.Movie_genre", b =>
                {
                    b.HasOne("volzshki.Models.Genre", "Genre")
                        .WithMany("Movie_genres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("volzshki.Models.Movie", "Movie")
                        .WithMany("Movie_genres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("volzshki.Models.Poster", b =>
                {
                    b.HasOne("volzshki.Models.Screening", "Screening")
                        .WithOne("Poster")
                        .HasForeignKey("volzshki.Models.Poster", "ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("volzshki.Models.Weekly_calendar", "WeeklyDay")
                        .WithMany("Posters")
                        .HasForeignKey("WeeklyDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screening");

                    b.Navigation("WeeklyDay");
                });

            modelBuilder.Entity("volzshki.Models.Reserved_seat", b =>
                {
                    b.HasOne("volzshki.Models.Booking", "Booking")
                        .WithMany("Reserved_seats")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("volzshki.Models.Screening", "Screening")
                        .WithMany("Reserved_seats")
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("volzshki.Models.Seat", "Seat")
                        .WithMany("Reserved_seats")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Screening");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("volzshki.Models.Screening", b =>
                {
                    b.HasOne("volzshki.Models.Auditorium", "Auditorium")
                        .WithMany("Screenings")
                        .HasForeignKey("AuditoriumId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("volzshki.Models.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Auditorium");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("volzshki.Models.Seat", b =>
                {
                    b.HasOne("volzshki.Models.Auditorium", "Auditorium")
                        .WithMany("Seats")
                        .HasForeignKey("AuditoriumId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Auditorium");
                });

            modelBuilder.Entity("volzshki.Models.Auditorium", b =>
                {
                    b.Navigation("Screenings");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("volzshki.Models.Booking", b =>
                {
                    b.Navigation("Reserved_seats");
                });

            modelBuilder.Entity("volzshki.Models.Client", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("volzshki.Models.Genre", b =>
                {
                    b.Navigation("Movie_genres");
                });

            modelBuilder.Entity("volzshki.Models.Movie", b =>
                {
                    b.Navigation("Movie_genres");

                    b.Navigation("Screenings");
                });

            modelBuilder.Entity("volzshki.Models.Screening", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Poster");

                    b.Navigation("Reserved_seats");
                });

            modelBuilder.Entity("volzshki.Models.Seat", b =>
                {
                    b.Navigation("Reserved_seats");
                });

            modelBuilder.Entity("volzshki.Models.Weekly_calendar", b =>
                {
                    b.Navigation("Posters");
                });
#pragma warning restore 612, 618
        }
    }
}

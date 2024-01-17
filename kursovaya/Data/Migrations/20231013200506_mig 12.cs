using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kursovaya.Migrations
{
    /// <inheritdoc />
    public partial class mig12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Client_ClientId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Screenings_ScreeningId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserved_seats_Booking_BookingId",
                table: "Reserved_seats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_ScreeningId",
                table: "Bookings",
                newName: "IX_Bookings_ScreeningId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_ClientId",
                table: "Bookings",
                newName: "IX_Bookings_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Client_ClientId",
                table: "Bookings",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Screenings_ScreeningId",
                table: "Bookings",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserved_seats_Bookings_BookingId",
                table: "Reserved_seats",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Client_ClientId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Screenings_ScreeningId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserved_seats_Bookings_BookingId",
                table: "Reserved_seats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_ScreeningId",
                table: "Booking",
                newName: "IX_Booking_ScreeningId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_ClientId",
                table: "Booking",
                newName: "IX_Booking_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Client_ClientId",
                table: "Booking",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Screenings_ScreeningId",
                table: "Booking",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserved_seats_Booking_BookingId",
                table: "Reserved_seats",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

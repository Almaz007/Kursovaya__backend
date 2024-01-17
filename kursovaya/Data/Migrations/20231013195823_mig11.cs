using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kursovaya.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reserved_seats_BookingId",
                table: "Reserved_seats");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_seats_BookingId",
                table: "Reserved_seats",
                column: "BookingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reserved_seats_BookingId",
                table: "Reserved_seats");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_seats_BookingId",
                table: "Reserved_seats",
                column: "BookingId",
                unique: true);
        }
    }
}

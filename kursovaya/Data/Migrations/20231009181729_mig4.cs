using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kursovaya.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cast",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Cast",
                table: "Booking",
                newName: "Cost");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Booking",
                newName: "Cast");

            migrationBuilder.AddColumn<decimal>(
                name: "Cast",
                table: "Movies",
                type: "decimal(10,2)",
                nullable: true);
        }
    }
}

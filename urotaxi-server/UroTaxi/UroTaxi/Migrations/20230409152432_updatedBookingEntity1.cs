using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UroTaxi.Migrations
{
    /// <inheritdoc />
    public partial class updatedBookingEntity1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "carModel",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "carModel",
                table: "Bookings");
        }
    }
}

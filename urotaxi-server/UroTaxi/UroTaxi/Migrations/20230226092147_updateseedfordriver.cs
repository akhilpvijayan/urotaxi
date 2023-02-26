using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UroTaxi.Migrations
{
    /// <inheritdoc />
    public partial class updateseedfordriver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "driverId",
                keyValue: 2,
                column: "driverName",
                value: "John Moose");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "driverId",
                keyValue: 2,
                column: "driverName",
                value: "John");
        }
    }
}

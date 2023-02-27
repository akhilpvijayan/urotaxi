using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UroTaxi.Migrations
{
    /// <inheritdoc />
    public partial class updatedDriverSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookingDetails");

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "driverId", "carModel", "driverEMail", "driverName", "driverPhone", "isActive" },
                values: new object[,]
                {
                    { 18, 18, "gregory@gmail.com", "Gregory", 9871000010L, true },
                    { 19, 19, "chris@gmail.com", "Chris", 9871111010L, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "driverId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "driverId",
                keyValue: 19);

            migrationBuilder.CreateTable(
                name: "bookingDetails",
                columns: table => new
                {
                    bookingDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carModelId = table.Column<int>(type: "int", nullable: false),
                    carName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carTypeId = table.Column<int>(type: "int", nullable: false),
                    driverEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    driverId = table.Column<int>(type: "int", nullable: false),
                    driverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    driverPhone = table.Column<long>(type: "bigint", nullable: false),
                    fare = table.Column<long>(type: "bigint", nullable: false),
                    fuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    seats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingDetails", x => x.bookingDetailId);
                });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UroTaxi.Migrations
{
    /// <inheritdoc />
    public partial class addedseedandentitiesandfueltypetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "fuelType",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isAC",
                table: "CarModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "minFare",
                table: "CarModels",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "seats",
                table: "CarModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "fueltypes",
                columns: table => new
                {
                    fuelTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fuelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fueltypes", x => x.fuelTypeId);
                });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 1,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 250L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 2,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 2, true, 280L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 3,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 550L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 4,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 3, true, 450L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 5,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 2, true, 400L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 6,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 4, true, 950L, 2 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 7,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 1050L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 8,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 2, true, 150L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 9,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 300L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 10,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 800L, 7 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 11,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 370L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 12,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 750L, 6 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 13,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 250L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 14,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 1250L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 15,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 350L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 16,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 1, true, 280L, 4 });

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 17,
                columns: new[] { "fuelType", "isAC", "minFare", "seats" },
                values: new object[] { 2, true, 680L, 6 });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "carModelId", "carImage", "carModel", "carType", "fuelType", "isAC", "isActive", "minFare", "seats" },
                values: new object[,]
                {
                    { 18, "https://media.zigcdn.com/media/model/2022/Aug/tiago-new-1_930x620.jpg", "Tata Tiago", 1, 1, true, true, 250L, 4 },
                    { 19, "https://media.zigcdn.com/media/model/2020/Nov/hyundai-i20-2_930x620.jpg", "Hyundai i20", 1, 2, true, true, 290L, 4 }
                });

            migrationBuilder.InsertData(
                table: "fueltypes",
                columns: new[] { "fuelTypeId", "fuelType", "isActive" },
                values: new object[,]
                {
                    { 1, "Petrol", true },
                    { 2, "Diesel", true },
                    { 3, "Hybrid", true },
                    { 4, "Electric", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fueltypes");

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "carModelId",
                keyValue: 19);

            migrationBuilder.DropColumn(
                name: "fuelType",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "isAC",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "minFare",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "seats",
                table: "CarModels");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UroTaxi.Migrations
{
    /// <inheritdoc />
    public partial class addedseedandentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    bookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    source = table.Column<int>(type: "int", nullable: false),
                    destination = table.Column<int>(type: "int", nullable: false),
                    pickUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pickUpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<long>(type: "bigint", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dropAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.bookingId);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    carModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carType = table.Column<int>(type: "int", nullable: false),
                    carImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.carModelId);
                });

            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    carTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.carTypeId);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    cityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.cityId);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    driverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    driverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    driverPhone = table.Column<long>(type: "bigint", nullable: false),
                    driverEMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carModel = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.driverId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    reviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    driverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.reviewId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userPhone = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    isDriver = table.Column<bool>(type: "bit", nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "carModelId", "carImage", "carModel", "carType", "isActive" },
                values: new object[,]
                {
                    { 1, "https://imgd.aeplcdn.com/1056x594/n/cw/ec/32597/altroz-exterior-right-front-three-quarter-79.jpeg?isig=0&q=75&wm=1", "Tata Altroz", 1, true },
                    { 2, "https://imgd.aeplcdn.com/1056x594/n/cw/ec/112839/glanza-facelift-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1", "Toyota Glanza", 1, true },
                    { 3, "https://imgd.aeplcdn.com/1056x594/n/cw/ec/26755/city-4th-generation-exterior-right-front-three-quarter.jpeg?q=75&wm=1", "Honda City", 2, true },
                    { 4, "https://imgd.aeplcdn.com/1056x594/n/cw/ec/44088/slavia-exterior-right-front-three-quarter-5.jpeg?isig=0&q=75&wm=1", "Skoda Slavia", 2, true },
                    { 5, "https://imgd.aeplcdn.com/1056x594/n/cw/ec/45951/amaze-facelift-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1", "Honda Amaze", 3, true },
                    { 6, "https://imgd.aeplcdn.com/1056x594/n/cw/ec/46994/jaguar-f-type-right-front-three-quarter18.jpeg?q=75&wm=1", "Jaguar F-Type", 4, true },
                    { 7, "https://imgd.aeplcdn.com/1056x594/n/cw/ec/48034/2-series-gran-coupe-exterior-right-front-three-quarter.jpeg?q=75&wm=1", "BMW 2-Series Gran Coupe", 4, true },
                    { 8, "https://imgd.aeplcdn.com/600x600/cw/ec/18712/Tata-Nano-GenX-Exterior-122442.jpg?wm=0&q=75", "Tata Nano", 5, true },
                    { 9, "https://imgd.aeplcdn.com/1056x594/n/cw/ec/141115/creta-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1", "Hyundai Creta", 6, true },
                    { 10, "https://imgd.aeplcdn.com/1056x594/n/cw/ec/42355/xuv700-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1", "Mahindra XUV700", 6, true },
                    { 11, "https://imgd.aeplcdn.com/1056x594/n/yshbs0b_1641669.jpg?q=75", "Renault Triber", 7, true },
                    { 12, "https://imgd.aeplcdn.com/0x0/n/cw/ec/115777/2022-ertiga-exterior-right-front-three-quarter-3.jpeg?isig=0", "Maruti Suzuki Ertiga", 7, true },
                    { 13, "https://imgd.aeplcdn.com/1200x900/n/cw/ec/45245/datsun-redi-go-right-front-three-quarter19.jpeg?q=75", "Datsun Redi Go", 8, true },
                    { 14, "https://imgd.aeplcdn.com/1280x720/cw/ec/37095/BMW-Z4-Roadster-Right-Front-Three-Quarter-153914.jpg?wm=0&q=75", "BMW Z4", 9, true },
                    { 15, "https://imgd.aeplcdn.com/1200x900/n/cw/ec/53695/new-gen-celerio-exterior-right-front-three-quarter-2.jpeg?isig=0&q=75", "Maruti Suzuki Celerio", 10, true },
                    { 16, "https://imgd.aeplcdn.com/1200x900/n/cw/ec/54399/exterior-right-front-three-quarter-10.jpeg?q=75", "Maruti Suzuki Swift", 10, true },
                    { 17, "https://imgd.aeplcdn.com/0x0/n/cw/ec/41205/kia-carnival-right-front-three-quarter8.jpeg", "Kia Carnival", 11, true }
                });

            migrationBuilder.InsertData(
                table: "CarTypes",
                columns: new[] { "carTypeId", "carType", "isActive" },
                values: new object[,]
                {
                    { 1, "HatchBack", true },
                    { 2, "Sedan", true },
                    { 3, "Compact Sedan", true },
                    { 4, "Coupe", true },
                    { 5, "Micro Car", true },
                    { 6, "SUV", true },
                    { 7, "MPV", true },
                    { 8, "CrossOver", true },
                    { 9, "Convertible", true },
                    { 10, "City Car", true },
                    { 11, "MPV/Mini Van", true }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "cityId", "city", "isActive" },
                values: new object[,]
                {
                    { 1, "Mumbai", true },
                    { 2, "Pune", true },
                    { 3, "Kochi", true },
                    { 4, "Trivandrum", true },
                    { 5, "Bengaluru", true },
                    { 6, "Mysore", true },
                    { 7, "Chennai", true },
                    { 8, "Hyderabad", true },
                    { 9, "Jamshedpur", true },
                    { 10, "Indore", true },
                    { 11, "Delhi", true }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "driverId", "carModel", "driverEMail", "driverName", "driverPhone", "isActive" },
                values: new object[,]
                {
                    { 1, 1, "ben1@gmail.com", "Ben", 9871245678L, true },
                    { 2, 2, "john1@gmail.com", "John", 9811255678L, true },
                    { 3, 3, "kumar@gmail.com", "Kumar", 9991826780L, true },
                    { 4, 4, "adam@gmail.com", "Adam", 7869123410L, true },
                    { 5, 5, "donald@gmail.com", "Donald", 9867123401L, true },
                    { 6, 6, "paul@gmail.com", "Paul", 8079876518L, true },
                    { 7, 7, "rahim@gmail.com", "Rahim", 9813245167L, true },
                    { 8, 8, "gabriel@gmail.com", "Gabriel", 7124516789L, true },
                    { 9, 9, "kenny@gmail.com", "McKenny", 8971324510L, true },
                    { 10, 10, "ali@gmail.com", "Ali", 9124561789L, true },
                    { 11, 11, "curt@gmail.com", "Curt", 8712531230L, true },
                    { 12, 12, "alex@gmail.com", "Alex", 8919298126L, true },
                    { 13, 13, "joseph@gmail.com", "Joseph", 9018273581L, true },
                    { 14, 14, "buchan@gmail.com", "Buchan", 9871425617L, true },
                    { 15, 15, "amit@gmail.com", "Amit", 9182918239L, true },
                    { 16, 16, "anto@gmail.com", "Anto", 9809087867L, true },
                    { 17, 17, "antony@gmail.com", "Antony", 9871278910L, true }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "reviewId", "driverId", "rating", "userId" },
                values: new object[,]
                {
                    { 1, 4, 90, 2 },
                    { 2, 5, 80, 3 },
                    { 3, 2, 70, 4 },
                    { 4, 4, 76, 1 },
                    { 5, 7, 81, 5 },
                    { 6, 9, 65, 4 },
                    { 7, 16, 39, 5 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "isActive", "isAdmin", "isDriver", "password", "userEmail", "userName", "userPhone" },
                values: new object[,]
                {
                    { 1, true, true, false, "superuser@1", "super@yahoo.com", "superuser", 9812451267L },
                    { 2, true, false, true, "jane@1", "jane@yahoo.com", "jane", 5627189891L },
                    { 3, true, false, false, "mike@1", "mike@yahoo.com", "mike", 9812451267L },
                    { 4, true, false, false, "kennedy@1", "kennedy@yahoo.com", "kennedy", 9812451267L },
                    { 5, true, false, false, "piyush@1", "piyush@yahoo.com", "Piyush", 9812451267L },
                    { 6, true, false, false, "dwayne@1", "dwayne@yahoo.com", "Dwayne", 9812451267L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "CarTypes");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

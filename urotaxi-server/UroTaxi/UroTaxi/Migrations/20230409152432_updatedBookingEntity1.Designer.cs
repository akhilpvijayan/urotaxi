﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UroTaxi.Entities;

#nullable disable

namespace UroTaxi.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230409152432_updatedBookingEntity1")]
    partial class updatedBookingEntity1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UroTaxi.Entities.Booking", b =>
                {
                    b.Property<int>("bookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookingId"));

                    b.Property<int>("bookedUser")
                        .HasColumnType("int");

                    b.Property<int>("carModel")
                        .HasColumnType("int");

                    b.Property<int>("destination")
                        .HasColumnType("int");

                    b.Property<string>("dropAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("phone")
                        .HasColumnType("bigint");

                    b.Property<string>("pickUpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("pickUpDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("source")
                        .HasColumnType("int");

                    b.HasKey("bookingId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("UroTaxi.Entities.CarModel", b =>
                {
                    b.Property<int>("carModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("carModelId"));

                    b.Property<string>("carImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("carModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("carType")
                        .HasColumnType("int");

                    b.Property<int>("fuelType")
                        .HasColumnType("int");

                    b.Property<bool>("isAC")
                        .HasColumnType("bit");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<long>("minFare")
                        .HasColumnType("bigint");

                    b.Property<int>("seats")
                        .HasColumnType("int");

                    b.HasKey("carModelId");

                    b.ToTable("CarModels");

                    b.HasData(
                        new
                        {
                            carModelId = 1,
                            carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/32597/altroz-exterior-right-front-three-quarter-79.jpeg?isig=0&q=75&wm=1",
                            carModel = "Tata Altroz",
                            carType = 1,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 250L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 2,
                            carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/112839/glanza-facelift-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1",
                            carModel = "Toyota Glanza",
                            carType = 1,
                            fuelType = 2,
                            isAC = true,
                            isActive = true,
                            minFare = 280L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 3,
                            carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/26755/city-4th-generation-exterior-right-front-three-quarter.jpeg?q=75&wm=1",
                            carModel = "Honda City",
                            carType = 2,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 550L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 4,
                            carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/44088/slavia-exterior-right-front-three-quarter-5.jpeg?isig=0&q=75&wm=1",
                            carModel = "Skoda Slavia",
                            carType = 2,
                            fuelType = 3,
                            isAC = true,
                            isActive = true,
                            minFare = 450L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 5,
                            carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/45951/amaze-facelift-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1",
                            carModel = "Honda Amaze",
                            carType = 3,
                            fuelType = 2,
                            isAC = true,
                            isActive = true,
                            minFare = 400L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 6,
                            carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/46994/jaguar-f-type-right-front-three-quarter18.jpeg?q=75&wm=1",
                            carModel = "Jaguar F-Type",
                            carType = 4,
                            fuelType = 4,
                            isAC = true,
                            isActive = true,
                            minFare = 950L,
                            seats = 2
                        },
                        new
                        {
                            carModelId = 7,
                            carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/48034/2-series-gran-coupe-exterior-right-front-three-quarter.jpeg?q=75&wm=1",
                            carModel = "BMW 2-Series Gran Coupe",
                            carType = 4,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 1050L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 8,
                            carImage = "https://imgd.aeplcdn.com/600x600/cw/ec/18712/Tata-Nano-GenX-Exterior-122442.jpg?wm=0&q=75",
                            carModel = "Tata Nano",
                            carType = 5,
                            fuelType = 2,
                            isAC = true,
                            isActive = true,
                            minFare = 150L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 9,
                            carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/141115/creta-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1",
                            carModel = "Hyundai Creta",
                            carType = 6,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 300L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 10,
                            carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/42355/xuv700-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1",
                            carModel = "Mahindra XUV700",
                            carType = 6,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 800L,
                            seats = 7
                        },
                        new
                        {
                            carModelId = 11,
                            carImage = "https://imgd.aeplcdn.com/1056x594/n/yshbs0b_1641669.jpg?q=75",
                            carModel = "Renault Triber",
                            carType = 7,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 370L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 12,
                            carImage = "https://imgd.aeplcdn.com/0x0/n/cw/ec/115777/2022-ertiga-exterior-right-front-three-quarter-3.jpeg?isig=0",
                            carModel = "Maruti Suzuki Ertiga",
                            carType = 7,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 750L,
                            seats = 6
                        },
                        new
                        {
                            carModelId = 13,
                            carImage = "https://imgd.aeplcdn.com/1200x900/n/cw/ec/45245/datsun-redi-go-right-front-three-quarter19.jpeg?q=75",
                            carModel = "Datsun Redi Go",
                            carType = 8,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 250L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 14,
                            carImage = "https://imgd.aeplcdn.com/1280x720/cw/ec/37095/BMW-Z4-Roadster-Right-Front-Three-Quarter-153914.jpg?wm=0&q=75",
                            carModel = "BMW Z4",
                            carType = 9,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 1250L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 15,
                            carImage = "https://imgd.aeplcdn.com/1200x900/n/cw/ec/53695/new-gen-celerio-exterior-right-front-three-quarter-2.jpeg?isig=0&q=75",
                            carModel = "Maruti Suzuki Celerio",
                            carType = 10,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 350L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 16,
                            carImage = "https://imgd.aeplcdn.com/1200x900/n/cw/ec/54399/exterior-right-front-three-quarter-10.jpeg?q=75",
                            carModel = "Maruti Suzuki Swift",
                            carType = 10,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 280L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 17,
                            carImage = "https://imgd.aeplcdn.com/0x0/n/cw/ec/41205/kia-carnival-right-front-three-quarter8.jpeg",
                            carModel = "Kia Carnival",
                            carType = 11,
                            fuelType = 2,
                            isAC = true,
                            isActive = true,
                            minFare = 680L,
                            seats = 6
                        },
                        new
                        {
                            carModelId = 18,
                            carImage = "https://media.zigcdn.com/media/model/2022/Aug/tiago-new-1_930x620.jpg",
                            carModel = "Tata Tiago",
                            carType = 1,
                            fuelType = 1,
                            isAC = true,
                            isActive = true,
                            minFare = 250L,
                            seats = 4
                        },
                        new
                        {
                            carModelId = 19,
                            carImage = "https://media.zigcdn.com/media/model/2020/Nov/hyundai-i20-2_930x620.jpg",
                            carModel = "Hyundai i20",
                            carType = 1,
                            fuelType = 2,
                            isAC = true,
                            isActive = true,
                            minFare = 290L,
                            seats = 4
                        });
                });

            modelBuilder.Entity("UroTaxi.Entities.CarType", b =>
                {
                    b.Property<int>("carTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("carTypeId"));

                    b.Property<string>("carType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("carTypeId");

                    b.ToTable("CarTypes");

                    b.HasData(
                        new
                        {
                            carTypeId = 1,
                            carType = "HatchBack",
                            isActive = true
                        },
                        new
                        {
                            carTypeId = 2,
                            carType = "Sedan",
                            isActive = true
                        },
                        new
                        {
                            carTypeId = 3,
                            carType = "Compact Sedan",
                            isActive = true
                        },
                        new
                        {
                            carTypeId = 4,
                            carType = "Coupe",
                            isActive = true
                        },
                        new
                        {
                            carTypeId = 5,
                            carType = "Micro Car",
                            isActive = true
                        },
                        new
                        {
                            carTypeId = 6,
                            carType = "SUV",
                            isActive = true
                        },
                        new
                        {
                            carTypeId = 7,
                            carType = "MPV",
                            isActive = true
                        },
                        new
                        {
                            carTypeId = 8,
                            carType = "CrossOver",
                            isActive = true
                        },
                        new
                        {
                            carTypeId = 9,
                            carType = "Convertible",
                            isActive = true
                        },
                        new
                        {
                            carTypeId = 10,
                            carType = "City Car",
                            isActive = true
                        },
                        new
                        {
                            carTypeId = 11,
                            carType = "MPV/Mini Van",
                            isActive = true
                        });
                });

            modelBuilder.Entity("UroTaxi.Entities.City", b =>
                {
                    b.Property<int>("cityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cityId"));

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("cityId");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            cityId = 1,
                            city = "Mumbai",
                            isActive = true
                        },
                        new
                        {
                            cityId = 2,
                            city = "Pune",
                            isActive = true
                        },
                        new
                        {
                            cityId = 3,
                            city = "Kochi",
                            isActive = true
                        },
                        new
                        {
                            cityId = 4,
                            city = "Trivandrum",
                            isActive = true
                        },
                        new
                        {
                            cityId = 5,
                            city = "Bengaluru",
                            isActive = true
                        },
                        new
                        {
                            cityId = 6,
                            city = "Mysore",
                            isActive = true
                        },
                        new
                        {
                            cityId = 7,
                            city = "Chennai",
                            isActive = true
                        },
                        new
                        {
                            cityId = 8,
                            city = "Hyderabad",
                            isActive = true
                        },
                        new
                        {
                            cityId = 9,
                            city = "Jamshedpur",
                            isActive = true
                        },
                        new
                        {
                            cityId = 10,
                            city = "Indore",
                            isActive = true
                        },
                        new
                        {
                            cityId = 11,
                            city = "Delhi",
                            isActive = true
                        });
                });

            modelBuilder.Entity("UroTaxi.Entities.Driver", b =>
                {
                    b.Property<int>("driverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("driverId"));

                    b.Property<int>("carModel")
                        .HasColumnType("int");

                    b.Property<string>("driverEMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("driverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("driverPhone")
                        .HasColumnType("bigint");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("driverId");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            driverId = 1,
                            carModel = 1,
                            driverEMail = "ben1@gmail.com",
                            driverName = "Ben",
                            driverPhone = 9871245678L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 2,
                            carModel = 2,
                            driverEMail = "john1@gmail.com",
                            driverName = "John Moose",
                            driverPhone = 9811255678L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 3,
                            carModel = 3,
                            driverEMail = "kumar@gmail.com",
                            driverName = "Kumar",
                            driverPhone = 9991826780L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 4,
                            carModel = 4,
                            driverEMail = "adam@gmail.com",
                            driverName = "Adam",
                            driverPhone = 7869123410L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 5,
                            carModel = 5,
                            driverEMail = "donald@gmail.com",
                            driverName = "Donald",
                            driverPhone = 9867123401L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 6,
                            carModel = 6,
                            driverEMail = "paul@gmail.com",
                            driverName = "Paul",
                            driverPhone = 8079876518L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 7,
                            carModel = 7,
                            driverEMail = "rahim@gmail.com",
                            driverName = "Rahim",
                            driverPhone = 9813245167L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 8,
                            carModel = 8,
                            driverEMail = "gabriel@gmail.com",
                            driverName = "Gabriel",
                            driverPhone = 7124516789L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 9,
                            carModel = 9,
                            driverEMail = "kenny@gmail.com",
                            driverName = "McKenny",
                            driverPhone = 8971324510L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 10,
                            carModel = 10,
                            driverEMail = "ali@gmail.com",
                            driverName = "Ali",
                            driverPhone = 9124561789L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 11,
                            carModel = 11,
                            driverEMail = "curt@gmail.com",
                            driverName = "Curt",
                            driverPhone = 8712531230L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 12,
                            carModel = 12,
                            driverEMail = "alex@gmail.com",
                            driverName = "Alex",
                            driverPhone = 8919298126L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 13,
                            carModel = 13,
                            driverEMail = "joseph@gmail.com",
                            driverName = "Joseph",
                            driverPhone = 9018273581L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 14,
                            carModel = 14,
                            driverEMail = "buchan@gmail.com",
                            driverName = "Buchan",
                            driverPhone = 9871425617L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 15,
                            carModel = 15,
                            driverEMail = "amit@gmail.com",
                            driverName = "Amit",
                            driverPhone = 9182918239L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 16,
                            carModel = 16,
                            driverEMail = "anto@gmail.com",
                            driverName = "Anto",
                            driverPhone = 9809087867L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 17,
                            carModel = 17,
                            driverEMail = "antony@gmail.com",
                            driverName = "Antony",
                            driverPhone = 9871278910L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 18,
                            carModel = 18,
                            driverEMail = "gregory@gmail.com",
                            driverName = "Gregory",
                            driverPhone = 9871000010L,
                            isActive = true
                        },
                        new
                        {
                            driverId = 19,
                            carModel = 19,
                            driverEMail = "chris@gmail.com",
                            driverName = "Chris",
                            driverPhone = 9871111010L,
                            isActive = true
                        });
                });

            modelBuilder.Entity("UroTaxi.Entities.Fueltype", b =>
                {
                    b.Property<int>("fuelTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("fuelTypeId"));

                    b.Property<string>("fuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("fuelTypeId");

                    b.ToTable("fueltypes");

                    b.HasData(
                        new
                        {
                            fuelTypeId = 1,
                            fuelType = "Petrol",
                            isActive = true
                        },
                        new
                        {
                            fuelTypeId = 2,
                            fuelType = "Diesel",
                            isActive = true
                        },
                        new
                        {
                            fuelTypeId = 3,
                            fuelType = "Hybrid",
                            isActive = true
                        },
                        new
                        {
                            fuelTypeId = 4,
                            fuelType = "Electric",
                            isActive = true
                        });
                });

            modelBuilder.Entity("UroTaxi.Entities.Review", b =>
                {
                    b.Property<int>("reviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reviewId"));

                    b.Property<int>("driverId")
                        .HasColumnType("int");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("reviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            reviewId = 1,
                            driverId = 4,
                            rating = 90,
                            userId = 2
                        },
                        new
                        {
                            reviewId = 2,
                            driverId = 5,
                            rating = 80,
                            userId = 3
                        },
                        new
                        {
                            reviewId = 3,
                            driverId = 2,
                            rating = 70,
                            userId = 4
                        },
                        new
                        {
                            reviewId = 4,
                            driverId = 4,
                            rating = 76,
                            userId = 1
                        },
                        new
                        {
                            reviewId = 5,
                            driverId = 7,
                            rating = 81,
                            userId = 5
                        },
                        new
                        {
                            reviewId = 6,
                            driverId = 9,
                            rating = 65,
                            userId = 4
                        },
                        new
                        {
                            reviewId = 7,
                            driverId = 16,
                            rating = 39,
                            userId = 5
                        });
                });

            modelBuilder.Entity("UroTaxi.Entities.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isDriver")
                        .HasColumnType("bit");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userPhone")
                        .HasColumnType("bigint");

                    b.HasKey("userId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            userId = 1,
                            isActive = true,
                            isAdmin = true,
                            isDriver = false,
                            password = "superuser@1",
                            userEmail = "super@yahoo.com",
                            userName = "superuser",
                            userPhone = 9812451267L
                        },
                        new
                        {
                            userId = 2,
                            isActive = true,
                            isAdmin = false,
                            isDriver = true,
                            password = "jane@1",
                            userEmail = "jane@yahoo.com",
                            userName = "jane",
                            userPhone = 5627189891L
                        },
                        new
                        {
                            userId = 3,
                            isActive = true,
                            isAdmin = false,
                            isDriver = false,
                            password = "mike@1",
                            userEmail = "mike@yahoo.com",
                            userName = "mike",
                            userPhone = 9812451267L
                        },
                        new
                        {
                            userId = 4,
                            isActive = true,
                            isAdmin = false,
                            isDriver = false,
                            password = "kennedy@1",
                            userEmail = "kennedy@yahoo.com",
                            userName = "kennedy",
                            userPhone = 9812451267L
                        },
                        new
                        {
                            userId = 5,
                            isActive = true,
                            isAdmin = false,
                            isDriver = false,
                            password = "piyush@1",
                            userEmail = "piyush@yahoo.com",
                            userName = "Piyush",
                            userPhone = 9812451267L
                        },
                        new
                        {
                            userId = 6,
                            isActive = true,
                            isAdmin = false,
                            isDriver = false,
                            password = "dwayne@1",
                            userEmail = "dwayne@yahoo.com",
                            userName = "Dwayne",
                            userPhone = 9812451267L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
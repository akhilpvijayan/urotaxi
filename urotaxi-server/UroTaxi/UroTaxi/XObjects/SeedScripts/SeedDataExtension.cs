using Microsoft.EntityFrameworkCore;
using UroTaxi.Entities;

namespace UroTaxi.XObjects.SeedScripts
{
    public static class SeedDataExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Users
            modelBuilder.Entity<User>()
                .HasData(
                new User { userId = 1, userName = "superuser", password = "superuser@1", userEmail = "super@yahoo.com", userPhone = 9812451267, isAdmin = true, isDriver = false, isActive = true },
                new User { userId = 2, userName = "jane", password = "jane@1", userEmail = "jane@yahoo.com", userPhone = 5627189891, isAdmin = false, isDriver = true, isActive = true },
                new User { userId = 3, userName = "mike", password = "mike@1", userEmail = "mike@yahoo.com", userPhone = 9812451267, isAdmin = false, isDriver = false, isActive = true },
                new User { userId = 4, userName = "kennedy", password = "kennedy@1", userEmail = "kennedy@yahoo.com", userPhone = 9812451267, isAdmin = false, isDriver = false, isActive = true },
                new User { userId = 5, userName = "Piyush", password = "piyush@1", userEmail = "piyush@yahoo.com", userPhone = 9812451267, isAdmin = false, isDriver = false, isActive = true },
                new User { userId = 6, userName = "Dwayne", password = "dwayne@1", userEmail = "dwayne@yahoo.com", userPhone = 9812451267, isAdmin = false, isDriver = false, isActive = true }
                 );

            //Drivers
            modelBuilder.Entity<Driver>()
                .HasData(
                new Driver { driverId = 1, driverName = "Ben", driverPhone = 9871245678, driverEMail = "ben1@gmail.com", carModel = 1, isActive = true },
                new Driver { driverId = 2, driverName = "John Moose", driverPhone = 9811255678, driverEMail = "john1@gmail.com", carModel = 2, isActive = true },
                new Driver { driverId = 3, driverName = "Kumar", driverPhone = 9991826780, driverEMail = "kumar@gmail.com", carModel = 3, isActive = true },
                new Driver { driverId = 4, driverName = "Adam", driverPhone = 7869123410, driverEMail = "adam@gmail.com", carModel = 4, isActive = true },
                new Driver { driverId = 5, driverName = "Donald", driverPhone = 9867123401, driverEMail = "donald@gmail.com", carModel = 5, isActive = true },
                new Driver { driverId = 6, driverName = "Paul", driverPhone = 8079876518, driverEMail = "paul@gmail.com", carModel = 6, isActive = true },
                new Driver { driverId = 7, driverName = "Rahim", driverPhone = 9813245167, driverEMail = "rahim@gmail.com", carModel = 7, isActive = true },
                new Driver { driverId = 8, driverName = "Gabriel", driverPhone = 7124516789, driverEMail = "gabriel@gmail.com", carModel = 8, isActive = true },
                new Driver { driverId = 9, driverName = "McKenny", driverPhone = 8971324510, driverEMail = "kenny@gmail.com", carModel = 9, isActive = true },
                new Driver { driverId = 10, driverName = "Ali", driverPhone = 9124561789, driverEMail = "ali@gmail.com", carModel = 10, isActive = true },
                new Driver { driverId = 11, driverName = "Curt", driverPhone = 8712531230, driverEMail = "curt@gmail.com", carModel = 11, isActive = true },
                new Driver { driverId = 12, driverName = "Alex", driverPhone = 8919298126, driverEMail = "alex@gmail.com", carModel = 12, isActive = true },
                new Driver { driverId = 13, driverName = "Joseph", driverPhone = 9018273581, driverEMail = "joseph@gmail.com", carModel = 13, isActive = true },
                new Driver { driverId = 14, driverName = "Buchan", driverPhone = 9871425617, driverEMail = "buchan@gmail.com", carModel = 14, isActive = true },
                new Driver { driverId = 15, driverName = "Amit", driverPhone = 09182918239, driverEMail = "amit@gmail.com", carModel = 15, isActive = true },
                new Driver { driverId = 16, driverName = "Anto", driverPhone = 9809087867, driverEMail = "anto@gmail.com", carModel = 16, isActive = true },
                new Driver { driverId = 17, driverName = "Antony", driverPhone = 9871278910, driverEMail = "antony@gmail.com", carModel = 17, isActive = true }
                );

            //CarModels
            modelBuilder.Entity<CarModel>()
                .HasData(
                new CarModel { carModelId = 1, carModel = "Tata Altroz", carType = 1, carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/32597/altroz-exterior-right-front-three-quarter-79.jpeg?isig=0&q=75&wm=1", fuelType = 1, isAC = true, seats = 4, minFare = 250, isActive = true },
                new CarModel { carModelId = 2, carModel = "Toyota Glanza", carType = 1, carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/112839/glanza-facelift-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1", fuelType = 2, isAC = true, seats = 4, minFare = 280, isActive = true },
                new CarModel { carModelId = 3, carModel = "Honda City", carType = 2, carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/26755/city-4th-generation-exterior-right-front-three-quarter.jpeg?q=75&wm=1", fuelType = 1, isAC = true, seats = 4, minFare = 550, isActive = true },
                new CarModel { carModelId = 4, carModel = "Skoda Slavia", carType = 2, carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/44088/slavia-exterior-right-front-three-quarter-5.jpeg?isig=0&q=75&wm=1", fuelType = 3, isAC = true, seats = 4, minFare = 450, isActive = true },
                new CarModel { carModelId = 5, carModel = "Honda Amaze", carType = 3, carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/45951/amaze-facelift-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1", fuelType = 2, isAC = true, seats = 4, minFare = 400, isActive = true },
                new CarModel { carModelId = 6, carModel = "Jaguar F-Type", carType = 4, carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/46994/jaguar-f-type-right-front-three-quarter18.jpeg?q=75&wm=1", fuelType = 4, isAC = true, seats = 2, minFare = 950, isActive = true },
                new CarModel { carModelId = 7, carModel = "BMW 2-Series Gran Coupe", carType = 4, carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/48034/2-series-gran-coupe-exterior-right-front-three-quarter.jpeg?q=75&wm=1", fuelType = 1, isAC = true, seats = 4, minFare = 1050, isActive = true },
                new CarModel { carModelId = 8, carModel = "Tata Nano", carType = 5, carImage = "https://imgd.aeplcdn.com/600x600/cw/ec/18712/Tata-Nano-GenX-Exterior-122442.jpg?wm=0&q=75", fuelType = 2, isAC = true, seats = 4, minFare = 150, isActive = true },
                new CarModel { carModelId = 9, carModel = "Hyundai Creta", carType = 6, carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/141115/creta-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1", fuelType = 1, isAC = true, seats = 4, minFare = 300, isActive = true },
                new CarModel { carModelId = 10, carModel = "Mahindra XUV700", carType = 6, carImage = "https://imgd.aeplcdn.com/1056x594/n/cw/ec/42355/xuv700-exterior-right-front-three-quarter.jpeg?isig=0&q=75&wm=1", fuelType = 1, isAC = true, seats = 7, minFare = 800, isActive = true },
                new CarModel { carModelId = 11, carModel = "Renault Triber", carType = 7, carImage = "https://imgd.aeplcdn.com/1056x594/n/yshbs0b_1641669.jpg?q=75", fuelType = 1, isAC = true, seats = 4, minFare = 370, isActive = true },
                new CarModel { carModelId = 12, carModel = "Maruti Suzuki Ertiga", carType = 7, carImage = "https://imgd.aeplcdn.com/0x0/n/cw/ec/115777/2022-ertiga-exterior-right-front-three-quarter-3.jpeg?isig=0", fuelType = 1, isAC = true, seats = 6, minFare = 750, isActive = true },
                new CarModel { carModelId = 13, carModel = "Datsun Redi Go", carType = 8, carImage = "https://imgd.aeplcdn.com/1200x900/n/cw/ec/45245/datsun-redi-go-right-front-three-quarter19.jpeg?q=75", fuelType = 1, isAC = true, seats = 4, minFare = 250, isActive = true },
                new CarModel { carModelId = 14, carModel = "BMW Z4", carType = 9, carImage = "https://imgd.aeplcdn.com/1280x720/cw/ec/37095/BMW-Z4-Roadster-Right-Front-Three-Quarter-153914.jpg?wm=0&q=75", fuelType = 1, isAC = true, seats = 4, minFare = 1250, isActive = true },
                new CarModel { carModelId = 15, carModel = "Maruti Suzuki Celerio", carType = 10, carImage = "https://imgd.aeplcdn.com/1200x900/n/cw/ec/53695/new-gen-celerio-exterior-right-front-three-quarter-2.jpeg?isig=0&q=75", fuelType = 1, isAC = true, seats = 4, minFare = 350, isActive = true },
                new CarModel { carModelId = 16, carModel = "Maruti Suzuki Swift", carType = 10, carImage = "https://imgd.aeplcdn.com/1200x900/n/cw/ec/54399/exterior-right-front-three-quarter-10.jpeg?q=75", fuelType = 1, isAC = true, seats = 4, minFare = 280, isActive = true },
                new CarModel { carModelId = 17, carModel = "Kia Carnival", carType = 11, carImage = "https://imgd.aeplcdn.com/0x0/n/cw/ec/41205/kia-carnival-right-front-three-quarter8.jpeg", fuelType = 2, isAC = true, seats = 6, minFare = 680, isActive = true },
                new CarModel { carModelId = 18, carModel = "Tata Tiago", carType = 1, carImage = "https://media.zigcdn.com/media/model/2022/Aug/tiago-new-1_930x620.jpg", fuelType = 1, isAC = true, seats = 4, minFare = 250, isActive = true },
                new CarModel { carModelId = 19, carModel = "Hyundai i20", carType = 1, carImage = "https://media.zigcdn.com/media/model/2020/Nov/hyundai-i20-2_930x620.jpg", fuelType = 2, isAC = true, seats = 4, minFare = 290, isActive = true }
                );

            //Fueltypes
            modelBuilder.Entity<Fueltype>()
                .HasData(
                new Fueltype { fuelTypeId = 1, fuelType = "Petrol", isActive = true },
                new Fueltype { fuelTypeId = 2, fuelType = "Diesel", isActive = true },
                new Fueltype { fuelTypeId = 3, fuelType = "Hybrid", isActive = true },
                new Fueltype { fuelTypeId = 4, fuelType = "Electric", isActive = true }
                );

            //CarTypes
            modelBuilder.Entity<CarType>()
                .HasData(
                new CarType { carTypeId = 1, carType = "HatchBack", isActive = true },
                new CarType { carTypeId = 2, carType = "Sedan", isActive = true },
                new CarType { carTypeId = 3, carType = "Compact Sedan", isActive = true },
                new CarType { carTypeId = 4, carType = "Coupe", isActive = true },
                new CarType { carTypeId = 5, carType = "Micro Car", isActive = true },
                new CarType { carTypeId = 6, carType = "SUV", isActive = true },
                new CarType { carTypeId = 7, carType = "MPV", isActive = true },
                new CarType { carTypeId = 8, carType = "CrossOver", isActive = true },
                new CarType { carTypeId = 9, carType = "Convertible", isActive = true },
                new CarType { carTypeId = 10, carType = "City Car", isActive = true },
                new CarType { carTypeId = 11, carType = "MPV/Mini Van", isActive = true }
            );

            //Reviews
            modelBuilder.Entity<Review>()
                .HasData(
                new Review { reviewId = 1, userId = 2, rating = 90, driverId = 4 },
                new Review { reviewId = 2, userId = 3, rating = 80, driverId = 5 },
                new Review { reviewId = 3, userId = 4, rating = 70, driverId = 2 },
                new Review { reviewId = 4, userId = 1, rating = 76, driverId = 4 },
                new Review { reviewId = 5, userId = 5, rating = 81, driverId = 7 },
                new Review { reviewId = 6, userId = 4, rating = 65, driverId = 9 },
                new Review { reviewId = 7, userId = 5, rating = 39, driverId = 16 }
                );

            //Cities
            modelBuilder.Entity<City>()
                .HasData(
                new City { cityId = 1, city = "Mumbai", isActive = true },
                new City { cityId = 2, city = "Pune", isActive = true },
                new City { cityId = 3, city = "Kochi", isActive = true },
                new City { cityId = 4, city = "Trivandrum", isActive = true },
                new City { cityId = 5, city = "Bengaluru", isActive = true },
                new City { cityId = 6, city = "Mysore", isActive = true },
                new City { cityId = 7, city = "Chennai", isActive = true },
                new City { cityId = 8, city = "Hyderabad", isActive = true },
                new City { cityId = 9, city = "Jamshedpur", isActive = true },
                new City { cityId = 10, city = "Indore", isActive = true },
                new City { cityId = 11, city = "Delhi", isActive = true }
                );
        }
    }
}
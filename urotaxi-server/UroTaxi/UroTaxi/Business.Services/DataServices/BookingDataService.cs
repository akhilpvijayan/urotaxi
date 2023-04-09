using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using UroTaxi.Business.DataServices;
using UroTaxi.Business.Entities;
using UroTaxi.Business.Services.Dto;
using UroTaxi.Business.Services.Services;
using UroTaxi.Entities;
using UroTaxi.XObjects.ViewModels;

namespace UroTaxi.Business.Services.DataServices
{
    public class BookingDataService : IBookingDataService
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public BookingDataService(
            ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region public functions
        public async Task<List<BookingListDto>> GetAllBookings()
        {
            if (_applicationDbContext != null)
            {
                return await (from booking in _applicationDbContext.Bookings
                              from user in _applicationDbContext.Users
                              from city in _applicationDbContext.City
                              from city1 in _applicationDbContext.City
                              from carModel in _applicationDbContext.CarModels
                              from carType in _applicationDbContext.CarTypes
                              from driver in _applicationDbContext.Drivers
                              from fuelType in _applicationDbContext.fueltypes
                              where fuelType.fuelTypeId == carModel.fuelType
                              where carType.carTypeId == carModel.carType
                              where driver.carModel == carModel.carModelId
                              where user.userId == booking.bookedUser
                              where city.cityId == booking.source
                              where booking.carModel == carModel.carModelId
                              where city1.cityId == booking.destination
                              where carModel.isActive == true

                              select new BookingListDto
                              {
                                  bookingId = booking.bookingId,
                                  name = booking.name,
                                  source = city.city,
                                  destination = city1.city,
                                  pickUpAddress= booking.pickUpAddress,
                                  pickUpDate = booking.pickUpDate,
                                  phone = booking.phone,
                                  email = booking.email,
                                  dropAddress =booking.dropAddress,
                                  bookedUser = user.userName,
                                  carModelId = carModel.carModelId,
                                  carName = carModel.carModel,
                                  carTypeId = carModel.carType,
                                  carType = carType.carType,
                                  carImage = carModel.carImage,
                                  fuelType = fuelType.fuelType,
                                  minFare = carModel.minFare,
                                  seats = carModel.seats,
                                  ac = carModel.isAC,
                                  driverId = driver.driverId,
                                  driverName = driver.driverName,
                                  driverEmail = driver.driverEMail,
                                  driverPhone = driver.driverPhone
                              }
                                ).ToListAsync();
            }
            return null;
        }
        public async Task<List<BookingDetailDto>> GetBookingDetail(int carModelId)
        {
            return await(from carType in _applicationDbContext.CarTypes
                         from carModel in _applicationDbContext.CarModels
                         from driver in _applicationDbContext.Drivers
                         from fuelTypes in _applicationDbContext.fueltypes
                         where carModel.carModelId == carModelId
                         where fuelTypes.fuelTypeId == carModel.fuelType
                         where driver.carModel == carModel.carModelId
                         where carType.carTypeId ==carModel.carType

                         select new BookingDetailDto
                         {
                             carModelId = carModel.carModelId,
                             carName = carModel.carModel,
                             carTypeId = carType.carTypeId,
                             carType = carType.carType,
                             ac = carModel.isAC ? "AC" : "Non-AC",
                             seats = carModel.seats,
                             carImage = carModel.carImage,
                             fare = carModel.minFare,
                             fuelType = fuelTypes.fuelType,
                             driverId = driver.driverId,
                             driverName = driver.driverName,
                             driverEmail = driver.driverEMail,
                             driverPhone= driver.driverPhone
                         }
                                ).ToListAsync();
        }

        public async Task<int> AddBooking(Booking booking)
        {
            if (_applicationDbContext != null)
            {
                await _applicationDbContext.Bookings.AddAsync(booking);
                await _applicationDbContext.SaveChangesAsync();
                return booking.bookingId;
            }
            return 0;
        }

        public async Task<Booking> DeleteBooking(int bookingId)
        {
            var result = await _applicationDbContext.Bookings
                .FirstOrDefaultAsync(e => e.bookingId == bookingId);
            if (result != null)
            {
                _applicationDbContext.Bookings.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }
        #endregion
    }
}

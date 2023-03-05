using Microsoft.EntityFrameworkCore;
using System.Linq;
using UroTaxi.Business.DataServices;
using UroTaxi.Business.Entities;
using UroTaxi.Business.Services.Dto;
using UroTaxi.Entities;

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
        #endregion
    }
}

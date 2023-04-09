using Microsoft.AspNetCore.Mvc;
using UroTaxi.Business.DataServices;
using UroTaxi.Business.Services.Dto;
using UroTaxi.Entities;

namespace UroTaxi.Business.Services.Services
{
    public class BookingService : IBookingService
    {
        #region Private Functions
        private readonly IBookingDataService _bookingDataService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public BookingService(
            IBookingDataService bookingDataService,
            ApplicationDBContext applicationDbContext)
        {
            _bookingDataService = bookingDataService;
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region public functions

        public Task<List<BookingListDto>> GetAllBookings()
        {
            return _bookingDataService.GetAllBookings();
        }
        public Task<List<BookingDetailDto>> GetBookingDetail(int carModelId)
        {
            return _bookingDataService.GetBookingDetail(carModelId);
        }

        public Task<int> AddBooking(Booking booking)
        {
            return _bookingDataService.AddBooking(booking);
        }
        public Task<Booking> DeleteBooking(int bookingId)
        {
            return _bookingDataService.DeleteBooking(bookingId);
        }
        #endregion
    }
}

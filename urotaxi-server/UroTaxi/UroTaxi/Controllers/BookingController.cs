using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UroTaxi.Business.Services;
using UroTaxi.Business.Services.Dto;
using UroTaxi.Entities;

namespace UroTaxi.Controllers
{
    public class BookingController : ControllerBase
    {
        #region Private Functions
        private readonly IBookingService _bookingService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public BookingController(
            IBookingService bookingService,
            ApplicationDBContext applicationDbContext)
        {
            _bookingService = bookingService;
            _applicationDbContext = applicationDbContext;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("bookings")]
        [ProducesResponseType(typeof(Booking), 200)]
        [ProducesResponseType(404)]
        public Task<List<Booking>> GetAllBookings()
        {
            return _applicationDbContext.Bookings.ToListAsync();
        }

        [HttpGet]
        [Route("booking/detail/{carModelId}")]
        [ProducesResponseType(typeof(Booking), 200)]
        [ProducesResponseType(404)]
        public Task<List<BookingDetailDto>> GetBookingDetail(int carModelId)
        {
            return _bookingService.GetBookingDetail(carModelId);
        }


        [HttpPost]
        [Route("booking")]
        [ProducesResponseType(typeof(Booking), 200)]
        [ProducesResponseType(404)]
        public Task<int> AddBooking([FromBody]  Booking booking)
        {
            return _bookingService.AddBooking(booking);
        }
        #endregion
    }
}

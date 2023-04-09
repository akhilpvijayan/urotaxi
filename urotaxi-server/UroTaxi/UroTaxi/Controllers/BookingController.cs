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
        public Task<List<BookingListDto>> GetAllBookings()
        {
            return _bookingService.GetAllBookings();
        }

        [HttpGet]
        [Route("bookings/{userId}")]
        [ProducesResponseType(typeof(Booking), 200)]
        [ProducesResponseType(404)]
        public Task<List<Booking>> GetAllBookingsByUser(int userId)
        {
            return _applicationDbContext.Bookings.Where(s => s.bookedUser == userId).ToListAsync();
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

        [HttpDelete]
        [Route("booking/{bookingId}")]
        [ProducesResponseType(typeof(Booking), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Booking>> DeleteBooking(int bookingId)
        {
            try
            {
                var employeeToDelete = await _bookingService.GetBookingDetail(bookingId);

                if (employeeToDelete == null)
                {
                    return NotFound($"Booking not found");
                }

                return await _bookingService.DeleteBooking(bookingId);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
        #endregion
    }
}

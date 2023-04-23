using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System.Text;
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
        private readonly IDistributedCache _cache;
        #endregion

        #region Constructors
        public BookingController(
            IBookingService bookingService,
            ApplicationDBContext applicationDbContext, IDistributedCache cache)
        {
            _bookingService = bookingService;
            _applicationDbContext = applicationDbContext;
            _cache = cache;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("bookings")]
        [ProducesResponseType(typeof(Booking), 200)]
        [ProducesResponseType(404)]
        public async Task<List<BookingListDto>> GetAllBookings()
        {
            // Trying to get data from the Redis cache
            byte[] cachedData = await _cache.GetAsync("booking");
            List<BookingListDto> booking = new();
            if (cachedData != null)
            {
                // If the data is found in the cache, encode and deserialize cached data.
                var cachedDataString = Encoding.UTF8.GetString(cachedData);
                booking = JsonSerializer.Deserialize<List<BookingListDto>>(cachedDataString);
            }
            else
            {
                // If the data is not found in the cache, then fetch data from database
                booking = await _bookingService.GetAllBookings();

                // Serializing the data
                string cachedDataString = JsonSerializer.Serialize(booking);
                var dataToCache = Encoding.UTF8.GetBytes(cachedDataString);

                // Setting up the cache options
                DistributedCacheEntryOptions options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(10));

                // Add the data into the cache
                await _cache.SetAsync("booking", dataToCache, options);
            }
            return booking;
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
            _cache.RemoveAsync("booking");
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
                _cache.RemoveAsync("booking");
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

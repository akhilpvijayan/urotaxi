using Microsoft.EntityFrameworkCore;
using UroTaxi.Business.DataServices;
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
        public Task<List<BookingDetailsDto>> GetBookingDetail(int carModelId)
        {
            var bookings = _applicationDbContext.CarTypes.FromSqlRaw("GetBookingDetails {0}", carModelId);
            return null;
        }
        #endregion
    }
}

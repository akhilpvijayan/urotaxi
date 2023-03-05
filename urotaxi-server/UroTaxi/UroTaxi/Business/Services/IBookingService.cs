using UroTaxi.Business.Services.Dto;
using UroTaxi.Entities;

namespace UroTaxi.Business.Services
{
    public interface IBookingService
    {
        Task<List<BookingDetailDto>> GetBookingDetail(int carModelId);
        Task<int> AddBooking(Booking booking);
    }
}

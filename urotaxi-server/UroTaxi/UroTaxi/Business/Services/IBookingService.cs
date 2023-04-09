using UroTaxi.Business.Services.Dto;
using UroTaxi.Entities;

namespace UroTaxi.Business.Services
{
    public interface IBookingService
    {
        Task<List<BookingListDto>> GetAllBookings();
        Task<List<BookingDetailDto>> GetBookingDetail(int carModelId);
        Task<int> AddBooking(Booking booking);
        Task<Booking> DeleteBooking(int bookingId);
    }
}


using UroTaxi.Business.Services.Dto;
using UroTaxi.Entities;

namespace UroTaxi.Business.DataServices
{
    public interface IBookingDataService
    {
        Task<List<BookingListDto>> GetAllBookings();
        Task<List<BookingDetailDto>> GetBookingDetail(int carModelId);
        Task<int> AddBooking(Booking booking);
        Task<Booking> DeleteBooking(int bookingId);
    }
}

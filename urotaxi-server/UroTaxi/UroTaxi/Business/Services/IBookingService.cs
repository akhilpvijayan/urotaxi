using UroTaxi.Business.Services.Dto;

namespace UroTaxi.Business.Services
{
    public interface IBookingService
    {
        Task<List<BookingDetailsDto>> GetBookingDetail(int carModelId);
    }
}

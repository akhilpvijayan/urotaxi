using UroTaxi.Business.Services.Dto;

namespace UroTaxi.Business.Services
{
    public interface IBookingService
    {
        Task<List<BookingDetailDto>> GetBookingDetail(int carModelId);
    }
}

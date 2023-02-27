
using UroTaxi.Business.Services.Dto;

namespace UroTaxi.Business.DataServices
{
    public interface IBookingDataService
    {
        Task<List<BookingDetailDto>> GetBookingDetail(int carModelId);
    }
}

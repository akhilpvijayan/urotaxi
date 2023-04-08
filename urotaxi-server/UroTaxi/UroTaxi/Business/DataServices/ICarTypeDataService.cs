using UroTaxi.Entities;

namespace UroTaxi.Business.DataServices
{
    public interface ICarTypeDataService
    {
        Task<int> AddCarType(CarType carType);
        Task<int> DeleteCarType(int id);
        Task<int> RestoreCarType(int id);
    }
}

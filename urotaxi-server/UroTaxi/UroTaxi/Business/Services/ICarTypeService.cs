using UroTaxi.Entities;

namespace UroTaxi.Business.Services
{
    public interface ICarTypeService
    {
        Task<int> AddCarType(CarType carType);
        Task<int> DeleteCarType(int id);
        Task<int> RestoreCarType(int id);
    }
}

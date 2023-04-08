using UroTaxi.Entities;

namespace UroTaxi.Business.Services
{
    public interface ICityService
    {
        Task<int> AddCity(City city);
        Task<int> DeleteCity(int id);
        Task<int> RestoreCity(int id);
    }
}

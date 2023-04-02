using UroTaxi.Entities;

namespace UroTaxi.Business.Services
{
    public interface ICityService
    {
        Task<int> AddCity(City city);
        Task<int> AddCity(City city);
        Task<int> RestoreCity(int id);
    }
}

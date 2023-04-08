using UroTaxi.Entities;

namespace UroTaxi.Business.DataServices
{
    public interface ICityDataService
    {
        Task<int> AddCity(City city);
        Task<int> DeleteCity(int id);
        Task<int> RestoreCity(int id);
    }
}

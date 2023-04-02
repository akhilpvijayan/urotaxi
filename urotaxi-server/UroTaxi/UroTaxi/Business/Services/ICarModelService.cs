using UroTaxi.Entities;
using UroTaxi.XObjects.ViewModels;

namespace UroTaxi.Business.Services
{
    public interface ICarModelService
    {
        Task<List<CarModelsViewModel>> GetAllCarModelVM();
        Task<int> AddCarModel(CarModel carModel);
        Task<int> DeleteCarModel(int id);
        Task<int> RestoreCarModel(int id);
    }
}

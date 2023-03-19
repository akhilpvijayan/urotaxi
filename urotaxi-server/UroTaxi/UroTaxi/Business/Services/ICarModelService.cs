using UroTaxi.XObjects.ViewModels;

namespace UroTaxi.Business.Services
{
    public interface ICarModelService
    {
        Task<List<CarModelsViewModel>> GetAllCarModelVM();
        Task<int> DeleteCarModel(int id);
        Task<int> RestoreCarModel(int id);
    }
}

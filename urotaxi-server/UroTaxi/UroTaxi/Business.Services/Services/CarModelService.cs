using UroTaxi.Business.DataServices;
using UroTaxi.Entities;
using UroTaxi.XObjects.ViewModels;

namespace UroTaxi.Business.Services.Services
{
    public class CarModelService : ICarModelService
    {
        #region Private Functions
        private readonly ICarModelDataService _carModelDataService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public CarModelService(
            ICarModelDataService carModelDataService,
            ApplicationDBContext applicationDbContext)
        {
            _carModelDataService = carModelDataService;
            _applicationDbContext = applicationDbContext;
        }

        #endregion
        #region public functions
        public Task<List<CarModelsViewModel>> GetAllCarModelVM()
        {
            return _carModelDataService.GetAllCarModelVM();
        }

        public Task<int> DeleteCarModel(int id)
        {
            return _carModelDataService.DeleteCarModel(id);
        }

        public Task<int> RestoreCarModel(int id)
        {
            return _carModelDataService.RestoreCarModel(id);
        }
        #endregion
    }
}

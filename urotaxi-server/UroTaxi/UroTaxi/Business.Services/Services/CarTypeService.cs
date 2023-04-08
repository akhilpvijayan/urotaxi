using UroTaxi.Business.DataServices;
using UroTaxi.Entities;
using UroTaxi.XObjects.ViewModels;

namespace UroTaxi.Business.Services.Services
{
    public class CarTypeService : ICarTypeService
    {
        #region Private Functions
        private readonly ICarTypeDataService _carTypeDataService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public CarTypeService(
            ICarTypeDataService carTypeDataService,
            ApplicationDBContext applicationDbContext)
        {
            _carTypeDataService = carTypeDataService;
            _applicationDbContext = applicationDbContext;
        }

        #endregion
        #region public functions
        public Task<int> AddCarType(CarType carType)
        {
            return _carTypeDataService.AddCarType(carType);
        }

        public Task<int> DeleteCarType(int id)
        {
            return _carTypeDataService.DeleteCarType(id);
        }

        public Task<int> RestoreCarType(int id)
        {
            return _carTypeDataService.RestoreCarType(id);
        }
        #endregion
    }
}

using UroTaxi.Business.DataServices;
using UroTaxi.Business.Services.DataServices;
using UroTaxi.Entities;
using UroTaxi.XObjects.ViewModels;

namespace UroTaxi.Business.Services.Services
{
    public class CityService : ICityService
    {
        #region Private Functions
        private readonly ICityDataService _cityDataService;
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public CityService(
            ICityDataService cityDataService,
            ApplicationDBContext applicationDbContext)
        {
            _cityDataService = cityDataService;
            _applicationDbContext = applicationDbContext;
        }

        #endregion
        #region public functions
        public Task<int> AddCity(City city)
        {
            return _cityDataService.AddCity(city);
        }
        public Task<int> DeleteCity(int id)
        {
            return _cityDataService.DeleteCity(id);
        }

        public Task<int> RestoreCity(int id)
        {
            return _cityDataService.RestoreCity(id);
        }
        #endregion

    }
}

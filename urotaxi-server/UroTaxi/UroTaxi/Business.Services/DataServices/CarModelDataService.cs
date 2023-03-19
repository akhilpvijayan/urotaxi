using Microsoft.EntityFrameworkCore;
using UroTaxi.Business.DataServices;
using UroTaxi.Entities;
using UroTaxi.XObjects.ViewModels;

namespace UroTaxi.Business.Services.DataServices
{
    public class CarModelDataService : ICarModelDataService
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public CarModelDataService(
            ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region public functions

        public async Task<List<CarModelsViewModel>> GetAllCarModelVM()
        {
            if (_applicationDbContext != null)
            {
                return await (from carModel in _applicationDbContext.CarModels
                              from carType in _applicationDbContext.CarTypes
                              from fuelType in _applicationDbContext.fueltypes
                              where fuelType.fuelTypeId == carModel.fuelType
                              where carType.carTypeId == carModel.carType
                              where carModel.isActive == true

                              select new CarModelsViewModel
                              {
                                  carModelId = carModel.carModelId,
                                  carModel = carModel.carModel,
                                  carType = carType.carType,
                                  carImage = carModel.carImage,
                                  fuelType = fuelType.fuelType,
                                  minFare = carModel.minFare,
                                  seats = carModel.seats
                              }
                                ).ToListAsync();
            }
            return null;
        }

        public async Task<int> DeleteCarModel(int id)
        {
            if (_applicationDbContext != null)
            {
                var itemToRemove = _applicationDbContext.CarModels.SingleOrDefault(x => x.carModelId == id);

                if (itemToRemove != null)
                {
                    itemToRemove.isActive = false;
                    await _applicationDbContext.SaveChangesAsync();
                    return id;
                }
                return 0;
            }
            return 0;
        }

        public async Task<int> RestoreCarModel(int id)
        {
            if (_applicationDbContext != null)
            {
                var itemToRemove = _applicationDbContext.CarModels.SingleOrDefault(x => x.carModelId == id);

                if (itemToRemove != null)
                {
                    itemToRemove.isActive = true;
                    await _applicationDbContext.SaveChangesAsync();
                    return id;
                }
                return 0;
            }
            return 0;
        }
        #endregion
    }
}

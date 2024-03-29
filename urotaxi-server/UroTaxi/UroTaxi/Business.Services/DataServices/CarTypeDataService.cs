﻿using UroTaxi.Business.DataServices;
using UroTaxi.Entities;
using UroTaxi.XObjects.ViewModels;

namespace UroTaxi.Business.Services.DataServices
{
    public class CarTypeDataService : ICarTypeDataService
    {
        #region Private Functions
        private readonly ApplicationDBContext _applicationDbContext;
        #endregion

        #region Constructors
        public CarTypeDataService(
            ApplicationDBContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        #endregion
        #region public functions
        public async Task<int> AddCarType(CarType carType)
        {
            if (_applicationDbContext != null)
            {
                await _applicationDbContext.CarTypes.AddAsync(carType);
                await _applicationDbContext.SaveChangesAsync();
                return carType.carTypeId;
            }
            return 0;
        }

        public async Task<int> DeleteCarType(int id)
        {
            if (_applicationDbContext != null)
            {
                var itemToRemove = _applicationDbContext.CarTypes.SingleOrDefault(x => x.carTypeId == id);

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

        public async Task<int> RestoreCarType(int id)
        {
            if (_applicationDbContext != null)
            {
                var itemToRemove = _applicationDbContext.CarTypes.SingleOrDefault(x => x.carTypeId == id);

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

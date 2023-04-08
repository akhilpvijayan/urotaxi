using UroTaxi.Business.DataServices;
using UroTaxi.Entities;

namespace UroTaxi.Business.Services.DataServices
{
    public class CityDataService : ICityDataService
    {
            #region Private Functions
            private readonly ApplicationDBContext _applicationDbContext;
            #endregion

            #region Constructors
            public CityDataService(
                ApplicationDBContext applicationDbContext)
            {
                _applicationDbContext = applicationDbContext;
            }
            #endregion
            #region public functions

            public async Task<int> AddCity(City city)
            {
                if (_applicationDbContext != null)
                {
                    await _applicationDbContext.City.AddAsync(city);
                    await _applicationDbContext.SaveChangesAsync();
                    return city.cityId;
                }
                return 0;
            }

            public async Task<int> DeleteCity(int id)
            {
                if (_applicationDbContext != null)
                {
                    var itemToRemove = _applicationDbContext.City.SingleOrDefault(x => x.cityId == id);

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

            public async Task<int> RestoreCity(int id)
            {
                if (_applicationDbContext != null)
                {
                    var itemToRemove = _applicationDbContext.City.SingleOrDefault(x => x.cityId == id);

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


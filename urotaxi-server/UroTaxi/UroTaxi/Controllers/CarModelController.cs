using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System.Text;
using UroTaxi.Business.Entities;
using UroTaxi.Business.Services;
using UroTaxi.Entities;
using UroTaxi.XObjects.ViewModels;
using StackExchange.Redis;

namespace UroTaxi.Controllers
{
    [ApiController]
    public class CarModelController : ControllerBase
    {

        #region Private Functions
        private readonly ICarModelService _carModelService;
        private readonly ApplicationDBContext _applicationDbContext;
        private readonly IDistributedCache _cache;
        #endregion

        #region Constructors
        public CarModelController(
            ICarModelService carModelService,
            ApplicationDBContext applicationDbContext, IDistributedCache cache)
        {
            _carModelService = carModelService;
            _applicationDbContext = applicationDbContext;
            _cache = cache;
        }
        #endregion

        #region Public Functions
        [HttpGet]
        [Route("carmodel")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public async Task<List<CarModel>> GetAllCarModels()
        {
            // Trying to get data from the Redis cache
            byte[] cachedData = await _cache.GetAsync("carModel");
            List<CarModel> carModel = new();
            if (cachedData != null)
            {
                // If the data is found in the cache, encode and deserialize cached data.
                var cachedDataString = Encoding.UTF8.GetString(cachedData);
                carModel = JsonSerializer.Deserialize<List<CarModel>>(cachedDataString);
            }
            else
            {
                // If the data is not found in the cache, then fetch data from database
                carModel = await _applicationDbContext.CarModels.Where(x => x.isActive == true).ToListAsync();

                // Serializing the data
                string cachedDataString = JsonSerializer.Serialize(carModel);
                var dataToCache = Encoding.UTF8.GetBytes(cachedDataString);

                // Setting up the cache options
                DistributedCacheEntryOptions options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(10));

                // Add the data into the cache
                await _cache.SetAsync("carModel", dataToCache, options);
            }
            return carModel;
        }

        [HttpGet]
        [Route("carmodel/{carTypeId}")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public Task<List<CarModel>> GetCarModels(int carTypeId)
        {
            return _applicationDbContext.CarModels.Where(s=>s.carType == carTypeId).ToListAsync();
        }

        [HttpGet("carmodels")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IEnumerable<CarModelsViewModel>>> GetAllCarModelVM()
        {
            // Trying to get data from the Redis cache
            byte[] cachedData = await _cache.GetAsync("carModelsViewModel");
            List<CarModelsViewModel> carModel = new();
            if (cachedData != null)
            {
                // If the data is found in the cache, encode and deserialize cached data.
                var cachedDataString = Encoding.UTF8.GetString(cachedData);
                carModel = JsonSerializer.Deserialize<List<CarModelsViewModel>>(cachedDataString);
            }
            else
            {
                // If the data is not found in the cache, then fetch data from database
                carModel = await _carModelService.GetAllCarModelVM();

                // Serializing the data
                string cachedDataString = JsonSerializer.Serialize(carModel);
                var dataToCache = Encoding.UTF8.GetBytes(cachedDataString);

                // Setting up the cache options
                DistributedCacheEntryOptions options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(10));

                // Add the data into the cache
                await _cache.SetAsync("carModelsViewModel", dataToCache, options);
            }
            return carModel;
        }

        [HttpPost]
        [Route("carmodel")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public Task<int> AddCarModel([FromBody] CarModel carModel)
        {
            _cache.RemoveAsync("carModel");
            _cache.RemoveAsync("carModelsViewModel");
            return _carModelService.AddCarModel(carModel);
        }

        [HttpPut("carmodel/restore/{id}")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RestoreCarModel(int id)
        {
            var uId = await _carModelService.RestoreCarModel(id);
            if (uId == 0)
            {
                return NotFound();
            }
            _cache.RemoveAsync("carModel");
            _cache.RemoveAsync("carModelsViewModel");
            return Ok(uId);
        }

        [HttpDelete("carmodel/{id}")]
        [ProducesResponseType(typeof(CarModel), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteCarModel(int id)
        {
            var uId = await _carModelService.DeleteCarModel(id);
            if (uId == 0)
            {
                return NotFound();
            }
            _cache.RemoveAsync("carModel");
            _cache.RemoveAsync("carModelsViewModel");
            return Ok(uId);
        }

        #endregion
    }
}
